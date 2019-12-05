using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBookShop
{
    public class CBook : IComparable<CBook>
    {
        public string _ISBN { set; get; }
        public string _Author { set; get; }
        public string _Title { set; get; }
        public double _Price { set; get; }

        public CBook() { }
        ~CBook() { }

        public CBook(string ISBN, string Author, string Title, double Price)
        {
            _ISBN = ISBN;
            _Author = Author;
            _Title = Title;
            _Price = Price;
        }

        

        public string GetDisplayBook()
        {
            return ISBN + "        " + Author + "        " + Title + "                  " + Price.ToString();
        }

        public string GetDisplayBook(string sep)
        {
            return String.Format( ISBN + sep + Author + sep + Title + Price.ToString());
        }
    }
}
