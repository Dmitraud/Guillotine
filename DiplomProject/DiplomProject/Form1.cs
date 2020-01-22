using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace DiplomProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TlpBlanksParam_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnCompute_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
            int n = TableBlankParam.RowCount; //Количество строк в таблице

            try
            {
                int[,] LengthWidthArray = new int[n, 2]; //Массив длин и ширин заготовок
                int SpaceForDrawWidth = this.Width - TableBlankParam.Width;//Свободное место на форме для рисования
                pictureBox1.Width = SpaceForDrawWidth;
                int x = 0, y = 0;
                int maxY = 0;
                Graphics g = pictureBox1.CreateGraphics();
                for (int i = 0; i < n - 1; i++)
                {
                    LengthWidthArray[i, 0] = Convert.ToInt16(TableBlankParam[0, i].Value);
                    LengthWidthArray[i, 1] = Convert.ToInt16(TableBlankParam[1, i].Value);
                    if (LengthWidthArray[i, 1] > maxY) maxY = LengthWidthArray[i, 1];
                    MessageBox.Show(Convert.ToString(LengthWidthArray[i, 0]) + "  " + Convert.ToString(LengthWidthArray[i, 1]));
                    g.DrawRectangle(Pens.Blue, new Rectangle(x, y, LengthWidthArray[i, 0], LengthWidthArray[i, 1]));
                    x += LengthWidthArray[i, 0] + 2;

                    if (x > 350)
                    {
                        x = 0;
                        y += maxY + 2;
                        maxY = 0;
                    }

                }
            }
            catch(System.FormatException ex)
            {
                MessageBox.Show("Таблица содержит недопустимые символы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            

        }

        private void NumBlankCount_ValueChanged(object sender, EventArgs e)
        {
          //  TableBlankParam.RowCount= (int)NumBlankCount.Value;
           // int i = (int)NumBlankCount.Value-1;
          //  TableBlankParam[0, i].Value = i+1;
          //  i++;

        }


        private void btnDBOpen_Click(object sender, EventArgs e)
        {
            
            
                openFileDialog1.DefaultExt = ".txt";
                openFileDialog1.ShowDialog();
            
                BindingSource bs;
                OleDbDataAdapter adapter;
                DataTable dt;


                string DBName = @openFileDialog1.FileName;
                label1.Text = "Выбрана база " + DBName;
                string CmdText = "SELECT * FROM [Таблица1]";

                string ConnString = @"Driver={Microsoft Access Driver (*.mdb)}; DBQ=DBName";

                string conBD = string.Format("Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0}", DBName);

                OleDbConnection connection = new OleDbConnection(conBD);
            try
            {
                
                connection.Open();
                TableBlankParam.Columns.Clear();
                string query1 = "SELECT * FROM Таблица1";
                OleDbCommand cmd1 = new OleDbCommand(query1, connection);

                dt = new DataTable();

                adapter = new OleDbDataAdapter(cmd1);
                OleDbCommandBuilder AccessCommandBuilder = new OleDbCommandBuilder(adapter);
                adapter.Fill(dt);
                dt.Columns.Remove("Код"); //Удаление лишнего столбца после импорта БД

                TableBlankParam.DataSource = dt;
                BtnCompute.Enabled = true;
            }

            catch (System.Data.OleDb.OleDbException ex)
            {
                MessageBox.Show("База данных не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label1.Text = "";
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        { 
            openFileDialog1.Filter = "Текстовые файлы (*.txt)|*.txt|Файлы базы данных Access (*.accdb)|*.accdb|Файлы базы данных Access 2002-2003 (*.mdb)|*.mdb";
            this.MinimumSize = new Size (770, 430);
            BtnCompute.Enabled = false;
            
        }


       
        private void Form1_Resize(object sender, System.EventArgs e)
        {

        }



        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.DrawRectangle(Pens.Blue, new Rectangle(10, 10, 100, 100));
        }

        private void TableBlankParam_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (TableBlankParam[0, 0].Value !=null && TableBlankParam[1, 0].Value != null) BtnCompute.Enabled = true;
            else BtnCompute.Enabled = false;
            
        }
    }
}
