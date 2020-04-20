using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace 电影数据库
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }


 

   

        private void button2_Click(object sender, EventArgs e)
        {
            string name = userName.Text.Trim();

            string constr = "Server=.;DataBase=Management;Integrated Security=True";
            // 建立SqlConnection对象
            SqlConnection con = new SqlConnection(constr);
            // 打开连接
            con.Open();
            // 指定SQL语句
            SqlCommand com = new SqlCommand("select Uid from Users where Uid='" + name + "'", con);
            // 建立SqlDataAdapter和DataSet对象
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataSet ds = new DataSet();

            int n = da.Fill(ds, "Users");
            if (n != 0)
            {
                MessageBox.Show("用户名已存在！", "提示");
                userName.Text = "";
                userPwd.Text = "";
                userPwdCheck.Text = "";
            }
            else if (userName.TextLength > 16)
            {
                MessageBox.Show("用户名太长，我怕你记不住，请换个短的吧！", "提示");
            }
            else if (userPwd.Text != userPwdCheck.Text)
            {
                MessageBox.Show("两次输入的密码不一致！", "提示");
                userPwd.Text = "";
                userPwdCheck.Text = "";
            }
            else if (userName.Text == "" || userPwd.Text == "")
            {
                MessageBox.Show("用户名或密码不能为空！", "提示");
            }
            else if (userPwd.TextLength < 6 || userPwd.TextLength > 12)
            {
                MessageBox.Show("密码长度不符合要求！", "提示");
                userPwd.Text = "";
                userPwdCheck.Text = "";
            }
            else
            {
                // 指定SQL语句
                com = new SqlCommand("insert into Users(Uid,passwd) values ('"
                    + userName.Text + "','" + userPwd.Text + "')", con);
                // 建立SqlDataAdapter和DataSet对象
                com.ExecuteNonQuery();
                com = null;
                MessageBox.Show("注册成功！", "提示");
                this.Close();
            }
            con.Close();

        }
    }
}
