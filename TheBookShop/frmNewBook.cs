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
    public partial class frmNewBook : Form
    {
        public frmNewBook()
        {
            InitializeComponent();
        }

        private CBook book = null;

        public CBook GetNewBook()
        {
            this.ShowDialog();
            return book;
        }

        private void btnSaveNewBook_Click(object sender, EventArgs e)
        {
            if (IsValidData())
            {
                book = new CBook(txtISBN.Text, txtAuthor.Text, txtTitle.Text, Convert.ToDouble(txtPrice.Text));
                this.Close();
            }

        }

        private bool IsValidData()
        {
            return Validator.IsPresent(txtISBN) &&
                   Validator.IsPresent(txtAuthor) &&
                   Validator.IsPresent(txtTitle) &&
                   Validator.IsPresent(txtPrice);
        }

        private void btnCancelNewBook_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }       
 }

