using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Shop.Models
{
    public class CarouselRowModel:SmartRowModel
    {
        public List<CarouselItem> CarouselItems = new List<CarouselItem>();
        public bool ShowPreviousBtn { get; set; } = true;
        public bool ShowNextBtn { get; set; } = true;
        public bool ShowIndicators { get; set; } = true;

        public void AddCarouselItem(string strImageName, string strImageText, bool active = false)
        {
            var strImgSrc = @"images/" + strImageName;
            CarouselItems.Add(new CarouselItem(CarouselItems.Count)
            {
                ImagePath = strImgSrc,
                ImageText = strImageText,
                IsActive = active
            }); 
        }
        public class CarouselItem
        {
      
            internal CarouselItem(int idx)
            {
                Index = idx;
            }
            public readonly int Index;
            public bool IsActive { get; set; } = false;
            public string ImagePath { get; set; } = "";
            public string ImageText { get; set; } = "";
        }
    }
}
