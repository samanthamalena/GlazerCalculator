using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace GlazerCalculator
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

           /* Slider volumeSlider = new Slider();
            volumeSlider.Header = "Volume";
            volumeSlider.Width = 200;
            volumeSlider.ValueChanged += volumeSlider_ValueChanged; */

        }
        private void sliderQuantity_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            var sliderQuantity = sender as Slider;

            var quantity = sliderQuantity.Value;

            sldValue.Text = quantity.ToString();

        }
        private void ButCalculate_Click(object sender, RoutedEventArgs e)
        {

            double width, height, woodLength, glassArea;
            string widthString, heightString;

            widthString = txtboxWidthInput.Text;
            width = double.Parse(widthString);

            heightString = txtboxHeightInput.Text;
            height = double.Parse(heightString);

            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height);

            woodLengthOutput.Text = woodLength + " Feet";
            glassAreaOutput.Text = glassArea + " Square meters";
            DateOutput.Text = DateTime.Now.ToString("dddd, dd, MMMM, yyyy");

        }

        private void TxtboxWidthInput_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            string widthString = txtboxWidthInput.Text;
            if (!int.TryParse(widthString, out int width))
            {
                widthNum.Text = "Width must be a number.";
            }
            else
            {
                widthNum.Text = "";
            }
        }

        private void TxtboxHeightInput_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            string heightString = txtboxHeightInput.Text;
            if (!int.TryParse(heightString, out int width))
            {
                heightNum.Text = "Height must be a number.";
            }
            else
            {
                heightNum.Text = "";
            }
        }

            

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

       
    }

}
    