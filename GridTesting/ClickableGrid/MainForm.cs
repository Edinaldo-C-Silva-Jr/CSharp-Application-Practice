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
		public MainForm()
		{
			InitializeComponent();
		}
		
		void MainFormLoad(object sender, EventArgs e)
		{
			rdb_dataGridView.Checked = true;
		}
		
		void Btn_generateGridClick(object sender, EventArgs e)
		{
			Form gridForm = null;
			int height, width;
			
			height = (int)nmb_height.Value;
			width = (int)nmb_width.Value;
			
			if (rdb_dataGridView.Checked == true)
			{
				gridForm = new DataGridViewForm(height, width);
				
			}
			
			gridForm.Show();
		}
	}
}
