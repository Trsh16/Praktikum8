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
        DataTable dtTeamAway = new DataTable();
        DataTable dtTeamHome= new DataTable();
        private void Form1_Load(object sender, EventArgs e)
        {
            sqlQuery = "SELECT t.team_id as 'ID Team',  team_name as 'Nama Tim', manager_name as 'Nama Manager', player_name as 'Captain Tim', home_stadium as 'Stadium', capacity as 'Capacity', n.match_date as 'Tanggal', if(n.goal_home is null, 'Belum Berlangsung', concat(n.goal_home, ' - ', n.goal_away)) as 'Skor' FROM manager m, team t, player p, premier_league.match n WHERE t.manager_id = m.manager_id and p.player_id = t.captain_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeamHome);
            sqlAdapter.Fill(dtTeamAway);
            comboBox_Home.DataSource = dtTeamHome;
            comboBox_Home.DisplayMember = "Nama Tim";
            comboBox_Home.ValueMember = "ID Team";
            comboBox_Away.DataSource = dtTeamAway;
            comboBox_Away.DisplayMember = "Nama Tim";
            comboBox_Away.ValueMember = "ID Team";
        }
        private void comboBox_Home_SelectedIndexChanged(object sender, EventArgs e)
        {
            int posisiindex = comboBox_Home.SelectedIndex;
            label_ManagerHome.Text = dtTeamHome.Rows[posisiindex]["Nama Manager"].ToString();
            label_CaptainHome.Text = dtTeamHome.Rows[posisiindex]["Captain Tim"].ToString();
            label_Stadium.Text = dtTeamHome.Rows[posisiindex]["Stadium"].ToString();
            label_Capacity.Text = dtTeamHome.Rows[posisiindex]["Capacity"].ToString();
            label_Tanggal.Text = dtTeamHome.Rows[posisiindex]["Tanggal"].ToString();
            label_Skor.Text = dtTeamHome.Rows[posisiindex]["Skor"].ToString();
        }
        private void comboBox_Away_SelectedIndexChanged(object sender, EventArgs e)
        {
            int posisiindex = comboBox_Away.SelectedIndex;
            label_ManagerAway.Text = dtTeamHome.Rows[posisiindex]["Nama Manager"].ToString();
            label_CaptainAway.Text = dtTeamHome.Rows[posisiindex]["Captain Tim"].ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dtPlayer = new DataTable();
            sqlQuery = "select d.`minute`, p.player_name as 'Player Name 1'," +
            "if (d.type = 'CY', 'Yellow Card', " +
            "if (d.type = 'CR', 'Real Card'," +
            "if (d.type = 'GO','Goal', " +
            "if (d.type = 'GP','Goal Penalty', " +
            "if (d.type = 'GW','Own Goal', 'Penalty Miss'))))) as 'Type 1', " +
            "k.player_name as 'Player Name 2', " +
            "if (d.type = 'CY', 'Yellow Card', " + 
            "if (d.type = 'CR', 'Real Card'," +
            "if (d.type = 'GO','Goal'," +
            "if (d.type = 'GP','Goal Penalty', " +
            "if (d.type = 'GW','Own Goal', 'Penalty Miss'))))) as 'Type 2' " +
            "from dmatch d, player p, player k, premier_league.match b " +
            "where d.team_id = p.player_id and " +
            "d.team_id = p.team_id and k.player_id = d.team_id and " +
            "k.player_id = d.player_id and d.match_id = b.match_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtPlayer);
            dgvplayer.DataSource = dtPlayer;
        }
    }
}
