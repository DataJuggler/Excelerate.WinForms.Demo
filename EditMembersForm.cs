﻿

#region using statements

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataJuggler.Excelerate;
using Demo.Objects;
using DataJuggler.UltimateHelper;
using DataJuggler.UltimateHelper.Objects;
using Demo.Enumerations;
using DataJuggler.Win.Controls;
using DataJuggler.Win.Controls.Interfaces;

#endregion

namespace Demo
{

    #region class EditMembersForm
    /// <summary>
    /// This class is used to edit members and member's addresses
    /// </summary>
    public partial class EditMembersForm : Form, ITextChanged
    {
        
        #region Private Variables
        private List<Member> members;
        private List<Address> addresses;
        private List<State> states;
        private bool firstActivationComplete;
        private Row stateHeaderRow;
        private Row addressHeaderRow;
        private DateTime filterTypedTime;
        private Member selectedMember;
        private EditModeEnum editMode;
        private Workbook workbook;
        private int membersIndex;
        private int addressIndex;
        private int statesIndex;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'EditMembersForm' object.
        /// </summary>
        public EditMembersForm()
        {
            // Create Controls
            InitializeComponent();

            // Setup the listener
            FilterTextBox.OnTextChangedListener = this;
            EditMode = EditModeEnum.NothingSelected;
        }
        #endregion

        #region Events

            #region AddButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'AddButton' is clicked.
            /// </summary>
            private void AddButton_Click(object sender, EventArgs e)
            {
                // Create a new instance of a 'Member' object.
                Member member = new Member();

                // Get the highest MemberId + 1
                member.Id = GetMaxMemberId() + 1;
                
                // set the selected member
                SelectedMember = member;

                // Display the new member (only the Id is set so far)
                DisplaySelectedMember();

                // Setup the UI
                EditMode = EditModeEnum.AddNew;

                // Enable or disable controls
                UIEnable();

                // Set Focus to the text box
                FirstNameEditControl.SetFocusToTextBox();
            }
            #endregion
            
            #region EditMembersForm_Activated(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Edit Members Form _ Activated
            /// </summary>
            private void EditMembersForm_Activated(object sender, EventArgs e)
            {
                // if the value for FirstActivationComplete is false
                if (!FirstActivationComplete)
                {
                    // Only fire once
                    FirstActivationComplete = true;

                    // Load all the data
                    LoadAllData();

                    // Load the Filter options
                    FilterComboBox.LoadItems(typeof(FilterByEnum));
                    FilterComboBox.SelectedIndex = FilterComboBox.FindItemIndexByValue("Starts With");

                    // Load the listbox with the first 50 items
                    DisplayMembers();
                }
            }
            #endregion
            
            #region FilterTimer_Tick(object sender, EventArgs e)
            /// <summary>
            /// event is fired when Filter Timer _ Tick
            /// </summary>
            private void FilterTimer_Tick(object sender, EventArgs e)
            {   
                // Get the time now
                DateTime now = DateTime.Now;

                // get the elapsed milliseconds
                double elapsed = (now - filterTypedTime).TotalMilliseconds;

                // if more than 300 milliseconds has passed
                if (elapsed >= 300)
                {
                    // Stop the timer
                    FilterTimer.Stop();

                    // Get the text box
                    string filterText = FilterTextBox.Text;

                    // Display the members with this filter
                    DisplayMembers(filterText);
                }
            }
            #endregion
            
            #region MembersListBox_SelectedIndexChanged(object sender, EventArgs e)
            /// <summary>
            /// event is fired when a selection is made in the 'MembersListBox_'.
            /// </summary>
            private void MembersListBox_SelectedIndexChanged(object sender, EventArgs e)
            {
                // Set the SelectedMember
                SelectedMember = MembersListBox.SelectedItem as Member;

                // if the SelectedMember Exists, does not have an Address, and the Addresses collection exists
                if ((HasSelectedMember) && (!SelectedMember.HasAddress) && (ListHelper.HasOneOrMoreItems(Addresses)))
                {
                    // Find the Address
                    SelectedMember.Address = Addresses.FirstOrDefault(x => x.MemberId == SelectedMember.Id);

                    // if the Address does not exist
                    if (!SelectedMember.HasAddress)
                    {
                        // Create a new instance of an 'Address' object.
                        SelectedMember.Address = new Address();
                    }
                }

                // Display the selected member
                DisplaySelectedMember();

                // Set to Read Only
                EditMode = EditModeEnum.ReadOnly;

                // Enable or disable controls
                UIEnable();
            }
            #endregion
            
