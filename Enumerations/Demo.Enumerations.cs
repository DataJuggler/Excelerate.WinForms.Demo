using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Enumerations
{

    #region EditModeEnum
    /// <summary>
    /// This enum is used to determine which PanelExtender to show, View or Edit
    /// </summary>
    public enum EditModeEnum : int
    {
        NothingSelected = 0,
        ReadOnly = 1,
        AddNew = 2,
        Editing = 3
    }
    #endregion

    #region FilterByEnum
    /// <summary>
    /// This enum is used to filter the list
    /// </summary>
    public enum FilterByEnum : int
    {
        Starts_With = 0,
        Contains = 1
    }
    #endregion

}
