//
// ICT2106 Software Design
//
// Program for testing constant dictionaries
//
using System;
using System.Collections.Generic;

namespace ICT2106.ConstantDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // create a test dictionary
            IDictionary<int, String> mutableDict = new Dictionary<int, String>();
            mutableDict.Add(1, "cricket");
            mutableDict.Add(2, "mosquito");
            mutableDict.Add(3, "fly");

            // create an immutable dictionary
            IConstantDictionary<int, String> immutableDict = new ConstantDictionaryAdapter<int, String>(mutableDict);

            // print the contents of the dictionary
            foreach (KeyValuePair<int, String> keypair in immutableDict)
            {
                Console.WriteLine(keypair.ToString());
            }
            Console.WriteLine();
        }
    }
}
