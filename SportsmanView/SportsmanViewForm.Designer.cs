namespace SportsmanView
{
    partial class SportsmanViewForm
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
            this.sportsmenDGV = new System.Windows.Forms.DataGridView();
            this.showEverybodyBtn = new System.Windows.Forms.Button();
            this.sortByNameBtn = new System.Windows.Forms.Button();
            this.selectByNumberOfWinsBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.winsNUD = new System.Windows.Forms.NumericUpDown();
            this.printToFileBtn = new System.Windows.Forms.Button();
            this.SportsmanName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Age = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BestResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfWins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberOfInternationalWins = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.sportsmenDGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.winsNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // sportsmenDGV
            // 
            this.sportsmenDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.sportsmenDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SportsmanName,
            this.Age,
            this.BestResult,
            this.NumberOfWins,
            this.NumberOfInternationalWins});
            this.sportsmenDGV.Location = new System.Drawing.Point(326, 35);
            this.sportsmenDGV.Name = "sportsmenDGV";
            this.sportsmenDGV.RowHeadersWidth = 62;
            this.sportsmenDGV.RowTemplate.Height = 28;
            this.sportsmenDGV.Size = new System.Drawing.Size(440, 435);
            this.sportsmenDGV.TabIndex = 0;
            // 
            // showEverybodyBtn
            // 
            this.showEverybodyBtn.Location = new System.Drawing.Point(22, 35);
            this.showEverybodyBtn.Name = "showEverybodyBtn";
            this.showEverybodyBtn.Size = new System.Drawing.Size(216, 40);
            this.showEverybodyBtn.TabIndex = 1;
            this.showEverybodyBtn.Text = "Вывод всех";
            this.showEverybodyBtn.UseVisualStyleBackColor = true;
            this.showEverybodyBtn.Click += new System.EventHandler(this.showEverybodyBtn_Click);
            // 
            // sortByNameBtn
            // 
            this.sortByNameBtn.Location = new System.Drawing.Point(22, 96);
            this.sortByNameBtn.Name = "sortByNameBtn";
            this.sortByNameBtn.Size = new System.Drawing.Size(216, 40);
            this.sortByNameBtn.TabIndex = 2;
            this.sortByNameBtn.Text = "Сортировка по имени";
            this.sortByNameBtn.UseVisualStyleBackColor = true;
            this.sortByNameBtn.Click += new System.EventHandler(this.sortByNameBtn_Click);
            // 
            // selectByNumberOfWinsBtn
            // 
            this.selectByNumberOfWinsBtn.Location = new System.Drawing.Point(22, 205);
            this.selectByNumberOfWinsBtn.Name = "selectByNumberOfWinsBtn";
            this.selectByNumberOfWinsBtn.Size = new System.Drawing.Size(216, 39);
            this.selectByNumberOfWinsBtn.TabIndex = 3;
            this.selectByNumberOfWinsBtn.Text = "Отбор по победам";
            this.selectByNumberOfWinsBtn.UseVisualStyleBackColor = true;
            this.selectByNumberOfWinsBtn.Click += new System.EventHandler(this.selectByNumberOfWinsBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Победы:";
            // 
            // winsNUD
            // 
            this.winsNUD.Location = new System.Drawing.Point(118, 158);
            this.winsNUD.Name = "winsNUD";
            this.winsNUD.Size = new System.Drawing.Size(120, 26);
            this.winsNUD.TabIndex = 5;
            // 
            // printToFileBtn
            // 
            this.printToFileBtn.Location = new System.Drawing.Point(22, 276);
            this.printToFileBtn.Name = "printToFileBtn";
            this.printToFileBtn.Size = new System.Drawing.Size(216, 39);
            this.printToFileBtn.TabIndex = 6;
            this.printToFileBtn.Text = "Вывод в файл";
            this.printToFileBtn.UseVisualStyleBackColor = true;
            this.printToFileBtn.Click += new System.EventHandler(this.printToFileBtn_Click);
            // 
            // SportsmanName
            // 
            this.SportsmanName.HeaderText = "Имя";
            this.SportsmanName.MinimumWidth = 8;
            this.SportsmanName.Name = "SportsmanName";
            this.SportsmanName.Width = 150;
            // 
            // Age
            // 
            this.Age.HeaderText = "Возраст";
            this.Age.MinimumWidth = 8;
            this.Age.Name = "Age";
            this.Age.Width = 150;
            // 
            // BestResult
            // 
            this.BestResult.HeaderText = "Лучший результат";
            this.BestResult.MinimumWidth = 8;
            this.BestResult.Name = "BestResult";
            this.BestResult.Width = 150;
            // 
            // NumberOfWins
            // 
            this.NumberOfWins.HeaderText = "Количество побед";
            this.NumberOfWins.MinimumWidth = 8;
            this.NumberOfWins.Name = "NumberOfWins";
            this.NumberOfWins.Width = 150;
            // 
            // NumberOfInternationalWins
            // 
            this.NumberOfInternationalWins.HeaderText = "Количество побед на международных соревнованиях";
            this.NumberOfInternationalWins.MinimumWidth = 8;
            this.NumberOfInternationalWins.Name = "NumberOfInternationalWins";
            this.NumberOfInternationalWins.Width = 150;
            // 
            // SportsmanViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 497);
            this.Controls.Add(this.printToFileBtn);
            this.Controls.Add(this.winsNUD);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.selectByNumberOfWinsBtn);
            this.Controls.Add(this.sortByNameBtn);
            this.Controls.Add(this.showEverybodyBtn);
            this.Controls.Add(this.sportsmenDGV);
            this.Name = "SportsmanViewForm";
            this.Text = "Просмотр Спортсменов";
            ((System.ComponentModel.ISupportInitialize)(this.sportsmenDGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.winsNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView sportsmenDGV;
        private System.Windows.Forms.Button showEverybodyBtn;
        private System.Windows.Forms.Button sortByNameBtn;
        private System.Windows.Forms.Button selectByNumberOfWinsBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown winsNUD;
        private System.Windows.Forms.Button printToFileBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn SportsmanName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Age;
        private System.Windows.Forms.DataGridViewTextBoxColumn BestResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfWins;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberOfInternationalWins;
    }
}

