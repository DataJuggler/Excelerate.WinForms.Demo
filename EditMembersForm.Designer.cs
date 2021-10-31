

#region using statements


#endregion

namespace Demo
{

    #region class EditMembersForm
    /// <summary>
    /// method [Enter Method Description]
    /// </summary>
    partial class EditMembersForm
    {
        
        #region Private Variables
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.ListBox MembersListBox;
        private DataJuggler.Win.Controls.Button AddButton;
        private DataJuggler.Win.Controls.Button EditButton;
        private DataJuggler.Win.Controls.Button DeleteButton;
        private DataJuggler.Win.Controls.Objects.PanelExtender MemberDetailViewPanel;
        private DataJuggler.Win.Controls.LabelLabelControl EmailControl;
        private DataJuggler.Win.Controls.LabelLabelControl LastNameControl;
        private DataJuggler.Win.Controls.LabelLabelControl FirstNameControl;
        private DataJuggler.Win.Controls.LabelLabelControl MemberIdControl;
        private System.Windows.Forms.ProgressBar Graph;
        private System.Windows.Forms.Label StatusLabel;
        private DataJuggler.Win.Controls.LabelLabelControl CityControl;
        private DataJuggler.Win.Controls.LabelLabelControl StreetAddressControl;
        private new DataJuggler.Win.Controls.Button CancelButton;
        private DataJuggler.Win.Controls.Button SaveButton;
        private DataJuggler.Win.Controls.LabelLabelControl ZipCodeControl;
        private DataJuggler.Win.Controls.LabelLabelControl StateControl;
        private DataJuggler.Win.Controls.LabelLabelControl UnitControl;
        private DataJuggler.Win.Controls.LabelLabelControl ActiveControl;
        private DataJuggler.Win.Controls.Objects.PanelExtender MemberDetailEditPanel;
        private DataJuggler.Win.Controls.LabelTextBoxControl EmailEditControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl LastNameEditControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl FirstNameEditControl;
        private DataJuggler.Win.Controls.LabelLabelControl MemberIdControl2;
        private DataJuggler.Win.Controls.LabelTextBoxControl ZipCodeEditControl;
        private DataJuggler.Win.Controls.LabelComboBoxControl StateComboBox;
        private DataJuggler.Win.Controls.LabelTextBoxControl CityEditControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl UnitEditControl;
        private DataJuggler.Win.Controls.LabelTextBoxControl AddressEditControl;
        private DataJuggler.Win.Controls.LabelCheckBoxControl ActiveEditCheckBox;
        private DataJuggler.Win.Controls.LabelTextBoxControl FilterTextBox;
        private System.Windows.Forms.Label FilterLabel;
        private DataJuggler.Win.Controls.LabelComboBoxControl FilterComboBox;
        private System.Windows.Forms.Timer FilterTimer;
        #endregion
        
        #region Methods
            
