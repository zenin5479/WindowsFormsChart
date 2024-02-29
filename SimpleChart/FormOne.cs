using System;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace SimpleChart
{
   public partial class FormOne : Form
   {
      public FormOne()
      {
         InitializeComponent();
      }

      private void FormOne_Load(object sender, EventArgs e)
      {

      }

      private void ButtonGenerate_Click(object sender, EventArgs e)
      {
         // Массив данных
         string[] seriesArray = { "Репка", "Дед", "Бабка", "Внучка", "Собака", "Кошка", "Мышка" };
         int[] pointsArray = { 1, 50, 45, 17, 10, 7, 5 };

         for (int i = 0; i < seriesArray.Length; i++)
         {
            Series series = ChartOne.Series.Add(seriesArray[i]);
            series.Points.Add(pointsArray[i]);
         }
      }
   }
}