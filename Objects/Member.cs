

#region using statements

using DataJuggler.Excelerate;
using DataJuggler.UltimateHelper;
using System;

#endregion

namespace Demo.Objects
{

    #region class Member
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
        /// Create a new instance of a Member object
        /// </summary>
        public Member()
        {
            // Default to Active
            Active = true;
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

            #region ToString()
            /// <summary>
            /// method returns the FullName when ToString is called
            /// </summary>
            public override string ToString()
            {
                // return fullName
                return this.FullName;
            }
            #endregion
            
        #endregion

        #region Properties

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

            #region bool Active
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

            #region HasAddress
            /// <summary>
            /// This property returns true if this object has an 'Address'.
            /// </summary>
            public bool HasAddress
            {
                get
                {
                    // initial value
                    bool hasAddress = (this.Address != null);
                    
                    // return value
                    return hasAddress;
                }
            }
            #endregion
            
            #region string EmailAddress
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

            #region string FirstName
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

            #region int Id
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

            #region string LastName
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

            #region Guid RowId
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