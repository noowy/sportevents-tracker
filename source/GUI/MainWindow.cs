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
	public partial class MainWindow : Form
	{
		private string SelectedEvent { get; set; }

		public MainWindow()
		{
			InitializeComponent();
		}

		private void AddEventButton_Click(object sender, EventArgs e)
		{
			AddEventWindow = new NewEventWindow();
			AddEventWindow.Show();
			AddEventWindow.FormClosed += new FormClosedEventHandler(
				SportEventsListUpdate);
		}

		private void SportEventsListUpdate(object sender, EventArgs e)
		{
			List<string>[] names;
			names = Data.Input.Handler.GetFieldsFromDataBase("Name");
			SportEventsList.Items.Clear();

			SportEventsList.BeginUpdate();
			for (int i = 0; i < names[0].Count; i++)
			{
				SportEventsList.Items.Add(names[0][i]);
			}
			SportEventsList.EndUpdate();
		}

		private void SportEventsList_DoubleClick(object sender, EventArgs e)
		{
			if (SportEventsList.SelectedItem == null)
				return;

			string selectedName = SportEventsList.SelectedItem.ToString();
			List<string> chosenEvent = Data.Input.
											Handler.
											GetEntryFromDataBase(selectedName);

			PutEventInTextBoxes(chosenEvent);
			MakeChosenEventVisible();
			SelectedEvent = selectedName;
		}

		private void SaveChangesButton_Click(object sender, EventArgs e)
		{
			string[] changedEvent = { EventTypeTextBox.Text,
									  EventLeagueTextBox.Text,
									  EventNameTextBox.Text,
									  EventDateDatePicker.Text,
									  EventWinnerTextBox.Text};
			Data.Output.Handler.SaveToDataBase(SelectedEvent, changedEvent);
			SelectedEvent = EventNameTextBox.Text;
		}

		private void PutEventInTextBoxes(List<string> theEvent)
		{
			EventTypeTextBox.Text = theEvent[0];
			EventLeagueTextBox.Text = theEvent[1];
			EventNameTextBox.Text = theEvent[2];
			EventDateDatePicker.Text = theEvent[3];
			EventWinnerTextBox.Text = theEvent[4];
		}

		private void MakeChosenEventVisible()
		{
			label1.Visible = true;
			label2.Visible = true;
			label3.Visible = true;
			label4.Visible = true;
			label5.Visible = true;
			EventTypeTextBox.Visible = true;
			EventLeagueTextBox.Visible = true;
			EventNameTextBox.Visible = true;
			EventDateDatePicker.Visible = true;
			EventWinnerTextBox.Visible = true;
			SaveChangesButton.Visible = false;
		}

		private void EventTextBox_Enter(object sender, EventArgs e)
		{
			SaveChangesButton.Visible = true;
		}

		private void saveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (saveFileDialog1.ShowDialog() == DialogResult.OK)
			{
				Data.Output.Handler.SaveToTextFile(saveFileDialog1.FileName);
			}
			else
			{
				MessageBox.Show("Data wasn't saved to text file");
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Environment.Exit(1);
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show(@"Laboratory work #4
Use of SQLite database.
Create a program for creating and saving sport events.
Student of 464th group, Soldatkin Anton Igorevich, 2018.", "About");
		}
	}
}
