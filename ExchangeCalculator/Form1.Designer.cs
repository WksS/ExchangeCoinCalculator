﻿
namespace ExchangeCalculator
{
    partial class ExchangeCalculator
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExchangeCalculator));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.valueToConvert = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textOfFIrstValue = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(260, 491);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(260, 134);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.label1.Font = new System.Drawing.Font("Century Gothic", 22F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 134);
            this.label1.TabIndex = 0;
            this.label1.Text = "Exchange Rate Calculator";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueToConvert
            // 
            this.valueToConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.valueToConvert.Location = new System.Drawing.Point(452, 65);
            this.valueToConvert.Multiline = true;
            this.valueToConvert.Name = "valueToConvert";
            this.valueToConvert.Size = new System.Drawing.Size(134, 69);
            this.valueToConvert.TabIndex = 1;
            this.valueToConvert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.button1.Location = new System.Drawing.Point(420, 319);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(207, 95);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // textOfFIrstValue
            // 
            this.textOfFIrstValue.AutoSize = true;
            this.textOfFIrstValue.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.textOfFIrstValue.Location = new System.Drawing.Point(380, 21);
            this.textOfFIrstValue.Name = "textOfFIrstValue";
            this.textOfFIrstValue.Size = new System.Drawing.Size(301, 30);
            this.textOfFIrstValue.TabIndex = 4;
            this.textOfFIrstValue.Text = "Enter a value to convert";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.textBox1.Location = new System.Drawing.Point(268, 452);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(584, 27);
            this.textBox1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.label2.Location = new System.Drawing.Point(499, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 30);
            this.label2.TabIndex = 6;
            this.label2.Text = "To:";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 21;
            this.listBox1.Location = new System.Drawing.Point(452, 219);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(150, 25);
            this.listBox1.TabIndex = 7;
            // 
            // ExchangeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(864, 491);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textOfFIrstValue);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.valueToConvert);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ExchangeCalculator";
            this.Text = "Exchange Calculator";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox valueToConvert;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label textOfFIrstValue;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox listBox1;
    }
}

