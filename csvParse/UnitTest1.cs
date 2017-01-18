using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System.Collections.Generic;
using System.Linq;

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
            var newDic = new List<string>(dic);

            var groups = dic.Count / 5;
            int quant = 0;

            int z = 0;
            

            for (int x = 1; x <= groups; x++)
            {
                if (x == 1)
                {
                    var names = new Dictionary<string, string>();
                    do
                    {
                        for (int y = x - 1; y < 5; y++)
                        {

                            string digit = "dig" + y;
                            if (names.ContainsKey(digit))
                            {
                                names[digit] = dic[y].Substring(0, dic[y].IndexOf("/"));
                            }
                            else
                            {
                                names.Add(digit, dic[y].Substring(0, dic[y].IndexOf("/")));
                            }


                        }
                        


                        var first = names["dig0"];
                        var second = names["dig1"];
                        var third = names["dig2"];
                        var fourth = names["dig3"];
                        var fifth = names["dig4"];

                        

                            var bool1 = first.Equals(second);

                            var bool2 = first.Equals(third);

                            var bool3 = first.Equals(fourth);

                            var bool4 = first.Equals(fifth);

                            var bool5 = second.Equals(third);

                            var bool6 = second.Equals(fourth);

                            var bool7 = second.Equals(fifth);

                            var bool8 = third.Equals(fourth);

                            var bool9 = third.Equals(fifth);

                            var bool10 = fourth.Equals(fifth);

         
                          
                            if (bool1)
                            {
                                newDic.Add(dic[1]);
                                newDic.RemoveAt(1);
                                dic = newDic;


                            }
                            if (bool2)
                            {
                                newDic.Add(dic[2]);
                                newDic.RemoveAt(2);
                                dic = newDic;
                            }
                             if (bool3)
                            {
                                newDic.Add(dic[3]);
                                newDic.RemoveAt(3);
                                dic = newDic;
                            }
                             if (bool4)
                            {
                                newDic.Add(dic[4]);
                                newDic.RemoveAt(4);
                                dic = newDic;
                            }
                             if (bool5)
                            {
                                newDic.Add(dic[2]);
                                newDic.RemoveAt(2);
                                dic = newDic;

                            }
                             if (bool6)
                            {
                                newDic.Add(dic[3]);
                                newDic.RemoveAt(3);
                                dic = newDic;
                            }
                             if (bool7)
                            {
                                newDic.Add(dic[4]);
                                newDic.RemoveAt(4);
                                dic = newDic;
                            }
                             if (bool8)
                            {
                                newDic.Add(dic[3]);
                                newDic.RemoveAt(3);
                                dic = newDic;
                            }
                             if (bool9)
                            {
                                newDic.Add(dic[4]);
                                newDic.RemoveAt(4);
                                dic = newDic;
                            }
                             if (bool10)
                            {
                                newDic.Add(dic[4]);
                                newDic.RemoveAt(4);
                                dic = newDic;
                            }


                        quant = names.GroupBy(c => c.Value).Where(c => c.Count() > 1).Count();
                    } while (quant > 0 ) ;// && //second.Equals(third) && !third.Equals(fourth) && fourth.Equals(fifth));
                    z = 5;
                }
                else
                {
                    do
                    {
                        var names = new Dictionary<string, string>();
                        string first = null;
                        string second = null;
                        string third = null;
                        string fourth = null;
                        string fifth = null;
                        int[] number = new int[5];
                        do
                        {
                            int i = 0;
                            for (int y = z; y < 5 * x; y++)
                            {

                                string digit = "dig" + y;
                                if (names.ContainsKey(digit))
                                {
                                    names[digit] = dic[y].Substring(0, dic[y].IndexOf("/"));
                                }
                                else
                                {
                                    names.Add(digit, dic[y].Substring(0, dic[y].IndexOf("/")));
                                }
                                number[i] = y;
                                i++;
                            }
                            i = 0;



                            first = names["dig" + number[0]];
                            second = names["dig" + number[1]];
                            third = names["dig" + number[2]];
                            fourth = names["dig" + number[3]];
                            fifth = names["dig" + number[4]];




                            var bool1 = first.Equals(second);

                            var bool2 = first.Equals(third);

                            var bool3 = first.Equals(fourth);

                            var bool4 = first.Equals(fifth);

                            var bool5 = second.Equals(third);

                            var bool6 = second.Equals(fourth);

                            var bool7 = second.Equals(fifth);

                            var bool8 = third.Equals(fourth);

                            var bool9 = third.Equals(fifth);

                            var bool10 = fourth.Equals(fifth);


                            if (bool1)
                            {
                                newDic.Add(dic[1 + z]);
                                newDic.RemoveAt(1 + z);
                                dic = newDic;


                            }
                            if (bool2)
                            {
                                newDic.Add(dic[2 + z]);
                                newDic.RemoveAt(2 + z);
                                dic = newDic;
                            }
                            if (bool3)
                            {
                                newDic.Add(dic[3 + z]);
                                newDic.RemoveAt(3 + z);
                                dic = newDic;
                            }
                            if (bool4)
                            {
                                newDic.Add(dic[4 + z]);
                                newDic.RemoveAt(4 + z);
                                dic = newDic;
                            }
                            if (bool5)
                            {
                                newDic.Add(dic[2 + z]);
                                newDic.RemoveAt(2 + z);
                                dic = newDic;

                            }
                            if (bool6)
                            {
                                newDic.Add(dic[3 + z]);
                                newDic.RemoveAt(3 + z);
                                dic = newDic;
                            }
                            if (bool7)
                            {
                                newDic.Add(dic[4 + z]);
                                newDic.RemoveAt(4 + z);
                                dic = newDic;
                            }
                            if (bool8)
                            {
                                newDic.Add(dic[3 + z]);
                                newDic.RemoveAt(3 + z);
                                dic = newDic;
                            }
                            if (bool9)
                            {
                                newDic.Add(dic[4 + z]);
                                newDic.RemoveAt(4 + z);
                                dic = newDic;
                            }
                            if (bool10)
                            {
                                newDic.Add(dic[4 + z]);
                                newDic.RemoveAt(4 + z);
                                dic = newDic;
                            }


                            quant = names.GroupBy(c => c.Value).Where(c => c.Count() > 1).Count();
                        } while (quant > 0 && z < (dic.Count - 16) );// && //second.Equals(third) && !third.Equals(fourth) && fourth.Equals(fifth));
                        z = z + 5;
                    } while (z > dic.Count);
                }
               

            }
           //dic = newDic;

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
