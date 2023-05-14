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
		
		// Sets all controls to their correct position, and sets the form size to the correct initial size
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
		// Changes the maximum allowed grid size based on the type of grid
		// Sizes set arbitrarily based on a few concerns (such as making sure the grid fits on screen, and making sure it can't crash teh program)
		private void RadioButtonChange(object sender, EventArgs e)
		{
			if (rdb_dataGridView.Checked == true) // If the grid is a DataGridView, maximum size is 80x80
			{
				nmb_height.Maximum = 80;
				nmb_width.Maximum = 80;
			}
			
			if (rdb_tableLayoutPanel.Checked == true) // If the grid is a TableLayoutPanel, maximum size is 70x70
			{
				nmb_height.Maximum = 70;
				nmb_width.Maximum = 70;
			}
			
			if (rdb_pictureBox.Checked == true) // If the grid is a PictureBox, maximum size is 100x100
			{
				nmb_height.Maximum = 100;
				nmb_width.Maximum = 100;
			}
		}
		
		// Clears all grids and shows the grid generation panel again. Also changes the form size back to default
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
		// Handles the grid generation process
		private void Btn_generateGridClick(object sender, EventArgs e)
		{
			gridRows = (int)nmb_height.Value; // Gets the currently defined height and width of the grid
			gridColumns = (int)nmb_width.Value;
			
			cellHeight = calculate.CellSize(gridRows); // Calculates the cell size. Calculates the height and width separately
			cellWidth = calculate.CellSize(gridColumns);
			gridHeight = calculate.GridSize(gridRows); // Calculates the grid size. Calculates the height and width separately
			gridWidth = calculate.GridSize(gridColumns);
			
			pnl_formGenertor.Visible = false;
			btn_back.Visible = true;
			this.Size = new Size(35 + gridWidth, 75 + gridHeight);
			
			if (rdb_dataGridView.Checked == true) // Generates a DataGridView grid
			{
				dgv_clickableGrid.ResizeGrid(gridWidth, gridHeight);
				dgv_clickableGrid.GenerateGrid(gridColumns, gridRows, cellWidth, cellHeight);
			}
			
			if (rdb_tableLayoutPanel.Checked == true) // Generates a TableLayoutPanel grid
			{
				tbl_clickableGrid.ResizeGrid(gridWidth, gridHeight);
				tbl_clickableGrid.GenerateGrid(gridColumns, gridRows, cellWidth, cellHeight);
				
				AssignClickEvent(); // Manually assigns the click even to the grid cells
			}
			
			if (rdb_pictureBox.Checked == true) // Generates a PictureBox grid
			{
				pbx_clickableGrid.ResizeGrid(gridWidth, gridHeight);
				pbx_clickableGrid.GenerateGrid(gridWidth, gridHeight, gridColumns, gridRows, cellWidth, cellHeight);
			}
		}
		
		// Assisgns the click event for each RectangleCell control in the TableLayoutPanel grid
		private void AssignClickEvent()
		{
			foreach (Control cell in tbl_clickableGrid.Controls)
			{
				cell.Click += new EventHandler(tbl_ClickableGridCellClick);
			}
		}
		#endregion
		
		#region Cell Click Events
		// Handles the click event on a DataGridView grid cell
		private void Dgv_clickableGridCellClick(object sender, DataGridViewCellEventArgs e)
		{
			dgv_clickableGrid.CellClicked();
		}
		
		// Handles the click event on a TableLayoutPanel grid cell
		private void tbl_ClickableGridCellClick(object sender, EventArgs e)
		{
			RectangleCell cell = sender as RectangleCell; // Gets the control that triggered the event to pass it as a parameter to the custom TableLayoutPanel method
			tbl_clickableGrid.CellClicked(cell);
		}
		
		// Handles the click event on a PictureBox grid cell
		private void Pbx_clickableGridClick(object sender, EventArgs e)
		{
			MouseEventArgs mouseCursor = (MouseEventArgs)e; // Gets the mouse event args to pass the cursor location as a parameter to the custom Picturebox method
			pbx_clickableGrid.CellClicked(mouseCursor.Location.X, mouseCursor.Location.Y, cellWidth, cellHeight);
		}
		#endregion
	}
}
