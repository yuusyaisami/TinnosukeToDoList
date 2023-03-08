using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace todolist
{
    public partial class Formsub1 : Form
    {
        public static string save, cancel;
        public FormMain formMain;
        string Enptystring = "";
        public Formsub1()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            formMain.NameDete = TextBox.Text;
            TextBox.Text = Enptystring;
            this.Hide();
        }

        private void Formsub1Closing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // フォームの閉じる処理をキャンセルする
                e.Cancel = true;
                //フォームをHideさせる
                this.Hide();
            }
        }

        private void Formsub1Loading(object sender, EventArgs e)
        {
            this.Text = MenuTitle.Text = FormMain.MenuName;
            CancelBtn.Text = cancel;
            SaveBtn.Text = save;
        }
    }
}
