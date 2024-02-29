namespace SimpleChart
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
         System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
         this.ButtonGenerate = new System.Windows.Forms.Button();
         this.ChartOne = new System.Windows.Forms.DataVisualization.Charting.Chart();
         ((System.ComponentModel.ISupportInitialize)(this.ChartOne)).BeginInit();
         this.SuspendLayout();
         // 
         // ButtonGenerate
         // 
         this.ButtonGenerate.Location = new System.Drawing.Point(437, 318);
         this.ButtonGenerate.Name = "ButtonGenerate";
         this.ButtonGenerate.Size = new System.Drawing.Size(75, 23);
         this.ButtonGenerate.TabIndex = 3;
         this.ButtonGenerate.Text = "Вывод";
         this.ButtonGenerate.UseVisualStyleBackColor = true;
         this.ButtonGenerate.Click += new System.EventHandler(this.ButtonGenerate_Click);
         // 
         // ChartOne
         // 
         chartArea1.Name = "ChartArea1";
         this.ChartOne.ChartAreas.Add(chartArea1);
         legend1.Name = "Legend1";
         this.ChartOne.Legends.Add(legend1);
         this.ChartOne.Location = new System.Drawing.Point(12, 12);
         this.ChartOne.Name = "ChartOne";
         this.ChartOne.Size = new System.Drawing.Size(500, 300);
         this.ChartOne.TabIndex = 5;
         this.ChartOne.Text = "Pets";
         title1.Name = "Pets";
         title1.Text = "Сказка про репку";
         this.ChartOne.Titles.Add(title1);
         // 
         // FormOne
         // 
         this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
         this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
         this.ClientSize = new System.Drawing.Size(524, 347);
         this.Controls.Add(this.ChartOne);
         this.Controls.Add(this.ButtonGenerate);
         this.Name = "FormOne";
         this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
         this.Text = "Простая диаграмма";
         this.Load += new System.EventHandler(this.FormOne_Load);
         ((System.ComponentModel.ISupportInitialize)(this.ChartOne)).EndInit();
         this.ResumeLayout(false);

      }

      #endregion

      private System.Windows.Forms.Button ButtonGenerate;
      private System.Windows.Forms.DataVisualization.Charting.Chart ChartOne;
   }
}