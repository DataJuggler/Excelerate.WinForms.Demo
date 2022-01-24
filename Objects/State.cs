

#region using statements

using DataJuggler.Excelerate;
using DataJuggler.Net6;
using DataJuggler.UltimateHelper;
using System;

#endregion

namespace Demo.Objects
{

    #region class State
    public class State
    {

        #region Private Variables
        private string code;
        private int id;
        private string name;
        private Guid rowId;
        #endregion

        #region Methods

            #region Load(Row row)
            /// <summary>
            /// This method loads a State object from a Row.
            /// </Summary>
            /// <param name="row">The row which the row.Columns[x].ColumnValue will be used to load this object.</param>
            public void Load(Row row)
            {
                // If the row exists and the row's column collection exists
                if ((NullHelper.Exists(row)) && (row.HasColumns))
                {
                    Id = row.Columns[0].IntValue;
                    Name = row.Columns[1].StringValue;
                    Code = row.Columns[2].StringValue;
                }

                // Set RowId
                RowId = row.Id;
            }
            #endregion

            #region NewRow(Row row)
            /// <summary>
            /// This method creates the columns for the row to save a new State object.
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
                Column nameColumn = new Column("Name", rowNumber, 2, DataManager.DataTypeEnum.String);

                // Add this column
                newRow.Columns.Add(nameColumn);

                // Create Column
                Column codeColumn = new Column("Code", rowNumber, 3, DataManager.DataTypeEnum.String);

                // Add this column
                newRow.Columns.Add(codeColumn);

                // return value
                return newRow;
            }
            #endregion

            #region Save(Row row)
            /// <summary>
            /// This method saves a State object back to a Row.
            /// </Summary>
            /// <param name="row">The row which the row.Columns[x].ColumnValue will be set to Save back to Excel.</param>
            public Row Save(Row row)
            {
                // If the row exists and the row's column collection exists
                if ((NullHelper.Exists(row)) && (row.HasColumns))
                {
                    row.Columns[0].ColumnValue = Id;
                    row.Columns[1].ColumnValue = Name;
                    row.Columns[2].ColumnValue = Code;
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
                return Name;
            }
            #endregion

        #endregion

        #region Properties

            #region string Code
            public string Code
            {
                get
                {
                    return code;
                }
                set
                {
                    code = value;
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

            #region string Name
            public string Name
            {
                get
                {
                    return name;
                }
                set
                {
                    name = value;
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