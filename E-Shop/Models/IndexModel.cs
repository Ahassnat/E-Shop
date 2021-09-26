using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Shop.Models
{
    public class IndexModel
    {
        public NoticRowModel noticRow { get; private set; } = new NoticRowModel();

        public IndexModel()
        {
            LoadDefaultValues();
        }
        private void LoadDefaultValues()
        {
            var strNotifyMessage = "Free Shipping for order above 270";
            noticRow = new NoticRowModel(strNotifyMessage);
        }
    }
}
