namespace LabApprox
{
    partial class ApproxForm
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
            System.Windows.Forms.Label label1;
            System.Windows.Forms.Label label2;
            System.Windows.Forms.Label label3;
            System.Windows.Forms.Label label5;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series21 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series22 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series23 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series24 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series25 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.drawButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.saveButton = new System.Windows.Forms.Button();
            this.coeffPanel = new System.Windows.Forms.Panel();
            this.DeleteCoeffButton = new System.Windows.Forms.Button();
            this.addCoeffButton = new System.Windows.Forms.Button();
            this.addCoeffBox = new System.Windows.Forms.TextBox();
            this.pointPanel = new System.Windows.Forms.Panel();
            this.DeletePointButton = new System.Windows.Forms.Button();
            this.addPointButton = new System.Windows.Forms.Button();
            this.addedPointYBox = new System.Windows.Forms.TextBox();
            this.addedPointXBox = new System.Windows.Forms.TextBox();
            this.powerSquares = new System.Windows.Forms.NumericUpDown();
            this.loadButton = new System.Windows.Forms.Button();
            this.funcTypeBox = new System.Windows.Forms.ComboBox();
            this.pointsList = new System.Windows.Forms.ListBox();
            this.drawChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.coeffPanel.SuspendLayout();
            this.pointPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerSquares)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawChart)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label1.Location = new System.Drawing.Point(10, 62);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(209, 25);
            label1.TabIndex = 10;
            label1.Text = "Степень многочлена";
            label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label2.Location = new System.Drawing.Point(1, 9);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(162, 25);
            label2.TabIndex = 13;
            label2.Text = "Добавить точку";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new System.Drawing.Point(67, 42);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(13, 20);
            label3.TabIndex = 16;
            label3.Text = ";";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label5.Location = new System.Drawing.Point(1, 9);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(165, 25);
            label5.TabIndex = 13;
            label5.Text = "Добавить коэф.";
            // 
            // drawButton
            // 
            this.drawButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.drawButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.drawButton.Location = new System.Drawing.Point(0, 651);
            this.drawButton.Name = "drawButton";
            this.drawButton.Size = new System.Drawing.Size(414, 46);
            this.drawButton.TabIndex = 0;
            this.drawButton.Text = "Построить";
            this.drawButton.UseVisualStyleBackColor = true;
            this.drawButton.Click += new System.EventHandler(this.DrawButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.saveButton);
            this.panel1.Controls.Add(this.coeffPanel);
            this.panel1.Controls.Add(this.pointPanel);
            this.panel1.Controls.Add(this.powerSquares);
            this.panel1.Controls.Add(label1);
            this.panel1.Controls.Add(this.loadButton);
            this.panel1.Controls.Add(this.funcTypeBox);
            this.panel1.Controls.Add(this.pointsList);
            this.panel1.Controls.Add(this.drawButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(856, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(414, 697);
            this.panel1.TabIndex = 1;
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.Location = new System.Drawing.Point(0, 307);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(414, 46);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "Сохранить список в файл";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // coeffPanel
            // 
            this.coeffPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.coeffPanel.Controls.Add(this.DeleteCoeffButton);
            this.coeffPanel.Controls.Add(this.addCoeffButton);
            this.coeffPanel.Controls.Add(this.addCoeffBox);
            this.coeffPanel.Controls.Add(label5);
            this.coeffPanel.Location = new System.Drawing.Point(0, 117);
            this.coeffPanel.Name = "coeffPanel";
            this.coeffPanel.Size = new System.Drawing.Size(414, 72);
            this.coeffPanel.TabIndex = 20;
            // 
            // DeleteCoeffButton
            // 
            this.DeleteCoeffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeleteCoeffButton.Location = new System.Drawing.Point(258, 19);
            this.DeleteCoeffButton.Name = "DeleteCoeffButton";
            this.DeleteCoeffButton.Size = new System.Drawing.Size(43, 43);
            this.DeleteCoeffButton.TabIndex = 18;
            this.DeleteCoeffButton.Text = "-";
            this.DeleteCoeffButton.UseVisualStyleBackColor = true;
            this.DeleteCoeffButton.Click += new System.EventHandler(this.DeleteCoeffButton_Click);
            // 
            // addCoeffButton
            // 
            this.addCoeffButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addCoeffButton.Location = new System.Drawing.Point(183, 19);
            this.addCoeffButton.Name = "addCoeffButton";
            this.addCoeffButton.Size = new System.Drawing.Size(43, 43);
            this.addCoeffButton.TabIndex = 17;
            this.addCoeffButton.Text = "+";
            this.addCoeffButton.UseVisualStyleBackColor = true;
            this.addCoeffButton.Click += new System.EventHandler(this.AddCoeffButton_Click);
            // 
            // addCoeffBox
            // 
            this.addCoeffBox.Location = new System.Drawing.Point(5, 39);
            this.addCoeffBox.MaxLength = 12;
            this.addCoeffBox.Name = "addCoeffBox";
            this.addCoeffBox.Size = new System.Drawing.Size(137, 26);
            this.addCoeffBox.TabIndex = 14;
            // 
            // pointPanel
            // 
            this.pointPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pointPanel.Controls.Add(this.DeletePointButton);
            this.pointPanel.Controls.Add(this.addPointButton);
            this.pointPanel.Controls.Add(label3);
            this.pointPanel.Controls.Add(this.addedPointYBox);
            this.pointPanel.Controls.Add(this.addedPointXBox);
            this.pointPanel.Controls.Add(label2);
            this.pointPanel.Location = new System.Drawing.Point(0, 189);
            this.pointPanel.Name = "pointPanel";
            this.pointPanel.Size = new System.Drawing.Size(414, 72);
            this.pointPanel.TabIndex = 19;
            // 
            // DeletePointButton
            // 
            this.DeletePointButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeletePointButton.Location = new System.Drawing.Point(258, 19);
            this.DeletePointButton.Name = "DeletePointButton";
            this.DeletePointButton.Size = new System.Drawing.Size(43, 43);
            this.DeletePointButton.TabIndex = 18;
            this.DeletePointButton.Text = "-";
            this.DeletePointButton.UseVisualStyleBackColor = true;
            this.DeletePointButton.Click += new System.EventHandler(this.DeletePointButton_Click);
            // 
            // addPointButton
            // 
            this.addPointButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addPointButton.Location = new System.Drawing.Point(183, 19);
            this.addPointButton.Name = "addPointButton";
            this.addPointButton.Size = new System.Drawing.Size(43, 43);
            this.addPointButton.TabIndex = 17;
            this.addPointButton.Text = "+";
            this.addPointButton.UseVisualStyleBackColor = true;
            this.addPointButton.Click += new System.EventHandler(this.AddPointButton_Click);
            // 
            // addedPointYBox
            // 
            this.addedPointYBox.Location = new System.Drawing.Point(86, 39);
            this.addedPointYBox.MaxLength = 12;
            this.addedPointYBox.Name = "addedPointYBox";
            this.addedPointYBox.Size = new System.Drawing.Size(56, 26);
            this.addedPointYBox.TabIndex = 15;
            // 
            // addedPointXBox
            // 
            this.addedPointXBox.Location = new System.Drawing.Point(5, 39);
            this.addedPointXBox.MaxLength = 12;
            this.addedPointXBox.Name = "addedPointXBox";
            this.addedPointXBox.Size = new System.Drawing.Size(56, 26);
            this.addedPointXBox.TabIndex = 14;
            // 
            // powerSquares
            // 
            this.powerSquares.Enabled = false;
            this.powerSquares.Location = new System.Drawing.Point(225, 62);
            this.powerSquares.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.powerSquares.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.powerSquares.Name = "powerSquares";
            this.powerSquares.Size = new System.Drawing.Size(49, 26);
            this.powerSquares.TabIndex = 11;
            this.powerSquares.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.powerSquares.ValueChanged += new System.EventHandler(this.powerSquares_ValueChanged);
            // 
            // loadButton
            // 
            this.loadButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.loadButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loadButton.Location = new System.Drawing.Point(0, 261);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(414, 46);
            this.loadButton.TabIndex = 9;
            this.loadButton.Text = "Загрузить из файла";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // funcTypeBox
            // 
            this.funcTypeBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.funcTypeBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.funcTypeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.funcTypeBox.FormattingEnabled = true;
            this.funcTypeBox.Items.AddRange(new object[] {
            "Интерполяционный многочлен Лагранжа",
            "Интерполяционный многочлен Ньютона",
            "Сглаживающие многочлены 1, 2, 3 степени, полученный по методу наименьших квадрато" +
                "в",
            "Произвольный многочлен 4 степени, заданного набором коэффициентов"});
            this.funcTypeBox.Location = new System.Drawing.Point(0, 0);
            this.funcTypeBox.Name = "funcTypeBox";
            this.funcTypeBox.Size = new System.Drawing.Size(414, 33);
            this.funcTypeBox.TabIndex = 8;
            this.funcTypeBox.SelectedIndexChanged += new System.EventHandler(this.FuncTypeBox_SelectedIndexChanged);
            // 
            // pointsList
            // 
            this.pointsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pointsList.FormattingEnabled = true;
            this.pointsList.IntegralHeight = false;
            this.pointsList.ItemHeight = 20;
            this.pointsList.Location = new System.Drawing.Point(0, 410);
            this.pointsList.Name = "pointsList";
            this.pointsList.Size = new System.Drawing.Size(414, 241);
            this.pointsList.TabIndex = 7;
            // 
            // drawChart
            // 
            this.drawChart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea5.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Cross;
            chartArea5.Name = "ChartArea1";
            this.drawChart.ChartAreas.Add(chartArea5);
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Top;
            legend5.Name = "Legend1";
            legend5.TableStyle = System.Windows.Forms.DataVisualization.Charting.LegendTableStyle.Wide;
            this.drawChart.Legends.Add(legend5);
            this.drawChart.Location = new System.Drawing.Point(0, 0);
            this.drawChart.Name = "drawChart";
            this.drawChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SemiTransparent;
            series21.BorderWidth = 4;
            series21.ChartArea = "ChartArea1";
            series21.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series21.Color = System.Drawing.Color.Red;
            series21.Legend = "Legend1";
            series21.Name = "Интерполяция Ньютона";
            series22.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.DashDotDot;
            series22.BorderWidth = 3;
            series22.ChartArea = "ChartArea1";
            series22.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series22.Color = System.Drawing.Color.Blue;
            series22.Legend = "Legend1";
            series22.Name = "Интерполяция Лагранжа";
            series23.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series23.BorderWidth = 2;
            series23.ChartArea = "ChartArea1";
            series23.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series23.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            series23.Legend = "Legend1";
            series23.Name = "Сглаживающие многочлены";
            series24.BorderWidth = 2;
            series24.ChartArea = "ChartArea1";
            series24.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series24.Color = System.Drawing.Color.Fuchsia;
            series24.Legend = "Legend1";
            series24.Name = "Многочлен 4 степени";
            series25.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series25.ChartArea = "ChartArea1";
            series25.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;
            series25.Color = System.Drawing.Color.Yellow;
            series25.IsValueShownAsLabel = true;
            series25.Legend = "Legend1";
            series25.MarkerStyle = System.Windows.Forms.DataVisualization.Charting.MarkerStyle.Circle;
            series25.Name = "Исходные точки";
            this.drawChart.Series.Add(series21);
            this.drawChart.Series.Add(series22);
            this.drawChart.Series.Add(series23);
            this.drawChart.Series.Add(series24);
            this.drawChart.Series.Add(series25);
            this.drawChart.Size = new System.Drawing.Size(855, 697);
            this.drawChart.TabIndex = 2;
            this.drawChart.Text = "chart1";
            this.drawChart.Click += new System.EventHandler(this.drawChart_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(0, 352);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 64);
            this.button1.TabIndex = 22;
            this.button1.Text = "Не костыль";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(205, 352);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(206, 64);
            this.button2.TabIndex = 23;
            this.button2.Text = "отчистка";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ApproxForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1270, 697);
            this.Controls.Add(this.drawChart);
            this.Controls.Add(this.panel1);
            this.Name = "ApproxForm";
            this.Text = "Аппроксимация функций";
            this.Load += new System.EventHandler(this.ApproxForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.coeffPanel.ResumeLayout(false);
            this.coeffPanel.PerformLayout();
            this.pointPanel.ResumeLayout(false);
            this.pointPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.powerSquares)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drawChart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button drawButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListBox pointsList;
        private System.Windows.Forms.DataVisualization.Charting.Chart drawChart;
        private System.Windows.Forms.ComboBox funcTypeBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.NumericUpDown powerSquares;
        private System.Windows.Forms.TextBox addedPointYBox;
        private System.Windows.Forms.TextBox addedPointXBox;
        private System.Windows.Forms.Button DeletePointButton;
        private System.Windows.Forms.Button addPointButton;
        private System.Windows.Forms.Panel pointPanel;
        private System.Windows.Forms.Panel coeffPanel;
        private System.Windows.Forms.Button DeleteCoeffButton;
        private System.Windows.Forms.Button addCoeffButton;
        private System.Windows.Forms.TextBox addCoeffBox;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

