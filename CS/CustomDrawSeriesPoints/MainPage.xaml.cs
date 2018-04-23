using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using DevExpress.Xpf.Charts;

namespace CustomDrawSeriesPoints
{
    public partial class MainPage : UserControl
    {


        public MainPage()
        {
            InitializeComponent();

        }

        private void chbCustomDraw_Checked(object sender, RoutedEventArgs e)
        {
            if (chart != null)
                chart.UpdateData();
        }

        private void chbCustomDraw_Unchecked(object sender, RoutedEventArgs e)
        {
            if (chart != null)
                chart.UpdateData();
        }

        private void chart_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e)
        {
            if (chbCustomDraw != null)
                if (chbCustomDraw.IsChecked.Value)
                {
                    string color = CorrectDrawOptions(e.SeriesPoint.Value, e.DrawOptions);
                    if (!String.IsNullOrEmpty(color))
                        e.LabelText = color + ": " + e.LabelText;
                }
        }

        string CorrectDrawOptions(double val, DrawOptions drawOptions)
        {
            if (drawOptions == null)
                return "";
            if (val < 1)
            {
                drawOptions.Color = Color.FromArgb(0xFF, 0x51, 0x89, 0x03);
                return "Green";
            }
            else if (val < 2)
            {
                drawOptions.Color = Color.FromArgb(0xFF, 0xF9, 0xAA, 0x0F);
                return "Yellow";
            }
            else
            {
                drawOptions.Color = Color.FromArgb(0xFF, 0xC7, 0x39, 0x0C);
                return "Red";
            }
        }

    }
}