            #region OnTextChanged(Control sender, string text)
            /// <summary>
            /// event is fired when On Text Changed
            /// </summary>
            public void OnTextChanged(Control sender, string text)
            {
                // If the text string exists
                if (TextHelper.Exists(text))
                {
                    // Store the last typed time
                    FilterTypedTime = DateTime.Now;

                    // Start the Timer
                    FilterTimer.Start();
                }
            }
            #endregion
            
            #region SaveButton_Click(object sender, EventArgs e)
            /// <summary>
            /// event is fired when the 'SaveButton' is clicked.
            /// </summary>
            private void SaveButton_Click(object sender, EventArgs e)
            {
                // Capture the SelectedMember
                CaptureSelectedMember();

                // Is the current member valid
                bool isValid = ValidateMember();

                // local
                Row row = null;

                // if valid (if not the Status label is updated above
                if ((isValid) && (HasWorkbook) && (MembersIndex >= 0) && (ListHelper.HasXOrMoreItems(Workbook.Worksheets, MembersIndex + 1)))
                {
                    // Get the worksheet
                    Worksheet membersWorksheet = Workbook.Worksheets[MembersIndex];

                    // if this is a new record
                    if (EditMode == EditModeEnum.AddNew)
                    {
                        // Create a new Row
                        row = membersWorksheet.NewRow();
                    }
                    else
                    {
                        row = membersWorksheet.Rows.FirstOrDefault(x => x.Id == SelectedMember.RowId);
                    }


                }
            }
            #endregion
            
        #endregion

        #region Methods

            #region CaptureSelectedMember()
            /// <summary>
            /// returns the Selected Member
            /// </summary>
            public void CaptureSelectedMember()
            {
                // if the value for HasSelectedMember is true
                if (HasSelectedMember)
                {
                    // Capture the values
                    SelectedMember.FirstName = FirstNameEditControl.Text;
                    SelectedMember.LastName = LastNameEditControl.Text;
                    SelectedMember.EmailAddress = EmailEditControl.Text;
                    SelectedMember.Active = ActiveEditCheckBox.Checked;
                    SelectedMember.Address.MemberId = SelectedMember.Id;
                    SelectedMember.Address.StreetAddress = AddressEditControl.Text;
                    SelectedMember.Address.Unit = UnitEditControl.Text;
                    SelectedMember.Address.City = CityEditControl.Text;
                    SelectedMember.Address.StateId = GetSelectedStateId();
                    SelectedMember.Address.ZipCode = ZipCodeEditControl.Text;
                }
            }
            #endregion

            #region CheckValidEmail(string emailAddress)
            /// <summary>
            /// This method returns the Valid Email
            /// </summary>
            public bool CheckValidEmail(string emailAddress)
            {
                // initial value
                bool isValidEmail = false;

                try
                {
                    // If the emailAddress string exists
                    if (TextHelper.Exists(emailAddress))
                    {
                        // find the at Sign
                        int atSignIndex = emailAddress.IndexOf("@");

                        // if found
                        if (atSignIndex > 0)
                        {
                            // get the wordBefore
                            string wordBefore = emailAddress.Substring(0, atSignIndex -1);

                            // get the words after
                            string wordsAfter = emailAddress.Substring(atSignIndex + 1);

                            // get the delimiters
                            char[] delimiters = { '.' };

                            // get the words
                            List<Word> words = TextHelper.GetWords(wordsAfter, delimiters);

                            // if there are 2 or more words, this should be valid
                            isValidEmail = ((TextHelper.Exists(wordBefore)) && (ListHelper.HasXOrMoreItems(words, 2)));
                        } 
                    }
                } 
                catch (Exception error)
                {
                    // not valid
                    isValidEmail = false;

                    // for debugging only
                    DebugHelper.WriteDebugError("CheckValidEmail", "EditMembersForm.cs", error);
                }
                
                // return value
                return isValidEmail;
            }
            #endregion
            
