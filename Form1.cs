using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonWinform
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        MySqlConnection conn;
        //MySqlDataAdapter dataAdapter;
        MySqlCommand query;

        private void MainForm_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=localhost;port=3306;database=shinpokemon;uid=root;pwd=qwe2e3r4t5");
            //dataAdapter = new MySqlDataAdapter("Select * from user", conn);
            query = conn.CreateCommand();
            query.CommandText = "select name from user";

            try
            {
                conn.Open();
                MySqlDataReader reader = query.ExecuteReader();
                for (int i = 0; reader.Read(); i++)
                {
                    cbxUsername.Items.Add(reader["name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (cbxUsername.Items.Count == 0) cbxUsername.Items.Add("null");
                cbxUsername.SelectedIndex = 0;
                conn.Close();
            }

        }

        private void btnUserCtrl_Click(object sender, EventArgs e)
        {
            UserCtrlForm showUserCtrl = new UserCtrlForm();

            showUserCtrl.ShowDialog();
        }

        private void btnPocketmonCtrl_Click(object sender, EventArgs e)
        {
            //PocketmonCtrlForm showPocketmonCtrl = new PocketmonCtrlForm();
            //showPocketmonCtrl.Passvalue = cbxUsername.SelectedItem.ToString();
            //showPocketmonCtrl.ShowDialog();
            MessageBox.Show("추후 추가 예정일겁니다!");
        }

        private void btnPocketmonDic_Click(object sender, EventArgs e)
        {
            PocketmonDicForm showPocketmonDic = new PocketmonDicForm();

            showPocketmonDic.ShowDialog();
        }

        private void cbxUsername_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cbxUsername_MouseDown(object sender, MouseEventArgs e)
        {
            query.CommandText = "select name from user";

            try
            {
                conn.Open();
                cbxUsername.Items.Clear();
                MySqlDataReader reader = query.ExecuteReader();
                for (int i = 0; reader.Read(); i++)
                {
                    cbxUsername.Items.Add(reader["name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
