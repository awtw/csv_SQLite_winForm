using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpliteHelper
{
    public partial class Form1 : Form
    {
        public enum SearchColName
        {
            時間,
            第1段溫度顯示值,
            第2段溫度顯示值,
            第3段溫度顯示值,
            第4段溫度顯示值,
            第5段溫度顯示值,
            第6段溫度顯示值,
        }


        public string FileName { get; set; }
        public int InsertInformation { get; set; }
        public List<TemperatureRecord> TemperatureRecords { get; set; }
        public string DeleteRowSelect { get; set; }

        public string DbPath = @"C:\Users\xps15\source\repos\SQLite_Re\SQLite_Re\bin\Debug\database.sqlite3";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DatabaseHelper.DatabasePath = DbPath;

            comboBox1.DataSource = Enum.GetValues(typeof(SearchColName));
        }


        private void btnCsv_Click(object sender, EventArgs e)
        {
            TemperatureRecords?.Clear();
            try
            {
                using (var ofd = new OpenFileDialog() { Filter = "CSV|*.csv", ValidateNames = true, Multiselect = false })
                {
                    if (ofd.ShowDialog() == DialogResult.OK)
                    {
                        var temp = CsvHelper.Import(ofd.FileName);
                        TemperatureRecords = new List<TemperatureRecord>();
                        foreach (var item in temp)
                        {
                            var key = Guid.NewGuid().ToString();
                            //MessageBox.Show(key);
                            TemperatureRecords.Add(new TemperatureRecord()
                            {
                                ID = key,
                                時間 = Convert.ToDateTime(item.時間),
                                第1段溫度顯示值 = Convert.ToDouble(item.第1段溫度顯示值),
                                第2段溫度顯示值 = Convert.ToDouble(item.第2段溫度顯示值),
                                第3段溫度顯示值 = Convert.ToDouble(item.第3段溫度顯示值),
                                第4段溫度顯示值 = Convert.ToDouble(item.第4段溫度顯示值),
                                第5段溫度顯示值 = Convert.ToDouble(item.第5段溫度顯示值),
                                第6段溫度顯示值 = Convert.ToDouble(item.第6段溫度顯示值)

                            });

                        }
                        dataGridView1.DataSource = TemperatureRecords;
                        dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        dataGridView1.Columns["ID"].Visible = false;
                        FileName = ofd.FileName;

                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDownload_Click(object sender, EventArgs e)
        {
            if (TemperatureRecords == null)
            {
                MessageBox.Show("Please Open the database first !");
            }
            else
            {
                using (var sfd = new SaveFileDialog())
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        CsvHelper.Export(sfd.FileName, TemperatureRecords);
                    }
                }

                MessageBox.Show("Download Complete");
            }

        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (FileName == null)
            {
                MessageBox.Show("Select csv File first !");
            }
            else
            {
                DatabaseHelper.Insert(TemperatureRecords);
                MessageBox.Show("Insert Complete !");
            }
            btnInsert.Click += new EventHandler(btnDatabase_Click);


        }

        private void btnDatabase_Click(object sender, EventArgs e)
        {
            UpdateGridView();
        }

        private void UpdateGridView()
        {
            dataGridView1.ClearSelection();
            TemperatureRecords?.Clear();
            TemperatureRecords = DatabaseHelper.Get();
            dataGridView1.DataSource = TemperatureRecords;
            dataGridView1.Columns["ID"].Visible = false;
            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.ReadOnly = true;

            var result = TemperatureRecords[dataGridView1.CurrentCell.RowIndex];
            DatabaseHelper.Update(result);

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null)
                MessageBox.Show("Please select row first !");
            else
            {

                var question = MessageBox.Show("Please confirm the deletion of the field", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (question == DialogResult.Yes)
                {
                    DatabaseHelper.Delete(TemperatureRecords[dataGridView1.CurrentCell.RowIndex].ID);
                    UpdateGridView();
                }

            }
        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (TemperatureRecords == null)
            {
                MessageBox.Show("You have to open database first !");
            }
            else
            {
                TemperatureRecords?.Clear();
                if (string.IsNullOrWhiteSpace(txtFrom.Text) && string.IsNullOrWhiteSpace(txtTo.Text))
                {
                    MessageBox.Show("Please select Search item first !");
                }
                else
                {
                    if ((SearchColName)comboBox1.SelectedItem == SearchColName.時間)
                    {
                       
                        if(DateTime.TryParse(txtFrom.Text, out DateTime timeFrom)  &&  DateTime.TryParse(txtTo.Text, out DateTime timeTo))
                        {
                            TemperatureRecords = DatabaseHelper.Get(timeFrom, timeTo, SearchColName.時間.ToString());
                            dataGridView1.DataSource = TemperatureRecords;
                        }
                        else
                        {
                            MessageBox.Show("DateTime format error !");
                        }
                       
                    }
                    else
                    {
                        TemperatureRecords = DatabaseHelper.Get(comboBox1.SelectedItem.ToString(), txtFrom.Text, txtTo.Text);
                        dataGridView1.DataSource = TemperatureRecords;
                    }

                    dataGridView1.Columns["ID"].Visible = false;
                    dataGridView1.ReadOnly = true;
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }


            }
        }

        private void btnCount_Click_1(object sender, EventArgs e)
        {
            if (TemperatureRecords != null)
            {
                row.Text = TemperatureRecords.Count.ToString();
                var result = CalculatorHelper.CalStd(TemperatureRecords);

                sd1.Text = result[0].ToString();
                sd2.Text = result[1].ToString();
                sd3.Text = result[2].ToString();
                sd4.Text = result[3].ToString();
                sd5.Text = result[4].ToString();
                sd6.Text = result[5].ToString();
               

               
                minText.Text =  CalculatorHelper.GetMinValue(TemperatureRecords).ToString();
                maxText.Text =  CalculatorHelper.GetMaxValue(TemperatureRecords).ToString();

            }
        }
    }
}
