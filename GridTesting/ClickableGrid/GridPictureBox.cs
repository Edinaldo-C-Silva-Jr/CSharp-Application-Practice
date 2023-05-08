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
	public partial class GridPictureBox : PictureBox
	{
		public void ResizeGrid(int gridWidth, int gridHeight)
		{
			this.Size = new Size (1 + gridWidth, 1 + gridHeight);
			this.Image = new Bitmap(1 + gridWidth, 1 + gridHeight);
		}
		
		public void GenerateGrid(int gridWidth, int gridHeight, int gridColumns, int gridRows, int cellWidth, int cellHeight)
		{
			Graphics gridImage = Graphics.FromImage(this.Image);
			gridImage.FillRectangle(Brushes.White, 0, 0, gridWidth, gridHeight);
			
			for (int i = 0; i < gridColumns + 1; i++)
			{
				gridImage.DrawLine(Pens.Gray, i * cellWidth, 0, i * cellWidth, this.Height);
			}
			
			for (int i = 0; i < gridRows + 1; i++)
			{
				gridImage.DrawLine(Pens.Gray, 0, i * cellHeight, this.Width, i * cellHeight);
			}
			
			this.Visible = true;
		}
		
		public void ClearGrid()
		{
			this.Visible = false;
		}
		
		public void CellClicked(int x, int y, int cellWidth, int cellHeight)
		{
			Bitmap gridBitmap = new Bitmap(this.Image);
			Color cellColor = gridBitmap.GetPixel(x, y);
			
			Graphics gridImage = Graphics.FromImage(this.Image);
			
			if (cellColor.ToArgb() == Color.White.ToArgb())
			{
				gridImage.FillRectangle(Brushes.Black, (x - (x % cellWidth) + 1), (y - (y % cellHeight) + 1), cellWidth - 1, cellHeight - 1);
			}
			
			if (cellColor.ToArgb() == Color.Black.ToArgb())
			{
				gridImage.FillRectangle(Brushes.White, (x - (x % cellWidth) + 1), (y - (y % cellHeight) + 1), cellWidth - 1, cellHeight - 1);
			}
			
			this.Refresh();
		}
	}
}
