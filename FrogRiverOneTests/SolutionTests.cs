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
		public void Test1()
		{
			int result = _solution.solution(5, new int[] { 1, 3, 1, 4, 2, 3, 5, 4 });
			Assert.AreEqual(6, result);
		}
	}
}