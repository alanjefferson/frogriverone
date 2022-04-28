using FrogRiverOne;
using NUnit.Framework;

namespace FrogRiverOneTests
{
	public class SolutionTests
	{
		private Solution _solution { get; set; } = null!;

		[SetUp]
		public void Setup()
		{
			_solution = new Solution();
		}

		[Test]
		public void FrogRiverOne_Test1()
		{
			int result = _solution.solution(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 });
			Assert.AreEqual(6, result);
		}

		[Test]
		public void FrogRiverOne_Test2()
		{
			int result = _solution.solution(5, new int[] { 1, 3, 1, 4, 1, 3, 5, 4 });
			Assert.AreEqual(-1, result);
		}

		[Test]
		public void FrogRiverOne_Test3()
		{
			int result = _solution.solution(6, new int[] { 1, 3, 1, 4, 2, 3, 5, 4, 6 });
			Assert.AreEqual(8, result);
		}
	}
}