using Repositories.Entities;
using Services.BookServices;
using Services.BookServices.BookServices;

namespace BookManager
{
    public partial class BookManager : Form
    {

        private IBookServices _services = new BookServices();

        public BookManager()
        {
            InitializeComponent();
        }

        public void BookManager_Load(object sender, EventArgs e)
        {
            FillBookList(_services.GetAllBooks());
        }

        public void FillBookList(List<Book> bookList)
        {
            dgvBookList.DataSource = null;
            dgvBookList.DataSource = bookList;
        }
    }
}
