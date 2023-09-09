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
		private UserControl[] panels;
		private UserControl activePanel;

		public MainWindow()
		{
			InitializeComponent();

			panels = new UserControl[] { StudentView, StudentAdd, StudentRemove };

			MenuButtons.ViewButtonClicked += Student_View;
			MenuButtons.AddButtonClicked += Student_Add;
			MenuButtons.RemoveButtonClicked += Student_Remove;
			// add edit button event handler
		}

		private void Student_Add(object sender, EventArgs e)
		{
			SetActivePanel(StudentAdd);
		}

		private void Student_Remove(object sender, EventArgs e)
		{
			SetActivePanel(StudentRemove);
		}

		private void Student_Edit(object sender, EventArgs e)
		{
			//EditStudent?.Invoke(this, EventArgs.Empty);
		}

		private void Student_View(object sender, EventArgs e)
		{
			SetActivePanel(StudentView);
		}

		private void ChangePanelVisibility(UserControl panel, Visibility newVisibility)
		{
			if (panel != null)
			{
				panel.Visibility = newVisibility;
			}
		}

		private void SetActivePanel(UserControl newActivePanel)
		{
			activePanel = newActivePanel;

			foreach (var current in panels)
			{
				if (current != newActivePanel)
				{
					ChangePanelVisibility(current, Visibility.Collapsed);
				}
				else
				{
					ChangePanelVisibility(current, Visibility.Visible);
				}
			}
		}
	}
}