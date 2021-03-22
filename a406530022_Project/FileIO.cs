using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;
using System.Collections;

namespace a406530022_Project
{
    public class FileIO
    {
        List<Person> players = new List<Person>();
        String[] load_name;
        String[] load_ID ;
        string[] load_Password ;
        string[] load_Date ;
        string[] load_score;

        List<Person> list;
        public FileIO()
        {
            
        }

        public FileIO(List<Person> list_in)
        {
            list = list_in;
        }
        public void output_file()
        {
            string s="";
            s += "<Persons>";
            string[] name = new string[50];
            string[] id = new string[50];
            string[] pw = new string[50];
            string[] date = new string[50];
            int[] score = new int[50];
            int counter=0;
            foreach (Person p in list)
            {
                name[counter] = p.getName();
                id[counter] = p.getId();
                pw[counter] = p.getPassword();
                date[counter] = p.getDate().show();
                score[counter] = p.getHighScore();
                counter++;
            }
            for(int i=0;i<counter;i++)
            {
                s += "<Person>";
                s += "<Name>";
                s += name[i] ;
                s += "</Name>";
                s += "<ID>";
                s += id[i] ;
                s += "</ID>";
                s += "<PW>";
                s += pw[i] ;
                s += "</PW>";
                s += "<Date>";
                s += date[i];
                s += "</Date>";
                s += "<Score>";
                s += Convert.ToString(score[i]);
                s += "</Score>";
                s += "</Person>";
            }
            s += "</Persons>";
            XmlDocument xml_writer = new XmlDocument();
            xml_writer.LoadXml(s);
            xml_writer.Save("Persons.xml");
        }
        public string[] getName()
        {
            return this.load_name;
        }
        public string[] getID()
        {
            return this.load_ID;
        }
        public string[] getPassword()
        {
            return this.load_Password;
        }
        public string[] getDate()
        {
            return this.load_Date;
        }
        public string[] getScore()
        {
            return this.load_score;
        }

        public void input_file()
        {
            XmlDocument xmltxt = new XmlDocument();
            xmltxt.Load("Persons.xml");
            XmlNodeList NodeList1 = xmltxt.SelectNodes("Persons/Person");

            load_name = new string[50];
            load_ID = new string[50];
            load_Password = new string[50];
            load_Date = new string[50];
            load_score = new string[50];
            int counter = 0;
            foreach (XmlNode OneNode in NodeList1)
            {
                foreach (XmlNode node in OneNode)
                {
                    String StrAttrName = node.Name;
                    //String StrAttrName = attr.Name.ToString();
                    if(StrAttrName.Equals("Name"))
                    {
                        load_name[counter] = node.InnerText;
                    }
                    else if(StrAttrName.Equals("ID"))
                    {
                        load_ID[counter] = node.InnerText;
                    }
                    else if(StrAttrName.Equals("PW"))
                    {
                        load_Password[counter] = node.InnerText;
                    }
                    else if(StrAttrName.Equals("Date"))
                    {
                        load_Date[counter] = node.InnerText;
                    }
                    else if (StrAttrName.Equals("Score"))
                    {
                        load_score[counter] = node.InnerText;
                    }
                }

                String[] date = new string[3];
                date = load_Date[counter].Split('-');
                Date d = new Date(int.Parse(date[0]), int.Parse(date[1]), int.Parse(date[2]));

                Person p = new Person(load_name[counter],load_ID[counter],load_Password[counter],d,int.Parse(load_score[counter]));
                players.Add(p);
                counter++;
            }
        }

        public List<Person> return_existing_User()
        {
            return players;
        }
    }

}
