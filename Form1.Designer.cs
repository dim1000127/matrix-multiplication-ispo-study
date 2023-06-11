namespace KursovyaPM
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownFirstCol = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFirstRow = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.numericUpDownSecondCol = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownSecondRow = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.buttonRandFirstMat = new System.Windows.Forms.Button();
            this.buttonRandSecondMat = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.buttonMultiMatrix = new System.Windows.Forms.Button();
            this.buttonClearMatrixFirst = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonClearMatrixSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondCol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondRow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(16, 193);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 49;
            this.dataGridView2.Size = new System.Drawing.Size(370, 227);
            this.dataGridView2.TabIndex = 21;
            this.dataGridView2.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellEndEdit);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(539, 193);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 49;
            this.dataGridView1.Size = new System.Drawing.Size(370, 227);
            this.dataGridView1.TabIndex = 20;
            this.dataGridView1.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEndEdit);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(536, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Столбцы";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(536, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Строки";
            // 
            // numericUpDownFirstCol
            // 
            this.numericUpDownFirstCol.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownFirstCol.Location = new System.Drawing.Point(623, 118);
            this.numericUpDownFirstCol.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownFirstCol.Name = "numericUpDownFirstCol";
            this.numericUpDownFirstCol.Size = new System.Drawing.Size(51, 26);
            this.numericUpDownFirstCol.TabIndex = 13;
            this.numericUpDownFirstCol.ValueChanged += new System.EventHandler(this.numericUpDownFirstCol_ValueChanged);
            // 
            // numericUpDownFirstRow
            // 
            this.numericUpDownFirstRow.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownFirstRow.Location = new System.Drawing.Point(623, 73);
            this.numericUpDownFirstRow.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownFirstRow.Name = "numericUpDownFirstRow";
            this.numericUpDownFirstRow.Size = new System.Drawing.Size(51, 26);
            this.numericUpDownFirstRow.TabIndex = 12;
            this.numericUpDownFirstRow.ValueChanged += new System.EventHandler(this.numericUpDownFirstRow_ValueChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 18);
            this.label3.TabIndex = 27;
            this.label3.Text = "Столбцы";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 18);
            this.label6.TabIndex = 26;
            this.label6.Text = "Строки";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // numericUpDownSecondCol
            // 
            this.numericUpDownSecondCol.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSecondCol.Location = new System.Drawing.Point(95, 120);
            this.numericUpDownSecondCol.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSecondCol.Name = "numericUpDownSecondCol";
            this.numericUpDownSecondCol.Size = new System.Drawing.Size(51, 26);
            this.numericUpDownSecondCol.TabIndex = 25;
            this.numericUpDownSecondCol.ValueChanged += new System.EventHandler(this.numericUpDownSecondCol_ValueChanged);
            // 
            // numericUpDownSecondRow
            // 
            this.numericUpDownSecondRow.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDownSecondRow.Location = new System.Drawing.Point(95, 75);
            this.numericUpDownSecondRow.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownSecondRow.Name = "numericUpDownSecondRow";
            this.numericUpDownSecondRow.Size = new System.Drawing.Size(51, 26);
            this.numericUpDownSecondRow.TabIndex = 24;
            this.numericUpDownSecondRow.ValueChanged += new System.EventHandler(this.numericUpDownSecondRow_ValueChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(536, 34);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 18);
            this.label7.TabIndex = 28;
            this.label7.Text = "Матрица M";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 34);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 18);
            this.label8.TabIndex = 29;
            this.label8.Text = "Матрица N";
            // 
            // buttonRandFirstMat
            // 
            this.buttonRandFirstMat.BackColor = System.Drawing.Color.White;
            this.buttonRandFirstMat.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandFirstMat.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRandFirstMat.Location = new System.Drawing.Point(692, 77);
            this.buttonRandFirstMat.Name = "buttonRandFirstMat";
            this.buttonRandFirstMat.Size = new System.Drawing.Size(171, 71);
            this.buttonRandFirstMat.TabIndex = 30;
            this.buttonRandFirstMat.Text = "Заполнить матрицу M случайными числами от -1000 до 1000";
            this.buttonRandFirstMat.UseVisualStyleBackColor = false;
            this.buttonRandFirstMat.Click += new System.EventHandler(this.buttonRandFirstMat_Click);
            // 
            // buttonRandSecondMat
            // 
            this.buttonRandSecondMat.BackColor = System.Drawing.Color.White;
            this.buttonRandSecondMat.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRandSecondMat.Location = new System.Drawing.Point(172, 75);
            this.buttonRandSecondMat.Name = "buttonRandSecondMat";
            this.buttonRandSecondMat.Size = new System.Drawing.Size(171, 71);
            this.buttonRandSecondMat.TabIndex = 31;
            this.buttonRandSecondMat.Text = "Заполнить матрицу N случайными числами от -1000 до 1000";
            this.buttonRandSecondMat.UseVisualStyleBackColor = false;
            this.buttonRandSecondMat.Click += new System.EventHandler(this.buttonRandSecondMat_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(539, 467);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersWidth = 49;
            this.dataGridView3.Size = new System.Drawing.Size(374, 227);
            this.dataGridView3.TabIndex = 32;
            // 
            // dataGridView4
            // 
            this.dataGridView4.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(18, 467);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.ReadOnly = true;
            this.dataGridView4.RowHeadersWidth = 49;
            this.dataGridView4.Size = new System.Drawing.Size(370, 227);
            this.dataGridView4.TabIndex = 33;
            // 
            // buttonMultiMatrix
            // 
            this.buttonMultiMatrix.BackColor = System.Drawing.Color.White;
            this.buttonMultiMatrix.Font = new System.Drawing.Font("Lucida Fax", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonMultiMatrix.Location = new System.Drawing.Point(392, 267);
            this.buttonMultiMatrix.Name = "buttonMultiMatrix";
            this.buttonMultiMatrix.Size = new System.Drawing.Size(141, 77);
            this.buttonMultiMatrix.TabIndex = 34;
            this.buttonMultiMatrix.Text = "Перемножить матрицы";
            this.buttonMultiMatrix.UseVisualStyleBackColor = false;
            this.buttonMultiMatrix.Click += new System.EventHandler(this.buttonMultiMatrix_Click);
            // 
            // buttonClearMatrixFirst
            // 
            this.buttonClearMatrixFirst.BackColor = System.Drawing.Color.White;
            this.buttonClearMatrixFirst.Location = new System.Drawing.Point(663, 164);
            this.buttonClearMatrixFirst.Name = "buttonClearMatrixFirst";
            this.buttonClearMatrixFirst.Size = new System.Drawing.Size(130, 23);
            this.buttonClearMatrixFirst.TabIndex = 35;
            this.buttonClearMatrixFirst.Text = "Очистить матрицу M";
            this.buttonClearMatrixFirst.UseVisualStyleBackColor = false;
            this.buttonClearMatrixFirst.Click += new System.EventHandler(this.buttonClearMatrixFirst_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(536, 444);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(280, 18);
            this.label4.TabIndex = 36;
            this.label4.Text = "Результат перемножения матриц (M*N)";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(280, 18);
            this.label5.TabIndex = 37;
            this.label5.Text = "Результат перемножения матриц (N*M)";
            // 
            // buttonClearMatrixSec
            // 
            this.buttonClearMatrixSec.BackColor = System.Drawing.Color.White;
            this.buttonClearMatrixSec.Location = new System.Drawing.Point(142, 164);
            this.buttonClearMatrixSec.Name = "buttonClearMatrixSec";
            this.buttonClearMatrixSec.Size = new System.Drawing.Size(130, 23);
            this.buttonClearMatrixSec.TabIndex = 38;
            this.buttonClearMatrixSec.Text = "Очистить матрицу N";
            this.buttonClearMatrixSec.UseVisualStyleBackColor = false;
            this.buttonClearMatrixSec.Click += new System.EventHandler(this.buttonClearMatrixSec_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(928, 704);
            this.Controls.Add(this.buttonClearMatrixSec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonClearMatrixFirst);
            this.Controls.Add(this.buttonMultiMatrix);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.buttonRandSecondMat);
            this.Controls.Add(this.buttonRandFirstMat);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.numericUpDownSecondCol);
            this.Controls.Add(this.numericUpDownSecondRow);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.numericUpDownFirstCol);
            this.Controls.Add(this.numericUpDownFirstRow);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Перемножение матриц";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFirstRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondCol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSecondRow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownFirstCol;
        private System.Windows.Forms.NumericUpDown numericUpDownFirstRow;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.NumericUpDown numericUpDownSecondCol;
        private System.Windows.Forms.NumericUpDown numericUpDownSecondRow;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button buttonRandFirstMat;
        private System.Windows.Forms.Button buttonRandSecondMat;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Button buttonMultiMatrix;
        private System.Windows.Forms.Button buttonClearMatrixFirst;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonClearMatrixSec;
    }
}

