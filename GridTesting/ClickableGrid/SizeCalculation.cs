/*
 * Date: 08/05/2023
 * Time: 17:10
*/
using System;

namespace ClickableGrid
{
	// Class that is responsible for calculating the size of the grid and cells
	public class SizeCalculation
	{
		// Calculates the total size of the grid, which depends on the amount of cells in the row or column
		public int GridSize(int numberOfCells)
		{
			int size;
			
			if (numberOfCells < 9) // If the row/column has 1-8 cells, grid size increases linearly at 50 pixels per cell, up to 400 pixels for 8 cells
			{
				size = numberOfCells * 50;
			}
			else
			{
				if (numberOfCells < 21) // If the row/column has 9-20 cells, grid size is the highest multiple of the cell amount that's lower than 400
				{
					size = numberOfCells * (400 / numberOfCells);
				}
				else
				{
					if (numberOfCells < 36) // If the row/column has 21-35 cells, grid size is the highest multiple of the cell amount that's lower than 500
					{
						size = numberOfCells * (500 / numberOfCells);
					}
					else
					{
						if (numberOfCells < 51) // If the row/column has 36-50 cells, grid size is the highest multiple of the cell amount that's lower than 600
						{
							size = numberOfCells * (600 / numberOfCells);
						}
						else
						{
							if (numberOfCells < 66) // If the row/column has 51-65 cells, grid size is the highest multiple of the cell amount that's lower than 700
							{
								size = numberOfCells * (700 / numberOfCells);
							}
							else // If the row/column has 66-100 cells, grid size is the highest multiple of the cell amount that's lower than 800
							{
								size = numberOfCells * (800 / numberOfCells);
							}
						}
					}
				}
			}
			
			return size;
		}
		
		// Calculates the size of each grid cell, which depends on the amount of cells in the row or column
		public int CellSize(int numberOfCells)
		{
			int size;
			
			if (numberOfCells < 9) // If the row/column has 1-8 cells, cell size is fixed at 50 pixels
			{
				size = 50;
			}
			else
			{
				if (numberOfCells < 21) // If the row/column has 9-20 cells, cell size is 400 divided by the number of cells
				{
					size = 400 / numberOfCells;
				}
				else
				{
					if (numberOfCells < 36) // If the row/column has 21-35 cells, cell size is 500 divided by the number of cells
					{
						size = 500 / numberOfCells;
					}
					else
					{
						if (numberOfCells < 51) // If the row/column has 36-50 cells, cell size is 600 divided by the number of cells
						{
							size = 600 / numberOfCells;
						}
						else
						{
							if (numberOfCells < 66) // If the row/column has 51-65 cells, cell size is 700 divided by the number of cells
							{
								size = 700 / numberOfCells;
							}
							else // If the row/column has 66-100 cells, cell size is 800 divided by the number of cells
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
