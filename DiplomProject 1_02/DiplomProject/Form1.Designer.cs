namespace DiplomProject
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtnCompute = new System.Windows.Forms.Button();
            this.TableBlankParam = new System.Windows.Forms.DataGridView();
            this.BlankLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlankWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlankSquare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDBOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnSaveImage = new System.Windows.Forms.Button();
            this.NumScaleMod = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cBoxSortType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.TableBlankParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NumScaleMod)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCompute
            // 
            this.BtnCompute.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.BtnCompute.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.BtnCompute.Location = new System.Drawing.Point(110, 365);
            this.BtnCompute.Name = "BtnCompute";
            this.BtnCompute.Size = new System.Drawing.Size(105, 45);
            this.BtnCompute.TabIndex = 2;
            this.BtnCompute.Text = "Вычислить";
            this.BtnCompute.UseVisualStyleBackColor = true;
            this.BtnCompute.Click += new System.EventHandler(this.BtnCompute_Click);
            // 
            // TableBlankParam
            // 
            this.TableBlankParam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.TableBlankParam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableBlankParam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BlankLength,
            this.BlankWidth,
            this.BlankSquare});
            this.TableBlankParam.Location = new System.Drawing.Point(12, 58);
            this.TableBlankParam.Name = "TableBlankParam";
            this.TableBlankParam.Size = new System.Drawing.Size(325, 216);
            this.TableBlankParam.TabIndex = 3;
            // 
            // BlankLength
            // 
            this.BlankLength.HeaderText = "Ширина заготовки (см)";
            this.BlankLength.MaxInputLength = 500;
            this.BlankLength.Name = "BlankLength";
            this.BlankLength.Width = 90;
            // 
            // BlankWidth
            // 
            this.BlankWidth.HeaderText = "Высота заготовки (см)";
            this.BlankWidth.MaxInputLength = 500;
            this.BlankWidth.Name = "BlankWidth";
            this.BlankWidth.Width = 90;
            // 
            // BlankSquare
            // 
            this.BlankSquare.HeaderText = "Площадь заготовки (кв.м)";
            this.BlankSquare.Name = "BlankSquare";
            this.BlankSquare.ReadOnly = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDBOpen
            // 
            this.btnDBOpen.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnDBOpen.Location = new System.Drawing.Point(110, 280);
            this.btnDBOpen.Name = "btnDBOpen";
            this.btnDBOpen.Size = new System.Drawing.Size(104, 37);
            this.btnDBOpen.TabIndex = 4;
            this.btnDBOpen.Text = "Импорт из базы данных";
            this.btnDBOpen.UseVisualStyleBackColor = true;
            this.btnDBOpen.Click += new System.EventHandler(this.btnDBOpen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 5;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(350, 350);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(375, 382);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(385, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(407, 322);
            this.panel1.TabIndex = 9;
            // 
            // BtnSaveImage
            // 
            this.BtnSaveImage.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.BtnSaveImage.Location = new System.Drawing.Point(543, 405);
            this.BtnSaveImage.Name = "BtnSaveImage";
            this.BtnSaveImage.Size = new System.Drawing.Size(75, 23);
            this.BtnSaveImage.TabIndex = 10;
            this.BtnSaveImage.Text = "Сохранить";
            this.BtnSaveImage.UseVisualStyleBackColor = true;
            this.BtnSaveImage.Click += new System.EventHandler(this.BtnSaveImage_Click);
            // 
            // NumScaleMod
            // 
            this.NumScaleMod.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NumScaleMod.DecimalPlaces = 1;
            this.NumScaleMod.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumScaleMod.Location = new System.Drawing.Point(24, 309);
            this.NumScaleMod.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.NumScaleMod.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.NumScaleMod.Name = "NumScaleMod";
            this.NumScaleMod.Size = new System.Drawing.Size(64, 20);
            this.NumScaleMod.TabIndex = 11;
            this.NumScaleMod.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumScaleMod.ValueChanged += new System.EventHandler(this.NumScaleMod_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 292);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Масштаб";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 22);
            this.label3.TabIndex = 13;
            this.label3.Text = "Ширина листа: ";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(230, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(145, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Сортировать заготовки по:";
            // 
            // cBoxSortType
            // 
            this.cBoxSortType.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cBoxSortType.FormattingEnabled = true;
            this.cBoxSortType.Items.AddRange(new object[] {
            "Высоте",
            "Ширине",
            "Площади"});
            this.cBoxSortType.Location = new System.Drawing.Point(242, 308);
            this.cBoxSortType.Name = "cBoxSortType";
            this.cBoxSortType.Size = new System.Drawing.Size(104, 21);
            this.cBoxSortType.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(70, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Таблица размеров";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(356, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "( для изменения ширины листа, измените размер окна программы )";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 42);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(333, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "( введите значения вручную или импортируйте из базы данных )";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 452);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cBoxSortType);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NumScaleMod);
            this.Controls.Add(this.BtnSaveImage);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDBOpen);
            this.Controls.Add(this.TableBlankParam);
            this.Controls.Add(this.BtnCompute);
            this.Name = "Form1";
            this.Text = "Гильотинный раскрой";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableBlankParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NumScaleMod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button BtnCompute;
        private System.Windows.Forms.DataGridView TableBlankParam;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDBOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button BtnSaveImage;
        private System.Windows.Forms.NumericUpDown NumScaleMod;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlankLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlankWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlankSquare;
        private System.Windows.Forms.ComboBox cBoxSortType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

