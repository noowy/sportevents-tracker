using System;

namespace SportEventsLab
{
	partial class MainWindow
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.EventListLabel = new System.Windows.Forms.Label();
			this.SportEventsList = new System.Windows.Forms.ListBox();
			this.AddEventButton = new System.Windows.Forms.Button();
			this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.EventTypeTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.EventLeagueTextBox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.EventNameTextBox = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.EventDateDatePicker = new System.Windows.Forms.DateTimePicker();
			this.label5 = new System.Windows.Forms.Label();
			this.EventWinnerTextBox = new System.Windows.Forms.TextBox();
			this.SaveChangesButton = new System.Windows.Forms.Button();
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
			this.tableLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel1.SuspendLayout();
			this.flowLayoutPanel2.SuspendLayout();
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.73414F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.26586F));
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel2, 1, 1);
			this.tableLayoutPanel1.Controls.Add(this.menuStrip1, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 94F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(662, 450);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// flowLayoutPanel1
			// 
			this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.flowLayoutPanel1.Controls.Add(this.EventListLabel);
			this.flowLayoutPanel1.Controls.Add(this.SportEventsList);
			this.flowLayoutPanel1.Controls.Add(this.AddEventButton);
			this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(22, 32);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(271, 413);
			this.flowLayoutPanel1.TabIndex = 0;
			// 
			// EventListLabel
			// 
			this.EventListLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.EventListLabel.AutoSize = true;
			this.EventListLabel.Location = new System.Drawing.Point(93, 0);
			this.EventListLabel.Name = "EventListLabel";
			this.EventListLabel.Size = new System.Drawing.Size(87, 13);
			this.EventListLabel.TabIndex = 0;
			this.EventListLabel.Text = "Sport Events List";
			// 
			// SportEventsList
			// 
			this.SportEventsList.FormattingEnabled = true;
			this.SportEventsList.Location = new System.Drawing.Point(3, 16);
			this.SportEventsList.Name = "SportEventsList";
			this.SportEventsList.Size = new System.Drawing.Size(268, 355);
			this.SportEventsList.TabIndex = 1;
			this.SportEventsList.DoubleClick += new System.EventHandler(this.SportEventsList_DoubleClick);
			// 
			// AddEventButton
			// 
			this.AddEventButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.AddEventButton.Location = new System.Drawing.Point(99, 377);
			this.AddEventButton.Name = "AddEventButton";
			this.AddEventButton.Size = new System.Drawing.Size(75, 23);
			this.AddEventButton.TabIndex = 2;
			this.AddEventButton.Text = "Add Event";
			this.AddEventButton.UseVisualStyleBackColor = true;
			this.AddEventButton.Click += new System.EventHandler(this.AddEventButton_Click);
			// 
			// flowLayoutPanel2
			// 
			this.flowLayoutPanel2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.flowLayoutPanel2.Controls.Add(this.label1);
			this.flowLayoutPanel2.Controls.Add(this.EventTypeTextBox);
			this.flowLayoutPanel2.Controls.Add(this.label2);
			this.flowLayoutPanel2.Controls.Add(this.EventLeagueTextBox);
			this.flowLayoutPanel2.Controls.Add(this.label3);
			this.flowLayoutPanel2.Controls.Add(this.EventNameTextBox);
			this.flowLayoutPanel2.Controls.Add(this.label4);
			this.flowLayoutPanel2.Controls.Add(this.EventDateDatePicker);
			this.flowLayoutPanel2.Controls.Add(this.label5);
			this.flowLayoutPanel2.Controls.Add(this.EventWinnerTextBox);
			this.flowLayoutPanel2.Controls.Add(this.SaveChangesButton);
			this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
			this.flowLayoutPanel2.Location = new System.Drawing.Point(337, 50);
			this.flowLayoutPanel2.Name = "flowLayoutPanel2";
			this.flowLayoutPanel2.Size = new System.Drawing.Size(303, 376);
			this.flowLayoutPanel2.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(107, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(92, 13);
			this.label1.TabIndex = 5;
			this.label1.Text = "Type of the Event";
			this.label1.Visible = false;
			// 
			// EventTypeTextBox
			// 
			this.EventTypeTextBox.Location = new System.Drawing.Point(3, 16);
			this.EventTypeTextBox.Name = "EventTypeTextBox";
			this.EventTypeTextBox.Size = new System.Drawing.Size(300, 20);
			this.EventTypeTextBox.TabIndex = 0;
			this.EventTypeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.EventTypeTextBox.Visible = false;
			this.EventTypeTextBox.Enter += new System.EventHandler(this.EventTextBox_Enter);
			// 
			// label2
			// 
			this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(86, 39);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(133, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "League name of the Event";
			this.label2.Visible = false;
			// 
			// EventLeagueTextBox
			// 
			this.EventLeagueTextBox.Location = new System.Drawing.Point(3, 55);
			this.EventLeagueTextBox.Name = "EventLeagueTextBox";
			this.EventLeagueTextBox.Size = new System.Drawing.Size(300, 20);
			this.EventLeagueTextBox.TabIndex = 7;
			this.EventLeagueTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.EventLeagueTextBox.Visible = false;
			this.EventLeagueTextBox.Enter += new System.EventHandler(this.EventTextBox_Enter);
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(105, 78);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(96, 13);
			this.label3.TabIndex = 8;
			this.label3.Text = "Name of the Event";
			this.label3.Visible = false;
			// 
			// EventNameTextBox
			// 
			this.EventNameTextBox.Location = new System.Drawing.Point(3, 94);
			this.EventNameTextBox.Name = "EventNameTextBox";
			this.EventNameTextBox.Size = new System.Drawing.Size(300, 20);
			this.EventNameTextBox.TabIndex = 9;
			this.EventNameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.EventNameTextBox.Visible = false;
			this.EventNameTextBox.Enter += new System.EventHandler(this.EventTextBox_Enter);
			// 
			// label4
			// 
			this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(107, 117);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(91, 13);
			this.label4.TabIndex = 10;
			this.label4.Text = "Date of the Event";
			this.label4.Visible = false;
			// 
			// EventDateDatePicker
			// 
			this.EventDateDatePicker.Location = new System.Drawing.Point(3, 133);
			this.EventDateDatePicker.Name = "EventDateDatePicker";
			this.EventDateDatePicker.Size = new System.Drawing.Size(300, 20);
			this.EventDateDatePicker.TabIndex = 14;
			this.EventDateDatePicker.Visible = false;
			this.EventDateDatePicker.Enter += new System.EventHandler(this.EventTextBox_Enter);
			// 
			// label5
			// 
			this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(102, 156);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(102, 13);
			this.label5.TabIndex = 12;
			this.label5.Text = "Winner of the Event";
			this.label5.Visible = false;
			// 
			// EventWinnerTextBox
			// 
			this.EventWinnerTextBox.Location = new System.Drawing.Point(3, 172);
			this.EventWinnerTextBox.Name = "EventWinnerTextBox";
			this.EventWinnerTextBox.Size = new System.Drawing.Size(300, 20);
			this.EventWinnerTextBox.TabIndex = 13;
			this.EventWinnerTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			this.EventWinnerTextBox.Visible = false;
			this.EventWinnerTextBox.Enter += new System.EventHandler(this.EventTextBox_Enter);
			// 
			// SaveChangesButton
			// 
			this.SaveChangesButton.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.SaveChangesButton.Location = new System.Drawing.Point(101, 198);
			this.SaveChangesButton.Name = "SaveChangesButton";
			this.SaveChangesButton.Size = new System.Drawing.Size(104, 23);
			this.SaveChangesButton.TabIndex = 15;
			this.SaveChangesButton.Text = "Save Changes";
			this.SaveChangesButton.UseVisualStyleBackColor = true;
			this.SaveChangesButton.Visible = false;
			this.SaveChangesButton.Click += new System.EventHandler(this.SaveChangesButton_Click);
			this.SaveChangesButton.Click += new System.EventHandler(this.SportEventsListUpdate);
			// 
			// menuStrip1
			// 
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(315, 24);
			this.menuStrip1.TabIndex = 2;
			this.menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// saveToolStripMenuItem
			// 
			this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
			this.saveToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.saveToolStripMenuItem.Text = "Save";
			this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(98, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutToolStripMenuItem
			// 
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
			// 
			// saveFileDialog1
			// 
			this.saveFileDialog1.DefaultExt = "txt";
			this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
			this.saveFileDialog1.InitialDirectory = Environment.CurrentDirectory;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(662, 450);
			this.Controls.Add(this.tableLayoutPanel1);
			this.MainMenuStrip = this.menuStrip1;
			this.Name = "MainWindow";
			this.Text = "Sport Events";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.SportEventsListUpdate);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.flowLayoutPanel2.ResumeLayout(false);
			this.flowLayoutPanel2.PerformLayout();
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.Label EventListLabel;
		private System.Windows.Forms.ListBox SportEventsList;
		private System.Windows.Forms.Button AddEventButton;
		private NewEventWindow AddEventWindow;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox EventTypeTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox EventLeagueTextBox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox EventNameTextBox;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox EventWinnerTextBox;
		private System.Windows.Forms.DateTimePicker EventDateDatePicker;
		private System.Windows.Forms.Button SaveChangesButton;
		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
		private System.Windows.Forms.SaveFileDialog saveFileDialog1;
	}
}

