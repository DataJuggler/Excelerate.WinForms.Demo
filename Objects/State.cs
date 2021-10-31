

#region using statements

using DataJuggler.Excelerate;
using DataJuggler.UltimateHelper;
using System;

#endregion

namespace Demo.Objects
{

    #region class States
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
            /// This method loads a States object from a Row.
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