using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SportEventsLab
{
	public partial class NewEventWindow : Form
	{
		public NewEventWindow()
		{
			InitializeComponent();
		}

		private void AddEventButton_Click(object sender, EventArgs e)
		{
			string[] newEvent = { EventTypeTextBox.Text,
							      EventLeagueNameTextBox.Text,
				   			      EventNameTextBox.Text,
								  EventDateDatePicker.Text,
								  EventWinnerTextBox.Text};
			Data.Output.Handler.SaveToDataBase(newEvent);
			this.Close();
		}
	}
}
