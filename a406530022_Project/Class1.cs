using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a406530022_Project
{
    public class Class1
    {
    }

    public class Person
    {
        private String name;
        private String Id;
        private String Password;
        private Date date;
        private int highScore;
        public Person()
        {
            name = "unknown";
            Id = "unknown";
            Password = "unknown";
            date = new Date();
        }
        public Person(String n,String i, String p, Date d,int score)
        {
            name = n;
            Id = i;
            Password = p;
            date = d;
            highScore = score;
        }
        public Person(String i,String p)
        {
            Id = i;
            Password = p;
        }
        public void setName(String n)
        {
            name = n;
        }
        public String getName()
        {
            return name;
        }
        public void setId(String i)
        {
            Id = i;
        }
        public String getId()
        {
            return Id;
        }
        public void setPassword(String p)
        {
            Password = p;
        }
        public String getPassword()
        {
            return Password;
        }
        public void setDate(Date d)
        {
            date = d;
        }
        public Date getDate()
        {
            if (date != null)
            {
                return new Date(date.getYear(), date.getMonth(), date.getDay());
            }
            else
            {
                return null;
            }
        }
        public string show()
        {
            string str = "名字 : " + name + "\r\n";
            str += "帳號 : " + Id + "\r\n";
            str += "密碼 : " + Password + "\r\n";
            str += "生日 : " + date.show();
            return str;
        }

        public int getHighScore()
        {
            return highScore;
        }
        public void setHighScore(int score)
        {
            this.highScore = score;
        }
    } 
}
