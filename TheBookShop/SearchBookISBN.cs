using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheBookShop
{
    class SearchBookISBN : IComparer<CBook>
    {
        public static IComparer<CBook> Default = new SearchBookISBN();

        public int Compare(CBook x, CBook y)
        {
            return string.Compare(x._ISBN, y._ISBN);
        }
    }
}
