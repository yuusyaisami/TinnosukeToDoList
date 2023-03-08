using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace todolist
{
    public partial class FormMain : Form
    {
        //language Pack

        string[] LanguagePack = { "Move to left", "Move to right", "Move to up", "Move to down", "NewCreate", "Name change", "Delete", "Textbox is empty.", "That text has already been used.", "that text is not available.", "Move" };
        //すべての文字が入るジャグ配列とその他の宣言
        string[][] listdete = new string[255][];
        string ListDetePath = "ListDete.txt";
        bool ListNumber1, ListNumber2, ListNumber3, ListNumber4;
        Formsub1 formsub1;

        //formsub1とのデータのやり取りに使う変数
        public static int MenuIndex;
        public static string MenuName;


        public FormMain()
        {
            formsub1 = new Formsub1();
            formsub1.formMain = this;
            InitializeComponent();
            //配列listdeteをnullで初期化するサイズは255 x 100で作る
            for (int a = 0; a<listdete.Length; a++)
            {
                listdete[a] = new string[100];
                for (int b = 0; b < listdete[a].Length; b++)
                {
                    listdete[a][b] = null;
                }
            }
            //配列の中にデータを収容する
            //StreamReaderは読み取り専用sr.ReadLine()は一行読み込んだら自動で改行する
            StreamReader sr = new StreamReader(ListDetePath);
            string todolistdete;
            int i = 0, j = -1;
            while (sr.Peek() != -1)
            {
                todolistdete = sr.ReadLine();
                if (todolistdete == "0")
                {
                    i = 0;
                    j++;
                    listdete[j][i] = todolistdete;
                    i++;
                    todolistdete = sr.ReadLine();
                    Todolist.Items.Add(todolistdete);
                    listdete[j][i] = todolistdete;
                    i++;
                    //ここまではtodotitleと行の数値を上げている
                    //もし0になったら次のプロジェクトを読み込むことになっている
                }
                else if (todolistdete == "1")
                {
                    Numbers("ListNumber1");
                    listdete[j][i] = todolistdete;
                    i++;
                    //1はListBox1のデータを表してるので、２が来たらその次の文はListBox1の中のデータであるその他同じ
                }
                else if (todolistdete == "2")
                {
                    Numbers("ListNumber2");
                    listdete[j][i] = todolistdete;
                    i++;
                }
                else if (todolistdete == "3")
                {
                    Numbers("ListNumber3");
                    listdete[j][i] = todolistdete;
                    i++;
                }
                else if (todolistdete == "4")
                {
                    Numbers("ListNumber4");
                    listdete[j][i] = todolistdete;
                    i++;
                }
                else
                {//1,2,3の時のデータをそれぞれに分ける
                    if (ListNumber1)
                    {
                        listdete[j][i] = todolistdete;
                        i++;
                    }
                    if (ListNumber2)
                    {
                        listdete[j][i] = todolistdete;
                        i++;
                    }
                    if (ListNumber3)
                    {
                        listdete[j][i] = todolistdete;
                        i++;
                    }
                    if (ListNumber4)
                    {
                        listdete[j][i] = todolistdete;
                        i++;
                    }
                }

            }
            sr.Close();
            //ファイルを閉じる


        }
        //-------------------------Todolistのメニュー---------------------------------------------
        private void Todolist_SelectedIndexChanged(object sender, EventArgs e)
        {
            PrinttoListBoxs(-1, Todolist.SelectedIndex);
        }

        private void CreateItemTodolist_Click(object sender, EventArgs e)
        {
            MenuName = LanguagePack[4];
            formsub1.Show();
            MenuIndex = 11;
            Use = "Todolist";
        }

        private void ChangeNameTodolist_Click(object sender, EventArgs e)
        {
            if (Todolist.SelectedIndex != -1)
            {
                MenuName = LanguagePack[5];
                formsub1.Show();
                MenuIndex = 12;
                Use = "Todolist";
            }
        }

        private void DeleteTodolist_Click(object sender, EventArgs e)
        {
            if (Todolist.SelectedIndex != -1)
            {
                ListDeteDelete(Todolist.SelectedIndex, "Todolist");
            }
        }
        //----------------------------ListBoxのメニュー------------------------------------
        private void MovetoUpListBox1_Click(object sender, EventArgs e)
        {
            MovetoFanction("Up", "ListBox1");
        }

        private void MovetoRightListBox1_Click(object sender, EventArgs e)
        {
            MovetoFanction("Right", "ListBox1");
        }

        private void MovetoDownListBox1_Click(object sender, EventArgs e)
        {
            MovetoFanction("Down", "ListBox1");
        }

        private void CreateItemListBox1_Click(object sender, EventArgs e)
        {
            if (Todolist.SelectedIndex != -1)
            {
                MenuName = LanguagePack[4];
                formsub1.Show();
                MenuIndex = 21;
                Use = "ListBox";
            }
        }

        private void ChangeNameListBox1_Click(object sender, EventArgs e)
        {
            if (Todolist.SelectedIndex != -1 && ListBox1.SelectedIndex != -1)
            {
                MenuName = LanguagePack[5];
                formsub1.Show();
                MenuIndex = 22;
                Use = "ListBox";
            }
        }

        private void DeleteListBox1_Click(object sender, EventArgs e)
        {
            ListDeteDelete(Todolist.SelectedIndex, "ListBox1");
        }

        private void CreateItemListBox2_Click(object sender, EventArgs e)
        {
            if (Todolist.SelectedIndex != -1)
            {
                MenuName = LanguagePack[4];
                formsub1.Show();
                MenuIndex = 31;
                Use = "ListBox";
            }
        }

        private void ChangeNameListBox2_Click(object sender, EventArgs e)
        {
            if (Todolist.SelectedIndex != -1 && ListBox2.SelectedIndex != -1)
            {
                MenuName = LanguagePack[5];
                formsub1.Show();
                MenuIndex = 32;
                Use = "ListBox";
            }
        }

        private void DeleteListBox2_Click(object sender, EventArgs e)
        {
            ListDeteDelete(Todolist.SelectedIndex, "ListBox2");
        }

        private void MovetoUpListBox2_Click(object sender, EventArgs e)
        {
            MovetoFanction("Up", "ListBox2");
        }

        private void MovetoRightListBox2_Click(object sender, EventArgs e)
        {
            MovetoFanction("Right", "ListBox2");
        }

        private void MovetoLeftListBox2_Click(object sender, EventArgs e)
        {
            MovetoFanction("Left", "ListBox2");
        }

        private void MovetoDownListBox2_Click(object sender, EventArgs e)
        {
            MovetoFanction("Down", "ListBox2");
        }

        private void CreateItemListBox3_Click(object sender, EventArgs e)
        {
            if (Todolist.SelectedIndex != -1)
            {
                MenuName = LanguagePack[4];
                formsub1.Show();
                MenuIndex = 41;
                Use = "ListBox";
            }
        }

        private void ChangeNameListBox3_Click(object sender, EventArgs e)
        {
            if (Todolist.SelectedIndex != -1 && ListBox3.SelectedIndex != -1)
            {
                MenuName = LanguagePack[5];
                formsub1.Show();
                MenuIndex = 42;
                Use = "ListBox";
            }
        }
        private void DeleteListBox3_Click(object sender, EventArgs e)
        {
            ListDeteDelete(Todolist.SelectedIndex, "ListBox3");
        }

        private void MovetoUpListBox3_Click(object sender, EventArgs e)
        {
            MovetoFanction("Up", "ListBox3");
        }

        private void MovetoLeftListBox3_Click(object sender, EventArgs e)
        {
            MovetoFanction("Left", "ListBox3");
        }

        private void MovetoDownListBox3_Click(object sender, EventArgs e)
        {
            MovetoFanction("Down", "ListBox3");
        }

        //Formsub1とのget/setアクセサ
        public string namedete,Use;
        public string NameDete
        {
            set
            {
                namedete = value;
                namedete = namedete.Trim();
                if (String.IsNullOrEmpty(namedete) == false)//namedeteが存在しないかつ空白だったら、実行しない
                {
                    if (ChackName(namedete, "Todolist") && ChackName(namedete, "value") && Use == "Todolist")//名前がかぶらないかChack (Todolistのグループ)
                    {
                        if (MenuIndex == 11) //Todolistの新規作成
                        {
                            ListDeteAdd(0, "Todolist", namedete);
                        }
                        else if (MenuIndex == 12)//Todolistの名前変更
                        {
                            listdete[Todolist.SelectedIndex][1] = namedete;
                            PrinttoListBoxs(0, Todolist.SelectedIndex);
                            SavetoTextFile();
                        }
                        Debugtext.Text = "CreateTodolist";
                    }
                    else if (ChackName(namedete, "ListBox") && ChackName(namedete, "value") && Use == "ListBox")//ListBoxのグループ
                    {
                        if (MenuIndex == 21)//ListBox1の新規作成
                        {
                            ListDeteAdd(Todolist.SelectedIndex, "ListBox1", namedete);
                        }
                        else if (MenuIndex == 22)//ListBox1の名前変更
                        {
                            if (ListBox1.SelectedIndex != -1)
                            {
                                listdete[Todolist.SelectedIndex][ListBox1.SelectedIndex + 3] = namedete;
                                PrinttoListBoxs(0, Todolist.SelectedIndex);
                                SavetoTextFile();
                            }
                        }
                        else if (MenuIndex == 31)//ListBox2の新規作成
                        {
                            ListDeteAdd(Todolist.SelectedIndex, "ListBox2", namedete);
                        }
                        else if (MenuIndex == 32)//ListBox2の名前変更
                        {
                            if (ListBox2.SelectedIndex != -1)
                            {
                                int i;
                                for (i = 0; listdete[Todolist.SelectedIndex][i] != "2"; i++) { }
                                listdete[Todolist.SelectedIndex][ListBox2.SelectedIndex + i] = namedete;
                                PrinttoListBoxs(0, Todolist.SelectedIndex);
                                SavetoTextFile();
                            }

                        }
                        else if (MenuIndex == 41)//ListBox3の新規作成
                        {
                            ListDeteAdd(Todolist.SelectedIndex, "ListBox3", namedete);
                        }
                        else if (MenuIndex == 42)//ListBox3の名前変更
                        {
                            if (ListBox3.SelectedIndex != -1)
                            {
                                int i;
                                for (i = 0; listdete[Todolist.SelectedIndex][i] != "3"; i++) { }
                                listdete[Todolist.SelectedIndex][ListBox3.SelectedIndex + i] = namedete;
                                PrinttoListBoxs(0, Todolist.SelectedIndex);
                                SavetoTextFile();
                            }

                        }
                    }
                    else if (ChackName(namedete, "ListBox") == false )
                    {
                        MessageBox.Show(LanguagePack[8]);
                    }
                    else
                    {
                        MessageBox.Show(LanguagePack[9]);
                    }
                }
                else MessageBox.Show(LanguagePack[7]);
            }
            get
            {
                return namedete;
            }
        }
        //ここまでイベントハンドラ
        //-----------------------------------------------------------------------------
        private void Numbers(string numb)
        {   //ListNumberの処理をまとめたもの

            if (numb == "ListNumber1")
            {
                ListNumber1 = true;
                ListNumber2 = false;
                ListNumber3 = false;
                ListNumber4 = false;
            }
            if (numb == "ListNumber2")
            {
                ListNumber1 = false;
                ListNumber2 = true;
                ListNumber3 = false;
                ListNumber4 = false;
            }
            if (numb == "ListNumber3")
            {
                ListNumber1 = false;
                ListNumber2 = false;
                ListNumber3 = true;
                ListNumber4 = false;
            }
            if (numb == "ListNumber4")
            {
                ListNumber1 = false;
                ListNumber2 = false;
                ListNumber3 = false;
                ListNumber4 = true;
            }
            if (numb == "Alltrue")
            {
                ListNumber1 = true;
                ListNumber2 = true;
                ListNumber3 = true;
                ListNumber4 = true;
            }
            if (numb == "Allfalse")
            {
                ListNumber1 = false;
                ListNumber2 = false;
                ListNumber3 = false;
                ListNumber4 = false;
            }

        }
        private void SavetoTextFile()
        {
            FileStream fs = new FileStream(ListDetePath, FileMode.Open);
            fs.SetLength(0);
            fs.Close();
            //データをすべて消した後ファイルを閉じる
            StreamWriter sw = new StreamWriter(ListDetePath);
            //書き込み専用
            int b;
            for (int c = 0; listdete[c][1] != null; c++)
            {
                for (b = 0; listdete[c][b] != null; b++)
                {
                    sw.WriteLine(listdete[c][b]);
                }
            }
            sw.Close();
            //ファイルにListDete配列のデータを書き込むWriteLineは自動で改行する
        }

        private void PrinttoListBoxs(int a = -1, int SelectedIndex = 0)
        {   //引数は更新するListBoxの値　初期値は-1　※-1はすべて更新

            int index;
            //Todolistが選択されているかチェックする
            if (-1 != SelectedIndex)
            {
                int i = 0;
                index = SelectedIndex;
                TodoTitle.Text = listdete[index][1];

                if (a == 1) ListBox1.Items.Clear();
                else if (a == 2) ListBox2.Items.Clear();
                else if (a == 3) ListBox3.Items.Clear();
                else
                {
                    ListBox1.Items.Clear();
                    ListBox2.Items.Clear();
                    ListBox3.Items.Clear();
                }

                Numbers("Allfalse");
                //Numbers()でListNumberをすべて初期化
                for (i = 0; null != listdete[index][i];)
                {
                    if (listdete[index][i] == "0")
                    {
                        i++;

                        if (a == 0)
                        {
                            Todolist.Items.Clear();
                            for (int j = 0; listdete[j][1] != null; j++)
                            {
                                Todolist.Items.Add(listdete[j][1]);
                                Debugtext.Text = "実行されました";
                            }
                        }

                    }
                    else if (listdete[index][i] == "1")
                    {
                        Numbers("ListNumber1");
                        i++;
                    }
                    else if (listdete[index][i] == "2")
                    {
                        Numbers("ListNumber2");
                        i++;
                    }
                    else if (listdete[index][i] == "3")
                    {
                        Numbers("ListNumber3");
                        i++;
                    }
                    else if (listdete[index][i] == "4")
                    {
                        Numbers("ListNumber4");
                        i++;
                    }
                    else
                    {
                        if (ListNumber1)
                        {
                            if (a == 1 || a == -1) ListBox1.Items.Add(listdete[index][i]);
                            i++;

                        }
                        else if (ListNumber2)
                        {
                            if (a == 2 || a == -1) ListBox2.Items.Add(listdete[index][i]);
                            i++;

                        }
                        else if (ListNumber3)
                        {
                            if (a == 3 || a == -1) ListBox3.Items.Add(listdete[index][i]);
                            i++;
                        }
                        /*else if (ListNumber4)
                        {
                            if (a == 4 || a == -1) DetailsTodolist.AppendText(listdete[index][i]);
                            i++;
                        }*/
                        else i++;

                    }
                    //配列のデータをlistに表示する、選択されてるtodolistのデータがlistBoxに表示される

                }
            }

        }

        private void LanguageCheckBoxJP_CheckedChanged(object sender, EventArgs e)
        {
            if (LanguageCheckBoxJP.Checked == true)
            {
                Debugtext.Text = "Japanese";
                LanguageFanction("JP");
                Formsub1.save = "保存";
                Formsub1.cancel = "キャンセル";
            }
            else if(LanguageCheckBoxENG.Checked == true)
            {
                Debugtext.Text = "English";
                LanguageFanction("ENG");
                Formsub1.save = "save";
                Formsub1.cancel = "cancel";
            }
            else
            {
                Debugtext.Text = "English";
                LanguageFanction("ENG");
                Formsub1.save = "save";
                Formsub1.cancel = "cancel";
            }
            CreateItemTodolist.Text = CreateItemListBox1.Text = CreateItemListBox2.Text = CreateItemListBox3.Text = LanguagePack[4];
            ChangeNameTodolist.Text = ChangeNameListBox1.Text = ChangeNameListBox2.Text = ChangeNameListBox3.Text = LanguagePack[5];
            DeleteTodolist.Text= DeleteListBox1.Text = DeleteListBox2.Text = DeleteListBox3.Text = LanguagePack[6];

            MovetoListBox1.Text = MovetoListBox2.Text = MovetoListBox3.Text = LanguagePack[10];
            MovetoUpListBox1.Text = MovetoUpListBox2.Text = MovetoUpListBox3.Text = LanguagePack[2];
            MovetoDownListBox1.Text = MovetoDownListBox2.Text = MovetoDownListBox3.Text = LanguagePack[3];
            MovetoRightListBox1.Text = MovetoRightListBox2.Text = LanguagePack[0];
            MovetoLeftListBox2.Text = MovetoLeftListBox3.Text = LanguagePack[1];


        }

        private void LanguageCheckBoxENG_CheckedChanged(object sender, EventArgs e)
        {
            if (LanguageCheckBoxJP.Checked == true && LanguageCheckBoxENG.Checked == true)
            {
                Debugtext.Text = "English";
                LanguageFanction("ENG");
                Formsub1.save = "save";
                Formsub1.cancel = "cancel";
            }
            else if (LanguageCheckBoxENG.Checked == true)
            {
                Debugtext.Text = "English";
                LanguageFanction("ENG");
                Formsub1.save = "save";
                Formsub1.cancel = "cancel";
            }
            else if(LanguageCheckBoxJP.Checked == true)
            {
                Debugtext.Text = "Japanese";
                LanguageFanction("JP");
                Formsub1.save = "保存";
                Formsub1.cancel = "キャンセル";
            }
            else
            {
                Debugtext.Text = "English";
                LanguageFanction("ENG");
                Formsub1.save = "save";
                Formsub1.cancel = "cancel";
            }
            CreateItemTodolist.Text = CreateItemListBox1.Text = CreateItemListBox2.Text = CreateItemListBox3.Text = LanguagePack[4];
            ChangeNameTodolist.Text = ChangeNameListBox1.Text = ChangeNameListBox2.Text = ChangeNameListBox3.Text = LanguagePack[5];
            DeleteTodolist.Text= DeleteListBox1.Text = DeleteListBox2.Text = DeleteListBox3.Text = LanguagePack[6];

            MovetoListBox1.Text = MovetoListBox2.Text = MovetoListBox3.Text = LanguagePack[10];
            MovetoUpListBox1.Text = MovetoUpListBox2.Text = MovetoUpListBox3.Text = LanguagePack[2];
            MovetoDownListBox1.Text = MovetoDownListBox2.Text = MovetoDownListBox3.Text = LanguagePack[3];
            MovetoRightListBox1.Text = MovetoRightListBox2.Text = LanguagePack[0];
            MovetoLeftListBox2.Text = MovetoLeftListBox3.Text = LanguagePack[1];
            ChangeNameListBox1.Text = ChangeNameListBox2.Text = ChangeNameListBox3.Text = LanguagePack[5];  
        }
        void LanguageFanction(string Language)
        {
            if(Language == "ENG")
            {
                LanguagePack[0] = "Move to left";
                LanguagePack[1] = "Move to right";
                LanguagePack[2] = "Move to up";
                LanguagePack[3] = "Move to down";
                LanguagePack[4] = "New Create";
                LanguagePack[5] = "Name Change";
                LanguagePack[6] = "Delete";
                LanguagePack[7] = "Textbox is empty";
                LanguagePack[8] = "That text has already been used.";
                LanguagePack[9] = "that text is not available.";
                LanguagePack[10]= "Move";
            }
            else
            {
                LanguagePack[0] = "右へ移動";
                LanguagePack[1] = "左へ移動";
                LanguagePack[2] = "上へ移動";
                LanguagePack[3] = "下へ移動";
                LanguagePack[4] = "新規作成";
                LanguagePack[5] = "名前変更";
                LanguagePack[6] = "削除";
                LanguagePack[7] = "テキストボックスは空です";
                LanguagePack[8] = "そのテキストは既に存在します";
                LanguagePack[9] = "そのテキストは使用できません";
                LanguagePack[10]= "移動";
            }
        }

        bool ChackName(string Chack, string Listname)
        {

                if (Listname =="Todolist")
                {
                    for (int i = 0; listdete[i][1] != null; i++) if (Chack == listdete[i][1]) return false;
                }
                else if (Listname == "ListBox")
                {
                    if(Todolist.SelectedIndex != -1)
                    {
                        for (int j = 3; listdete[Todolist.SelectedIndex][j] != null; j++)
                        {
                            if (Chack == listdete[Todolist.SelectedIndex][j]) return false;
                        }
                    }
                }
                else if (Listname == "value")
                {
                    Debugtext.Text = Chack;
                    for (int a = 0; a < 10; a++)
                    {
                        if (Chack == a.ToString()) return false;
                    }

                }
                return true;
        }

        

        void ListDeteAdd(int y = 0, string Place = "ListBox1", string Addstring = "NoSetting")
        { //listdeteに文字を追加する関数 y は行数 Place は列（正確にはlistの場所) Addstringは追加する名前
            int dete = 0, j;
            if (Place == "Todolist")
            {
                for (int i = 0; listdete[i][1] != null; i++) dete = i + 1;
                listdete[dete][0] = "0";
                listdete[dete][1] = Addstring;
                for (int a = 1; a < 5; a++) listdete[dete][a + 1] = a.ToString();
                Todolist.Items.Add(Addstring);
            }
            else
            {
                //placeの最後を読み取る
                for (int i = 0; listdete[y][i] != null; i++) dete = i + 1;
                for (j = dete; ; j--)
                {
                    listdete[y][j] = listdete[y][j - 1];
                    if (listdete[y][j] == "2" && Place == "ListBox1") break;
                    if (listdete[y][j] == "3" && Place == "ListBox2") break;
                    if (listdete[y][j] == "4" && Place == "ListBox3") break;
                    if (listdete[y][j] == null && Place == "DetailsTodolist") break;
                }
                if (Place == "ListBox1" || Place == "ListBox2" || Place == "ListBox3") listdete[y][j - 1] = Addstring;
                else if (Place == "DetailsTodolist") listdete[y][j] = Addstring + "\n";
            }
            SavetoTextFile();
            if(Place == "Todolist") PrinttoListBoxs(0, Todolist.SelectedIndex);
            PrinttoListBoxs(-1, Todolist.SelectedIndex);
        }
        void ListDeteDelete(int rowsvalue = 0, string Place = "ListBox1")
        {//rowsが行 columsが列 基本的にrowsvalueにtodolist.SelectedIndexをいれ、columsvalueにはListBox.SelectedIndexを入れる
            if (Place == "Todolist")
            {
                if(rowsvalue != -1)
                {
                    for (int i = 0; listdete[rowsvalue][i] != null; i++)
                    {
                        listdete[rowsvalue][i] = null;
                    }
                    int a = 0;
                    for (; ; a++)
                    {
                        for (int b = 0; b < 99; b++)
                        {
                            listdete[rowsvalue + a][b] = listdete[rowsvalue + a + 1][b];
                        }
                        if (listdete[rowsvalue + a][0] == null) break;
                    }
                }
            }

            else
            {
                
                int a,columns = 0;
                string listbox = "2";
                if (Place == "ListBox1")
                {
                    listbox = "1";
                    columns = ListBox1.SelectedIndex;
                }
                if (Place == "ListBox2")
                {
                    listbox = "2";
                    columns = ListBox2.SelectedIndex;
                }
                if (Place == "ListBox3")
                {
                    listbox = "3";
                    columns = ListBox3.SelectedIndex;
                }
                if (columns != -1)
                {
                    for (a = 1; listdete[rowsvalue][a - 1] != listbox; a++) { }
                    Debugtext.Text = listdete[rowsvalue][a + columns];
                    listdete[rowsvalue][a + columns] = null;
                    for (int i = 0; i < 99 - (a + 1 + i); i++)
                    {
                        listdete[rowsvalue][columns + i + a]  = listdete[rowsvalue][columns + i + a + 1];
                    }
                }
            }
            if (Place == "Todolist")
            {
                PrinttoListBoxs(0, 0);
            }
            if (Todolist.SelectedIndex != -1)
            {
                PrinttoListBoxs(-1, Todolist.SelectedIndex);
            }
            SavetoTextFile();
        }
        void MovetoFanction(string direction, string ListType)
        {//Up ,Down, Right, Left は direction Todolist, ListBox1,2,3はListType
            int tdindex = Todolist.SelectedIndex;
            if (direction == "Up")
            {
                if (ListType == "Todolist")
                {
                    if (Todolist.SelectedItems != null && tdindex != -1 && tdindex != 0)
                    {
                        string[] temp = new string[255];

                        for (int i = 0; i < 99; i++)
                        {
                            temp[i] = listdete[tdindex - 1][i];
                            listdete[tdindex - 1][i] = listdete[tdindex][i];
                            listdete[tdindex][i] = temp[i];
                        }
                    }
                }
                else
                {

                    if (Todolist.SelectedItems != null && tdindex != -1)
                    {
                        string temp;
                        int index = ListBox1.SelectedIndex;
                        if (ListType == "ListBox1" && ListBox1.SelectedIndex != 0 && ListBox1.Items != null && ListBox1.SelectedIndex != -1)
                        {
                            index = ListBox1.SelectedIndex;
                            temp = listdete[tdindex][index + 3];
                            listdete[tdindex][index + 3] = listdete[tdindex][index + 2];
                            listdete[tdindex][index + 2] = temp;
                        }
                        if (ListType == "ListBox2" && ListBox2.Items != null && ListBox2.SelectedIndex != -1 && ListBox2.SelectedIndex != 0)
                        {
                            int i;
                            for (i = 1; listdete[Todolist.SelectedIndex][i - 1] != "2"; i++) { }
                            index = ListBox2.SelectedIndex;
                            if (listdete[tdindex][index - 1 + i] != "3")
                            {
                                temp = listdete[tdindex][index - 1 + i];
                                listdete[tdindex][index - 1 + i] = listdete[tdindex][index + i];
                                listdete[tdindex][index + i] = temp;
                            }
                        }
                        if (ListType == "ListBox3" && ListBox3.Items != null && ListBox3.SelectedIndex != -1 && ListBox3.SelectedIndex != 0)
                        {
                            int i;
                            for (i = 1; listdete[tdindex][i - 1] != "3"; i++) { }
                            index = ListBox3.SelectedIndex;
                            if (listdete[tdindex][index - 1 + i] != "4")
                            {
                                temp = listdete[tdindex][index - 1 + i];
                                listdete[tdindex][index - 1 + i] = listdete[tdindex][index + i];
                                listdete[tdindex][index + i] = temp;
                            }
                        }
                    }

                }

            }
            else if (direction =="Down")
            {
                if (ListType == "Todolist")
                {
                    if (Todolist.SelectedItems != null && tdindex != -1 && listdete[tdindex + 1][0] != null)
                    {
                        string[] temp1 = new string[255];
                        for (int i = 0; i < 99; i++)
                        {
                            temp1[i] = listdete[tdindex + 1][i];
                            listdete[tdindex + 1][i] = listdete[tdindex][i];
                            listdete[tdindex][i] = temp1[i];
                        }
                    }
                }
                else
                {

                    if (Todolist.SelectedItems != null && tdindex != -1)
                    {
                        string temp2;
                        int index = ListBox1.SelectedIndex;
                        if (ListType == "ListBox1" && listdete[tdindex][index + 4] != "2" && ListBox1.Items != null && ListBox1.SelectedIndex != -1)
                        {
                            index = ListBox1.SelectedIndex;
                            temp2 = listdete[tdindex][index + 3];
                            listdete[tdindex][index + 3] = listdete[tdindex][index + 4];
                            listdete[tdindex][index + 4] = temp2;
                        }
                        if (ListType == "ListBox2" && ListBox2.Items != null && ListBox2.SelectedIndex != -1)
                        {
                            int i;
                            for (i = 1; listdete[tdindex][i - 1] != "2"; i++) { }
                            index = ListBox2.SelectedIndex;
                            if (listdete[tdindex][index + 1 + i] != "3")
                            {
                                temp2 = listdete[tdindex][index + 1 + i];
                                listdete[tdindex][index + 1 + i] = listdete[tdindex][index + i];
                                listdete[tdindex][index + i] = temp2;
                            }
                        }
                        if (ListType == "ListBox3" && ListBox3.Items != null && ListBox3.SelectedIndex != -1)
                        {
                            int i;
                            for (i = 1; listdete[tdindex][i - 1] != "3"; i++) { }
                            index = ListBox3.SelectedIndex;
                            if (listdete[tdindex][index + 1 + i] != "4")
                            {
                                temp2 = listdete[tdindex][index + 1 + i];
                                listdete[tdindex][index + 1 + i] = listdete[tdindex][index + i];
                                listdete[tdindex][index + i] = temp2;
                            }
                        }
                    }
                }
            }


            else if (direction == "Right")
            {
                if(ListType == "ListBox1")
                {
                    if (Todolist.SelectedItems != null && tdindex != -1 && ListBox1.SelectedIndex != -1)
                    {
                        if(ListBox1.Items != null && ListBox1.SelectedIndex != -1)
                        {
                            string temp = listdete[tdindex][ListBox1.SelectedIndex + 3];
                            for(int a = ListBox1.SelectedIndex + 3; ; a++)
                            {
                                listdete[tdindex][a] = listdete[tdindex][a + 1];
                                if (listdete[tdindex][a] == null) break;
                            }
                            int c,d;
                            for( c = 0; listdete[tdindex][c] != null; c++){ }
                            for (d = c; ; d--)
                            {
                                listdete[tdindex][d] = listdete[tdindex][d - 1];
                                if(listdete[tdindex][d] == "3") break;
                            }
                            Debugtext.Text = d.ToString();
                            listdete[tdindex][d - 1] = temp;



                        }
                    }
                }
                if(ListType == "ListBox2")
                {
                    if (Todolist.SelectedItems != null && tdindex != -1 && ListBox2.SelectedIndex != -1)
                    {
                        if (ListBox2.Items != null && ListBox2.SelectedIndex != -1)
                        {
                            int i;
                            for (i = 1; listdete[tdindex][i - 1] != "2"; i++) { }
                            string temp = listdete[tdindex][i + ListBox2.SelectedIndex];
                            for (int a = i; ; a++)
                            {
                                listdete[tdindex][ListBox2.SelectedIndex + a] = listdete[tdindex][ListBox2.SelectedIndex + a + 1];
                                if (listdete[tdindex][ListBox2.SelectedIndex + a] == null) break;
                            }
                            int c, d;
                            for (c = 0; listdete[tdindex][c] != null; c++) { }
                            for (d = c; ; d--)
                            {
                                listdete[tdindex][d] = listdete[tdindex][d - 1];
                                if (listdete[tdindex][d] == "4") break;
                            }
                            Debugtext.Text = d.ToString();
                            listdete[tdindex][d - 1] = temp;
                        }
                    }
                }
            }
            else if (direction == "Left")
            {
                if(ListType == "ListBox2") 
                {
                    if (ListBox2.Items != null && ListBox2.SelectedIndex != -1)
                    {
                        int i;
                        for (i = 1; listdete[tdindex][i - 1] != "2"; i++) { }
                        string temp = listdete[tdindex][i + ListBox2.SelectedIndex];
                        for (int a = i; ; a++)
                        {
                            listdete[tdindex][ListBox2.SelectedIndex + a] = listdete[tdindex][ListBox2.SelectedIndex + a + 1];
                            if (listdete[tdindex][ListBox2.SelectedIndex + a] == null) break;
                        }
                        int c, d;
                        for (c = 0; listdete[tdindex][c] != null; c++) { }
                        for (d = c; ; d--)
                        {
                            listdete[tdindex][d] = listdete[tdindex][d - 1];
                            if (listdete[tdindex][d] == "2") break;
                        }
                        Debugtext.Text = d.ToString();
                        listdete[tdindex][d - 1] = temp;
                    }
                }
                if(ListType == "ListBox3")
                {
                    if (ListBox3.Items != null && ListBox3.SelectedIndex != -1)
                    {
                        int i;
                        for (i = 1; listdete[tdindex][i - 1] != "3"; i++) { }
                        string temp = listdete[tdindex][i + ListBox3.SelectedIndex];
                        for (int a = i; ; a++)
                        {
                            listdete[tdindex][ListBox3.SelectedIndex + a] = listdete[tdindex][ListBox3.SelectedIndex + a + 1];
                            if (listdete[tdindex][ListBox3.SelectedIndex + a] == null) break;
                        }
                        int c, d;
                        for (c = 0; listdete[tdindex][c] != null; c++) { }
                        for (d = c; ; d--)
                        {
                            listdete[tdindex][d] = listdete[tdindex][d - 1];
                            if (listdete[tdindex][d] == "3") break;
                        }
                        Debugtext.Text = d.ToString();
                        listdete[tdindex][d - 1] = temp;
                    }
                }
            }
            if(Todolist.SelectedIndex != -1 && ListType == "Todolist")
            {
                PrinttoListBoxs(0,Todolist.SelectedIndex);
            }
            PrinttoListBoxs(-1,Todolist.SelectedIndex);
            SavetoTextFile();
        }

    }
}

