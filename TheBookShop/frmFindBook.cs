using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace TheBookShop
{
    public partial class frmFindBook : Form
    {
        private const string Path = @"..\..\Book.xml";
        public frmFindBook()
        {
            InitializeComponent();
        }
        List<CBook> BookS = new List<CBook>();

        private void btnSearch_Click(object sender, EventArgs e)
        {
            //SearchISBN(BookS);
            string findISBN = txtEnterISBN.Text;
            XmlDocument xml = new XmlDocument();
            //xml.Load("c:\\Users\\Timos\\Desktop\\SD_Year2a\\c#\\TheBookShop\\TheBookShop\\Book.xml");
            xml.Load(@"..\..\Book.xml");
            XmlNodeList xnList = xml.SelectNodes("/Books/Book/ISBN");
            foreach (XmlNode xn in xnList)
            {
                string isbn = xn["ISBN"].InnerText;
                if (findISBN == isbn)
                {
                    //listBox1.Items.Add(isbn);
                    txtBookFound.Text = isbn;
                }
            }



            //}

            //int i = lstBook.SelectedIndex;
            //if (i != -1)
            //{
            //    CBook student = (CBook)books[i];
            //    string message = "Are you sure you want to delete "
            //        + student._Title + "?";
            //    DialogResult button =
            //        MessageBox.Show(message, "Confirm Delete",
            //        MessageBoxButtons.YesNo);
            //    if (button == DialogResult.Yes)
            //    {
            //        books.Remove(student);
            //        BookDB.AddNewBook(books);
            //        FillBookListBox();

        }

        //public void SearchISBN(List<CBook> BookS)
        //{
        //    string findISBN = txtEnterISBN.Text;
        //    CBook fc = new CBook();
            
            

        //    foreach (CBook book_ in BookS)
        //    {
        //        if (findISBN == book_._ISBN)
        //        {
        //            //int index = 
        //            //txtBookFound.Text = book_.GetDisplayBook();
        //        }
        //        else
        //            MessageBox.Show(" No book found ");
        //    }
        //}

        private void btnCancelFind_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
