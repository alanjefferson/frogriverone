using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrogRiverOne
{
	public class Solution
	{
		public int solution(int X, int[] A)
		{
            int occupiedPositions = 0;
            bool[] leavesInPosition = new bool[X + 1];

            for (int i = 0; i < A.Length; i++)
            {
                int position = A[i];
                if (position <= X && !leavesInPosition[position]) {
                    leavesInPosition[position] = true;
                    occupiedPositions++;
                }

                if (occupiedPositions == X)
                    return i;
            }

            return -1;
        }
	}
}
