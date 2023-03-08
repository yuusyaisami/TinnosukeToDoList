namespace todolist
{
    partial class FormMain
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.Todolist = new System.Windows.Forms.ListBox();
            this.TodolistRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.CreateItemTodolist = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeNameTodolist = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteTodolist = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.ListBox3 = new System.Windows.Forms.ListBox();
            this.ListBox3RightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MovetoListBox3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MovetoUpListBox3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MovetoLeftListBox3 = new System.Windows.Forms.ToolStripMenuItem();
            this.MovetoDownListBox3 = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateItemListBox3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeNameListBox3 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteListBox3 = new System.Windows.Forms.ToolStripMenuItem();
            this.ListBox1 = new System.Windows.Forms.ListBox();
            this.ListBox1RightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MovetoListBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MovetoUpListBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MovetoRightListBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.MovetoDownListBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateItemListBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeNameListBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteListBox1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ListBox2 = new System.Windows.Forms.ListBox();
            this.ListBox2RightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.MovetoListBox2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MovetoUpListBox2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MovetoRightListBox2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MovetoLeftListBox2 = new System.Windows.Forms.ToolStripMenuItem();
            this.MovetoDownListBox2 = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateItemListBox2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ChangeNameListBox2 = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteListBox2 = new System.Windows.Forms.ToolStripMenuItem();
            this.TodoTitle = new System.Windows.Forms.Label();
            this.Debugtext = new System.Windows.Forms.Label();
            this.monthCalendar = new System.Windows.Forms.MonthCalendar();
            this.LanguageCheckBoxJP = new System.Windows.Forms.CheckBox();
            this.LanguageCheckBoxENG = new System.Windows.Forms.CheckBox();
            this.TodolistRightClick.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.ListBox3RightClick.SuspendLayout();
            this.ListBox1RightClick.SuspendLayout();
            this.ListBox2RightClick.SuspendLayout();
            this.SuspendLayout();
            // 
            // Todolist
            // 
            this.Todolist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Todolist.ContextMenuStrip = this.TodolistRightClick;
            this.Todolist.Font = new System.Drawing.Font("BIZ UDPゴシック", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Todolist.FormattingEnabled = true;
            this.Todolist.ItemHeight = 18;
            this.Todolist.Location = new System.Drawing.Point(0, 0);
            this.Todolist.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Todolist.Name = "Todolist";
            this.Todolist.Size = new System.Drawing.Size(248, 508);
            this.Todolist.TabIndex = 0;
            this.Todolist.SelectedIndexChanged += new System.EventHandler(this.Todolist_SelectedIndexChanged);
            // 
            // TodolistRightClick
            // 
            this.TodolistRightClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TodolistRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateItemTodolist,
            this.ChangeNameTodolist,
            this.DeleteTodolist});
            this.TodolistRightClick.Name = "TodolistRightClick";
            this.TodolistRightClick.Size = new System.Drawing.Size(139, 76);
            this.TodolistRightClick.Text = "Todolist";
            // 
            // CreateItemTodolist
            // 
            this.CreateItemTodolist.Name = "CreateItemTodolist";
            this.CreateItemTodolist.Size = new System.Drawing.Size(138, 24);
            this.CreateItemTodolist.Text = "新規作成";
            this.CreateItemTodolist.Click += new System.EventHandler(this.CreateItemTodolist_Click);
            // 
            // ChangeNameTodolist
            // 
            this.ChangeNameTodolist.Name = "ChangeNameTodolist";
            this.ChangeNameTodolist.Size = new System.Drawing.Size(138, 24);
            this.ChangeNameTodolist.Text = "名前変更";
            this.ChangeNameTodolist.Click += new System.EventHandler(this.ChangeNameTodolist_Click);
            // 
            // DeleteTodolist
            // 
            this.DeleteTodolist.Name = "DeleteTodolist";
            this.DeleteTodolist.Size = new System.Drawing.Size(138, 24);
            this.DeleteTodolist.Text = "削除";
            this.DeleteTodolist.Click += new System.EventHandler(this.DeleteTodolist_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.3321F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.00185F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.3321F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 6.00185F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.3321F));
            this.tableLayoutPanel1.Controls.Add(this.ListBox3, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.ListBox1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.ListBox2, 2, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(276, 78);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(938, 646);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // ListBox3
            // 
            this.ListBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox3.ContextMenuStrip = this.ListBox3RightClick;
            this.ListBox3.Font = new System.Drawing.Font("BIZ UDPゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ListBox3.FormattingEnabled = true;
            this.ListBox3.ItemHeight = 20;
            this.ListBox3.Location = new System.Drawing.Point(665, 2);
            this.ListBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBox3.Name = "ListBox3";
            this.tableLayoutPanel1.SetRowSpan(this.ListBox3, 2);
            this.ListBox3.Size = new System.Drawing.Size(270, 624);
            this.ListBox3.TabIndex = 2;
            this.ListBox3.TabStop = false;
            // 
            // ListBox3RightClick
            // 
            this.ListBox3RightClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ListBox3RightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MovetoListBox3,
            this.CreateItemListBox3,
            this.ChangeNameListBox3,
            this.DeleteListBox3});
            this.ListBox3RightClick.Name = "ListBox1RightClick";
            this.ListBox3RightClick.Size = new System.Drawing.Size(139, 100);
            this.ListBox3RightClick.Text = "ListBox";
            // 
            // MovetoListBox3
            // 
            this.MovetoListBox3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MovetoUpListBox3,
            this.MovetoLeftListBox3,
            this.MovetoDownListBox3});
            this.MovetoListBox3.Name = "MovetoListBox3";
            this.MovetoListBox3.Size = new System.Drawing.Size(138, 24);
            this.MovetoListBox3.Text = "移動";
            // 
            // MovetoUpListBox3
            // 
            this.MovetoUpListBox3.Name = "MovetoUpListBox3";
            this.MovetoUpListBox3.Size = new System.Drawing.Size(149, 26);
            this.MovetoUpListBox3.Text = "上に移動";
            this.MovetoUpListBox3.Click += new System.EventHandler(this.MovetoUpListBox3_Click);
            // 
            // MovetoLeftListBox3
            // 
            this.MovetoLeftListBox3.Name = "MovetoLeftListBox3";
            this.MovetoLeftListBox3.Size = new System.Drawing.Size(149, 26);
            this.MovetoLeftListBox3.Text = "左に移動";
            this.MovetoLeftListBox3.Click += new System.EventHandler(this.MovetoLeftListBox3_Click);
            // 
            // MovetoDownListBox3
            // 
            this.MovetoDownListBox3.Name = "MovetoDownListBox3";
            this.MovetoDownListBox3.Size = new System.Drawing.Size(149, 26);
            this.MovetoDownListBox3.Text = "下に移動";
            this.MovetoDownListBox3.Click += new System.EventHandler(this.MovetoDownListBox3_Click);
            // 
            // CreateItemListBox3
            // 
            this.CreateItemListBox3.Name = "CreateItemListBox3";
            this.CreateItemListBox3.Size = new System.Drawing.Size(138, 24);
            this.CreateItemListBox3.Text = "新規作成";
            this.CreateItemListBox3.Click += new System.EventHandler(this.CreateItemListBox3_Click);
            // 
            // ChangeNameListBox3
            // 
            this.ChangeNameListBox3.Name = "ChangeNameListBox3";
            this.ChangeNameListBox3.Size = new System.Drawing.Size(138, 24);
            this.ChangeNameListBox3.Text = "名前変更";
            this.ChangeNameListBox3.Click += new System.EventHandler(this.ChangeNameListBox3_Click);
            // 
            // DeleteListBox3
            // 
            this.DeleteListBox3.Name = "DeleteListBox3";
            this.DeleteListBox3.Size = new System.Drawing.Size(138, 24);
            this.DeleteListBox3.Text = "削除";
            this.DeleteListBox3.Click += new System.EventHandler(this.DeleteListBox3_Click);
            // 
            // ListBox1
            // 
            this.ListBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox1.ContextMenuStrip = this.ListBox1RightClick;
            this.ListBox1.Font = new System.Drawing.Font("BIZ UDPゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ListBox1.FormattingEnabled = true;
            this.ListBox1.ItemHeight = 20;
            this.ListBox1.Location = new System.Drawing.Point(3, 2);
            this.ListBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBox1.Name = "ListBox1";
            this.tableLayoutPanel1.SetRowSpan(this.ListBox1, 2);
            this.ListBox1.Size = new System.Drawing.Size(269, 624);
            this.ListBox1.TabIndex = 3;
            this.ListBox1.TabStop = false;
            // 
            // ListBox1RightClick
            // 
            this.ListBox1RightClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ListBox1RightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MovetoListBox1,
            this.CreateItemListBox1,
            this.ChangeNameListBox1,
            this.DeleteListBox1});
            this.ListBox1RightClick.Name = "ListBox1RightClick";
            this.ListBox1RightClick.Size = new System.Drawing.Size(139, 100);
            this.ListBox1RightClick.Text = "ListBox";
            // 
            // MovetoListBox1
            // 
            this.MovetoListBox1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MovetoUpListBox1,
            this.MovetoRightListBox1,
            this.MovetoDownListBox1});
            this.MovetoListBox1.Name = "MovetoListBox1";
            this.MovetoListBox1.Size = new System.Drawing.Size(138, 24);
            this.MovetoListBox1.Text = "移動";
            // 
            // MovetoUpListBox1
            // 
            this.MovetoUpListBox1.Name = "MovetoUpListBox1";
            this.MovetoUpListBox1.Size = new System.Drawing.Size(224, 26);
            this.MovetoUpListBox1.Text = "上に移動";
            this.MovetoUpListBox1.Click += new System.EventHandler(this.MovetoUpListBox1_Click);
            // 
            // MovetoRightListBox1
            // 
            this.MovetoRightListBox1.Name = "MovetoRightListBox1";
            this.MovetoRightListBox1.Size = new System.Drawing.Size(224, 26);
            this.MovetoRightListBox1.Text = "右に移動";
            this.MovetoRightListBox1.Click += new System.EventHandler(this.MovetoRightListBox1_Click);
            // 
            // MovetoDownListBox1
            // 
            this.MovetoDownListBox1.Name = "MovetoDownListBox1";
            this.MovetoDownListBox1.Size = new System.Drawing.Size(224, 26);
            this.MovetoDownListBox1.Text = "下に移動";
            this.MovetoDownListBox1.Click += new System.EventHandler(this.MovetoDownListBox1_Click);
            // 
            // CreateItemListBox1
            // 
            this.CreateItemListBox1.Name = "CreateItemListBox1";
            this.CreateItemListBox1.Size = new System.Drawing.Size(138, 24);
            this.CreateItemListBox1.Text = "新規作成";
            this.CreateItemListBox1.Click += new System.EventHandler(this.CreateItemListBox1_Click);
            // 
            // ChangeNameListBox1
            // 
            this.ChangeNameListBox1.Name = "ChangeNameListBox1";
            this.ChangeNameListBox1.Size = new System.Drawing.Size(138, 24);
            this.ChangeNameListBox1.Text = "名前変更";
            this.ChangeNameListBox1.Click += new System.EventHandler(this.ChangeNameListBox1_Click);
            // 
            // DeleteListBox1
            // 
            this.DeleteListBox1.Name = "DeleteListBox1";
            this.DeleteListBox1.Size = new System.Drawing.Size(138, 24);
            this.DeleteListBox1.Text = "削除";
            this.DeleteListBox1.Click += new System.EventHandler(this.DeleteListBox1_Click);
            // 
            // ListBox2
            // 
            this.ListBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListBox2.ContextMenuStrip = this.ListBox2RightClick;
            this.ListBox2.Font = new System.Drawing.Font("BIZ UDPゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ListBox2.FormattingEnabled = true;
            this.ListBox2.ItemHeight = 20;
            this.ListBox2.Location = new System.Drawing.Point(334, 2);
            this.ListBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ListBox2.Name = "ListBox2";
            this.tableLayoutPanel1.SetRowSpan(this.ListBox2, 2);
            this.ListBox2.Size = new System.Drawing.Size(269, 624);
            this.ListBox2.TabIndex = 1;
            this.ListBox2.TabStop = false;
            // 
            // ListBox2RightClick
            // 
            this.ListBox2RightClick.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ListBox2RightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MovetoListBox2,
            this.CreateItemListBox2,
            this.ChangeNameListBox2,
            this.DeleteListBox2});
            this.ListBox2RightClick.Name = "ListBox1RightClick";
            this.ListBox2RightClick.Size = new System.Drawing.Size(139, 100);
            this.ListBox2RightClick.Text = "ListBox";
            // 
            // MovetoListBox2
            // 
            this.MovetoListBox2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MovetoUpListBox2,
            this.MovetoRightListBox2,
            this.MovetoLeftListBox2,
            this.MovetoDownListBox2});
            this.MovetoListBox2.Name = "MovetoListBox2";
            this.MovetoListBox2.Size = new System.Drawing.Size(138, 24);
            this.MovetoListBox2.Text = "移動";
            // 
            // MovetoUpListBox2
            // 
            this.MovetoUpListBox2.Name = "MovetoUpListBox2";
            this.MovetoUpListBox2.Size = new System.Drawing.Size(224, 26);
            this.MovetoUpListBox2.Text = "上に移動";
            this.MovetoUpListBox2.Click += new System.EventHandler(this.MovetoUpListBox2_Click);
            // 
            // MovetoRightListBox2
            // 
            this.MovetoRightListBox2.Name = "MovetoRightListBox2";
            this.MovetoRightListBox2.Size = new System.Drawing.Size(224, 26);
            this.MovetoRightListBox2.Text = "右に移動";
            this.MovetoRightListBox2.Click += new System.EventHandler(this.MovetoRightListBox2_Click);
            // 
            // MovetoLeftListBox2
            // 
            this.MovetoLeftListBox2.Name = "MovetoLeftListBox2";
            this.MovetoLeftListBox2.Size = new System.Drawing.Size(224, 26);
            this.MovetoLeftListBox2.Text = "左に移動";
            this.MovetoLeftListBox2.Click += new System.EventHandler(this.MovetoLeftListBox2_Click);
            // 
            // MovetoDownListBox2
            // 
            this.MovetoDownListBox2.Name = "MovetoDownListBox2";
            this.MovetoDownListBox2.Size = new System.Drawing.Size(224, 26);
            this.MovetoDownListBox2.Text = "下に移動";
            this.MovetoDownListBox2.Click += new System.EventHandler(this.MovetoDownListBox2_Click);
            // 
            // CreateItemListBox2
            // 
            this.CreateItemListBox2.Name = "CreateItemListBox2";
            this.CreateItemListBox2.Size = new System.Drawing.Size(138, 24);
            this.CreateItemListBox2.Text = "新規作成";
            this.CreateItemListBox2.Click += new System.EventHandler(this.CreateItemListBox2_Click);
            // 
            // ChangeNameListBox2
            // 
            this.ChangeNameListBox2.Name = "ChangeNameListBox2";
            this.ChangeNameListBox2.Size = new System.Drawing.Size(138, 24);
            this.ChangeNameListBox2.Text = "名前変更";
            this.ChangeNameListBox2.Click += new System.EventHandler(this.ChangeNameListBox2_Click);
            // 
            // DeleteListBox2
            // 
            this.DeleteListBox2.Name = "DeleteListBox2";
            this.DeleteListBox2.Size = new System.Drawing.Size(138, 24);
            this.DeleteListBox2.Text = "削除";
            this.DeleteListBox2.Click += new System.EventHandler(this.DeleteListBox2_Click);
            // 
            // TodoTitle
            // 
            this.TodoTitle.AutoSize = true;
            this.TodoTitle.Font = new System.Drawing.Font("BIZ UDPゴシック", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TodoTitle.Location = new System.Drawing.Point(285, 31);
            this.TodoTitle.Name = "TodoTitle";
            this.TodoTitle.Size = new System.Drawing.Size(178, 33);
            this.TodoTitle.TabIndex = 2;
            this.TodoTitle.Text = "maintask";
            // 
            // Debugtext
            // 
            this.Debugtext.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Debugtext.AutoSize = true;
            this.Debugtext.Location = new System.Drawing.Point(1144, 729);
            this.Debugtext.Name = "Debugtext";
            this.Debugtext.Size = new System.Drawing.Size(76, 15);
            this.Debugtext.TabIndex = 7;
            this.Debugtext.Text = "DebugText";
            // 
            // monthCalendar
            // 
            this.monthCalendar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.monthCalendar.Location = new System.Drawing.Point(0, 517);
            this.monthCalendar.Name = "monthCalendar";
            this.monthCalendar.TabIndex = 8;
            // 
            // LanguageCheckBoxJP
            // 
            this.LanguageCheckBoxJP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LanguageCheckBoxJP.AutoSize = true;
            this.LanguageCheckBoxJP.Location = new System.Drawing.Point(984, 729);
            this.LanguageCheckBoxJP.Name = "LanguageCheckBoxJP";
            this.LanguageCheckBoxJP.Size = new System.Drawing.Size(74, 19);
            this.LanguageCheckBoxJP.TabIndex = 9;
            this.LanguageCheckBoxJP.Text = "日本語";
            this.LanguageCheckBoxJP.UseVisualStyleBackColor = true;
            this.LanguageCheckBoxJP.CheckedChanged += new System.EventHandler(this.LanguageCheckBoxJP_CheckedChanged);
            // 
            // LanguageCheckBoxENG
            // 
            this.LanguageCheckBoxENG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.LanguageCheckBoxENG.AutoSize = true;
            this.LanguageCheckBoxENG.Location = new System.Drawing.Point(1064, 729);
            this.LanguageCheckBoxENG.Name = "LanguageCheckBoxENG";
            this.LanguageCheckBoxENG.Size = new System.Drawing.Size(73, 19);
            this.LanguageCheckBoxENG.TabIndex = 10;
            this.LanguageCheckBoxENG.Text = "English";
            this.LanguageCheckBoxENG.UseVisualStyleBackColor = true;
            this.LanguageCheckBoxENG.CheckedChanged += new System.EventHandler(this.LanguageCheckBoxENG_CheckedChanged);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 753);
            this.Controls.Add(this.LanguageCheckBoxENG);
            this.Controls.Add(this.LanguageCheckBoxJP);
            this.Controls.Add(this.monthCalendar);
            this.Controls.Add(this.Debugtext);
            this.Controls.Add(this.TodoTitle);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.Todolist);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMain";
            this.Text = "Todolist";
            this.TodolistRightClick.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ListBox3RightClick.ResumeLayout(false);
            this.ListBox1RightClick.ResumeLayout(false);
            this.ListBox2RightClick.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Todolist;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox ListBox2;
        private System.Windows.Forms.ListBox ListBox3;
        private System.Windows.Forms.ListBox ListBox1;
        private System.Windows.Forms.Label TodoTitle;
        private System.Windows.Forms.ContextMenuStrip TodolistRightClick;
        private System.Windows.Forms.ToolStripMenuItem CreateItemTodolist;
        private System.Windows.Forms.ToolStripMenuItem ChangeNameTodolist;
        private System.Windows.Forms.ToolStripMenuItem DeleteTodolist;
        private System.Windows.Forms.ContextMenuStrip ListBox1RightClick;
        private System.Windows.Forms.ToolStripMenuItem MovetoListBox1;
        private System.Windows.Forms.ToolStripMenuItem MovetoUpListBox1;
        private System.Windows.Forms.ToolStripMenuItem MovetoRightListBox1;
        private System.Windows.Forms.ToolStripMenuItem MovetoDownListBox1;
        private System.Windows.Forms.ToolStripMenuItem CreateItemListBox1;
        private System.Windows.Forms.ToolStripMenuItem ChangeNameListBox1;
        private System.Windows.Forms.ToolStripMenuItem DeleteListBox1;
        private System.Windows.Forms.Label Debugtext;
        private System.Windows.Forms.ContextMenuStrip ListBox2RightClick;
        private System.Windows.Forms.ToolStripMenuItem MovetoListBox2;
        private System.Windows.Forms.ToolStripMenuItem MovetoUpListBox2;
        private System.Windows.Forms.ToolStripMenuItem MovetoRightListBox2;
        private System.Windows.Forms.ToolStripMenuItem MovetoDownListBox2;
        private System.Windows.Forms.ToolStripMenuItem CreateItemListBox2;
        private System.Windows.Forms.ToolStripMenuItem ChangeNameListBox2;
        private System.Windows.Forms.ToolStripMenuItem DeleteListBox2;
        private System.Windows.Forms.ContextMenuStrip ListBox3RightClick;
        private System.Windows.Forms.ToolStripMenuItem MovetoListBox3;
        private System.Windows.Forms.ToolStripMenuItem MovetoUpListBox3;
        private System.Windows.Forms.ToolStripMenuItem MovetoLeftListBox3;
        private System.Windows.Forms.ToolStripMenuItem MovetoDownListBox3;
        private System.Windows.Forms.ToolStripMenuItem CreateItemListBox3;
        private System.Windows.Forms.ToolStripMenuItem ChangeNameListBox3;
        private System.Windows.Forms.ToolStripMenuItem DeleteListBox3;
        private System.Windows.Forms.ToolStripMenuItem MovetoLeftListBox2;
        private System.Windows.Forms.MonthCalendar monthCalendar;
        private System.Windows.Forms.CheckBox LanguageCheckBoxJP;
        private System.Windows.Forms.CheckBox LanguageCheckBoxENG;
    }
}

