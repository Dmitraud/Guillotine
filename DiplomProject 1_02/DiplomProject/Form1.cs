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


        //------------------------------------------------------------

        //Удаление пустых строк таблицы
        private void TableCheck(DataGridView table)
        {
            try
            {
                int n = TableBlankParam.RowCount;
                for (int i = 0; i < TableBlankParam.RowCount - 1; i++)
                {
                    if ((Convert.ToInt32(TableBlankParam[0, i].Value) == 0) || (Convert.ToInt32(TableBlankParam[1, i].Value) == 0) || (TableBlankParam[0, i].Value == null) || (TableBlankParam[1, i].Value == null))
                    {
                        n--;
                        TableBlankParam.Rows.RemoveAt(i); i--;
                    }
                    else if (Convert.ToInt32(TableBlankParam[0, i].Value) < 0 || Convert.ToInt32(TableBlankParam[0, i].Value) < 0)
                    {
                        TableBlankParam[0, i].Value = Math.Abs(Convert.ToInt32(TableBlankParam[0, i].Value));
                        TableBlankParam[1, i].Value = Math.Abs(Convert.ToInt32(TableBlankParam[1, i].Value));
                    }

                    if (Convert.ToInt32(TableBlankParam[0, i].Value) > pictureBox1.Width - 5)
                    {
                        TableBlankParam[0, i].Value = pictureBox1.Width - 5;
                        MessageBox.Show("Ширина заготовки не может превышать выбранную ширину листа. Значение изменено на  " + (pictureBox1.Width - 5) + ". ", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
            }
            catch 
            {
                MessageBox.Show("Таблица пуста или содержит недопустимые символы", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            // TableBlankParam.RowCount = n;
        }


        private void WHArrInit(int[] W, int[] H) //Формирование массивов длин и ширин из данных с таблицы
        {

            this.BlankSquare.DefaultCellStyle.Format = "N2";
            
                for (int i = 0; i < W.Length - 1; i++)
                {
                        W[i] = Convert.ToInt16(TableBlankParam[0, i].Value);
                        H[i] = Convert.ToInt16(TableBlankParam[1, i].Value);

                        //Вычисление площадей заготовок и заполнение соответствующего столбца таблицы
                        TableBlankParam[2, i].Value = (double)(W[i] * H[i]) / 10000;                  
                }
            
            
        }



        //Сортировка заготовок по выбранному критерию
        private void BlanksSort(int[] W, int[] H) 
        {
            
            int n = W.Length;
            int tW = 0;
            int tH = 0;
            string sortType = cBoxSortType.Text;

            for (int j = 1; j < n; j++)
            {
                for (int i = 1; i < n; i++)
                {

                    switch (sortType)
                    {
                        case "Ширине":
                            if (W[i] > W[i - 1])
                            {
                                tW = W[i]; tH = H[i];
                                W[i] = W[i - 1]; H[i] = H[i - 1];
                                W[i - 1] = tW; H[i - 1] = tH;
                            }

                            break;
                        case "Площади":
                            if (W[i]*H[i] > W[i - 1]* H[i - 1])
                            {
                                tW = W[i]; tH = H[i];
                                W[i] = W[i - 1]; H[i] = H[i - 1];
                                W[i - 1] = tW; H[i - 1] = tH;
                            }
                            break;

                        case "Большей стороне":
                            if ((W[i] > W[i - 1] && W[i] > H[i - 1]) || H[i] > H[i - 1] && H[i] > W[i - 1])
                            {
                                tW = W[i]; tH = H[i];
                                W[i] = W[i - 1]; H[i] = H[i - 1];
                                W[i - 1] = tW; H[i - 1] = tH;
                            }
                            break;


                        default:
                            if (H[i] > H[i - 1])
                            {
                                tW = W[i]; tH = H[i];
                                W[i] = W[i - 1]; H[i] = H[i - 1];
                                W[i - 1] = tW; H[i - 1] = tH;                               
                            }
                            break;

                    }
                    
                }
            }

        }


        //-------------------------------------------------------------------------------
        //Сортировка списка пустых прямоугольников
        private void EmptySort(List<Rectangle> Ob)
        {
            int n = Ob.Count;
            Rectangle temp;
            string sortType = cBoxSortType.Text;

            for (int j = 1; j < n; j++)
            {
                for (int i = 1; i < n; i++)
                {


                    switch (sortType)
                    {
                        case "Ширине":
                            if (Ob[i].Width < Ob[i-1].Width)
                            {
                                temp = Ob[i];
                                Ob[i] = Ob[i - 1];
                                Ob[i - 1] = temp;
                            }

                            break;
                        case "Площади":
                            if (Ob[i].Width * Ob[i].Height < Ob[i-1].Width * Ob[i-1].Height)
                            {
                                temp = Ob[i];
                                Ob[i] = Ob[i - 1];
                                Ob[i - 1] = temp;
                            }
                            break;

                        case "Большей стороне":
                            if ((Ob[i].Width < Ob[i - 1].Width && Ob[i].Width < Ob[i - 1].Height) || Ob[i].Height < Ob[i - 1].Height && Ob[i].Height < Ob[i - 1].Width)
                            {
                                temp = Ob[i];
                                Ob[i] = Ob[i - 1];
                                Ob[i - 1] = temp;
                            }
                            break;


                        default:
                            if (Ob[i].Height < Ob[i - 1].Height)
                            {
                                temp = Ob[i];
                                Ob[i] = Ob[i - 1];
                                Ob[i - 1] = temp;
                            }
                            break;

                    }

                }
            }

        }

        
        //Формирование массива заготовок из данных с таблицы
        private void BlanksCreate(int[] W, int[] H, Rectangle[] BlanksArr) 
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
                sw.WriteLine("____________");
            }
            
            for (int i = 0; i < rectangles.Count; i++)
            {
                using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
                {
                    sw.WriteLine(i+".  "+rectangles[i].Width+" "+rectangles[i].Height);
                    //sw.Write(4.5);
                }
            }
            using (StreamWriter sw = new StreamWriter(writePath, true, System.Text.Encoding.Default))
            {
                sw.WriteLine("____________");
            }
        }
        //______________________________________________________________


        //private void DrawRect(List<Rectangle> Ob) { }

        //Метод для рисования заготовок
        private void DrawRect(Rectangle [] Blanks) {

            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            using (Graphics g = Graphics.FromImage(pictureBox1.Image))
            {
                g.Clear(Color.White);
                float sc = (float)NumScaleMod.Value;
                SizeF scale = new SizeF(sc, sc);
                g.ScaleTransform(sc, sc);
                SolidBrush brush = new SolidBrush(Color.Red);
                SolidBrush brush2 = new SolidBrush(Color.Black);
                Pen p = new Pen(Color.Black, 2);
                 g.FillRectangles(brush,Blanks);
                g.DrawRectangles(p, Blanks);


                //Маркировка размеров на заготовках
                float fontsize;
                for (int i = 0; i < Blanks.Length - 1; i++)
                {
                    fontsize = (Blanks[i].Width * Blanks[i].Height) / (2 * (Blanks[i].Width + Blanks[i].Height));
                    if (fontsize > 16) fontsize = 18;

                    if (Blanks[i].Width / Blanks[i].Height < 0.5)
                    {
                        using (Font TextFont = new Font("Arial", fontsize, FontStyle.Bold))
                        {
                            
                            StringFormat sf = new StringFormat(StringFormatFlags.DirectionVertical);
                            g.DrawString(Blanks[i].Width.ToString() + "x" + Blanks[i].Height.ToString(), TextFont, brush2, Blanks[i].Location, sf);
                        }
                    }

                    else
                    {
                        using (Font TextFont = new Font("Arial",fontsize, FontStyle.Bold))
                        {
                            //StringFormat sf = new StringFormat(StringFormatFlags.DirectionVertical);
                            g.DrawString(Blanks[i].Width.ToString() + "x" + Blanks[i].Height.ToString(), TextFont, brush2, Blanks[i].Location);
                        }
                    }

                }

            }
            

        }

        //_________________________________________________________________

        //**************************************************************
        //Кнопка вычисления раскроя
        private void BtnCompute_Click(object sender, EventArgs e)
        {
            
            TableCheck(TableBlankParam);
            int n = TableBlankParam.RowCount; //Количество строк в таблице
            int[] WidthArray = new int[n]; //Массивы длин и ширин заготовок
            int[] HeightArray = new int[n];

            Rectangle[] BlanksArray = new Rectangle[n];//Массив заготовок
            try
            {
                WHArrInit(WidthArray, HeightArray);


            BlanksSort(WidthArray, HeightArray);

            BlanksCreate(WidthArray, HeightArray, BlanksArray);
            pictureBox1.Height = BlanksArray[0].Height;

            //Исходный материал
            Rectangle OriginBlock = new Rectangle(pictureBox1.Left, pictureBox1.Top, pictureBox1.Width,BlanksArray[0].Height);

            //Нулевой прямоугольник для корректного размещения заготовок 
            //(нужен, если заготовки займут 100% пространства листа)
            Rectangle zero = new Rectangle(0, 0, 0, 0);                
        
            //string writePath = @"C:\Users\User\Desktop\LOG.txt";

            List<Rectangle> Ob1 = new List<Rectangle>();//Динамический список пустых прямоугольников
            Ob1.Add(OriginBlock);
            Ob1.Add(zero);


            for (int i=0; i < n - 1; i++)
            {
                //EmptySort(Ob1);//Сортировка списка пустых прямоугольников

                for (int j = 0; j < Ob1.Count ; j++)
                {
                        //EmptyPrint(Ob1); //Вывод данных в LOG.txt


                        //Размер заготовки равен размеру пустого прямоугольника
                        if ((BlanksArray[i].Width == Ob1[j].Width) && (BlanksArray[i].Height == Ob1[j].Height))
                        {
                            BlanksArray[i].X = Ob1[j].X;
                            BlanksArray[i].Y = Ob1[j].Y;
                            Ob1.RemoveAt(j);
                            break;
                        }

                        //Высота заготовки равна высоте пустого прямоугольника, а ширина меньше
                        else if ((BlanksArray[i].Width < Ob1[j].Width) && (BlanksArray[i].Height == Ob1[j].Height))
                        {
                            BlanksArray[i].X = Ob1[j].X;
                            BlanksArray[i].Y = Ob1[j].Y;
                            Ob1.Add(new Rectangle(BlanksArray[i].Right, BlanksArray[i].Top, Ob1[j].Width - BlanksArray[i].Width, BlanksArray[i].Height));
                            Ob1.RemoveAt(j);
                            break;
                        }

                        //Ширина заготовки равна ширине пустого прямоугольника, а высота меньше
                        else if ((BlanksArray[i].Width == Ob1[j].Width) && (BlanksArray[i].Height < Ob1[j].Height))
                        {
                            BlanksArray[i].X = Ob1[j].X;
                            BlanksArray[i].Y = Ob1[j].Y;
                            Ob1.Add(new Rectangle(BlanksArray[i].Left, BlanksArray[i].Bottom, Ob1[j].Width, Ob1[j].Height - BlanksArray[i].Height));
                            Ob1.RemoveAt(j); break;

                        }

                        //Высота и ширина заготовки меньше высоты и ширины пустого прямоугольника
                        else if ((BlanksArray[i].Width < Ob1[j].Width) && (BlanksArray[i].Height < Ob1[j].Height))
                        {
                            BlanksArray[i].X = Ob1[j].X;
                            BlanksArray[i].Y = Ob1[j].Y;
                            Ob1.Add(new Rectangle(BlanksArray[i].Right, BlanksArray[i].Top, Ob1[j].Width - BlanksArray[i].Width, BlanksArray[i].Height));
                            Ob1.Add(new Rectangle(BlanksArray[i].Left, BlanksArray[i].Bottom, Ob1[j].Width, Ob1[j].Height - BlanksArray[i].Height));
                            Ob1.RemoveAt(j);
                            break;
                        }


                        //Приращение вниз если не осталось места                    
                        else if (((BlanksArray[i].Width > Ob1[j].Width || BlanksArray[i].Height > Ob1[j].Height) && j == Ob1.Count - 1) ) 
                    {
                        BlanksArray[i].X = pictureBox1.Left;
                        BlanksArray[i].Y = OriginBlock.Bottom;
                        pictureBox1.Height += BlanksArray[i].Height;
                        OriginBlock.Height += BlanksArray[i].Height;
                        Ob1.Add(new Rectangle(BlanksArray[i].Right, BlanksArray[i].Top, OriginBlock.Width - BlanksArray[i].Width, BlanksArray[i].Height));
                        break;
                    }
                    else continue;
                   
                }

                DrawRect(BlanksArray);//Рисование заготовок


                   // EmptySort(Ob1);//Сортировка списка пустых прямоугольников
                    //EmptyPrint(Ob1); //Вывод данных в LOG.txt



            //______________________________________________
        }

            }
            
            catch
            {
                pictureBox1.Image = null;
            }
            
        }


        //Кнопка выбора базы данных, из которой будут импортированы размеры заготовок
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
            }

            catch (System.Data.OleDb.OleDbException ex)
            {
                MessageBox.Show("База данных не выбрана", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label1.Text = "";
            }


        }

        //Загрузка формы
        private void Form1_Load(object sender, EventArgs e)
        { 
            openFileDialog1.Filter = "Файлы базы данных Access (*.accdb)|*.accdb|Файлы базы данных Access 2002-2003 (*.mdb)|*.mdb";
            this.MinimumSize = new Size (770, 430);
            cBoxSortType.SelectedText = "Высоте"; //Вид сортировки, который будет показан изначально
            label3.Text = "Ширина листа:" + pictureBox1.Width+" cм";
            BtnCompute.Enabled = true;
            this.Resize += Form1_Resize;

        }


       //Изменение размеров элементов формы при изменении размера формы
        private void Form1_Resize(object sender, System.EventArgs e)
        {
            panel1.Width = this.Width - TableBlankParam.Width - 100;// Ширина области для рисования в зависимости от ширины формы
            panel1.Height = this.Height - 160;
            pictureBox1.Width = this.Width - TableBlankParam.Width - 102;
            TableBlankParam.Height= this.Height - 290; ;
            label3.Text = "Ширина листа: " + pictureBox1.Width + " cм";
        }




        //Кнопка для сохранения изображения
        private void BtnSaveImage_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog saveImage = new SaveFileDialog();
                saveImage.Title = "Сохранить изображение как...";
                saveImage.OverwritePrompt = true;
                saveImage.CheckPathExists = true;
                saveImage.DefaultExt = ".jpg";
                saveImage.Filter = "JPEG-файл(*.JPG)|*.*";

                if (saveImage.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(saveImage.FileName, System.Drawing.Imaging.ImageFormat.Jpeg);
                }
            }
            else MessageBox.Show("Отсутствует изображение для сохранения", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        //Изменение масштаба изображения на лету
        private void NumScaleMod_ValueChanged(object sender, EventArgs e)
        {
            EventArgs args = new EventArgs();
            BtnCompute_Click(NumScaleMod,args);
        }
    }
}
