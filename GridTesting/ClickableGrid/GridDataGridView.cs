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
	public partial class GridDataGridView : DataGridView
	{
		public GridDataGridView()
		{
			DoubleBuffered = true;
		}
		
		public void ResizeGrid(int gridWidth, int gridHeight)
		{
			this.Size = new Size(3 + gridWidth, 3 + gridHeight);
		}
		
		public void GenerateGrid (int gridColumns, int gridRows, int cellWidth, int cellHeight)
		{
			for (int i = 0; i < gridColumns; i++)
			{
				this.Columns.Add(new DataGridViewColumn(new DataGridViewButtonCell()));
				this.Columns[i].Width = cellWidth;
			}
			
			this.RowTemplate.Height = cellHeight;
			this.Rows.Add(gridRows);
			
			this.Visible = true;
		}
		
		public void ClearGrid()
		{
			this.Visible = false;
			this.Columns.Clear();
			this.Rows.Clear();
		}
		
		public void CellClicked()
		{
			int column, row;
			column = this.CurrentCell.ColumnIndex;
			row = this.CurrentCell.RowIndex;
			
			if (this[column, row].Style.BackColor == Color.Black)
			{
				this[column, row].Style.BackColor = Color.White;
			}
			else
			{
				this[column, row].Style.BackColor = Color.Black;
			}
			this.CurrentCell.Selected = false;
		}
	}
}
