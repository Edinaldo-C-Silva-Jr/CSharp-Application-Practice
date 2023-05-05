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
		
		public MainForm()
		{
			InitializeComponent();
		}
		
		private void ResetForm()
		{
			btn_back.Visible = false;
			
			dgv_clickableGrid.Visible = false;
			dgv_clickableGrid.Columns.Clear();
			dgv_clickableGrid.Rows.Clear();
			
			tbl_clickableGrid.Visible = false;
			tbl_clickableGrid.ColumnStyles.Clear();
			tbl_clickableGrid.ColumnCount = 0;
			tbl_clickableGrid.RowStyles.Clear();
			tbl_clickableGrid.RowCount = 0;
			
			pbx_clickableGrid.Visible = false;
			
			pnl_formGenertor.Visible = true;
			this.Size = new Size(315, 335);
		}
		
		private int CalculateGridSize(int numberOfCells)
		{
			int size;
			
			if (numberOfCells < 9)
			{
				size = numberOfCells * 50;
			}
			else
			{
				if (numberOfCells < 21)
				{
					size = numberOfCells * (400 / numberOfCells);
				}
				else
				{
					if (numberOfCells < 36)
					{
						size = numberOfCells * (500 / numberOfCells);
					}
					else
					{
						if (numberOfCells < 51)
						{
							size = numberOfCells * (600 / numberOfCells);
						}
						else
						{
							if (numberOfCells < 66)
							{
								size = numberOfCells * (700 / numberOfCells);
							}
							else
							{
								size = numberOfCells * (800 / numberOfCells);
							}
						}
					}
				}
			}
			
			return size;
		}
		
		private int CalculateCellSize(int numberOfCells)
		{
			int size;
			
			if (numberOfCells < 9)
			{
				size = 50;
			}
			else
			{
				if (numberOfCells < 21)
				{
					size = 400 / numberOfCells;
				}
				else
				{
					if (numberOfCells < 36)
					{
						size = 500 / numberOfCells;
					}
					else
					{
						if (numberOfCells < 51)
						{
							size = 600 / numberOfCells;
						}
						else
						{
							if (numberOfCells < 66)
							{
								size = 700 / numberOfCells;
							}
							else
							{
								size = 800 / numberOfCells;
							}
						}
					}
				}
			}
			
			return size;
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			rdb_dataGridView.Checked = true;
			pnl_formGenertor.Location = new Point(0,0);
			
			dgv_clickableGrid.Location = new Point(10, 30);
			tbl_clickableGrid.Location = new Point(10, 30);
			pbx_clickableGrid.Location = new Point(10, 30);
			
			ResetForm();
		}
		
		private void Btn_generateGridClick(object sender, EventArgs e)
		{
			gridColumns = (int)nmb_height.Value;
			gridRows = (int)nmb_width.Value;
			
			cellHeight = CalculateCellSize(gridRows);
			cellWidth = CalculateCellSize(gridColumns);
			gridHeight = CalculateGridSize(gridRows);
			gridWidth = CalculateGridSize(gridColumns);
			
			pnl_formGenertor.Visible = false;
			btn_back.Visible = true;
			
			if (rdb_dataGridView.Checked == true)
			{
				dgv_clickableGrid.Size = new Size(3 + gridWidth, 3 + gridHeight);
				this.Size = new Size(35 + gridWidth, 75 + gridHeight);
				
				dgv_clickableGrid.Visible = true;
				
				for (int i = 0; i < gridColumns; i++)
				{
					dgv_clickableGrid.Columns.Add(new DataGridViewColumn(new DataGridViewButtonCell()));
					dgv_clickableGrid.Columns[i].Width = cellWidth;
				}
				
				dgv_clickableGrid.RowTemplate.Height = cellHeight;
				dgv_clickableGrid.Rows.Add(gridRows);
			}
			
			if (rdb_tableLayoutPanel.Checked == true)
			{
				tbl_clickableGrid.Size = new Size(5 + gridWidth, 5 + gridHeight);
				this.Size = new Size(35 + gridWidth, 75 + gridHeight);
				
				tbl_clickableGrid.Visible = true;
				
				
				tbl_clickableGrid.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, cellWidth));
				tbl_clickableGrid.RowStyles.Add(new RowStyle(SizeType.Absolute, cellHeight));
				tbl_clickableGrid.ColumnCount = gridColumns;
				tbl_clickableGrid.RowCount = gridRows;
				tbl_clickableGrid.CellBorderStyle = TableLayoutPanelCellBorderStyle.Single;
				
				Panel panelTemplate;
				
				for (int i = 0; i < gridColumns; i++)
				{
					for (int j = 0; j < gridRows; j++)
					{
						panelTemplate = new Panel();
						panelTemplate.Dock = DockStyle.Fill;
						panelTemplate.BackColor = Color.White;
						panelTemplate.Margin = new Padding(0,0,0,0);
						panelTemplate.Size = new Size(50, 50);
						panelTemplate.Visible = true;
						
						tbl_clickableGrid.Controls.Add(panelTemplate, i, j);
					}
				}
			}
			
			if (rdb_pictureBox.Checked == false)
			{
				
			}
		}
		
		void Btn_backClick(object sender, EventArgs e)
		{
			ResetForm();
		}
		
		void Dgv_clickableGridCellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			int column, row;
			column = dgv_clickableGrid.CurrentCell.ColumnIndex;
			row = dgv_clickableGrid.CurrentCell.RowIndex;
			
			if (dgv_clickableGrid[column, row].Style.BackColor == Color.Black)
			{
				dgv_clickableGrid[column, row].Style.BackColor = Color.White;
			}
			else
			{
				dgv_clickableGrid[column, row].Style.BackColor = Color.Black;
			}
			dgv_clickableGrid.CurrentCell.Selected = false;
		}
	}
}
