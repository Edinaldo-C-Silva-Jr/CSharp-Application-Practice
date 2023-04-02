/*
 * Date: 28/03/2023
 * Time: 12:48
*/
namespace TheFrogRiddle
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.lbl_frog1 = new System.Windows.Forms.Label();
			this.lbl_frog2 = new System.Windows.Forms.Label();
			this.lst_frog1Gender = new System.Windows.Forms.ListBox();
			this.lst_frog1Croaked = new System.Windows.Forms.ListBox();
			this.lst_frog2Gender = new System.Windows.Forms.ListBox();
			this.lst_frog2Croaked = new System.Windows.Forms.ListBox();
			this.btn_test1 = new System.Windows.Forms.Button();
			this.btn_test5 = new System.Windows.Forms.Button();
			this.btn_test10 = new System.Windows.Forms.Button();
			this.btn_test50 = new System.Windows.Forms.Button();
			this.btn_test100 = new System.Windows.Forms.Button();
			this.btn_test500 = new System.Windows.Forms.Button();
			this.btn_test1000 = new System.Windows.Forms.Button();
			this.btn_test5000 = new System.Windows.Forms.Button();
			this.btn_test10000 = new System.Windows.Forms.Button();
			this.btn_test50000 = new System.Windows.Forms.Button();
			this.gpb_frog1Stats = new System.Windows.Forms.GroupBox();
			this.lbl_frog1CroakCount = new System.Windows.Forms.Label();
			this.lbl_frog1CroakPercent = new System.Windows.Forms.Label();
			this.lbl_frog1Croak = new System.Windows.Forms.Label();
			this.lbl_frog1FemalePercent = new System.Windows.Forms.Label();
			this.lbl_frog1FemaleCount = new System.Windows.Forms.Label();
			this.lbl_frog1Female = new System.Windows.Forms.Label();
			this.lbl_frog1MaleCount = new System.Windows.Forms.Label();
			this.lbl_frog1MalePercent = new System.Windows.Forms.Label();
			this.lbl_frog1Male = new System.Windows.Forms.Label();
			this.gpb_frog2Stats = new System.Windows.Forms.GroupBox();
			this.lbl_frog2CroakCount = new System.Windows.Forms.Label();
			this.lbl_frog2CroakPercent = new System.Windows.Forms.Label();
			this.lbl_frog2Croaked = new System.Windows.Forms.Label();
			this.lbl_frog2FemalePercent = new System.Windows.Forms.Label();
			this.lbl_frog2FemaleCount = new System.Windows.Forms.Label();
			this.lbl_frog2Female = new System.Windows.Forms.Label();
			this.lbl_frog2MaleCount = new System.Windows.Forms.Label();
			this.lbl_frog2MalePercent = new System.Windows.Forms.Label();
			this.lbl_frog2Male = new System.Windows.Forms.Label();
			this.pnl_buttons = new System.Windows.Forms.Panel();
			this.gpb_groupStats = new System.Windows.Forms.GroupBox();
			this.lbl_twoCroaksPercent = new System.Windows.Forms.Label();
			this.lbl_twoCroaksCount = new System.Windows.Forms.Label();
			this.lbl_twoCroaks = new System.Windows.Forms.Label();
			this.lbl_twoFemalesCount = new System.Windows.Forms.Label();
			this.lbl_twoFemalesPercent = new System.Windows.Forms.Label();
			this.lbl_twoFemales = new System.Windows.Forms.Label();
			this.lbl_oneCroakPercent = new System.Windows.Forms.Label();
			this.lbl_oneCroakCount = new System.Windows.Forms.Label();
			this.lbl_oneCroak = new System.Windows.Forms.Label();
			this.lbl_maleFemaleCount = new System.Windows.Forms.Label();
			this.lbl_maleFemalePercent = new System.Windows.Forms.Label();
			this.lbl_maleFemale = new System.Windows.Forms.Label();
			this.lbl_noCroakPercent = new System.Windows.Forms.Label();
			this.lbl_noCroakCount = new System.Windows.Forms.Label();
			this.lbl_noCroak = new System.Windows.Forms.Label();
			this.lbl_twoMalesCount = new System.Windows.Forms.Label();
			this.lbl_twoMalesPercent = new System.Windows.Forms.Label();
			this.lbl_twoMales = new System.Windows.Forms.Label();
			this.lbl_globalCounter = new System.Windows.Forms.Label();
			this.pnl_radioCroaks = new System.Windows.Forms.Panel();
			this.rdb_twoCroaks = new System.Windows.Forms.RadioButton();
			this.rdb_oneCroak = new System.Windows.Forms.RadioButton();
			this.rdb_noCroaks = new System.Windows.Forms.RadioButton();
			this.rdb_allCroaks = new System.Windows.Forms.RadioButton();
			this.lbl_filteredCounter = new System.Windows.Forms.Label();
			this.lbl_filteredPercent = new System.Windows.Forms.Label();
			this.gpb_frog1Stats.SuspendLayout();
			this.gpb_frog2Stats.SuspendLayout();
			this.pnl_buttons.SuspendLayout();
			this.gpb_groupStats.SuspendLayout();
			this.pnl_radioCroaks.SuspendLayout();
			this.SuspendLayout();
			// 
			// lbl_frog1
			// 
			this.lbl_frog1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_frog1.Location = new System.Drawing.Point(95, 10);
			this.lbl_frog1.Name = "lbl_frog1";
			this.lbl_frog1.Size = new System.Drawing.Size(70, 30);
			this.lbl_frog1.TabIndex = 7;
			this.lbl_frog1.Text = "Frog #1";
			// 
			// lbl_frog2
			// 
			this.lbl_frog2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_frog2.Location = new System.Drawing.Point(355, 10);
			this.lbl_frog2.Name = "lbl_frog2";
			this.lbl_frog2.Size = new System.Drawing.Size(70, 30);
			this.lbl_frog2.TabIndex = 8;
			this.lbl_frog2.Text = "Frog #2";
			// 
			// lst_frog1Gender
			// 
			this.lst_frog1Gender.FormattingEnabled = true;
			this.lst_frog1Gender.HorizontalScrollbar = true;
			this.lst_frog1Gender.Location = new System.Drawing.Point(5, 40);
			this.lst_frog1Gender.Name = "lst_frog1Gender";
			this.lst_frog1Gender.Size = new System.Drawing.Size(125, 160);
			this.lst_frog1Gender.TabIndex = 13;
			this.lst_frog1Gender.SelectedIndexChanged += new System.EventHandler(this.Lst_IndexChange);
			// 
			// lst_frog1Croaked
			// 
			this.lst_frog1Croaked.FormattingEnabled = true;
			this.lst_frog1Croaked.HorizontalScrollbar = true;
			this.lst_frog1Croaked.Location = new System.Drawing.Point(130, 40);
			this.lst_frog1Croaked.Name = "lst_frog1Croaked";
			this.lst_frog1Croaked.Size = new System.Drawing.Size(125, 160);
			this.lst_frog1Croaked.TabIndex = 15;
			this.lst_frog1Croaked.SelectedIndexChanged += new System.EventHandler(this.Lst_IndexChange);
			// 
			// lst_frog2Gender
			// 
			this.lst_frog2Gender.FormattingEnabled = true;
			this.lst_frog2Gender.HorizontalScrollbar = true;
			this.lst_frog2Gender.Location = new System.Drawing.Point(265, 40);
			this.lst_frog2Gender.Name = "lst_frog2Gender";
			this.lst_frog2Gender.Size = new System.Drawing.Size(125, 160);
			this.lst_frog2Gender.TabIndex = 16;
			this.lst_frog2Gender.SelectedIndexChanged += new System.EventHandler(this.Lst_IndexChange);
			// 
			// lst_frog2Croaked
			// 
			this.lst_frog2Croaked.FormattingEnabled = true;
			this.lst_frog2Croaked.HorizontalScrollbar = true;
			this.lst_frog2Croaked.Location = new System.Drawing.Point(390, 40);
			this.lst_frog2Croaked.Name = "lst_frog2Croaked";
			this.lst_frog2Croaked.Size = new System.Drawing.Size(125, 160);
			this.lst_frog2Croaked.TabIndex = 17;
			this.lst_frog2Croaked.SelectedIndexChanged += new System.EventHandler(this.Lst_IndexChange);
			// 
			// btn_test1
			// 
			this.btn_test1.Location = new System.Drawing.Point(5, 5);
			this.btn_test1.Name = "btn_test1";
			this.btn_test1.Size = new System.Drawing.Size(90, 30);
			this.btn_test1.TabIndex = 24;
			this.btn_test1.Tag = "1";
			this.btn_test1.Text = "Test +1";
			this.btn_test1.UseVisualStyleBackColor = true;
			this.btn_test1.Click += new System.EventHandler(this.Btn_testFrogsClick);
			// 
			// btn_test5
			// 
			this.btn_test5.Location = new System.Drawing.Point(105, 5);
			this.btn_test5.Name = "btn_test5";
			this.btn_test5.Size = new System.Drawing.Size(90, 30);
			this.btn_test5.TabIndex = 25;
			this.btn_test5.Tag = "5";
			this.btn_test5.Text = "Test +5";
			this.btn_test5.UseVisualStyleBackColor = true;
			this.btn_test5.Click += new System.EventHandler(this.Btn_testFrogsClick);
			// 
			// btn_test10
			// 
			this.btn_test10.Location = new System.Drawing.Point(205, 5);
			this.btn_test10.Name = "btn_test10";
			this.btn_test10.Size = new System.Drawing.Size(90, 30);
			this.btn_test10.TabIndex = 26;
			this.btn_test10.Tag = "10";
			this.btn_test10.Text = "Test +10";
			this.btn_test10.UseVisualStyleBackColor = true;
			this.btn_test10.Click += new System.EventHandler(this.Btn_testFrogsClick);
			// 
			// btn_test50
			// 
			this.btn_test50.Location = new System.Drawing.Point(305, 5);
			this.btn_test50.Name = "btn_test50";
			this.btn_test50.Size = new System.Drawing.Size(90, 30);
			this.btn_test50.TabIndex = 27;
			this.btn_test50.Tag = "50";
			this.btn_test50.Text = "Test +50";
			this.btn_test50.UseVisualStyleBackColor = true;
			this.btn_test50.Click += new System.EventHandler(this.Btn_testFrogsClick);
			// 
			// btn_test100
			// 
			this.btn_test100.Location = new System.Drawing.Point(405, 5);
			this.btn_test100.Name = "btn_test100";
			this.btn_test100.Size = new System.Drawing.Size(90, 30);
			this.btn_test100.TabIndex = 28;
			this.btn_test100.Tag = "100";
			this.btn_test100.Text = "Test +100";
			this.btn_test100.UseVisualStyleBackColor = true;
			this.btn_test100.Click += new System.EventHandler(this.Btn_testFrogsClick);
			// 
			// btn_test500
			// 
			this.btn_test500.Location = new System.Drawing.Point(5, 45);
			this.btn_test500.Name = "btn_test500";
			this.btn_test500.Size = new System.Drawing.Size(90, 30);
			this.btn_test500.TabIndex = 29;
			this.btn_test500.Tag = "500";
			this.btn_test500.Text = "Test +500";
			this.btn_test500.UseVisualStyleBackColor = true;
			this.btn_test500.Click += new System.EventHandler(this.Btn_testFrogsClick);
			// 
			// btn_test1000
			// 
			this.btn_test1000.Location = new System.Drawing.Point(105, 45);
			this.btn_test1000.Name = "btn_test1000";
			this.btn_test1000.Size = new System.Drawing.Size(90, 30);
			this.btn_test1000.TabIndex = 30;
			this.btn_test1000.Tag = "1000";
			this.btn_test1000.Text = "Test +1000";
			this.btn_test1000.UseVisualStyleBackColor = true;
			this.btn_test1000.Click += new System.EventHandler(this.Btn_testFrogsClick);
			// 
			// btn_test5000
			// 
			this.btn_test5000.Location = new System.Drawing.Point(205, 45);
			this.btn_test5000.Name = "btn_test5000";
			this.btn_test5000.Size = new System.Drawing.Size(90, 30);
			this.btn_test5000.TabIndex = 31;
			this.btn_test5000.Tag = "5000";
			this.btn_test5000.Text = "Test +5000";
			this.btn_test5000.UseVisualStyleBackColor = true;
			this.btn_test5000.Click += new System.EventHandler(this.Btn_testFrogsClick);
			// 
			// btn_test10000
			// 
			this.btn_test10000.Location = new System.Drawing.Point(305, 45);
			this.btn_test10000.Name = "btn_test10000";
			this.btn_test10000.Size = new System.Drawing.Size(90, 30);
			this.btn_test10000.TabIndex = 32;
			this.btn_test10000.Tag = "10000";
			this.btn_test10000.Text = "Test +10000";
			this.btn_test10000.UseVisualStyleBackColor = true;
			this.btn_test10000.Click += new System.EventHandler(this.Btn_testFrogsClick);
			// 
			// btn_test50000
			// 
			this.btn_test50000.Location = new System.Drawing.Point(405, 45);
			this.btn_test50000.Name = "btn_test50000";
			this.btn_test50000.Size = new System.Drawing.Size(90, 30);
			this.btn_test50000.TabIndex = 33;
			this.btn_test50000.Tag = "50000";
			this.btn_test50000.Text = "Test +50000";
			this.btn_test50000.UseVisualStyleBackColor = true;
			this.btn_test50000.Click += new System.EventHandler(this.Btn_testFrogsClick);
			// 
			// gpb_frog1Stats
			// 
			this.gpb_frog1Stats.Controls.Add(this.lbl_frog1CroakCount);
			this.gpb_frog1Stats.Controls.Add(this.lbl_frog1CroakPercent);
			this.gpb_frog1Stats.Controls.Add(this.lbl_frog1Croak);
			this.gpb_frog1Stats.Controls.Add(this.lbl_frog1FemalePercent);
			this.gpb_frog1Stats.Controls.Add(this.lbl_frog1FemaleCount);
			this.gpb_frog1Stats.Controls.Add(this.lbl_frog1Female);
			this.gpb_frog1Stats.Controls.Add(this.lbl_frog1MaleCount);
			this.gpb_frog1Stats.Controls.Add(this.lbl_frog1MalePercent);
			this.gpb_frog1Stats.Controls.Add(this.lbl_frog1Male);
			this.gpb_frog1Stats.Location = new System.Drawing.Point(10, 210);
			this.gpb_frog1Stats.Name = "gpb_frog1Stats";
			this.gpb_frog1Stats.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gpb_frog1Stats.Size = new System.Drawing.Size(240, 80);
			this.gpb_frog1Stats.TabIndex = 34;
			this.gpb_frog1Stats.TabStop = false;
			this.gpb_frog1Stats.Text = "Frog 1 Stats";
			// 
			// lbl_frog1CroakCount
			// 
			this.lbl_frog1CroakCount.Location = new System.Drawing.Point(120, 45);
			this.lbl_frog1CroakCount.Name = "lbl_frog1CroakCount";
			this.lbl_frog1CroakCount.Size = new System.Drawing.Size(50, 15);
			this.lbl_frog1CroakCount.TabIndex = 8;
			this.lbl_frog1CroakCount.Text = "0";
			// 
			// lbl_frog1CroakPercent
			// 
			this.lbl_frog1CroakPercent.Location = new System.Drawing.Point(175, 45);
			this.lbl_frog1CroakPercent.Name = "lbl_frog1CroakPercent";
			this.lbl_frog1CroakPercent.Size = new System.Drawing.Size(50, 15);
			this.lbl_frog1CroakPercent.TabIndex = 7;
			this.lbl_frog1CroakPercent.Text = "0%";
			// 
			// lbl_frog1Croak
			// 
			this.lbl_frog1Croak.Location = new System.Drawing.Point(150, 30);
			this.lbl_frog1Croak.Name = "lbl_frog1Croak";
			this.lbl_frog1Croak.Size = new System.Drawing.Size(50, 15);
			this.lbl_frog1Croak.TabIndex = 6;
			this.lbl_frog1Croak.Text = "Croaked";
			// 
			// lbl_frog1FemalePercent
			// 
			this.lbl_frog1FemalePercent.Location = new System.Drawing.Point(60, 60);
			this.lbl_frog1FemalePercent.Name = "lbl_frog1FemalePercent";
			this.lbl_frog1FemalePercent.Size = new System.Drawing.Size(50, 15);
			this.lbl_frog1FemalePercent.TabIndex = 5;
			this.lbl_frog1FemalePercent.Text = "0%";
			// 
			// lbl_frog1FemaleCount
			// 
			this.lbl_frog1FemaleCount.Location = new System.Drawing.Point(5, 60);
			this.lbl_frog1FemaleCount.Name = "lbl_frog1FemaleCount";
			this.lbl_frog1FemaleCount.Size = new System.Drawing.Size(50, 15);
			this.lbl_frog1FemaleCount.TabIndex = 4;
			this.lbl_frog1FemaleCount.Text = "0";
			// 
			// lbl_frog1Female
			// 
			this.lbl_frog1Female.Location = new System.Drawing.Point(35, 45);
			this.lbl_frog1Female.Name = "lbl_frog1Female";
			this.lbl_frog1Female.Size = new System.Drawing.Size(45, 15);
			this.lbl_frog1Female.TabIndex = 3;
			this.lbl_frog1Female.Text = "Female";
			// 
			// lbl_frog1MaleCount
			// 
			this.lbl_frog1MaleCount.Location = new System.Drawing.Point(5, 30);
			this.lbl_frog1MaleCount.Name = "lbl_frog1MaleCount";
			this.lbl_frog1MaleCount.Size = new System.Drawing.Size(50, 15);
			this.lbl_frog1MaleCount.TabIndex = 2;
			this.lbl_frog1MaleCount.Text = "0";
			// 
			// lbl_frog1MalePercent
			// 
			this.lbl_frog1MalePercent.Location = new System.Drawing.Point(60, 30);
			this.lbl_frog1MalePercent.Name = "lbl_frog1MalePercent";
			this.lbl_frog1MalePercent.Size = new System.Drawing.Size(50, 15);
			this.lbl_frog1MalePercent.TabIndex = 1;
			this.lbl_frog1MalePercent.Text = "0%";
			// 
			// lbl_frog1Male
			// 
			this.lbl_frog1Male.Location = new System.Drawing.Point(40, 15);
			this.lbl_frog1Male.Name = "lbl_frog1Male";
			this.lbl_frog1Male.Size = new System.Drawing.Size(30, 15);
			this.lbl_frog1Male.TabIndex = 0;
			this.lbl_frog1Male.Text = "Male";
			// 
			// gpb_frog2Stats
			// 
			this.gpb_frog2Stats.Controls.Add(this.lbl_frog2CroakCount);
			this.gpb_frog2Stats.Controls.Add(this.lbl_frog2CroakPercent);
			this.gpb_frog2Stats.Controls.Add(this.lbl_frog2Croaked);
			this.gpb_frog2Stats.Controls.Add(this.lbl_frog2FemalePercent);
			this.gpb_frog2Stats.Controls.Add(this.lbl_frog2FemaleCount);
			this.gpb_frog2Stats.Controls.Add(this.lbl_frog2Female);
			this.gpb_frog2Stats.Controls.Add(this.lbl_frog2MaleCount);
			this.gpb_frog2Stats.Controls.Add(this.lbl_frog2MalePercent);
			this.gpb_frog2Stats.Controls.Add(this.lbl_frog2Male);
			this.gpb_frog2Stats.Location = new System.Drawing.Point(270, 210);
			this.gpb_frog2Stats.Name = "gpb_frog2Stats";
			this.gpb_frog2Stats.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gpb_frog2Stats.Size = new System.Drawing.Size(240, 80);
			this.gpb_frog2Stats.TabIndex = 35;
			this.gpb_frog2Stats.TabStop = false;
			this.gpb_frog2Stats.Text = "Frog 2 Stats";
			// 
			// lbl_frog2CroakCount
			// 
			this.lbl_frog2CroakCount.Location = new System.Drawing.Point(120, 45);
			this.lbl_frog2CroakCount.Name = "lbl_frog2CroakCount";
			this.lbl_frog2CroakCount.Size = new System.Drawing.Size(50, 15);
			this.lbl_frog2CroakCount.TabIndex = 8;
			this.lbl_frog2CroakCount.Text = "0";
			// 
			// lbl_frog2CroakPercent
			// 
			this.lbl_frog2CroakPercent.Location = new System.Drawing.Point(175, 45);
			this.lbl_frog2CroakPercent.Name = "lbl_frog2CroakPercent";
			this.lbl_frog2CroakPercent.Size = new System.Drawing.Size(50, 15);
			this.lbl_frog2CroakPercent.TabIndex = 7;
			this.lbl_frog2CroakPercent.Text = "0%";
			// 
			// lbl_frog2Croaked
			// 
			this.lbl_frog2Croaked.Location = new System.Drawing.Point(150, 30);
			this.lbl_frog2Croaked.Name = "lbl_frog2Croaked";
			this.lbl_frog2Croaked.Size = new System.Drawing.Size(50, 15);
			this.lbl_frog2Croaked.TabIndex = 6;
			this.lbl_frog2Croaked.Text = "Croaked";
			// 
			// lbl_frog2FemalePercent
			// 
			this.lbl_frog2FemalePercent.Location = new System.Drawing.Point(60, 60);
			this.lbl_frog2FemalePercent.Name = "lbl_frog2FemalePercent";
			this.lbl_frog2FemalePercent.Size = new System.Drawing.Size(50, 15);
			this.lbl_frog2FemalePercent.TabIndex = 5;
			this.lbl_frog2FemalePercent.Text = "0%";
			// 
			// lbl_frog2FemaleCount
			// 
			this.lbl_frog2FemaleCount.Location = new System.Drawing.Point(5, 60);
			this.lbl_frog2FemaleCount.Name = "lbl_frog2FemaleCount";
			this.lbl_frog2FemaleCount.Size = new System.Drawing.Size(50, 15);
			this.lbl_frog2FemaleCount.TabIndex = 4;
			this.lbl_frog2FemaleCount.Text = "0";
			// 
			// lbl_frog2Female
			// 
			this.lbl_frog2Female.Location = new System.Drawing.Point(35, 45);
			this.lbl_frog2Female.Name = "lbl_frog2Female";
			this.lbl_frog2Female.Size = new System.Drawing.Size(45, 15);
			this.lbl_frog2Female.TabIndex = 3;
			this.lbl_frog2Female.Text = "Female";
			// 
			// lbl_frog2MaleCount
			// 
			this.lbl_frog2MaleCount.Location = new System.Drawing.Point(5, 30);
			this.lbl_frog2MaleCount.Name = "lbl_frog2MaleCount";
			this.lbl_frog2MaleCount.Size = new System.Drawing.Size(50, 15);
			this.lbl_frog2MaleCount.TabIndex = 2;
			this.lbl_frog2MaleCount.Text = "0";
			// 
			// lbl_frog2MalePercent
			// 
			this.lbl_frog2MalePercent.Location = new System.Drawing.Point(60, 30);
			this.lbl_frog2MalePercent.Name = "lbl_frog2MalePercent";
			this.lbl_frog2MalePercent.Size = new System.Drawing.Size(50, 15);
			this.lbl_frog2MalePercent.TabIndex = 1;
			this.lbl_frog2MalePercent.Text = "0%";
			// 
			// lbl_frog2Male
			// 
			this.lbl_frog2Male.Location = new System.Drawing.Point(40, 15);
			this.lbl_frog2Male.Name = "lbl_frog2Male";
			this.lbl_frog2Male.Size = new System.Drawing.Size(30, 15);
			this.lbl_frog2Male.TabIndex = 0;
			this.lbl_frog2Male.Text = "Male";
			// 
			// pnl_buttons
			// 
			this.pnl_buttons.Controls.Add(this.btn_test1);
			this.pnl_buttons.Controls.Add(this.btn_test5);
			this.pnl_buttons.Controls.Add(this.btn_test10);
			this.pnl_buttons.Controls.Add(this.btn_test50);
			this.pnl_buttons.Controls.Add(this.btn_test100);
			this.pnl_buttons.Controls.Add(this.btn_test500);
			this.pnl_buttons.Controls.Add(this.btn_test1000);
			this.pnl_buttons.Controls.Add(this.btn_test5000);
			this.pnl_buttons.Controls.Add(this.btn_test10000);
			this.pnl_buttons.Controls.Add(this.btn_test50000);
			this.pnl_buttons.Location = new System.Drawing.Point(15, 390);
			this.pnl_buttons.Name = "pnl_buttons";
			this.pnl_buttons.Size = new System.Drawing.Size(500, 80);
			this.pnl_buttons.TabIndex = 36;
			// 
			// gpb_groupStats
			// 
			this.gpb_groupStats.Controls.Add(this.lbl_twoCroaksPercent);
			this.gpb_groupStats.Controls.Add(this.lbl_twoCroaksCount);
			this.gpb_groupStats.Controls.Add(this.lbl_twoCroaks);
			this.gpb_groupStats.Controls.Add(this.lbl_twoFemalesCount);
			this.gpb_groupStats.Controls.Add(this.lbl_twoFemalesPercent);
			this.gpb_groupStats.Controls.Add(this.lbl_twoFemales);
			this.gpb_groupStats.Controls.Add(this.lbl_oneCroakPercent);
			this.gpb_groupStats.Controls.Add(this.lbl_oneCroakCount);
			this.gpb_groupStats.Controls.Add(this.lbl_oneCroak);
			this.gpb_groupStats.Controls.Add(this.lbl_maleFemaleCount);
			this.gpb_groupStats.Controls.Add(this.lbl_maleFemalePercent);
			this.gpb_groupStats.Controls.Add(this.lbl_maleFemale);
			this.gpb_groupStats.Controls.Add(this.lbl_noCroakPercent);
			this.gpb_groupStats.Controls.Add(this.lbl_noCroakCount);
			this.gpb_groupStats.Controls.Add(this.lbl_noCroak);
			this.gpb_groupStats.Controls.Add(this.lbl_twoMalesCount);
			this.gpb_groupStats.Controls.Add(this.lbl_twoMalesPercent);
			this.gpb_groupStats.Controls.Add(this.lbl_twoMales);
			this.gpb_groupStats.Location = new System.Drawing.Point(10, 295);
			this.gpb_groupStats.Name = "gpb_groupStats";
			this.gpb_groupStats.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.gpb_groupStats.Size = new System.Drawing.Size(360, 90);
			this.gpb_groupStats.TabIndex = 37;
			this.gpb_groupStats.TabStop = false;
			this.gpb_groupStats.Text = "Both Frogs Stats";
			// 
			// lbl_twoCroaksPercent
			// 
			this.lbl_twoCroaksPercent.Location = new System.Drawing.Point(300, 70);
			this.lbl_twoCroaksPercent.Name = "lbl_twoCroaksPercent";
			this.lbl_twoCroaksPercent.Size = new System.Drawing.Size(50, 15);
			this.lbl_twoCroaksPercent.TabIndex = 23;
			this.lbl_twoCroaksPercent.Text = "0%";
			// 
			// lbl_twoCroaksCount
			// 
			this.lbl_twoCroaksCount.Location = new System.Drawing.Point(245, 70);
			this.lbl_twoCroaksCount.Name = "lbl_twoCroaksCount";
			this.lbl_twoCroaksCount.Size = new System.Drawing.Size(50, 15);
			this.lbl_twoCroaksCount.TabIndex = 22;
			this.lbl_twoCroaksCount.Text = "0";
			// 
			// lbl_twoCroaks
			// 
			this.lbl_twoCroaks.Location = new System.Drawing.Point(270, 55);
			this.lbl_twoCroaks.Name = "lbl_twoCroaks";
			this.lbl_twoCroaks.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl_twoCroaks.Size = new System.Drawing.Size(50, 15);
			this.lbl_twoCroaks.TabIndex = 21;
			this.lbl_twoCroaks.Text = "2 Croaks";
			// 
			// lbl_twoFemalesCount
			// 
			this.lbl_twoFemalesCount.Location = new System.Drawing.Point(245, 30);
			this.lbl_twoFemalesCount.Name = "lbl_twoFemalesCount";
			this.lbl_twoFemalesCount.Size = new System.Drawing.Size(50, 15);
			this.lbl_twoFemalesCount.TabIndex = 20;
			this.lbl_twoFemalesCount.Text = "0";
			// 
			// lbl_twoFemalesPercent
			// 
			this.lbl_twoFemalesPercent.Location = new System.Drawing.Point(300, 30);
			this.lbl_twoFemalesPercent.Name = "lbl_twoFemalesPercent";
			this.lbl_twoFemalesPercent.Size = new System.Drawing.Size(50, 15);
			this.lbl_twoFemalesPercent.TabIndex = 19;
			this.lbl_twoFemalesPercent.Text = "0%";
			// 
			// lbl_twoFemales
			// 
			this.lbl_twoFemales.Location = new System.Drawing.Point(265, 15);
			this.lbl_twoFemales.Name = "lbl_twoFemales";
			this.lbl_twoFemales.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl_twoFemales.Size = new System.Drawing.Size(55, 15);
			this.lbl_twoFemales.TabIndex = 18;
			this.lbl_twoFemales.Text = "2 Females";
			// 
			// lbl_oneCroakPercent
			// 
			this.lbl_oneCroakPercent.Location = new System.Drawing.Point(180, 70);
			this.lbl_oneCroakPercent.Name = "lbl_oneCroakPercent";
			this.lbl_oneCroakPercent.Size = new System.Drawing.Size(50, 15);
			this.lbl_oneCroakPercent.TabIndex = 17;
			this.lbl_oneCroakPercent.Text = "0%";
			// 
			// lbl_oneCroakCount
			// 
			this.lbl_oneCroakCount.Location = new System.Drawing.Point(125, 70);
			this.lbl_oneCroakCount.Name = "lbl_oneCroakCount";
			this.lbl_oneCroakCount.Size = new System.Drawing.Size(50, 15);
			this.lbl_oneCroakCount.TabIndex = 16;
			this.lbl_oneCroakCount.Text = "0";
			// 
			// lbl_oneCroak
			// 
			this.lbl_oneCroak.Location = new System.Drawing.Point(160, 55);
			this.lbl_oneCroak.Name = "lbl_oneCroak";
			this.lbl_oneCroak.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl_oneCroak.Size = new System.Drawing.Size(45, 15);
			this.lbl_oneCroak.TabIndex = 15;
			this.lbl_oneCroak.Text = "1 Croak";
			// 
			// lbl_maleFemaleCount
			// 
			this.lbl_maleFemaleCount.Location = new System.Drawing.Point(125, 30);
			this.lbl_maleFemaleCount.Name = "lbl_maleFemaleCount";
			this.lbl_maleFemaleCount.Size = new System.Drawing.Size(50, 15);
			this.lbl_maleFemaleCount.TabIndex = 14;
			this.lbl_maleFemaleCount.Text = "0";
			// 
			// lbl_maleFemalePercent
			// 
			this.lbl_maleFemalePercent.Location = new System.Drawing.Point(180, 30);
			this.lbl_maleFemalePercent.Name = "lbl_maleFemalePercent";
			this.lbl_maleFemalePercent.Size = new System.Drawing.Size(50, 15);
			this.lbl_maleFemalePercent.TabIndex = 13;
			this.lbl_maleFemalePercent.Text = "0%";
			// 
			// lbl_maleFemale
			// 
			this.lbl_maleFemale.Location = new System.Drawing.Point(140, 15);
			this.lbl_maleFemale.Name = "lbl_maleFemale";
			this.lbl_maleFemale.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl_maleFemale.Size = new System.Drawing.Size(75, 15);
			this.lbl_maleFemale.TabIndex = 12;
			this.lbl_maleFemale.Text = "Male / Female";
			// 
			// lbl_noCroakPercent
			// 
			this.lbl_noCroakPercent.Location = new System.Drawing.Point(60, 70);
			this.lbl_noCroakPercent.Name = "lbl_noCroakPercent";
			this.lbl_noCroakPercent.Size = new System.Drawing.Size(50, 15);
			this.lbl_noCroakPercent.TabIndex = 11;
			this.lbl_noCroakPercent.Text = "0%";
			// 
			// lbl_noCroakCount
			// 
			this.lbl_noCroakCount.Location = new System.Drawing.Point(5, 70);
			this.lbl_noCroakCount.Name = "lbl_noCroakCount";
			this.lbl_noCroakCount.Size = new System.Drawing.Size(50, 15);
			this.lbl_noCroakCount.TabIndex = 10;
			this.lbl_noCroakCount.Text = "0";
			// 
			// lbl_noCroak
			// 
			this.lbl_noCroak.Location = new System.Drawing.Point(30, 55);
			this.lbl_noCroak.Name = "lbl_noCroak";
			this.lbl_noCroak.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl_noCroak.Size = new System.Drawing.Size(60, 15);
			this.lbl_noCroak.TabIndex = 9;
			this.lbl_noCroak.Text = "No Croaks";
			// 
			// lbl_twoMalesCount
			// 
			this.lbl_twoMalesCount.Location = new System.Drawing.Point(5, 30);
			this.lbl_twoMalesCount.Name = "lbl_twoMalesCount";
			this.lbl_twoMalesCount.Size = new System.Drawing.Size(50, 15);
			this.lbl_twoMalesCount.TabIndex = 8;
			this.lbl_twoMalesCount.Text = "0";
			// 
			// lbl_twoMalesPercent
			// 
			this.lbl_twoMalesPercent.Location = new System.Drawing.Point(60, 30);
			this.lbl_twoMalesPercent.Name = "lbl_twoMalesPercent";
			this.lbl_twoMalesPercent.Size = new System.Drawing.Size(50, 15);
			this.lbl_twoMalesPercent.TabIndex = 7;
			this.lbl_twoMalesPercent.Text = "0%";
			// 
			// lbl_twoMales
			// 
			this.lbl_twoMales.Location = new System.Drawing.Point(35, 15);
			this.lbl_twoMales.Name = "lbl_twoMales";
			this.lbl_twoMales.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lbl_twoMales.Size = new System.Drawing.Size(45, 15);
			this.lbl_twoMales.TabIndex = 6;
			this.lbl_twoMales.Text = "2 Males";
			// 
			// lbl_globalCounter
			// 
			this.lbl_globalCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_globalCounter.Location = new System.Drawing.Point(210, 5);
			this.lbl_globalCounter.Name = "lbl_globalCounter";
			this.lbl_globalCounter.Size = new System.Drawing.Size(100, 15);
			this.lbl_globalCounter.TabIndex = 38;
			this.lbl_globalCounter.Text = "Total: 0";
			// 
			// pnl_radioCroaks
			// 
			this.pnl_radioCroaks.Controls.Add(this.rdb_twoCroaks);
			this.pnl_radioCroaks.Controls.Add(this.rdb_oneCroak);
			this.pnl_radioCroaks.Controls.Add(this.rdb_noCroaks);
			this.pnl_radioCroaks.Controls.Add(this.rdb_allCroaks);
			this.pnl_radioCroaks.Location = new System.Drawing.Point(400, 295);
			this.pnl_radioCroaks.Name = "pnl_radioCroaks";
			this.pnl_radioCroaks.Size = new System.Drawing.Size(90, 90);
			this.pnl_radioCroaks.TabIndex = 39;
			// 
			// rdb_twoCroaks
			// 
			this.rdb_twoCroaks.Location = new System.Drawing.Point(5, 25);
			this.rdb_twoCroaks.Name = "rdb_twoCroaks";
			this.rdb_twoCroaks.Size = new System.Drawing.Size(80, 15);
			this.rdb_twoCroaks.TabIndex = 3;
			this.rdb_twoCroaks.TabStop = true;
			this.rdb_twoCroaks.Text = "2 Croaks";
			this.rdb_twoCroaks.UseVisualStyleBackColor = true;
			this.rdb_twoCroaks.CheckedChanged += new System.EventHandler(this.Rdb_CheckedChanged);
			// 
			// rdb_oneCroak
			// 
			this.rdb_oneCroak.Location = new System.Drawing.Point(5, 45);
			this.rdb_oneCroak.Name = "rdb_oneCroak";
			this.rdb_oneCroak.Size = new System.Drawing.Size(80, 15);
			this.rdb_oneCroak.TabIndex = 2;
			this.rdb_oneCroak.TabStop = true;
			this.rdb_oneCroak.Text = "1 Croak";
			this.rdb_oneCroak.UseVisualStyleBackColor = true;
			this.rdb_oneCroak.CheckedChanged += new System.EventHandler(this.Rdb_CheckedChanged);
			// 
			// rdb_noCroaks
			// 
			this.rdb_noCroaks.Location = new System.Drawing.Point(5, 65);
			this.rdb_noCroaks.Name = "rdb_noCroaks";
			this.rdb_noCroaks.Size = new System.Drawing.Size(80, 15);
			this.rdb_noCroaks.TabIndex = 1;
			this.rdb_noCroaks.TabStop = true;
			this.rdb_noCroaks.Text = "No Croaks";
			this.rdb_noCroaks.UseVisualStyleBackColor = true;
			this.rdb_noCroaks.CheckedChanged += new System.EventHandler(this.Rdb_CheckedChanged);
			// 
			// rdb_allCroaks
			// 
			this.rdb_allCroaks.Location = new System.Drawing.Point(5, 5);
			this.rdb_allCroaks.Name = "rdb_allCroaks";
			this.rdb_allCroaks.Size = new System.Drawing.Size(80, 15);
			this.rdb_allCroaks.TabIndex = 0;
			this.rdb_allCroaks.TabStop = true;
			this.rdb_allCroaks.Text = "All Results";
			this.rdb_allCroaks.UseVisualStyleBackColor = true;
			this.rdb_allCroaks.CheckedChanged += new System.EventHandler(this.Rdb_CheckedChanged);
			// 
			// lbl_filteredCounter
			// 
			this.lbl_filteredCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_filteredCounter.Location = new System.Drawing.Point(175, 20);
			this.lbl_filteredCounter.Name = "lbl_filteredCounter";
			this.lbl_filteredCounter.Size = new System.Drawing.Size(100, 15);
			this.lbl_filteredCounter.TabIndex = 40;
			this.lbl_filteredCounter.Text = "Found: 0";
			// 
			// lbl_filteredPercent
			// 
			this.lbl_filteredPercent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_filteredPercent.Location = new System.Drawing.Point(280, 20);
			this.lbl_filteredPercent.Name = "lbl_filteredPercent";
			this.lbl_filteredPercent.Size = new System.Drawing.Size(60, 15);
			this.lbl_filteredPercent.TabIndex = 41;
			this.lbl_filteredPercent.Text = "0%";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 482);
			this.Controls.Add(this.lbl_filteredPercent);
			this.Controls.Add(this.lbl_filteredCounter);
			this.Controls.Add(this.pnl_radioCroaks);
			this.Controls.Add(this.lbl_globalCounter);
			this.Controls.Add(this.gpb_groupStats);
			this.Controls.Add(this.pnl_buttons);
			this.Controls.Add(this.gpb_frog2Stats);
			this.Controls.Add(this.gpb_frog1Stats);
			this.Controls.Add(this.lst_frog2Croaked);
			this.Controls.Add(this.lst_frog2Gender);
			this.Controls.Add(this.lst_frog1Croaked);
			this.Controls.Add(this.lst_frog1Gender);
			this.Controls.Add(this.lbl_frog2);
			this.Controls.Add(this.lbl_frog1);
			this.Name = "MainForm";
			this.Text = "TheFrogRiddle";
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.gpb_frog1Stats.ResumeLayout(false);
			this.gpb_frog2Stats.ResumeLayout(false);
			this.pnl_buttons.ResumeLayout(false);
			this.gpb_groupStats.ResumeLayout(false);
			this.pnl_radioCroaks.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label lbl_filteredPercent;
		private System.Windows.Forms.Label lbl_filteredCounter;
		private System.Windows.Forms.RadioButton rdb_allCroaks;
		private System.Windows.Forms.RadioButton rdb_noCroaks;
		private System.Windows.Forms.RadioButton rdb_oneCroak;
		private System.Windows.Forms.RadioButton rdb_twoCroaks;
		private System.Windows.Forms.Panel pnl_radioCroaks;
		private System.Windows.Forms.Label lbl_globalCounter;
		private System.Windows.Forms.Label lbl_twoMales;
		private System.Windows.Forms.Label lbl_twoMalesPercent;
		private System.Windows.Forms.Label lbl_twoMalesCount;
		private System.Windows.Forms.Label lbl_noCroak;
		private System.Windows.Forms.Label lbl_noCroakCount;
		private System.Windows.Forms.Label lbl_noCroakPercent;
		private System.Windows.Forms.Label lbl_maleFemale;
		private System.Windows.Forms.Label lbl_maleFemalePercent;
		private System.Windows.Forms.Label lbl_maleFemaleCount;
		private System.Windows.Forms.Label lbl_oneCroak;
		private System.Windows.Forms.Label lbl_oneCroakCount;
		private System.Windows.Forms.Label lbl_oneCroakPercent;
		private System.Windows.Forms.Label lbl_twoFemales;
		private System.Windows.Forms.Label lbl_twoFemalesPercent;
		private System.Windows.Forms.Label lbl_twoFemalesCount;
		private System.Windows.Forms.Label lbl_twoCroaks;
		private System.Windows.Forms.Label lbl_twoCroaksCount;
		private System.Windows.Forms.Label lbl_twoCroaksPercent;
		private System.Windows.Forms.GroupBox gpb_groupStats;
		private System.Windows.Forms.Panel pnl_buttons;
		private System.Windows.Forms.Label lbl_frog2Male;
		private System.Windows.Forms.Label lbl_frog2MalePercent;
		private System.Windows.Forms.Label lbl_frog2MaleCount;
		private System.Windows.Forms.Label lbl_frog2Female;
		private System.Windows.Forms.Label lbl_frog2FemaleCount;
		private System.Windows.Forms.Label lbl_frog2FemalePercent;
		private System.Windows.Forms.Label lbl_frog2Croaked;
		private System.Windows.Forms.Label lbl_frog2CroakPercent;
		private System.Windows.Forms.Label lbl_frog2CroakCount;
		private System.Windows.Forms.GroupBox gpb_frog2Stats;
		private System.Windows.Forms.Label lbl_frog1Female;
		private System.Windows.Forms.Label lbl_frog1FemaleCount;
		private System.Windows.Forms.Label lbl_frog1FemalePercent;
		private System.Windows.Forms.Label lbl_frog1Croak;
		private System.Windows.Forms.Label lbl_frog1CroakPercent;
		private System.Windows.Forms.Label lbl_frog1CroakCount;
		private System.Windows.Forms.Label lbl_frog1Male;
		private System.Windows.Forms.Label lbl_frog1MalePercent;
		private System.Windows.Forms.Label lbl_frog1MaleCount;
		private System.Windows.Forms.GroupBox gpb_frog1Stats;
		private System.Windows.Forms.Button btn_test50000;
		private System.Windows.Forms.Button btn_test10000;
		private System.Windows.Forms.Button btn_test5000;
		private System.Windows.Forms.Button btn_test1000;
		private System.Windows.Forms.Button btn_test500;
		private System.Windows.Forms.Button btn_test100;
		private System.Windows.Forms.Button btn_test50;
		private System.Windows.Forms.Button btn_test10;
		private System.Windows.Forms.Button btn_test5;
		private System.Windows.Forms.Button btn_test1;
		private System.Windows.Forms.ListBox lst_frog2Croaked;
		private System.Windows.Forms.ListBox lst_frog2Gender;
		private System.Windows.Forms.ListBox lst_frog1Croaked;
		private System.Windows.Forms.ListBox lst_frog1Gender;
		private System.Windows.Forms.Label lbl_frog2;
		private System.Windows.Forms.Label lbl_frog1;
	}
}