            #region DisplayMembers(string filterText = "")
            /// <summary>
            /// Display Members
            /// </summary>
            public void DisplayMembers(string filterText = "")
            {
                // Clear the list                
                MembersListBox.Items.Clear();

                // if the value for HasMembers is true
                if (HasMembers)
                {  
                    // reset
                    Graph.Value = 0;
                    
                    // force refresh
                    Refresh();
                    Application.DoEvents();

                    // local
                    List<Member> sortedMembers = null;

                    // do a where clause here
                    if (TextHelper.Exists(filterText))
                    {
                        // get the filterText
                        filterText = filterText.ToLower();

                        // Determine the filter by the filter type
                        if (FilterComboBox.SelectedIndex == 0)
                        {
                            // Contains Filter
                            sortedMembers = members.Where(x => x.FullNameLowerCase.Contains(filterText)).OrderBy(x => x.FullName).Take(20).ToList();
                        }
                        else
                        {
                            // Starts With Filter                            
                            sortedMembers = members.Where(x => x.FullNameLowerCase.StartsWith(filterText)).OrderBy(x => x.FullName).Take(20).ToList();
                        }
                    }
                    else
                    {
                        // Get the sortedMembers from all members
                        sortedMembers = members.OrderBy(x => x.FullName).Take(20).ToList();
                    }

                    if (ListHelper.HasOneOrMoreItems(sortedMembers))
                    {
                        // Setup the Graph
                        Graph.Maximum = sortedMembers.Count;
                        Graph.Visible = true;

                        // Iterate the collection of Member objects
                        foreach (Member member in sortedMembers)
                        {
                            // Add this item
                            MembersListBox.Items.Add(member);

                            // safeguard, as it crashed here once
                            if (Graph.Maximum >= MembersListBox.Items.Count)
                            {
                                // Set the value
                                Graph.Value = MembersListBox.Items.Count;
                            }

                            // force refresh
                            Refresh();
                            Application.DoEvents();
                        }

                        if (sortedMembers.Count == 1)
                        {
                            // Update the StatusText
                            StatusLabel.Text = "Displaying " + sortedMembers.Count + " member.";
                        }
                        else if (sortedMembers.Count == 20)
                        {
                            // Update the StatusText
                            StatusLabel.Text = "Displaying first " + sortedMembers.Count + " members.";
                        }
                        else
                        {
                            // Update the StatusText
                            StatusLabel.Text = "Displaying " + sortedMembers.Count + " members.";
                        }
                    }
                    else
                    {
                        // Show a message
                        StatusLabel.Text = "No items found";                        
                    }
                }

                // Hide
                Graph.Visible = false;

                 // force refresh
                 Refresh();
                 Application.DoEvents();
            }
            #endregion
            
            #region DisplaySelectedMember()
            /// <summary>
            /// Display Selected Member
            /// </summary>
            public void DisplaySelectedMember()
            {
                // locals
                int memberId = 0;
                string firstName = "";
                string lastName = "";
                string email = "";
                string active = "True";
                bool activeValue = false;
                string streetAddress = "";
                string unit = "";
                string city = "";
                string state = "";
                string zipCode = "";

                // if the SelectedMember exists
                if (HasSelectedMember)
                {
                    // set the values
                    memberId = SelectedMember.Id;
                    firstName = SelectedMember.FirstName;
                    lastName = SelectedMember.LastName;
                    email = SelectedMember.EmailAddress;
                    active = SelectedMember.Active ? "True" : "False";
                    activeValue = SelectedMember.Active;

                    // If the value for the property SelectedMember.HasAddress is true
                    if (SelectedMember.HasAddress)
                    {
                        // local copy for ease of typing
                        Address address = SelectedMember.Address;

                        // set the values
                        streetAddress = address.StreetAddress;
                        unit = address.Unit;
                        city = address.City;
                        zipCode = address.ZipCode.ToString();
                        
                        // if the address.StateId is set and the States collection exists
                        if ((address.StateId > 0) && (ListHelper.HasOneOrMoreItems(States)))
                        {
                            // set the name
                            state = States.FirstOrDefault(x => x.Id == address.StateId).Name;
                        }
                    }
                }
                
                // display values
                MemberIdControl.Text = memberId.ToString();
                FirstNameControl.Text = firstName;
                LastNameControl.Text = lastName;
                EmailControl.Text = email;
                ActiveControl.Text = active;
                StreetAddressControl.Text = streetAddress;
                UnitControl.Text = unit;
                CityControl.Text = city;
                StateControl.Text = state;
                ZipCodeControl.Text = zipCode;

                // display values for the edit control
                MemberIdControl2.Text = memberId.ToString();
                FirstNameEditControl.Text = firstName;
                LastNameEditControl.Text = lastName;
                EmailEditControl.Text = email;
                ActiveEditCheckBox.Checked = activeValue;
                AddressEditControl.Text = streetAddress;
                UnitEditControl.Text = unit;
                CityEditControl.Text = city;
                StateComboBox.SelectedIndex = StateComboBox.FindItemIndexByValue(state);
                ZipCodeEditControl.Text = zipCode;

                // Enable controls
                UIEnable();
            }
            #endregion
            