            #region Dispose(bool disposing)
            /// <summary>
            ///  Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                {
                    components.Dispose();
                }
                base.Dispose(disposing);
            }
            #endregion
            
            #region InitializeComponent()
            /// <summary>
            ///  Required method for Designer support - do not modify
            ///  the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMembersForm));
            this.MembersListBox = new System.Windows.Forms.ListBox();
            this.AddButton = new DataJuggler.Win.Controls.Button();
            this.EditButton = new DataJuggler.Win.Controls.Button();
            this.DeleteButton = new DataJuggler.Win.Controls.Button();
            this.MemberDetailViewPanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            this.ActiveControl = new DataJuggler.Win.Controls.LabelLabelControl();
            this.ZipCodeControl = new DataJuggler.Win.Controls.LabelLabelControl();
            this.StateControl = new DataJuggler.Win.Controls.LabelLabelControl();
            this.UnitControl = new DataJuggler.Win.Controls.LabelLabelControl();
            this.CityControl = new DataJuggler.Win.Controls.LabelLabelControl();
            this.StreetAddressControl = new DataJuggler.Win.Controls.LabelLabelControl();
            this.EmailControl = new DataJuggler.Win.Controls.LabelLabelControl();
            this.LastNameControl = new DataJuggler.Win.Controls.LabelLabelControl();
            this.FirstNameControl = new DataJuggler.Win.Controls.LabelLabelControl();
            this.MemberIdControl = new DataJuggler.Win.Controls.LabelLabelControl();
            this.Graph = new System.Windows.Forms.ProgressBar();
            this.StatusLabel = new System.Windows.Forms.Label();
            this.CancelButton = new DataJuggler.Win.Controls.Button();
            this.SaveButton = new DataJuggler.Win.Controls.Button();
            this.MemberDetailEditPanel = new DataJuggler.Win.Controls.Objects.PanelExtender();
            this.ZipCodeEditControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.StateComboBox = new DataJuggler.Win.Controls.LabelComboBoxControl();
            this.CityEditControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.UnitEditControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.AddressEditControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.ActiveEditCheckBox = new DataJuggler.Win.Controls.LabelCheckBoxControl();
            this.EmailEditControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.LastNameEditControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.FirstNameEditControl = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.MemberIdControl2 = new DataJuggler.Win.Controls.LabelLabelControl();
            this.FilterTextBox = new DataJuggler.Win.Controls.LabelTextBoxControl();
            this.FilterLabel = new System.Windows.Forms.Label();
            this.FilterComboBox = new DataJuggler.Win.Controls.LabelComboBoxControl();
            this.FilterTimer = new System.Windows.Forms.Timer(this.components);
            this.MemberDetailViewPanel.SuspendLayout();
            this.MemberDetailEditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // MembersListBox
            // 
            this.MembersListBox.FormattingEnabled = true;
            this.MembersListBox.ItemHeight = 18;
            this.MembersListBox.Location = new System.Drawing.Point(24, 88);
            this.MembersListBox.Name = "MembersListBox";
            this.MembersListBox.Size = new System.Drawing.Size(275, 382);
            this.MembersListBox.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.BackColor = System.Drawing.Color.Transparent;
            this.AddButton.ButtonText = "Add";
            this.AddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.AddButton.Location = new System.Drawing.Point(23, 478);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(84, 44);
            this.AddButton.TabIndex = 1;
            this.AddButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // EditButton
            // 
            this.EditButton.BackColor = System.Drawing.Color.Transparent;
            this.EditButton.ButtonText = "Edit";
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.EditButton.Location = new System.Drawing.Point(119, 478);
            this.EditButton.Margin = new System.Windows.Forms.Padding(4);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(84, 44);
            this.EditButton.TabIndex = 2;
            this.EditButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton.ButtonText = "Delete";
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.DeleteButton.Location = new System.Drawing.Point(215, 478);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(84, 44);
            this.DeleteButton.TabIndex = 3;
            this.DeleteButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // MemberDetailViewPanel
            // 
            this.MemberDetailViewPanel.BackColor = System.Drawing.Color.Transparent;
            this.MemberDetailViewPanel.Controls.Add(this.ActiveControl);
            this.MemberDetailViewPanel.Controls.Add(this.ZipCodeControl);
            this.MemberDetailViewPanel.Controls.Add(this.StateControl);
            this.MemberDetailViewPanel.Controls.Add(this.UnitControl);
            this.MemberDetailViewPanel.Controls.Add(this.CityControl);
            this.MemberDetailViewPanel.Controls.Add(this.StreetAddressControl);
            this.MemberDetailViewPanel.Controls.Add(this.EmailControl);
            this.MemberDetailViewPanel.Controls.Add(this.LastNameControl);
            this.MemberDetailViewPanel.Controls.Add(this.FirstNameControl);
            this.MemberDetailViewPanel.Controls.Add(this.MemberIdControl);
            this.MemberDetailViewPanel.Location = new System.Drawing.Point(324, 16);
            this.MemberDetailViewPanel.Name = "MemberDetailViewPanel";
            this.MemberDetailViewPanel.Size = new System.Drawing.Size(566, 430);
            this.MemberDetailViewPanel.TabIndex = 9;
            this.MemberDetailViewPanel.Visible = false;
            // 
            // ActiveControl
            // 
            this.ActiveControl.BackColor = System.Drawing.Color.Transparent;
            this.ActiveControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActiveControl.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ActiveControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ActiveControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ActiveControl.LabelText = "Active:";
            this.ActiveControl.LabelWidth = 140;
            this.ActiveControl.Location = new System.Drawing.Point(16, 182);
            this.ActiveControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ActiveControl.Name = "ActiveControl";
            this.ActiveControl.Size = new System.Drawing.Size(360, 28);
            this.ActiveControl.TabIndex = 19;
            this.ActiveControl.ValueLabelColor = System.Drawing.Color.LemonChiffon;
            this.ActiveControl.ValueLabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // ZipCodeControl
            // 
            this.ZipCodeControl.BackColor = System.Drawing.Color.Transparent;
            this.ZipCodeControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ZipCodeControl.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ZipCodeControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ZipCodeControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ZipCodeControl.LabelText = "Zip Code:";
            this.ZipCodeControl.LabelWidth = 140;
            this.ZipCodeControl.Location = new System.Drawing.Point(16, 392);
            this.ZipCodeControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.ZipCodeControl.Name = "ZipCodeControl";
            this.ZipCodeControl.Size = new System.Drawing.Size(524, 28);
            this.ZipCodeControl.TabIndex = 18;
            this.ZipCodeControl.ValueLabelColor = System.Drawing.Color.LemonChiffon;
            this.ZipCodeControl.ValueLabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // StateControl
            // 
            this.StateControl.BackColor = System.Drawing.Color.Transparent;
            this.StateControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StateControl.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StateControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.StateControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StateControl.LabelText = "State:";
            this.StateControl.LabelWidth = 140;
            this.StateControl.Location = new System.Drawing.Point(16, 350);
            this.StateControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.StateControl.Name = "StateControl";
            this.StateControl.Size = new System.Drawing.Size(524, 28);
            this.StateControl.TabIndex = 17;
            this.StateControl.ValueLabelColor = System.Drawing.Color.LemonChiffon;
            this.StateControl.ValueLabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // UnitControl
            // 
            this.UnitControl.BackColor = System.Drawing.Color.Transparent;
            this.UnitControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnitControl.ForeColor = System.Drawing.Color.LemonChiffon;
            this.UnitControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.UnitControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UnitControl.LabelText = "Unit:";
            this.UnitControl.LabelWidth = 140;
            this.UnitControl.Location = new System.Drawing.Point(16, 266);
            this.UnitControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.UnitControl.Name = "UnitControl";
            this.UnitControl.Size = new System.Drawing.Size(524, 28);
            this.UnitControl.TabIndex = 16;
            this.UnitControl.ValueLabelColor = System.Drawing.Color.LemonChiffon;
            this.UnitControl.ValueLabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // CityControl
            // 
            this.CityControl.BackColor = System.Drawing.Color.Transparent;
            this.CityControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CityControl.ForeColor = System.Drawing.Color.LemonChiffon;
            this.CityControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.CityControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CityControl.LabelText = "City:";
            this.CityControl.LabelWidth = 140;
            this.CityControl.Location = new System.Drawing.Point(16, 308);
            this.CityControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CityControl.Name = "CityControl";
            this.CityControl.Size = new System.Drawing.Size(524, 28);
            this.CityControl.TabIndex = 15;
            this.CityControl.ValueLabelColor = System.Drawing.Color.LemonChiffon;
            this.CityControl.ValueLabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // StreetAddressControl
            // 
            this.StreetAddressControl.BackColor = System.Drawing.Color.Transparent;
            this.StreetAddressControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StreetAddressControl.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StreetAddressControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.StreetAddressControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StreetAddressControl.LabelText = "Address:";
            this.StreetAddressControl.LabelWidth = 140;
            this.StreetAddressControl.Location = new System.Drawing.Point(16, 224);
            this.StreetAddressControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.StreetAddressControl.Name = "StreetAddressControl";
            this.StreetAddressControl.Size = new System.Drawing.Size(524, 28);
            this.StreetAddressControl.TabIndex = 14;
            this.StreetAddressControl.ValueLabelColor = System.Drawing.Color.LemonChiffon;
            this.StreetAddressControl.ValueLabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // EmailControl
            // 
            this.EmailControl.BackColor = System.Drawing.Color.Transparent;
            this.EmailControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailControl.ForeColor = System.Drawing.Color.LemonChiffon;
            this.EmailControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.EmailControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmailControl.LabelText = "Email:";
            this.EmailControl.LabelWidth = 140;
            this.EmailControl.Location = new System.Drawing.Point(16, 140);
            this.EmailControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.EmailControl.Name = "EmailControl";
            this.EmailControl.Size = new System.Drawing.Size(524, 28);
            this.EmailControl.TabIndex = 12;
            this.EmailControl.ValueLabelColor = System.Drawing.Color.LemonChiffon;
            this.EmailControl.ValueLabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // LastNameControl
            // 
            this.LastNameControl.BackColor = System.Drawing.Color.Transparent;
            this.LastNameControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameControl.ForeColor = System.Drawing.Color.LemonChiffon;
            this.LastNameControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.LastNameControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LastNameControl.LabelText = "Last Name:";
            this.LastNameControl.LabelWidth = 140;
            this.LastNameControl.Location = new System.Drawing.Point(16, 98);
            this.LastNameControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.LastNameControl.Name = "LastNameControl";
            this.LastNameControl.Size = new System.Drawing.Size(360, 28);
            this.LastNameControl.TabIndex = 11;
            this.LastNameControl.ValueLabelColor = System.Drawing.Color.LemonChiffon;
            this.LastNameControl.ValueLabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // FirstNameControl
            // 
            this.FirstNameControl.BackColor = System.Drawing.Color.Transparent;
            this.FirstNameControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameControl.ForeColor = System.Drawing.Color.LemonChiffon;
            this.FirstNameControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.FirstNameControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstNameControl.LabelText = "First Name:";
            this.FirstNameControl.LabelWidth = 140;
            this.FirstNameControl.Location = new System.Drawing.Point(16, 56);
            this.FirstNameControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.FirstNameControl.Name = "FirstNameControl";
            this.FirstNameControl.Size = new System.Drawing.Size(360, 28);
            this.FirstNameControl.TabIndex = 10;
            this.FirstNameControl.ValueLabelColor = System.Drawing.Color.LemonChiffon;
            this.FirstNameControl.ValueLabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // MemberIdControl
            // 
            this.MemberIdControl.BackColor = System.Drawing.Color.Transparent;
            this.MemberIdControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MemberIdControl.ForeColor = System.Drawing.Color.LemonChiffon;
            this.MemberIdControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.MemberIdControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MemberIdControl.LabelText = "Member Id:";
            this.MemberIdControl.LabelWidth = 140;
            this.MemberIdControl.Location = new System.Drawing.Point(16, 14);
            this.MemberIdControl.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MemberIdControl.Name = "MemberIdControl";
            this.MemberIdControl.Size = new System.Drawing.Size(360, 28);
            this.MemberIdControl.TabIndex = 9;
            this.MemberIdControl.ValueLabelColor = System.Drawing.Color.LemonChiffon;
            this.MemberIdControl.ValueLabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // Graph
            // 
            this.Graph.Location = new System.Drawing.Point(24, 559);
            this.Graph.Name = "Graph";
            this.Graph.Size = new System.Drawing.Size(883, 23);
            this.Graph.TabIndex = 10;
            this.Graph.Visible = false;
            // 
            // StatusLabel
            // 
            this.StatusLabel.BackColor = System.Drawing.Color.Transparent;
            this.StatusLabel.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StatusLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.StatusLabel.Location = new System.Drawing.Point(24, 532);
            this.StatusLabel.Name = "StatusLabel";
            this.StatusLabel.Size = new System.Drawing.Size(657, 23);
            this.StatusLabel.TabIndex = 11;
            this.StatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatusLabel.Visible = false;
            // 
            // CancelButton
            // 
            this.CancelButton.BackColor = System.Drawing.Color.Transparent;
            this.CancelButton.ButtonText = "Cancel";
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CancelButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.CancelButton.Location = new System.Drawing.Point(811, 482);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(96, 44);
            this.CancelButton.TabIndex = 13;
            this.CancelButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.CancelButton.Visible = false;
            // 
            // SaveButton
            // 
            this.SaveButton.BackColor = System.Drawing.Color.Transparent;
            this.SaveButton.ButtonText = "Save";
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveButton.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.ForeColor = System.Drawing.Color.LemonChiffon;
            this.SaveButton.Location = new System.Drawing.Point(707, 482);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(96, 44);
            this.SaveButton.TabIndex = 12;
            this.SaveButton.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            this.SaveButton.Visible = false;
            // 
            // MemberDetailEditPanel
            // 
            this.MemberDetailEditPanel.BackColor = System.Drawing.Color.Transparent;
            this.MemberDetailEditPanel.Controls.Add(this.ZipCodeEditControl);
            this.MemberDetailEditPanel.Controls.Add(this.StateComboBox);
            this.MemberDetailEditPanel.Controls.Add(this.CityEditControl);
            this.MemberDetailEditPanel.Controls.Add(this.UnitEditControl);
            this.MemberDetailEditPanel.Controls.Add(this.AddressEditControl);
            this.MemberDetailEditPanel.Controls.Add(this.ActiveEditCheckBox);
            this.MemberDetailEditPanel.Controls.Add(this.EmailEditControl);
            this.MemberDetailEditPanel.Controls.Add(this.LastNameEditControl);
            this.MemberDetailEditPanel.Controls.Add(this.FirstNameEditControl);
            this.MemberDetailEditPanel.Controls.Add(this.MemberIdControl2);
            this.MemberDetailEditPanel.Location = new System.Drawing.Point(324, 16);
            this.MemberDetailEditPanel.Name = "MemberDetailEditPanel";
            this.MemberDetailEditPanel.Size = new System.Drawing.Size(566, 430);
            this.MemberDetailEditPanel.TabIndex = 14;
            this.MemberDetailEditPanel.Visible = false;
            // 
            // ZipCodeEditControl
            // 
            this.ZipCodeEditControl.BackColor = System.Drawing.Color.Transparent;
            this.ZipCodeEditControl.BottomMargin = 0;
            this.ZipCodeEditControl.Editable = true;
            this.ZipCodeEditControl.Encrypted = false;
            this.ZipCodeEditControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ZipCodeEditControl.LabelBottomMargin = 0;
            this.ZipCodeEditControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ZipCodeEditControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ZipCodeEditControl.LabelText = "Zip:";
            this.ZipCodeEditControl.LabelTopMargin = 4;
            this.ZipCodeEditControl.LabelWidth = 140;
            this.ZipCodeEditControl.Location = new System.Drawing.Point(16, 392);
            this.ZipCodeEditControl.MultiLine = false;
            this.ZipCodeEditControl.Name = "ZipCodeEditControl";
            this.ZipCodeEditControl.OnTextChangedListener = null;
            this.ZipCodeEditControl.PasswordMode = false;
            this.ZipCodeEditControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.ZipCodeEditControl.Size = new System.Drawing.Size(244, 28);
            this.ZipCodeEditControl.TabIndex = 8;
            this.ZipCodeEditControl.TextBoxBottomMargin = 0;
            this.ZipCodeEditControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.ZipCodeEditControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.ZipCodeEditControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ZipCodeEditControl.TextBoxTopMargin = 0;
            this.ZipCodeEditControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // StateComboBox
            // 
            this.StateComboBox.BackColor = System.Drawing.Color.Transparent;
            this.StateComboBox.ComboBoxLeftMargin = 1;
            this.StateComboBox.ComboBoxText = "";
            this.StateComboBox.ComoboBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StateComboBox.Editable = true;
            this.StateComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.StateComboBox.HideLabel = false;
            this.StateComboBox.LabelBottomMargin = 0;
            this.StateComboBox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.StateComboBox.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.StateComboBox.LabelText = "State:";
            this.StateComboBox.LabelTopMargin = 4;
            this.StateComboBox.LabelWidth = 140;
            this.StateComboBox.List = null;
            this.StateComboBox.Location = new System.Drawing.Point(16, 350);
            this.StateComboBox.Name = "StateComboBox";
            this.StateComboBox.SelectedIndex = -1;
            this.StateComboBox.SelectedIndexListener = null;
            this.StateComboBox.Size = new System.Drawing.Size(360, 28);
            this.StateComboBox.Sorted = true;
            this.StateComboBox.Source = null;
            this.StateComboBox.TabIndex = 7;
            // 
            // CityEditControl
            // 
            this.CityEditControl.BackColor = System.Drawing.Color.Transparent;
            this.CityEditControl.BottomMargin = 0;
            this.CityEditControl.Editable = true;
            this.CityEditControl.Encrypted = false;
            this.CityEditControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CityEditControl.LabelBottomMargin = 0;
            this.CityEditControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.CityEditControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CityEditControl.LabelText = "City:";
            this.CityEditControl.LabelTopMargin = 4;
            this.CityEditControl.LabelWidth = 140;
            this.CityEditControl.Location = new System.Drawing.Point(16, 308);
            this.CityEditControl.MultiLine = false;
            this.CityEditControl.Name = "CityEditControl";
            this.CityEditControl.OnTextChangedListener = null;
            this.CityEditControl.PasswordMode = false;
            this.CityEditControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.CityEditControl.Size = new System.Drawing.Size(360, 28);
            this.CityEditControl.TabIndex = 6;
            this.CityEditControl.TextBoxBottomMargin = 0;
            this.CityEditControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.CityEditControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.CityEditControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CityEditControl.TextBoxTopMargin = 0;
            this.CityEditControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // UnitEditControl
            // 
            this.UnitEditControl.BackColor = System.Drawing.Color.Transparent;
            this.UnitEditControl.BottomMargin = 0;
            this.UnitEditControl.Editable = true;
            this.UnitEditControl.Encrypted = false;
            this.UnitEditControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnitEditControl.LabelBottomMargin = 0;
            this.UnitEditControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.UnitEditControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UnitEditControl.LabelText = "Unit:";
            this.UnitEditControl.LabelTopMargin = 4;
            this.UnitEditControl.LabelWidth = 140;
            this.UnitEditControl.Location = new System.Drawing.Point(16, 266);
            this.UnitEditControl.MultiLine = false;
            this.UnitEditControl.Name = "UnitEditControl";
            this.UnitEditControl.OnTextChangedListener = null;
            this.UnitEditControl.PasswordMode = false;
            this.UnitEditControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UnitEditControl.Size = new System.Drawing.Size(244, 28);
            this.UnitEditControl.TabIndex = 5;
            this.UnitEditControl.TextBoxBottomMargin = 0;
            this.UnitEditControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.UnitEditControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.UnitEditControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UnitEditControl.TextBoxTopMargin = 0;
            this.UnitEditControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // AddressEditControl
            // 
            this.AddressEditControl.BackColor = System.Drawing.Color.Transparent;
            this.AddressEditControl.BottomMargin = 0;
            this.AddressEditControl.Editable = true;
            this.AddressEditControl.Encrypted = false;
            this.AddressEditControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressEditControl.LabelBottomMargin = 0;
            this.AddressEditControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.AddressEditControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AddressEditControl.LabelText = "Address:";
            this.AddressEditControl.LabelTopMargin = 4;
            this.AddressEditControl.LabelWidth = 140;
            this.AddressEditControl.Location = new System.Drawing.Point(16, 224);
            this.AddressEditControl.MultiLine = false;
            this.AddressEditControl.Name = "AddressEditControl";
            this.AddressEditControl.OnTextChangedListener = null;
            this.AddressEditControl.PasswordMode = false;
            this.AddressEditControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AddressEditControl.Size = new System.Drawing.Size(524, 28);
            this.AddressEditControl.TabIndex = 4;
            this.AddressEditControl.TextBoxBottomMargin = 0;
            this.AddressEditControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.AddressEditControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.AddressEditControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AddressEditControl.TextBoxTopMargin = 0;
            this.AddressEditControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // ActiveEditCheckBox
            // 
            this.ActiveEditCheckBox.BackColor = System.Drawing.Color.Transparent;
            this.ActiveEditCheckBox.CheckBoxHorizontalOffSet = 2;
            this.ActiveEditCheckBox.CheckBoxVerticalOffSet = 3;
            this.ActiveEditCheckBox.CheckChangedListener = null;
            this.ActiveEditCheckBox.Checked = true;
            this.ActiveEditCheckBox.Editable = true;
            this.ActiveEditCheckBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ActiveEditCheckBox.ForeColor = System.Drawing.Color.LemonChiffon;
            this.ActiveEditCheckBox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.ActiveEditCheckBox.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ActiveEditCheckBox.LabelText = "Active:";
            this.ActiveEditCheckBox.LabelWidth = 140;
            this.ActiveEditCheckBox.Location = new System.Drawing.Point(16, 182);
            this.ActiveEditCheckBox.Name = "ActiveEditCheckBox";
            this.ActiveEditCheckBox.Size = new System.Drawing.Size(360, 28);
            this.ActiveEditCheckBox.TabIndex = 3;
            // 
            // EmailEditControl
            // 
            this.EmailEditControl.BackColor = System.Drawing.Color.Transparent;
            this.EmailEditControl.BottomMargin = 0;
            this.EmailEditControl.Editable = true;
            this.EmailEditControl.Encrypted = false;
            this.EmailEditControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailEditControl.LabelBottomMargin = 0;
            this.EmailEditControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.EmailEditControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmailEditControl.LabelText = "Email:";
            this.EmailEditControl.LabelTopMargin = 4;
            this.EmailEditControl.LabelWidth = 140;
            this.EmailEditControl.Location = new System.Drawing.Point(16, 140);
            this.EmailEditControl.MultiLine = false;
            this.EmailEditControl.Name = "EmailEditControl";
            this.EmailEditControl.OnTextChangedListener = null;
            this.EmailEditControl.PasswordMode = false;
            this.EmailEditControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.EmailEditControl.Size = new System.Drawing.Size(524, 28);
            this.EmailEditControl.TabIndex = 2;
            this.EmailEditControl.TextBoxBottomMargin = 0;
            this.EmailEditControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.EmailEditControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.EmailEditControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailEditControl.TextBoxTopMargin = 0;
            this.EmailEditControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // LastNameEditControl
            // 
            this.LastNameEditControl.BackColor = System.Drawing.Color.Transparent;
            this.LastNameEditControl.BottomMargin = 0;
            this.LastNameEditControl.Editable = true;
            this.LastNameEditControl.Encrypted = false;
            this.LastNameEditControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameEditControl.LabelBottomMargin = 0;
            this.LastNameEditControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.LastNameEditControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LastNameEditControl.LabelText = "Last Name:";
            this.LastNameEditControl.LabelTopMargin = 4;
            this.LastNameEditControl.LabelWidth = 140;
            this.LastNameEditControl.Location = new System.Drawing.Point(16, 98);
            this.LastNameEditControl.MultiLine = false;
            this.LastNameEditControl.Name = "LastNameEditControl";
            this.LastNameEditControl.OnTextChangedListener = null;
            this.LastNameEditControl.PasswordMode = false;
            this.LastNameEditControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.LastNameEditControl.Size = new System.Drawing.Size(360, 28);
            this.LastNameEditControl.TabIndex = 1;
            this.LastNameEditControl.TextBoxBottomMargin = 0;
            this.LastNameEditControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.LastNameEditControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.LastNameEditControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LastNameEditControl.TextBoxTopMargin = 0;
            this.LastNameEditControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // FirstNameEditControl
            // 
            this.FirstNameEditControl.BackColor = System.Drawing.Color.Transparent;
            this.FirstNameEditControl.BottomMargin = 0;
            this.FirstNameEditControl.Editable = true;
            this.FirstNameEditControl.Encrypted = false;
            this.FirstNameEditControl.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameEditControl.LabelBottomMargin = 0;
            this.FirstNameEditControl.LabelColor = System.Drawing.Color.LemonChiffon;
            this.FirstNameEditControl.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FirstNameEditControl.LabelText = "First Name:";
            this.FirstNameEditControl.LabelTopMargin = 4;
            this.FirstNameEditControl.LabelWidth = 140;
            this.FirstNameEditControl.Location = new System.Drawing.Point(16, 56);
            this.FirstNameEditControl.MultiLine = false;
            this.FirstNameEditControl.Name = "FirstNameEditControl";
            this.FirstNameEditControl.OnTextChangedListener = null;
            this.FirstNameEditControl.PasswordMode = false;
            this.FirstNameEditControl.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FirstNameEditControl.Size = new System.Drawing.Size(360, 28);
            this.FirstNameEditControl.TabIndex = 0;
            this.FirstNameEditControl.TextBoxBottomMargin = 0;
            this.FirstNameEditControl.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.FirstNameEditControl.TextBoxEditableColor = System.Drawing.Color.White;
            this.FirstNameEditControl.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FirstNameEditControl.TextBoxTopMargin = 0;
            this.FirstNameEditControl.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // MemberIdControl2
            // 
            this.MemberIdControl2.BackColor = System.Drawing.Color.Transparent;
            this.MemberIdControl2.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MemberIdControl2.ForeColor = System.Drawing.Color.LemonChiffon;
            this.MemberIdControl2.LabelColor = System.Drawing.Color.LemonChiffon;
            this.MemberIdControl2.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MemberIdControl2.LabelText = "Member Id:";
            this.MemberIdControl2.LabelWidth = 140;
            this.MemberIdControl2.Location = new System.Drawing.Point(16, 14);
            this.MemberIdControl2.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MemberIdControl2.Name = "MemberIdControl2";
            this.MemberIdControl2.Size = new System.Drawing.Size(360, 28);
            this.MemberIdControl2.TabIndex = 9;
            this.MemberIdControl2.ValueLabelColor = System.Drawing.Color.LemonChiffon;
            this.MemberIdControl2.ValueLabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            // 
            // FilterTextBox
            // 
            this.FilterTextBox.BackColor = System.Drawing.Color.Transparent;
            this.FilterTextBox.BottomMargin = 0;
            this.FilterTextBox.Editable = true;
            this.FilterTextBox.Encrypted = false;
            this.FilterTextBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilterTextBox.LabelBottomMargin = 0;
            this.FilterTextBox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.FilterTextBox.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FilterTextBox.LabelText = "Filter:";
            this.FilterTextBox.LabelTopMargin = 4;
            this.FilterTextBox.LabelWidth = 0;
            this.FilterTextBox.Location = new System.Drawing.Point(23, 53);
            this.FilterTextBox.MultiLine = false;
            this.FilterTextBox.Name = "FilterTextBox";
            this.FilterTextBox.OnTextChangedListener = null;
            this.FilterTextBox.PasswordMode = false;
            this.FilterTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FilterTextBox.Size = new System.Drawing.Size(276, 28);
            this.FilterTextBox.TabIndex = 15;
            this.FilterTextBox.TextBoxBottomMargin = 0;
            this.FilterTextBox.TextBoxDisabledColor = System.Drawing.Color.LightGray;
            this.FilterTextBox.TextBoxEditableColor = System.Drawing.Color.White;
            this.FilterTextBox.TextBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilterTextBox.TextBoxTopMargin = 0;
            this.FilterTextBox.Theme = DataJuggler.Win.Controls.Enumerations.ThemeEnum.Dark;
            // 
            // FilterLabel
            // 
            this.FilterLabel.BackColor = System.Drawing.Color.Transparent;
            this.FilterLabel.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilterLabel.ForeColor = System.Drawing.Color.LemonChiffon;
            this.FilterLabel.Location = new System.Drawing.Point(316, 466);
            this.FilterLabel.Name = "FilterLabel";
            this.FilterLabel.Size = new System.Drawing.Size(360, 69);
            this.FilterLabel.TabIndex = 16;
            this.FilterLabel.Text = "* To improve performance, the listbox only loads 50 items at a time. The listbox " +
    "will update after one or more characters are typed.\r\n\r\n";
            // 
            // FilterComboBox
            // 
            this.FilterComboBox.BackColor = System.Drawing.Color.Transparent;
            this.FilterComboBox.ComboBoxLeftMargin = 1;
            this.FilterComboBox.ComboBoxText = "";
            this.FilterComboBox.ComoboBoxFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilterComboBox.Editable = true;
            this.FilterComboBox.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FilterComboBox.HideLabel = false;
            this.FilterComboBox.LabelBottomMargin = 0;
            this.FilterComboBox.LabelColor = System.Drawing.Color.LemonChiffon;
            this.FilterComboBox.LabelFont = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FilterComboBox.LabelText = "* Filter By:";
            this.FilterComboBox.LabelTopMargin = 4;
            this.FilterComboBox.LabelWidth = 108;
            this.FilterComboBox.List = null;
            this.FilterComboBox.Location = new System.Drawing.Point(23, 16);
            this.FilterComboBox.Name = "FilterComboBox";
            this.FilterComboBox.SelectedIndex = -1;
            this.FilterComboBox.SelectedIndexListener = null;
            this.FilterComboBox.Size = new System.Drawing.Size(276, 28);
            this.FilterComboBox.Sorted = true;
            this.FilterComboBox.Source = null;
            this.FilterComboBox.TabIndex = 17;
            // 
            // FilterTimer
            // 
            this.FilterTimer.Tick += new System.EventHandler(this.FilterTimer_Tick);
            // 
            // EditMembersForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::Demo.Properties.Resources.BlackImage;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(948, 597);
            this.Controls.Add(this.FilterComboBox);
            this.Controls.Add(this.FilterLabel);
            this.Controls.Add(this.FilterTextBox);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.StatusLabel);
            this.Controls.Add(this.Graph);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MembersListBox);
            this.Controls.Add(this.MemberDetailViewPanel);
            this.Controls.Add(this.MemberDetailEditPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditMembersForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excelerate Win Forms Demo";
            this.Activated += new System.EventHandler(this.EditMembersForm_Activated);
            this.MemberDetailViewPanel.ResumeLayout(false);
            this.MemberDetailEditPanel.ResumeLayout(false);
            this.ResumeLayout(false);

            }
            #endregion
            
        #endregion
        
    }
    #endregion

}
