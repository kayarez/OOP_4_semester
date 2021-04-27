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
    /// Логика взаимодействия для SecondControl.xaml
    /// </summary>
    public partial class MyControl : UserControl
    {
	//	public static RoutedEvent 


		public MyControl()
        {
            InitializeComponent();
        }

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Chips phone = (Chips)this.Resources["Lays"];
			MessageBox.Show(phone.Price.ToString());
		}

	

		private void Control_MouseDown(object sender, MouseButtonEventArgs e)
		{
			textBlock1.Text = textBlock1.Text + "sender: " + sender.ToString() + "\n";
			textBlock1.Text = textBlock1.Text + "source: " + e.Source.ToString() + "\n";

		}

		private void Control_MouseDown2(object sender, MouseButtonEventArgs e)
		{
			textBlock2.Text = textBlock2.Text + "sender: " + sender.ToString() + "\n";
			textBlock2.Text = textBlock2.Text + "source: " + e.Source.ToString() + "\n";

		}

		private void Control_MouseDown3(object sender, MouseButtonEventArgs e)
		{
			textBlock3.Text = textBlock3.Text + "sender: " + sender.ToString() + "\n";
			textBlock3.Text = textBlock3.Text + "source: " + e.Source.ToString() + "\n";

		}


		private void Exit_Executed(object sender, ExecutedRoutedEventArgs e)
		{
			using (System.IO.StreamWriter writer = new System.IO.StreamWriter("log.txt", true))
			{
				writer.WriteLine("Выход из приложения: " + DateTime.Now.ToShortDateString() + " " +
				DateTime.Now.ToLongTimeString());
				writer.Flush();
			}

			//this.Close();
		}
	}

	public class Chips : DependencyObject
	{
		public static readonly DependencyProperty TitleProperty;
		public static readonly DependencyProperty PriceProperty;

		static Chips()
		{
			TitleProperty = DependencyProperty.Register("Title", typeof(string), typeof(Chips));

			FrameworkPropertyMetadata metadata = new FrameworkPropertyMetadata();
			metadata.CoerceValueCallback = new CoerceValueCallback(CorrectValue);

			PriceProperty = DependencyProperty.Register("Price", typeof(int), typeof(Chips), metadata,
				new ValidateValueCallback(ValidateValue));
		}

		private static object CorrectValue(DependencyObject d, object baseValue)
		{
			int currentValue = (int)baseValue;
			if (currentValue > 1000)  
				return 1000;
			return currentValue;
		}

		private static bool ValidateValue(object value)
		{
			int currentValue = (int)value;
			if (currentValue >= 0)
				return true;
			return false;
		}

		public string Title
		{
			get { return (string)GetValue(TitleProperty); }
			set { SetValue(TitleProperty, value); }
		}
		public int Price
		{
			get { return (int)GetValue(PriceProperty); }
			set { SetValue(PriceProperty, value); }
		}
	}

	public class WindowComands
	{
		static WindowComands()
		{
			Exit = new RoutedCommand("Exit", typeof(MainWindow));
		}
		public static RoutedCommand Exit { get; set; }
	}
}
