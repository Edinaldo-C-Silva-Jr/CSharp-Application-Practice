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
			this.pnl_formGenertor = new System.Windows.Forms.Panel();
			this.dgv_clickableGrid = new System.Windows.Forms.DataGridView();
			this.btn_back = new System.Windows.Forms.Button();
			this.tbl_clickableGrid = new System.Windows.Forms.TableLayoutPanel();
			this.pbx_clickableGrid = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.nmb_height)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nmb_width)).BeginInit();
			this.pnl_formGenertor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_clickableGrid)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pbx_clickableGrid)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_generateGrid
			// 
			this.btn_generateGrid.Location = new System.Drawing.Point(90, 240);
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
			this.lbl_height.Location = new System.Drawing.Point(10, 10);
			this.lbl_height.Name = "lbl_height";
			this.lbl_height.Size = new System.Drawing.Size(50, 20);
			this.lbl_height.TabIndex = 0;
			this.lbl_height.Text = "Height:";
			// 
			// lbl_width
			// 
			this.lbl_width.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_width.Location = new System.Drawing.Point(10, 40);
			this.lbl_width.Name = "lbl_width";
			this.lbl_width.Size = new System.Drawing.Size(50, 20);
			this.lbl_width.TabIndex = 0;
			this.lbl_width.Text = "Width:";
			// 
			// nmb_height
			// 
			this.nmb_height.Location = new System.Drawing.Point(70, 10);
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
			this.nmb_width.Location = new System.Drawing.Point(70, 40);
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
			this.rdb_dataGridView.Location = new System.Drawing.Point(10, 90);
			this.rdb_dataGridView.Name = "rdb_dataGridView";
			this.rdb_dataGridView.Size = new System.Drawing.Size(120, 25);
			this.rdb_dataGridView.TabIndex = 3;
			this.rdb_dataGridView.TabStop = true;
			this.rdb_dataGridView.Text = "Data Grid View";
			this.rdb_dataGridView.UseVisualStyleBackColor = true;
			// 
			// rdb_tableLayoutPanel
			// 
			this.rdb_tableLayoutPanel.Location = new System.Drawing.Point(160, 90);
			this.rdb_tableLayoutPanel.Name = "rdb_tableLayoutPanel";
			this.rdb_tableLayoutPanel.Size = new System.Drawing.Size(120, 25);
			this.rdb_tableLayoutPanel.TabIndex = 4;
			this.rdb_tableLayoutPanel.TabStop = true;
			this.rdb_tableLayoutPanel.Text = "Table Layout Panel";
			this.rdb_tableLayoutPanel.UseVisualStyleBackColor = true;
			// 
			// rdb_pictureBox
			// 
			this.rdb_pictureBox.Location = new System.Drawing.Point(10, 120);
			this.rdb_pictureBox.Name = "rdb_pictureBox";
			this.rdb_pictureBox.Size = new System.Drawing.Size(120, 25);
			this.rdb_pictureBox.TabIndex = 5;
			this.rdb_pictureBox.TabStop = true;
			this.rdb_pictureBox.Text = "Picture Box";
			this.rdb_pictureBox.UseVisualStyleBackColor = true;
			// 
			// pnl_formGenertor
			// 
			this.pnl_formGenertor.Controls.Add(this.btn_generateGrid);
			this.pnl_formGenertor.Controls.Add(this.nmb_width);
			this.pnl_formGenertor.Controls.Add(this.rdb_pictureBox);
			this.pnl_formGenertor.Controls.Add(this.nmb_height);
			this.pnl_formGenertor.Controls.Add(this.lbl_height);
			this.pnl_formGenertor.Controls.Add(this.rdb_tableLayoutPanel);
			this.pnl_formGenertor.Controls.Add(this.lbl_width);
			this.pnl_formGenertor.Controls.Add(this.rdb_dataGridView);
			this.pnl_formGenertor.Location = new System.Drawing.Point(0, 30);
			this.pnl_formGenertor.Name = "pnl_formGenertor";
			this.pnl_formGenertor.Size = new System.Drawing.Size(300, 300);
			this.pnl_formGenertor.TabIndex = 7;
			// 
			// dgv_clickableGrid
			// 
			this.dgv_clickableGrid.AllowUserToAddRows = false;
			this.dgv_clickableGrid.AllowUserToDeleteRows = false;
			this.dgv_clickableGrid.AllowUserToResizeColumns = false;
			this.dgv_clickableGrid.AllowUserToResizeRows = false;
			this.dgv_clickableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_clickableGrid.ColumnHeadersVisible = false;
			this.dgv_clickableGrid.Location = new System.Drawing.Point(70, 5);
			this.dgv_clickableGrid.MultiSelect = false;
			this.dgv_clickableGrid.Name = "dgv_clickableGrid";
			this.dgv_clickableGrid.RowHeadersVisible = false;
			this.dgv_clickableGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dgv_clickableGrid.Size = new System.Drawing.Size(20, 20);
			this.dgv_clickableGrid.TabIndex = 0;
			this.dgv_clickableGrid.TabStop = false;
			this.dgv_clickableGrid.Visible = false;
			this.dgv_clickableGrid.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_clickableGridCellContentClick);
			// 
			// btn_back
			// 
			this.btn_back.Location = new System.Drawing.Point(10, 5);
			this.btn_back.Name = "btn_back";
			this.btn_back.Size = new System.Drawing.Size(50, 20);
			this.btn_back.TabIndex = 7;
			this.btn_back.Text = "Back";
			this.btn_back.UseVisualStyleBackColor = true;
			this.btn_back.Visible = false;
			this.btn_back.Click += new System.EventHandler(this.Btn_backClick);
			// 
			// tbl_clickableGrid
			// 
			this.tbl_clickableGrid.ColumnCount = 1;
			this.tbl_clickableGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tbl_clickableGrid.Location = new System.Drawing.Point(100, 5);
			this.tbl_clickableGrid.Name = "tbl_clickableGrid";
			this.tbl_clickableGrid.RowCount = 1;
			this.tbl_clickableGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tbl_clickableGrid.Size = new System.Drawing.Size(20, 20);
			this.tbl_clickableGrid.TabIndex = 0;
			// 
			// pbx_clickableGrid
			// 
			this.pbx_clickableGrid.Location = new System.Drawing.Point(130, 5);
			this.pbx_clickableGrid.Name = "pbx_clickableGrid";
			this.pbx_clickableGrid.Size = new System.Drawing.Size(20, 20);
			this.pbx_clickableGrid.TabIndex = 9;
			this.pbx_clickableGrid.TabStop = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(299, 327);
			this.Controls.Add(this.pbx_clickableGrid);
			this.Controls.Add(this.tbl_clickableGrid);
			this.Controls.Add(this.btn_back);
			this.Controls.Add(this.dgv_clickableGrid);
			this.Controls.Add(this.pnl_formGenertor);
			this.Name = "MainForm";
			this.Text = "ClickableGrid";
			this.Load += new System.EventHandler(this.MainFormLoad);
			((System.ComponentModel.ISupportInitialize)(this.nmb_height)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nmb_width)).EndInit();
			this.pnl_formGenertor.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_clickableGrid)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pbx_clickableGrid)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.PictureBox pbx_clickableGrid;
		private System.Windows.Forms.TableLayoutPanel tbl_clickableGrid;
		private System.Windows.Forms.Button btn_back;
		private System.Windows.Forms.DataGridView dgv_clickableGrid;
		private System.Windows.Forms.Panel pnl_formGenertor;
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
