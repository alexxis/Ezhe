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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnMaxId_Click(object sender, EventArgs e)
        {
            //string connString = String.Format("Server=192.168.1.13;Port=5432;UserId=diary;Database=ezhe;");
            string connString = String.Format("Server=127.0.0.1;Port=15432;UserId=ezheuser;Database=ezhedb;");
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            string sql = "SELECT MAX(eid) FROM events;";
            NpgsqlCommand command = new NpgsqlCommand(sql, conn);
            string abc = "qq";
            //textBox1.Text = Convert.ToInt32(command.ExecuteScalar()).ToString();
            abc = Convert.ToInt32(command.ExecuteScalar()).ToString();
            //abd = (Int32)command.ExecuteScalar();
            MessageBox.Show(abc);
            //MessageBox.Show(abd.ToString());
            conn.Close();
            //MessageBox.Show("Соединение с БД закрыто");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //string connString = String.Format("Server=192.168.1.13;Port=5432;UserId=diary;Database=ezhe;");
            string connString = String.Format("Server=127.0.0.1;Port=15432;UserId=ezheuser;Database=ezhedb;");
            NpgsqlConnection conn = new NpgsqlConnection(connString);
            conn.Open();
            //MessageBox.Show("Соединение с БД открыто");
            //string sql = "SELECT MAX(id) FROM events;";
            //NpgsqlCommand command = new NpgsqlCommand(sql, conn);
            //int maxId = 0;
            //maxId = (Int32)command.ExecuteScalar() + 1;
            //MessageBox.Show(maxId.ToString());
            //string sql2 = "INSERT INTO ezhe(id,date,time,event,rate,descr) VALUES ('"+maxId+"','02.04.2015','23:59','Чаёк','15','Описание');";
            //string sql2 = "INSERT INTO ezhe(id) VALUES (" + maxId + ");";
            string sql2 = "INSERT INTO events(date,time,event,rate,descr) VALUES ('";
            //sql2 += maxId;
            //sql2 += "','";
            sql2 += dtpDate.Text;
            //sql2 += "05.19.2015";
            sql2 += "','";
            sql2 += dtpTime.Text;
            sql2 += "','";
            sql2 += tbEvent.Text;
            sql2 += "','";
            sql2 += tbRate.Text;
            sql2 += "','";
            sql2 += tbDescr.Text;
            sql2 += "');";
            //MessageBox.Show(sql);
            MessageBox.Show(sql2);
            NpgsqlCommand command2 = new NpgsqlCommand(sql2, conn);
            command2.ExecuteNonQuery();
            conn.Close();
            //MessageBox.Show("Соединение с БД закрыто");
        }
    }
}
