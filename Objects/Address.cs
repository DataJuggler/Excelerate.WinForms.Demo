

#region using statements

using DataJuggler.Excelerate;
using DataJuggler.UltimateHelper;
using System;

#endregion

namespace Demo.Objects
{

    #region class Address
    public class Address
    {

        #region Private Variables
        private string city;
        private int id;
        private int memberId;
        private Guid rowId;
        private int stateId;
        private string streetAddress;
        private string unit;
        private string zipCode;
        #endregion

        #region Methods

            #region Load(Row row)
            /// <summary>
            /// This method loads a Address object from a Row.
            /// </Summary>
            /// <param name="row">The row which the row.Columns[x].ColumnValue will be used to load this object.</param>
            public void Load(Row row)
            {
                // If the row exists and the row's column collection exists
                if ((NullHelper.Exists(row)) && (row.HasColumns))
                {
                    Id = row.Columns[0].IntValue;
                    MemberId = row.Columns[1].IntValue;
                    StreetAddress = row.Columns[2].StringValue;
                    Unit = row.Columns[3].StringValue;
                    City = row.Columns[4].StringValue;
                    StateId = row.Columns[5].IntValue;
                    ZipCode = row.Columns[6].StringValue;
                }

                // Set RowId
                RowId = row.Id;
            }
            #endregion

            #region Save(Row row)
            /// <summary>
            /// This method saves a Address object back to a Row.
            /// </Summary>
            /// <param name="row">The row which the row.Columns[x].ColumnValue will be set to Save back to Excel.</param>
            public void Save(Row row)
            {
                // If the row exists and the row's column collection exists
                if ((NullHelper.Exists(row)) && (row.HasColumns))
                {
                    row.Columns[0].ColumnValue = Id;
                    row.Columns[1].ColumnValue = MemberId;
                    row.Columns[2].ColumnValue = StreetAddress;
                    row.Columns[3].ColumnValue = Unit;
                    row.Columns[4].ColumnValue = City;
                    row.Columns[5].ColumnValue = StateId;
                    row.Columns[6].ColumnValue = ZipCode;
                }
            }
            #endregion

        #endregion

        #region Properties

            #region string City
            public string City
            {
                get
                {
                    return city;
                }
                set
                {
                    city = value;
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

            #region int MemberId
            public int MemberId
            {
                get
                {
                    return memberId;
                }
                set
                {
                    memberId = value;
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

            #region int StateId
            public int StateId
            {
                get
                {
                    return stateId;
                }
                set
                {
                    stateId = value;
                }
            }
            #endregion

            #region string StreetAddress
            public string StreetAddress
            {
                get
                {
                    return streetAddress;
                }
                set
                {
                    streetAddress = value;
                }
            }
            #endregion

            #region string Unit
            public string Unit
            {
                get
                {
                    return unit;
                }
                set
                {
                    unit = value;
                }
            }
            #endregion

            #region string ZipCode
            public string ZipCode
            {
                get
                {
                    return zipCode;
                }
                set
                {
                    zipCode = value;
                }
            }
            #endregion

        #endregion

    }
    #endregion

}