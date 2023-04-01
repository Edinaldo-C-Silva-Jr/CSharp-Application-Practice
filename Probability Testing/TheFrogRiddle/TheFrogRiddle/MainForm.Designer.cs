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
			this.gpb_frog1Stats.SuspendLayout();
			this.gpb_frog2Stats.SuspendLayout();
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
			this.btn_test1.Location = new System.Drawing.Point(20, 350);
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
			this.btn_test5.Location = new System.Drawing.Point(120, 350);
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
			this.btn_test10.Location = new System.Drawing.Point(220, 350);
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
			this.btn_test50.Location = new System.Drawing.Point(320, 350);
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
			this.btn_test100.Location = new System.Drawing.Point(420, 350);
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
			this.btn_test500.Location = new System.Drawing.Point(20, 390);
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
			this.btn_test1000.Location = new System.Drawing.Point(120, 390);
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
			this.btn_test5000.Location = new System.Drawing.Point(220, 390);
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
			this.btn_test10000.Location = new System.Drawing.Point(320, 390);
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
			this.btn_test50000.Location = new System.Drawing.Point(420, 390);
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
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 442);
			this.Controls.Add(this.gpb_frog2Stats);
			this.Controls.Add(this.gpb_frog1Stats);
			this.Controls.Add(this.btn_test50000);
			this.Controls.Add(this.btn_test10000);
			this.Controls.Add(this.btn_test5000);
			this.Controls.Add(this.btn_test1000);
			this.Controls.Add(this.btn_test500);
			this.Controls.Add(this.btn_test100);
			this.Controls.Add(this.btn_test50);
			this.Controls.Add(this.btn_test10);
			this.Controls.Add(this.btn_test5);
			this.Controls.Add(this.btn_test1);
			this.Controls.Add(this.lst_frog2Croaked);
			this.Controls.Add(this.lst_frog2Gender);
			this.Controls.Add(this.lst_frog1Croaked);
			this.Controls.Add(this.lst_frog1Gender);
			this.Controls.Add(this.lbl_frog2);
			this.Controls.Add(this.lbl_frog1);
			this.Name = "MainForm";
			this.Text = "TheFrogRiddle";
			this.gpb_frog1Stats.ResumeLayout(false);
			this.gpb_frog2Stats.ResumeLayout(false);
			this.ResumeLayout(false);
		}
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
