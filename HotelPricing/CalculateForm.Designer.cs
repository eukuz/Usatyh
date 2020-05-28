namespace HotelPricing
{
    partial class CalculateForm
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
            this.roomTypesLB = new System.Windows.Forms.ListBox();
            this.residenceWeeksNUD = new System.Windows.Forms.NumericUpDown();
            this.complementaryServicesGB = new System.Windows.Forms.GroupBox();
            this.swimmingPoolCB = new System.Windows.Forms.CheckBox();
            this.foodGB = new System.Windows.Forms.GroupBox();
            this.threeTimesRB = new System.Windows.Forms.RadioButton();
            this.twoTimesRB = new System.Windows.Forms.RadioButton();
            this.complementaryFoodCB = new System.Windows.Forms.CheckBox();
            this.allInclusiveCB = new System.Windows.Forms.CheckBox();
            this.roomTypesLbl = new System.Windows.Forms.Label();
            this.residenceWeeksLbl = new System.Windows.Forms.Label();
            this.finalPriceLbl = new System.Windows.Forms.Label();
            this.calculateBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.residenceWeeksNUD)).BeginInit();
            this.complementaryServicesGB.SuspendLayout();
            this.foodGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // roomTypesLB
            // 
            this.roomTypesLB.FormattingEnabled = true;
            this.roomTypesLB.ItemHeight = 20;
            this.roomTypesLB.Location = new System.Drawing.Point(47, 65);
            this.roomTypesLB.Name = "roomTypesLB";
            this.roomTypesLB.Size = new System.Drawing.Size(268, 204);
            this.roomTypesLB.TabIndex = 0;
            // 
            // residenceWeeksNUD
            // 
            this.residenceWeeksNUD.Location = new System.Drawing.Point(218, 283);
            this.residenceWeeksNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.residenceWeeksNUD.Name = "residenceWeeksNUD";
            this.residenceWeeksNUD.Size = new System.Drawing.Size(97, 26);
            this.residenceWeeksNUD.TabIndex = 1;
            this.residenceWeeksNUD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // complementaryServicesGB
            // 
            this.complementaryServicesGB.Controls.Add(this.swimmingPoolCB);
            this.complementaryServicesGB.Controls.Add(this.foodGB);
            this.complementaryServicesGB.Controls.Add(this.complementaryFoodCB);
            this.complementaryServicesGB.Controls.Add(this.allInclusiveCB);
            this.complementaryServicesGB.Location = new System.Drawing.Point(336, 45);
            this.complementaryServicesGB.Name = "complementaryServicesGB";
            this.complementaryServicesGB.Size = new System.Drawing.Size(224, 224);
            this.complementaryServicesGB.TabIndex = 2;
            this.complementaryServicesGB.TabStop = false;
            this.complementaryServicesGB.Text = "Доп. Услуги";
            // 
            // swimmingPoolCB
            // 
            this.swimmingPoolCB.AutoSize = true;
            this.swimmingPoolCB.Location = new System.Drawing.Point(16, 172);
            this.swimmingPoolCB.Name = "swimmingPoolCB";
            this.swimmingPoolCB.Size = new System.Drawing.Size(98, 24);
            this.swimmingPoolCB.TabIndex = 4;
            this.swimmingPoolCB.Text = "Бассейн";
            this.swimmingPoolCB.UseVisualStyleBackColor = true;
            // 
            // foodGB
            // 
            this.foodGB.Controls.Add(this.threeTimesRB);
            this.foodGB.Controls.Add(this.twoTimesRB);
            this.foodGB.Enabled = false;
            this.foodGB.Location = new System.Drawing.Point(43, 66);
            this.foodGB.Name = "foodGB";
            this.foodGB.Size = new System.Drawing.Size(154, 100);
            this.foodGB.TabIndex = 3;
            this.foodGB.TabStop = false;
            this.foodGB.Text = "Питание";
            // 
            // threeTimesRB
            // 
            this.threeTimesRB.AutoSize = true;
            this.threeTimesRB.Location = new System.Drawing.Point(6, 52);
            this.threeTimesRB.Name = "threeTimesRB";
            this.threeTimesRB.Size = new System.Drawing.Size(137, 24);
            this.threeTimesRB.TabIndex = 1;
            this.threeTimesRB.TabStop = true;
            this.threeTimesRB.Text = "3 раза в день";
            this.threeTimesRB.UseVisualStyleBackColor = true;
            // 
            // twoTimesRB
            // 
            this.twoTimesRB.AutoSize = true;
            this.twoTimesRB.Location = new System.Drawing.Point(6, 25);
            this.twoTimesRB.Name = "twoTimesRB";
            this.twoTimesRB.Size = new System.Drawing.Size(137, 24);
            this.twoTimesRB.TabIndex = 0;
            this.twoTimesRB.TabStop = true;
            this.twoTimesRB.Text = "2 раза в день";
            this.twoTimesRB.UseVisualStyleBackColor = true;
            // 
            // complementaryFoodCB
            // 
            this.complementaryFoodCB.AutoSize = true;
            this.complementaryFoodCB.Location = new System.Drawing.Point(16, 66);
            this.complementaryFoodCB.Name = "complementaryFoodCB";
            this.complementaryFoodCB.Size = new System.Drawing.Size(22, 21);
            this.complementaryFoodCB.TabIndex = 2;
            this.complementaryFoodCB.UseVisualStyleBackColor = true;
            this.complementaryFoodCB.CheckedChanged += new System.EventHandler(this.complementaryFoodCB_CheckedChanged);
            // 
            // allInclusiveCB
            // 
            this.allInclusiveCB.AutoSize = true;
            this.allInclusiveCB.Location = new System.Drawing.Point(16, 36);
            this.allInclusiveCB.Name = "allInclusiveCB";
            this.allInclusiveCB.Size = new System.Drawing.Size(142, 24);
            this.allInclusiveCB.TabIndex = 0;
            this.allInclusiveCB.Text = "Все включено";
            this.allInclusiveCB.UseVisualStyleBackColor = true;
            this.allInclusiveCB.CheckedChanged += new System.EventHandler(this.allInclusiveCB_CheckedChanged);
            // 
            // roomTypesLbl
            // 
            this.roomTypesLbl.AutoSize = true;
            this.roomTypesLbl.Location = new System.Drawing.Point(43, 42);
            this.roomTypesLbl.Name = "roomTypesLbl";
            this.roomTypesLbl.Size = new System.Drawing.Size(110, 20);
            this.roomTypesLbl.TabIndex = 3;
            this.roomTypesLbl.Text = "Тип комнаты:";
            // 
            // residenceWeeksLbl
            // 
            this.residenceWeeksLbl.AutoSize = true;
            this.residenceWeeksLbl.Location = new System.Drawing.Point(43, 285);
            this.residenceWeeksLbl.Name = "residenceWeeksLbl";
            this.residenceWeeksLbl.Size = new System.Drawing.Size(169, 20);
            this.residenceWeeksLbl.TabIndex = 4;
            this.residenceWeeksLbl.Text = "Проживание недель:";
            // 
            // finalPriceLbl
            // 
            this.finalPriceLbl.AutoSize = true;
            this.finalPriceLbl.Location = new System.Drawing.Point(43, 330);
            this.finalPriceLbl.Name = "finalPriceLbl";
            this.finalPriceLbl.Size = new System.Drawing.Size(207, 20);
            this.finalPriceLbl.TabIndex = 5;
            this.finalPriceLbl.Text = "Итоговая стоимость:  руб.";
            // 
            // calculateBtn
            // 
            this.calculateBtn.Location = new System.Drawing.Point(336, 277);
            this.calculateBtn.Name = "calculateBtn";
            this.calculateBtn.Size = new System.Drawing.Size(224, 37);
            this.calculateBtn.TabIndex = 6;
            this.calculateBtn.Text = "Рассчитать";
            this.calculateBtn.UseVisualStyleBackColor = true;
            this.calculateBtn.Click += new System.EventHandler(this.calculateBtn_Click);
            // 
            // CalculateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 406);
            this.Controls.Add(this.calculateBtn);
            this.Controls.Add(this.finalPriceLbl);
            this.Controls.Add(this.residenceWeeksLbl);
            this.Controls.Add(this.roomTypesLbl);
            this.Controls.Add(this.complementaryServicesGB);
            this.Controls.Add(this.residenceWeeksNUD);
            this.Controls.Add(this.roomTypesLB);
            this.Name = "CalculateForm";
            this.Text = "Рассчитать стоимость проживания";
            ((System.ComponentModel.ISupportInitialize)(this.residenceWeeksNUD)).EndInit();
            this.complementaryServicesGB.ResumeLayout(false);
            this.complementaryServicesGB.PerformLayout();
            this.foodGB.ResumeLayout(false);
            this.foodGB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox roomTypesLB;
        private System.Windows.Forms.NumericUpDown residenceWeeksNUD;
        private System.Windows.Forms.GroupBox complementaryServicesGB;
        private System.Windows.Forms.CheckBox swimmingPoolCB;
        private System.Windows.Forms.GroupBox foodGB;
        private System.Windows.Forms.RadioButton threeTimesRB;
        private System.Windows.Forms.RadioButton twoTimesRB;
        private System.Windows.Forms.CheckBox complementaryFoodCB;
        private System.Windows.Forms.CheckBox allInclusiveCB;
        private System.Windows.Forms.Label roomTypesLbl;
        private System.Windows.Forms.Label residenceWeeksLbl;
        private System.Windows.Forms.Label finalPriceLbl;
        private System.Windows.Forms.Button calculateBtn;
    }
}

