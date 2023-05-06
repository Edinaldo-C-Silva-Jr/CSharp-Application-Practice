/*
 * Date: 06/05/2023
 * Time: 00:36
*/
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ClickableGrid
{
	public partial class DBTablePanel : TableLayoutPanel
	{
		public DBTablePanel()
		{
			DoubleBuffered = true;
		}
	}
}
