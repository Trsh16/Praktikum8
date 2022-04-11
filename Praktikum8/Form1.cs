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

namespace Praktikum8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string sqlConnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlConnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        public string sqlQuery;
        private void comboBox_Home_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtSearch = new DataTable();  
                label_ManagerHome.Text = comboBox_Home.SelectedValue.ToString();
                sqlQuery = "SELECT * FROM team WHERE manager_name = '" + comboBox_Home.SelectedValue.ToString() + "'";           
                label_CaptainHome.Text = comboBox_Home.SelectedValue.ToString();
                sqlQuery = "SELECT * FROM team WHERE player_name = '" + comboBox_Home.SelectedValue.ToString() + "'";               
                label_Stadium.Text = comboBox_Home.SelectedValue.ToString();
                sqlQuery = "SELECT * FROM team WHERE home_stadium = '" + comboBox_Home.SelectedValue.ToString() + "'";             
                label_Capacity.Text = comboBox_Home.SelectedValue.ToString();
                sqlQuery = "SELECT * FROM team WHERE capacity = '" + comboBox_Home.SelectedValue.ToString() + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtSearch);            
            }
            catch (Exception)
            {

            }
        }
        private void comboBox_Away_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable dtSearch = new DataTable();
                label_ManagerAway.Text = comboBox_Away.SelectedValue.ToString();
                sqlQuery = "SELECT * FROM team WHERE manager_name = '" + comboBox_Away.SelectedValue.ToString() + "'";
                label_CaptainAway.Text = comboBox_Away.SelectedValue.ToString();
                sqlQuery = "SELECT * FROM team WHERE player_name = '" + comboBox_Away.SelectedValue.ToString() + "'";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtSearch);
            }
            catch (Exception)
            {

            }           
        }
        private void Form1_Load(object sender, EventArgs e)
        {                   
            sqlQuery = "SELECT team_name as 'Nama Tim', " +
                     "manager_name as 'Manager Tim', " +
                     "player_name as 'Captain Tim', " +
                     "home_stadium as 'Stadium', " +
                     "capacity as 'Capacity'" +
                     "FROM manager m, team t, player p " +
                     "WHERE t.manager_id = m.manager_id and p.player_id = t.captain_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            DataTable dtHome = new DataTable();
            sqlAdapter.Fill(dtHome);
            comboBox_Home.DataSource = dtHome;
            comboBox_Home.DisplayMember = "Nama Tim";
            comboBox_Home.ValueMember = "Stadium";
            comboBox_Home.ValueMember = "Captain Tim"; 
            comboBox_Home.ValueMember = "Capacity";
            comboBox_Home.ValueMember = "Manager Tim";
            DataTable dtAway = new DataTable();
            comboBox_Away.DataSource = dtHome;
            comboBox_Away.DisplayMember = "Nama Tim";
            comboBox_Away.ValueMember = "Captain Tim";
            comboBox_Away.ValueMember = "Manager Tim";
        }
    }
}
