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
    public partial class PocketmonCtrlForm : Form
    {
        private string T_name;
        public string Passvalue
        {
            get { return this.T_name; }
            set { this.T_name = value; }  // 다른폼(Form1)에서 전달받은 값을 쓰기
        }

        public PocketmonCtrlForm()
        {
            InitializeComponent();
        }
        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;
        MySqlCommand query;
        private void PocketmonCtrlForm_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=localhost;port=3306;database=shinpokemon;uid=root;pwd=qwe2e3r4t5");
            dataAdapter = new MySqlDataAdapter($"Select * from hold", conn);
            dataSet = new DataSet();

            string sql = $"select * from hold where name = @name";

            dataAdapter.SelectCommand = new MySqlCommand(sql, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", T_name);

            try
            {
                conn.Open();
                if (dataAdapter.SelectCommand.ExecuteNonQuery() > 0) // 검색된 데이터의 행 수 반환
                {
                    dataSet.Clear();
                    dataAdapter.Fill(dataSet, "hold");
                    dataGridView1.DataSource = dataSet.Tables["hold"];
                }
                else
                    MessageBox.Show("발견 된 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                dataAdapter.SelectCommand.Parameters.Clear();
            }


        }
    }
}
