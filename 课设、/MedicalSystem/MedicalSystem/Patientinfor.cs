using System;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace MedicalSystem
{
    public partial class Patientinfor : Form
    {
        private long  MDnumber;
        public Patientinfor(long mdnumber)
        {
            this.MDnumber = mdnumber;
            InitializeComponent();
            load();
        }
        private void Patientinfor_Load(object sender, EventArgs e)
        {
            this.txtmedicalid.Text = MDnumber.ToString();

        }
        public void load()
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString =
           "Server=(Local);Database=MedicalSystem;Integrated Security=sspi";
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.CommandText = "SELECT * FROM tb_PATIENTINFOR WHERE MedicalCardId=@MedicalCardId";
            sqlCommand.Parameters.AddWithValue("@MedicalCardId",this.MDnumber);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter();
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            if (sqlDataReader.Read())
            {
                this.txbname.Text = sqlDataReader["PatientNAME"].ToString();
                this.txtbirthdate .Text= sqlDataReader["BIRTHDATE"].ToString();
                this.txbpinying.Text = sqlDataReader["pinying"].ToString();
                this.rbtnman.Checked = (bool)sqlDataReader["GENDER"];
                this.rbtnwoman.Checked = !(bool)sqlDataReader["GENDER"];
                this.txtProvince.Text = sqlDataReader["PROVINCE"].ToString();
                this.txbcity.Text = sqlDataReader["CITY"].ToString();
                this.txbnationality .Text = sqlDataReader["NATIONALITY"].ToString();
                this.txbaddress.Text= sqlDataReader["ADDRESS"].ToString();
                this.txtage.Text= sqlDataReader["AGE"].ToString();
                this.txbidcard.Text = sqlDataReader["IDCARD"].ToString();
                this.txbtel.Text = sqlDataReader["TEL"].ToString();
                this.txbmarry.Text = sqlDataReader["MARRYSITUATION"].ToString();
                this.txbpaytype.Text = sqlDataReader["PAYTYPE"].ToString();

            }
            sqlConnection.Close();
        }

        private void btnbackinfor_Click(object sender, EventArgs e)
        {
            register register = new register();
            register.Show();
            this.Close();
        }

        private void btnRegiteration_Click(object sender, EventArgs e)
        {
            //registration registration = new registration();
            //registration.Show();
            //this.Close();
        }
    }
}
