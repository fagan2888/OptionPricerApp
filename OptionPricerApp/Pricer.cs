using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OptionPricing;

namespace OptionPricerApp
{
    public partial class FXOPricer : Form
    {
        public FXOPricer()
        {
            InitializeComponent();
        }

        private void Pricer_Load(object sender, EventArgs e)
        {
            InitDate();
            InitType();
            InitExerciseType();
            InitValuationMethod();
            InitDefaultVal();
        }

        private void InitDefaultVal()
        {
            this.tbBRfR.Text = "0.0";
            this.tbCrossRfR.Text = "0.0";
            this.tbVolatility.Text = "0.0";
            this.tbStrike.Text = "0.0";
            this.tbSpot.Text = "0.0";
            this.tbTtM.Text = "0.0";
            this.tbGamma.Text = "0.0";
            this.tbRho.Text = "0.0";
            this.tbTheta.Text = "0.0";
            this.tbVega.Text = "0.0";
            this.tbDelta.Text = "0.0";

            this.cboExerciseType.SelectedItem = Exercise.European;
            this.cboMonth.SelectedItem = Month.Jan;
            this.cboValuationMethod.SelectedItem = ValuationMethod.Analytic;
            this.cboType.SelectedItem = OptionPricing.Type.Call;
            this.cboYear.SelectedItem = 1990.ToString();
            this.cboWeekday.SelectedItem = Weekday.Fri;
        }

        private void InitDate()
        {
            const int startYear = 1980;

            for (int i = startYear; i <= startYear + 50; i++)
                cboYear.Items.Add(i.ToString());

            foreach (var month in Enum.GetValues(typeof(Month)))
            {
                cboMonth.Items.Add(month);
            }

            foreach (var day in Enum.GetValues(typeof(Weekday)))
            {
                cboWeekday.Items.Add(day);
            }
        }

        private void InitType()
        {
            foreach (var type in Enum.GetValues(typeof(OptionPricing.Type)))
            {
                cboType.Items.Add(type);
            }
        }

        private void InitExerciseType()
        {
            foreach (var exercise in Enum.GetValues(typeof(Exercise)))
            {
                cboExerciseType.Items.Add(exercise);
            } 
        }

        private void InitValuationMethod()
        {
            foreach (var valuemethod in Enum.GetValues(typeof(ValuationMethod)))
            {
                cboValuationMethod.Items.Add(valuemethod);
            }
        }
        

        private void btnPrice_Click(object sender, EventArgs e)
        {
            try
            {
                var date = new Date(Weekday.Fri, (Month) cboMonth.SelectedItem, (int) cboMonth.SelectedItem);

                var fxOption = new VanillaOption((Exercise) cboExerciseType.SelectedItem, double.Parse(tbStrike.Text),
                    double.Parse(tbSpot.Text), double.Parse(tbCrossRfR.Text), double.Parse(tbBRfR.Text),
                    double.Parse(tbTtM.Text), double.Parse(tbVolatility.Text), date, (OptionPricing.ValuationMethod) cboValuationMethod.SelectedItem, (OptionPricing.Type) cboType.SelectedItem);

                tboPrice.Text = fxOption.Npv().ToString();
                tbDelta.Text = fxOption.Delta().ToString();
                tbGamma.Text = fxOption.Gamma().ToString();
                tbTheta.Text = fxOption.Theta().ToString();
                tbVega.Text = fxOption.Vega().ToString();
            }
            catch (NotImplementedException ex)
            {
                MessageBox.Show("{0}", ex.Message);
            }

           
        }


    }
}
