namespace OptionPricerApp
{
    partial class FXOPricer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbStrike = new System.Windows.Forms.TextBox();
            this.tbVolatility = new System.Windows.Forms.TextBox();
            this.tbSpot = new System.Windows.Forms.TextBox();
            this.cboYear = new System.Windows.Forms.ComboBox();
            this.cboExerciseType = new System.Windows.Forms.ComboBox();
            this.lStrike = new System.Windows.Forms.Label();
            this.lUnderlying = new System.Windows.Forms.Label();
            this.lVol = new System.Windows.Forms.Label();
            this.tbBRfR = new System.Windows.Forms.TextBox();
            this.lRfR = new System.Windows.Forms.Label();
            this.lExerciseType = new System.Windows.Forms.Label();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.lPutCall = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbCrossRfR = new System.Windows.Forms.TextBox();
            this.lTtM = new System.Windows.Forms.Label();
            this.tbTtM = new System.Windows.Forms.TextBox();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.lMonth = new System.Windows.Forms.Label();
            this.lYear = new System.Windows.Forms.Label();
            this.lDay = new System.Windows.Forms.Label();
            this.btnPrice = new System.Windows.Forms.Button();
            this.tboPrice = new System.Windows.Forms.TextBox();
            this.lPrice = new System.Windows.Forms.Label();
            this.cboValuationMethod = new System.Windows.Forms.ComboBox();
            this.lPriceMethod = new System.Windows.Forms.Label();
            this.cboWeekday = new System.Windows.Forms.ComboBox();
            this.tbVega = new System.Windows.Forms.TextBox();
            this.tbDelta = new System.Windows.Forms.TextBox();
            this.tbGamma = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lVega = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbRho = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTheta = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbStrike
            // 
            this.tbStrike.Location = new System.Drawing.Point(12, 40);
            this.tbStrike.Name = "tbStrike";
            this.tbStrike.Size = new System.Drawing.Size(122, 20);
            this.tbStrike.TabIndex = 0;
            // 
            // tbVolatility
            // 
            this.tbVolatility.Location = new System.Drawing.Point(12, 142);
            this.tbVolatility.Name = "tbVolatility";
            this.tbVolatility.Size = new System.Drawing.Size(122, 20);
            this.tbVolatility.TabIndex = 5;
            // 
            // tbSpot
            // 
            this.tbSpot.Location = new System.Drawing.Point(12, 92);
            this.tbSpot.Name = "tbSpot";
            this.tbSpot.Size = new System.Drawing.Size(122, 20);
            this.tbSpot.TabIndex = 6;
            // 
            // cboYear
            // 
            this.cboYear.FormattingEnabled = true;
            this.cboYear.Location = new System.Drawing.Point(290, 141);
            this.cboYear.Name = "cboYear";
            this.cboYear.Size = new System.Drawing.Size(48, 21);
            this.cboYear.TabIndex = 7;
            // 
            // cboExerciseType
            // 
            this.cboExerciseType.FormattingEnabled = true;
            this.cboExerciseType.Location = new System.Drawing.Point(212, 40);
            this.cboExerciseType.Name = "cboExerciseType";
            this.cboExerciseType.Size = new System.Drawing.Size(126, 21);
            this.cboExerciseType.TabIndex = 8;
            // 
            // lStrike
            // 
            this.lStrike.AutoSize = true;
            this.lStrike.Location = new System.Drawing.Point(12, 24);
            this.lStrike.Name = "lStrike";
            this.lStrike.Size = new System.Drawing.Size(34, 13);
            this.lStrike.TabIndex = 9;
            this.lStrike.Text = "Strike";
            // 
            // lUnderlying
            // 
            this.lUnderlying.AutoSize = true;
            this.lUnderlying.Location = new System.Drawing.Point(12, 76);
            this.lUnderlying.Name = "lUnderlying";
            this.lUnderlying.Size = new System.Drawing.Size(57, 13);
            this.lUnderlying.TabIndex = 10;
            this.lUnderlying.Text = "Underlying";
            // 
            // lVol
            // 
            this.lVol.AutoSize = true;
            this.lVol.Location = new System.Drawing.Point(12, 126);
            this.lVol.Name = "lVol";
            this.lVol.Size = new System.Drawing.Size(45, 13);
            this.lVol.TabIndex = 11;
            this.lVol.Text = "Volatility";
            // 
            // tbBRfR
            // 
            this.tbBRfR.Location = new System.Drawing.Point(12, 196);
            this.tbBRfR.Name = "tbBRfR";
            this.tbBRfR.Size = new System.Drawing.Size(122, 20);
            this.tbBRfR.TabIndex = 12;
            // 
            // lRfR
            // 
            this.lRfR.AutoSize = true;
            this.lRfR.Location = new System.Drawing.Point(12, 180);
            this.lRfR.Name = "lRfR";
            this.lRfR.Size = new System.Drawing.Size(105, 13);
            this.lRfR.TabIndex = 13;
            this.lRfR.Text = "Base Risk Free Rate";
            // 
            // lExerciseType
            // 
            this.lExerciseType.AutoSize = true;
            this.lExerciseType.Location = new System.Drawing.Point(214, 24);
            this.lExerciseType.Name = "lExerciseType";
            this.lExerciseType.Size = new System.Drawing.Size(74, 13);
            this.lExerciseType.TabIndex = 14;
            this.lExerciseType.Text = "Exercise Type";
            // 
            // cboType
            // 
            this.cboType.FormattingEnabled = true;
            this.cboType.Location = new System.Drawing.Point(212, 92);
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(126, 21);
            this.cboType.TabIndex = 15;
            // 
            // lPutCall
            // 
            this.lPutCall.AutoSize = true;
            this.lPutCall.Location = new System.Drawing.Point(214, 76);
            this.lPutCall.Name = "lPutCall";
            this.lPutCall.Size = new System.Drawing.Size(45, 13);
            this.lPutCall.TabIndex = 16;
            this.lPutCall.Text = "Put/Call";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Cross Risk Free Rate";
            // 
            // tbCrossRfR
            // 
            this.tbCrossRfR.Location = new System.Drawing.Point(12, 255);
            this.tbCrossRfR.Name = "tbCrossRfR";
            this.tbCrossRfR.Size = new System.Drawing.Size(122, 20);
            this.tbCrossRfR.TabIndex = 18;
            // 
            // lTtM
            // 
            this.lTtM.AutoSize = true;
            this.lTtM.Location = new System.Drawing.Point(9, 297);
            this.lTtM.Name = "lTtM";
            this.lTtM.Size = new System.Drawing.Size(119, 13);
            this.lTtM.TabIndex = 19;
            this.lTtM.Text = "Time To Maturity (Days)";
            // 
            // tbTtM
            // 
            this.tbTtM.Location = new System.Drawing.Point(12, 313);
            this.tbTtM.Name = "tbTtM";
            this.tbTtM.Size = new System.Drawing.Size(122, 20);
            this.tbTtM.TabIndex = 20;
            // 
            // cboMonth
            // 
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Location = new System.Drawing.Point(245, 141);
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(39, 21);
            this.cboMonth.TabIndex = 21;
            // 
            // lMonth
            // 
            this.lMonth.AutoSize = true;
            this.lMonth.Location = new System.Drawing.Point(246, 125);
            this.lMonth.Name = "lMonth";
            this.lMonth.Size = new System.Drawing.Size(37, 13);
            this.lMonth.TabIndex = 22;
            this.lMonth.Text = "Month";
            // 
            // lYear
            // 
            this.lYear.AutoSize = true;
            this.lYear.Location = new System.Drawing.Point(287, 125);
            this.lYear.Name = "lYear";
            this.lYear.Size = new System.Drawing.Size(29, 13);
            this.lYear.TabIndex = 23;
            this.lYear.Text = "Year";
            // 
            // lDay
            // 
            this.lDay.AutoSize = true;
            this.lDay.Location = new System.Drawing.Point(210, 125);
            this.lDay.Name = "lDay";
            this.lDay.Size = new System.Drawing.Size(26, 13);
            this.lDay.TabIndex = 25;
            this.lDay.Text = "Day";
            // 
            // btnPrice
            // 
            this.btnPrice.Location = new System.Drawing.Point(132, 431);
            this.btnPrice.Name = "btnPrice";
            this.btnPrice.Size = new System.Drawing.Size(75, 23);
            this.btnPrice.TabIndex = 26;
            this.btnPrice.Text = "Price";
            this.btnPrice.UseVisualStyleBackColor = true;
            this.btnPrice.Click += new System.EventHandler(this.btnPrice_Click);
            // 
            // tboPrice
            // 
            this.tboPrice.Location = new System.Drawing.Point(212, 196);
            this.tboPrice.Name = "tboPrice";
            this.tboPrice.Size = new System.Drawing.Size(100, 20);
            this.tboPrice.TabIndex = 27;
            // 
            // lPrice
            // 
            this.lPrice.AutoSize = true;
            this.lPrice.Location = new System.Drawing.Point(209, 180);
            this.lPrice.Name = "lPrice";
            this.lPrice.Size = new System.Drawing.Size(31, 13);
            this.lPrice.TabIndex = 28;
            this.lPrice.Text = "Price";
            // 
            // cboValuationMethod
            // 
            this.cboValuationMethod.FormattingEnabled = true;
            this.cboValuationMethod.Location = new System.Drawing.Point(15, 383);
            this.cboValuationMethod.Name = "cboValuationMethod";
            this.cboValuationMethod.Size = new System.Drawing.Size(121, 21);
            this.cboValuationMethod.TabIndex = 29;
            // 
            // lPriceMethod
            // 
            this.lPriceMethod.AutoSize = true;
            this.lPriceMethod.Location = new System.Drawing.Point(21, 367);
            this.lPriceMethod.Name = "lPriceMethod";
            this.lPriceMethod.Size = new System.Drawing.Size(78, 13);
            this.lPriceMethod.TabIndex = 30;
            this.lPriceMethod.Text = "Pricing Method";
            // 
            // cboWeekday
            // 
            this.cboWeekday.FormattingEnabled = true;
            this.cboWeekday.Location = new System.Drawing.Point(200, 141);
            this.cboWeekday.Name = "cboWeekday";
            this.cboWeekday.Size = new System.Drawing.Size(39, 21);
            this.cboWeekday.TabIndex = 31;
            // 
            // tbVega
            // 
            this.tbVega.Location = new System.Drawing.Point(213, 277);
            this.tbVega.Name = "tbVega";
            this.tbVega.Size = new System.Drawing.Size(100, 20);
            this.tbVega.TabIndex = 33;
            // 
            // tbDelta
            // 
            this.tbDelta.Location = new System.Drawing.Point(212, 317);
            this.tbDelta.Name = "tbDelta";
            this.tbDelta.Size = new System.Drawing.Size(100, 20);
            this.tbDelta.TabIndex = 34;
            // 
            // tbGamma
            // 
            this.tbGamma.Location = new System.Drawing.Point(212, 357);
            this.tbGamma.Name = "tbGamma";
            this.tbGamma.Size = new System.Drawing.Size(100, 20);
            this.tbGamma.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 40;
            // 
            // lVega
            // 
            this.lVega.AutoSize = true;
            this.lVega.Location = new System.Drawing.Point(216, 260);
            this.lVega.Name = "lVega";
            this.lVega.Size = new System.Drawing.Size(32, 13);
            this.lVega.TabIndex = 37;
            this.lVega.Text = "Vega";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Delta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(215, 340);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Gamma";
            // 
            // tbRho
            // 
            this.tbRho.Location = new System.Drawing.Point(212, 239);
            this.tbRho.Name = "tbRho";
            this.tbRho.Size = new System.Drawing.Size(100, 20);
            this.tbRho.TabIndex = 41;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(217, 223);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 42;
            this.label3.Text = "Rho";
            // 
            // tbTheta
            // 
            this.tbTheta.Location = new System.Drawing.Point(213, 404);
            this.tbTheta.Name = "tbTheta";
            this.tbTheta.Size = new System.Drawing.Size(100, 20);
            this.tbTheta.TabIndex = 43;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(217, 386);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 44;
            this.label6.Text = "Theta";
            // 
            // FXOPricer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 466);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTheta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbRho);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lVega);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbGamma);
            this.Controls.Add(this.tbDelta);
            this.Controls.Add(this.tbVega);
            this.Controls.Add(this.cboWeekday);
            this.Controls.Add(this.lPriceMethod);
            this.Controls.Add(this.cboValuationMethod);
            this.Controls.Add(this.lPrice);
            this.Controls.Add(this.tboPrice);
            this.Controls.Add(this.btnPrice);
            this.Controls.Add(this.lDay);
            this.Controls.Add(this.lYear);
            this.Controls.Add(this.lMonth);
            this.Controls.Add(this.cboMonth);
            this.Controls.Add(this.tbTtM);
            this.Controls.Add(this.lTtM);
            this.Controls.Add(this.tbCrossRfR);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lPutCall);
            this.Controls.Add(this.cboType);
            this.Controls.Add(this.lExerciseType);
            this.Controls.Add(this.lRfR);
            this.Controls.Add(this.tbBRfR);
            this.Controls.Add(this.lVol);
            this.Controls.Add(this.lUnderlying);
            this.Controls.Add(this.lStrike);
            this.Controls.Add(this.cboExerciseType);
            this.Controls.Add(this.cboYear);
            this.Controls.Add(this.tbSpot);
            this.Controls.Add(this.tbVolatility);
            this.Controls.Add(this.tbStrike);
            this.Name = "FXOPricer";
            this.Text = "FXOPricer";
            this.Load += new System.EventHandler(this.Pricer_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbStrike;
        private System.Windows.Forms.TextBox tbVolatility;
        private System.Windows.Forms.TextBox tbSpot;
        private System.Windows.Forms.ComboBox cboYear;
        private System.Windows.Forms.ComboBox cboExerciseType;
        private System.Windows.Forms.Label lStrike;
        private System.Windows.Forms.Label lUnderlying;
        private System.Windows.Forms.Label lVol;
        private System.Windows.Forms.TextBox tbBRfR;
        private System.Windows.Forms.Label lRfR;
        private System.Windows.Forms.Label lExerciseType;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label lPutCall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbCrossRfR;
        private System.Windows.Forms.Label lTtM;
        private System.Windows.Forms.TextBox tbTtM;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.Label lMonth;
        private System.Windows.Forms.Label lYear;
        private System.Windows.Forms.Label lDay;
        private System.Windows.Forms.Button btnPrice;
        private System.Windows.Forms.TextBox tboPrice;
        private System.Windows.Forms.Label lPrice;
        private System.Windows.Forms.ComboBox cboValuationMethod;
        private System.Windows.Forms.Label lPriceMethod;
        private System.Windows.Forms.ComboBox cboWeekday;
        private System.Windows.Forms.TextBox tbVega;
        private System.Windows.Forms.TextBox tbDelta;
        private System.Windows.Forms.TextBox tbGamma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lVega;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbRho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTheta;
        private System.Windows.Forms.Label label6;
    }
}

