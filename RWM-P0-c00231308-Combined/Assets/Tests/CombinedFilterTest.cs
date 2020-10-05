using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 1, 3, 5, 7, 9 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 1, 0, 2, 1, 0 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
