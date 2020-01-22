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
            this.NumBlankCount = new System.Windows.Forms.NumericUpDown();
            this.BtnCompute = new System.Windows.Forms.Button();
            this.TableBlankParam = new System.Windows.Forms.DataGridView();
            this.BlankLength = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlankWidth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BlankSquare = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnDBOpen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.NumBlankCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBlankParam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // NumBlankCount
            // 
            this.NumBlankCount.Location = new System.Drawing.Point(153, 249);
            this.NumBlankCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumBlankCount.Name = "NumBlankCount";
            this.NumBlankCount.Size = new System.Drawing.Size(51, 20);
            this.NumBlankCount.TabIndex = 1;
            this.NumBlankCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NumBlankCount.ValueChanged += new System.EventHandler(this.NumBlankCount_ValueChanged);
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
            // BlankLength
            // 
            this.BlankLength.HeaderText = "Длина заготовки (мм)";
            this.BlankLength.Name = "BlankLength";
            this.BlankLength.Width = 90;
            // 
            // BlankWidth
            // 
            this.BlankWidth.HeaderText = "Ширина заготовки (мм)";
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
            this.pictureBox1.Location = new System.Drawing.Point(358, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(756, 393);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDBOpen);
            this.Controls.Add(this.TableBlankParam);
            this.Controls.Add(this.BtnCompute);
            this.Controls.Add(this.NumBlankCount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NumBlankCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TableBlankParam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.NumericUpDown NumBlankCount;
        private System.Windows.Forms.Button BtnCompute;
        private System.Windows.Forms.DataGridView TableBlankParam;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDBOpen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlankLength;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlankWidth;
        private System.Windows.Forms.DataGridViewTextBoxColumn BlankSquare;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

