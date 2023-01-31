

#region using statements

using DataJuggler.Excelerate;
using DataJuggler.Net7;
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

            #region NewRow(Row row)
            /// <summary>
            /// This method creates the columns for the row to save a new Address object.
            /// </Summary>
            /// <param name="row">The row which the Columns will be created for.</param>
            public static Row NewRow(int rowNumber)
            {
                // initial value
                Row newRow = new Row();

                // Create Column
                Column idColumn = new Column("Id", rowNumber, 1, DataManager.DataTypeEnum.Integer);

                // Add this column
                newRow.Columns.Add(idColumn);

                // Create Column
                Column memberIdColumn = new Column("MemberId", rowNumber, 2, DataManager.DataTypeEnum.Integer);

                // Add this column
                newRow.Columns.Add(memberIdColumn);

                // Create Column
                Column streetAddressColumn = new Column("StreetAddress", rowNumber, 3, DataManager.DataTypeEnum.String);

                // Add this column
                newRow.Columns.Add(streetAddressColumn);

                // Create Column
                Column unitColumn = new Column("Unit", rowNumber, 4, DataManager.DataTypeEnum.String);

                // Add this column
                newRow.Columns.Add(unitColumn);

                // Create Column
                Column cityColumn = new Column("City", rowNumber, 5, DataManager.DataTypeEnum.String);

                // Add this column
                newRow.Columns.Add(cityColumn);

                // Create Column
                Column stateIdColumn = new Column("StateId", rowNumber, 6, DataManager.DataTypeEnum.Integer);

                // Add this column
                newRow.Columns.Add(stateIdColumn);

                // Create Column
                Column zipCodeColumn = new Column("ZipCode", rowNumber, 7, DataManager.DataTypeEnum.String);

                // Add this column
                newRow.Columns.Add(zipCodeColumn);

                // return value
                return newRow;
            }
            #endregion

            #region Save(Row row)
            /// <summary>
            /// This method saves a Address object back to a Row.
            /// </Summary>
            /// <param name="row">The row which the row.Columns[x].ColumnValue will be set to Save back to Excel.</param>
            public Row Save(Row row)
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

                // return value
                return row;
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