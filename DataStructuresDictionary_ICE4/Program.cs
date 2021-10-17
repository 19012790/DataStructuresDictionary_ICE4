using System;
using System.Collections.Generic;

namespace DataStructuresDictionary_ICE4
{
    class Program
    {
        private static Dictionary<string, object> dict;//dictionary created
        private static void plus(string strKey, object dataType) //method that adds
        {
            if (!dict.ContainsKey(strKey)) //if statment created
            {
                dict.Add(strKey, dataType);
            }
            else //else statement
            {
                dict[strKey] = dataType;
            }
        }

        public static T GetVal<T>(string strKey) //get value method
        {
            object obj;
            T retType;
            dict.TryGetValue(strKey, out obj);

            try //try catch created
            {
                retType = (T)obj;
            }
            catch
            {
                retType = default(T);
            }
            return retType;
        }

        static void Main(string[] args)
        {
            dict = new Dictionary<string, object>(); //dictionary object created

            plus("dog","pitbull"); //adds strings
            plus("snake", "cobra");//adds strings
            plus("bird", "eagle");//adds strings
            plus("n", 2);//adds int

            Console.WriteLine("dog = " + GetVal<string>("dog"));  
            Console.WriteLine("snake = " + GetVal<string>("snake"));
            Console.WriteLine("bird = " + GetVal<string>("bird"));
            Console.WriteLine("n = " + GetVal<int>("n"));
            Console.ReadLine();
        }
    }
}

