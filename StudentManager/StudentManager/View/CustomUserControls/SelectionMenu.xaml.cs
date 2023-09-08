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

namespace StudentManager.View.CustomUserControls
{
	/// <summary>
	/// Interaction logic for SelectionMenu.xaml
	/// </summary>
	public partial class SelectionMenu : UserControl
	{
		public event EventHandler AddButtonClicked;
		public event EventHandler RemoveButtonClicked;
		public event EventHandler EditButtonClicked;
		public event EventHandler ViewButtonClicked;

		public SelectionMenu()
		{
			InitializeComponent();
		}

		private void AddButton_Click(object sender, RoutedEventArgs e)
		{
			AddButtonClicked?.Invoke(this, EventArgs.Empty);
		}

		private void RemoveButton_Click(object sender, RoutedEventArgs e)
		{
			RemoveButtonClicked?.Invoke(this, EventArgs.Empty);
		}

		private void EditButton_Click(object sender, RoutedEventArgs e)
		{
			EditButtonClicked?.Invoke(this, EventArgs.Empty);
		}

		private void ViewButton_Click(object sender, RoutedEventArgs e)
		{
			ViewButtonClicked?.Invoke(this, EventArgs.Empty);
		}
	}
}
