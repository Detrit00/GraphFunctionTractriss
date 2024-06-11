using System;
using System.Windows.Forms;
using System.IO;
using TractrixNamespace;

namespace WinFormsKR3
{
    public partial class FunctionSolutionForm : Form
    {

        double leftBorder, rightBorder, step, a, x, y;

        //Построение пользовательского интерфейса
        public FunctionSolutionForm()
        {
            InitializeComponent();
            LoadDefaultParametrs();
            showStart_ToolStripMenuItem.Checked = Properties.Settings.Default.checkBoxUser;
            if (showStart_ToolStripMenuItem.Checked == true)
            {
                new GreetUserForm().Show();
            }
        }

        //Обработка события при закрытии формы
        private void FunctionSolution_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.checkBoxUser = showStart_ToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();
        }
        
        private void information_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new GreetUserForm().Show();
        }
        
        private void showStart_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            showStart_ToolStripMenuItem.Checked = !showStart_ToolStripMenuItem.Checked;
        }

        private void saveChart_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            
            string filename = saveFileDialog.FileName;
            using (StreamWriter writer = new StreamWriter(filename, false))
            {
                for (int i = 0; i < funcValue_Table.RowCount; i++)
                {
                    writer.Write(funcValue_Table.Rows[i].Cells[0].Value);
                    writer.Write(" ");
                    writer.WriteLine(funcValue_Table.Rows[i].Cells[1].Value);
                }
            }
            chartTraktris_Chart.SaveImage($"{filename}.png", System.Drawing.Imaging.ImageFormat.Png);
        }

        private void saveInitialData_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.Cancel)
                return;

            string filename = saveFileDialog.FileName;
            using (StreamWriter writer = new StreamWriter(filename, false))
            {
                writer.WriteLine(a);
                writer.WriteLine(step);
                writer.WriteLine(leftBorder);
                writer.WriteLine(rightBorder);
            }
        }

        private void initialData_Button_Click(object sender, EventArgs e)
        {
            LoadDefaultParametrs();
        }

        private void clearChart_Button_Click(object sender, EventArgs e)
        {
            this.chartTraktris_Chart.Series[0].Points.Clear();
        }

        private void downloadFromFile_ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string line;
            if (openFileDialog.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = openFileDialog.FileName;
            using (StreamReader reader = new StreamReader(filename))
            {
                try
                {
                    line = reader.ReadLine();
                    valueA_TextBox.Text = line;
                    line = reader.ReadLine();
                    step_TextBox.Text = line;
                    line = reader.ReadLine();
                    leftBorder_TextBox.Text = line;
                    line = reader.ReadLine();
                    rightBorder_TextBox.Text = line;
                    CheckInitialData();
                    BuildChart();
                }
                catch
                {
                    MessageBox.Show(this, "Произошла ошибка при попытке считывания данных из файла." +
                                        "Отредактируйте данные и попробуйте снова", "Ошибка!",
                                         MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }




        private void buildChart_Button_Click(object sender, EventArgs e)
        {
            try
            {
                
                
                if (CheckInitialData())
                {
                    funcValue_Table.Rows.Clear();
                    this.chartTraktris_Chart.Series[0].Points.Clear();
                    BuildChart();
                    
                }
                else
                {
                    funcValue_Table.Rows.Clear();
                    this.chartTraktris_Chart.Series[0].Points.Clear();
                }

            }
            catch
            {

                MessageBox.Show(this, "Невозможно построить график", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void BuildChart()
        {

            
            double count = 0;
            for (y = leftBorder; y <= rightBorder; y += step)
            {
                y = Math.Round(y, 3);
                x = TractrixClass.EquationTractrix(a, y);
                x = Math.Round(x, 3);

                this.chartTraktris_Chart.Series[0].Points.AddXY(-x, y);
                funcValue_Table.Rows.Add(y, -x);
                count = y;
            }
            if ((count+step) == a)
            {
                this.chartTraktris_Chart.Series[0].Points.AddXY(0, a);
                funcValue_Table.Rows.Add(a, 0);
 
            }
            else
            {
                this.chartTraktris_Chart.Series[0].Points.AddXY(0, a);
                //this.chartTraktris_Chart.Series[0].Points.AddXY(0, double.NaN);
                
            }
            for (y = count; y >= leftBorder; y -= step)
            {
                y = Math.Round(y, 3);
                x = TractrixClass.EquationTractrix(a, y);
                x = Math.Round(x, 3);

                this.chartTraktris_Chart.Series[0].Points.AddXY(x, y);
                funcValue_Table.Rows.Add(y, x);
            }
        }



        private bool CheckInitialData()
        {
            try
            {
                leftBorder = Convert.ToDouble(leftBorder_TextBox.Text);
                rightBorder = Convert.ToDouble(rightBorder_TextBox.Text);
                step = Convert.ToDouble(step_TextBox.Text);
                a = Convert.ToDouble(valueA_TextBox.Text);

                leftBorder = Math.Round(leftBorder, 3);
                rightBorder = Math.Round(rightBorder, 3);
                step = Math.Round(step, 3);
                a = Math.Round(a, 3);

                leftBorder_TextBox.Text = leftBorder.ToString();
                rightBorder_TextBox.Text = rightBorder.ToString();
                step_TextBox.Text = step.ToString();
                valueA_TextBox.Text = a.ToString();

                
                if ((leftBorder <= 0) || (rightBorder < leftBorder))
                {
                    MessageBox.Show(this, "Невозможно построить график в заданном интревале.\n" +
                        "Измените границы диапазона", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                y = leftBorder;
                if ((leftBorder == rightBorder) || (y + step > rightBorder))
                {
                    MessageBox.Show(this, "График выражется в точку.\n" +
                        "Измените границы диапазона", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if ((a <= rightBorder))
                {
                    MessageBox.Show(this, "Невозможно построить график с текущим коэффициентом.\n" +
                        "Измените коэффициент 'a' ", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                if ((step <= 0))
                {
                    MessageBox.Show(this, "Невозможно построить график с заданным шагом.\n" +
                        "Измените шаг", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            catch
            {
                MessageBox.Show(this, "Невозможно построить график.\n" + 
                    "Проверьте корректность введнных данных", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private void LoadDefaultParametrs()
        {
            a = 1;
            step = 0.1;
            leftBorder = 0.1;
            rightBorder = 0.9;
            leftBorder_TextBox.Text = leftBorder.ToString();
            rightBorder_TextBox.Text = rightBorder.ToString();
            step_TextBox.Text = step.ToString();
            valueA_TextBox.Text = a.ToString();
            if (CheckInitialData())
            {
                funcValue_Table.Rows.Clear();
                this.chartTraktris_Chart.Series[0].Points.Clear();
                BuildChart();

            }
        }

    }
}


 

