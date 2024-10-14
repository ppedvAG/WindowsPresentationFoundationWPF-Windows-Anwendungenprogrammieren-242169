using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace M001
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			//Erzeugt die GUI
			InitializeComponent();

			//Name: Voller Zugriff auf das UI-Element im C#-Code
			CB.IsChecked = CB.IsChecked;
		}

		/// <summary>
		/// Per Events wird diese Methode mit dem entsprechenden Button verbunden
		/// </summary>
		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Close();
		}
	}
}