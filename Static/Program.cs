using System;
using System.Collections.Generic;
using System.Linq;

namespace Static
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var percent = GetLikesPerViews().Aggregate(new Double(), (p, kv) => kv.Key / 100 * kv.Value );

            Console.WriteLine($"По статистике, {percent}% человек, " +
                "просмотревших мою запись в ВК, \nпоставили на неё лайк.");
            Console.ReadKey();
        }

        public static List<KeyValuePair<double, int>> GetLikesPerViews()
        {
            return new List<KeyValuePair<double, int>>() {
                { 1, 63 }, //{ 2, 81 }, { 1, 77 },   { 4, 143 }, { 1, 97 }, { 1, 108 }, 
                { 8, 94 }, { 1, 54 }, { 1, 199 },  { 1, 147 }, { 2, 84 }, { 1, 86 }, 
                { 1, 122 }, { 1, 52 }, { 1, 92 }, { 1, 61 }, { 1, 33 }
            }; 
        }
    }

    public static class InitializerExtensions
    {
        public static void Add<T1, T2>(this ICollection<KeyValuePair<T1, T2>> target, T1 item1, T2 item2)
        {
            if (target == null)
                throw new ArgumentNullException(nameof(target));

            target.Add(new KeyValuePair<T1, T2>(item1, item2));
        }
    }
}
