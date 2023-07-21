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
		bool[] personIsSaved = new bool[11];
		int[] timesVisited = new int[11];
		float delay;
		
		int turnsTaken = 0, peopleSaved = 0, peopleCounted = 0, robotPosition = 0;
		
		bool rightLever = false, leftLever = false, buttonPressed = false;
		Random robotTeleport;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			robotTeleport = new Random();
			
			cbb_delay.SelectedIndex = 2;
		}
		
		void Btn_startClick(object sender, EventArgs e)
		{
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
	}
}
