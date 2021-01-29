
namespace WindowsFormsApp2
{
    partial class Form1
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
            this.chislo1 = new System.Windows.Forms.Label();
            this.chislo2 = new System.Windows.Forms.Label();
            this.plus = new System.Windows.Forms.Label();
            this.etoravno = new System.Windows.Forms.Label();
            this.summa = new System.Windows.Forms.Label();
            this.simpletext = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Label();
            this.plus1 = new System.Windows.Forms.Label();
            this.minus = new System.Windows.Forms.Label();
            this.ymnoj = new System.Windows.Forms.Label();
            this.randomchik = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chislo1
            // 
            this.chislo1.AutoSize = true;
            this.chislo1.BackColor = System.Drawing.Color.Transparent;
            this.chislo1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chislo1.Location = new System.Drawing.Point(74, 127);
            this.chislo1.Name = "chislo1";
            this.chislo1.Size = new System.Drawing.Size(52, 23);
            this.chislo1.TabIndex = 0;
            this.chislo1.Text = "290";
            this.chislo1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // chislo2
            // 
            this.chislo2.AutoSize = true;
            this.chislo2.BackColor = System.Drawing.Color.Transparent;
            this.chislo2.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chislo2.Location = new System.Drawing.Point(182, 127);
            this.chislo2.Name = "chislo2";
            this.chislo2.Size = new System.Drawing.Size(52, 23);
            this.chislo2.TabIndex = 0;
            this.chislo2.Text = "290";
            this.chislo2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // plus
            // 
            this.plus.AutoSize = true;
            this.plus.BackColor = System.Drawing.Color.Transparent;
            this.plus.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus.Location = new System.Drawing.Point(141, 127);
            this.plus.Name = "plus";
            this.plus.Size = new System.Drawing.Size(26, 23);
            this.plus.TabIndex = 0;
            this.plus.Text = "+";
            this.plus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // etoravno
            // 
            this.etoravno.AutoSize = true;
            this.etoravno.BackColor = System.Drawing.Color.Transparent;
            this.etoravno.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.etoravno.Location = new System.Drawing.Point(250, 127);
            this.etoravno.Name = "etoravno";
            this.etoravno.Size = new System.Drawing.Size(26, 23);
            this.etoravno.TabIndex = 0;
            this.etoravno.Text = "=";
            this.etoravno.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.etoravno.Click += new System.EventHandler(this.etoravno_Click);
            // 
            // summa
            // 
            this.summa.AutoSize = true;
            this.summa.BackColor = System.Drawing.Color.Transparent;
            this.summa.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.summa.Location = new System.Drawing.Point(282, 127);
            this.summa.Name = "summa";
            this.summa.Size = new System.Drawing.Size(0, 23);
            this.summa.TabIndex = 0;
            this.summa.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // simpletext
            // 
            this.simpletext.AutoSize = true;
            this.simpletext.BackColor = System.Drawing.Color.Transparent;
            this.simpletext.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.simpletext.Location = new System.Drawing.Point(62, 62);
            this.simpletext.Name = "simpletext";
            this.simpletext.Size = new System.Drawing.Size(220, 23);
            this.simpletext.TabIndex = 0;
            this.simpletext.Text = "Нажми на равно :)";
            this.simpletext.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Reset
            // 
            this.Reset.AutoSize = true;
            this.Reset.BackColor = System.Drawing.Color.Transparent;
            this.Reset.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Reset.Location = new System.Drawing.Point(221, 170);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(78, 25);
            this.Reset.TabIndex = 0;
            this.Reset.Text = "Reset";
            this.Reset.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // plus1
            // 
            this.plus1.AutoSize = true;
            this.plus1.BackColor = System.Drawing.Color.Transparent;
            this.plus1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.plus1.Location = new System.Drawing.Point(419, 88);
            this.plus1.Name = "plus1";
            this.plus1.Size = new System.Drawing.Size(26, 23);
            this.plus1.TabIndex = 0;
            this.plus1.Text = "+";
            this.plus1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.plus1.Click += new System.EventHandler(this.plus1_Click);
            // 
            // minus
            // 
            this.minus.AutoSize = true;
            this.minus.BackColor = System.Drawing.Color.Transparent;
            this.minus.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minus.Location = new System.Drawing.Point(424, 127);
            this.minus.Name = "minus";
            this.minus.Size = new System.Drawing.Size(19, 23);
            this.minus.TabIndex = 0;
            this.minus.Text = "-";
            this.minus.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.minus.Click += new System.EventHandler(this.minus_Click);
            // 
            // ymnoj
            // 
            this.ymnoj.AutoSize = true;
            this.ymnoj.BackColor = System.Drawing.Color.Transparent;
            this.ymnoj.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ymnoj.Location = new System.Drawing.Point(424, 160);
            this.ymnoj.Name = "ymnoj";
            this.ymnoj.Size = new System.Drawing.Size(24, 23);
            this.ymnoj.TabIndex = 0;
            this.ymnoj.Text = "*";
            this.ymnoj.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ymnoj.Click += new System.EventHandler(this.ymnoj_Click);
            // 
            // randomchik
            // 
            this.randomchik.AutoSize = true;
            this.randomchik.Font = new System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.randomchik.Location = new System.Drawing.Point(48, 170);
            this.randomchik.Name = "randomchik";
            this.randomchik.Size = new System.Drawing.Size(108, 25);
            this.randomchik.TabIndex = 1;
            this.randomchik.Text = "Random";
            this.randomchik.Click += new System.EventHandler(this.randomchik_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 275);
            this.Controls.Add(this.randomchik);
            this.Controls.Add(this.summa);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.plus1);
            this.Controls.Add(this.simpletext);
            this.Controls.Add(this.minus);
            this.Controls.Add(this.ymnoj);
            this.Controls.Add(this.chislo2);
            this.Controls.Add(this.etoravno);
            this.Controls.Add(this.plus);
            this.Controls.Add(this.chislo1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label chislo1;
        private System.Windows.Forms.Label chislo2;
        private System.Windows.Forms.Label plus;
        private System.Windows.Forms.Label etoravno;
        private System.Windows.Forms.Label summa;
        private System.Windows.Forms.Label simpletext;
        private System.Windows.Forms.Label Reset;
        private System.Windows.Forms.Label plus1;
        private System.Windows.Forms.Label minus;
        private System.Windows.Forms.Label ymnoj;
        private System.Windows.Forms.Label randomchik;
    }
}

