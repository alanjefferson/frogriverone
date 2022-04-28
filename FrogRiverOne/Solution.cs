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
			int position = 0;
			int index = 0;

			for(int i=0; i < A.Length; i++)
				if (A[i] == X) {
					index = i;
					position = A[i];
					break;
				}

			int[] B = new int[index+1];
			for (int i = 0; i <= index; i++)
				B[i] = A[i];

			for (int j=position; j > 0; j--)
				if (!B.Contains(j)) {
					index = -1;
					break;
				}

			return index;
		}
	}
}
