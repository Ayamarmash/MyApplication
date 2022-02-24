using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MyApplication
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            String MyDate = DateTime.Now.ToString();
            MyLabel.Text = "Aya Marmash" + "\n" + MyDate;
        }

        private void ImageButton_Clicked(object sender, EventArgs e)
        {
            WebPage.Source = "https://zajel.najah.edu/";
        }

        private void ImageButton_Clicked_1(object sender, EventArgs e)
        {
            WebPage.Source = "https://google.ps";
        }
    }
}
