using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MedicalSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        public static  string str;
        public static string officename;
        public void getname()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
           "Server=(Local);Database=MedicalSystem;Integrated Security=sspi";
            sqlConnection.Open();
            SqlCommand sqlCommand = sqlConnection.CreateCommand();
            sqlCommand.CommandText = "SELECT O.OFFICENAME,D.DoctorName  FROM tb_Doctors AS D " +
                "JOIN tb_OFFICE AS O ON O.OFFICEID = D.OFFICEID " +
                "WHERE DoctorID=@No";
            sqlCommand.Parameters.AddWithValue("@No", this.txb_UserID.Text.Trim());
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                this.txb_UserName.Text = sqlDataReader["DoctorName"].ToString();
                this.txboffice.Text= sqlDataReader["OFFICENAME"].ToString();
            }
            sqlConnection.Close();
            
        }
        public void btnLogin_Click(object sender, EventArgs e)
        {
          
            SqlConnection sqlConnection = new SqlConnection();             
            sqlConnection.ConnectionString =
           "Server=(Local);Database=MedicalSystem;Integrated Security=sspi";
            SqlCommand sqlCommand = sqlConnection.CreateCommand();                                      //调用SQL连接的方法CreateCommand来创建SQL命令；该命令将绑定SQL连接；
            sqlCommand.CommandText =
            "SELECT COUNT(1) FROM tb_Doctors WHERE DoctorID=@No AND Password=HASHBYTES('MD5',@Password);";
            SqlCommand Command = sqlConnection.CreateCommand();
            Command.CommandText = "SELECT DoctorName FROM tb_Doctors WHERE DoctorID={this.txb_UserID.Text.Trim()}";
            sqlCommand.Parameters.AddWithValue("@Password", this.txb_Password.Text.Trim());             //直接调用方法AddWithValue向SQL命令的参数集合添加参数的名称、值；SQL参数能自动识别类型，但若SQL参数被用作某函数的输入参数，则使用函数定义的参数类型作为SQL参数类型；
            sqlCommand.Parameters["@Password"].SqlDbType = SqlDbType.VarChar;
            sqlCommand.Parameters.AddWithValue("@No", this.txb_UserID.Text.Trim()); 
      
            sqlConnection.Open();
            int rowCount = (int)sqlCommand.ExecuteScalar();                                         //调用SQL命令的方法ExecuteScalar来执行命令，并接受单个结果（即标量）；
           if (rowCount == 1)                                                                          //若查得所输用户号相应的1行记录；
            {
                getname();
                MessageBox.Show("登录成功。");
                Desktop desktop = new Desktop();
                desktop.Show();
                this.Close();
            }
            else                                                                                        //否则；
            {
                MessageBox.Show("用户号/密码有误，请重新输入！");											//显示错误提示；
                this.txb_Password.Focus();                                                              //密码文本框获得焦点；
                this.txb_Password.SelectAll();                                                          //密码文本框内所有文本被选中；
            }
            sqlConnection.Close();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        public  void txb_UserID_TextChanged(object sender, EventArgs e)
        {
            getname();
            str = txb_UserName.Text;
            officename = txboffice.Text;
        }
    }
}
