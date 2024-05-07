using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Xml.XPath;

namespace LabApprox
{
    public partial class ApproxForm : Form
    {
        //
        string pointsPath = "pointsList.txt"; // (x;y)
        string coeffPath = "coeffList.txt";    // x
        List<(double x, double y)> points;
        double[,] pointsL;
        List<double> coeff;
        Newton newtonMethod;
        Lagranz lagranzMethod;
        //LeastSquares leastSquares;
        private LeastSquares leastSquares = new LeastSquares();
        double[,] numbers = new double[,]
            {
            {-1, 1, 2, 3, 4},
            {-5, -3, 18, 6, -2}
            };

        enum MethodType
        {
            Lagrange =0 , Newton, Squares, Coeffs
        };
        MethodType type = MethodType.Lagrange;

        public ApproxForm()
        {
            InitializeComponent();

            funcTypeBox.SelectedIndex = 1; // индекс по умолчанию
            coeffPanel.Enabled = false;
            pointPanel.Enabled = true;
            leastSquares = new LeastSquares();
            drawChart.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0.###}";
            drawChart.ChartAreas[0].AxisY.LabelStyle.Format = "{0:0.###}";
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            StreamReader file;
            string line;
            if (type == MethodType.Coeffs)      // для многочлена степени 4
            {
                if (!File.Exists(coeffPath))
                {
                    MessageBox.Show($"Файл {coeffPath} не существует!\nСоздан пустой файл.",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    File.Create(coeffPath).Dispose();
                }
                file = new StreamReader(coeffPath);
                coeff = new List<double>();
                while (!file.EndOfStream)
                {
                    line = file.ReadLine();
                    coeff.Add(double.Parse(line));
                }
                pointsList.Items.Clear();
                if (coeff.Count() > 5)
                {
                    MessageBox.Show("Слишком много коэффициентов для многочлена 4 степени -" +
                        " будут использованы только первые 5!",
                        "Внимание!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    coeff.RemoveRange(5, coeff.Count - 5);
                }
                foreach (var i in coeff)
                    pointsList.Items.Add(i);
            }
            else
            {                                   // для интерполяций
                if (!File.Exists(pointsPath))
                {
                    MessageBox.Show($"Файл {pointsPath} не существует!\nСоздан пустой файл.",
                        "Ошибка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    File.Create(pointsPath).Dispose();
                }
                file = new StreamReader(pointsPath);
                string[] str;
                points = new List<(double, double)>();

                while (!file.EndOfStream)
                {
                    line = file.ReadLine();
                    line = line.Substring(1, line.Length - 2);
                    str = line.Split(';');
                    points.Add((double.Parse(str[0]), double.Parse(str[1])));
                }
                pointsList.Items.Clear();
                drawChart.Series["Исходные точки"].Points.Clear();
                points = points.Distinct().ToList();
                foreach (var (x, y) in points)
                {
                    pointsList.Items.Add("(" + x + ";" + y + ")");
                    drawChart.Series["Исходные точки"].Points.AddXY(x, y);
                }
            }
            file.Close();

            if (type == MethodType.Lagrange)
            {
                lagranzMethod = new Lagranz(points);
            }

            // поменять
            /////////////////////////////////////////
            if (type == MethodType.Newton)
            {
                newtonMethod = new Newton(points);
                newtonMethod.CalculateTable();

            }
            //////////////////////////////////////////
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            StreamWriter file;
            if (type == MethodType.Coeffs)
            {
                file = File.CreateText(coeffPath);
                foreach (var c in coeff)
                    file.WriteLine(c);
            }
            else
            {
                file = File.CreateText(pointsPath);
                foreach (var (x, y) in points)
                    file.WriteLine("(" + x + ";" + y + ")");
            }
            file.Close();
        }

        private void DrawButton_Click(object sender, EventArgs e)
        {
            //polynomialDegree = (int)powerSquares.Value;
            foreach (var ser in drawChart.Series)
            {
                ser.Points.Clear();
            }
            foreach (var ser in drawChart.Series)
                ser.Points.Clear();
            double min, max, h;
            if (type != MethodType.Coeffs)
            {
                foreach (var (x, y) in points)
                    drawChart.Series["Исходные точки"].Points.AddXY(x, y); // добавление исходных точек
                min = points.Aggregate((i1, i2) => i1.x < i2.x ? i1 : i2).x;
                max = points.Aggregate((i1, i2) => i1.x > i2.x ? i1 : i2).x;
            }
            else
            {
                min = -5;
                max = 5;
                while (coeff.Count < 5)
                    coeff.Add(0);
            }
            h = (max - min) / (drawChart.Size.Width / 1);
            bool flag = false;




            
            //double[] ex = {-1,1,2,3,4 };
            //double[] yy = { -6.96, 6.82, 8.21, 5.93, -0.001 };
            for (double x = min - 10 * h; x < max + 10 * h; x += h)
            {
                double f = 0;
                switch (type)
                {
                    case MethodType.Lagrange:
                        {
                            f = lagranzMethod.FuncValue(x);
                            drawChart.Series["Интерполяция Лагранжа"].Points.AddXY(x, f);
                        } break;
                    case MethodType.Newton:
                        {
                            f = newtonMethod.FuncValue(x);
                            drawChart.Series["Интерполяция Ньютона"].Points.AddXY(x, f);
                        } break;
                    case MethodType.Squares:
                        {

                            //double[] smoothedData = leastSquares.ApplySmoothing(numbers, (int)powerSquares.Value); // Пример использования, предполагается, что функция возвращает массив сглаженных данных

                            //// Добавление сглаженных данных на график
                            //for (int i = 0; i < smoothedData.Length; i++)
                            //{
                            //    drawChart.Series["Сглаживающие многочлены"].Points.AddXY(numbers[0, i], smoothedData[i]);
                               
                            //}

                        }
                        break;
                    case MethodType.Coeffs:
                        {
                            f = coeff[0] * x * x * x * x + coeff[1] * x * x * x + coeff[2] * x * x + coeff[3] * x + coeff[4];
                            drawChart.Series["Многочлен 4 степени"].Points.AddXY(x, f);
                        } break;
                    default:
                        {
                            MessageBox.Show("Неизвестный тип функции!",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            flag = true;
                        } break;
                }
                if (flag)
                    break;
            }
        }

        private void FuncTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (funcTypeBox.SelectedIndex)
            {
                case 0:
                    {
                        powerSquares.Value = 1;
                        powerSquares.Maximum = 3;
                        powerSquares.Enabled = false;
                        type = MethodType.Lagrange;
                        pointsList.Items.Clear();
                        coeffPanel.Enabled = false;
                        pointPanel.Enabled = true;
                    } break;
                case 1:
                    {
                        powerSquares.Value = 1;
                        powerSquares.Maximum = 3;
                        powerSquares.Enabled = false;
                        type = MethodType.Newton;
                        pointsList.Items.Clear();
                        coeffPanel.Enabled = false;
                        pointPanel.Enabled = true;
                    }
                    break;
                case 2:
                    {
                        powerSquares.Value = 1;
                        powerSquares.Maximum = 3;
                        powerSquares.Enabled = true;
                        type = MethodType.Squares;
                        pointsList.Items.Clear();
                        coeffPanel.Enabled = false;
                        pointPanel.Enabled = true;
                    }
                    break;
                case 3:
                    {
                        powerSquares.Maximum = 4;
                        powerSquares.Value = 4;
                        powerSquares.Enabled = false;
                        type = MethodType.Coeffs;
                        pointsList.Items.Clear();
                        coeffPanel.Enabled = true;
                        pointPanel.Enabled = false;
                    }
                    break;
                default:
                    {
                        MessageBox.Show("Некорректный выбор метода!",
                            "Ошибка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    } break;
            }

        }

        private void AddPointButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(addedPointXBox.Text, out double x) || !double.TryParse(addedPointYBox.Text, out double y))
            {
                MessageBox.Show("Неправильные данные для добавленной точки!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                addedPointXBox.Text = "";
                addedPointYBox.Text = "";
            }
            else
            {
                points ??= new List<(double x, double y)>();
                if (!points.Contains((x, y)))
                {
                    points.Add((x, y));
                    pointsList.Items.Add("(" + x + ";" + y + ")");
                    if (type == MethodType.Newton)
                    {
                        if (newtonMethod == null)
                            newtonMethod = new Newton(points);
                        else
                            newtonMethod.AddToTable(x, y);
                    }
                    if (type == MethodType.Lagrange)
                    {
                        if (lagranzMethod == null)
                            lagranzMethod = new Lagranz(points);
                    }

                }
            }
        }

        private void DeletePointButton_Click(object sender, EventArgs e)
        {
            /*if (!double.TryParse(addedPointXBox.Text, out double x) || !double.TryParse(addedPointYBox.Text, out double y))
            {
                MessageBox.Show("Неправильные данные для удаления точки!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                addedPointXBox.Text = "";
                addedPointYBox.Text = "";
            }
            else
            {
                points.Remove((x, y));
                pointsList.Items.Remove("(" + x + ";" + y + ")");
                if (type == MethodType.Newton)
                {
                    newtonMethod.CalculateTable();
                }
            }*/
            if (points == null || pointsList.Items == null)
                return;
            if (pointsList.SelectedIndex != -1)
            {
                points.RemoveAt(pointsList.SelectedIndex);
                pointsList.Items.RemoveAt(pointsList.SelectedIndex);
            }
            else
            {
                points.Remove(points.Last());
                pointsList.Items.RemoveAt(pointsList.Items.Count - 1);
            }
        }

        private void AddCoeffButton_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(addCoeffBox.Text, out double x))
            {
                MessageBox.Show("Неправильные данные для добавленного коэффициента!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                addCoeffBox.Text = "";
            }
            else
            {
                coeff.Add(x);
                pointsList.Items.Add(x);
            }
        }

        private void DeleteCoeffButton_Click(object sender, EventArgs e)
        {
            if (coeff == null || pointsList.Items == null)
                return;
            if (pointsList.SelectedIndex != -1)
            {
                coeff.RemoveAt(pointsList.SelectedIndex);
                pointsList.Items.RemoveAt(pointsList.SelectedIndex);
            }
            else
            {
                coeff.Remove(coeff.Last());
                pointsList.Items.RemoveAt(pointsList.Items.Count - 1);
            }
        }

        private void ApproxForm_Load(object sender, EventArgs e)
        {

        }

        private void drawChart_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void powerSquares_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            drawChart.Series["Сглаживающие многочлены"].Points.Clear();
            double[] smoothedData = leastSquares.ApplySmoothing(numbers, (int)powerSquares.Value); // Пример использования, предполагается, что функция возвращает массив сглаженных данных

            // Добавление сглаженных данных на график
            for (int i = 0; i < smoothedData.Length; i++)
            {
                drawChart.Series["Сглаживающие многочлены"].Points.AddXY(numbers[0, i], smoothedData[i]);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            drawChart.Series["Сглаживающие многочлены"].Points.Clear();
        }
    }
}
