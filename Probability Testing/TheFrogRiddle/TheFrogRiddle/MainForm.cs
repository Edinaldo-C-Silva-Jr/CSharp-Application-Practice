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
		int filteredCounter = 0;
		double filteredPercent = 0;
		
		int frog1MaleCount = 0, frog1FemaleCount = 0;
		int frog2MaleCount = 0, frog2FemaleCount = 0;
		int frog1CroakedCount = 0, frog2CroakedCount = 0;
		double frog1MalePercent = 0, frog1FemalePercent = 0;
		double frog2MalePercent = 0, frog2FemalePercent = 0;
		double frog1CroakPercent = 0, frog2CroakPercent = 0;
		
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
			rdb_allCroaks.Checked = true;
		}
		
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
		}
		
		private void RunFrogTests(Frog f1, Frog f2)
		{
			filteredCounter++;
				CountGender(f1, f2);
				CountBothGender(f1, f2);
				CountCroaks(f1, f2);
				CountBothCroaks(f1, f2);
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
			
			if (rdb_allCroaks.Checked == true)
			{
				RunFrogTests(f1, f2);
			}
			
			if (rdb_twoCroaks.Checked == true)
			{
				if (f1.getCroaked() && f2.getCroaked())
				{
					RunFrogTests(f1, f2);
				}
			}
			
			if (rdb_oneCroak.Checked == true)
			{
				if (f1.getCroaked() ^ f2.getCroaked())
				{
					RunFrogTests(f1, f2);
				}
			}
			
			if (rdb_noCroaks.Checked == true)
			{
				if (!(f1.getCroaked() || f2.getCroaked()))
				{
					RunFrogTests(f1, f2);
				}
			}
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
			
			lst_frog1Gender.SelectedIndex = filteredCounter - 1;
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
		
		void Rdb_CheckedChanged(object sender, EventArgs e)
		{
			ResetAll();
			UpdateCounters();
		}
	}
}
