using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace 电影数据库
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        static string connstr = ConfigurationManager.ConnectionStrings["myApp.Properties.Settings.myConnectionString"].ConnectionString.ToString();
        MySqlConnection conn = new MySqlConnection(connstr);



        static void StartTheSearch(MySqlConnection conn)
        {
           ;
            using (conn)
            {
                Form1 frm = new Form1();
                string Info = frm.Search.Text;
                conn.Open();
                string sqlstr = @"select Mno, Mname, Mtype, Cname  
                              from Movie, CM, Cast_
                              where Movie.Mno = CM.Mno and Cast_.Cno = CM.Cno ";
                MySqlCommand dbcmd = new MySqlCommand(sqlstr, conn);
                MySqlDataReader dr_cm = dbcmd.ExecuteReader();
                Form_list frm4 = new Form_list();
                string Mno = null;
                string Mname = null;
                string Mtype = null;
                string Cname = null;
                while (dr_cm.Read())
                {
                    Mno = dr_cm["Mno"].ToString();
                    Mname = dr_cm["Mname"].ToString();
                    Mtype = dr_cm["Mtype"].ToString();
                    Cname = dr_cm["Cname"].ToString();
                }
                dr_cm.Close();
                if(Info == null)
                {
                    frm4.listBox1.Items.Add("没有找到搜索结果");
                }
                else if (Info == Mno || Info == Mname)
                {
                    string movstr = @"select * from Movie";
                    MySqlCommand dbcmov = new MySqlCommand(movstr, conn);
                    MySqlDataReader dr_movie = dbcmov.ExecuteReader();
                    movie_form frm2 = new movie_form();
                    while (dr_movie.Read())
                    {
                        string Moviename = dr_movie["Mname"].ToString();
                        string Movietype = dr_movie["Mtype"].ToString();
                        string Director = dr_movie["Director"].ToString();
                        string Rate = dr_movie["synthe_rate"].ToString();
                        string act1 = dr_movie["act1"].ToString();
                        string act2 = dr_movie["act2"].ToString();
                        string Moviedate = dr_movie["Mdate"].ToString();
                        string trailer = dr_movie["trailer"].ToString();
                        string poster = dr_movie["poster"].ToString();
                        string Mincome = dr_movie["Mincome"].ToString();
                        
                        frm2.Pname.Text = Moviename;
                        frm2.Director.Text += Director;
                        frm2.synthe_rate.Text += Rate;
                        frm2.Mtype.Text += Movietype;
                        frm2.Actor.Text += act1 + "," + act2;
                        frm2.Mdate.Text += Moviedate;
                        frm2.Trailer.URL = trailer;
                        frm2.Poster.ImageLocation = poster;
                        frm2.Income.Text += Mincome;
                    }
                    dr_movie.Close();
                    frm2.Show();
                }
                else if (Info == Mtype || Info == Cname)
                {
                    while (Mno != null)
                    {
                        frm4.listBox1.Items.Add(Mno+" "+Mname+" "+ Mtype);
                    }
                    frm4.Show();
                }
                else
                {
                    frm4.listBox1.Items.Add("没有找到搜索结果");
                    frm4.Show();
                }
            }
        }
        static void GetViewPR(MySqlConnection conn)
        {
            using (conn)
            {
                string sqlstr = "select * from V_PR";
                MySqlCommand dbcmd = new MySqlCommand(sqlstr, conn);
                MySqlDataReader reader = dbcmd.ExecuteReader();
                DataTable PRview = reader.GetSchemaTable();
                conn.Open();
                foreach(DataRow row in PRview.Rows)
                {
                    foreach(DataColumn column in PRview.Columns)
                    {
                        string datastr = column.ToString();
                        Console.Write(datastr+" ");
                    }
                    Console.WriteLine("\n");
                }
            }
        }
        static void GetViewRR(MySqlConnection conn)
        {
            using (conn)
            {
                string sqlstr = "select * from V_RR";
                MySqlCommand command = new MySqlCommand(sqlstr, conn);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable RRview = reader.GetSchemaTable();
                conn.Open();
                foreach (DataRow row in RRview.Rows)
                {
                    foreach (DataColumn column in RRview.Columns)
                    {
                        string datastr = column.ToString();
                        Console.Write(datastr + " ");
                    }
                    Console.WriteLine("\n");
                }
            }
        }
        private void toolStripLabel1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            GetViewPR(conn);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            Form mine_form = new Form();
            mine_form.Show();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            GetViewRR(conn);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StartTheSearch(conn);
        }

        private void Search_TextChanged_1(object sender, EventArgs e)
        {
            Search.AutoSize = false;
            Search.Height = 35;
            Search.Text = "";
        }
    }
}
