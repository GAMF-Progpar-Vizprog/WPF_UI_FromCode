using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;

namespace WPF_UI_FromCode
{
	public partial class wndMain : Window
	{
		public wndMain()
		{
			InitializeComponent();
			Title = "UI from C# code";
			Width = 300;
			Height = 100;
			WindowStartupLocation = WindowStartupLocation.CenterScreen;

			var ugGrid = new UniformGrid
			{
				Columns = 2,
				Rows = 1
			};


			var btMessage = new Button
			{
				Content = "Message",
				Height = 30,
				Width = 100,
				VerticalAlignment = VerticalAlignment.Center,
				HorizontalAlignment = HorizontalAlignment.Center
			};
			btMessage.Click += btMessage_Click;


			var btExit = new Button
			{
				Content = "Exit",
				Height = 30,
				Width = 100,
				VerticalAlignment = VerticalAlignment.Center,
				HorizontalAlignment = HorizontalAlignment.Center
			};
			btExit.Click += btExit_Click;


			ugGrid.Children.Add(btMessage);
			ugGrid.Children.Add(btExit);


			AddChild(ugGrid);
			
		}

		void btMessage_Click(object sender, RoutedEventArgs e)
		{
			MessageBox.Show("Message");
		}

		void btExit_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
	}

}
