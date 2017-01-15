using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;

namespace csvParse
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            csvParse.parseCsv();

            var dic = csvParse.parseCsv();

            for (int i = 0; i < dic.Count; i++)
            {
                if (i.Equals(dic.Count) && dic[i].Substring(0, dic[i].IndexOf("/")).Equals(dic[i + 1].Substring(0, dic[i + 1].IndexOf("/")))
                    && dic[i].Substring(0, dic[i].IndexOf("/")).Equals(dic[i + 2].Substring(0, dic[i + 2].IndexOf("/")))
                    && dic[i].Substring(0, dic[i].IndexOf("/")).Equals(dic[i + 3].Substring(0, dic[i + 3].IndexOf("/")))
                    && dic[i].Substring(0, dic[i].IndexOf("/")).Equals(dic[i + 4].Substring(0, dic[i + 4].IndexOf("/"))))
                {
                    dic.Add(dic[i]);
                }
                else if (i.Equals(dic.Count) && dic[i + 1].Substring(0, dic[i + 1].IndexOf("/")).Equals(dic[i + 2].Substring(0, dic[i + 2].IndexOf("/")))
                    && dic[i + 1].Substring(0, dic[i + 1].IndexOf("/")).Equals(dic[i + 3].Substring(0, dic[i + 3].IndexOf("/")))
                    && dic[i + 1].Substring(0, dic[i + 1].IndexOf("/")).Equals(dic[i + 4].Substring(0, dic[i + 4].IndexOf("/"))))
                {
                    dic.Add(dic[i + 1]);
                }
                else if (i.Equals(dic.Count) && dic[i + 2].Substring(0, dic[i + 2].IndexOf("/")).Equals(dic[i + 3].Substring(0, dic[i + 3].IndexOf("/")))
                    && dic[i + 2].Substring(0, dic[i + 2].IndexOf("/")).Equals(dic[i + 4].Substring(0, dic[i + 4].IndexOf("/"))))
                {
                    dic.Add(dic[i + 2]);
                }
                else if (i.Equals(dic.Count) && dic[i + 3].Substring(0, dic[i + 3].IndexOf("/")).Equals(dic[i + 4].Substring(0, dic[i + 4].IndexOf("/"))))
                {
                    dic.Add(dic[i + 3]);
                }
               
            }
            dic.Reverse();
            var k = dic.Count;

            using (var file = File.CreateText("test.csv"))
            {
                foreach (var arr in dic)
                {
                    file.WriteLine(string.Join(",", arr));
                }
            }
        }
    }
}
