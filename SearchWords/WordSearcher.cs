using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SearchWords
{
    public class WordSearcher
    {
        private string _allWordsPath = Path.Combine(Path.GetFullPath(@"..\..\Data"), "all_russian_words.txt");

        public WordSearcherSettings WordSearcherSettings { get; set; }

        public async void GetAllWords(IList<string> words, Regex regex)
        {
            using (StreamReader streamReader = new StreamReader(_allWordsPath))
            {
                string? line;

                while ((line = await streamReader.ReadLineAsync()) != null)
                {
                    //if (words.Add(line);
                }
            }
        }
    }
}
