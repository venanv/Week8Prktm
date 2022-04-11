using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Week8Prktm
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection); //sebagai data koneksi ke DBMSnya
        public MySqlCommand sqlCommand; //memindahkan query ke database, query terjadi di dbmsnya
        public static MySqlDataAdapter sqlAdapter; //hasil dari query akan disimpan di mysqldata
        public string sqlQuery;
        private void Form1_Load(object sender, EventArgs e)
        {
            Manager1.Text = "Arsene Wenger";
            Captain1.Text = "Mikel Arteta";
            Manager2.Text = "Arsene Wenger";
            Captain2.Text = "Mikel Arteta";
            Stadium.Text = "Emirates Stadium, London";
            Capacity.Text = "60432";
            DataTable dteam1 = new DataTable();
            sqlQuery = "SELECT team_name, team_id FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dteam1);
            DataTable dteam2 = new DataTable();
            sqlQuery = "SELECT team_name, team_id FROM team";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dteam2);
            cb1.DataSource = dteam1;
            cb1.DisplayMember = "team_name";
            cb1.ValueMember = "team_id";
            cb2.DataSource = dteam2;
            cb2.DisplayMember = "team_name";
            cb2.ValueMember = "team_id";

            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void Manager2_Click(object sender, EventArgs e)
        {

        }

        private void cb1_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
            DataTable dthome = new DataTable();
            sqlQuery = "SELECT t.team_name, t.team_id , m.manager_name, p.player_name, CONCAT(t.home_stadium, ', ', t.city), t.capacity FROM team t, manager m, player p WHERE t.manager_id = m.manager_id AND t.captain_id = p.player_id and t.team_id = '"+cb1.SelectedValue+"'";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dthome);
            Manager1.Text = dthome.Rows[0][2].ToString();
            Captain1.Text = dthome.Rows[0][3].ToString();
                Stadium.Text = dthome.Rows[0][4].ToString();
                Capacity.Text = dthome.Rows[0][5].ToString();
            }
            catch (Exception)
            {

            }
           
        }

        private void cb2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dthome = new DataTable();
                sqlQuery = "SELECT t.team_name, t.team_id , m.manager_name, p.player_name, CONCAT(t.home_stadium, ', ', t.city), t.capacity FROM team t, manager m, player p WHERE t.manager_id = m.manager_id AND t.captain_id = p.player_id and t.team_id = '" + cb2.SelectedValue + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dthome);
                Manager2.Text = dthome.Rows[0][2].ToString();
                Captain2.Text = dthome.Rows[0][3].ToString();
            }
            catch(Exception)
            {

            }
        }
    }
}
