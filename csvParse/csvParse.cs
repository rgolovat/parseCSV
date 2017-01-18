using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csvParse
{
    public class csvParse
    {
        public static List<string> parseCsv()
        {
            var dict = File.ReadLines("VTS data 2017-01-17(11_10_03).csv").Select(line => line.Split(',')).SelectMany(s => s).ToList();


 return dict;
        }
    }
}
