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
	// A program that tests the probability of a riddle known as "The Frog Riddle", published by the Youtube channel Ted-Ed
	// A basic description of the riddle is: A certain forest has a species of frogs that can be male or female. Both male and female frogs are identical in appearance, and the only way to distinguish them is by their croak, since only male frogs can croak.
	// While out in this forest, you hear a croak behind you, and you turn to see 2 frogs. What's the chance that one of them is female?
	// This implementation expands a little bit on the concept, by allowing the user to test specific amounts of frogs, while showing how many of them were male, female and how many croaks were there. There are also options to filter the results based on number of croaks (To simulate the riddle's probability, the filter must be set to "1 Croak")
	public partial class MainForm : Form
	{
		Random randomNumber = new Random();
		
		// Counters for the amount of frogs tested
		int globalCounter = 0;
		int filteredCounter = 0;
		double filteredPercent = 0;
		
		// Counters for the amount of male frogs, female frogs and amount of croaks.
		// These are individual counters for both Frog 1 and Frog 2
		int frog1MaleCount = 0, frog1FemaleCount = 0;
		int frog2MaleCount = 0, frog2FemaleCount = 0;
		int frog1CroakedCount = 0, frog2CroakedCount = 0;
		double frog1MalePercent = 0, frog1FemalePercent = 0;
		double frog2MalePercent = 0, frog2FemalePercent = 0;
		double frog1CroakPercent = 0, frog2CroakPercent = 0;
		
		// Counters for the amount of each frog and croak combination
		// This takes into account both frogs, counting things like whether the test returned 2 male frogs, 2 female frogs, and so on
		int twoMalesCount = 0, twoFemalesCount = 0, maleFemaleCount = 0;
		int noCroakCount = 0, oneCroakCount = 0, twoCroaksCount = 0;
		double twoMalesPercent = 0, twoFemalesPercent = 0, maleFemalePercent = 0;
		double noCroakPercent = 0, oneCroakPercent = 0, twoCroaksPercent = 0;
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			rdb_allCroaks.Checked = true; // Sets the filter to default once the program starts
		}
		
		// Counts the gender of frogs in the current test iteration
		// Increases the count for that frog's gender (either male or female) and adds what the gender was in the list box
		private void CountGender(Frog f1, Frog f2)
		{
			if (f1.getGender())
			{
				lst_frog1Gender.Items.Add(globalCounter + " - Gender: Male");
				frog1MaleCount++;
			}
			else
			{
				lst_frog1Gender.Items.Add(globalCounter + " - Gender: Female");
				frog1FemaleCount++;
			}
			
			if (f2.getGender())
			{
				lst_frog2Gender.Items.Add(globalCounter + " - Gender: Male");
				frog2MaleCount++;
			}
			else
			{
				lst_frog2Gender.Items.Add(globalCounter + " - Gender: Female");
				frog2FemaleCount++;
			}
		}
		
		// Counts what was the combination of genders in the current test iteration
		// This could be 2 males, 2 females or 1 of each
		private void CountBothGender(Frog f1, Frog f2)
		{
			if (f1.getGender() && f2.getGender())
			{
				twoMalesCount++;
			}
			
			if (f1.getGender() ^ f2.getGender())
			{
				maleFemaleCount++;
			}
			
			if (!(f1.getGender() || f2.getGender()))
			{
				twoFemalesCount++;
			}
		}
		
		// Counts the croaks in the current test iteration
		// Adds whether the frog croaked to the list box, and increases the count if the frog croaked
		private void CountCroaks(Frog f1, Frog f2)
		{
			if (f1.getCroaked())
			{
				lst_frog1Croaked.Items.Add(globalCounter + " - Frog Croaked!");
				frog1CroakedCount++;
			}
			else
			{
				lst_frog1Croaked.Items.Add(globalCounter + " - Did not croak...");
			}
			
			if (f2.getCroaked())
			{
				lst_frog2Croaked.Items.Add(globalCounter + " - Frog Croaked!");
				frog2CroakedCount++;
			}
			else
			{
				lst_frog2Croaked.Items.Add(globalCounter + " - Did not croak...");
			}
		}
		
		// Counts the combination of croaks in the current test iteration
		// This could be both frogs croaking, only 1 croaking, or no croaks
		private void CountBothCroaks(Frog f1, Frog f2)
		{
			if (f1.getCroaked() && f2.getCroaked())
			{
				twoCroaksCount++;
			}
			
			if (f1.getCroaked() ^ f2.getCroaked())
			{
				oneCroakCount++;
			}
			
			if (!(f1.getCroaked() || f2.getCroaked()))
			{
				noCroakCount++;
			}
		}
		
		// Calculates the percentages of each counter in relation to the total amount of frogs tested
		private void CalculatePercentages()
		{
			filteredPercent = (double)filteredCounter / globalCounter;
			filteredPercent *= 100;
			
			frog1MalePercent = (double)frog1MaleCount / filteredCounter;
			frog1MalePercent *= 100;
			frog1FemalePercent = (double)frog1FemaleCount / filteredCounter;
			frog1FemalePercent *= 100;
			frog1CroakPercent = (double)frog1CroakedCount / filteredCounter;
			frog1CroakPercent *= 100;
			
			frog2MalePercent = (double)frog2MaleCount / filteredCounter;
			frog2MalePercent *= 100;
			frog2FemalePercent = (double)frog2FemaleCount / filteredCounter;
			frog2FemalePercent *= 100;
			frog2CroakPercent = (double)frog2CroakedCount / filteredCounter;
			frog2CroakPercent *= 100;
			
			twoMalesPercent = (double)twoMalesCount / filteredCounter;
			twoMalesPercent *= 100;
			twoFemalesPercent = (double)twoFemalesCount / filteredCounter;
			twoFemalesPercent *= 100;
			maleFemalePercent = (double)maleFemaleCount / filteredCounter;
			maleFemalePercent *= 100;
			
			twoCroaksPercent = (double)twoCroaksCount / filteredCounter;
			twoCroaksPercent *= 100;
			oneCroakPercent = (double)oneCroakCount / filteredCounter;
			oneCroakPercent *= 100;
			noCroakPercent = (double)noCroakCount / filteredCounter;
			noCroakPercent *= 100;
		}
		
		// Updates all labels with the new counter values and percentages after the test iterations are done
		private void UpdateCounters()
		{
			lbl_globalCounter.Text = "Total: " + globalCounter.ToString();
			lbl_filteredCounter.Text = "Found: " + filteredCounter.ToString();
			lbl_filteredPercent.Text = filteredPercent.ToString("0.##") + "%";
			
			lbl_frog1MaleCount.Text = frog1MaleCount.ToString();
			lbl_frog1MalePercent.Text = frog1MalePercent.ToString("0.##") + "%";
			lbl_frog1FemaleCount.Text = frog1FemaleCount.ToString();
			lbl_frog1FemalePercent.Text = frog1FemalePercent.ToString("0.##") + "%";
			lbl_frog1CroakCount.Text = frog1CroakedCount.ToString();
			lbl_frog1CroakPercent.Text = frog1CroakPercent.ToString("0.##") + "%";
			
			lbl_frog2MaleCount.Text = frog2MaleCount.ToString();
			lbl_frog2MalePercent.Text = frog2MalePercent.ToString("0.##") + "%";
			lbl_frog2FemaleCount.Text = frog2FemaleCount.ToString();
			lbl_frog2FemalePercent.Text = frog2FemalePercent.ToString("0.##") + "%";
			lbl_frog2CroakCount.Text = frog2CroakedCount.ToString();
			lbl_frog2CroakPercent.Text = frog2CroakPercent.ToString("0.##") + "%";
			
			lbl_twoMalesCount.Text = twoMalesCount.ToString();
			lbl_twoMalesPercent.Text = twoMalesPercent.ToString("0.##") + "%";
			lbl_twoFemalesCount.Text = twoFemalesCount.ToString();
			lbl_twoFemalesPercent.Text = twoFemalesPercent.ToString("0.##") + "%";
			lbl_maleFemaleCount.Text = maleFemaleCount.ToString();
			lbl_maleFemalePercent.Text = maleFemalePercent.ToString("0.##") + "%";
			
			lbl_twoCroaksCount.Text = twoCroaksCount.ToString();
			lbl_twoCroaksPercent.Text = twoCroaksPercent.ToString("0.##") + "%";
			lbl_oneCroakCount.Text = oneCroakCount.ToString();
			lbl_oneCroakPercent.Text = oneCroakPercent.ToString("0.##") + "%";
			lbl_noCroakCount.Text = noCroakCount.ToString();
			lbl_noCroakPercent.Text = noCroakPercent.ToString("0.##") + "%";
		}
		
		// Resets all counters back to 0, and then updates the labels to reflect the changes
		// also clears all values in the list boxes
		private void ResetAll()
		{
			globalCounter = 0;
			filteredCounter = 0;
			filteredPercent = 0;
			
			frog1MaleCount = 0;
			frog1FemaleCount = 0;
			frog2MaleCount = 0;
			frog2FemaleCount = 0;
			frog1CroakedCount = 0;
			frog2CroakedCount = 0;
			frog1MalePercent = 0;
			frog1FemalePercent = 0;
			frog2MalePercent = 0;
			frog2FemalePercent = 0;
			frog1CroakPercent = 0;
			frog2CroakPercent = 0;
			
			twoMalesCount = 0;
			twoFemalesCount = 0;
			maleFemaleCount = 0;
			noCroakCount = 0;
			oneCroakCount = 0;
			twoCroaksCount = 0;
			twoMalesPercent = 0;
			twoFemalesPercent = 0;
			maleFemalePercent = 0;
			noCroakPercent = 0;
			oneCroakPercent = 0;
			twoCroaksPercent = 0;
			
			lst_frog1Gender.Items.Clear();
			lst_frog1Croaked.Items.Clear();
			lst_frog2Gender.Items.Clear();
			lst_frog2Croaked.Items.Clear();
			
			UpdateCounters();
		}
		
		// Runs one iteration of frog tests.
		private void RunFrogTests(Frog f1, Frog f2)
		{
			filteredCounter++; // Filtered counter only increases if a test has been successfully run 
			CountGender(f1, f2);
			CountBothGender(f1, f2);
			CountCroaks(f1, f2);
			CountBothCroaks(f1, f2);
		}
		
		// Prepares and starts one iteration of tests. This is the method that instances the frogs, sets their properties and applies the filters to the tests
		private void TestFrogs()
		{
			globalCounter++; // Global counter always increases
			int num;
			
			// Instances 2 frogs for the test
			// The random number genetares either 0 or 1, and is used to pass whether the frog will be a male or a female
			num = randomNumber.Next(2);
			Frog f1 = new Frog(num == 1);
			num = randomNumber.Next(2);
			Frog f2 = new Frog(num == 1);
			
			// Makes each frog try to croak once
			// The random number genetares either 0 or 1, and is used to pass whether the frog successfully croaked or not
			// Note that only male frogs can croak, so if the frog is a female, it will fail regardless of the value passed
			num = randomNumber.Next(2);
			f1.croak(num == 1);
			num = randomNumber.Next(2);
			f2.croak(num == 1);
			
			// If the filter "All Results" is set, always runs the test
			if (rdb_allCroaks.Checked == true)
			{
				RunFrogTests(f1, f2);
			}
			
			// If the filter "2 Croaks" is set, only runs the tests if both frog 1 and frog 2 have croaked
			if (rdb_twoCroaks.Checked == true)
			{
				if (f1.getCroaked() && f2.getCroaked())
				{
					RunFrogTests(f1, f2);
				}
			}
			
			// If the filter "1 Croak" is set, only runs the tests if either frog 1 or frog 2 croaked, but not both
			if (rdb_oneCroak.Checked == true)
			{
				if (f1.getCroaked() ^ f2.getCroaked())
				{
					RunFrogTests(f1, f2);
				}
			}
			
			// If the filter "No Croaks" is set, only runs the tests if none of the frogs croaked
			if (rdb_noCroaks.Checked == true)
			{
				if (!(f1.getCroaked() || f2.getCroaked()))
				{
					RunFrogTests(f1, f2);
				}
			}
		}
		
		// Button click event. Runs a specific amount of tests that is dependent on which button was pressed
		void Btn_testFrogsClick(object sender, EventArgs e)
		{
			Button clickedButton = sender as Button;
			
			int testAmount = int.Parse(clickedButton.Tag.ToString()); // Gets the amount of iterations that will be tested from the "Tag" property in the buttons
			
			for (int i = 0; i < testAmount; i++) {
				TestFrogs();
			}
			
			CalculatePercentages(); // Updates the counters once the tests have been finished
			UpdateCounters();
			
			lst_frog1Gender.SelectedIndex = filteredCounter - 1; // Highlights the last added item in the list boxes
		}
		
		// ListBox index change event. Makes sure to syncronize all list boxes by highlighting the same item in all of them
		void Lst_IndexChange(object sender, EventArgs e)
		{
			ListBox listClicked = sender as ListBox;
			
			int indexSelected = listClicked.SelectedIndex;
			
			lst_frog1Gender.SelectedIndex = indexSelected;
			lst_frog1Croaked.SelectedIndex = indexSelected;
			lst_frog2Gender.SelectedIndex = indexSelected;
			lst_frog2Croaked.SelectedIndex = indexSelected;
		}
		
		// Radio Button change event. Resets all counters whenever the filter is changed
		void Rdb_CheckedChanged(object sender, EventArgs e)
		{
			ResetAll();
		}
	}
}
