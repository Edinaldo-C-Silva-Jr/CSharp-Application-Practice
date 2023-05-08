/*
 * Date: 29/04/2023
 * Time: 14:55
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ClickableGrid
{
	public partial class MainForm : Form
	{
		private int gridColumns, gridRows;
		private int gridHeight, gridWidth, cellHeight, cellWidth;
		
		SizeCalculation calculate;
		
		#region Form Initialization
		public MainForm()
		{
			InitializeComponent();
		}
		
		private void MainFormLoad(object sender, EventArgs e)
		{
			calculate = new SizeCalculation();
			
			pnl_formGenertor.Location = new Point(0,0);
			dgv_clickableGrid.Location = new Point(10, 30);
			tbl_clickableGrid.Location = new Point(10, 30);
			pbx_clickableGrid.Location = new Point(10, 30);
			
			this.Size = new Size(315, 335);
		}
		#endregion
		
		#region Changing Grid Options
		private void RadioButtonChange(object sender, EventArgs e)
		{
			if (rdb_dataGridView.Checked == true)
			{
				nmb_height.Maximum = 80;
				nmb_width.Maximum = 80;
			}
			
			if (rdb_tableLayoutPanel.Checked == true)
			{
				nmb_height.Maximum = 70;
				nmb_width.Maximum = 70;
			}
			
			if (rdb_pictureBox.Checked == true)
			{
				nmb_height.Maximum = 100;
				nmb_width.Maximum = 100;
			}
		}
		
		private void Btn_backClick(object sender, EventArgs e)
		{
			btn_back.Visible = false;
			
			dgv_clickableGrid.ClearGrid();
			
			tbl_clickableGrid.ClearGrid();
			
			pbx_clickableGrid.ClearGrid();
			
			pnl_formGenertor.Visible = true;
			this.Size = new Size(315, 335);
		}
		#endregion
		
		#region Grid Generation
		private void Btn_generateGridClick(object sender, EventArgs e)
		{
			gridRows = (int)nmb_height.Value;
			gridColumns = (int)nmb_width.Value;
			
			cellHeight = calculate.CellSize(gridRows);
			cellWidth = calculate.CellSize(gridColumns);
			gridHeight = calculate.GridSize(gridRows);
			gridWidth = calculate.GridSize(gridColumns);
			
			pnl_formGenertor.Visible = false;
			btn_back.Visible = true;
			this.Size = new Size(35 + gridWidth, 75 + gridHeight);
			
			if (rdb_dataGridView.Checked == true)
			{
				dgv_clickableGrid.ResizeGrid(gridWidth, gridHeight);
				dgv_clickableGrid.GenerateGrid(gridColumns, gridRows, cellWidth, cellHeight);
			}
			
			if (rdb_tableLayoutPanel.Checked == true)
			{
				tbl_clickableGrid.ResizeGrid(gridWidth, gridHeight);
				tbl_clickableGrid.GenerateGrid(gridColumns, gridRows, cellWidth, cellHeight);
				
				AssignClickEvent();
			}
			
			if (rdb_pictureBox.Checked == true)
			{
				pbx_clickableGrid.ResizeGrid(gridWidth, gridHeight);
				pbx_clickableGrid.GenerateGrid(gridWidth, gridHeight, gridColumns, gridRows, cellWidth, cellHeight);
			}
		}
		
		private void AssignClickEvent()
		{
			foreach (Control cell in tbl_clickableGrid.Controls)
			{
				cell.Click += new EventHandler(tbl_ClickableGridCellClick);
			}
		}
		#endregion
		
		#region Cell Click Events
		private void Dgv_clickableGridCellClick(object sender, DataGridViewCellEventArgs e)
		{
			dgv_clickableGrid.CellClicked();
		}
		
		private void tbl_ClickableGridCellClick(object sender, EventArgs e)
		{
			RectangleCell cell = sender as RectangleCell;
			tbl_clickableGrid.CellClicked(cell);
		}
		
		private void Pbx_clickableGridClick(object sender, EventArgs e)
		{
			MouseEventArgs mouseCursor = (MouseEventArgs)e;
			pbx_clickableGrid.CellClicked(mouseCursor.Location.X, mouseCursor.Location.Y, cellWidth, cellHeight);
		}
		#endregion
	}
}
