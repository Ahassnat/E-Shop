using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace E_Shop.Models
{
    public class IndexViewModel
    {
        public NoticRowModel noticRow { get; private set; } = new NoticRowModel();

        private void LoadDefaultValues()
        {
            var strNotifyMessage = "Free Shipping for order above 270";
            noticRow = new NoticRowModel(strNotifyMessage);
            CreateCarousel();
        }
        public CarouselRowModel carouselRow { get; private set; } = new CarouselRowModel();

        private void CreateCarousel()
        {
            carouselRow = new CarouselRowModel();
            carouselRow.AddCarouselItem("caro1.jpg", "01", true);
            carouselRow.AddCarouselItem("caro2.jpg", "02");
            carouselRow.AddCarouselItem("caro3.jpg", "03");
            carouselRow.AddCarouselItem("caro4.jpg", "04");
            //  carouselRow.ShowIndicators = false;
            //carouselRow.ShowIndicators = true;
            //carouselRow.ApplyTopPadding(2);
            //carouselRow.ShowNextBtn = false;
            //carouselRow.ShowPreviousBtn = false;
        }

        public IndexViewModel()
        {
            LoadDefaultValues();
        }
        
    }
}
