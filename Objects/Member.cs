

#region using statements

using DataJuggler.Excelerate;
using DataJuggler.UltimateHelper;
using System;

#endregion

namespace Demo.Objects
{

    #region class Member
    /// <summary>
    /// This class represents a Member object.
    /// </summary>
    public class Member
    {
        
        #region Private Variables
        private bool active;
        private string emailAddress;
        private string firstName;
        private int id;
        private string lastName;
        private Guid rowId;
        private Address address;
        #endregion
        
        #region Constructor
        /// <summary>
        /// Create a new instance of a 'Member' object.
        /// </summary>
        public Member()
        {
            // Create a new instance of an 'Address' object.
            Address = new Address();
        }
        #endregion
        
        #region Methods
            
            #region Load(Row row)
            /// <summary>
            /// This method loads a Members object from a Row.
            /// </Summary>
            /// <param name="row">The row which the row.Columns[x].ColumnValue will be used to load this object.</param>
            public void Load(Row row)
            {
                // If the row exists and the row's column collection exists
                if ((NullHelper.Exists(row)) && (row.HasColumns))
                {
                    Id = row.Columns[0].IntValue;
                    FirstName = row.Columns[1].StringValue;
                    LastName = row.Columns[2].StringValue;
                    Active = row.Columns[3].BoolValue;
                    EmailAddress = row.Columns[4].StringValue;
                }
                
                // Set RowId
                RowId = row.Id;
            }
            #endregion
            
            #region Save(Row row)
            /// <summary>
            /// This method saves a Members object back to a Row.
            /// </Summary>
            /// <param name="row">The row which the row.Columns[x].ColumnValue will be set to Save back to Excel.</param>
            public Row Save(Row row)
            {
                // If the row exists and the row's column collection exists
                if ((NullHelper.Exists(row)) && (row.HasColumns))
                {
                    row.Columns[0].ColumnValue = Id;
                    row.Columns[1].ColumnValue = FirstName;
                    row.Columns[2].ColumnValue = LastName;
                    row.Columns[3].ColumnValue = Active;
                    row.Columns[4].ColumnValue = EmailAddress;
                }
                
                // return value
                return row;
            }
            #endregion
            
            #region ToString()
            /// <summary>
            /// method returns the State Name when ToString is called.
            /// </summary>
            public override string ToString()
            {
                // return value
                return FullName;
            }
            #endregion
            
        #endregion
        
        #region Properties
            
            #region Active
            /// <summary>
            /// method [Enter Method Description]
            /// </summary>
            public bool Active
            {
                get
                {
                    return active;
                }
                set
                {
                    active = value;
                }
            }
            #endregion
            
            #region Address
            /// <summary>
            /// This property gets or sets the value for 'Address'.
            /// </summary>
            public Address Address
            {
                get { return address; }
                set { address = value; }
            }
            #endregion
            
            #region EmailAddress
            /// <summary>
            /// method [Enter Method Description]
            /// </summary>
            public string EmailAddress
            {
                get
                {
                    return emailAddress;
                }
                set
                {
                    emailAddress = value;
                }
            }
            #endregion
            
            #region FirstName
            /// <summary>
            /// method [Enter Method Description]
            /// </summary>
            public string FirstName
            {
                get
                {
                    return firstName;
                }
                set
                {
                    firstName = value;
                }
            }
            #endregion
            
            #region FullName
            /// <summary>
            /// This read only property returns the value for 'FullName'.
            /// </summary>
            public string FullName
            {
                get
                {
                    // initial value
                    string fullName = FirstName + " " + LastName;
                    
                    // return value
                    return fullName;
                }
            }
            #endregion
            
            #region FullNameLowerCase
            /// <summary>
            /// This read only property returns the value for 'FullName' set to LowerCase
            /// </summary>
            public string FullNameLowerCase
            {
                get
                {
                    // initial value
                    string fullName = FullName;
                    
                    // If the fullName string exists
                    if (TextHelper.Exists(fullName))
                    {
                        // set to lower case
                        fullName = fullName.ToLower();
                    }
                    
                    // return value
                    return fullName;
                }
            }
            #endregion
            
            #region HasAddress
            /// <summary>
            /// This property returns true if this object has an 'Address'.
            /// </summary>
            public bool HasAddress
            {
                get
                {
                    // initial value
                    bool hasAddress = ((this.Address != null) && (TextHelper.Exists(Address.StreetAddress, Address.City, Address.ZipCode)));
                    
                    // return value
                    return hasAddress;
                }
            }
            #endregion
            
            #region Id
            /// <summary>
            /// This property get or sets the value for 'Id'.
            /// </summary>
            public int Id
            {
                get
                {
                    return id;
                }
                set
                {
                    id = value;
                }
            }
            #endregion
            
            #region LastName
            /// <summary>
            /// method [Enter Method Description]
            /// </summary>
            public string LastName
            {
                get
                {
                    return lastName;
                }
                set
                {
                    lastName = value;
                }
            }
            #endregion
            
            #region RowId
            /// <summary>
            /// method [Enter Method Description]
            /// </summary>
            public Guid RowId
            {
                get
                {
                    return rowId;
                }
                set
                {
                    rowId = value;
                }
            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
