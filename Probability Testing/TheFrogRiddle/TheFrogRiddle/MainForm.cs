/*
 * Date: 25/03/2023
 * Time: 18:01
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace TheFrogRiddle
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Random randomNumber = new Random();
		int global_counter = 0;
		int frog1_male = 0, frog1_female = 0;
		int frog2_male = 0, frog2_female = 0;
		int frog1_croaked = 0, frog2_croaked = 0;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		private void CountGender(Frog f1, Frog f2)
		{
			if (f1.getGender())
			{
				lst_Frog1_Gender.Items.Add(global_counter + " - Gender: Male");
				frog1_male++;
			}
			else
			{
				lst_Frog1_Gender.Items.Add(global_counter + " - Gender: Female");
				frog1_female++;
			}
			
			if (f2.getGender())
			{
				lst_Frog2_Gender.Items.Add(global_counter + " - Gender: Male");
				frog2_male++;
			}
			else
			{
				lst_Frog2_Gender.Items.Add(global_counter + " - Gender: Female");
				frog2_female++;
			}
		}
		
		private void CountCroaks(Frog f1, Frog f2)
		{
			if (f1.getCroaked())
			{
				lst_Frog1_Croaked.Items.Add(global_counter + " - Croaked!");
				frog1_croaked++;
			}
			else
			{
				lst_Frog1_Croaked.Items.Add(global_counter + " - Did not...");
			}
			
			if (f2.getCroaked())
			{
				lst_Frog2_Croaked.Items.Add(global_counter + " - Croaked!");
				frog2_croaked++;
			}
			else
			{
				lst_Frog2_Croaked.Items.Add(global_counter + " - Did not...");
			}
		}
		
		private void UpdateCounters()
		{
			lbl_Frog1_MaleCounter.Text = "Male: " + frog1_male;
			lbl_Frog1_FemaleCounter.Text = "Female: " + frog1_female;
			lbl_Frog2_MaleCounter.Text = "Male: " + frog2_male;
			lbl_Frog2_FemaleCounter.Text = "Female: " + frog2_female;
			lbl_frog1_croaked.Text = "Croaks: " + frog1_croaked;
			lbl_frog2_croaked.Text = "Croaks: " + frog2_croaked;
		}
		
		private void TestFrogs()
		{
			global_counter++;
			int num;
			
			num = randomNumber.Next(2);
			Frog f1 = new Frog(num == 1);
			
			num = randomNumber.Next(2);
			Frog f2 = new Frog(num == 1);
			
			num = randomNumber.Next(2);
			f1.croak(num == 1);
			
			num = randomNumber.Next(2);
			f2.croak(num == 1);
			
			CountGender(f1, f2);
			CountCroaks(f1, f2);
		}
		
		void Btn_testFrogsClick(object sender, EventArgs e)
		{
			Button clickedButton = sender as Button;
			
			int testAmount = int.Parse(clickedButton.Tag.ToString());
			
			for (int i = 0; i < testAmount; i++) {
				TestFrogs();
				UpdateCounters();
			}
		}
	}
}
