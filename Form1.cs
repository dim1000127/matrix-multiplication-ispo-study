using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KursovyaPM
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataGridView1.RowCount = 1;
            dataGridView2.RowCount = 1;
            dataGridView1.Columns[0].Width = 70;
            dataGridView2.Columns[0].Width = 70;
            dataGridView3.RowCount = 1;
            dataGridView4.RowCount = 1;
            numericUpDownFirstRow.Value = 1;
            numericUpDownFirstCol.Value = 1;
            numericUpDownSecondRow.Value = 1;
            numericUpDownSecondCol.Value = 1;
            this.Height = 480;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRandFirstMat_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            for (int j = 0; j < (dataGridView1.RowCount - 1); j++)
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    if (dataGridView1.Rows[j].Cells[i].Value == null)
                    {
                        dataGridView1.Rows[j].Cells[i].Value = rand.Next(-1000, 1001);
                    }
                }
            }
            //установка ширины столбца
            foreach (DataGridViewColumn column in dataGridView1.Columns)
                column.Width = 70;
        }

        private void buttonRandSecondMat_Click(object sender, EventArgs e)
        {
            Random rand = new Random();

            for (int j = 0; j < (dataGridView2.RowCount - 1); j++)
            {
                for (int i = 0; i < dataGridView2.ColumnCount; i++)
                {
                    if (dataGridView2.Rows[j].Cells[i].Value == null)
                    {
                        dataGridView2.Rows[j].Cells[i].Value = rand.Next(-1000, 1001);
                    }
                }
            }
            //установка ширины столбца
            foreach (DataGridViewColumn column in dataGridView2.Columns)
                column.Width = 70;
        }

        private void numericUpDownFirstRow_ValueChanged(object sender, EventArgs e)
        {
            addFirstGridRowCol();
        }

        private void numericUpDownFirstCol_ValueChanged(object sender, EventArgs e)
        {
            addFirstGridRowCol();
        }

        private void addFirstGridRowCol()
        {
            //добавляем одну дополнительную строчку, для красивого отображения матрицы
            //впоследствии при добавлении новых стррочек последнняя строка не будет съезжать
            dataGridView1.RowCount = (int)numericUpDownFirstRow.Value + 1;
            dataGridView1.ColumnCount = (int)numericUpDownFirstCol.Value;
            for (int j = 0; j < (dataGridView1.RowCount - 1); j++)
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    dataGridView1.Columns[i].HeaderText = i.ToString();
                    dataGridView1.Rows[j].HeaderCell.Value = string.Format((j).ToString(), "0");
                }
            }
            //установка ширины столбца
            foreach (DataGridViewColumn column in dataGridView1.Columns)
                column.Width = 70;
        }

        private void numericUpDownSecondRow_ValueChanged(object sender, EventArgs e)
        {
            addSecondGridRowCol();
        }

        private void numericUpDownSecondCol_ValueChanged(object sender, EventArgs e)
        {
            addSecondGridRowCol();
        }

        private void addSecondGridRowCol()
        {
            //добавляем одну дополнительную строчку, для красивого отображения матрицы
            //впоследствии при добавлении новых стррочек последнняя строка не будет съезжать
            dataGridView2.RowCount = (int)numericUpDownSecondRow.Value + 1;
            dataGridView2.ColumnCount = (int)numericUpDownSecondCol.Value;

            for (int j = 0; j < (dataGridView2.RowCount - 1); j++)
            {
                for (int i = 0; i < dataGridView2.ColumnCount; i++)
                {
                    dataGridView2.Columns[i].HeaderText = i.ToString();
                    dataGridView2.Rows[j].HeaderCell.Value = string.Format((j).ToString(), "0");
                }
            }
            //установка ширины столбца
            foreach (DataGridViewColumn column in dataGridView2.Columns)
                column.Width = 70;
        }

        private void buttonMultiMatrix_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < (dataGridView1.RowCount - 1); j++)
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    if (dataGridView1.Rows[j].Cells[i].Value == null)
                    {
                        MessageBox.Show(String.Format("Заполните все элементы (вручную или рандомно). Элемент [{0}][{1}] матрицы M - пустой", j, i));
                        return;
                    }
                }
            }

            for (int j = 0; j < (dataGridView2.RowCount - 1); j++)
            {
                for (int i = 0; i < dataGridView2.ColumnCount; i++)
                {
                    if (dataGridView2.Rows[j].Cells[i].Value == null) {
                        MessageBox.Show(String.Format("Заполните все элементы (вручную или рандомно). Элемент [{0}][{1}] матрицы N - пустой", j, i));
                        return;
                    }
                }
            }

            this.Height = 743;
            if ((dataGridView1.ColumnCount) == (dataGridView2.RowCount - 1))
            {
                multiplicationFirstSec();
            }
            else
            {
                dataGridView3.Rows.Clear();
                dataGridView3.ColumnCount = 1;
                MessageBox.Show("Матрицы M и N не согласованы. Умножение не удалось");
            }


            if ((dataGridView2.ColumnCount) == (dataGridView1.RowCount - 1))
            {
                multiplicationSecFirst();
            }
            else
            {
                dataGridView4.Rows.Clear();
                dataGridView4.ColumnCount = 1;
                MessageBox.Show("Матрицы N и M не согласованы. Умножение не удалось");
            }
        }

        void multiplicationFirstSec()
        {
            dataGridView3.RowCount = dataGridView1.RowCount;
            dataGridView3.ColumnCount = dataGridView2.ColumnCount;

            //создаем матрицы с размерностью как datagridview
            int[,] A = new int[(dataGridView1.RowCount - 1), dataGridView1.ColumnCount];
            int[,] B = new int[(dataGridView2.RowCount - 1), dataGridView2.ColumnCount];

            //заполняем матрицы значениями из datagridview
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                for (int j = 0; j < (dataGridView1.RowCount - 1); j++)
                    A[j, i] = Convert.ToInt32(dataGridView1[i, j].Value);
            for (int i = 0; i < dataGridView2.ColumnCount; i++)
                for (int j = 0; j < (dataGridView2.RowCount - 1); j++)
                    B[j, i] = Convert.ToInt32(dataGridView2[i, j].Value);

            for (int i = 0; i < (dataGridView1.RowCount-1); i++)
            {
                dataGridView3.Rows[i].HeaderCell.Value = string.Format((i).ToString(), "0");
                for (int j = 0; j < dataGridView2.ColumnCount; j++)
                {
                    dataGridView3.Columns[j].HeaderText = j.ToString();
                    int s = 0;
                    for (int k = 0; k < (dataGridView2.RowCount - 1); k++)
                    {
                        s += A[i, k] * B[k, j];
                    }
                    dataGridView3[j, i].Value = s;
                }
            }
            //установка ширины столбца
            foreach (DataGridViewColumn column in dataGridView3.Columns)
                column.Width = 70;
        }

        void multiplicationSecFirst()
        {
            dataGridView4.RowCount = dataGridView2.RowCount;
            dataGridView4.ColumnCount = dataGridView1.ColumnCount;

            //создаем матрицы с размерностью как datagridview
            int[,] A = new int[(dataGridView1.RowCount - 1), dataGridView1.ColumnCount];
            int[,] B = new int[(dataGridView2.RowCount - 1), dataGridView2.ColumnCount];

            //заполняем матрицы значениями из datagridview
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
                for (int j = 0; j < (dataGridView1.RowCount - 1); j++)
                    A[j, i] = Convert.ToInt32(dataGridView1[i, j].Value);
            for (int i = 0; i < dataGridView2.ColumnCount; i++)
                for (int j = 0; j < (dataGridView2.RowCount - 1); j++)
                    B[j, i] = Convert.ToInt32(dataGridView2[i, j].Value);

            for (int i = 0; i < (dataGridView2.RowCount - 1); i++)
            {
                dataGridView4.Rows[i].HeaderCell.Value = string.Format((i).ToString(), "0");
                for (int j = 0; j < dataGridView1.ColumnCount; j++)
                {
                    dataGridView4.Columns[j].HeaderText = j.ToString();
                    int s = 0;
                    for (int k = 0; k < (dataGridView1.RowCount - 1); k++)
                    {
                        s += B[i, k] * A[k, j];
                    }
                    dataGridView4[j, i].Value = s;
                }
            }
            //установка ширины столбца
            foreach (DataGridViewColumn column in dataGridView4.Columns)
                column.Width = 70;
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void buttonClearMatrixFirst_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < (dataGridView1.RowCount - 1); j++)
            {
                for (int i = 0; i < dataGridView1.ColumnCount; i++)
                {
                    dataGridView1.Rows[j].Cells[i].Value = null;
                }
            }
        }

        private void buttonClearMatrixSec_Click(object sender, EventArgs e)
        {
            for (int j = 0; j < (dataGridView2.RowCount - 1); j++)
            {
                for (int i = 0; i < dataGridView2.ColumnCount; i++)
                {
                    dataGridView2.Rows[j].Cells[i].Value = null;
                }
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Проверка на то, что пустая ячейка или нет
            if (dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string changedValue = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                //можно ли число сконвертировать в int
                if (Int32.TryParse(changedValue, out int result))
                {
                    int changedValueInt = Convert.ToInt32(changedValue);
                    if (changedValueInt >= (-1000) && (changedValueInt < 1001))
                    {
                        //MessageBox.Show(changedValueInt.ToString());
                    }
                    else
                    {
                        MessageBox.Show("Введите число в диапазоне от -1000 до 1000");
                        dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                    }
                }
                else
                {
                    MessageBox.Show("Введите число в диапазоне от -1000 до 1000");
                    dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                }
            }
        }

        private void dataGridView2_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            //Проверка на то, что пустая ячейка или нет
            if (dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                string changedValue = dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
                //можно ли число сконвертировать в int
                if (Int32.TryParse(changedValue, out int result))
                {
                    int changedValueInt = Convert.ToInt32(changedValue);
                    if (changedValueInt >= (-1000) && (changedValueInt < 1001))
                    {
                        //MessageBox.Show(changedValue.ToString());
                    }
                    else {
                        MessageBox.Show("Введите число в диапазоне от -1000 до 1000");
                        dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                    }

                }
                else
                {
                    MessageBox.Show("Введите число в диапазоне от -1000 до 1000");
                    dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value = null;
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}

