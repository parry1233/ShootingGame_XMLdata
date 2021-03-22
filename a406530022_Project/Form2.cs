using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace a406530022_Project
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void Label2_Click(object sender, EventArgs e)
        {
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            String name_set = textBox1.Text;
            String id_set = textBox2.Text;
            String password_set = textBox3.Text;
            int y = Convert.ToInt32(textBox4.Text);
            int m = Convert.ToInt32(textBox5.Text);
            int d = Convert.ToInt32(textBox6.Text);
            Date date = new Date(y, m, d);
            Person p = new Person(name_set,id_set, password_set,date,0);
            
            DialogResult check = MessageBox.Show(p.show(), "確認資料", MessageBoxButtons.OKCancel);
            if (check.Equals(DialogResult.OK))
            {
                Form1 form = new Form1(p);
                Close();
            }
            else
            {
                MessageBox.Show("請重新輸入資料", "取消", MessageBoxButtons.OK);
            }
        }
        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
