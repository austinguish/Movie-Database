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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }


   
    
      
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string username = name.Text.Trim();
            string pwd = password.Text;
            string constr = "Server=.;DataBase=Management;Integrated Security=True";
            // 建立SqlConnection对象
            SqlConnection con = new SqlConnection(constr);
            // 打开连接
            con.Open();
            // 指定SQL语句
            SqlCommand com = new SqlCommand("select Uid,passwd from Users where Uid='" + username + "' and passwd='" + pwd + "'", con);
            //这里修改表名和属性名
            // 建立SqlDataAdapter和DataSet对象
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();

            int n = da.Fill(ds, "Users");
            if (n != 0)
            {
                MessageBox.Show("登录成功！", "提示");
                name.Visible = false;
                password.Visible = false;
                myinform frm = new myinform();
                frm.uname = name;
                frm.Show();
            }
            else
            {
                MessageBox.Show("用户名或密码错误，请重新输入！", "提示");
                name.Text = "";
                password.Text = "";
                name.Focus();
            }
            con.Close();
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void resis_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }
    }
}
