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
    public partial class UserCtrlForm : Form
    {
        public UserCtrlForm()
        {
            InitializeComponent();
        }
        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;
        MySqlCommand query;
        private void UserCtrlForm_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=localhost;port=3306;database=shinpokemon;uid=root;pwd=qwe2e3r4t5");
            dataAdapter = new MySqlDataAdapter("Select * from user", conn);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "user");
            dataGridView1.DataSource = dataSet.Tables["user"];
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

            cbxUsex.SelectedIndex = 0;

        }

        private void btnUselect_Click(object sender, EventArgs e)
        {
            string sql = $"select * from user where name = @name";

            dataAdapter.SelectCommand = new MySqlCommand(sql, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@name", tbxUSname.Text.ToString());

            try
            {
                conn.Open();
                if (dataAdapter.SelectCommand.ExecuteNonQuery() > 0) // 검색된 데이터의 행 수 반환
                {
                    dataSet.Clear();
                    dataAdapter.Fill(dataSet, "user");
                    dataGridView1.DataSource = dataSet.Tables["user"];
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

        private void btnUinsert_Click(object sender, EventArgs e)
        {
            if (tbxUIname.Text.ToString() == "") { MessageBox.Show("공백은 넣을 수 업습니다."); return; }

            string sql = $"insert into user (name, sex) values(@name, @sex)";

                dataAdapter.InsertCommand = new MySqlCommand(sql, conn);
                dataAdapter.InsertCommand.Parameters.AddWithValue("@name", tbxUIname.Text.ToString());
                dataAdapter.InsertCommand.Parameters.AddWithValue("@sex", cbxUsex.SelectedItem.ToString());
            try
            {
                conn.Open();
                if (dataAdapter.InsertCommand.ExecuteNonQuery() > 0) // 검색된 데이터의 행 수 반환
                {
                    dataSet.Clear();
                    dataAdapter.Fill(dataSet, "user");
                    dataGridView1.DataSource = dataSet.Tables["user"];
                }
                else
                    MessageBox.Show("수정된 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                dataAdapter.InsertCommand.Parameters.Clear();
            }
        }

        private void btnUupdate_Click(object sender, EventArgs e)
        {
            string sql = $"update user set sex=@sex where name=@name";

            dataAdapter.UpdateCommand = new MySqlCommand(sql, conn);
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@sex", cbxUusex.SelectedItem.ToString());
            dataAdapter.UpdateCommand.Parameters.AddWithValue("@name", dataGridView1.SelectedRows[0].Cells["name"].Value);
            try
            {
                conn.Open();
                if (dataAdapter.UpdateCommand.ExecuteNonQuery() > 0) // 검색된 데이터의 행 수 반환
                {
                    dataSet.Clear();
                    dataAdapter.Fill(dataSet, "user");
                    dataGridView1.DataSource = dataSet.Tables["user"];
                }
                else
                    MessageBox.Show("수정된 데이터가 없습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                dataAdapter.UpdateCommand.Parameters.Clear();
            }
        }

        private void btnUdelete_Click(object sender, EventArgs e)
        {
            string sql = "DELETE FROM user Where name=@name";
            dataAdapter.DeleteCommand = new MySqlCommand(sql, conn);
            dataAdapter.DeleteCommand.Parameters.AddWithValue("@name", dataGridView1.SelectedRows[0].Cells["name"].Value);

            try
            {
                conn.Open();
                dataAdapter.DeleteCommand.ExecuteNonQuery();

                dataSet.Clear();
                dataAdapter.Fill(dataSet, "user");
                dataGridView1.DataSource = dataSet.Tables["user"];
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                dataAdapter.DeleteCommand.Parameters.Clear();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lbSelectedTrainer.Text = dataGridView1.SelectedRows[0].Cells["name"].Value.ToString();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                lbSelectedTrainer.Text = dataGridView1.SelectedRows[0].Cells["name"].Value.ToString();
            }
            catch (Exception)
            {
                // ignore;
            }
        }
    }
}
