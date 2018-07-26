//
// Line number reader, similar to java's LineNumberReader class, implemented
// as a decorator for the TextReader class.
//
// See the documentation for the TextReader class for a detailed description
// of the behaviour of each function in this class.
//

using System.IO;

namespace LineNumberReader
{
    class LineNumberReader : TextReader
    {
	
		//
		// Constructor.
		//
		// Lines will be read from BaseStreamIn.
		//
		public LineNumberReader(TextReader BaseStreamIn) : base() {
			
			// TO BE IMPLEMENTED
			
		}
		
		
		//
		// Get the current line number.
		//
		public int GetLineNumber() {
			
			// TO BE IMPLEMENTED
			
			return 0;
		
		}
		
		
		//
		// Set the current line number.
		//
		public void SetLineNumber(int n) {
			
			// TO BE IMPLEMENTED
			
		}
		
		
		//
		// Close the stream.
		//
		public override void Close() {
			
			// TO BE IMPLEMENTED
			
		}
		
		//
		// Read one character without changing the state of the reader.
		//
		public override int Peek() {
			
			// TO BE IMPLEMENTED
			
			return 0;
			
		}
		
		
		//
		// Read one character.
		//
		public override int Read() {
			
			// TO BE IMPLEMENTED
			
			return 0;
		}
		
		
		//
		// Read a sequence of 'count' characters into a buffer, starting at the given index.
		//
		public override int Read(char[] buffer, int index, int count) {
			
			// TO BE IMPLEMENTED
			
			return 0;
		}
		
	}
}