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
            this.panelTitle = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.valueToConvert = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.labelEnterValue = new System.Windows.Forms.Label();
            this.textBoxResult = new System.Windows.Forms.TextBox();
            this.labelTo = new System.Windows.Forms.Label();
            this.comboBoxType = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.panelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.panel1.Controls.Add(this.panelTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(233, 491);
            this.panel1.TabIndex = 0;
            // 
            // panelTitle
            // 
            this.panelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.panelTitle.Controls.Add(this.Title);
            this.panelTitle.Location = new System.Drawing.Point(0, 0);
            this.panelTitle.Margin = new System.Windows.Forms.Padding(5);
            this.panelTitle.Name = "panelTitle";
            this.panelTitle.Size = new System.Drawing.Size(233, 123);
            this.panelTitle.TabIndex = 0;
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Title.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.Title.ForeColor = System.Drawing.SystemColors.Control;
            this.Title.Location = new System.Drawing.Point(14, 9);
            this.Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(203, 97);
            this.Title.TabIndex = 0;
            this.Title.Text = "Exchange Rate \r\nCalculator";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // valueToConvert
            // 
            this.valueToConvert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.valueToConvert.Font = new System.Drawing.Font("Century Gothic", 22F);
            this.valueToConvert.ForeColor = System.Drawing.SystemColors.Control;
            this.valueToConvert.Location = new System.Drawing.Point(454, 79);
            this.valueToConvert.Multiline = true;
            this.valueToConvert.Name = "valueToConvert";
            this.valueToConvert.Size = new System.Drawing.Size(147, 44);
            this.valueToConvert.TabIndex = 1;
            this.valueToConvert.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.btnCalculate.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCalculate.Location = new System.Drawing.Point(436, 326);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(179, 70);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = false;
            // 
            // labelEnterValue
            // 
            this.labelEnterValue.AutoSize = true;
            this.labelEnterValue.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.labelEnterValue.ForeColor = System.Drawing.SystemColors.Control;
            this.labelEnterValue.Location = new System.Drawing.Point(375, 26);
            this.labelEnterValue.Name = "labelEnterValue";
            this.labelEnterValue.Size = new System.Drawing.Size(334, 33);
            this.labelEnterValue.TabIndex = 4;
            this.labelEnterValue.Text = "Enter a value to convert";
            // 
            // textBoxResult
            // 
            this.textBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.textBoxResult.Location = new System.Drawing.Point(268, 452);
            this.textBoxResult.Name = "textBoxResult";
            this.textBoxResult.Size = new System.Drawing.Size(584, 27);
            this.textBoxResult.TabIndex = 5;
            // 
            // labelTo
            // 
            this.labelTo.AutoSize = true;
            this.labelTo.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.labelTo.ForeColor = System.Drawing.SystemColors.Control;
            this.labelTo.Location = new System.Drawing.Point(505, 146);
            this.labelTo.Name = "labelTo";
            this.labelTo.Size = new System.Drawing.Size(51, 33);
            this.labelTo.TabIndex = 6;
            this.labelTo.Text = "To:";
            // 
            // comboBoxType
            // 
            this.comboBoxType.AutoCompleteCustomSource.AddRange(new string[] {
            "Dolar",
            "Euro"});
            this.comboBoxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.comboBoxType.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.comboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxType.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.comboBoxType.ForeColor = System.Drawing.SystemColors.Control;
            this.comboBoxType.FormattingEnabled = true;
            this.comboBoxType.Items.AddRange(new object[] {
            "Dolar",
            "Euro"});
            this.comboBoxType.Location = new System.Drawing.Point(454, 200);
            this.comboBoxType.Name = "comboBoxType";
            this.comboBoxType.Size = new System.Drawing.Size(147, 38);
            this.comboBoxType.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "oi",
            "fudido"});
            this.comboBox1.Location = new System.Drawing.Point(708, 156);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(96, 29);
            this.comboBox1.TabIndex = 8;
            // 
            // ExchangeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(864, 491);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.comboBoxType);
            this.Controls.Add(this.labelTo);
            this.Controls.Add(this.textBoxResult);
            this.Controls.Add(this.labelEnterValue);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.valueToConvert);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ExchangeCalculator";
            this.Text = "Exchange Calculator";
            this.panel1.ResumeLayout(false);
            this.panelTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelTitle;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox valueToConvert;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Label labelEnterValue;
        private System.Windows.Forms.TextBox textBoxResult;
        private System.Windows.Forms.Label labelTo;
        private System.Windows.Forms.ComboBox comboBoxType;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
