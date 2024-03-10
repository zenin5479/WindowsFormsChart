namespace GraphChart
{
   partial class FormOne
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
         System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
         System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
         System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
         System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
         System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
         System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
         System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
         this.ChartOne = new System.Windows.Forms.DataVisualization.Charting.Chart();
         this.ButtonBuildGraph = new System.Windows.Forms.Button();
         this.CheckBoxSin = new System.Windows.Forms.CheckBox();
         this.ButtonClear = new System.Windows.Forms.Button();
         this.CheckBoxCos = new System.Windows.Forms.CheckBox();
         this.TextBoxOneVariable = new System.Windows.Forms.TextBox();
         this.LabelOneVariable = new System.Windows.Forms.Label();
         this.TextBoxTwoVariable = new System.Windows.Forms.TextBox();
         this.LabelTwoVariable = new System.Windows.Forms.Label();
         this.TextBoxThreeVariable = new System.Windows.Forms.TextBox();
         this.LabelThreeVariable = new System.Windows.Forms.Label();
         this.LabelStep = new System.Windows.Forms.Label();
         this.TextBoxStep = new System.Windows.Forms.TextBox();
         this.LabelRightBorder = new System.Windows.Forms.Label();
         this.TextBoxB = new System.Windows.Forms.TextBox();
         this.LabelLeftBorder = new System.Windows.Forms.Label();
         this.TextBoxA = new System.Windows.Forms.TextBox();
         this.groupBox1 = new System.Windows.Forms.GroupBox();
         this.CheckBoxSinCos = new System.Windows.Forms.CheckBox();
         this.GroupBoxChartParameters = new System.Windows.Forms.GroupBox();
         this.GroupBoxEnteringVariables = new System.Windows.Forms.GroupBox();
         this.LabelBracket = new System.Windows.Forms.Label();
         ((System.ComponentModel.ISupportInitialize)(this.ChartOne)).BeginInit();
         this.groupBox1.SuspendLayout();
         this.GroupBoxChartParameters.SuspendLayout();
         this.GroupBoxEnteringVariables.SuspendLayout();
         this.SuspendLayout();
         // 
         // ChartOne
         // 
         chartArea1.Name = "ChartArea1";
         this.ChartOne.ChartAreas.Add(chartArea1);
         legend1.Name = "Legend1";
         legend1.Title = "Функция";
         this.ChartOne.Legends.Add(legend1);
         this.ChartOne.Location = new System.Drawing.Point(12, 12);
         this.ChartOne.Name = "ChartOne";
         series1.BorderWidth = 3;
         series1.ChartArea = "ChartArea1";
         series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
         series1.Color = System.Drawing.Color.Fuchsia;
         series1.Legend = "Legend1";
         series1.LegendText = "y = sin(-10*x/7+5)";
         series1.LegendToolTip = "y = sin(-10*x/7+5)";
         series1.Name = "Series0";
         series1.YValuesPerPoint = 2;
         series2.BorderWidth = 3;
         series2.ChartArea = "ChartArea1";
         series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
         series2.Color = System.Drawing.Color.Indigo;
         series2.Legend = "Legend1";
         series2.LegendText = "y = sin(x)";
         series2.LegendToolTip = "y = sin(x)";
         series2.Name = "Series1";
         series3.BorderWidth = 3;
         series3.ChartArea = "ChartArea1";
         series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
         series3.Color = System.Drawing.Color.DarkOrange;
         series3.Legend = "Legend1";
         series3.LegendText = "y = cos(x)";
         series3.LegendToolTip = "y = cos(x)";
         series3.Name = "Series2";
         series4.BorderWidth = 3;
         series4.ChartArea = "ChartArea1";
         series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
         series4.Color = System.Drawing.Color.Lime;
         series4.Legend = "Legend1";
         series4.LegendText = "y = sin(x)+cos(x)";
         series4.LegendToolTip = "y = sin(x)+cos(x)";
         series4.Name = "Series3";
         this.ChartOne.Series.Add(series1);
         this.ChartOne.Series.Add(series2);
         this.ChartOne.Series.Add(series3);
         this.ChartOne.Series.Add(series4);
         this.ChartOne.Size = new System.Drawing.Size(570, 438);
         this.ChartOne.TabIndex = 0;
         this.ChartOne.Text = "График";
         title1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
         title1.Name = "Title1";
         title1.Text = "Графики функций";
         this.ChartOne.Titles.Add(title1);
         // 
         // ButtonBuildGraph
         // 
         this.ButtonBuildGraph.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.ButtonBuildGraph.Location = new System.Drawing.Point(9, 51);
         this.ButtonBuildGraph.Name = "ButtonBuildGraph";
         this.ButtonBuildGraph.Size = new System.Drawing.Size(158, 30);
         this.ButtonBuildGraph.TabIndex = 1;
         this.ButtonBuildGraph.Text = "Построить график";
         this.ButtonBuildGraph.UseVisualStyleBackColor = true;
         this.ButtonBuildGraph.Click += new System.EventHandler(this.ButtonBuildGraph_Click);
         // 
         // CheckBoxSin
         // 
         this.CheckBoxSin.AutoSize = true;
         this.CheckBoxSin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.CheckBoxSin.Location = new System.Drawing.Point(6, 22);
         this.CheckBoxSin.Name = "CheckBoxSin";
         this.CheckBoxSin.Size = new System.Drawing.Size(94, 21);
         this.CheckBoxSin.TabIndex = 2;
         this.CheckBoxSin.Text = "y = sin(x)";
         this.CheckBoxSin.UseVisualStyleBackColor = true;
         this.CheckBoxSin.CheckedChanged += new System.EventHandler(this.CheckBoxSin_CheckedChanged);
         // 
         // ButtonClear
         // 
         this.ButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.ButtonClear.Location = new System.Drawing.Point(185, 51);
         this.ButtonClear.Name = "ButtonClear";
         this.ButtonClear.Size = new System.Drawing.Size(150, 30);
         this.ButtonClear.TabIndex = 3;
         this.ButtonClear.Text = "Очистить график";
         this.ButtonClear.UseVisualStyleBackColor = true;
         this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
         // 
         // CheckBoxCos
         // 
         this.CheckBoxCos.AutoSize = true;
         this.CheckBoxCos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.CheckBoxCos.Location = new System.Drawing.Point(120, 22);
         this.CheckBoxCos.Name = "CheckBoxCos";
         this.CheckBoxCos.Size = new System.Drawing.Size(98, 21);
         this.CheckBoxCos.TabIndex = 4;
         this.CheckBoxCos.Text = "y = cos(x)";
         this.CheckBoxCos.UseVisualStyleBackColor = true;
         this.CheckBoxCos.CheckedChanged += new System.EventHandler(this.CheckBoxCos_CheckedChanged);
         // 
         // TextBoxOneVariable
         // 
         this.TextBoxOneVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.TextBoxOneVariable.Location = new System.Drawing.Point(74, 22);
         this.TextBoxOneVariable.Name = "TextBoxOneVariable";
         this.TextBoxOneVariable.Size = new System.Drawing.Size(58, 23);
         this.TextBoxOneVariable.TabIndex = 5;
         this.TextBoxOneVariable.Text = "-10";
         // 
         // LabelOneVariable
         // 
         this.LabelOneVariable.AutoSize = true;
         this.LabelOneVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.LabelOneVariable.Location = new System.Drawing.Point(6, 25);
         this.LabelOneVariable.Name = "LabelOneVariable";
         this.LabelOneVariable.Size = new System.Drawing.Size(62, 17);
         this.LabelOneVariable.TabIndex = 6;
         this.LabelOneVariable.Text = "y = sin(";
         // 
         // TextBoxTwoVariable
         // 
         this.TextBoxTwoVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.TextBoxTwoVariable.Location = new System.Drawing.Point(185, 22);
         this.TextBoxTwoVariable.Name = "TextBoxTwoVariable";
         this.TextBoxTwoVariable.Size = new System.Drawing.Size(58, 23);
         this.TextBoxTwoVariable.TabIndex = 7;
         this.TextBoxTwoVariable.Text = "7";
         // 
         // LabelTwoVariable
         // 
         this.LabelTwoVariable.AutoSize = true;
         this.LabelTwoVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.LabelTwoVariable.Location = new System.Drawing.Point(138, 25);
         this.LabelTwoVariable.Name = "LabelTwoVariable";
         this.LabelTwoVariable.Size = new System.Drawing.Size(41, 17);
         this.LabelTwoVariable.TabIndex = 8;
         this.LabelTwoVariable.Text = "* x  /";
         // 
         // TextBoxThreeVariable
         // 
         this.TextBoxThreeVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.TextBoxThreeVariable.Location = new System.Drawing.Point(277, 22);
         this.TextBoxThreeVariable.Name = "TextBoxThreeVariable";
         this.TextBoxThreeVariable.Size = new System.Drawing.Size(58, 23);
         this.TextBoxThreeVariable.TabIndex = 9;
         this.TextBoxThreeVariable.Text = "5";
         // 
         // LabelThreeVariable
         // 
         this.LabelThreeVariable.AutoSize = true;
         this.LabelThreeVariable.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.LabelThreeVariable.Location = new System.Drawing.Point(249, 25);
         this.LabelThreeVariable.Name = "LabelThreeVariable";
         this.LabelThreeVariable.Size = new System.Drawing.Size(22, 17);
         this.LabelThreeVariable.TabIndex = 10;
         this.LabelThreeVariable.Text = " +";
         // 
         // LabelStep
         // 
         this.LabelStep.AutoSize = true;
         this.LabelStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.LabelStep.Location = new System.Drawing.Point(6, 111);
         this.LabelStep.Name = "LabelStep";
         this.LabelStep.Size = new System.Drawing.Size(35, 17);
         this.LabelStep.TabIndex = 16;
         this.LabelStep.Text = "Шаг";
         // 
         // TextBoxStep
         // 
         this.TextBoxStep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.TextBoxStep.Location = new System.Drawing.Point(9, 131);
         this.TextBoxStep.Name = "TextBoxStep";
         this.TextBoxStep.Size = new System.Drawing.Size(60, 23);
         this.TextBoxStep.TabIndex = 15;
         this.TextBoxStep.Text = "0,01";
         // 
         // LabelRightBorder
         // 
         this.LabelRightBorder.AutoSize = true;
         this.LabelRightBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.LabelRightBorder.Location = new System.Drawing.Point(6, 65);
         this.LabelRightBorder.Name = "LabelRightBorder";
         this.LabelRightBorder.Size = new System.Drawing.Size(128, 17);
         this.LabelRightBorder.TabIndex = 14;
         this.LabelRightBorder.Text = "Правая граница";
         // 
         // TextBoxB
         // 
         this.TextBoxB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.TextBoxB.Location = new System.Drawing.Point(9, 85);
         this.TextBoxB.Name = "TextBoxB";
         this.TextBoxB.Size = new System.Drawing.Size(60, 23);
         this.TextBoxB.TabIndex = 13;
         this.TextBoxB.Text = "10";
         // 
         // LabelLeftBorder
         // 
         this.LabelLeftBorder.AutoSize = true;
         this.LabelLeftBorder.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.LabelLeftBorder.Location = new System.Drawing.Point(6, 19);
         this.LabelLeftBorder.Name = "LabelLeftBorder";
         this.LabelLeftBorder.Size = new System.Drawing.Size(119, 17);
         this.LabelLeftBorder.TabIndex = 12;
         this.LabelLeftBorder.Text = "Левая граница";
         // 
         // TextBoxA
         // 
         this.TextBoxA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.TextBoxA.Location = new System.Drawing.Point(9, 39);
         this.TextBoxA.Name = "TextBoxA";
         this.TextBoxA.Size = new System.Drawing.Size(60, 23);
         this.TextBoxA.TabIndex = 11;
         this.TextBoxA.Text = "-10";
         // 
         // groupBox1
         // 
         this.groupBox1.Controls.Add(this.CheckBoxSinCos);
         this.groupBox1.Controls.Add(this.CheckBoxCos);
         this.groupBox1.Controls.Add(this.CheckBoxSin);
         this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.groupBox1.Location = new System.Drawing.Point(199, 567);
         this.groupBox1.Name = "groupBox1";
         this.groupBox1.Size = new System.Drawing.Size(383, 50);
         this.groupBox1.TabIndex = 17;
         this.groupBox1.TabStop = false;
         this.groupBox1.Text = "Дополнительные функции";
         // 
         // CheckBoxSinCos
         // 
         this.CheckBoxSinCos.AutoSize = true;
         this.CheckBoxSinCos.Location = new System.Drawing.Point(224, 22);
         this.CheckBoxSinCos.Name = "CheckBoxSinCos";
         this.CheckBoxSinCos.Size = new System.Drawing.Size(157, 21);
         this.CheckBoxSinCos.TabIndex = 5;
         this.CheckBoxSinCos.Text = "y = sin(x) + cos(x)";
         this.CheckBoxSinCos.UseVisualStyleBackColor = true;
         this.CheckBoxSinCos.CheckedChanged += new System.EventHandler(this.CheckBoxSinCos_CheckedChanged);
         // 
         // GroupBoxChartParameters
         // 
         this.GroupBoxChartParameters.Controls.Add(this.LabelLeftBorder);
         this.GroupBoxChartParameters.Controls.Add(this.TextBoxA);
         this.GroupBoxChartParameters.Controls.Add(this.LabelStep);
         this.GroupBoxChartParameters.Controls.Add(this.TextBoxB);
         this.GroupBoxChartParameters.Controls.Add(this.TextBoxStep);
         this.GroupBoxChartParameters.Controls.Add(this.LabelRightBorder);
         this.GroupBoxChartParameters.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.GroupBoxChartParameters.Location = new System.Drawing.Point(12, 456);
         this.GroupBoxChartParameters.Name = "GroupBoxChartParameters";
         this.GroupBoxChartParameters.Size = new System.Drawing.Size(176, 165);
         this.GroupBoxChartParameters.TabIndex = 18;
         this.GroupBoxChartParameters.TabStop = false;
         this.GroupBoxChartParameters.Text = "Параметры графика";
         // 
         // GroupBoxEnteringVariables
         // 
         this.GroupBoxEnteringVariables.Controls.Add(this.LabelBracket);
         this.GroupBoxEnteringVariables.Controls.Add(this.ButtonBuildGraph);
         this.GroupBoxEnteringVariables.Controls.Add(this.ButtonClear);
         this.GroupBoxEnteringVariables.Controls.Add(this.TextBoxOneVariable);
         this.GroupBoxEnteringVariables.Controls.Add(this.LabelThreeVariable);
         this.GroupBoxEnteringVariables.Controls.Add(this.LabelOneVariable);
         this.GroupBoxEnteringVariables.Controls.Add(this.TextBoxThreeVariable);
         this.GroupBoxEnteringVariables.Controls.Add(this.TextBoxTwoVariable);
         this.GroupBoxEnteringVariables.Controls.Add(this.LabelTwoVariable);
         this.GroupBoxEnteringVariables.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.GroupBoxEnteringVariables.Location = new System.Drawing.Point(223, 456);
         this.GroupBoxEnteringVariables.Name = "GroupBoxEnteringVariables";
         this.GroupBoxEnteringVariables.Size = new System.Drawing.Size(359, 92);
         this.GroupBoxEnteringVariables.TabIndex = 19;
         this.GroupBoxEnteringVariables.TabStop = false;
         this.GroupBoxEnteringVariables.Text = "Ввод переменных для функции sin ";
         // 
         // LabelBracket
         // 
         this.LabelBracket.AutoSize = true;
         this.LabelBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
         this.LabelBracket.Location = new System.Drawing.Point(341, 25);
         this.LabelBracket.Name = "LabelBracket";
         this.LabelBracket.Size = new System.Drawing.Size(14, 17);
         this.LabelBracket.TabIndex = 11;
         this.LabelBracket.Text = ")";
         // 
         // FormOne
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(596, 629);
         this.Controls.Add(this.GroupBoxEnteringVariables);
         this.Controls.Add(this.GroupBoxChartParameters);
         this.Controls.Add(this.groupBox1);
         this.Controls.Add(this.ChartOne);
         this.Name = "FormOne";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "График Chart";
         this.Load += new System.EventHandler(this.FormOne_Load);
         ((System.ComponentModel.ISupportInitialize)(this.ChartOne)).EndInit();
         this.groupBox1.ResumeLayout(false);
         this.groupBox1.PerformLayout();
         this.GroupBoxChartParameters.ResumeLayout(false);
         this.GroupBoxChartParameters.PerformLayout();
         this.GroupBoxEnteringVariables.ResumeLayout(false);
         this.GroupBoxEnteringVariables.PerformLayout();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.DataVisualization.Charting.Chart ChartOne;
      private System.Windows.Forms.Button ButtonBuildGraph;
      private System.Windows.Forms.CheckBox CheckBoxSin;
      private System.Windows.Forms.Button ButtonClear;
      private System.Windows.Forms.CheckBox CheckBoxCos;
      private System.Windows.Forms.TextBox TextBoxOneVariable;
      private System.Windows.Forms.Label LabelOneVariable;
      private System.Windows.Forms.TextBox TextBoxTwoVariable;
      private System.Windows.Forms.Label LabelTwoVariable;
      private System.Windows.Forms.TextBox TextBoxThreeVariable;
      private System.Windows.Forms.Label LabelThreeVariable;
      private System.Windows.Forms.Label LabelStep;
      private System.Windows.Forms.TextBox TextBoxStep;
      private System.Windows.Forms.Label LabelRightBorder;
      private System.Windows.Forms.TextBox TextBoxB;
      private System.Windows.Forms.Label LabelLeftBorder;
      private System.Windows.Forms.TextBox TextBoxA;
      private System.Windows.Forms.GroupBox groupBox1;
      private System.Windows.Forms.CheckBox CheckBoxSinCos;
      private System.Windows.Forms.GroupBox GroupBoxChartParameters;
      private System.Windows.Forms.GroupBox GroupBoxEnteringVariables;
      private System.Windows.Forms.Label LabelBracket;
   }
}