using CSSaveToFileSysAssociationFW;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSaveToFileSysAssociationAllCLIFW
{
    class Program
    {
        private static int sqlConnectionString = 0;
        private static int outPath = 1;

        static void Main(string[] args)
        {

            if (args.Length != 6)
            {
                Console.WriteLine(args.Length);
                Console.WriteLine("<sqlConnectionString> <outPath>");
            }

            string[] files =
                Directory.GetFiles(args[outPath], "*.xml", SearchOption.TopDirectoryOnly);

            new SaveToFileSysAssociationFW(
            args[sqlConnectionString],
            args[outPath]
            ).WriteOutAc4yAssociationAll();
        }
    }
}