            #region GetMaxMemberId()
            /// <summary>
            /// returns the Max Member Id
            /// </summary>
            public int GetMaxMemberId()
            {
                // initial value
                int maxMemberId = 0;

                // if the value for HasMembers is true
                if (HasMembers)
                {
                    // get the max Id
                    maxMemberId = Members.Max(x => x.Id);
                }
                
                // return value
                return maxMemberId;
            }
            #endregion
            
            #region GetSelectedStateId()
            /// <summary>
            /// returns the Selected State Id
            /// </summary>
            public int GetSelectedStateId()
            {
                // initial value
                int selectedStateId = 0;

                // get the selectedIndex
                int index = StateComboBox.SelectedIndex;

                // if the index was found
                if (ListHelper.HasXOrMoreItems(States, index + 1))
                {
                    // Set the return value
                    selectedStateId = States[index].Id;
                }
                
                // return value
                return selectedStateId;
            }
            #endregion
            
            #region LoadAddresses(Worksheet worksheet)
            /// <summary>
            /// loads the Addresses
            /// </summary>
            public int LoadAddresses(Worksheet worksheet)
            {
                // Create a new collection of 'Address' objects.
                Addresses = new List<Address>();

                // Set the Status
                StatusLabel.Text = "Loading Addresses...";

                // local
                Address address = null;

                // If the worksheet object exists
                if (NullHelper.Exists(worksheet))
                {
                    // if the Rows collection exists and has two or more rows (the top row is the header row)
                    if (ListHelper.HasXOrMoreItems(worksheet.Rows, 2))
                    {
                        // Store the AddressHeaderRow
                        AddressHeaderRow = worksheet.Rows[0];

                        // Remove the header row so the loop below is slightly faster
                        // and doesn't have to check for if firstRow 20,000 times
                        worksheet.Rows.RemoveAt(0);

                        // iterate the rows
                        foreach (Row row in worksheet.Rows)
                        {
                            // Create a new instance of a 'Address' object.
                            address = new Address();

                            // Load the address
                            address.Load(row);

                            // Add this item
                            addresses.Add(address);

                            // if 100 rows have been added
                            if (addresses.Count % 100 == 0)
                            {
                                // Add 100 to the graph
                                Graph.Value += 100;

                                // refresh everything
                                Refresh();
                                Application.DoEvents();
                            }
                        }

                        // Update the Graph
                        Graph.Value = MembersCount + AddressesCount;

                        // Show this even though it will only show for a millisecond
                        StatusLabel.Text = "Loaded " + AddressesCount.ToString("n0") + " addresses.";

                        // refresh everything
                        Refresh();
                        Application.DoEvents();
                    }                    
                }

                // return value
                return AddressesCount;
            }
            #endregion

            #region LoadAlldata()
            /// <summary>
            /// Loads all data
            /// </summary>
            public int LoadAllData()
            {
                // initial value
                int objectsLoaded = 0;

                // Ensure visible
                StatusLabel.Visible = true;
                Graph.Visible = true;

                // hard coded path to Excel workbook MemberData.xlsx
                string tempPath = "Documents/MemberData.xlsx";

                // attempt to get the path
                string path = Path.GetFullPath(tempPath);

                // Set the Status
                StatusLabel.Text = "Loading data, please wait.";

                // Force a refresh here
                Refresh();
                Application.DoEvents();

                // if the path exists
                if (FileHelper.Exists(path))
                {
                    // load the workbook
                    Workbook = ExcelDataLoader.LoadAllData(path);

                    // if the workbook exists
                    if ((NullHelper.Exists(workbook)) && (ListHelper.HasXOrMoreItems(workbook.Worksheets, 3)))
                    {
                        // Get the indexes of each sheet
                        membersIndex = workbook.GetWorksheetIndex("Members");
                        addressIndex = workbook.GetWorksheetIndex("Address");
                        statesIndex = workbook.GetWorksheetIndex("States");

                        // verify all sheet indexes were found
                        if ((membersIndex >= 0) && (addressIndex >= 0) && (statesIndex >= 0))
                        {
                            // Get the counts
                            int membersCount = workbook.Worksheets[membersIndex].Rows.Count -1;
                            int addressesCount = workbook.Worksheets[addressIndex].Rows.Count -1;
                            int statesCount = workbook.Worksheets[statesIndex].Rows.Count -1;

                            // Setup the Graph
                            Graph.Maximum = workbook.Worksheets[0].Rows.Count + addressesCount + statesCount;
                            Graph.Value = 0;

                            // Force a refresh here
                            Refresh();
                            Application.DoEvents();

                            // Load the Members
                            LoadMembers(workbook.Worksheets[membersIndex]);

                            // Load the Addresses
                            LoadAddresses(workbook.Worksheets[addressIndex]);

                             // Load the States
                            LoadStates(workbook.Worksheets[statesIndex]);

                            // Set the StatusLabel
                            StatusLabel.Text = "All data has been loaded";
                        }
                    }
                }

                // return value
                return objectsLoaded;
            }
            #endregion

