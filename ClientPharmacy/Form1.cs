using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientPharmacy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pharmacyEntities pharmacy = new pharmacyEntities();
            dataGridView1.DataSource = pharmacy.pharmacy_list.ToList();
            //pharmacyEntities entities = new pharmacyEntities();
           //dataGridView1.DataSource = entities.pharmacy_list.ToList();
        }
        void LoadData()
        {
            //pharmacyEntities context = new pharmacyEntities();

            string connectString = "Server=localhost;Port=5432;User=postgres;Password=root;Database=pharmacy";
            NpgsqlConnection npgsqlConnection = new NpgsqlConnection(connectString);
            npgsqlConnection.Open();
        }
        }
}
