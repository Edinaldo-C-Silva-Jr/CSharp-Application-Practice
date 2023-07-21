/*
 * Date: 17/07/2023
 * Time: 17:19
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace MultiverseRescueRiddle
{
	public partial class MainForm : Form
	{
		private bool[] personIsSaved = new bool[11];
		private int[] timesVisited = new int[11];
		private float delay;
		
		private int turnsTaken = 0, peopleSaved = 0, peopleCounted = 0, robotPosition = 0;
		
		private bool rightLever = false, leftLever = false, buttonPressed = false;
		Random robotTeleport;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		private void MainFormLoad(object sender, EventArgs e)
		{
			robotTeleport = new Random();
			
			cbb_delay.SelectedIndex = 2;
		}
		
		private void Btn_startClick(object sender, EventArgs e)
		{
			if (buttonPressed)
			{
				MessageBox.Show("The simulation has been finished, and must be reset first.");
				return;
			}
			
			string groupBoxName = "", labelName = "";
			delay = 1000 * float.Parse(cbb_delay.SelectedItem.ToString());
			
			do
			{
				if (turnsTaken > 0)
				{
					labelName = "lbl_d" + robotPosition + "Robot";
					this.Controls[groupBoxName].Controls[labelName].Visible = false;
				}
				
				turnsTaken++;
				robotPosition = robotTeleport.Next(1, 12);
				timesVisited[robotPosition - 1]++;
				groupBoxName = "gpb_dimension" + robotPosition;
				
				if (robotPosition == 1)
				{
					if (!personIsSaved[robotPosition - 1])
					{
						personIsSaved[robotPosition - 1] = true;
						peopleSaved++;
						
						labelName = "lbl_d" + robotPosition + "Saved";
						this.Controls[groupBoxName].Controls[labelName].Text = "Saved: Yes";
						this.Controls[groupBoxName].Controls[labelName].ForeColor = Color.Green;
						
						labelName = "lbl_d" + robotPosition + "TurnSaved";
						this.Controls[groupBoxName].Controls[labelName].Text = "On Turn: " + turnsTaken;
					}
					
					if (leftLever)
					{
						leftLever = false;
						peopleCounted++;
					}
					else
					{
						rightLever = !rightLever;
					}
					
					if (peopleCounted == 10)
					{
						buttonPressed = true;
						lbl_buttonFinish.Text = "Home: Yes!";
						lbl_buttonFinish.ForeColor = Color.Green;
					}
				}
				else
				{
					if (!leftLever && !personIsSaved[robotPosition - 1])
					{
						personIsSaved[robotPosition - 1] = true;
						peopleSaved++;
						leftLever = true;
						
						labelName = "lbl_d" + robotPosition + "Saved";
						this.Controls[groupBoxName].Controls[labelName].Text = "Saved: Yes";
						this.Controls[groupBoxName].Controls[labelName].ForeColor = Color.Green;
						
						labelName = "lbl_d" + robotPosition + "TurnSaved";
						this.Controls[groupBoxName].Controls[labelName].Text = "On Turn: " + turnsTaken;
					}
					else
					{
						rightLever = !rightLever;
					}
				}
				
				tbr_leftLever.Value = Convert.ToInt32(leftLever);
				tbr_rightLever.Value = Convert.ToInt32(rightLever);
				
				lbl_peopleSaved.Text = "People Saved: " + peopleSaved.ToString();
				lbl_peopleCounted.Text = "People Counted: " + peopleCounted.ToString();
				lbl_turns.Text = "Turns Taken: " + turnsTaken.ToString();
				
				labelName = "lbl_d" + robotPosition + "TimesVisited";
				this.Controls[groupBoxName].Controls[labelName].Text = "Times Visited: " + timesVisited[robotPosition - 1];
				
				labelName = "lbl_d" + robotPosition + "Robot";
				this.Controls[groupBoxName].Controls[labelName].Visible = true;
				
				this.Refresh();
				Thread.Sleep((int)delay);
			}
			while(!buttonPressed);
		}
		
		void Btn_resetClick(object sender, EventArgs e)
		{
			turnsTaken = peopleCounted = peopleSaved = robotPosition = 0;
			rightLever = leftLever = buttonPressed = false;
			
			tbr_leftLever.Value = 0;
			tbr_rightLever.Value = 0;
			lbl_turns.Text = "Turns Taken: 0";
			lbl_peopleSaved.Text = "People Saved: 0";
			lbl_peopleCounted.Text = "People Counted: 0";
			lbl_buttonFinish.Text = "Home: No";
			lbl_buttonFinish.ForeColor = Color.Red;
			
			string groupBoxName = "", labelName = "";
			
			for (int i = 1; i < 12; i++)
			{
				personIsSaved[i-1] = false;
				timesVisited[i-1] = 0;
				
				groupBoxName = "gpb_dimension" + i;
				
				labelName = "lbl_d" + i + "Saved";
				this.Controls[groupBoxName].Controls[labelName].Text = "Saved: No";
				this.Controls[groupBoxName].Controls[labelName].ForeColor = Color.Red;
				
				labelName = "lbl_d" + i + "TurnSaved";
				this.Controls[groupBoxName].Controls[labelName].Text = "On Turn: 0";
				
				labelName = "lbl_d" + i + "TimesVisited";
				this.Controls[groupBoxName].Controls[labelName].Text = "Times Visited: 0";
				
				labelName = "lbl_d" + i + "Robot";
				this.Controls[groupBoxName].Controls[labelName].Visible = false;
			}
		}
	}
}
