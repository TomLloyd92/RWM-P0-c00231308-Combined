using NUnit.Framework;
using UnityEngine;

namespace Tests
{
    public class CombinedFilterTest
    {
        [Test]
        public void CombinedFilterSimple()
        {
            int[] input = { 4, 2 };
            int[] output = CombinedFilter.combinedFilter(input);
            int[] expected = { 21, 23 };

            CollectionAssert.AreEqual(expected, output);
        }
    }
}