            #region LoadMembers(Worksheet worksheet)
            /// <summary>
            /// Load the Members
            /// </summary>
            public int LoadMembers(Worksheet worksheet)
            {
                // Create a new collection of 'Member' objects.
                Members = new List<Member>();

                // Set the Status
                StatusLabel.Text = "Loading Members...";

                // local
                Member member = null;

                // If the worksheet object exists
                if (NullHelper.Exists(worksheet))
                {
                    // if the Rows collection exists and has two or more rows (the top row is the header row)
                    if (ListHelper.HasXOrMoreItems(worksheet.Rows, 2))
                    {
                        // Store the StateHeaderRow
                        StateHeaderRow = worksheet.Rows[0];

                        // Remove the header row so the loop below is slightly faster
                        // and doesn't have to check for if firstRow 20,000 times
                        worksheet.Rows.RemoveAt(0);

                        // iterate the rows
                        foreach (Row row in worksheet.Rows)
                        {
                            // Create a new instance of a 'Member' object.
                            member = new Member();

                            // Load the member
                            member.Load(row);

                            // Add this item
                            members.Add(member);

                            // if 100 rows have been added
                            if (members.Count % 100 == 0)
                            {
                                // Add 100 to the graph
                                Graph.Value += 100;

                                // refresh everything
                                Refresh();
                                Application.DoEvents();
                            }
                        }

                        // Update the Graph
                        Graph.Value = MembersCount;

                        // Show this even though it will only show for a millisecond
                        StatusLabel.Text = "Loaded " + MembersCount.ToString("n0") + " members.";

                        // refresh everything
                        Refresh();
                        Application.DoEvents();
                    }                    
                }

                // return value
                return MembersCount;
            }
            #endregion

            #region LoadStates(Worksheet worksheet)
            /// <summary>
            /// Load the States
            /// </summary>
            public int LoadStates(Worksheet worksheet)
            {
                // Create a new collection of 'State' objects.
                States = new List<State>();

                // Set the Status
                StatusLabel.Text = "Loading States...";

                // local
                State state = null;

                // If the worksheet object exists
                if (NullHelper.Exists(worksheet))
                {
                    // if the Rows collection exists and has two or more rows (the top row is the header row)
                    if (ListHelper.HasXOrMoreItems(worksheet.Rows, 2))
                    {
                        // Store the StateHeaderRow
                        StateHeaderRow = worksheet.Rows[0];

                        // Remove the header row so the loop below is slightly faster
                        // and doesn't have to check for if firstRow 20,000 times
                        worksheet.Rows.RemoveAt(0);

                        // iterate the rows
                        foreach (Row row in worksheet.Rows)
                        {
                            // Create a new instance of a 'State' object.
                            state = new State();

                            // Load the state
                            state.Load(row);

                            // Add this item
                            states.Add(state);                           
                        }

                        // Update the Graph
                        int itemsLoaded = MembersCount + AddressesCount + StatesCount;

                        // if less than or equal to max
                        if (itemsLoaded <= Graph.Maximum)
                        {
                            // Set the graph
                            Graph.Value = itemsLoaded;
                        }
                        else
                        {
                            // Set to the Max
                            Graph.Value = Graph.Maximum;
                        }

                        // Show this even though it will only show for a millisecond
                        StatusLabel.Text = "Loaded " + StatesCount.ToString("n0") + " states.";

                        // Load the states
                        StateComboBox.LoadItems(States);

                        // refresh everything
                        Refresh();
                        Application.DoEvents();
                    }                    
                }

                // return value
                return StatesCount;
            }
        #endregion

