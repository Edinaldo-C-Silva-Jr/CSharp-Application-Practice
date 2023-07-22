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
		private string groupBoxName = "", labelName = "";
		Random robotTeleport;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		private void MainFormLoad(object sender, EventArgs e)
		{
			robotTeleport = new Random();
			
			cbb_delay.SelectedIndex = 2;
			delay = 1000 * float.Parse(cbb_delay.SelectedItem.ToString());
			tmr_interval.Interval = (int)delay;
		}
		
		private void Btn_startClick(object sender, EventArgs e)
		{
			if (buttonPressed)
			{
				MessageBox.Show("The simulation has been finished, and must be reset first.");
				return;
			}
			
			tmr_interval.Enabled = true;
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
		
		void Btn_riddleClick(object sender, EventArgs e)
		{
			string explanation;
			
			explanation = "Welcome! \nThis is a simulation for the solution of a riddle known as 'The Multiverse Rescue Riddle.'"
				+ "This riddle can be found on the Youtube channel Ted-ED. \n\nA basic description of it is: \n"
				+ "You and 10 other people are stuck in 11 different dimensions. Your only chance of going back home is being rescued by the Multiverse Robot. \n\n"
				+ "The robot has 2 levers, which can be set to either position A or B, and a button. The way it works is by randomly teleporting between any of the 11 dimensions. Once it appears, it will stay there until one of its levers is flipped, which lever and which position does not matter. Once a person flips a lever, the robot knows their dimensional position, and will be able to teleport them back. Once the button is pressed, everyone who has previously touched a lever gets teleported back home. The ones who didn't touch a lever will remain stuck. \n\n"
				+ "The robot keeps teleporting, randomly, and always requires one of its levers to be flipped before it can teleport again. So if a person who has already been visited sees the robot again, they'll have to flip the lever, again. \n\n"
				+ "The goal of the riddle is to find a strategy that guarantees everyone will be saved. The people trapped can only communicate with each other, to figure out the plan, before the robot is activated. Once it is active, the only communication is the position of the levers. \n\n"
				+ "Can you figure out a strategy?";
			MessageBox.Show(explanation, "The Riddle", MessageBoxButtons.OK);
		}
		
		void Btn_answerClick(object sender, EventArgs e)
		{
			string explanation;
			
			explanation = "This is the solution for the Multiverse Rescue Riddle, that the program is set to simulate. \n\n"
				+ "Since there are only 2 levers, they are not enough to communicate who has been visited by the robot. And it wouldn't be a certain result because people are required to flip a lever, even if they have already been saved. \n\n"
				+ "The solution then relies on the fact not everyone needs to know how many people were visited. If only one person becomes responsible for pressing the button, only that person will need to know when everyone has been visited. The person doesn't even need to know who has been visited, they only need to make sure the robot visited 11 people in the end (including themselves). \n\n"
				+ "Once this person (let's call them 'leader') has been defined, the plan is the following: The left lever will be used to count visits, and the right lever to just send the robot on its way. At the start, the lever starts down. When someone is visited by the robot for the first time, they should flip the left lever up, to signal they're a newly saved person. After this, only the leader can pull it down, to signal they acknowledge there is a newly saved person. If anyone, other than the leader, finds the left lever already up, they should not touch it, even if they haven't been visited yet. Also, after a person has flipped the left lever up, they're officially saved, and should only use the right lever until the end of the simulation. \n\n"
				+ "For the sake of this simulation, the leader is always the person in dimension 1. So everytime someone is saved, the robot needs to visit dimension 1 before saving a new person. After 10 people have been counted (the leader doesn't need to count themselves), the simulation ends.";
			MessageBox.Show(explanation, "The Answer", MessageBoxButtons.OK);
		}
		
		void Tmr_intervalTick(object sender, EventArgs e)
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
					tmr_interval.Enabled = false;
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
		}
		
		void Cbb_delaySelectedIndexChanged(object sender, EventArgs e)
		{
			delay = 1000 * float.Parse(cbb_delay.SelectedItem.ToString());
			if (delay == 0)
			{
				tmr_interval.Interval = 1;
			}
			else
			{
				tmr_interval.Interval = (int)delay;
			}
		}
	}
}