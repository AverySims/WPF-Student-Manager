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

namespace StudentManager
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
			ChangePanelVisibility(StudentView);
		}

		private void Student_Add(object sender, EventArgs e)
		{
			//AddStudent?.Invoke(this, EventArgs.Empty);
		}

		private void Student_Remove(object sender, EventArgs e)
		{
			//RemoveStudent?.Invoke(this, EventArgs.Empty);
		}

		private void Student_Edit(object sender, EventArgs e)
		{
			//EditStudent?.Invoke(this, EventArgs.Empty);
		}

		private void Student_View(object sender, EventArgs e)
		{
			ChangePanelVisibility(StudentView);
		}

		private void ChangePanelVisibility(UserControl panel)
		{
			switch (StudentView.Visibility)
			{
				case Visibility.Visible:

					StudentView.Visibility = Visibility.Collapsed;

					break;
				case Visibility.Hidden:

					StudentView.Visibility = Visibility.Visible;

					break;
				case Visibility.Collapsed:

					StudentView.Visibility = Visibility.Visible;

					break;
			}
		}
	}
}