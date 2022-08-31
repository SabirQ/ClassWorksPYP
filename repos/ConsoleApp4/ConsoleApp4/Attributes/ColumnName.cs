using System;
using System.Collections.Generic;
using System.Text;
namespace ConsoleApp4.Attributes
{
    public class ColumnName: Attribute
    {
        private string? _displayName;

        public ColumnName()
        {

        }
        public ColumnName(string displayname)
        {
            _displayName = displayname;
        }
        public string DisplayName => this._displayName;
    }
}
