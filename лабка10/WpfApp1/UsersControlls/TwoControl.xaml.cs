using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1.UsersControlls
{
    /// <summary>
    /// Логика взаимодействия для TwoControl.xaml
    /// </summary>
    public partial class TwoControl : UserControl
    {
        public TwoControl()
        {
            InitializeComponent();
            sliderBlue.Value = 255.0;
            sliderBlue.Value = 0.0;
        }
        public int sost = 1;
        private void ColorChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {

            if (sost != 0)
            {
                sost = 1;
                Color color = Color.FromRgb((byte)(int)sliderRed.Value, (byte)(int)sliderGreen.Value, (byte)(int)sliderBlue.Value);
                Rect.Background = new SolidColorBrush(color);
                sost = 1;
                Colors col = (Colors)this.Resources["Colo"];
                col.RedCol = (int)sliderRed.Value + "";
                col.GreenCol = (int)sliderGreen.Value + "";
                col.BlueCol = (int)sliderBlue.Value + "";
                sost = 2;
            }
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (sost != 1)
            {
                sost = 0;
                Colors col = (Colors)this.Resources["Colo"];
                if (Red.Text == "") Red.Text = "0";
                if (Green.Text == "") Green.Text = "0";
                if (Blue.Text == "") Blue.Text = "0";
                sliderRed.Value = double.Parse(Red.Text);
                sliderGreen.Value = double.Parse(Green.Text);
                sliderBlue.Value = double.Parse(Blue.Text);
                Color color = Color.FromRgb((byte)(int)sliderRed.Value, (byte)(int)sliderGreen.Value, (byte)(int)sliderBlue.Value);
                Rect.Background = new SolidColorBrush(color);
                sost = 2;
            }

        }

        private void Control_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("sender: " + sender.ToString() + "\n" + "source: " + e.Source.ToString() + "\n\n");
        }

        private void button_MouseEnter(object sender, MouseEventArgs e)
        {
            MessageBox.Show("sender: " + sender.ToString() + "\n" + "source: " + e.Source.ToString() + "\n\n");
        }
    }

    public class Colors : DependencyObject
    {
        public static readonly DependencyProperty RedColProperty;
        public static readonly DependencyProperty GreenColProperty;
        public static readonly DependencyProperty BlueColProperty;

        static Colors()
        {
            PropertyMetadata metadata = new PropertyMetadata
            {
                DefaultValue = "0",
                CoerceValueCallback = new CoerceValueCallback(CorrectValue)
            };
            PropertyMetadata metadata1 = new PropertyMetadata
            {
                DefaultValue = "0",
                CoerceValueCallback = new CoerceValueCallback(CorrectValue)
            };
            PropertyMetadata metadata2 = new PropertyMetadata
            {
                DefaultValue = "0",
                CoerceValueCallback = new CoerceValueCallback(CorrectValue)
            };

            //metadata.CoerceValueCallback = new CoerceValueCallback(CorrectValue);
            RedColProperty = DependencyProperty.Register("RedCol", typeof(string), typeof(Colors), metadata,
            new ValidateValueCallback(ValidateValue));
            GreenColProperty = DependencyProperty.Register("GreenCol", typeof(string), typeof(Colors), metadata1,
            new ValidateValueCallback(ValidateValue));
            BlueColProperty = DependencyProperty.Register("BlueCol", typeof(string), typeof(Colors), metadata2,
            new ValidateValueCallback(ValidateValue));
        }
        private static object CorrectValue(DependencyObject d, object baseValue)
        {
            if (baseValue != null)
            {
                int currentValue = int.Parse((string)baseValue);
                if (currentValue > 255)
                    return "255";
                if (currentValue < 0) return "0";
            }
            return baseValue; // иначе возвращаем текущее значение
        }
        private static bool ValidateValue(object value)
        {
            if (value != null)
            {
                int currentValue = int.Parse((string)value);
                if (currentValue >= 0 && currentValue <= 255) // если текущее значение от нуля и выше
                    return true;
            }
            return false;

        }
        public string RedCol
        {
            get { return (string)GetValue(RedColProperty); }
            set { SetValue(RedColProperty, value); }
        }
        public string GreenCol
        {
            get { return (string)GetValue(GreenColProperty); }
            set { SetValue(GreenColProperty, value); }
        }
        public string BlueCol
        {
            get { return (string)GetValue(BlueColProperty); }
            set { SetValue(BlueColProperty, value); }
        }

    }
}
