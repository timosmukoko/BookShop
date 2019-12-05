using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TheBookShop
{
    public static class BookDB
    {
        private const string Path = @"..\..\Book.xml";

        public static List<CBook> GetBooks()
        {
            // create the list
            List<CBook> books = new List<CBook>();

            // create the xmlReaderSettings  object
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            // create the XmlReader object
            XmlReader xmlIn = XmlReader.Create(Path, settings);

            // read past all nodes to the first Student node
            if (xmlIn.ReadToDescendant("Book"))
            {
                // create one Student object for each Student node
                do
                {
                    CBook book = new CBook();
                    xmlIn.ReadStartElement("Book");
                    book._ISBN =
                        xmlIn.ReadElementContentAsString();
                    book._Author =
                        xmlIn.ReadElementContentAsString();
                    book._Title =
                        xmlIn.ReadElementContentAsString();
                    book._Price =
                        xmlIn.ReadElementContentAsDouble();
                    books.Add(book);
                }
                while (xmlIn.ReadToNextSibling("Book"));
            }

            // close the XmlReader object
            xmlIn.Close();

            return books;
        }

        public static void AddNewBook(List<CBook> books)
        {
            // create the XmlWriterSettings object
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            // create the XmlWriter object
            XmlWriter xmlOut = XmlWriter.Create(Path, settings);

            // write the start of the document
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("Books");

            // write each product object to the xml file
            foreach (CBook book in books)
            {
                xmlOut.WriteStartElement("Book");
                xmlOut.WriteElementString("ISBN", book._ISBN);
                xmlOut.WriteElementString("Author", book._Author);
                xmlOut.WriteElementString("Title", book._Title);
                xmlOut.WriteElementString("Price", Convert.ToString(book._Price));
                xmlOut.WriteEndElement();
                
            }

            // write the end tag for the root element
            xmlOut.WriteEndElement();

            // close the xmlWriter object
            xmlOut.Close();
        }
    }
}
