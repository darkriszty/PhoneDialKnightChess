using System;
using System.Collections.Generic;

namespace PhoneDialKnightChess
{
    internal class PhoneDialKnightChessSolver
    {
        private static readonly IDictionary<int, int[]> _nextHopMap = new Dictionary<int, int[]>
                                                                             {
                                                                                 [1] = new [] {6, 8},
                                                                                 [2] = new [] {7, 9},
                                                                                 [3] = new [] {4, 8},
                                                                                 [4] = new [] {3, 9, 0},
                                                                                 [5] = Array.Empty<int>(),
                                                                                 [6] = new [] {1, 7, 0},
                                                                                 [7] = new [] {2, 6},
                                                                                 [8] = new [] {1, 3},
                                                                                 [9] = new [] {2, 4},
                                                                                 [0] = new [] {4, 6}
                                                                             };

        internal static int GetDistinctNumbersDialed(int startingKey, int numberOfHops)
        {
            if (!_nextHopMap.ContainsKey(startingKey))
                return -1;

            var nextNeighbors = _nextHopMap[startingKey];
            if (numberOfHops == 0 || nextNeighbors.Length == 0)
                return 1;

            var result = 0;
            foreach (var neighbor in nextNeighbors)
            {
                result += GetDistinctNumbersDialed(neighbor, numberOfHops - 1);
            }

            return result;
        }
    }
}
