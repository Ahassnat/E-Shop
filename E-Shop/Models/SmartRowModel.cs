using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Shop.Models
{
    public abstract class SmartRowModel
    {
        public string CssClass { get; private set; } = "";
        private string _cssTopPadding = "";
        private string _cssBottomPadding = "";
        private void ApplyPadding()
        {
            CssClass = _cssTopPadding + " " + _cssBottomPadding;
        }
        internal void ApplyTopPadding(int pd = 1)
        {
            if (pd > 5 || pd < 0)
            {
                throw new Exception("Padding Length shoud be between 0 to 5");
            }
            _cssTopPadding = "pt-" + pd.ToString();
            ApplyPadding();
        }
        internal void ApplyBottomPadding(int pd = 1)
        {
            if (pd > 5 || pd < 0)
            {
                throw new Exception("Padding Length shoud be between 0 to 5");
            }
            _cssBottomPadding = "pb-" + pd.ToString();
            ApplyPadding();
        }
    }
}
