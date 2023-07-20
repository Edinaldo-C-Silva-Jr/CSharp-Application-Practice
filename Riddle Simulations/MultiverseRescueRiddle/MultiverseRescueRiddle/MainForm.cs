/*
 * Date: 17/07/2023
 * Time: 17:19
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MultiverseRescueRiddle
{
	public partial class MainForm : Form
	{
		bool[] personIsSaved = new bool[11];
		int[] timesVisited = new int[11], turnSaved = new int[11];
		
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
			
			cbb_delay.SelectedIndex = 5;
		}
		
		void Btn_startClick(object sender, EventArgs e)
		{
			do
			{
				turnsTaken++;
				
				robotPosition = robotTeleport.Next(1, 12);
				
				timesVisited[robotPosition - 1]++;
				
				if (robotPosition == 1)
				{
					if (!personIsSaved[robotPosition - 1])
					{
						personIsSaved[robotPosition - 1] = true;
						peopleSaved++;
						turnSaved[robotPosition - 1] = turnsTaken;
					}
					
					if (peopleCounted > 9)
					{
						buttonPressed = true;
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
				}
				else
				{
					if (!leftLever && !personIsSaved[robotPosition - 1])
					{
						personIsSaved[robotPosition - 1] = true;
						peopleSaved++;
						turnSaved[robotPosition - 1] = turnsTaken;
						leftLever = true;
					}
					else
					{
						rightLever = !rightLever;
					}
				}
				
				lbl_peopleSaved.Text = "People Saved: " + peopleSaved.ToString();
				lbl_peopleCounted.Text = "People Counted: " + peopleCounted.ToString();
				tbr_leftLever.Value = Convert.ToInt32(rightLever);
				tbr_rightLever.Value = Convert.ToInt32(leftLever);
				lbl_turns.Text = "Turns Taken: " + turnsTaken.ToString();
			}
			while(!buttonPressed);
		}
	}
}
