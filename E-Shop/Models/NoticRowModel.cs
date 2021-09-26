using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Shop.Models
{
    public class NoticRowModel: SmartRowModel
    {
        public NoticRowModel()
        {
                
        }
        public string NotifyText { get;private set; } = "";
        public NoticRowModel(string strMessage)
        {
            this.NotifyText = strMessage;
        }
    }
}
