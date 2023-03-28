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
			this.lst_Frog1_Gender = new System.Windows.Forms.ListBox();
			this.lst_Frog1_Croaked = new System.Windows.Forms.ListBox();
			this.lst_Frog2_Gender = new System.Windows.Forms.ListBox();
			this.lst_Frog2_Croaked = new System.Windows.Forms.ListBox();
			this.lbl_Frog1_MaleCounter = new System.Windows.Forms.Label();
			this.lbl_Frog1_FemaleCounter = new System.Windows.Forms.Label();
			this.lbl_Frog2_MaleCounter = new System.Windows.Forms.Label();
			this.lbl_Frog2_FemaleCounter = new System.Windows.Forms.Label();
			this.lbl_frog1_croaked = new System.Windows.Forms.Label();
			this.lbl_frog2_croaked = new System.Windows.Forms.Label();
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
			// lst_Frog1_Gender
			// 
			this.lst_Frog1_Gender.FormattingEnabled = true;
			this.lst_Frog1_Gender.HorizontalScrollbar = true;
			this.lst_Frog1_Gender.Location = new System.Drawing.Point(5, 40);
			this.lst_Frog1_Gender.Name = "lst_Frog1_Gender";
			this.lst_Frog1_Gender.Size = new System.Drawing.Size(125, 160);
			this.lst_Frog1_Gender.TabIndex = 13;
			// 
			// lst_Frog1_Croaked
			// 
			this.lst_Frog1_Croaked.FormattingEnabled = true;
			this.lst_Frog1_Croaked.HorizontalScrollbar = true;
			this.lst_Frog1_Croaked.Location = new System.Drawing.Point(130, 40);
			this.lst_Frog1_Croaked.Name = "lst_Frog1_Croaked";
			this.lst_Frog1_Croaked.Size = new System.Drawing.Size(125, 160);
			this.lst_Frog1_Croaked.TabIndex = 15;
			// 
			// lst_Frog2_Gender
			// 
			this.lst_Frog2_Gender.FormattingEnabled = true;
			this.lst_Frog2_Gender.HorizontalScrollbar = true;
			this.lst_Frog2_Gender.Location = new System.Drawing.Point(265, 40);
			this.lst_Frog2_Gender.Name = "lst_Frog2_Gender";
			this.lst_Frog2_Gender.Size = new System.Drawing.Size(125, 160);
			this.lst_Frog2_Gender.TabIndex = 16;
			// 
			// lst_Frog2_Croaked
			// 
			this.lst_Frog2_Croaked.FormattingEnabled = true;
			this.lst_Frog2_Croaked.HorizontalScrollbar = true;
			this.lst_Frog2_Croaked.Location = new System.Drawing.Point(390, 40);
			this.lst_Frog2_Croaked.Name = "lst_Frog2_Croaked";
			this.lst_Frog2_Croaked.Size = new System.Drawing.Size(125, 160);
			this.lst_Frog2_Croaked.TabIndex = 17;
			// 
			// lbl_Frog1_MaleCounter
			// 
			this.lbl_Frog1_MaleCounter.Location = new System.Drawing.Point(10, 210);
			this.lbl_Frog1_MaleCounter.Name = "lbl_Frog1_MaleCounter";
			this.lbl_Frog1_MaleCounter.Size = new System.Drawing.Size(80, 15);
			this.lbl_Frog1_MaleCounter.TabIndex = 18;
			this.lbl_Frog1_MaleCounter.Text = "Male: 0";
			// 
			// lbl_Frog1_FemaleCounter
			// 
			this.lbl_Frog1_FemaleCounter.Location = new System.Drawing.Point(10, 230);
			this.lbl_Frog1_FemaleCounter.Name = "lbl_Frog1_FemaleCounter";
			this.lbl_Frog1_FemaleCounter.Size = new System.Drawing.Size(80, 15);
			this.lbl_Frog1_FemaleCounter.TabIndex = 19;
			this.lbl_Frog1_FemaleCounter.Text = "Female: 0";
			// 
			// lbl_Frog2_MaleCounter
			// 
			this.lbl_Frog2_MaleCounter.Location = new System.Drawing.Point(270, 210);
			this.lbl_Frog2_MaleCounter.Name = "lbl_Frog2_MaleCounter";
			this.lbl_Frog2_MaleCounter.Size = new System.Drawing.Size(80, 15);
			this.lbl_Frog2_MaleCounter.TabIndex = 20;
			this.lbl_Frog2_MaleCounter.Text = "Male: 0";
			// 
			// lbl_Frog2_FemaleCounter
			// 
			this.lbl_Frog2_FemaleCounter.Location = new System.Drawing.Point(270, 230);
			this.lbl_Frog2_FemaleCounter.Name = "lbl_Frog2_FemaleCounter";
			this.lbl_Frog2_FemaleCounter.Size = new System.Drawing.Size(80, 15);
			this.lbl_Frog2_FemaleCounter.TabIndex = 21;
			this.lbl_Frog2_FemaleCounter.Text = "Female: 0";
			// 
			// lbl_frog1_croaked
			// 
			this.lbl_frog1_croaked.Location = new System.Drawing.Point(135, 210);
			this.lbl_frog1_croaked.Name = "lbl_frog1_croaked";
			this.lbl_frog1_croaked.Size = new System.Drawing.Size(80, 15);
			this.lbl_frog1_croaked.TabIndex = 22;
			this.lbl_frog1_croaked.Text = "Croaked: 0";
			// 
			// lbl_frog2_croaked
			// 
			this.lbl_frog2_croaked.Location = new System.Drawing.Point(395, 210);
			this.lbl_frog2_croaked.Name = "lbl_frog2_croaked";
			this.lbl_frog2_croaked.Size = new System.Drawing.Size(80, 15);
			this.lbl_frog2_croaked.TabIndex = 23;
			this.lbl_frog2_croaked.Text = "Croaked: 0";
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
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(524, 442);
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
			this.Controls.Add(this.lbl_frog2_croaked);
			this.Controls.Add(this.lbl_frog1_croaked);
			this.Controls.Add(this.lbl_Frog2_FemaleCounter);
			this.Controls.Add(this.lbl_Frog2_MaleCounter);
			this.Controls.Add(this.lbl_Frog1_FemaleCounter);
			this.Controls.Add(this.lbl_Frog1_MaleCounter);
			this.Controls.Add(this.lst_Frog2_Croaked);
			this.Controls.Add(this.lst_Frog2_Gender);
			this.Controls.Add(this.lst_Frog1_Croaked);
			this.Controls.Add(this.lst_Frog1_Gender);
			this.Controls.Add(this.lbl_frog2);
			this.Controls.Add(this.lbl_frog1);
			this.Name = "MainForm";
			this.Text = "TheFrogRiddle";
			this.ResumeLayout(false);
		}
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
		private System.Windows.Forms.Label lbl_frog2_croaked;
		private System.Windows.Forms.Label lbl_frog1_croaked;
		private System.Windows.Forms.Label lbl_Frog2_FemaleCounter;
		private System.Windows.Forms.Label lbl_Frog2_MaleCounter;
		private System.Windows.Forms.Label lbl_Frog1_FemaleCounter;
		private System.Windows.Forms.Label lbl_Frog1_MaleCounter;
		private System.Windows.Forms.ListBox lst_Frog2_Croaked;
		private System.Windows.Forms.ListBox lst_Frog2_Gender;
		private System.Windows.Forms.ListBox lst_Frog1_Croaked;
		private System.Windows.Forms.ListBox lst_Frog1_Gender;
		private System.Windows.Forms.Label lbl_frog2;
		private System.Windows.Forms.Label lbl_frog1;
	}
}
