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

namespace prak_w14
{
    public partial class FormTeam : Form
    {
        public FormTeam()
        {
            InitializeComponent();
        }

        public static string sqlconnection = "server=localhost;uid=root;pwd=;database=premier_league";
        public MySqlConnection sqlConnect = new MySqlConnection(sqlconnection);
        public MySqlCommand sqlCommand;
        public MySqlDataAdapter sqlAdapter;
        string sqlQuery;
        int posisi2 = 0;

        DataTable dt3Awal = new DataTable();
        DataTable dtTopScorer = new DataTable();
        DataTable dtWorstDiscipline = new DataTable();
        DataTable dtMatch = new DataTable();
        private void FormTeam_Load(object sender, EventArgs e)
        {
            sqlQuery = "select t.team_name as `Team Name`, concat(m.manager_name, ' (', n.nation, ') ') as `Manager`, concat(t.home_stadium, ', ', t.city, ' (', t.capacity, ') ') as `Stadium`, t.team_id as `Team_ID` from team t, manager m, player p, nationality n where m.manager_id = t.manager_id and t.team_id = p.team_id and n.nationality_id = m.nationality_id and t.captain_id = p.player_id";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dt3Awal);

            TeamData(0);
        }
        public void TeamData(int posisi)
        {
            dtMatch.Clear();
            labelNamaTim.Text = dt3Awal.Rows[posisi][0].ToString();
            labelNamaMan.Text = dt3Awal.Rows[posisi][1].ToString();
            labelStad.Text = dt3Awal.Rows[posisi][2].ToString();

            sqlQuery = "select concat(p.player_name, ' ', sum(d.type = 'GO' OR d.type = 'GP'), '(', sum(d.type = 'GP'),')') from dmatch d, player p where p.team_id = '" + dt3Awal.Rows[posisi]["Team_ID"] + "' and (d.type = 'GO' OR d.type = 'GP') and d.player_id = p.player_id group by d.player_id order by 1 desc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTopScorer);
            labelTopScorer.Text = dtTopScorer.Rows[posisi][0].ToString();

            sqlQuery = "select p.player_name as `Player`, kuning.kuning2 as `Yellow Card`, merah.merah2 as `Red Card` from player p, (select d.player_id as `ID`, sum(if(d.type = 'CY', 1, 0)) as kuning2, sum(if(d.type = 'CY', 1, 0)) as poin from dmatch d group by 1) `kuning`, (select d.player_id as `ID`, sum(if(d.type = 'CR', 1, 0)) as merah2, sum(if(d.type = 'CR', 3, 0)) as poin from dmatch d group by 1) merah where p.player_id = kuning.ID and kuning.ID = merah.ID and p.team_id = '"+ dt3Awal.Rows[posisi]["Team_ID"] + "' order by 2 desc;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtWorstDiscipline);
            labelWDis.Text = dtWorstDiscipline.Rows[posisi][0] + ", " + dtWorstDiscipline.Rows[posisi][1] + " Yellow Card and " + dtWorstDiscipline.Rows[posisi][2] + " Red Card";

            sqlQuery = "SELECT date_format(m.match_date, '%d/%m/%Y') as 'match_date', if (m.team_home = '" + dt3Awal.Rows[posisi]["Team_ID"] + "', 'HOME', 'AWAY') as 'Home/Away', if (m.team_home = '" + dt3Awal.Rows[posisi]["Team_ID"] + "', (select team.team_name from team where team.team_id = m.`team_away`), (select team.team_name from team where team.team_id = m.team_home)) as 'lawan', concat(goal_home, '-', goal_away) as 'score' from `match` m, team t where t.team_id = '" + dt3Awal.Rows[posisi]["Team_ID"] + "' and (m.team_home = '" + dt3Awal.Rows[posisi]["Team_ID"] + "' or m.team_away = '" + dt3Awal.Rows[posisi]["Team_ID"] + "') ORDER BY `match_date` asc LIMIT 5";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtMatch);
            dgvHasil.DataSource = dtMatch;
            posisi2 = posisi;
        }

        private void buttonFirst_Click(object sender, EventArgs e)
        {
            TeamData(0);
        }

        private void buttonLast_Click(object sender, EventArgs e)
        {
            TeamData(dt3Awal.Rows.Count - 1);
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            if (posisi2 == 0)
            {
                MessageBox.Show("This Data is The First Data");
            }
            else
            {
                posisi2--;
                TeamData(posisi2);
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            if (posisi2 < dt3Awal.Rows.Count - 1)
            {
                posisi2++;
                TeamData(posisi2);
            }
            else
            {
                MessageBox.Show("This Data is The Last Data");
            }
        }
    }
}
