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

namespace Dynamic_Tables_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection baglanti = new SqlConnection(@"Data Source=KUBRA-BOSNAK;Initial Catalog=DbDynamicTables;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            //// TODO: This line of code loads data into the 'dbDynamicTablesDataSet.DYNAMICTABLEPROJECT' table. You can move, or remove it, as needed.
            //this.dYNAMICTABLEPROJECTTableAdapter.Fill(this.dbDynamicTablesDataSet.DYNAMICTABLEPROJECT);
            
            baglanti.Open();
            SqlDataAdapter da = new SqlDataAdapter("EXECUTE DYNAMICTABLEPROJECT", baglanti);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            baglanti.Close();

            baglanti.Open();
            
            SqlCommand komut = new SqlCommand("SELECT PERSONELAD FROM TBLPERSONELLER", baglanti);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbSatici.Items.Add(dr[0]);
            }
            baglanti.Close();
            baglanti.Open();

            SqlCommand komut2 = new SqlCommand("SELECT URUNAD FROM TBLURUNLER", baglanti);
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbUrunAdi.Items.Add(dr2[0]);
            }
            baglanti.Close();          
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
//