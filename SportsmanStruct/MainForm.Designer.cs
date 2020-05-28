namespace SportsmanStruct
{
    partial class MainForm
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
            this.nameTB = new System.Windows.Forms.TextBox();
            this.sportsmenLB = new System.Windows.Forms.ListBox();
            this.ageNUD = new System.Windows.Forms.NumericUpDown();
            this.winsNUD = new System.Windows.Forms.NumericUpDown();
            this.internationalWinsNUD = new System.Windows.Forms.NumericUpDown();
            this.bestResultNUD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.inputBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ageNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.internationalWinsNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestResultNUD)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(176, 25);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(120, 26);
            this.nameTB.TabIndex = 0;
            // 
            // sportsmenLB
            // 
            this.sportsmenLB.FormattingEnabled = true;
            this.sportsmenLB.HorizontalScrollbar = true;
            this.sportsmenLB.ItemHeight = 20;
            this.sportsmenLB.Location = new System.Drawing.Point(12, 292);
            this.sportsmenLB.Name = "sportsmenLB";
            this.sportsmenLB.Size = new System.Drawing.Size(602, 264);
            this.sportsmenLB.TabIndex = 1;
            // 
            // ageNUD
            // 
            this.ageNUD.Location = new System.Drawing.Point(176, 57);
            this.ageNUD.Name = "ageNUD";
            this.ageNUD.Size = new System.Drawing.Size(120, 26);
            this.ageNUD.TabIndex = 2;
            // 
            // winsNUD
            // 
            this.winsNUD.Location = new System.Drawing.Point(176, 89);
            this.winsNUD.Name = "winsNUD";
            this.winsNUD.Size = new System.Drawing.Size(120, 26);
            this.winsNUD.TabIndex = 3;
            this.winsNUD.ValueChanged += new System.EventHandler(this.winsNUD_ValueChanged);
            // 
            // internationalWinsNUD
            // 
            this.internationalWinsNUD.Location = new System.Drawing.Point(176, 121);
            this.internationalWinsNUD.Name = "internationalWinsNUD";
            this.internationalWinsNUD.Size = new System.Drawing.Size(120, 26);
            this.internationalWinsNUD.TabIndex = 4;
            // 
            // bestResultNUD
            // 
            this.bestResultNUD.DecimalPlaces = 2;
            this.bestResultNUD.Location = new System.Drawing.Point(176, 191);
            this.bestResultNUD.Name = "bestResultNUD";
            this.bestResultNUD.Size = new System.Drawing.Size(76, 26);
            this.bestResultNUD.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(126, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Имя:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Возраст:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Лучший результат:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 60);
            this.label4.TabIndex = 9;
            this.label4.Text = "Количество побед \r\nна международных \r\nсоревнованиях:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Количество побед:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nameTB);
            this.groupBox1.Controls.Add(this.ageNUD);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.winsNUD);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.internationalWinsNUD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bestResultNUD);
            this.groupBox1.Location = new System.Drawing.Point(166, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 224);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Спортсмен";
            // 
            // inputBtn
            // 
            this.inputBtn.Location = new System.Drawing.Point(166, 249);
            this.inputBtn.Name = "inputBtn";
            this.inputBtn.Size = new System.Drawing.Size(321, 37);
            this.inputBtn.TabIndex = 13;
            this.inputBtn.Text = "Ввести";
            this.inputBtn.UseVisualStyleBackColor = true;
            this.inputBtn.Click += new System.EventHandler(this.inputBtn_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(254, 193);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 20);
            this.label6.TabIndex = 11;
            this.label6.Text = "секунд";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 579);
            this.Controls.Add(this.inputBtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.sportsmenLB);
            this.Name = "MainForm";
            this.Text = "Регистрация Спортсменов";
            ((System.ComponentModel.ISupportInitialize)(this.ageNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.internationalWinsNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bestResultNUD)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.ListBox sportsmenLB;
        private System.Windows.Forms.NumericUpDown ageNUD;
        private System.Windows.Forms.NumericUpDown winsNUD;
        private System.Windows.Forms.NumericUpDown internationalWinsNUD;
        private System.Windows.Forms.NumericUpDown bestResultNUD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button inputBtn;
        private System.Windows.Forms.Label label6;
    }
}

