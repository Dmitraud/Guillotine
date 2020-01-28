using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
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

        //------------------------------------------------------------


        private void WHArrInit(int[] W, int[] H) //Формирование массивов длин и ширин из данных с таблицы
        {
            for (int i = 0; i < W.Length - 1; i++)
            {
                W[i] = Convert.ToInt16(TableBlankParam[0, i].Value);
                H[i] = Convert.ToInt16(TableBlankParam[1, i].Value);
                TableBlankParam[2, i].Value = (double)(W[i] * H[i] / 1000);
                //if (HeightArray[i] > maxY) maxY = HeightArray[i];
                // MessageBox.Show(Convert.ToString(WidthHeightArray[i, 0]) + "  " + Convert.ToString(WidthHeightArray[i, 1]));
                //g.DrawRectangle(Pens.Blue, new Rectangle(x, y, WidthArray[i], HeightArray[i]));
                //x += WidthArray[i] + 2;

            }
        }

        private void BlanksSort(int[] W, int[] H) //Сортировка заготовок от большей к меньшей
        {
            int n = W.Length;
            int tW = 0;
            int tH = 0;
            for (int j = 1; j < n; j++)
            {
                for (int i = 1; i < n; i++)
                {
                    //W 51 34 21 55 88 99 40
                    //H 81 83 34 67 89 21 22

                    if ((W[i] > W[i - 1] && W[i] > H[i - 1]) || H[i] > H[i - 1] && H[i] > W[i - 1])
                    {
                        tW = W[i]; tH = H[i];
                        W[i] = W[i - 1]; H[i] = H[i - 1];
                        W[i - 1] = tW; H[i - 1] = tH;
                    }
                }
            }

        }



        private void BlanksSortByHeight(int[] W, int[] H) //Сортировка заготовок от большей к меньшей по ширине
        {
            
            int n = W.Length;
            int tW = 0;
            int tH = 0;
            for (int j = 1; j < n; j++)
            {
                for (int i = 1; i < n; i++)
                {
                    //W 51 34 21 55 88 99 40
                    //H 81 83 34 67 89 21 22

                    if (H[i] > H[i - 1])
                    {
                        tW = W[i]; tH = H[i];
                        W[i] = W[i - 1]; H[i] = H[i - 1];
                        W[i - 1] = tW; H[i - 1] = tH;
                    }
                }
            }

        }



        //-------------------------------------------------------------------------------
        private void BlanksCreate(int[] W, int[] H, Rectangle[] BlanksArr) //Формирование массива заготовок из данных с таблицы
        {                      
            for(int i=0; i<W.Length-1; i++)  
            {
                BlanksArr[i] = new Rectangle(0, 0, W[i], H[i]);                
            }
        }

        //Поворот прямоугольника на 90 градусов (не используется)
        private void Rotate(Rectangle r)
        {
            int t = r.Width;
            r.Width = r.Height;
            r.Height = t;

        }
    //______________________________________________________________________

    //Вывод в текстовый файл количества и размеров пустого пространства (для отладки)
        private void EmptyPrint(List <Rectangle> rectangles) { 
            string writePath = @"C:\Users\User\Desktop\LOG.txt";

            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine("________________________");
            }

            
            for (int i = 0; i < rectangles.Count; i++)
            {
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(i+".  "+rectangles[i].Width+" "+rectangles[i].Height);
                    //sw.Write(4.5);
                }
            }
        }
        //______________________________________________________________

       //Сортировка массива пустых прямоугольников
        private void EmptySort(List<Rectangle> Ob) 
        {
            int n = Ob.Count;
            int tW = 0;
            int tH = 0;
            for (int j = 1; j < n; j++)
            {
                for (int i = 1; i < n; i++)
                {

                    //if ((Ob[i].Width < Ob[i-1].Width && Ob[i].Width < Ob[i-1].Height) || Ob[i].Height < Ob[i-1].Height && Ob[i].Height < Ob[i-1].Width)
                    if ( Ob[i].Height > Ob[i - 1].Height)
                    //if (Ob[i].Width > Ob[i - 1].Width)

                    {
                        tW = Ob[i].Width; tH = Ob[i].Height;
                        Rectangle temp = Ob[i];
                        Rectangle temp1 = Ob[i-1];

                        temp.Width = Ob[i - 1].Width; temp.Height = Ob[i-1].Height;
                        temp1.Width = tW; temp.Height = tH;
                        Ob[i] = temp;
                        Ob[i - 1] = temp1;
                        
                    }
                }
            }

        }
        //_________________________________________________________________
     
        //**************************************************************
            private void BtnCompute_Click(object sender, EventArgs e)
        {
            pictureBox1.Refresh(); //Очистка области для рисования
            panel1.Width = this.Width - TableBlankParam.Width - 100;// Ширина области для рисования в зависимости от ширины формы
            panel1.Height = this.Height - 100;

            int n = TableBlankParam.RowCount; //Количество строк в таблице
            int k = 2;                                  
            int[] WidthArray = new int[n]; //Массивы длин и ширин заготовок
            int[] HeightArray = new int[n];
            //int t = 0;
            Rectangle[] BlanksArray = new Rectangle[n];//Массив заготовок

            WHArrInit(WidthArray, HeightArray);

            //BlanksSort(WidthArray, HeightArray);
            BlanksSortByHeight(WidthArray, HeightArray);
            BlanksCreate(WidthArray, HeightArray, BlanksArray);
            Rectangle OriginBlock = new Rectangle(pictureBox1.Left, pictureBox1.Top, pictureBox1.Width,BlanksArray[0].Height);//Исходный материал
            OriginBlock.Width -= 5;
            int wid = 0;


            List<Rectangle> Ob1 = new List<Rectangle>();//Динамический список пустых прямоугольников
            Ob1.Add(OriginBlock);
            float sc = (float)numericUpDown1.Value;
            Graphics g = pictureBox1.CreateGraphics();
            g.ScaleTransform(sc, sc);//Масштабирование
            SolidBrush brush1 = new SolidBrush(Color.Blue);
            SolidBrush brush2 = new SolidBrush(Color.Black);

            //g.FillRectangle(brush1, Ob1[0]);
            
            SolidBrush brush = new SolidBrush(Color.Red);

            Pen p = new Pen(Color.Black, 2);
            g.DrawRectangle(p, Ob1[0]);
            

            for (int i=0; i < n - 1; i++)
            {
                EmptySort(Ob1);//Сортировка списка пустых прямоугольников

                for (int j = 0; j < Ob1.Count ; j++)
                {
                    //if (BlanksArray[i].Width > Ob1[j].Width && j!=Ob1.Count-1) continue;
                    if (Ob1[j].Width < 1 || Ob1[j].Height < 1) { Ob1.RemoveAt(j); k--; }
                    
                    
                    //Размер заготовки равен размеру пустого прямоугольника
                    if ((BlanksArray[i].Width == Ob1[j].Width) && (BlanksArray[i].Height == Ob1[j].Height))
                    {
                        BlanksArray[i].X = Ob1[j].X;
                        BlanksArray[i].Y = Ob1[j].Y;
                        g.FillRectangle(brush, BlanksArray[i]);
                        Ob1.RemoveAt(j); k--; break;
                        //Ob1[j] = new Rectangle(BlanksArray[i].Left, BlanksArray[i].Bottom, Ob1[j].Width, Ob1[j].Height - BlanksArray[i].Height);
                        //Ob[j] = new Rectangle(BlanksArray[i].Right, BlanksArray[i].Top, Ob[j].Width - BlanksArray[i].Width, BlanksArray[i].Height);
                        //g.DrawRectangle(p, Ob1[j]);
                        //g.DrawRectangle(p, Ob[j + 1]);

                    }

                    //Высота заготовки равна высоте пустого прямоугольника, а ширина меньше
                    else if ((BlanksArray[i].Width < Ob1[j].Width) && (BlanksArray[i].Height == Ob1[j].Height))
                    {
                        BlanksArray[i].X = Ob1[j].X;
                        BlanksArray[i].Y = Ob1[j].Y;
                        g.FillRectangle(brush, BlanksArray[i]);

                        wid += BlanksArray[i].Width;
                        label3.Text = wid.ToString();
                        //Ob1.Add(new Rectangle(BlanksArray[i].Left, BlanksArray[i].Bottom, Ob1[j].Width, Ob1[j].Height - BlanksArray[i].Height));
                        Ob1[j] = new Rectangle(BlanksArray[i].Right, BlanksArray[i].Top, OriginBlock.Width - BlanksArray[i].Right, BlanksArray[i].Height);
                        g.DrawRectangle(p, Ob1[j]); break;
                        //g.DrawRectangle(p, Ob1[Ob1.Count - 1]);

                    }

                    //Ширина заготовки равна ширине пустого прямоугольника, а высота меньше
                    else if ((BlanksArray[i].Width == Ob1[j].Width) && (BlanksArray[i].Height < Ob1[j].Height))
                    {

                        BlanksArray[i].X = Ob1[j].X;
                        BlanksArray[i].Y = Ob1[j].Y;
                        g.FillRectangle(brush, BlanksArray[i]);

                        //Ob1.Add(new Rectangle(BlanksArray[i].Left, BlanksArray[i].Bottom, Ob1[j].Width, Ob1[j].Height - BlanksArray[i].Height));
                        Ob1[j] = new Rectangle(BlanksArray[i].Left, BlanksArray[i].Bottom, Ob1[j].Width, Ob1[j].Height - BlanksArray[i].Height);
                        g.DrawRectangle(p, Ob1[j]); break;
                        //g.DrawRectangle(p, Ob1[Ob1.Count - 1]);
                    }

                    //Высота и ширина заготовки меньше высоты и ширины пустого прямоугольника
                    else if ((BlanksArray[i].Width < Ob1[j].Width) && (BlanksArray[i].Height < Ob1[j].Height))
                    {
                        BlanksArray[i].X = Ob1[j].X;
                        BlanksArray[i].Y = Ob1[j].Y;
                        g.FillRectangle(brush, BlanksArray[i]);
                        wid += BlanksArray[i].Width;
                        Ob1.Add(new Rectangle(BlanksArray[i].Left, BlanksArray[i].Bottom, OriginBlock.Width-BlanksArray[i].Left, Ob1[j].Height - BlanksArray[i].Height));
                        Ob1[j] = new Rectangle(BlanksArray[i].Right, BlanksArray[i].Top, OriginBlock.Width - BlanksArray[i].Right, BlanksArray[i].Height);
                        label3.Text = wid.ToString();
                        label4.Text = Ob1[Ob1.Count-1].Width.ToString();
                        g.DrawRectangle(p, Ob1[j]);
                        g.DrawRectangle(p, Ob1[Ob1.Count - 1]);
                        k++;
                        //
                        break;
                    }

                    

                  //  else if ((BlanksArray[i].Height > Ob1[j].Height && BlanksArray[i].Height<= Ob1[j].Width && BlanksArray[i].Width<= Ob1[j].Height) || (BlanksArray[i].Width > Ob1[j].Width && BlanksArray[i].Width <= Ob1[j].Height && BlanksArray[i].Height<=Ob1[j].Width)) {
                   //     Rotate(BlanksArray[i]);
                  //      i--; break;
                  //  }

                //else if ((BlanksArray[i].Width > OriginBlock.Width- wid && ))// || BlanksArray[i].Width > Ob1[Ob1.Count - 1].Width))
                   
                   //Приращение вниз если не осталось места                    
                    else if ((BlanksArray[i].Width > Ob1[j].Width || BlanksArray[i].Height > Ob1[j].Height)&& j==Ob1.Count-1)
                    {
                        BlanksArray[i].X = pictureBox1.Left;
                        BlanksArray[i].Y = OriginBlock.Bottom;
                        
                        panel1.Height += BlanksArray[i].Height;
                        pictureBox1.Height += BlanksArray[i].Height;
                        //wid = OriginBlock.Width - BlanksArray[i].Width;
                        OriginBlock.Height += BlanksArray[i].Height;
                        //pictureBox1.Refresh();
                        //hei -= BlanksArray[t].Height; t++;

                        g.FillRectangle(brush, BlanksArray[i]);
                        g.DrawLine(p, BlanksArray[i].X, BlanksArray[i].Y, BlanksArray[i].Right, BlanksArray[i].Top);
                        //Ob1.Add(new Rectangle(BlanksArray[i].Left, BlanksArray[i].Bottom, OriginBlock.Width- BlanksArray[i].Left, BlanksArray[i].Height));
                        //g.DrawRectangle(p, Ob1[Ob1.Count - 1]);
                        Ob1.Add(new Rectangle(BlanksArray[i].Right, BlanksArray[i].Top, OriginBlock.Width - BlanksArray[i].Right, BlanksArray[i].Height));
                        g.DrawRectangle(p, Ob1[Ob1.Count - 1]);
                        wid = BlanksArray[i].Width;
                        //label3.Text = wid.ToString();
                        //k++;//k++;
                        break;
                    }
                    else continue;
                   
                }
                //Маркировка размеров на заготовках
                if (BlanksArray[i].Width / BlanksArray[i].Height < 0.5)
                {
                    using (Font TextFont = new Font("Arial", (BlanksArray[i].Width + BlanksArray[i].Height) / 12, FontStyle.Bold))
                    {
                        StringFormat sf = new StringFormat(StringFormatFlags.DirectionVertical);
                        g.DrawString(BlanksArray[i].Width.ToString() + "x" + BlanksArray[i].Height.ToString(), TextFont, brush2, BlanksArray[i].Location,sf);
                    }
                }

                else
                {
                    using (Font TextFont = new Font("Arial", (BlanksArray[i].Width + BlanksArray[i].Height) / 12, FontStyle.Bold))
                    {
                        //StringFormat sf = new StringFormat(StringFormatFlags.DirectionVertical);
                        g.DrawString(BlanksArray[i].Width.ToString() + "x" + BlanksArray[i].Height.ToString(), TextFont, brush2, BlanksArray[i].Location);
                    }
                }
                //______________________________________________
            }
            EmptyPrint(Ob1); //Вывод данных в LOG.txt

            //MessageBox.Show(Ob1.Count.ToString());

            /*
            try
            {
                int SpaceForDrawWidth = this.Width - TableBlankParam.Width;//Свободное место на форме для рисования
                //pictureBox1.Width = SpaceForDrawWidth;




            }
            catch(System.FormatException ex)
            {
                MessageBox.Show("Таблица содержит недопустимые символы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //ArrSort
            */

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
            openFileDialog1.Filter = "Файлы базы данных Access (*.accdb)|*.accdb|Файлы базы данных Access 2002-2003 (*.mdb)|*.mdb";
            this.MinimumSize = new Size (770, 430);
            BtnCompute.Enabled = true;

        }


       
        private void Form1_Resize(object sender, System.EventArgs e)
        {

        }



        protected override void OnPaint(PaintEventArgs e)
        {
           // e.Graphics.DrawRectangle(Pens.Blue, new Rectangle(10, 10, 100, 100));
        }

        private void TableBlankParam_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (TableBlankParam[0, 0].Value !=null && TableBlankParam[1, 0].Value != null) BtnCompute.Enabled = true;
            else BtnCompute.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)//Тестовая кнопка
        {
            //Graphics g1 = pictureBox1.CreateGraphics();
            //SolidBrush brush1 = new SolidBrush(Color.Blue); 
            //Rectangle B = new Rectangle(0,0,70,70);
            //g1.FillRectangle(brush1, B);
            //Rectangle[] Ob = new Rectangle[1];
            //Slice(B, OriginBlock);
            panel1.Width += 50;
            pictureBox1.Width += 50;
            


        }
    }
}
