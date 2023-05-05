/*
 * Date: 29/04/2023
 * Time: 14:55
*/
using System;
using System.Windows.Forms;

namespace ClickableGrid
{
	internal sealed class Program
	{
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
	}
}
