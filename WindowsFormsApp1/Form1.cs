using Npgsql;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using System.Xml;
using System.Globalization;
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{

    public partial class Form1 : Form
    {
        public Form Form2 = new Form();
        private NpgsqlConnection con;
        private string connString =
            "Host=127.0.0.1;Username=postgres;Password=Kostia09;Database=postgres";
        string[] Tables =
            new string[6] { "tourists", "touristsinfo", "tours", "seasons", "paid", "travelpackage" };
        private void loadTable(string TableName)
        {
            string Quote = "SELECT * FROM " + TableName;
            System.Data.DataTable dt = new System.Data.DataTable();
            NpgsqlDataAdapter adap = new NpgsqlDataAdapter(Quote, con);
            adap.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        public Form1()
        {
            InitializeComponent();
            con = new NpgsqlConnection(connString);
            con.Open();
            loadTable("tourists");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 = new Form();
            Form2.Height = 200;
            Form2.Width = 100 + 110 * dataGridView1.Columns.Count;
            int X = 10, Y = 50;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
                txt.Name = dataGridView1.Columns[i].Name;
                txt.Text = "";
                txt.Location = new System.Drawing.Point(X + 25, Y);
                X += 115;
                Form2.Controls.Add(txt);
            }

            X = 10;
            Y = 50;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
                lbl.Text = dataGridView1.Columns[i].Name;
                lbl.Location = new System.Drawing.Point(X + 35, Y - 15);
                X += 115;
                Form2.Controls.Add(lbl);
            }

            System.Windows.Forms.Button btnYes = new System.Windows.Forms.Button();
            btnYes.DialogResult = DialogResult.OK;
            btnYes.Text = "Принять";
            btnYes.Location = new System.Drawing.Point((Form2.Width / 3), 100);
            btnYes.Click += new EventHandler(btnYes_Click);
            Form2.Controls.Add(btnYes);

            System.Windows.Forms.Button btnNo = new System.Windows.Forms.Button();
            btnNo.DialogResult = DialogResult.Cancel;
            btnNo.Text = "Отмена";
            btnNo.Location = new System.Drawing.Point((Form2.Width / 2), 100);
            btnNo.Click += new EventHandler(btnNo_Click);
            Form2.Controls.Add(btnNo);

            Form2.Show();
        }


        void btnYes_Click(object sender, EventArgs e)
        {
            string tablename = Tables[tabControl1.SelectedIndex];
            string Insert = "SELECT * FROM \"" + tablename + "\" LIMIT 1";
            NpgsqlCommand cmd = new NpgsqlCommand(Insert, con);
            NpgsqlDataReader npgsqlDataReader = cmd.ExecuteReader();
            npgsqlDataReader.Read();
            Insert = "INSERT INTO \"" + tablename + "\" VALUES (";
            for (int i = 0; i < npgsqlDataReader.FieldCount; i++)
            {
                if (npgsqlDataReader.GetFieldType(i) == typeof(System.String))
                    Insert += "\'" + Form2.Controls[i].Text + "\', ";
                else
                    Insert += Form2.Controls[i].Text + ", ";
            }
            npgsqlDataReader.Close();
            Insert = Insert.Remove(Insert.Length - 2);
            Insert += ")";
            Console.WriteLine(Insert);
            cmd = new NpgsqlCommand(Insert, con);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            Form2.Close();
        }


        void btnNo_Click(object sender, EventArgs e)
        {
            Form2.Close();
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Form2 = new Form();
            Form2.Height = 200;
            Form2.Width = 100 + 110 * dataGridView1.Columns.Count;
            int X = 10, Y = 50;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                System.Windows.Forms.TextBox txt = new System.Windows.Forms.TextBox();
                txt.Name = dataGridView1.Columns[i].Name;
                txt.Text = dataGridView1.CurrentRow.Cells[i].Value.ToString();
                txt.Location = new System.Drawing.Point(X + 25, Y);
                X += 115;
                Form2.Controls.Add(txt);
            }

            X = 10;
            Y = 50;
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                System.Windows.Forms.Label lbl = new System.Windows.Forms.Label();
                lbl.Text = dataGridView1.Columns[i].Name;
                lbl.Location = new System.Drawing.Point(X + 35, Y - 15);
                X += 115;
                Form2.Controls.Add(lbl);
            }

            System.Windows.Forms.Button btnYes = new System.Windows.Forms.Button();
            btnYes.DialogResult = DialogResult.OK;
            btnYes.Text = "Принять";
            btnYes.Location = new System.Drawing.Point((Form2.Width / 3), 100);
            btnYes.Click += new EventHandler(btnYesChange_Click);
            Form2.Controls.Add(btnYes);

            System.Windows.Forms.Button btnNo = new System.Windows.Forms.Button();
            btnNo.DialogResult = DialogResult.Cancel;
            btnNo.Text = "Отмена";
            btnNo.Location = new System.Drawing.Point((Form2.Width / 2), 100);
            btnNo.Click += new EventHandler(btnNoChange_Click);
            Form2.Controls.Add(btnNo);

            Form2.Show();
        }

        void btnYesChange_Click(object sender, EventArgs e)
        {
            string tablename = Tables[tabControl1.SelectedIndex];
            string Insert = "SELECT * FROM \"" + tablename + "\" LIMIT 1";
            NpgsqlCommand cmd = new NpgsqlCommand(Insert, con);
            NpgsqlDataReader npgsqlDataReader = cmd.ExecuteReader();
            npgsqlDataReader.Read();
            Insert = "UPDATE \"" + tablename + "\" SET ";
            for (int i = 0; i < npgsqlDataReader.FieldCount; i++)
            {
                if (npgsqlDataReader.GetFieldType(i) == typeof(System.String))
                    Insert += dataGridView1.Columns[i].Name.ToString() + " = \'" + Form2.Controls[i].Text + "\', ";
                else
                    Insert += dataGridView1.Columns[i].Name.ToString() + " = " + Form2.Controls[i].Text + ", ";
            }
            npgsqlDataReader.Close();
            Insert = Insert.Remove(Insert.Length - 2);
            Insert += " WHERE " + dataGridView1.Columns[0].Name.ToString() + " = " + dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Console.WriteLine(Insert);
            cmd = new NpgsqlCommand(Insert, con);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
            Form2.Close();
        }

        void btnNoChange_Click(object sender, EventArgs e)
        {
            Form2.Close();
        }

        private void IfSelected(object sender, TabControlEventArgs e)
        {
            if (tabControl1.SelectedIndex < Tables.Length)
            {
                loadTable(Tables[tabControl1.SelectedIndex]);
                panel1.Visible = false;
                dataGridView1.Width = 776;
                dataGridView1.Height = 370;
                if (tabControl1.SelectedIndex == 0)
                {
                    Trigger.Visible = true;
                }
                else
                    Trigger.Visible = false;
            }
            else
            {
                panel1.Visible = true;
                dataGridView1.DataSource = null;
                dataGridView1.Rows.Clear();
                dataGridView1.Width = 390;
                dataGridView1.Height = 370;
            }
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            string tablename = Tables[tabControl1.SelectedIndex];
            string rowindex = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            string columnname = dataGridView1.Columns[0].Name.ToString();
            string sql = "DELETE FROM " + "\"" + tablename + "\"" + " WHERE " + "\"" + columnname + "\"" + " = " + rowindex;
            NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
            cmd.Prepare();
            cmd.ExecuteNonQuery();
        }

        private void ConfirmAggrSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = AggSelect.Text;
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                System.Data.DataTable dt = new System.Data.DataTable();
                NpgsqlDataAdapter adap = new NpgsqlDataAdapter(sql, con);
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Npgsql.PostgresException)
            {
                string message = "Неправильно набранная команда!";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }

        private void ConfigParamSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string sql = ParamSelect.Text.ToString();
                Console.WriteLine(sql);
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                System.Data.DataTable dt = new System.Data.DataTable();
                NpgsqlDataAdapter adap = new NpgsqlDataAdapter(sql, con);
                adap.Fill(dt);
                dataGridView1.DataSource = dt;
            }
            catch (Npgsql.PostgresException)
            {
                string message = "Неправильно набранная команда!";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
        }

        private void ExpWriter_Click(object sender, EventArgs e)
        {
            XmlWriter xmlWriter = XmlWriter.Create("test.xml");
            xmlWriter.WriteStartDocument();
            xmlWriter.WriteStartElement("Data");
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                xmlWriter.WriteStartElement("row");
                for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                {
                    Console.WriteLine(dataGridView1.Rows[i].Cells[j].Value.ToString());
                    xmlWriter.WriteAttributeString(dataGridView1.Columns[j].HeaderText.ToString(),
                        dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
                xmlWriter.WriteEndElement();
            }
            xmlWriter.WriteEndDocument();
            xmlWriter.Close();
        }

        private void ExpDocument_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            XmlNode rootNode = xmlDoc.CreateElement("Data");
            xmlDoc.AppendChild(rootNode);
            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                XmlNode userNode = xmlDoc.CreateElement("Row");
                for (int j = 0; j < dataGridView1.Rows[i].Cells.Count; j++)
                {
                    XmlAttribute attribute = xmlDoc.CreateAttribute(dataGridView1.Columns[j].HeaderText.ToString());
                    attribute.Value = dataGridView1.Rows[i].Cells[j].Value.ToString();
                    userNode.Attributes.Append(attribute);
                }
                rootNode.AppendChild(userNode);
            }
            xmlDoc.Save("test-doc.xml");
        }

        private void ImpReader_Click(object sender, EventArgs e)
        {
            XmlReader xmlReader = XmlReader.Create("test.xml");
            DataSet dataSet = new DataSet();
            dataSet.ReadXml(xmlReader);
            dataGridView1.DataSource = dataSet.Tables["Row"];
            xmlReader.Close();
        }

        private void ImpDocument_Click(object sender, EventArgs e)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load("test-doc.xml");
            DataSet dataSet = new DataSet();
            XmlReader xmlReader = new XmlNodeReader(xmlDoc);
            dataSet.ReadXml(xmlReader);
            dataGridView1.DataSource = dataSet.Tables["Row"];
            xmlReader.Close();
        }

        private void Trigger_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count == 0)
            {
                string message = "Должен быть выбран элемент!";
                string caption = "Error Detected in Input";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            else
            {
                //Найдём тур с наименьшей стоимостью
                string sql = "SELECT tour_id, price FROM tours WHERE price = (SELECT MIN(price) FROM tours)";
                NpgsqlCommand cmd = new NpgsqlCommand(sql, con);
                NpgsqlDataReader Reader = cmd.ExecuteReader();
                Reader.Read();
                string TourId = Reader[0].ToString();
                string TourPrice = Reader[1].ToString();
                Reader.Close();
                cmd.Cancel();
                TourPrice = TourPrice.Replace(",", ".");
                //Создадим новый тур.
                //Выберем новый id для этого тура
                sql = "SELECT MAX(season_id) FROM seasons";
                cmd = new NpgsqlCommand(sql, con);
                Reader = cmd.ExecuteReader();
                Reader.Read();
                string SeasonsIDString = Reader[0].ToString();
                Reader.Close();
                cmd.Cancel();
                int SeasonsID = Int16.Parse(SeasonsIDString) + 1;
                //Составим запрос, заполняющй таблицу seasons
                sql = "INSERT INTO seasons(season_id, tour_id, price) VALUES(" + SeasonsID.ToString() + ", " + TourId + ", "
                    + TourPrice + ")";
                cmd = new NpgsqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                string IndexOfTourist = dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells[0].Value.ToString();
                //Выберем новый id для этого travelpackage
                sql = "SELECT MAX(travelpackage_id) FROM travelpackage";
                cmd = new NpgsqlCommand(sql, con);
                Reader = cmd.ExecuteReader();
                Reader.Read();
                string TPID = Reader[0].ToString();
                Reader.Close();
                cmd.Cancel();
                if (TPID == "")
                    TPID = "1";
                else
                    TPID = (Int16.Parse(TPID) + 1).ToString();
                //Составим запрос, заполняющй таблицу travelpackage
                sql = "INSERT INTO travelpackage VALUES(" + TPID + ", " + IndexOfTourist + ", "
                    + SeasonsID + ")";
                cmd = new NpgsqlCommand(sql, con);
                cmd.ExecuteNonQuery();
                tabControl1.SelectTab(5);

            }
        }
    }
}