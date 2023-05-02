/*
 * Date: 29/04/2023
 * Time: 14:55
*/
namespace ClickableGrid
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
			this.btn_generateGrid = new System.Windows.Forms.Button();
			this.lbl_height = new System.Windows.Forms.Label();
			this.lbl_width = new System.Windows.Forms.Label();
			this.nmb_height = new System.Windows.Forms.NumericUpDown();
			this.nmb_width = new System.Windows.Forms.NumericUpDown();
			this.rdb_dataGridView = new System.Windows.Forms.RadioButton();
			this.rdb_tableLayoutPanel = new System.Windows.Forms.RadioButton();
			this.rdb_pictureBox = new System.Windows.Forms.RadioButton();
			((System.ComponentModel.ISupportInitialize)(this.nmb_height)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmb_width)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_generateGrid
			// 
			this.btn_generateGrid.Location = new System.Drawing.Point(80, 210);
			this.btn_generateGrid.Name = "btn_generateGrid";
			this.btn_generateGrid.Size = new System.Drawing.Size(120, 40);
			this.btn_generateGrid.TabIndex = 6;
			this.btn_generateGrid.Text = "Generate Grid";
			this.btn_generateGrid.UseVisualStyleBackColor = true;
			this.btn_generateGrid.Click += new System.EventHandler(this.Btn_generateGridClick);
			// 
			// lbl_height
			// 
			this.lbl_height.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_height.Location = new System.Drawing.Point(15, 20);
			this.lbl_height.Name = "lbl_height";
			this.lbl_height.Size = new System.Drawing.Size(50, 20);
			this.lbl_height.TabIndex = 0;
			this.lbl_height.Text = "Height:";
			// 
			// lbl_width
			// 
			this.lbl_width.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_width.Location = new System.Drawing.Point(15, 50);
			this.lbl_width.Name = "lbl_width";
			this.lbl_width.Size = new System.Drawing.Size(50, 20);
			this.lbl_width.TabIndex = 0;
			this.lbl_width.Text = "Width:";
			// 
			// nmb_height
			// 
			this.nmb_height.Location = new System.Drawing.Point(70, 20);
			this.nmb_height.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.nmb_height.Name = "nmb_height";
			this.nmb_height.Size = new System.Drawing.Size(80, 20);
			this.nmb_height.TabIndex = 1;
			this.nmb_height.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// nmb_width
			// 
			this.nmb_width.Location = new System.Drawing.Point(70, 50);
			this.nmb_width.Minimum = new decimal(new int[] {
									1,
									0,
									0,
									0});
			this.nmb_width.Name = "nmb_width";
			this.nmb_width.Size = new System.Drawing.Size(80, 20);
			this.nmb_width.TabIndex = 2;
			this.nmb_width.Value = new decimal(new int[] {
									1,
									0,
									0,
									0});
			// 
			// rdb_dataGridView
			// 
			this.rdb_dataGridView.Location = new System.Drawing.Point(10, 100);
			this.rdb_dataGridView.Name = "rdb_dataGridView";
			this.rdb_dataGridView.Size = new System.Drawing.Size(120, 25);
			this.rdb_dataGridView.TabIndex = 3;
			this.rdb_dataGridView.TabStop = true;
			this.rdb_dataGridView.Text = "Data Grid View";
			this.rdb_dataGridView.UseVisualStyleBackColor = true;
			// 
			// rdb_tableLayoutPanel
			// 
			this.rdb_tableLayoutPanel.Location = new System.Drawing.Point(150, 100);
			this.rdb_tableLayoutPanel.Name = "rdb_tableLayoutPanel";
			this.rdb_tableLayoutPanel.Size = new System.Drawing.Size(120, 25);
			this.rdb_tableLayoutPanel.TabIndex = 4;
			this.rdb_tableLayoutPanel.TabStop = true;
			this.rdb_tableLayoutPanel.Text = "table Layout Panel";
			this.rdb_tableLayoutPanel.UseVisualStyleBackColor = true;
			// 
			// rdb_pictureBox
			// 
			this.rdb_pictureBox.Location = new System.Drawing.Point(10, 130);
			this.rdb_pictureBox.Name = "rdb_pictureBox";
			this.rdb_pictureBox.Size = new System.Drawing.Size(120, 25);
			this.rdb_pictureBox.TabIndex = 5;
			this.rdb_pictureBox.TabStop = true;
			this.rdb_pictureBox.Text = "Picture Box";
			this.rdb_pictureBox.UseVisualStyleBackColor = true;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(284, 262);
			this.Controls.Add(this.rdb_pictureBox);
			this.Controls.Add(this.rdb_tableLayoutPanel);
			this.Controls.Add(this.rdb_dataGridView);
			this.Controls.Add(this.nmb_width);
			this.Controls.Add(this.nmb_height);
			this.Controls.Add(this.lbl_width);
			this.Controls.Add(this.lbl_height);
			this.Controls.Add(this.btn_generateGrid);
			this.Name = "MainForm";
			this.Text = "ClickableGrid";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.nmb_height)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmb_width)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.RadioButton rdb_pictureBox;
		private System.Windows.Forms.RadioButton rdb_tableLayoutPanel;
		private System.Windows.Forms.RadioButton rdb_dataGridView;
		private System.Windows.Forms.NumericUpDown nmb_width;
		private System.Windows.Forms.NumericUpDown nmb_height;
		private System.Windows.Forms.Label lbl_width;
		private System.Windows.Forms.Label lbl_height;
		private System.Windows.Forms.Button btn_generateGrid;
	}
}
