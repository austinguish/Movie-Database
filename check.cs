using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace 电影数据库
{
    public partial class check : Form
    {
        public check()
        {
            InitializeComponent();
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
           
        }

    private void button1_Click(object sender, EventArgs e)
    {
            string moviename = textBox1.Text.Trim();
            string mvdate = dateTimePicker1.Value.ToString();
            string mvcity = textBox2.Text.Trim(); 
            string constr = "Server=.;DataBase=Management;Integrated Security=True";
            // 建立SqlConnection对象
            SqlConnection con = new SqlConnection(constr);
            // 打开连接
            con.Open();
            // 指定SQL语句
            SqlCommand com1 = new SqlCommand("SELECT Mname,Mvtime,chain_name,Mvprice FROM movie inner join theatre on movie.Mno = theatre.Mno Where Mname = '" + moviename + "' and City ='"+mvcity+"' and date='"+mvdate+"'", con);
            //这里修改表名和属性名
            // 建立SqlDataAdapter和DataSet对象
            SqlDataAdapter da1 = new SqlDataAdapter(com1);
            
            DataSet ds = new DataSet();

            //使用fill方法填充DataSet
            da1.Fill(ds, "t");
            //在DataGridView1控件中显示表t
            dataGridView1.DataSource = ds.Tables["t"];
            con.Close();

        }
}
}
