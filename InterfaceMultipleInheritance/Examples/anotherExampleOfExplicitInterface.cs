using System;
using System.Collections.Generic;
using System.Text;
namespace ExplicitInterface
{
	class ExplicitInterface_Implementation
	{
		interface readFile
		{
			void Read();
			void Write();
		}
		interface writeFile
		{
			void View();
			void Read();
		}
		public class Document : readFile, writeFile
		{
			// the document constructor
			public Document(string doc)
			{
				Console.WriteLine("Creating a document with: {0}", doc);
			}
			// Implicit implementation
			public virtual void Read()
			{
				Console.WriteLine("Reading from Read method in interface readFile.");
			}
			public void Write()
			{
				Console.WriteLine("Writing in Write Method in interface readFile.");
			}
			// Explicit implementation
			void writeFile.Read()
			{
				Console.WriteLine("Reading from Read method in interface writeFile.");
			}
			public void View()
			{
				Console.WriteLine("Viewing from View method in interface writeFile.");
			}
		}
		public void CreateDoc()
		{
			// Creating a Document object
			Document doc1 = new Document("This Document is getting written \n in the document created.");
			readFile iFile = doc1 as readFile;
			if(iFile != null) {
				iFile.Read();
			}
			// Cast to an writeFile interface
			writeFile wFile = doc1 as writeFile;
			if(wFile != null) {
				wFile.Read();
			}
			doc1.Read();
			doc1.View();
		}
		public static void Main()
		{
			ExplicitInterface_Implementation ei = new ExplicitInterface_Implementation() ;
			ei.CreateDoc();
		}
	}
}