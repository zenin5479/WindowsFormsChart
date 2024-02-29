using System;
using System.Windows.Forms;

namespace GraphChart
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

      private void ButtonBuildGraph_Click(object sender, EventArgs e)
      {
         double a = Convert.ToDouble(TextBoxA.Text);
         double b = Convert.ToDouble(TextBoxB.Text);
         double h = Convert.ToDouble(TextBoxStep.Text);
         double oneVariable = double.Parse(TextBoxOneVariable.Text);
         double twoVariable = double.Parse(TextBoxTwoVariable.Text);
         double threeVariable = double.Parse(TextBoxThreeVariable.Text);
         ChartOne.Series[0].Points.Clear();
         double x = a;
         while (x <= b)
         {
            double y = Math.Sin(oneVariable * x / twoVariable + threeVariable);
            ChartOne.Series[0].Points.AddXY(x, y);
            x += h;
         }
      }

      private void ButtonClear_Click(object sender, EventArgs e)
      {
         ChartOne.Series[0].Points.Clear();
      }

      private void CheckBoxSin_CheckedChanged(object sender, EventArgs e)
      {
         if (CheckBoxSin.Checked)
         {
            double a = double.Parse(TextBoxA.Text);
            double b = double.Parse(TextBoxB.Text);
            double h = double.Parse(TextBoxStep.Text);
            ChartOne.Series[1].Points.Clear();
            double x = a;
            while (x <= b)
            {
               double y = Math.Sin(x);
               ChartOne.Series[1].Points.AddXY(x, y);
               x += h;
            }
         }
         else
         {
            ChartOne.Series[1].Points.Clear();
         }

      }
      private void CheckBoxCos_CheckedChanged(object sender, EventArgs e)
      {
         if (CheckBoxCos.Checked)
         {
            double a = double.Parse(TextBoxA.Text);
            double b = double.Parse(TextBoxB.Text);
            double h = double.Parse(TextBoxStep.Text);
            ChartOne.Series[2].Points.Clear();
            double x = a;
            while (x <= b)
            {
               double y = Math.Cos(x);
               ChartOne.Series[2].Points.AddXY(x, y);
               x += h;
            }
         }
         else
         {
            ChartOne.Series[2].Points.Clear();
         }
      }

      private void CheckBoxSinCos_CheckedChanged(object sender, EventArgs e)
      {
         if (CheckBoxSinCos.Checked)
         {
            double a = double.Parse(TextBoxA.Text);
            double b = double.Parse(TextBoxB.Text);
            double h = double.Parse(TextBoxStep.Text);
            ChartOne.Series[3].Points.Clear();
            double x = a;
            while (x <= b)
            {
               double y = Math.Sin(x) + Math.Cos(x);
               ChartOne.Series[3].Points.AddXY(x, y);
               x += h;
            }
         }
         else
         {
            ChartOne.Series[3].Points.Clear();
         }
      }
   }
}