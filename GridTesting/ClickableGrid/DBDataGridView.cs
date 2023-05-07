/*
 * Date: 07/05/2023
 * Time: 01:11
*/
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ClickableGrid
{
	public partial class DBDataGridView : DataGridView
	{
		public DBDataGridView()
		{
			DoubleBuffered = true;
		}
	}
}
