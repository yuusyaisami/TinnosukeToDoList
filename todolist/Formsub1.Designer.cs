namespace todolist
{
    partial class Formsub1
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
            this.CancelBtn = new System.Windows.Forms.Button();
            this.TextBox = new System.Windows.Forms.TextBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.MenuTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CancelBtn
            // 
            this.CancelBtn.Font = new System.Drawing.Font("BIZ UDPゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.CancelBtn.Location = new System.Drawing.Point(53, 129);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(150, 60);
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "キャンセル";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelBtn_Click);
            // 
            // TextBox
            // 
            this.TextBox.Font = new System.Drawing.Font("BIZ UDPゴシック", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TextBox.Location = new System.Drawing.Point(53, 93);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(377, 30);
            this.TextBox.TabIndex = 1;
            this.TextBox.TextChanged += new System.EventHandler(this.TextBox_TextChanged);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Font = new System.Drawing.Font("BIZ UDPゴシック", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SaveBtn.Location = new System.Drawing.Point(280, 129);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(150, 60);
            this.SaveBtn.TabIndex = 2;
            this.SaveBtn.Text = "保存";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // MenuTitle
            // 
            this.MenuTitle.AutoSize = true;
            this.MenuTitle.Font = new System.Drawing.Font("F910新コミック体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MenuTitle.Location = new System.Drawing.Point(80, 38);
            this.MenuTitle.Name = "MenuTitle";
            this.MenuTitle.Size = new System.Drawing.Size(138, 42);
            this.MenuTitle.TabIndex = 3;
            this.MenuTitle.Text = "新規作成";
            // 
            // Formsub1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(482, 228);
            this.Controls.Add(this.MenuTitle);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.CancelBtn);
            this.MaximumSize = new System.Drawing.Size(500, 275);
            this.MinimumSize = new System.Drawing.Size(500, 275);
            this.Name = "Formsub1";
            this.Text = "Formsub1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Formsub1Closing);
            this.Load += new System.EventHandler(this.Formsub1Loading);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CancelBtn;
        private System.Windows.Forms.TextBox TextBox;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Label MenuTitle;
    }
}