﻿using System;
using System.Data.SqlClient;                                                    //包含访问SQL Server所需的各类对象；
using System.Windows.Forms;


namespace MedicalSystem
{
    public partial class frm_Connection_ConnectionString : Form
    {
        public frm_Connection_ConnectionString()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();                  //声明并实例化SQL连接；
            sqlConnection.ConnectionString =
                "Server=(Local);Database=MedicalSystem;Integrated Security=sspi"; //在字符串变量中，描述连接字符串所需的服务器地址、数据库名称、集成安全性（即是否使用Windows验证）；
            sqlConnection.Open();                                               //打开SQL连接；
            MessageBox.Show                                                     //在消息框中显示；
                ($@"连接状态：{sqlConnection.State}" +                            //消息框消息内容；
                 $"\n工作站标识：{sqlConnection.WorkstationId}" +
                 $"\n服务器地址：{sqlConnection.DataSource}" +
                 $"\n服务器版本：{sqlConnection.ServerVersion}" +
                 $"\n数据库名称：{sqlConnection.Database}" +
                 $"\n\n（单击【确定】后将关闭SQL连接）");
            sqlConnection.Close();                                              //关闭SQL连接；
            MessageBox.Show                                                     //在消息框中显示；
                ($"连接状态：{sqlConnection.State}");
        }
    }
}
