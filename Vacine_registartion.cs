using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace test6826d0826formsappVacine
{
    public partial class Vacine_registartion : Form
    {
        SqlCommand DBCMD;
        SqlConnection DBConcet;
        public Vacine_registartion()
        {
            InitializeComponent();
        }
        private void mergeToDb()
        {
            DBConcet = new SqlConnection(@"Data Source=CHRISPC;Initial Catalog=VacineDetails;Integrated Security=True");
            DBConcet.Open();
            DBCMD = new SqlCommand("insert into VacinceRegistery values(@ID,@FirstName,@LastName,@Province,@Gender)",DBConcet);
            DBCMD.Parameters.AddWithValue("ID",int.Parse(TxtIdNum.Text));
            DBCMD.Parameters.AddWithValue("FirstName",TxtName.Text);
            DBCMD.Parameters.AddWithValue("LastName", TxtSurname.Text);
            DBCMD.Parameters.AddWithValue("Province", TxtProvince.Text);
            DBCMD.Parameters.AddWithValue("Gender", CBGender.SelectedItem.ToString());
            DBCMD.ExecuteNonQuery();
            DBConcet.Close();
        }

        private void BtnSubmitExit_Click(object sender, EventArgs e)
        {
            mergeToDb();
            MessageBox.Show("Thank you for your time\n you will be informed by the clerk when you vacince is secheduled","Done, Thank you",MessageBoxButtons.OK,MessageBoxIcon.Information);
            this.Close();
        }
    }
}
