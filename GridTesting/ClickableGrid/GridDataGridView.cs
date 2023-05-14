/*
 * Date: 08/05/2023
 * Time: 17:23
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ClickableGrid
{
	// A custom version of a DataGridView that has the double buffered property, and has custom methods to create and handle a clickable grid with color changing cells
	public partial class GridDataGridView : DataGridView
	{
		public GridDataGridView()
		{
			DoubleBuffered = true; // Uses double buffering to increase the rendering speed of the DataGridView
		}
		
		// Method that changes the size of the grid to the height and width values received as parameters
		// It has to be set to 3 pixels bigger than the grid size to prevent the scroll bars from appearing
		public void ResizeGrid(int gridWidth, int gridHeight)
		{
			this.Size = new Size(3 + gridWidth, 3 + gridHeight);
		}
		
		// Method that generates a grid, based on the parameters received
		// The parameters define the amount of cells on rows/columns and the cell size
		public void GenerateGrid (int gridColumns, int gridRows, int cellWidth, int cellHeight)
		{
			for (int i = 0; i < gridColumns; i++)
			{
				this.Columns.Add(new DataGridViewColumn(new DataGridViewButtonCell())); // Creates each column using a template for a button cell
				this.Columns[i].Width = cellWidth;
			}
			
			this.RowTemplate.Height = cellHeight;
			this.Rows.Add(gridRows);
			
			this.Visible = true;
		}
		
		// Empties the grid by clearing all rows and columns 
		public void ClearGrid()
		{
			this.Visible = false;
			this.Columns.Clear();
			this.Rows.Clear();
		}
		
		// Method that handles when a grid cell is clicked
		public void CellClicked()
		{
			int column, row; // Stores the index of the currently selected cell
			column = this.CurrentCell.ColumnIndex;
			row = this.CurrentCell.RowIndex;
			
			if (this[column, row].Style.BackColor == Color.Black)
			{
				this[column, row].Style.BackColor = Color.White; // If the cell is black, make it white
			}
			else
			{
				this[column, row].Style.BackColor = Color.Black; // If the cell is not black, make it black
			}
			this.CurrentCell.Selected = false; // Deselectes the cell (to show the cell's current color)
		}
	}
}
