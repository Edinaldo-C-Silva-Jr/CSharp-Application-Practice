/*
 * Date: 06/05/2023
 * Time: 01:20
*/
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace ClickableGrid
{
	// Control that is used by the TableLayoutPanel to create each cell
	public partial class RectangleCell : Control
	{
		public RectangleCell()
		{
			InitializeComponent();
		}
	}
}