            #region UIEnable()
            /// <summary>
            /// Enables controls and determines which controls are visible
            /// </summary>
            public void UIEnable()
            {
                // if the value for HasSelectedMember is true
                if (HasSelectedMember)
                {
                    // if Read Only
                    if ((EditMode == EditModeEnum.AddNew) || (EditMode == EditModeEnum.Editing))
                    {
                        // Add New or Edit

                        // Show the MemberDetailEditPanel
                        MemberDetailViewPanel.Visible = false;
                        MemberDetailEditPanel.Visible = true;

                        // Show both buttons
                        SaveButton.Visible = true;
                        CancelButton.Visible = true;
                    }
                    else
                    {
                        // Read Only

                        // Show the MemberDetailViewPanel
                        MemberDetailEditPanel.Visible = false;
                        MemberDetailViewPanel.Visible = true;

                        // Hide both buttons
                        SaveButton.Visible = false;
                        CancelButton.Visible = false;
                    }
                }
                else
                {
                    // Hide both Panels
                    MemberDetailViewPanel.Visible = false;
                    MemberDetailEditPanel.Visible = false;

                    // Hide both buttons
                    SaveButton.Visible = false;
                    CancelButton.Visible = false;
                }

                // Update the UI
                Refresh();
                Application.DoEvents();
            }
            #endregion
            
            #region ValidateMember()
            /// <summary>
            /// returns the Member
            /// </summary>
            public bool ValidateMember()
            {
                // initial value
                bool valid = false;

                // local
                string validationMessage = "";

                // if the value for HasSelectedMember is true
                if (HasSelectedMember)
                {
                    // only the first failed validation entry is shown
                    if (!TextHelper.Exists(SelectedMember.FirstName))
                    {
                        // not valid
                        valid = false;

                        // set the message
                        validationMessage = "First Name is required.";

                        // Set to red
                        FirstNameEditControl.GetTextBox().BackColor = Color.Tomato;

                        // Set Focus
                        FirstNameEditControl.SetFocusToTextBox();
                    }
                    else
                    {
                        // Set to White
                        FirstNameEditControl.GetTextBox().BackColor = Color.White;
                    }
                    
                    // only the first failed validation entry is shown
                    if ((valid) && (!TextHelper.Exists(SelectedMember.LastName)))
                    {
                        // not valid
                        valid = false;

                         // set the message
                        validationMessage = "Last Name is required.";

                        // Set to red
                        LastNameEditControl.GetTextBox().BackColor = Color.Tomato;

                        // Set Focus
                        LastNameEditControl.SetFocusToTextBox();
                    }
                    else
                    {
                        // Set to White
                        LastNameEditControl.GetTextBox().BackColor = Color.White;
                    }

                    // only the first failed validation entry is shown
                    if ((valid) && (!TextHelper.Exists(SelectedMember.EmailAddress)))
                    {
                        // not valid
                        valid = false;

                        // Set to red
                        EmailEditControl.GetTextBox().BackColor = Color.Tomato;

                        // Set Focus
                        EmailEditControl.SetFocusToTextBox();

                        // set the message
                        validationMessage = "Email is required.";
                    }
                    else
                    {
                        // Email gets one extra check
                        bool isValidEmail = CheckValidEmail(SelectedMember.EmailAddress);

                        // if not valid email
                        if (!isValidEmail)
                        {
                            // not valid
                            valid = false;

                            // Set to red
                            EmailEditControl.GetTextBox().BackColor = Color.Tomato;

                            // Set Focus
                            EmailEditControl.SetFocusToTextBox();

                            // set the message
                            validationMessage = "Enter a valid Email Address.";
                        }
                        else
                        {
                            // Set to White
                            EmailEditControl.GetTextBox().BackColor = Color.White;
                        }
                    }

                    // In this demo address is required

                    // Get the Address
                    Address address = SelectedMember.Address;

                    // only the first failed validation entry is shown
                    if ((valid) && (!TextHelper.Exists(address.StreetAddress)))
                    {
                        // not valid
                        valid = false;

                        // Set to red
                        AddressEditControl.GetTextBox().BackColor = Color.Tomato;

                        // Set Focus
                        AddressEditControl.SetFocusToTextBox();

                        // set the message
                        validationMessage = "Street Address is required.";
                    }
                    else
                    {
                         // Set to White
                        AddressEditControl.GetTextBox().BackColor = Color.White;
                    }

                    // only the first failed validation entry is shown
                    if ((valid) && (!TextHelper.Exists(address.City)))
                    {
                        // not valid
                        valid = false;

                        // Set to red
                        CityEditControl.GetTextBox().BackColor = Color.Tomato;

                        // Set Focus
                        CityEditControl.SetFocusToTextBox();

                        // set the message
                        validationMessage = "City is required.";
                    }
                    else
                    {
                         // Set to White
                        CityEditControl.GetTextBox().BackColor = Color.White;
                    }

                    // only the first failed validation entry is shown
                    if ((valid) && (address.StateId < 1))
                    {
                        // not valid
                        valid = false;

                        // Set to red
                        StateComboBox.ComboBoxControl.BackColor = Color.Tomato;

                        // Set Focus
                        StateComboBox.SetFocusToComboBox();

                        // set the message
                        validationMessage = "State is required.";
                    }
                    else
                    {
                         // Set to White
                        StateComboBox.ComboBoxControl.BackColor = Color.White;
                    }

                    // only the first failed validation entry is shown
                    if ((valid) && (!TextHelper.Exists(address.ZipCode)))
                    {
                        // not valid
                        valid = false;

                        // Set to red
                        ZipCodeEditControl.GetTextBox().BackColor = Color.Tomato;

                        // Set Focus
                        ZipCodeEditControl.SetFocusToTextBox();

                        // set the message
                        validationMessage = "Zip Code is required.";
                    }
                    else
                    {
                         // Set to White
                        ZipCodeEditControl.GetTextBox().BackColor = Color.White;
                    }

                    // if not valid
                    if (!valid)
                    {  
                        // Change the text to 
                        StatusLabel.ForeColor = Color.Tomato;

                        // Set the validation message
                        StatusLabel.Text = validationMessage;
                    }
                    else
                    {
                        // Put back to yellow
                        StatusLabel.ForeColor = Color.LemonChiffon;

                        // Show a message
                        StatusLabel.Text = "Saving member, please wait";
                    }
                }
                
                // return value
                return valid;
            }
            #endregion
            
