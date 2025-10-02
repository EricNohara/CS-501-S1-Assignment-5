namespace Personal_Library_Manager_Program
{
    partial class form_libraryManager
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label label_titleAdd;
            System.Windows.Forms.Label label_authorAdd;
            System.Windows.Forms.Label label_genreAdd;
            System.Windows.Forms.Label label_yearAdd;
            System.Windows.Forms.Label label_titleUpdate;
            System.Windows.Forms.Label label_authorUpdate;
            System.Windows.Forms.Label label_titleSearch;
            System.Windows.Forms.Label label_authorSearch;
            System.Windows.Forms.Label label_genreSearch;
            System.Windows.Forms.Label label_yearSearch;
            System.Windows.Forms.Label label_statusSearch;
            System.Windows.Forms.Label label_yearUpdateResult;
            System.Windows.Forms.Label label_genreUpdateResult;
            System.Windows.Forms.Label label_authorUpdateResult;
            System.Windows.Forms.Label label_titleUpdateResult;
            System.Windows.Forms.Label label_statusUpdateResult;
            System.Windows.Forms.Label label_deleteBook;
            this.label_libraryManager = new System.Windows.Forms.Label();
            this.tabCtrl_libraryMechanics = new System.Windows.Forms.TabControl();
            this.tabPage_addBook = new System.Windows.Forms.TabPage();
            this.label_addBookInstruction = new System.Windows.Forms.Label();
            this.textBox_genreAdd = new System.Windows.Forms.TextBox();
            this.booksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksDataSet = new Personal_Library_Manager_Program.BooksDataSet();
            this.label_addBookResult = new System.Windows.Forms.Label();
            this.button_addBook = new System.Windows.Forms.Button();
            this.nup_yearAdd = new System.Windows.Forms.NumericUpDown();
            this.textBox_authorAdd = new System.Windows.Forms.TextBox();
            this.textBox_titleAdd = new System.Windows.Forms.TextBox();
            this.button_clearAddBook = new System.Windows.Forms.Button();
            this.tabPage_updateBook = new System.Windows.Forms.TabPage();
            this.groupBox_updateResult = new System.Windows.Forms.GroupBox();
            this.label_performUpdateStatus = new System.Windows.Forms.Label();
            this.button_performUpdate = new System.Windows.Forms.Button();
            this.textBox_genreUpdateResult = new System.Windows.Forms.TextBox();
            this.textBox_titleUpdateResult = new System.Windows.Forms.TextBox();
            this.comboBox_statusUpdateResult = new System.Windows.Forms.ComboBox();
            this.textBox_authorUpdateResult = new System.Windows.Forms.TextBox();
            this.nup_yearUpdateResult = new System.Windows.Forms.NumericUpDown();
            this.label_updateSearchResult = new System.Windows.Forms.Label();
            this.label_updateSearchStatus = new System.Windows.Forms.Label();
            this.button_searchUpdate = new System.Windows.Forms.Button();
            this.button_clearUpdate = new System.Windows.Forms.Button();
            this.textBox_authorUpdate = new System.Windows.Forms.TextBox();
            this.textBox_titleUpdate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage_search = new System.Windows.Forms.TabPage();
            this.label_searchBookResult = new System.Windows.Forms.Label();
            this.checkBox_filterByYear = new System.Windows.Forms.CheckBox();
            this.dgv_searchResults = new System.Windows.Forms.DataGridView();
            this.label_searchResults = new System.Windows.Forms.Label();
            this.button_search = new System.Windows.Forms.Button();
            this.button_clearSearch = new System.Windows.Forms.Button();
            this.comboBox_statusSearch = new System.Windows.Forms.ComboBox();
            this.nup_yearSearch = new System.Windows.Forms.NumericUpDown();
            this.textBox_genreSearch = new System.Windows.Forms.TextBox();
            this.textBox_authorSearch = new System.Windows.Forms.TextBox();
            this.textBox_titleSearch = new System.Windows.Forms.TextBox();
            this.label_searchPrompt = new System.Windows.Forms.Label();
            this.booksTableAdapter = new Personal_Library_Manager_Program.BooksDataSetTableAdapters.BooksTableAdapter();
            this.tableAdapterManager = new Personal_Library_Manager_Program.BooksDataSetTableAdapters.TableAdapterManager();
            this.checkBox_deleteBook = new System.Windows.Forms.CheckBox();
            label_titleAdd = new System.Windows.Forms.Label();
            label_authorAdd = new System.Windows.Forms.Label();
            label_genreAdd = new System.Windows.Forms.Label();
            label_yearAdd = new System.Windows.Forms.Label();
            label_titleUpdate = new System.Windows.Forms.Label();
            label_authorUpdate = new System.Windows.Forms.Label();
            label_titleSearch = new System.Windows.Forms.Label();
            label_authorSearch = new System.Windows.Forms.Label();
            label_genreSearch = new System.Windows.Forms.Label();
            label_yearSearch = new System.Windows.Forms.Label();
            label_statusSearch = new System.Windows.Forms.Label();
            label_yearUpdateResult = new System.Windows.Forms.Label();
            label_genreUpdateResult = new System.Windows.Forms.Label();
            label_authorUpdateResult = new System.Windows.Forms.Label();
            label_titleUpdateResult = new System.Windows.Forms.Label();
            label_statusUpdateResult = new System.Windows.Forms.Label();
            label_deleteBook = new System.Windows.Forms.Label();
            this.tabCtrl_libraryMechanics.SuspendLayout();
            this.tabPage_addBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_yearAdd)).BeginInit();
            this.tabPage_updateBook.SuspendLayout();
            this.groupBox_updateResult.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_yearUpdateResult)).BeginInit();
            this.tabPage_search.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_searchResults)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_yearSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // label_titleAdd
            // 
            label_titleAdd.AutoSize = true;
            label_titleAdd.Location = new System.Drawing.Point(28, 70);
            label_titleAdd.Name = "label_titleAdd";
            label_titleAdd.Size = new System.Drawing.Size(36, 16);
            label_titleAdd.TabIndex = 1;
            label_titleAdd.Text = "Title:";
            // 
            // label_authorAdd
            // 
            label_authorAdd.AutoSize = true;
            label_authorAdd.Location = new System.Drawing.Point(16, 98);
            label_authorAdd.Name = "label_authorAdd";
            label_authorAdd.Size = new System.Drawing.Size(48, 16);
            label_authorAdd.TabIndex = 3;
            label_authorAdd.Text = "Author:";
            // 
            // label_genreAdd
            // 
            label_genreAdd.AutoSize = true;
            label_genreAdd.Location = new System.Drawing.Point(17, 126);
            label_genreAdd.Name = "label_genreAdd";
            label_genreAdd.Size = new System.Drawing.Size(47, 16);
            label_genreAdd.TabIndex = 8;
            label_genreAdd.Text = "Genre:";
            // 
            // label_yearAdd
            // 
            label_yearAdd.AutoSize = true;
            label_yearAdd.Location = new System.Drawing.Point(25, 153);
            label_yearAdd.Name = "label_yearAdd";
            label_yearAdd.Size = new System.Drawing.Size(39, 16);
            label_yearAdd.TabIndex = 9;
            label_yearAdd.Text = "Year:";
            // 
            // label_titleUpdate
            // 
            label_titleUpdate.AutoSize = true;
            label_titleUpdate.Location = new System.Drawing.Point(31, 68);
            label_titleUpdate.Name = "label_titleUpdate";
            label_titleUpdate.Size = new System.Drawing.Size(36, 16);
            label_titleUpdate.TabIndex = 1;
            label_titleUpdate.Text = "Title:";
            // 
            // label_authorUpdate
            // 
            label_authorUpdate.AutoSize = true;
            label_authorUpdate.Location = new System.Drawing.Point(19, 96);
            label_authorUpdate.Name = "label_authorUpdate";
            label_authorUpdate.Size = new System.Drawing.Size(48, 16);
            label_authorUpdate.TabIndex = 3;
            label_authorUpdate.Text = "Author:";
            // 
            // label_titleSearch
            // 
            label_titleSearch.AutoSize = true;
            label_titleSearch.Location = new System.Drawing.Point(17, 49);
            label_titleSearch.Name = "label_titleSearch";
            label_titleSearch.Size = new System.Drawing.Size(97, 16);
            label_titleSearch.TabIndex = 1;
            label_titleSearch.Text = "Title (contains):";
            // 
            // label_authorSearch
            // 
            label_authorSearch.AutoSize = true;
            label_authorSearch.Location = new System.Drawing.Point(176, 49);
            label_authorSearch.Name = "label_authorSearch";
            label_authorSearch.Size = new System.Drawing.Size(109, 16);
            label_authorSearch.TabIndex = 3;
            label_authorSearch.Text = "Author (contains):";
            // 
            // label_genreSearch
            // 
            label_genreSearch.AutoSize = true;
            label_genreSearch.Location = new System.Drawing.Point(17, 104);
            label_genreSearch.Name = "label_genreSearch";
            label_genreSearch.Size = new System.Drawing.Size(108, 16);
            label_genreSearch.TabIndex = 3;
            label_genreSearch.Text = "Genre (contains):";
            // 
            // label_yearSearch
            // 
            label_yearSearch.AutoSize = true;
            label_yearSearch.Location = new System.Drawing.Point(176, 104);
            label_yearSearch.Name = "label_yearSearch";
            label_yearSearch.Size = new System.Drawing.Size(39, 16);
            label_yearSearch.TabIndex = 8;
            label_yearSearch.Text = "Year:";
            // 
            // label_statusSearch
            // 
            label_statusSearch.AutoSize = true;
            label_statusSearch.Location = new System.Drawing.Point(17, 162);
            label_statusSearch.Name = "label_statusSearch";
            label_statusSearch.Size = new System.Drawing.Size(47, 16);
            label_statusSearch.TabIndex = 10;
            label_statusSearch.Text = "Status:";
            // 
            // label_yearUpdateResult
            // 
            label_yearUpdateResult.AutoSize = true;
            label_yearUpdateResult.Location = new System.Drawing.Point(20, 99);
            label_yearUpdateResult.Name = "label_yearUpdateResult";
            label_yearUpdateResult.Size = new System.Drawing.Size(39, 16);
            label_yearUpdateResult.TabIndex = 23;
            label_yearUpdateResult.Text = "Year:";
            // 
            // label_genreUpdateResult
            // 
            label_genreUpdateResult.AutoSize = true;
            label_genreUpdateResult.Location = new System.Drawing.Point(12, 72);
            label_genreUpdateResult.Name = "label_genreUpdateResult";
            label_genreUpdateResult.Size = new System.Drawing.Size(47, 16);
            label_genreUpdateResult.TabIndex = 22;
            label_genreUpdateResult.Text = "Genre:";
            // 
            // label_authorUpdateResult
            // 
            label_authorUpdateResult.AutoSize = true;
            label_authorUpdateResult.Location = new System.Drawing.Point(11, 44);
            label_authorUpdateResult.Name = "label_authorUpdateResult";
            label_authorUpdateResult.Size = new System.Drawing.Size(48, 16);
            label_authorUpdateResult.TabIndex = 18;
            label_authorUpdateResult.Text = "Author:";
            // 
            // label_titleUpdateResult
            // 
            label_titleUpdateResult.AutoSize = true;
            label_titleUpdateResult.Location = new System.Drawing.Point(23, 16);
            label_titleUpdateResult.Name = "label_titleUpdateResult";
            label_titleUpdateResult.Size = new System.Drawing.Size(36, 16);
            label_titleUpdateResult.TabIndex = 16;
            label_titleUpdateResult.Text = "Title:";
            // 
            // label_statusUpdateResult
            // 
            label_statusUpdateResult.AutoSize = true;
            label_statusUpdateResult.Location = new System.Drawing.Point(12, 130);
            label_statusUpdateResult.Name = "label_statusUpdateResult";
            label_statusUpdateResult.Size = new System.Drawing.Size(47, 16);
            label_statusUpdateResult.TabIndex = 26;
            label_statusUpdateResult.Text = "Status:";
            // 
            // label_libraryManager
            // 
            this.label_libraryManager.AutoSize = true;
            this.label_libraryManager.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_libraryManager.Location = new System.Drawing.Point(13, 13);
            this.label_libraryManager.Name = "label_libraryManager";
            this.label_libraryManager.Size = new System.Drawing.Size(338, 48);
            this.label_libraryManager.TabIndex = 0;
            this.label_libraryManager.Text = "Library Manager";
            // 
            // tabCtrl_libraryMechanics
            // 
            this.tabCtrl_libraryMechanics.Controls.Add(this.tabPage_addBook);
            this.tabCtrl_libraryMechanics.Controls.Add(this.tabPage_updateBook);
            this.tabCtrl_libraryMechanics.Controls.Add(this.tabPage_search);
            this.tabCtrl_libraryMechanics.Location = new System.Drawing.Point(21, 81);
            this.tabCtrl_libraryMechanics.Name = "tabCtrl_libraryMechanics";
            this.tabCtrl_libraryMechanics.SelectedIndex = 0;
            this.tabCtrl_libraryMechanics.Size = new System.Drawing.Size(651, 589);
            this.tabCtrl_libraryMechanics.TabIndex = 2;
            // 
            // tabPage_addBook
            // 
            this.tabPage_addBook.AutoScroll = true;
            this.tabPage_addBook.Controls.Add(this.label_addBookInstruction);
            this.tabPage_addBook.Controls.Add(this.textBox_genreAdd);
            this.tabPage_addBook.Controls.Add(this.label_addBookResult);
            this.tabPage_addBook.Controls.Add(this.button_addBook);
            this.tabPage_addBook.Controls.Add(label_yearAdd);
            this.tabPage_addBook.Controls.Add(this.nup_yearAdd);
            this.tabPage_addBook.Controls.Add(label_genreAdd);
            this.tabPage_addBook.Controls.Add(label_authorAdd);
            this.tabPage_addBook.Controls.Add(this.textBox_authorAdd);
            this.tabPage_addBook.Controls.Add(label_titleAdd);
            this.tabPage_addBook.Controls.Add(this.textBox_titleAdd);
            this.tabPage_addBook.Controls.Add(this.button_clearAddBook);
            this.tabPage_addBook.Location = new System.Drawing.Point(4, 25);
            this.tabPage_addBook.Name = "tabPage_addBook";
            this.tabPage_addBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_addBook.Size = new System.Drawing.Size(643, 560);
            this.tabPage_addBook.TabIndex = 0;
            this.tabPage_addBook.Text = "Add Book";
            this.tabPage_addBook.UseVisualStyleBackColor = true;
            // 
            // label_addBookInstruction
            // 
            this.label_addBookInstruction.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addBookInstruction.Location = new System.Drawing.Point(16, 15);
            this.label_addBookInstruction.Name = "label_addBookInstruction";
            this.label_addBookInstruction.Size = new System.Drawing.Size(238, 40);
            this.label_addBookInstruction.TabIndex = 13;
            this.label_addBookInstruction.Text = "Note: Two books cannot share both a title and author.";
            // 
            // textBox_genreAdd
            // 
            this.textBox_genreAdd.AutoCompleteCustomSource.AddRange(new string[] {
            "Fantasy",
            "Science Fiction",
            "Horror",
            "Mystery",
            "Thriller",
            "Crime",
            "Romance",
            "Historical Fiction",
            "Adventure",
            "Literary Fiction",
            "Magical Realism",
            "Dystopian",
            "Contemporary Fiction",
            "Young Adult",
            "Middle Grade",
            "Biography",
            "Autobiography",
            "Memoir",
            "Self-Help",
            "Psychology",
            "Philosophy",
            "Science",
            "Technology",
            "History",
            "Politics",
            "Economics",
            "Travel",
            "True Crime",
            "Essays",
            "Journalism",
            "Graphic Novel",
            "Comic",
            "Poetry",
            "Drama",
            "Cookbook",
            "Religion",
            "Spirituality",
            "Health & Wellness",
            "Parenting",
            "Education",
            "Textbook",
            "Short Stories",
            "Anthology"});
            this.textBox_genreAdd.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_genreAdd.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_genreAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Genre", true));
            this.textBox_genreAdd.Location = new System.Drawing.Point(70, 126);
            this.textBox_genreAdd.Name = "textBox_genreAdd";
            this.textBox_genreAdd.Size = new System.Drawing.Size(184, 22);
            this.textBox_genreAdd.TabIndex = 5;
            // 
            // booksBindingSource
            // 
            this.booksBindingSource.DataMember = "Books";
            this.booksBindingSource.DataSource = this.booksDataSet;
            // 
            // booksDataSet
            // 
            this.booksDataSet.DataSetName = "BooksDataSet";
            this.booksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label_addBookResult
            // 
            this.label_addBookResult.Location = new System.Drawing.Point(28, 194);
            this.label_addBookResult.Name = "label_addBookResult";
            this.label_addBookResult.Size = new System.Drawing.Size(226, 23);
            this.label_addBookResult.TabIndex = 12;
            // 
            // button_addBook
            // 
            this.button_addBook.Location = new System.Drawing.Point(20, 230);
            this.button_addBook.Name = "button_addBook";
            this.button_addBook.Size = new System.Drawing.Size(100, 29);
            this.button_addBook.TabIndex = 7;
            this.button_addBook.Text = "Add Book";
            this.button_addBook.UseVisualStyleBackColor = true;
            this.button_addBook.Click += new System.EventHandler(this.button_addBook_Click);
            // 
            // nup_yearAdd
            // 
            this.nup_yearAdd.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.booksBindingSource, "Year", true));
            this.nup_yearAdd.Location = new System.Drawing.Point(70, 153);
            this.nup_yearAdd.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nup_yearAdd.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nup_yearAdd.Name = "nup_yearAdd";
            this.nup_yearAdd.Size = new System.Drawing.Size(120, 22);
            this.nup_yearAdd.TabIndex = 6;
            this.nup_yearAdd.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // textBox_authorAdd
            // 
            this.textBox_authorAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Author", true));
            this.textBox_authorAdd.Location = new System.Drawing.Point(70, 95);
            this.textBox_authorAdd.Name = "textBox_authorAdd";
            this.textBox_authorAdd.Size = new System.Drawing.Size(184, 22);
            this.textBox_authorAdd.TabIndex = 4;
            // 
            // textBox_titleAdd
            // 
            this.textBox_titleAdd.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Title", true));
            this.textBox_titleAdd.Location = new System.Drawing.Point(70, 67);
            this.textBox_titleAdd.Name = "textBox_titleAdd";
            this.textBox_titleAdd.Size = new System.Drawing.Size(184, 22);
            this.textBox_titleAdd.TabIndex = 2;
            // 
            // button_clearAddBook
            // 
            this.button_clearAddBook.Location = new System.Drawing.Point(126, 230);
            this.button_clearAddBook.Name = "button_clearAddBook";
            this.button_clearAddBook.Size = new System.Drawing.Size(95, 29);
            this.button_clearAddBook.TabIndex = 8;
            this.button_clearAddBook.Text = "Clear";
            this.button_clearAddBook.UseVisualStyleBackColor = true;
            this.button_clearAddBook.Click += new System.EventHandler(this.button_clearAddBook_Click);
            // 
            // tabPage_updateBook
            // 
            this.tabPage_updateBook.Controls.Add(this.groupBox_updateResult);
            this.tabPage_updateBook.Controls.Add(this.label_updateSearchResult);
            this.tabPage_updateBook.Controls.Add(this.label_updateSearchStatus);
            this.tabPage_updateBook.Controls.Add(this.button_searchUpdate);
            this.tabPage_updateBook.Controls.Add(this.button_clearUpdate);
            this.tabPage_updateBook.Controls.Add(label_authorUpdate);
            this.tabPage_updateBook.Controls.Add(this.textBox_authorUpdate);
            this.tabPage_updateBook.Controls.Add(label_titleUpdate);
            this.tabPage_updateBook.Controls.Add(this.textBox_titleUpdate);
            this.tabPage_updateBook.Controls.Add(this.label1);
            this.tabPage_updateBook.Location = new System.Drawing.Point(4, 25);
            this.tabPage_updateBook.Name = "tabPage_updateBook";
            this.tabPage_updateBook.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_updateBook.Size = new System.Drawing.Size(643, 560);
            this.tabPage_updateBook.TabIndex = 1;
            this.tabPage_updateBook.Text = "Update/Delete Book";
            this.tabPage_updateBook.UseVisualStyleBackColor = true;
            // 
            // groupBox_updateResult
            // 
            this.groupBox_updateResult.Controls.Add(this.checkBox_deleteBook);
            this.groupBox_updateResult.Controls.Add(label_deleteBook);
            this.groupBox_updateResult.Controls.Add(this.label_performUpdateStatus);
            this.groupBox_updateResult.Controls.Add(this.button_performUpdate);
            this.groupBox_updateResult.Controls.Add(this.textBox_genreUpdateResult);
            this.groupBox_updateResult.Controls.Add(label_statusUpdateResult);
            this.groupBox_updateResult.Controls.Add(this.textBox_titleUpdateResult);
            this.groupBox_updateResult.Controls.Add(this.comboBox_statusUpdateResult);
            this.groupBox_updateResult.Controls.Add(label_titleUpdateResult);
            this.groupBox_updateResult.Controls.Add(this.textBox_authorUpdateResult);
            this.groupBox_updateResult.Controls.Add(label_authorUpdateResult);
            this.groupBox_updateResult.Controls.Add(label_yearUpdateResult);
            this.groupBox_updateResult.Controls.Add(label_genreUpdateResult);
            this.groupBox_updateResult.Controls.Add(this.nup_yearUpdateResult);
            this.groupBox_updateResult.Location = new System.Drawing.Point(22, 261);
            this.groupBox_updateResult.Name = "groupBox_updateResult";
            this.groupBox_updateResult.Size = new System.Drawing.Size(271, 265);
            this.groupBox_updateResult.TabIndex = 27;
            this.groupBox_updateResult.TabStop = false;
            this.groupBox_updateResult.Visible = false;
            // 
            // label_performUpdateStatus
            // 
            this.label_performUpdateStatus.Location = new System.Drawing.Point(23, 229);
            this.label_performUpdateStatus.Name = "label_performUpdateStatus";
            this.label_performUpdateStatus.Size = new System.Drawing.Size(226, 23);
            this.label_performUpdateStatus.TabIndex = 28;
            // 
            // button_performUpdate
            // 
            this.button_performUpdate.Location = new System.Drawing.Point(154, 184);
            this.button_performUpdate.Name = "button_performUpdate";
            this.button_performUpdate.Size = new System.Drawing.Size(95, 29);
            this.button_performUpdate.TabIndex = 28;
            this.button_performUpdate.Text = "Update";
            this.button_performUpdate.UseVisualStyleBackColor = true;
            this.button_performUpdate.Click += new System.EventHandler(this.button_performUpdate_Click);
            // 
            // textBox_genreUpdateResult
            // 
            this.textBox_genreUpdateResult.AutoCompleteCustomSource.AddRange(new string[] {
            "Fantasy",
            "Science Fiction",
            "Horror",
            "Mystery",
            "Thriller",
            "Crime",
            "Romance",
            "Historical Fiction",
            "Adventure",
            "Literary Fiction",
            "Magical Realism",
            "Dystopian",
            "Contemporary Fiction",
            "Young Adult",
            "Middle Grade",
            "Biography",
            "Autobiography",
            "Memoir",
            "Self-Help",
            "Psychology",
            "Philosophy",
            "Science",
            "Technology",
            "History",
            "Politics",
            "Economics",
            "Travel",
            "True Crime",
            "Essays",
            "Journalism",
            "Graphic Novel",
            "Comic",
            "Poetry",
            "Drama",
            "Cookbook",
            "Religion",
            "Spirituality",
            "Health & Wellness",
            "Parenting",
            "Education",
            "Textbook",
            "Short Stories",
            "Anthology"});
            this.textBox_genreUpdateResult.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.textBox_genreUpdateResult.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_genreUpdateResult.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Genre", true));
            this.textBox_genreUpdateResult.Location = new System.Drawing.Point(65, 72);
            this.textBox_genreUpdateResult.Name = "textBox_genreUpdateResult";
            this.textBox_genreUpdateResult.Size = new System.Drawing.Size(184, 22);
            this.textBox_genreUpdateResult.TabIndex = 20;
            // 
            // textBox_titleUpdateResult
            // 
            this.textBox_titleUpdateResult.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Title", true));
            this.textBox_titleUpdateResult.Location = new System.Drawing.Point(65, 13);
            this.textBox_titleUpdateResult.Name = "textBox_titleUpdateResult";
            this.textBox_titleUpdateResult.Size = new System.Drawing.Size(184, 22);
            this.textBox_titleUpdateResult.TabIndex = 17;
            // 
            // comboBox_statusUpdateResult
            // 
            this.comboBox_statusUpdateResult.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_statusUpdateResult.FormattingEnabled = true;
            this.comboBox_statusUpdateResult.Items.AddRange(new object[] {
            "available",
            "unavailable"});
            this.comboBox_statusUpdateResult.Location = new System.Drawing.Point(65, 127);
            this.comboBox_statusUpdateResult.Name = "comboBox_statusUpdateResult";
            this.comboBox_statusUpdateResult.Size = new System.Drawing.Size(121, 24);
            this.comboBox_statusUpdateResult.TabIndex = 25;
            // 
            // textBox_authorUpdateResult
            // 
            this.textBox_authorUpdateResult.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Author", true));
            this.textBox_authorUpdateResult.Location = new System.Drawing.Point(65, 41);
            this.textBox_authorUpdateResult.Name = "textBox_authorUpdateResult";
            this.textBox_authorUpdateResult.Size = new System.Drawing.Size(184, 22);
            this.textBox_authorUpdateResult.TabIndex = 19;
            // 
            // nup_yearUpdateResult
            // 
            this.nup_yearUpdateResult.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.booksBindingSource, "Year", true));
            this.nup_yearUpdateResult.Location = new System.Drawing.Point(65, 99);
            this.nup_yearUpdateResult.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nup_yearUpdateResult.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nup_yearUpdateResult.Name = "nup_yearUpdateResult";
            this.nup_yearUpdateResult.Size = new System.Drawing.Size(120, 22);
            this.nup_yearUpdateResult.TabIndex = 21;
            this.nup_yearUpdateResult.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label_updateSearchResult
            // 
            this.label_updateSearchResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_updateSearchResult.Location = new System.Drawing.Point(18, 234);
            this.label_updateSearchResult.Name = "label_updateSearchResult";
            this.label_updateSearchResult.Size = new System.Drawing.Size(127, 24);
            this.label_updateSearchResult.TabIndex = 24;
            this.label_updateSearchResult.Text = "Result:";
            // 
            // label_updateSearchStatus
            // 
            this.label_updateSearchStatus.Location = new System.Drawing.Point(19, 134);
            this.label_updateSearchStatus.Name = "label_updateSearchStatus";
            this.label_updateSearchStatus.Size = new System.Drawing.Size(226, 23);
            this.label_updateSearchStatus.TabIndex = 15;
            // 
            // button_searchUpdate
            // 
            this.button_searchUpdate.Location = new System.Drawing.Point(22, 171);
            this.button_searchUpdate.Name = "button_searchUpdate";
            this.button_searchUpdate.Size = new System.Drawing.Size(95, 29);
            this.button_searchUpdate.TabIndex = 14;
            this.button_searchUpdate.Text = "Search";
            this.button_searchUpdate.UseVisualStyleBackColor = true;
            this.button_searchUpdate.Click += new System.EventHandler(this.button_searchUpdate_Click);
            // 
            // button_clearUpdate
            // 
            this.button_clearUpdate.Location = new System.Drawing.Point(123, 171);
            this.button_clearUpdate.Name = "button_clearUpdate";
            this.button_clearUpdate.Size = new System.Drawing.Size(120, 29);
            this.button_clearUpdate.TabIndex = 13;
            this.button_clearUpdate.Text = "Clear/Cancel";
            this.button_clearUpdate.UseVisualStyleBackColor = true;
            this.button_clearUpdate.Click += new System.EventHandler(this.button_clearUpdate_Click);
            // 
            // textBox_authorUpdate
            // 
            this.textBox_authorUpdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Author", true));
            this.textBox_authorUpdate.Location = new System.Drawing.Point(73, 93);
            this.textBox_authorUpdate.Name = "textBox_authorUpdate";
            this.textBox_authorUpdate.Size = new System.Drawing.Size(169, 22);
            this.textBox_authorUpdate.TabIndex = 4;
            // 
            // textBox_titleUpdate
            // 
            this.textBox_titleUpdate.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Title", true));
            this.textBox_titleUpdate.Location = new System.Drawing.Point(73, 65);
            this.textBox_titleUpdate.Name = "textBox_titleUpdate";
            this.textBox_titleUpdate.Size = new System.Drawing.Size(169, 22);
            this.textBox_titleUpdate.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter the title and author of the book you wish to update (must use exact spellin" +
    "g):\r\n";
            // 
            // tabPage_search
            // 
            this.tabPage_search.Controls.Add(this.label_searchBookResult);
            this.tabPage_search.Controls.Add(this.checkBox_filterByYear);
            this.tabPage_search.Controls.Add(this.dgv_searchResults);
            this.tabPage_search.Controls.Add(this.label_searchResults);
            this.tabPage_search.Controls.Add(this.button_search);
            this.tabPage_search.Controls.Add(this.button_clearSearch);
            this.tabPage_search.Controls.Add(label_statusSearch);
            this.tabPage_search.Controls.Add(this.comboBox_statusSearch);
            this.tabPage_search.Controls.Add(label_yearSearch);
            this.tabPage_search.Controls.Add(this.nup_yearSearch);
            this.tabPage_search.Controls.Add(label_genreSearch);
            this.tabPage_search.Controls.Add(label_authorSearch);
            this.tabPage_search.Controls.Add(this.textBox_genreSearch);
            this.tabPage_search.Controls.Add(this.textBox_authorSearch);
            this.tabPage_search.Controls.Add(label_titleSearch);
            this.tabPage_search.Controls.Add(this.textBox_titleSearch);
            this.tabPage_search.Controls.Add(this.label_searchPrompt);
            this.tabPage_search.Location = new System.Drawing.Point(4, 25);
            this.tabPage_search.Name = "tabPage_search";
            this.tabPage_search.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_search.Size = new System.Drawing.Size(643, 560);
            this.tabPage_search.TabIndex = 3;
            this.tabPage_search.Text = "Search";
            this.tabPage_search.UseVisualStyleBackColor = true;
            // 
            // label_searchBookResult
            // 
            this.label_searchBookResult.Location = new System.Drawing.Point(18, 279);
            this.label_searchBookResult.Name = "label_searchBookResult";
            this.label_searchBookResult.Size = new System.Drawing.Size(226, 23);
            this.label_searchBookResult.TabIndex = 16;
            // 
            // checkBox_filterByYear
            // 
            this.checkBox_filterByYear.AutoSize = true;
            this.checkBox_filterByYear.Location = new System.Drawing.Point(182, 126);
            this.checkBox_filterByYear.Name = "checkBox_filterByYear";
            this.checkBox_filterByYear.Size = new System.Drawing.Size(18, 17);
            this.checkBox_filterByYear.TabIndex = 15;
            this.checkBox_filterByYear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox_filterByYear.UseVisualStyleBackColor = true;
            this.checkBox_filterByYear.CheckedChanged += new System.EventHandler(this.checkBox_filterByYear_CheckedChanged);
            // 
            // dgv_searchResults
            // 
            this.dgv_searchResults.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_searchResults.Location = new System.Drawing.Point(20, 357);
            this.dgv_searchResults.Name = "dgv_searchResults";
            this.dgv_searchResults.ReadOnly = true;
            this.dgv_searchResults.RowHeadersWidth = 51;
            this.dgv_searchResults.RowTemplate.Height = 24;
            this.dgv_searchResults.Size = new System.Drawing.Size(600, 179);
            this.dgv_searchResults.TabIndex = 14;
            // 
            // label_searchResults
            // 
            this.label_searchResults.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_searchResults.Location = new System.Drawing.Point(17, 330);
            this.label_searchResults.Name = "label_searchResults";
            this.label_searchResults.Size = new System.Drawing.Size(127, 24);
            this.label_searchResults.TabIndex = 13;
            this.label_searchResults.Text = "Results:";
            // 
            // button_search
            // 
            this.button_search.Location = new System.Drawing.Point(19, 229);
            this.button_search.Name = "button_search";
            this.button_search.Size = new System.Drawing.Size(95, 29);
            this.button_search.TabIndex = 12;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // button_clearSearch
            // 
            this.button_clearSearch.Location = new System.Drawing.Point(133, 229);
            this.button_clearSearch.Name = "button_clearSearch";
            this.button_clearSearch.Size = new System.Drawing.Size(95, 29);
            this.button_clearSearch.TabIndex = 11;
            this.button_clearSearch.Text = "Clear";
            this.button_clearSearch.UseVisualStyleBackColor = true;
            this.button_clearSearch.Click += new System.EventHandler(this.button_clearSearch_Click);
            // 
            // comboBox_statusSearch
            // 
            this.comboBox_statusSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_statusSearch.FormattingEnabled = true;
            this.comboBox_statusSearch.Items.AddRange(new object[] {
            "",
            "available",
            "unavailable"});
            this.comboBox_statusSearch.Location = new System.Drawing.Point(20, 181);
            this.comboBox_statusSearch.Name = "comboBox_statusSearch";
            this.comboBox_statusSearch.Size = new System.Drawing.Size(121, 24);
            this.comboBox_statusSearch.TabIndex = 9;
            // 
            // nup_yearSearch
            // 
            this.nup_yearSearch.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.booksBindingSource, "Year", true));
            this.nup_yearSearch.Location = new System.Drawing.Point(206, 123);
            this.nup_yearSearch.Maximum = new decimal(new int[] {
            9999,
            0,
            0,
            0});
            this.nup_yearSearch.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nup_yearSearch.Name = "nup_yearSearch";
            this.nup_yearSearch.ReadOnly = true;
            this.nup_yearSearch.Size = new System.Drawing.Size(120, 22);
            this.nup_yearSearch.TabIndex = 7;
            this.nup_yearSearch.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // textBox_genreSearch
            // 
            this.textBox_genreSearch.AutoCompleteCustomSource.AddRange(new string[] {
            "Fantasy",
            "Science Fiction",
            "Horror",
            "Mystery",
            "Thriller",
            "Crime",
            "Romance",
            "Historical Fiction",
            "Adventure",
            "Literary Fiction",
            "Magical Realism",
            "Dystopian",
            "Contemporary Fiction",
            "Young Adult",
            "Middle Grade",
            "Biography",
            "Autobiography",
            "Memoir",
            "Self-Help",
            "Psychology",
            "Philosophy",
            "Science",
            "Technology",
            "History",
            "Politics",
            "Economics",
            "Travel",
            "True Crime",
            "Essays",
            "Journalism",
            "Graphic Novel",
            "Comic",
            "Poetry",
            "Drama",
            "Cookbook",
            "Religion",
            "Spirituality",
            "Health & Wellness",
            "Parenting",
            "Education",
            "Textbook",
            "Short Stories",
            "Anthology"});
            this.textBox_genreSearch.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox_genreSearch.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.textBox_genreSearch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Title", true));
            this.textBox_genreSearch.Location = new System.Drawing.Point(20, 123);
            this.textBox_genreSearch.Name = "textBox_genreSearch";
            this.textBox_genreSearch.Size = new System.Drawing.Size(147, 22);
            this.textBox_genreSearch.TabIndex = 4;
            // 
            // textBox_authorSearch
            // 
            this.textBox_authorSearch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Title", true));
            this.textBox_authorSearch.Location = new System.Drawing.Point(179, 68);
            this.textBox_authorSearch.Name = "textBox_authorSearch";
            this.textBox_authorSearch.Size = new System.Drawing.Size(147, 22);
            this.textBox_authorSearch.TabIndex = 4;
            // 
            // textBox_titleSearch
            // 
            this.textBox_titleSearch.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.booksBindingSource, "Title", true));
            this.textBox_titleSearch.Location = new System.Drawing.Point(20, 68);
            this.textBox_titleSearch.Name = "textBox_titleSearch";
            this.textBox_titleSearch.Size = new System.Drawing.Size(147, 22);
            this.textBox_titleSearch.TabIndex = 2;
            // 
            // label_searchPrompt
            // 
            this.label_searchPrompt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label_searchPrompt.Location = new System.Drawing.Point(16, 14);
            this.label_searchPrompt.Name = "label_searchPrompt";
            this.label_searchPrompt.Size = new System.Drawing.Size(127, 24);
            this.label_searchPrompt.TabIndex = 0;
            this.label_searchPrompt.Text = "Search Filters:";
            // 
            // booksTableAdapter
            // 
            this.booksTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BooksTableAdapter = this.booksTableAdapter;
            this.tableAdapterManager.UpdateOrder = Personal_Library_Manager_Program.BooksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label_deleteBook
            // 
            label_deleteBook.AutoSize = true;
            label_deleteBook.Location = new System.Drawing.Point(5, 157);
            label_deleteBook.Name = "label_deleteBook";
            label_deleteBook.Size = new System.Drawing.Size(54, 16);
            label_deleteBook.TabIndex = 29;
            label_deleteBook.Text = "Delete?";
            // 
            // checkBox_deleteBook
            // 
            this.checkBox_deleteBook.AutoSize = true;
            this.checkBox_deleteBook.Location = new System.Drawing.Point(65, 156);
            this.checkBox_deleteBook.Name = "checkBox_deleteBook";
            this.checkBox_deleteBook.Size = new System.Drawing.Size(18, 17);
            this.checkBox_deleteBook.TabIndex = 30;
            this.checkBox_deleteBook.UseVisualStyleBackColor = true;
            // 
            // form_libraryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 682);
            this.Controls.Add(this.tabCtrl_libraryMechanics);
            this.Controls.Add(this.label_libraryManager);
            this.Name = "form_libraryManager";
            this.Text = "Library Manager";
            this.tabCtrl_libraryMechanics.ResumeLayout(false);
            this.tabPage_addBook.ResumeLayout(false);
            this.tabPage_addBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_yearAdd)).EndInit();
            this.tabPage_updateBook.ResumeLayout(false);
            this.tabPage_updateBook.PerformLayout();
            this.groupBox_updateResult.ResumeLayout(false);
            this.groupBox_updateResult.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nup_yearUpdateResult)).EndInit();
            this.tabPage_search.ResumeLayout(false);
            this.tabPage_search.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_searchResults)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nup_yearSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_libraryManager;
        private System.Windows.Forms.TabControl tabCtrl_libraryMechanics;
        private System.Windows.Forms.TabPage tabPage_addBook;
        private System.Windows.Forms.TabPage tabPage_updateBook;
        private System.Windows.Forms.TabPage tabPage_search;
        private System.Windows.Forms.Button button_clearAddBook;
        private BooksDataSet booksDataSet;
        private System.Windows.Forms.BindingSource booksBindingSource;
        private BooksDataSetTableAdapters.BooksTableAdapter booksTableAdapter;
        private BooksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textBox_titleAdd;
        private System.Windows.Forms.TextBox textBox_authorAdd;
        private System.Windows.Forms.NumericUpDown nup_yearAdd;
        private System.Windows.Forms.Button button_addBook;
        private System.Windows.Forms.Label label_addBookResult;
        private System.Windows.Forms.TextBox textBox_genreAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_authorUpdate;
        private System.Windows.Forms.TextBox textBox_titleUpdate;
        private System.Windows.Forms.TextBox textBox_titleSearch;
        private System.Windows.Forms.Label label_searchPrompt;
        private System.Windows.Forms.TextBox textBox_authorSearch;
        private System.Windows.Forms.TextBox textBox_genreSearch;
        private System.Windows.Forms.NumericUpDown nup_yearSearch;
        private System.Windows.Forms.ComboBox comboBox_statusSearch;
        private System.Windows.Forms.Button button_search;
        private System.Windows.Forms.Button button_clearSearch;
        private System.Windows.Forms.Label label_searchResults;
        private System.Windows.Forms.DataGridView dgv_searchResults;
        private System.Windows.Forms.CheckBox checkBox_filterByYear;
        private System.Windows.Forms.Label label_addBookInstruction;
        private System.Windows.Forms.Button button_searchUpdate;
        private System.Windows.Forms.Button button_clearUpdate;
        private System.Windows.Forms.Label label_searchBookResult;
        private System.Windows.Forms.Label label_updateSearchStatus;
        private System.Windows.Forms.Label label_updateSearchResult;
        private System.Windows.Forms.TextBox textBox_genreUpdateResult;
        private System.Windows.Forms.NumericUpDown nup_yearUpdateResult;
        private System.Windows.Forms.TextBox textBox_authorUpdateResult;
        private System.Windows.Forms.TextBox textBox_titleUpdateResult;
        private System.Windows.Forms.ComboBox comboBox_statusUpdateResult;
        private System.Windows.Forms.GroupBox groupBox_updateResult;
        private System.Windows.Forms.Label label_performUpdateStatus;
        private System.Windows.Forms.Button button_performUpdate;
        private System.Windows.Forms.CheckBox checkBox_deleteBook;
    }
}

