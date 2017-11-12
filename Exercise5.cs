using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sitech_ProgrammingExercise
{
    public partial class MainWindow
    {


        /// <summary>
        /// return the passed collection sorted first by frequency of the names and then alphabetically
        /// </summary>
        /// <param name="names"></param>
        /// <returns></returns>
        public IEnumerable<string> Exercise5(IEnumerable<string> names)
        {
            var mostFrequentlyUsed = names.GroupBy(word => word)
            .Select(wordGroup => new { Word = wordGroup.Key, Frequency = wordGroup.Count() })
            .OrderByDescending(word => word.Frequency).ThenBy(word => word.Word);

            return mostFrequentlyUsed.Select(i => i.Word);
        }
    }
}
