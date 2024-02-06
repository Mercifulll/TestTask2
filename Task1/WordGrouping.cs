using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class WordGrouping
    {
        private readonly string sentence;

        public WordGrouping(string sentence)
        {
            this.sentence = sentence;
        }

        public void GroupWordsByLength()
        {
            string[] words = sentence.Split(' ', ',', '.', '"', '\'');
            Dictionary<int, List<string>> wordGroups = new Dictionary<int, List<string>>();

            foreach (string word in words.Where(w => !string.IsNullOrEmpty(w)))
            {
                int length = word.Length;
                if (!wordGroups.ContainsKey(length))
                {
                    wordGroups[length] = new List<string>();
                }
                if (!wordGroups[length].Contains(word))
                {
                    wordGroups[length].Add(word);
                }
            }

            var sortedGroups = wordGroups.OrderBy(entry => entry.Key);

            foreach (var group in sortedGroups)
            {
                Console.WriteLine($"Words of length: {group.Key}, Count: {group.Value.Count}");
                foreach (string word in group.Value)
                {
                    Console.WriteLine(word);
                }
                Console.WriteLine();
            }
        }
    }
}
