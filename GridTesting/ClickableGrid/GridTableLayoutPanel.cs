/*
 * Date: 08/05/2023
 * Time: 18:57
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ClickableGrid
{
	// A custom version of a TableLayoutPanel that has the double buffered property, and has custom methods to create and handle a clickable grid with color changing cells
	public partial class GridTableLayoutPanel : TableLayoutPanel
	{
		public GridTableLayoutPanel()
		{
			DoubleBuffered = true; // Enables the double buffered property to increase rendering speed and reduce flickering
		}
		
		// Builds the cell template that will be used in the grid using a RectangleCell custom control
		private RectangleCell BuildCellTemplate(RectangleCell template, int cellWidth, int cellHeight)
		{
			template.Dock = DockStyle.Fill;
			template.BackColor = Color.White;
			template.Margin = new Padding(0,0,0,0);
			template.Size = new Size(cellWidth - 1, cellHeight - 1); // The size has to be 1 pixel smaller than the cell size to account for the 1 pixel margin of each cell
			template.Visible = true;
			
			return template;
		}
		
		// Method that changes the size of the grid to the height and width values received as parameters
		// It has to be set 1 pixel bigger than the grid size to account for the cell margin
		public void ResizeGrid(int gridWidth, int gridHeight)
		{
			this.Size = new Size(1 + gridWidth, 1 + gridHeight);
		}
		
		// Method that generates a grid, based on the parameters received
		// The parameters define the amount of cells on rows/columns and the cell size
		public void GenerateGrid(int gridColumns, int gridRows, int cellWidth, int cellHeight)
		{
			this.RowStyles.Clear(); // Makes sure the grid is empty before generating it
			this.ColumnStyles.Clear();
			
			RectangleCell cellTemplate;
			
			this.ColumnCount = gridColumns;
			this.RowCount = gridRows;
			this.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
			
			this.SuspendLayout(); // Suspends the control layout while the grid is being generated
			
			for (int i = 0; i < gridColumns; i++)
			{
				for (int j = 0; j < gridRows; j++)
				{
					cellTemplate = new RectangleCell();
					cellTemplate = BuildCellTemplate(cellTemplate, cellWidth, cellHeight);
					this.Controls.Add(cellTemplate, i, j); // Adds the RectangleCell template as a new cell on the grid
				}
			}
			
			this.ResumeLayout(); // Resumes the layout and shows the grid
			this.Visible = true;
		}
		
		// Empties the grid by clearing all styles, rows and columns
		public void ClearGrid()
		{
			this.Visible = false;
			this.Controls.Clear();
			this.ColumnStyles.Clear();
			this.ColumnCount = 0;
			this.RowStyles.Clear();
			this.RowCount = 0;
		}
		
		// Method that handles when a grid cell is clicked
		// The method already receives the clicked cell as a parameter
		public void CellClicked(RectangleCell cell)
		{
			if (cell.BackColor == Color.White)
			{
				cell.BackColor = Color.Black; // If the cell is black, make it white
			}
			else
			{
				cell.BackColor = Color.White; // If the cell is not black, make it black
			}
		}
	}
}