        #endregion

        #region Properties

            #region Addresses
            /// <summary>
            /// This property gets or sets the value for 'Addresses'.
            /// </summary>
            public List<Address> Addresses
            {
                get { return addresses; }
                set { addresses = value; }
            }
            #endregion

            #region AddressesCount
            /// <summary>
            /// This read only property returns the value for 'AddressesCount'.
            /// </summary>
            public int AddressesCount
            {
                get
                {
                    // initial value
                    int addressesCount = 0;
                    
                    // if the value for HasAddresses is true
                    if (HasAddresses)
                    {
                        // set the return value
                        addressesCount = Addresses.Count;
                    }
                    
                    // return value
                    return addressesCount;
                }
            }
            #endregion
            
            #region AddressHeaderRow
            /// <summary>
            /// This property gets or sets the value for 'AddressHeaderRow'.
            /// </summary>
            public Row AddressHeaderRow
            {
                get { return addressHeaderRow; }
                set { addressHeaderRow = value; }
            }
            #endregion
            
            #region AddressIndex
            /// <summary>
            /// This property gets or sets the value for 'AddressIndex'.
            /// </summary>
            public int AddressIndex
            {
                get { return addressIndex; }
                set { addressIndex = value; }
            }
            #endregion
            
            #region EditMode
            /// <summary>
            /// This property gets or sets the value for 'EditMode'.
            /// </summary>
            public EditModeEnum EditMode
            {
                get { return editMode; }
                set { editMode = value; }
            }
            #endregion
            
            #region FilterTypedTime
            /// <summary>
            /// This property gets or sets the value for 'FilterTypedTime'.
            /// </summary>
            public DateTime FilterTypedTime
            {
                get { return filterTypedTime; }
                set { filterTypedTime = value; }
            }
            #endregion
            
            #region FirstActivationComplete
            /// <summary>
            /// This property gets or sets the value for 'FirstActivationComplete'.
            /// </summary>
            public bool FirstActivationComplete
            {
                get { return firstActivationComplete; }
                set { firstActivationComplete = value; }
            }
            #endregion
            
            #region HasAddresses
            /// <summary>
            /// This property returns true if this object has an 'Addresses'.
            /// </summary>
            public bool HasAddresses
            {
                get
                {
                    // initial value
                    bool hasAddresses = (this.Addresses != null);
                    
                    // return value
                    return hasAddresses;
                }
            }
            #endregion
            
            #region HasAddressHeaderRow
            /// <summary>
            /// This property returns true if this object has an 'AddressHeaderRow'.
            /// </summary>
            public bool HasAddressHeaderRow
            {
                get
                {
                    // initial value
                    bool hasAddressHeaderRow = (this.AddressHeaderRow != null);
                    
                    // return value
                    return hasAddressHeaderRow;
                }
            }
            #endregion
            
            #region HasMembers
            /// <summary>
            /// This property returns true if this object has a 'Members'.
            /// </summary>
            public bool HasMembers
            {
                get
                {
                    // initial value
                    bool hasMembers = (this.Members != null);
                    
                    // return value
                    return hasMembers;
                }
            }
            #endregion
            
