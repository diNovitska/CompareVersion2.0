using java.lang;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CompareVersion2._0
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(VersionCompareText(VersionCompare("1.2", "1.2")));
            Console.WriteLine(VersionCompareText(VersionCompare("1.3", "1.2")));
            Console.WriteLine(VersionCompareText(VersionCompare("1.2", "1.5")));
            Console.WriteLine(VersionCompareText(VersionCompare("1.2.0", "1.2")));
            Console.WriteLine(VersionCompareText(VersionCompare("1.2", "1.2.0")));
            Console.WriteLine(VersionCompareText(VersionCompare("1.2.9.8.1", "1.3")));
            Console.WriteLine(VersionCompareText(VersionCompare("1.3", "1.2.9.8")));
            Console.WriteLine(VersionCompareText(VersionCompare("1.2.9", "1.2")));
            Console.WriteLine(VersionCompareText(VersionCompare("1.2", "1.2.9")));

        }

        public static string VersionCompareText(int result)
        {
            if (result == 0)
            {
                return "Versions are equal";
            }
            else
            { if (result == 1)
                {
                    return "First version is newer";
                }
                else 
            {
                    return "Second version is newer";
                }
            }

        }
            public static int VersionCompare(string str1, string str2)
        {
            List<string> version1 = new List<string>((str1.Split('.')).ToList());
            List<string> version2 = new List<string>((str2.Split('.')).ToList());

            while (version1.Count!= version2.Count)
            {
                if (version1.Count < version2.Count)
                {
                    version1.Add("0");
                }
                else
                {
                    version2.Add("0");
                }
            }

            string[] versionA = version1.ToArray();
            string[] versionB = version2.ToArray();
            int i = 0;
            while (i < versionA.Length && i < versionB.Length && versionA[i].Equals(versionB[i]))
            {
                i++;
            }
            if (i < versionA.Length && i < versionB.Length)
            {
                return versionA[i].CompareTo(versionB[i]);
                
            }
            else
            {
                return versionA.Length - versionB.Length;
            }
        }
    }
}

