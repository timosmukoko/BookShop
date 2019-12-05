using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TheBookShop
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private List<CBook> books = null;       

        private void frmMain_Load(object sender, EventArgs e)
        {
            books = BookDB.GetBooks();
            FillBookListBox();
        }

        private void FillBookListBox()
        {
            lstBook.Items.Clear();
            foreach (CBook bk in books)
            {
                lstBook.Items.Add(bk.GetDisplayBook());
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewBook addNewBook = new frmNewBook();
            CBook book = addNewBook.GetNewBook();
            if(book != null)
            {
                books.Add(book);
                BookDB.AddNewBook(books);
                FillBookListBox();                
            }           
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            frmFindBook findBookForm = new frmFindBook();
            findBookForm.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstBook.SelectedIndex;
            if (i != -1)
            {
                CBook book = (CBook)books[i];
                string message = "Are you sure you want to delete "
                    + book._Title + "?";
                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);
                if (button == DialogResult.Yes)
                {
                    books.Remove(book);
                    BookDB.AddNewBook(books);
                    FillBookListBox();
                }
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            List<string> _default = new List<string>();
           
            // Add parts to the list.
            _default.Add("123-234-999     How to do things    Lis Bourke                9.99 ");
            _default.Add("123-234-999     How to do things    Lis Bourke                9.99 ");
             lstBook.DataSource = _default;
            //lstBook.DataSource = null;
            //((DataTable)lstBook.DataSource).AcceptChanges();

        }
    }
}
