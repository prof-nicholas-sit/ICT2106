//
// Test harness for the LineNumberReader class. Do not modify this file.
//
// Usage:
//    dotnet run <filename> <characters>
//
// Reads the given number characters from the given file and prints the
// number of the line from which the last character was read.
//
// Author: Nicholas Paul Sheppard
//
using System;
using System.IO;

namespace LineNumberReader
{
    class Program
    {
        static void Main(string[] args)
        {
			String filename;			// filename to read from
			int n;						// number of characters to read
			char[] buffer;				// characters read
			int c;						// return value from Read()
			int i;						// counter
			LineNumberReader reader;	// the reader
			
			
			try {
            
				// get the filename
				if (args.Length > 1) {
					filename = args[1];
				} else {
					Console.Write("File to read from: ");
					filename = Console.ReadLine();
				}
			
				// get the number of characters to read
				if (args.Length > 2) {
					n = Int32.Parse(args[2]);
				} else{
					Console.Write("Number of characters to read: ");
					n = Int32.Parse(Console.ReadLine());
				}
				if (n < 0) {
					Console.WriteLine("The number of characters must be larger than zero.");
					return;
				}
				
				// check that reading n characters one at a time Read() works
				Console.WriteLine("Reading characters one by one...");
				reader = new LineNumberReader(File.OpenText(filename));
				c = 0;
				i = 0;
				while (i < n && c >= 0) {
					c = reader.Read();
					i++;
				}
				if (c >= 0) {
					Console.WriteLine("  Character " + n + " is on line " + reader.GetLineNumber());
				} else {
					Console.WriteLine("  Could not read " + n + " characters from " + filename);
				}
				reader.Close();
				Console.WriteLine();
				
				// check that reading n characters in a single call to Read() works
				Console.WriteLine("Reading characters into a buffer...");
				reader = new LineNumberReader(File.OpenText(filename));
				buffer = new char[n];
				c = reader.Read(buffer, 0, n);
				if (c >= n) {
					Console.WriteLine("  Character " + n + " is on line " + reader.GetLineNumber());
				} else {
					Console.WriteLine("  Could not read " + n + " characters from " + filename);
				}
				reader.Close();
				Console.WriteLine();
				
			}
			catch (FormatException) {
				Console.WriteLine("The number of characters must be an integer.");
			}
			catch (FileNotFoundException e) {
				Console.WriteLine(e.Message);
			}
			
        }
    }
}
