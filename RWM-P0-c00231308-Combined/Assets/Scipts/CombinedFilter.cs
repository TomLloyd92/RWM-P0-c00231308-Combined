using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class CombinedFilter
{
    public static int[] combinedFilter(int[] xs)
    {
        return XOR21.XORcalculation(ModuloFirstFilter.results(xs));
    }
}