            #region HasSelectedMember
            /// <summary>
            /// This property returns true if this object has a 'SelectedMember'.
            /// </summary>
            public bool HasSelectedMember
            {
                get
                {
                    // initial value
                    bool hasSelectedMember = (this.SelectedMember != null);
                    
                    // return value
                    return hasSelectedMember;
                }
            }
            #endregion
            
            #region HasStateHeaderRow
            /// <summary>
            /// This property returns true if this object has a 'StateHeaderRow'.
            /// </summary>
            public bool HasStateHeaderRow
            {
                get
                {
                    // initial value
                    bool hasStateHeaderRow = (this.StateHeaderRow != null);
                    
                    // return value
                    return hasStateHeaderRow;
                }
            }
            #endregion

            #region CreateParams
            /// <summary>
            /// This property here is what did the trick to reduce the flickering.
            /// I also needed to make all of the controls Double Buffered, but
            /// this was the final touch. It is a little slow when you switch tabs
            /// but that is because the repainting is finishing before control is
            /// returned.
            /// </summary>
            protected override CreateParams CreateParams
            {
                get
                {
                    // initial value
                    CreateParams cp = base.CreateParams;

                    // Apparently this interrupts Paint to finish before showing
                    cp.ExStyle |= 0x02000000;

                    // return value
                    return cp;
                }
            }
            #endregion
            
            #region HasStates
            /// <summary>
            /// This property returns true if this object has a 'States'.
            /// </summary>
            public bool HasStates
            {
                get
                {
                    // initial value
                    bool hasStates = (this.States != null);
                    
                    // return value
                    return hasStates;
                }
            }
            #endregion
            
            #region HasWorkbook
            /// <summary>
            /// This property returns true if this object has a 'Workbook'.
            /// </summary>
            public bool HasWorkbook
            {
                get
                {
                    // initial value
                    bool hasWorkbook = (this.Workbook != null);
                    
                    // return value
                    return hasWorkbook;
                }
            }
            #endregion
            
            #region Members
            /// <summary>
            /// This property gets or sets the value for 'Members'.
            /// </summary>
            public List<Member> Members
            {
                get { return members; }
                set { members = value; }
            }
            #endregion
            
            #region MembersCount
            /// <summary>
            /// This property gets or sets the value for 'MembersCount'.
            /// </summary>
            public int MembersCount
            {
                get
                {
                    // initial value
                    int membersCount = 0;
                    
                    // if the value for HasMembers is true
                    if (HasMembers)
                    {
                        // set the return value
                        membersCount = Members.Count;
                    }
                    
                    // return value
                    return membersCount;
                }
            }
            #endregion
          
            #region MembersIndex
            /// <summary>
            /// This property gets or sets the value for 'MembersIndex'.
            /// </summary>
            public int MembersIndex
            {
                get { return membersIndex; }
                set { membersIndex = value; }
            }
            #endregion
            
            #region SelectedMember
            /// <summary>
            /// This property gets or sets the value for 'SelectedMember'.
            /// </summary>
            public Member SelectedMember
            {
                get { return selectedMember; }
                set { selectedMember = value; }
            }
            #endregion
            
            #region StateHeaderRow
            /// <summary>
            /// This property gets or sets the value for 'StateHeaderRow'.
            /// </summary>
            public Row StateHeaderRow
            {
                get { return stateHeaderRow; }
                set { stateHeaderRow = value; }
            }
            #endregion
            
            #region States
            /// <summary>
            /// This property gets or sets the value for 'States'.
            /// </summary>
            public List<State> States
            {
                get { return states; }
                set { states = value; }
            }
        #endregion

            #region StatesCount
            /// <summary>
            /// This property gets or sets the value for 'StatesCount'.
            /// </summary>
            public int StatesCount
            {
                get
                {
                    // initial value
                    int statesCount = 0;
                    
                    // if the value for HasStates is true
                    if (HasStates)
                    {
                        // set the return value
                        statesCount = States.Count;
                    }
                    
                    // return value
                    return statesCount;
                }
            }
        #endregion

            #region StatesIndex
            /// <summary>
            /// This property gets or sets the value for 'StatesIndex'.
            /// </summary>
            public int StatesIndex
            {
                get { return statesIndex; }
                set { statesIndex = value; }
            }
            #endregion
            
            #region Workbook
            /// <summary>
            /// This property gets or sets the value for 'Workbook'.
            /// </summary>
            public Workbook Workbook
            {
                get { return workbook; }
                set { workbook = value; }
            }
        #endregion

        #endregion
    }
    #endregion

}
