using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Ezhe
{
    public partial class Form1 : Form
    {
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();

        public Form1()
        {
            InitializeComponent();
        }


        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Form2 formAddNew = new Form2();
            formAddNew.ShowDialog();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            //string connString = String.Format("Server=192.168.1.13;Port=5432;UserId=diary;Database=ezhe;");
            string connString = String.Format("Server=127.0.0.1;Port=15432;UserId=ezheuser;Database=ezhedb;");
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            string sql = "SELECT * FROM events;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dgvEvents.DataSource = dt;
            conn.Close();
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            //string connString = String.Format("Server=192.168.1.13;Port=5432;UserId=diary;Database=ezhe;");
            string connString = String.Format("Server=127.0.0.1;Port=15432;UserId=ezheuser;Database=ezhedb;");
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            string sql = "SELECT * FROM events;";
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(sql, conn);
            ds.Reset();
            da.Fill(ds);
            dt = ds.Tables[0];
            dgvEvents.DataSource = dt;
            conn.Close();
        }
    }
}
