/*
 * Date: 02/05/2023
 * Time: 14:53
*/
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ClickableGrid
{
	public partial class DataGridViewForm : Form
	{
		private int gridHeight, gridWidth;
		
		public DataGridViewForm(int height, int width)
		{
			InitializeComponent();
			gridHeight = height;
			gridWidth = width;
		}
		
		void DataGridViewFormLoad(object sender, EventArgs e)
		{
			this.Size = new Size((500, 500);
			dgv_clickableGrid.Size = new Size(400, 400);
		}
	}
}
