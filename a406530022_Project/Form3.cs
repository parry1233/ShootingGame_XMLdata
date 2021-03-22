using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a406530022_Project
{
    public partial class Form3 : Form
    {
        List<Person> list;
        public Form3()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void user_info(List<Person> temp_list)
        {
            list = temp_list;
            String s = "姓名" + "\t" + "帳號" + "\t" + "密碼" + "\t" + "生日" + "\t"+ "最高紀錄" +"\r\n";
            foreach (Person p in list)
            {
                s += p.getName() + "\t" + p.getId() + "\t" + p.getPassword() + "\t" + p.getDate().show()+"\t"+p.getHighScore()+ "\r\n";
            }
            textBox1.Text = s;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            FileIO io = new FileIO(list);
            io.output_file();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            String[] name = new string[50];
            String[] id = new string[50];
            String[] pw = new string[50];
            String[] date = new string[50];
            String[] highScore = new string[50];
            String[] score = new string[50];

            FileIO io = new FileIO();
            io.input_file();
            name = io.getName();
            id = io.getID();
            pw = io.getPassword();
            date = io.getDate();
            highScore = io.getScore();
            list = io.return_existing_User();
            Form1 form1 = new Form1(list);

            String s = "姓名" + "\t" + "帳號" + "\t" + "密碼" + "\t" + "生日" + "\t"+"最高紀錄"+"\r\n";
            for (int i=0;i<name.Length;i++)
            {
                s +=  name[i]+ "\t" + id[i] + "\t" + pw[i] + "\t" + date[i] + "\t" + highScore[i] + "\r\n";
            }
            textBox1.Text = s;

            MessageBox.Show("讀取檔案成功!已使用最新儲存檔案");
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
