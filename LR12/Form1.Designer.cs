﻿namespace LR12
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
            this.textBoxH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxF = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxH
            // 
            this.textBoxH.Location = new System.Drawing.Point(9, 48);
            this.textBoxH.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxH.Name = "textBoxH";
            this.textBoxH.ReadOnly = true;
            this.textBoxH.Size = new System.Drawing.Size(98, 20);
            this.textBoxH.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "значение e_2";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxF
            // 
            this.textBoxF.Location = new System.Drawing.Point(159, 48);
            this.textBoxF.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxF.Name = "textBoxF";
            this.textBoxF.Size = new System.Drawing.Size(98, 20);
            this.textBoxF.TabIndex = 5;
            this.textBoxF.TextChanged += new System.EventHandler(this.textBoxF_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(157, 32);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(161, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "значение t";
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(9, 98);
            this.textBoxD.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.ReadOnly = true;
            this.textBoxD.Size = new System.Drawing.Size(98, 20);
            this.textBoxD.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 82);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "значение arg_3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 366);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxH);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove_1);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxF;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.Label label7;
    }
}

