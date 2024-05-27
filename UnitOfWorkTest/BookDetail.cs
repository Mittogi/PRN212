using Microsoft.VisualBasic;
using Repositories.Entities;
using Services.BookCategoryServices;
using Services.BookServices.BookServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnitOfWorkTest
{
    public partial class BookDetail : Form
    {
        private IBookCategoryServices _bookCategoryServices = new BookCategoryServices();

        public int OpenMode { get; set; } //1: Create | 0: Update
        public Book SelectedBook { get; set; }

        public BookDetail()
        {
            InitializeComponent();
        }

        private void BookDetail_Load(object sender, EventArgs e)
        {

            cboBookCategory.DataSource = _bookCategoryServices.GetAllBookCategories();
            cboBookCategory.DisplayMember = "BookGenreType";
            cboBookCategory.ValueMember = "BookCategoryId";

            if (OpenMode == 1)
            {
                //Để form trống trơn, ngoại trừ combobox cate phải đổ vào bất chấp mode, đã làm ở trên
                //Đổ label cho rõ ràng
                lblHeader.Text = "Create a book";
            }
            else
            {
                lblHeader.Text = "Update a book";
                //jump đến mã loại sách edit
                //Nếu sách đang là sách trinh thám, id 2, jump đến số 2
                cboBookCategory.SelectedValue = SelectedBook.BookCategoryId;

                //Biến selectedBook có value
                txtBookID.Enabled = false;//Không cho edit id
                txtBookName.Text = SelectedBook.BookName;
                txtBookDescription.Text = SelectedBook.Description;
                txtBookPrice.Text = SelectedBook.Price.ToString();
                txtBookQuantity.Text = SelectedBook.Quantity.ToString();
                txtBookAuthor.Text = SelectedBook.Author.ToString();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int BookId;


            if (OpenMode == 1)
            {
                BookId = int.Parse(txtBookID.Text.Trim());
            }
            else
            {
                BookId = SelectedBook.BookId;
            }

            Book b = new Book()
            {
                BookId = BookId,
                BookName = txtBookName.Text.Trim(),
                Description = txtBookDescription.Text.Trim(),
                PublicationDate = dtpPublicationDate.Value,
                Quantity = int.Parse(txtBookQuantity.Text.Trim()),
                Price = double.Parse(txtBookPrice.Text.Trim()),
                Author = txtBookAuthor.Text.Trim(),
                BookCategoryId = (int)cboBookCategory.SelectedValue
            };

            BookServices service = new BookServices();

            if (OpenMode == 1)
            {
                service.AddBook(b);
                MessageBox.Show("Create book successfully", "Create result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                service.UpdateBook(b);
                MessageBox.Show("Update book successfully", "Update result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            this.Close();
        }

    }
}
