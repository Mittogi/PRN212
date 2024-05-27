namespace UnitOfWorkTest
{
    partial class BookDetail
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblHeader = new Label();
            groupBox1 = new GroupBox();
            cboBookCategory = new ComboBox();
            dtpPublicationDate = new DateTimePicker();
            txtBookPrice = new TextBox();
            txtBookQuantity = new TextBox();
            txtBookAuthor = new TextBox();
            txtBookDescription = new TextBox();
            txtBookName = new TextBox();
            txtBookID = new TextBox();
            lblBookName = new Label();
            lblBookDescription = new Label();
            lblPublicationDate = new Label();
            lblBookQuantity = new Label();
            lblBookPrice = new Label();
            lblAuthor = new Label();
            lblBookCategory = new Label();
            lblBookID = new Label();
            btnSave = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblHeader.ForeColor = Color.Yellow;
            lblHeader.Location = new Point(12, 9);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(242, 54);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Book Detail";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cboBookCategory);
            groupBox1.Controls.Add(dtpPublicationDate);
            groupBox1.Controls.Add(txtBookPrice);
            groupBox1.Controls.Add(txtBookQuantity);
            groupBox1.Controls.Add(txtBookAuthor);
            groupBox1.Controls.Add(txtBookDescription);
            groupBox1.Controls.Add(txtBookName);
            groupBox1.Controls.Add(txtBookID);
            groupBox1.Controls.Add(lblBookName);
            groupBox1.Controls.Add(lblBookDescription);
            groupBox1.Controls.Add(lblPublicationDate);
            groupBox1.Controls.Add(lblBookQuantity);
            groupBox1.Controls.Add(lblBookPrice);
            groupBox1.Controls.Add(lblAuthor);
            groupBox1.Controls.Add(lblBookCategory);
            groupBox1.Controls.Add(lblBookID);
            groupBox1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            groupBox1.ForeColor = Color.Yellow;
            groupBox1.Location = new Point(22, 86);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(864, 434);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Book Info";
            // 
            // cboBookCategory
            // 
            cboBookCategory.FormattingEnabled = true;
            cboBookCategory.Location = new Point(271, 382);
            cboBookCategory.Name = "cboBookCategory";
            cboBookCategory.Size = new Size(566, 45);
            cboBookCategory.TabIndex = 15;
            // 
            // dtpPublicationDate
            // 
            dtpPublicationDate.Format = DateTimePickerFormat.Short;
            dtpPublicationDate.Location = new Point(269, 216);
            dtpPublicationDate.Name = "dtpPublicationDate";
            dtpPublicationDate.Size = new Size(340, 43);
            dtpPublicationDate.TabIndex = 14;
            // 
            // txtBookPrice
            // 
            txtBookPrice.Location = new Point(653, 273);
            txtBookPrice.Name = "txtBookPrice";
            txtBookPrice.Size = new Size(184, 43);
            txtBookPrice.TabIndex = 13;
            // 
            // txtBookQuantity
            // 
            txtBookQuantity.Location = new Point(271, 273);
            txtBookQuantity.Name = "txtBookQuantity";
            txtBookQuantity.Size = new Size(202, 43);
            txtBookQuantity.TabIndex = 12;
            // 
            // txtBookAuthor
            // 
            txtBookAuthor.Location = new Point(271, 330);
            txtBookAuthor.Name = "txtBookAuthor";
            txtBookAuthor.Size = new Size(337, 43);
            txtBookAuthor.TabIndex = 11;
            // 
            // txtBookDescription
            // 
            txtBookDescription.Location = new Point(271, 162);
            txtBookDescription.Name = "txtBookDescription";
            txtBookDescription.Size = new Size(566, 43);
            txtBookDescription.TabIndex = 10;
            // 
            // txtBookName
            // 
            txtBookName.Location = new Point(271, 109);
            txtBookName.Name = "txtBookName";
            txtBookName.Size = new Size(566, 43);
            txtBookName.TabIndex = 9;
            // 
            // txtBookID
            // 
            txtBookID.Location = new Point(271, 52);
            txtBookID.Name = "txtBookID";
            txtBookID.Size = new Size(337, 43);
            txtBookID.TabIndex = 8;
            // 
            // lblBookName
            // 
            lblBookName.AutoSize = true;
            lblBookName.Location = new Point(6, 109);
            lblBookName.Name = "lblBookName";
            lblBookName.Size = new Size(171, 38);
            lblBookName.TabIndex = 7;
            lblBookName.Text = "Book Name";
            // 
            // lblBookDescription
            // 
            lblBookDescription.AutoSize = true;
            lblBookDescription.Location = new Point(6, 162);
            lblBookDescription.Name = "lblBookDescription";
            lblBookDescription.Size = new Size(243, 38);
            lblBookDescription.TabIndex = 6;
            lblBookDescription.Text = "Book Description";
            // 
            // lblPublicationDate
            // 
            lblPublicationDate.AutoSize = true;
            lblPublicationDate.Location = new Point(6, 216);
            lblPublicationDate.Name = "lblPublicationDate";
            lblPublicationDate.Size = new Size(235, 38);
            lblPublicationDate.TabIndex = 5;
            lblPublicationDate.Text = "Publication Date";
            // 
            // lblBookQuantity
            // 
            lblBookQuantity.AutoSize = true;
            lblBookQuantity.Location = new Point(6, 273);
            lblBookQuantity.Name = "lblBookQuantity";
            lblBookQuantity.Size = new Size(208, 38);
            lblBookQuantity.TabIndex = 4;
            lblBookQuantity.Text = "Book Quantity";
            // 
            // lblBookPrice
            // 
            lblBookPrice.AutoSize = true;
            lblBookPrice.Location = new Point(479, 273);
            lblBookPrice.Name = "lblBookPrice";
            lblBookPrice.Size = new Size(157, 38);
            lblBookPrice.TabIndex = 3;
            lblBookPrice.Text = "Book Price";
            // 
            // lblAuthor
            // 
            lblAuthor.AutoSize = true;
            lblAuthor.Location = new Point(6, 330);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(186, 38);
            lblAuthor.TabIndex = 2;
            lblAuthor.Text = "Book Author";
            // 
            // lblBookCategory
            // 
            lblBookCategory.AutoSize = true;
            lblBookCategory.Location = new Point(6, 382);
            lblBookCategory.Name = "lblBookCategory";
            lblBookCategory.Size = new Size(212, 38);
            lblBookCategory.TabIndex = 1;
            lblBookCategory.Text = "Book Category";
            // 
            // lblBookID
            // 
            lblBookID.AutoSize = true;
            lblBookID.Location = new Point(6, 52);
            lblBookID.Name = "lblBookID";
            lblBookID.Size = new Size(123, 38);
            lblBookID.TabIndex = 0;
            lblBookID.Text = "Book ID";
            // 
            // btnSave
            // 
            btnSave.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSave.Location = new Point(911, 110);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(197, 55);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // BookDetail
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Red;
            ClientSize = new Size(1119, 532);
            Controls.Add(btnSave);
            Controls.Add(groupBox1);
            Controls.Add(lblHeader);
            Name = "BookDetail";
            Text = "Book detail";
            Load += BookDetail_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblHeader;
        private GroupBox groupBox1;
        private Label lblBookID;
        private Label lblBookName;
        private Label lblBookDescription;
        private Label lblPublicationDate;
        private Label lblBookQuantity;
        private Label lblBookPrice;
        private Label lblAuthor;
        private Label lblBookCategory;
        private TextBox txtBookID;
        private ComboBox cboBookCategory;
        private DateTimePicker dtpPublicationDate;
        private TextBox txtBookPrice;
        private TextBox txtBookQuantity;
        private TextBox txtBookAuthor;
        private TextBox txtBookDescription;
        private TextBox txtBookName;
        private Button btnSave;
    }
}