/*
 * Date: 08/05/2023
 * Time: 19:33
 */
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ClickableGrid
{
	// A custom version of a PictureBox that has custom methods to create and handle a clickable grid with color changing cells
	public partial class GridPictureBox : PictureBox
	{
		// Method that changes the size of the control and the image to the height and width values received as parameters
		// It has to be set 1 pixel bigger than the grid size to account for the cell margin
		public void ResizeGrid(int gridWidth, int gridHeight)
		{
			this.Size = new Size (1 + gridWidth, 1 + gridHeight);
			this.Image = new Bitmap(1 + gridWidth, 1 + gridHeight);
		}
		
		// Method that generates a grid, based on the parameters received
		// The parameters define the amount of cells on rows/columns and the cell size
		// This method also receives the grid size values to fill the entire grid image generating a grid
		public void GenerateGrid(int gridWidth, int gridHeight, int gridColumns, int gridRows, int cellWidth, int cellHeight)
		{
			Graphics gridImage = Graphics.FromImage(this.Image);
			gridImage.FillRectangle(Brushes.White, 0, 0, gridWidth, gridHeight); // Fills the grid image with a blank rectangle to make sure it is empty before generating the grid
			
			for (int i = 0; i < gridColumns + 1; i++)
			{
				gridImage.DrawLine(Pens.Gray, i * cellWidth, 0, i * cellWidth, this.Height); // Draws vertical lines along the image to create the grid columns
			}
			
			for (int i = 0; i < gridRows + 1; i++)
			{
				gridImage.DrawLine(Pens.Gray, 0, i * cellHeight, this.Width, i * cellHeight); // Draws horizontal lines along the image to create the grid rows
			}
			
			this.Visible = true;
		}
		
		// To clear the grid, it onyl needs to be set invisible, since the image is cleared when a new grid is generated 
		public void ClearGrid()
		{
			this.Visible = false;
		}
		
		// Method that handles when a cell is clicked
		// It receives the mouse cursor position and cell size as parameters to find out which cell was clicked
		public void CellClicked(int x, int y, int cellWidth, int cellHeight)
		{
			Bitmap gridBitmap = new Bitmap(this.Image);
			Color cellColor = gridBitmap.GetPixel(x, y); // Gets the color of the exact pixel the mouse clicked on
			
			Graphics gridImage = Graphics.FromImage(this.Image);
			
			if (cellColor.ToArgb() == Color.White.ToArgb()) // If the clicked color is white
			{
				gridImage.FillRectangle(Brushes.Black, (x - (x % cellWidth) + 1), (y - (y % cellHeight) + 1), cellWidth - 1, cellHeight - 1); // Draw a black rectangle in the cell ot change its color
			}
			
			if (cellColor.ToArgb() == Color.Black.ToArgb()) // If clicked color is black
			{
				gridImage.FillRectangle(Brushes.White, (x - (x % cellWidth) + 1), (y - (y % cellHeight) + 1), cellWidth - 1, cellHeight - 1); // Draw a while rectangle in the cell to change its color
			}
			
			this.Refresh();
		}
	}
}
