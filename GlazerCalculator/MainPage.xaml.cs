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

        }

        private void ButCalculate_Click(object sender, RoutedEventArgs e)
        {

            double width, height, woodLength, glassArea;
            width = double.Parse(txtboxWidthInput.Text);
            height = double.Parse(txtboxHeightInput.Text);
            woodLength = 2 * (width + height) * 3.25;
            glassArea = 2 * (width * height) * 3.25;
            double quant = double.Parse(quantityNum.Text);
            string tint = ((ComboBoxItem)tintDropDown.SelectedItem).Content.ToString(); ;
            output.Text = $"Quantity: {quant}\n" +
                $"Tint: {tint}\n" +
                $"Length: {woodLength}\n" +
                $"Area: {glassArea}";
            //txtDate.Text = DateTime.Now.ToString();

        }

        private void TxtboxWidthInput_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            string widthString = txtboxWidthInput.Text;
            if (!int.TryParse(widthString, out int width))
            {
                txtboxWidthInput.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                txtboxWidthInput.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
                widthWarning.Text = "Width must be a number.";
            }
            else
            {
                txtboxWidthInput.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Gray);
                widthWarning.Text = "";
            }
        }

        private void TxtboxHeightInput_KeyUp(object sender, KeyRoutedEventArgs e)
        {
            string heightString = txtboxHeightInput.Text;
            if (!int.TryParse(heightString, out int width))
            {
                txtboxHeightInput.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Red);
                txtboxHeightInput.Foreground = new SolidColorBrush(Windows.UI.Colors.Red);
                heightWarning.Text = "Height must be a number.";
            }
            else
            {
                txtboxHeightInput.BorderBrush = new SolidColorBrush(Windows.UI.Colors.Gray);
                heightWarning.Text = "";
            }
        }

            private void SliderQuantity_ValueChanged(object sender, RangeBaseValueChangedEventArgs e)
        {
            quantityNum.Text = sliderQuantity.Value.ToString();

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }

}
    