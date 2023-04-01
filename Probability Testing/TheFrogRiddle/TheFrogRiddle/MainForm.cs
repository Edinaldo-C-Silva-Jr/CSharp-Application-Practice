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
		int globalCounter = 0;
		int frog1Male = 0, frog1Female = 0;
		int frog2Male = 0, frog2Female = 0;
		int frog1Croaked = 0, frog2Croaked = 0;
		double frog1MalePercent = 0, frog1FemalePercent = 0;
		double frog2MalePercent = 0, frog2FemalePercent = 0;
		double frog1CroakPercent = 0, frog2CroakPercent = 0;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		private void CountGender(Frog f1, Frog f2)
		{
			if (f1.getGender())
			{
				lst_frog1Gender.Items.Add(globalCounter + " - Gender: Male");
				frog1Male++;
			}
			else
			{
				lst_frog1Gender.Items.Add(globalCounter + " - Gender: Female");
				frog1Female++;
			}
			
			if (f2.getGender())
			{
				lst_frog2Gender.Items.Add(globalCounter + " - Gender: Male");
				frog2Male++;
			}
			else
			{
				lst_frog2Gender.Items.Add(globalCounter + " - Gender: Female");
				frog2Female++;
			}
		}
		
		private void CountCroaks(Frog f1, Frog f2)
		{
			if (f1.getCroaked())
			{
				lst_frog1Croaked.Items.Add(globalCounter + " - Frog Croaked!");
				frog1Croaked++;
			}
			else
			{
				lst_frog1Croaked.Items.Add(globalCounter + " - Did not croak...");
			}
			
			if (f2.getCroaked())
			{
				lst_frog2Croaked.Items.Add(globalCounter + " - Frog Croaked!");
				frog2Croaked++;
			}
			else
			{
				lst_frog2Croaked.Items.Add(globalCounter + " - Did not croak...");
			}
		}
		
		private void CalculatePercentages()
		{
			frog1MalePercent = (double)frog1Male / globalCounter;
			frog1MalePercent *= 100;
			frog1FemalePercent = (double)frog1Female / globalCounter;
			frog1FemalePercent *= 100;
			frog1CroakPercent = (double)frog1Croaked / globalCounter;
			frog1CroakPercent *= 100;
			
			frog2MalePercent = (double)frog2Male / globalCounter;
			frog2MalePercent *= 100;
			frog2FemalePercent = (double)frog2Female / globalCounter;
			frog2FemalePercent *= 100;
			frog2CroakPercent = (double)frog2Croaked / globalCounter;
			frog2CroakPercent *= 100;
		}
		
		private void UpdateCounters()
		{
			lbl_frog1MaleCount.Text = frog1Male.ToString();
			lbl_frog1MalePercent.Text = frog1MalePercent.ToString("0.##") + "%";
			lbl_frog1FemaleCount.Text = frog1Female.ToString();
			lbl_frog1FemalePercent.Text = frog1FemalePercent.ToString("0.##") + "%";
			lbl_frog1CroakCount.Text = frog1Croaked.ToString();
			lbl_frog1CroakPercent.Text = frog1CroakPercent.ToString("0.##") + "%";
			
			lbl_frog2MaleCount.Text = frog2Male.ToString();
			lbl_frog2MalePercent.Text = frog2MalePercent.ToString("0.##") + "%";
			lbl_frog2FemaleCount.Text = frog2Female.ToString();
			lbl_frog2FemalePercent.Text = frog2FemalePercent.ToString("0.##") + "%";
			lbl_frog2CroakCount.Text = frog2Croaked.ToString();
			lbl_frog2CroakPercent.Text = frog2CroakPercent.ToString("0.##") + "%";
		}
		
		private void TestFrogs()
		{
			globalCounter++;
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
			}
			
			CalculatePercentages();
			UpdateCounters();
		}
		
		void Lst_IndexChange(object sender, EventArgs e)
		{
			ListBox listClicked = sender as ListBox;
			
			int indexSelected = listClicked.SelectedIndex;
			
			lst_frog1Gender.SelectedIndex = indexSelected;
			lst_frog1Croaked.SelectedIndex = indexSelected;
			lst_frog2Gender.SelectedIndex = indexSelected;
			lst_frog2Croaked.SelectedIndex = indexSelected;
		}
	}
}
