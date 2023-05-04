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
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private int gridColumns, gridRows;
		
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
			
			pnl_formGenertor.Visible = true;
			this.Size = new Size(315, 335);
		}
		
		private int GridSize(int numberOfCells)
		{
			return (24 / (1 + (numberOfCells / 34))) * numberOfCells;
		}
		
		private int CellSize(int numberOfCells)
		{
			return 24 / (1 + (numberOfCells / 34));
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			rdb_dataGridView.Checked = true;
			pnl_formGenertor.Location = new Point(0,0);
			ResetForm();
		}
		
		void Btn_generateGridClick(object sender, EventArgs e)
		{	
			gridColumns = (int)nmb_height.Value;
			gridRows = (int)nmb_width.Value;
			
			if (rdb_dataGridView.Checked == true)
			{
				pnl_formGenertor.Visible = false;
				
				dgv_clickableGrid.Location = new Point(10, 30);
				dgv_clickableGrid.Size = new Size(3 + GridSize(gridColumns), 3 + GridSize(gridRows));
				this.Size = new Size(35 + GridSize(gridColumns), 75 + GridSize(gridRows));
				
				btn_back.Visible = true;
				dgv_clickableGrid.Visible = true;
				
				for (int i = 0; i < gridColumns; i++) 
				{
					dgv_clickableGrid.Columns.Add(new DataGridViewColumn(new DataGridViewButtonCell()));
					dgv_clickableGrid.Columns[i].Width = CellSize(gridColumns);
				}
				
				dgv_clickableGrid.RowTemplate.Height = CellSize(gridRows);
				dgv_clickableGrid.Rows.Add(gridRows);
			}
		}
		
		void Btn_backClick(object sender, EventArgs e)
		{
			ResetForm();
		}
	}
}
