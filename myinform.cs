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
    public partial class myinform : Form
    {
        public myinform()
        {
            InitializeComponent();
        }
        public object uname;
        private void Myinform_Load(object sender, EventArgs e)
        {
            //实例化SqlConnection变量conn，连接到数据库
            string conString = "server=.;database=test;uid=sa;pwd=sa;";
            SqlConnection conn = new SqlConnection(conString);
            //创建SqlDataAdapter对象s
            SqlDataAdapter s = new SqlDataAdapter("select * from Users where Uid = '" + uname + "'", conn);
            //创建DataSet对象d
            DataSet d = new DataSet();
            //使用fill方法填充DataSet
            s.Fill(d, "t");
            //在DataGridView1控件中显示表t
            dataGridView1.DataSource = d.Tables["t"];

            //设置SelectionMode属性，使得控件可以整行选择
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            //设置控件只读
            dataGridView1.ReadOnly = true;
            //设置选中行背景色为红色
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Red;
        }

    }
       
    }
