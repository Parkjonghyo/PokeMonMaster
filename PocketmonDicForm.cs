using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonWinform
{
    public partial class PocketmonDicForm : Form
    {
        public PocketmonDicForm()
        {
            InitializeComponent();
        }
        MySqlConnection conn;
        MySqlDataAdapter dataAdapter;
        DataSet dataSet;
        MySqlCommand query;

        string currentTable = "pocketmon";

        private void ReloadCbxSearchType()
        {
            query = conn.CreateCommand();
            query.CommandText = "select * from type order by id";

            try
            {
                conn.Open();
                cbxSearchType.Items.Clear();
                MySqlDataReader reader = query.ExecuteReader();
                for (int i = 0; reader.Read(); i++)
                {
                    cbxSearchType.Items.Add(reader["name"].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
                cbxSearchType.SelectedIndex = 0;
                cbxSearchWhat.SelectedIndex = 0;
            }
        }

        private void PocketmonDicForm_Load(object sender, EventArgs e)
        {
            conn = new MySqlConnection("server=localhost;port=3306;database=shinpokemon;uid=root;pwd=qwe2e3r4t5");
            dataAdapter = new MySqlDataAdapter("Select * from pocketmon order by id", conn);
            dataSet = new DataSet();
            dataAdapter.Fill(dataSet, "pocketmon");
            dataGridView1.DataSource = dataSet.Tables["pocketmon"];
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
            ReloadCbxSearchType();

        }

        private void tbxSearchName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string sql = $"{currentTable}";

                if (tbxSearchName.Text.ToString() != "")
                    sql += " where name = @name";

                changeDataGridView(sql, 1);
            }
        }

        private void tbxSearchId_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                string sql = $"{currentTable}";

                if (currentTable != "tribe")
                {
                    if (tbxSearchId.Text.ToString() != "")
                        sql += " where id = @id";
                } else { MessageBox.Show("종족값은 ID로 조회가 되지 않습니다."); }

                changeDataGridView(sql, 2);
            }
        }

        private void changeDataGridView(string plusSql, int mode = 0)
        {
            string sql = $"select * from {plusSql}";

            if (currentTable != "tribe") sql += " order by id";

            dataAdapter.SelectCommand = new MySqlCommand(sql, conn);
            if(mode == 1) { dataAdapter.SelectCommand.Parameters.AddWithValue("@name", tbxSearchName.Text.ToString()); }
            if(mode == 2) { dataAdapter.SelectCommand.Parameters.AddWithValue("@id", tbxSearchId.Text.ToString()); }

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, plusSql) > 0) // 검색된 데이터의 행 수 반환
                    dataGridView1.DataSource = dataSet.Tables[plusSql];
                else
                    MessageBox.Show("검색된 데이터가 없습니다.");
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

        private void rbPocketmon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbPocketmon.Checked)
            {
                currentTable = "pocketmon";
                changeDataGridView(currentTable);
            }
        }

        private void rbType_CheckedChanged(object sender, EventArgs e)
        {
            if (rbType.Checked)
            {
                currentTable = "type";
                changeDataGridView(currentTable);
            }
        }

        private void rbTrait_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTrait.Checked)
            {
                currentTable = "trait";
                changeDataGridView(currentTable);
            }
        }

        private void rbSkill_CheckedChanged(object sender, EventArgs e)
        {
            if (rbSkill.Checked)
            {
                currentTable = "skill";
                changeDataGridView(currentTable);
            }
        }

        private void rbTribe_CheckedChanged(object sender, EventArgs e)
        {
            if (rbTribe.Checked)
            {
                currentTable = "tribe";
                changeDataGridView(currentTable);
            }
        }

        private void btnSkillSelect_Click(object sender, EventArgs e)
        {
            string setting = cbxSearchWhat.SelectedItem.ToString();

            string sql = $"select * from skill";
            sql += $" where type1=@type and {setting}<=@value_up and {setting}>=@value_down";
            sql += " order by id";

            dataAdapter.SelectCommand = new MySqlCommand(sql, conn);
            dataAdapter.SelectCommand.Parameters.AddWithValue("@type", cbxSearchType.SelectedItem.ToString());
            dataAdapter.SelectCommand.Parameters.AddWithValue("@value_up", int.Parse(nudUp.Value.ToString()));
            dataAdapter.SelectCommand.Parameters.AddWithValue("@value_down", int.Parse(nudDown.Value.ToString()));

            try
            {
                conn.Open();
                dataSet.Clear();
                if (dataAdapter.Fill(dataSet, "skill") > 0) // 검색된 데이터의 행 수 반환
                    dataGridView1.DataSource = dataSet.Tables["skill"];
                else
                    MessageBox.Show("검색된 데이터가 없습니다.");
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

        private void ExportExcel()
        {
            {
                for (int i = 1; i <= 10; i++)
                {
                    DataGridViewRow row =
                        (DataGridViewRow)dataGridView1.RowTemplate.Clone();

                }
            }


            Microsoft.Office.Interop.Excel._Application excel = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = excel.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;

            try
            {

                worksheet = workbook.ActiveSheet;

                worksheet.Name = "ExportedFromDatGrid";

                int cellRowIndex = 1;
                int cellColumnIndex = 1;


                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < dataGridView1.Columns.Count; j++)
                    {
                        if (cellRowIndex == 1)
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Columns[j].HeaderText;
                        }
                        else
                        {
                            worksheet.Cells[cellRowIndex, cellColumnIndex] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                        }
                        cellColumnIndex++;
                    }
                    cellColumnIndex = 1;
                    cellRowIndex++;
                }

                SaveFileDialog saveDialog = new SaveFileDialog();
                saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                saveDialog.FilterIndex = 2;

                if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    workbook.SaveAs(saveDialog.FileName);
                    MessageBox.Show("Export Successful");
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                excel.Quit();
                workbook = null;
                excel = null;

            }
        }

        private void ExportTxt()
        {
            string path = @"C:\users\" + Environment.UserName + @"\desktop\name.txt";
            TextWriter writer = new StreamWriter(path);
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    writer.Write("\t" + dataGridView1.Rows[i].Cells[j].Value.ToString() + "\t" + "|");
                }
                writer.WriteLine("");
            }
            writer.Close();
            MessageBox.Show("Data Exported");
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            ExportExcel();
        }

        private void btnExportTxt_Click(object sender, EventArgs e)
        {
            ExportTxt();
        }
    }
}
