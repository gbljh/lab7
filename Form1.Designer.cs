namespace _7
{
    partial class fMain
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
            this.tbX1 = new System.Windows.Forms.TextBox();
            this.tbX2 = new System.Windows.Forms.TextBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbXmax = new System.Windows.Forms.TextBox();
            this.lbX1 = new System.Windows.Forms.Label();
            this.lbX2 = new System.Windows.Forms.Label();
            this.lbY = new System.Windows.Forms.Label();
            this.LbXmax = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbX1
            // 
            this.tbX1.Location = new System.Drawing.Point(271, 64);
            this.tbX1.Name = "tbX1";
            this.tbX1.Size = new System.Drawing.Size(100, 20);
            this.tbX1.TabIndex = 0;
            // 
            // tbX2
            // 
            this.tbX2.Location = new System.Drawing.Point(271, 111);
            this.tbX2.Name = "tbX2";
            this.tbX2.Size = new System.Drawing.Size(100, 20);
            this.tbX2.TabIndex = 1;
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(271, 169);
            this.tbY.Name = "tbY";
            this.tbY.ReadOnly = true;
            this.tbY.Size = new System.Drawing.Size(100, 20);
            this.tbY.TabIndex = 2;
            this.tbY.TabStop = false;
            // 
            // tbXmax
            // 
            this.tbXmax.Location = new System.Drawing.Point(271, 226);
            this.tbXmax.Name = "tbXmax";
            this.tbXmax.ReadOnly = true;
            this.tbXmax.Size = new System.Drawing.Size(100, 20);
            this.tbXmax.TabIndex = 3;
            // 
            // lbX1
            // 
            this.lbX1.AutoSize = true;
            this.lbX1.Location = new System.Drawing.Point(133, 71);
            this.lbX1.Name = "lbX1";
            this.lbX1.Size = new System.Drawing.Size(58, 13);
            this.lbX1.TabIndex = 4;
            this.lbX1.Text = "Змінна X1";
            // 
            // lbX2
            // 
            this.lbX2.AutoSize = true;
            this.lbX2.Location = new System.Drawing.Point(133, 118);
            this.lbX2.Name = "lbX2";
            this.lbX2.Size = new System.Drawing.Size(58, 13);
            this.lbX2.TabIndex = 5;
            this.lbX2.Text = "Змінна X2";
            // 
            // lbY
            // 
            this.lbY.AutoSize = true;
            this.lbY.Location = new System.Drawing.Point(133, 176);
            this.lbY.Name = "lbY";
            this.lbY.Size = new System.Drawing.Size(129, 13);
            this.lbY.TabIndex = 6;
            this.lbY.Text = "Результат розрахунку Y";
            // 
            // LbXmax
            // 
            this.LbXmax.AutoSize = true;
            this.LbXmax.Location = new System.Drawing.Point(133, 233);
            this.LbXmax.Name = "LbXmax";
            this.LbXmax.Size = new System.Drawing.Size(138, 13);
            this.LbXmax.TabIndex = 7;
            this.LbXmax.Text = "Максимальне значення X";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(136, 292);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 8;
            this.btnCount.Text = "Обчислити";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(271, 292);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Очистити";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(397, 292);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 10;
            this.btnExit.Text = "Вихід";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(334, 20);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(60, 13);
            this.label.TabIndex = 11;
            this.label.Text = "Варіант 29";
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.LbXmax);
            this.Controls.Add(this.lbY);
            this.Controls.Add(this.lbX2);
            this.Controls.Add(this.lbX1);
            this.Controls.Add(this.tbXmax);
            this.Controls.Add(this.tbY);
            this.Controls.Add(this.tbX2);
            this.Controls.Add(this.tbX1);
            this.Name = "fMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Лабораторна робота No7";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbX1;
        private System.Windows.Forms.TextBox tbX2;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.TextBox tbXmax;
        private System.Windows.Forms.Label lbX1;
        private System.Windows.Forms.Label lbX2;
        private System.Windows.Forms.Label lbY;
        private System.Windows.Forms.Label LbXmax;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label;
    }
}

