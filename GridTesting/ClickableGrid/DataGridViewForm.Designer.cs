/*
 * Date: 02/05/2023
 * Time: 14:53
*/
namespace ClickableGrid
{
	partial class DataGridViewForm
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
			this.dgv_clickableGrid = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dgv_clickableGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_clickableGrid
			// 
			this.dgv_clickableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_clickableGrid.Location = new System.Drawing.Point(10, 10);
			this.dgv_clickableGrid.Name = "dgv_clickableGrid";
			this.dgv_clickableGrid.Size = new System.Drawing.Size(50, 50);
			this.dgv_clickableGrid.TabIndex = 0;
			// 
			// DataGridViewForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(134, 112);
			this.Controls.Add(this.dgv_clickableGrid);
			this.Name = "DataGridViewForm";
			this.Text = "Grid using DGV";
			this.Load += new System.EventHandler(this.DataGridViewFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.dgv_clickableGrid)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.DataGridView dgv_clickableGrid;
	}
}
