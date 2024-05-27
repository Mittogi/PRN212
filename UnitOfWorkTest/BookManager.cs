using Repositories.Entities;
using Services.BookServices.BookServices;

namespace UnitOfWorkTest
{
    public partial class BookManager : Form
    {
        private BookServices bookServices = new BookServices();
        public BookManager()
        {
            InitializeComponent();
        }

        public void BookManager_Load(object sender, EventArgs e)
        {
            FillGrid(bookServices.GetAllBooks());
            dgvBookList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvBookList.ReadOnly = true;
        }

        private void FillGrid(List<Book> list)
        {
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = list;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            BookDetail f = new BookDetail();
            f.OpenMode = 1;
            f.SelectedBook = null;

            f.ShowDialog();

            FillGrid(bookServices.GetAllBooks());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Kiểm tra coi user đã select dòng chưa thì mới mở màn hình detail
            if (dgvBookList.SelectedRows.Count == 0)
            {
                //Chưa chọn dòng nào
                MessageBox.Show("Please select 1 row to edit", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //Thoát hàm sớm
            }

            //Lấy ra dòng đầu tiên user đã chọn [0]
            Book selectedBook = dgvBookList.SelectedRows[0].DataBoundItem as Book;

            BookDetail f = new BookDetail();
            f.OpenMode = 0;
            f.SelectedBook = selectedBook;

            f.ShowDialog();

            FillGrid(bookServices.GetAllBooks());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select 1 row to delete", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Delete a book
            //Book selectedBook = dgvBookList.SelectedRows[0].DataBoundItem as Book;

            //Get list of book are selected
            List<Book> bookSelectedList = new List<Book>();

            for (int i = 0; i < dgvBookList.SelectedRows.Count; i++)
            {
                Book bookSeclected = dgvBookList.SelectedRows[i].DataBoundItem as Book;
                bookSelectedList.Add(bookSeclected);
            }

            // Show confirm message
            DialogResult answer = MessageBox.Show("Are you sure to delete", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (answer == DialogResult.No)
                return;

            // Delete list of book
            bookServices.DeleteBook(bookSelectedList);

            //Refresh data gird view
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = bookServices.GetAllBooks();
        }
    }
}
