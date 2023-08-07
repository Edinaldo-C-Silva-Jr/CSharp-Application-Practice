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
	// A class that simulates the solution of a riddle known as "Multiverse Rescue Riddle".
	// An explanation for the riddle can be found within the program in the "Riddle" and "Answer" buttons
	public partial class MainForm : Form
	{
		private bool[] personIsSaved = new bool[11]; // Arrays for individual dimension states
		private bool[] personIsSavedLeftLever = new bool[11];
		private int[] timesVisited = new int[11];
		
		private int turnsTaken = 0, peopleSaved = 0, peopleSavedLeftLever = 0, peopleCounted = 0, robotPosition = 0; // Control variables for the simulation
		private float delay;
		
		private bool rightLever = false, leftLever = false, buttonPressed = false; // Robot related variables
		Random robotTeleport;
		
		private string groupBoxName = "", labelName = ""; // Variables for building the control names (used to change the controls' properties based on the result of the RNG)
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		private void MainFormLoad(object sender, EventArgs e)
		{
			robotTeleport = new Random();
			
			cbb_delay.SelectedIndex = 2; // Starts the execution delay of steps on 0.25s
			delay = 1000 * float.Parse(cbb_delay.SelectedItem.ToString());
			tmr_interval.Interval = (int)delay;
		}
		
		#region Simulation Methods
		// Saves the current person, if they haven't already been saved
		// This is the person's first visit, so whichever lever the person flips will save them
		// However, the person won't be properly counted as "saved" until they use the left lever (since the leader won't be able to know this person was visited)
		private void SaveCurrentPerson()
		{
			personIsSaved[robotPosition - 1] = true; // Marks person as saved
			peopleSaved++;
			
			labelName = "lbl_d" + robotPosition + "Saved"; // Changes the labels related to the current dimension by building their names with the number of the robot position
		
			this.Controls[groupBoxName].Controls[labelName].Text = "Saved: Yes";
			this.Controls[groupBoxName].Controls[labelName].ForeColor = Color.Green; // Changes the label "saved" to Yes and makes it green
			
			labelName = "lbl_d" + robotPosition + "TurnSaved";
			this.Controls[groupBoxName].Controls[labelName].Text = "On Turn: " + turnsTaken; // Records the turn the person was saved
			
			if (peopleSaved == 11)
			{
				lbl_turnSavedReality.Text = "Turn All were Saved (Real): " + turnsTaken;
			}
		}
		
		// Saves current person by using the left lever
		// This is the "proper" way a person is saved based on the riddle rules
		private void SaveCurrentPersonLeftLever()
		{
			personIsSavedLeftLever[robotPosition - 1] = true;
			peopleSavedLeftLever++;
			
			labelName = "lbl_d" + robotPosition + "LeftLever";
			this.Controls[groupBoxName].Controls[labelName].Text = "Left Lever: Yes";
			this.Controls[groupBoxName].Controls[labelName].ForeColor = Color.Green;
			
			labelName = "lbl_d" + robotPosition + "TurnLeftLever";
			this.Controls[groupBoxName].Controls[labelName].Text = "On Turn: " + turnsTaken;
		}
		
		// Updates all counters used by the form
		// This includes counter labels, state labels and robot levers
		private void UpdateCounters()
		{
			tbr_leftLever.Value = Convert.ToInt32(leftLever);
			tbr_rightLever.Value = Convert.ToInt32(rightLever);
			
			lbl_peopleSavedReality.Text = "People Saved (Reality): " + peopleSaved;
			lbl_peopleSavedLeftLever.Text = "People Saved (Left Lever): " + peopleSavedLeftLever.ToString();
			lbl_peopleCounted.Text = "People Counted by Leader: " + peopleCounted.ToString();
			lbl_turns.Text = "Turns Taken: " + turnsTaken.ToString();
			
			labelName = "lbl_d" + robotPosition + "TimesVisited";
			this.Controls[groupBoxName].Controls[labelName].Text = "Times Visited: " + timesVisited[robotPosition - 1];
			
			labelName = "lbl_d" + robotPosition + "Robot";
			this.Controls[groupBoxName].Controls[labelName].Visible = true;
			
			this.Refresh();
		}
		
		// Method that handles the Robot's visit to the chosen dimension, as well as his interaction with the person trapped in that dimension
		private void RobotVisitsDimension()
		{
			if (robotPosition == 1) // If the Robot goes to dimension 1 (where the group "leader" is)
			{
				if (!personIsSaved[robotPosition - 1]) // Saves leader if not already saved
				{
					SaveCurrentPerson();
				}
				
				if (leftLever) // If the left lever is flipped
				{
					leftLever = false;
					peopleCounted++; // Leader counts +1 person saved, and unflips the lever
				}
				else
				{
					rightLever = !rightLever; // Otherwise, leader just sends the Robot onwards
				}
				
				if (peopleCounted == 10) // If there have been 10 people counted
				{
					buttonPressed = true;
					tmr_interval.Enabled = false;
					lbl_buttonFinish.Text = "Home: Yes!";
					lbl_buttonFinish.ForeColor = Color.Green; // Leader presses the button and the simulation ends
					btn_start.Text = "Restart Simulation";
				}
			}
			else // If not in the dimension of the leader
			{
				if (!personIsSaved[robotPosition - 1]) // Saves person on their first visit
				{
					SaveCurrentPerson();
				}
				
				if (!leftLever && !personIsSavedLeftLever[robotPosition - 1]) // Saves the person by using the left lever (only if the left lever isn't flipped)
				{
					leftLever = true;
					SaveCurrentPersonLeftLever(); // Flip left lever and saves the person
				}
				else
				{
					rightLever = !rightLever; // Otherwise, just send Robot onwards
				}
			}
		}
		#endregion
		
		#region Run Simulation (Timer and Reset)
		// Runs 1 iteration of the teleportation process on every tick of the timer
		private void Tmr_intervalTick(object sender, EventArgs e)
		{
			if (turnsTaken > 0) // If this is not the first turn
			{
				labelName = "lbl_d" + robotPosition + "Robot";
				this.Controls[groupBoxName].Controls[labelName].Visible = false; // Removes the Robot from the dimension picked in the previous turn
			}
			
			turnsTaken++;
			robotPosition = robotTeleport.Next(1, 12); // Chooses the position (dimension) Robot will teleport to
			timesVisited[robotPosition - 1]++;
			groupBoxName = "gpb_dimension" + robotPosition; // Gets which GroupBox represents the dimension chosen by the robot
			
			RobotVisitsDimension();
			
			UpdateCounters();
		}
		
		// Resets all variables and all counters and states used by the form
		private void ResetSimulation()
		{
			turnsTaken = peopleCounted = peopleSaved = peopleSavedLeftLever = robotPosition = 0;
			rightLever = leftLever = buttonPressed = false;
			
			tbr_leftLever.Value = 0;
			tbr_rightLever.Value = 0;
			lbl_turns.Text = "Turns Taken: 0";
			lbl_peopleSavedLeftLever.Text = "People Saved (Left Lever): 0";
			lbl_peopleCounted.Text = "People Counted by Leader: 0";
			lbl_peopleSavedReality.Text = "People Saved (Reality): 0";
			lbl_turnSavedReality.Text = "Turn All were Saved (Real): 0";
			lbl_buttonFinish.Text = "Home: No";
			lbl_buttonFinish.ForeColor = Color.Red;
			
			string groupBoxName = "", labelName = "";
			
			for (int i = 1; i < 12; i++)
			{
				personIsSaved[i-1] = false;
				personIsSavedLeftLever[i-1] = false;
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
				
				if (i != 1)
				{
					labelName = "lbl_d" + i + "LeftLever";
					this.Controls[groupBoxName].Controls[labelName].Text = "Left Lever: No";
					this.Controls[groupBoxName].Controls[labelName].ForeColor = Color.Red;
					
					labelName = "lbl_d" + i + "TurnLeftLever";
					this.Controls[groupBoxName].Controls[labelName].Text = "On Turn: 0";
				}
			}
		}
		#endregion
		
		#region Control Actions (Button and ComboBox)
		// Changes the delay of the time it takes for each iteration of the teleportation process
		private void Cbb_delaySelectedIndexChanged(object sender, EventArgs e)
		{
			if (cbb_delay.SelectedIndex == 0) // If delay is the first value, set the time interval to minimum
			{
				tmr_interval.Interval = 1;
			}
			else // Otherwise, use the actual chosen delay in seconds
			{
				delay = 1000 * float.Parse(cbb_delay.SelectedItem.ToString());
				tmr_interval.Interval = (int)delay;
			}
		}
		
		// Sets the timer to start the simulation. Will also pause and resume it
		private void Btn_startClick(object sender, EventArgs e)
		{
			if (buttonPressed) // If simulation has already been finished, resets it
			{
				ResetSimulation();
				tmr_interval.Enabled = true;
				btn_start.Text = "Pause Simulation";
				return;
			}
			
			if (tmr_interval.Enabled) // If simulation is running, pause it
			{
				tmr_interval.Enabled = false;
				btn_start.Text = "Resume Simulation";
			}
			else // Otherwise, resume it
			{
				tmr_interval.Enabled = true;
				btn_start.Text = "Pause Simulation";
			}
		}
		
		// Resets and stops the simulation
		void Btn_resetClick(object sender, EventArgs e)
		{
			tmr_interval.Enabled = false;
			ResetSimulation();
			btn_start.Text = "Start Simulation";
		}
		#endregion
		
		#region Explanations
		// Explains the riddle this simulation is based on
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
		
		// Explains the answer to the riddle
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
		#endregion
	}
}