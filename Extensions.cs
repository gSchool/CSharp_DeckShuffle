using System.Net;
using System.Runtime.InteropServices.ComTypes;
using System.Collections.Generic;

namespace DeckShuffle
{
    public static class Extensions
    {
        public static IEnumerable<T> InterleaveSequenceWith<T>(this IEnumerable<T> first, IEnumerable<T> second){
            var firstIter = first.GetEnumerator();
            var secondIter = second.GetEnumerator();

            while (firstIter.MoveNext() && secondIter.MoveNext()){
                yield return firstIter.Current;
                yield return secondIter.Current;
            }
        }
    }
}