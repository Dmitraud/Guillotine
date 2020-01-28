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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDBOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.BlankLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlankWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlankSquare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.TableBlankParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnCompute
            // 
            this.BtnCompute.Location = new System.Drawing.Point(12, 292);
            this.BtnCompute.Name = "BtnCompute";
            this.BtnCompute.Size = new System.Drawing.Size(75, 23);
            this.BtnCompute.TabIndex = 2;
            this.BtnCompute.Text = "Вычислить";
            this.BtnCompute.UseVisualStyleBackColor = true;
            this.BtnCompute.Click += new System.EventHandler(this.BtnCompute_Click);
            // 
            // TableBlankParam
            // 
            this.TableBlankParam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TableBlankParam.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BlankLength,
            this.BlankWidth,
            this.BlankSquare});
            this.TableBlankParam.Location = new System.Drawing.Point(12, 27);
            this.TableBlankParam.Name = "TableBlankParam";
            this.TableBlankParam.Size = new System.Drawing.Size(325, 216);
            this.TableBlankParam.TabIndex = 3;
            this.TableBlankParam.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.TableBlankParam_CellValueChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.DefaultExt = "txt";
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnDBOpen
            // 
            this.btnDBOpen.Location = new System.Drawing.Point(12, 249);
            this.btnDBOpen.Name = "btnDBOpen";
            this.btnDBOpen.Size = new System.Drawing.Size(104, 37);
            this.btnDBOpen.TabIndex = 4;
            this.btnDBOpen.Text = "Открыть базу данных";
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
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(350, 350);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(396, 382);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Location = new System.Drawing.Point(5, 360);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(350, 17);
            this.hScrollBar1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoSize = true;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(386, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(396, 382);
            this.panel1.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(133, 250);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.DecimalPlaces = 1;
            this.numericUpDown1.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.numericUpDown1.Location = new System.Drawing.Point(194, 295);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(64, 20);
            this.numericUpDown1.TabIndex = 11;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(130, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Масштаб";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(214, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(363, 9);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(20, 382);
            this.vScrollBar1.TabIndex = 7;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 434);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hScrollBar1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDBOpen);
            this.Controls.Add(this.TableBlankParam);
            this.Controls.Add(this.BtnCompute);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TableBlankParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
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
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlankLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlankWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlankSquare;
    }
}

