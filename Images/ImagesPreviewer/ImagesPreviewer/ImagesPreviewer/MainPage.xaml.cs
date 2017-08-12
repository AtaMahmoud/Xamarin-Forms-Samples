using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ImagesPreviewer
{
    public partial class MainPage : ContentPage
    {
        public int ImageId { get; set; }
        public MainPage()
        {
            InitializeComponent();
            ImageId = 0;
            LoadImage();
            
        }
        
        void LoadImage()
        {
            image.Source = new UriImageSource
            {
                Uri = new Uri(string.Format("http://lorempixel.com/1920/1080/city/{0}", ImageId)),
                CachingEnabled = false
            };
              
        }
        private void Previous_Clicked(object sender, EventArgs e)
        {
            ImageId--;
            if (ImageId == 0)
            {
                ImageId = 10;
            }
            LoadImage();
           
                

        }

        private void Next_Clicked(object sender, EventArgs e)
        {
            ImageId++;
            if(ImageId ==10)
            {
                ImageId = 0;
            }
            LoadImage();
        }
    }
}
