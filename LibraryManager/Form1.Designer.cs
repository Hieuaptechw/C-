namespace LibraryManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            listViewBook = new ListView();
            btnAdd = new Button();
            lblTitle = new Label();
            lblAuthor = new Label();
            label3 = new Label();
            txtTitle = new TextBox();
            txtAuthor = new TextBox();
            txtYear = new TextBox();
            txtSearch = new TextBox();
            SuspendLayout();
            // 
            // listViewBook
            // 
            listViewBook.Location = new Point(25, 40);
            listViewBook.Name = "listViewBook";
            listViewBook.Size = new Size(749, 190);
            listViewBook.TabIndex = 0;
            listViewBook.UseCompatibleStateImageBehavior = false;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(483, 266);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(72, 250);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(38, 20);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Title";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(72, 298);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(54, 20);
            lblAuthor.TabIndex = 3;
            lblAuthor.Text = "Author";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 343);
            label3.Name = "label3";
            label3.Size = new Size(37, 20);
            label3.TabIndex = 4;
            label3.Text = "Year";
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(176, 250);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(125, 27);
            txtTitle.TabIndex = 5;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(176, 295);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(125, 27);
            txtAuthor.TabIndex = 6;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(176, 343);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(125, 27);
            txtYear.TabIndex = 7;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(635, 7);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Search..";
            txtSearch.Size = new Size(125, 27);
            txtSearch.TabIndex = 8;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtSearch);
            Controls.Add(txtYear);
            Controls.Add(txtAuthor);
            Controls.Add(txtTitle);
            Controls.Add(label3);
            Controls.Add(lblAuthor);
            Controls.Add(lblTitle);
            Controls.Add(btnAdd);
            Controls.Add(listViewBook);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListView listViewBook;
        private Button btnAdd;
        private Label lblTitle;
        private Label lblAuthor;
        private Label label3;
        private TextBox txtTitle;
        private TextBox txtAuthor;
        private TextBox txtYear;
        private TextBox txtSearch;
    }
}
