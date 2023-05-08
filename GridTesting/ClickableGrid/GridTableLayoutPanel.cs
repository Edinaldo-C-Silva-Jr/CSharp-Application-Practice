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
	public partial class GridTableLayoutPanel : TableLayoutPanel
	{
		public GridTableLayoutPanel()
		{
			DoubleBuffered = true;
		}
		
		private RectangleCell BuildCellTemplate(RectangleCell template, int cellWidth, int cellHeight)
		{
			template.Dock = DockStyle.Fill;
			template.BackColor = Color.White;
			template.Margin = new Padding(0,0,0,0);
			template.Size = new Size(cellWidth - 1, cellHeight - 1);
			template.Visible = true;
			
			return template;
		}
		
		public void ResizeGrid(int gridWidth, int gridHeight)
		{
			this.Size = new Size(1 + gridWidth, 1 + gridHeight);
		}
		
		public void GenerateGrid(int gridColumns, int gridRows, int cellWidth, int cellHeight)
		{
			this.RowStyles.Clear();
			this.ColumnStyles.Clear();
			
			RectangleCell cellTemplate;
			
			this.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, cellWidth - 1));
			this.RowStyles.Add(new RowStyle(SizeType.Absolute, cellHeight - 1));
			this.ColumnCount = gridColumns;
			this.RowCount = gridRows;
			this.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
			
			this.SuspendLayout();
			
			for (int i = 0; i < gridColumns; i++)
			{
				for (int j = 0; j < gridRows; j++)
				{
					cellTemplate = new RectangleCell();
					cellTemplate = BuildCellTemplate(cellTemplate, cellWidth, cellHeight);
					this.Controls.Add(cellTemplate, i, j);
				}
			}
			
			this.ResumeLayout();
			this.Visible = true;
		}
		
		public void ClearGrid()
		{
			this.Visible = false;
			this.Controls.Clear();
			this.ColumnStyles.Clear();
			this.ColumnCount = 0;
			this.RowStyles.Clear();
			this.RowCount = 0;
		}
		
		public void CellClicked(RectangleCell cell)
		{
			if (cell.BackColor == Color.White)
			{
				cell.BackColor = Color.Black;
			}
			else
			{
				cell.BackColor = Color.White;
			}
		}
	}
}
