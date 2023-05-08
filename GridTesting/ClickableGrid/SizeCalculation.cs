/*
 * Date: 08/05/2023
 * Time: 17:10
*/
using System;

namespace ClickableGrid
{
	public class SizeCalculation
	{
		public int GridSize(int numberOfCells)
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
		
		public int CellSize(int numberOfCells)
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
	}
}
