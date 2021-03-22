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
    public partial class Form1 : Form 
    {
        //int index;
        static List<Person> player = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }

        public Form1(Person p)
        {
            InitializeComponent();
            this.SetVisibleCore(true);
            player.Add(p);
        }

        public Form1(List<Person> list_person)
        {
            player = list_person;
            this.SetVisibleCore(false);
            this.Close();
        }
        public void Form1_newRecord(Person p)
        { 
            //player[index] = p;
            this.SetVisibleCore(false);
            this.Close();
        }
        private void Button1_Click(object sender, EventArgs e)
        {
            String temp_id = textBox1.Text;
            String temp_password = textBox2.Text;
            Person p_check=new Person();
            Boolean b = false;
            //int counter=0;
            foreach (Person p in player)
            {
                if (temp_id.Equals(p.getId())&&temp_password.Equals(p.getId()))
                {
                    p_check = p;
                    b = true;
                }
                //counter++;
            }

            if(b)
            {
                MessageBox.Show("玩家(ID:"+p_check.getId()+")，登入成功");
                Form4 form4 = new Form4(p_check);
                form4.Show();
                //index = counter-1;
            }
            else
            {
                MessageBox.Show("帳號或密碼錯誤,請重新輸入");
            }

        }
        private void Button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.SetVisibleCore(false);
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void 玩家資訊ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.user_info(player);
            form3.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void 排行榜ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
