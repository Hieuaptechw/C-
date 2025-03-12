namespace LibraryManager
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text) ||
            string.IsNullOrWhiteSpace(txtAuthor.Text) ||
            string.IsNullOrWhiteSpace(txtYear.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            Book book = new Book();
            int id = listViewBook.Items.Count+1;
            book.Title = txtTitle.Text;
            book.Author = txtAuthor.Text;
            book.Year = int.Parse(txtYear.Text);
            string b = id + "-" + book.Title + "-" + book.Author + "-" + book.Year;
            listViewBook.Items.Add(b);
            txtTitle.Clear();
            txtAuthor.Clear();
            txtYear.Clear();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = txtSearch.Text.Trim();

            if (string.IsNullOrEmpty(keyword))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SearchBook(keyword);
        }
        private void SearchBook(string keyword)
        {
            if (listViewBook.Items.Count == 0)
            {
                MessageBox.Show("Danh sách sách đang trống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            foreach (ListViewItem item in listViewBook.Items)
            {
        
                string title = item.SubItems[1].Text.ToLower();
                string author = item.SubItems[2].Text.ToLower();
                if (title.Contains(keyword.ToLower()) || author.Contains(keyword.ToLower()))
                {
                    item.BackColor = Color.Yellow;
                }
                else
                {
                    item.BackColor = Color.White; 
                }
            }
        }

    }
}
