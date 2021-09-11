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
            this.PanelMain = new System.Windows.Forms.Panel();
            this.PictureArrow = new System.Windows.Forms.PictureBox();
            this.PanelTitle = new System.Windows.Forms.Panel();
            this.LabelTitle = new System.Windows.Forms.Label();
            this.TextBoxValue = new System.Windows.Forms.TextBox();
            this.ButtonCalculate = new System.Windows.Forms.Button();
            this.LabelEnterValue = new System.Windows.Forms.Label();
            this.TextBoxResult = new System.Windows.Forms.TextBox();
            this.LabelTo = new System.Windows.Forms.Label();
            this.ComboBoxType = new System.Windows.Forms.ComboBox();
            this.LabelResult = new System.Windows.Forms.Label();
            this.PanelMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureArrow)).BeginInit();
            this.PanelTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(63)))));
            this.PanelMain.Controls.Add(this.PictureArrow);
            this.PanelMain.Controls.Add(this.PanelTitle);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelMain.Location = new System.Drawing.Point(0, 0);
            this.PanelMain.Margin = new System.Windows.Forms.Padding(5);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(233, 491);
            this.PanelMain.TabIndex = 0;
            // 
            // PictureArrow
            // 
            this.PictureArrow.Image = ((System.Drawing.Image)(resources.GetObject("PictureArrow.Image")));
            this.PictureArrow.Location = new System.Drawing.Point(67, 238);
            this.PictureArrow.Name = "PictureArrow";
            this.PictureArrow.Size = new System.Drawing.Size(69, 84);
            this.PictureArrow.TabIndex = 1;
            this.PictureArrow.TabStop = false;
            // 
            // PanelTitle
            // 
            this.PanelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.PanelTitle.Controls.Add(this.LabelTitle);
            this.PanelTitle.Location = new System.Drawing.Point(0, 0);
            this.PanelTitle.Margin = new System.Windows.Forms.Padding(5);
            this.PanelTitle.Name = "PanelTitle";
            this.PanelTitle.Size = new System.Drawing.Size(233, 123);
            this.PanelTitle.TabIndex = 0;
            // 
            // LabelTitle
            // 
            this.LabelTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.LabelTitle.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.LabelTitle.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelTitle.Location = new System.Drawing.Point(14, 9);
            this.LabelTitle.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.LabelTitle.Name = "LabelTitle";
            this.LabelTitle.Size = new System.Drawing.Size(203, 97);
            this.LabelTitle.TabIndex = 0;
            this.LabelTitle.Text = "Exchange Rate \r\nCalculator";
            this.LabelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TextBoxValue
            // 
            this.TextBoxValue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.TextBoxValue.Font = new System.Drawing.Font("Century Gothic", 22F);
            this.TextBoxValue.ForeColor = System.Drawing.SystemColors.Control;
            this.TextBoxValue.Location = new System.Drawing.Point(381, 79);
            this.TextBoxValue.MaxLength = 15;
            this.TextBoxValue.Multiline = true;
            this.TextBoxValue.Name = "TextBoxValue";
            this.TextBoxValue.Size = new System.Drawing.Size(328, 44);
            this.TextBoxValue.TabIndex = 1;
            this.TextBoxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TextBoxValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextBoxValue_KeyPress);
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ButtonCalculate.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCalculate.ForeColor = System.Drawing.SystemColors.Control;
            this.ButtonCalculate.Location = new System.Drawing.Point(447, 295);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(186, 75);
            this.ButtonCalculate.TabIndex = 3;
            this.ButtonCalculate.Text = "Calculate";
            this.ButtonCalculate.UseVisualStyleBackColor = false;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // LabelEnterValue
            // 
            this.LabelEnterValue.AutoSize = true;
            this.LabelEnterValue.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.LabelEnterValue.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelEnterValue.Location = new System.Drawing.Point(375, 26);
            this.LabelEnterValue.Name = "LabelEnterValue";
            this.LabelEnterValue.Size = new System.Drawing.Size(334, 33);
            this.LabelEnterValue.TabIndex = 4;
            this.LabelEnterValue.Text = "Enter a value to convert";
            // 
            // TextBoxResult
            // 
            this.TextBoxResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.TextBoxResult.Enabled = false;
            this.TextBoxResult.Location = new System.Drawing.Point(326, 423);
            this.TextBoxResult.Multiline = true;
            this.TextBoxResult.Name = "TextBoxResult";
            this.TextBoxResult.ReadOnly = true;
            this.TextBoxResult.Size = new System.Drawing.Size(506, 56);
            this.TextBoxResult.TabIndex = 5;
            // 
            // LabelTo
            // 
            this.LabelTo.AutoSize = true;
            this.LabelTo.Font = new System.Drawing.Font("Century Gothic", 20F);
            this.LabelTo.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelTo.Location = new System.Drawing.Point(391, 147);
            this.LabelTo.Name = "LabelTo";
            this.LabelTo.Size = new System.Drawing.Size(294, 33);
            this.LabelTo.TabIndex = 6;
            this.LabelTo.Text = "Select a type of coin:";
            // 
            // ComboBoxType
            // 
            this.ComboBoxType.AutoCompleteCustomSource.AddRange(new string[] {
            "Dolar",
            "Euro"});
            this.ComboBoxType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(54)))), ((int)(((byte)(62)))));
            this.ComboBoxType.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.ComboBoxType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxType.Font = new System.Drawing.Font("Century Gothic", 18F);
            this.ComboBoxType.ForeColor = System.Drawing.SystemColors.Control;
            this.ComboBoxType.FormattingEnabled = true;
            this.ComboBoxType.Items.AddRange(new object[] {
            "Dolar",
            "Euro"});
            this.ComboBoxType.Location = new System.Drawing.Point(381, 200);
            this.ComboBoxType.Name = "ComboBoxType";
            this.ComboBoxType.Size = new System.Drawing.Size(328, 38);
            this.ComboBoxType.TabIndex = 7;
            // 
            // LabelResult
            // 
            this.LabelResult.AutoSize = true;
            this.LabelResult.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelResult.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelResult.Location = new System.Drawing.Point(241, 438);
            this.LabelResult.Name = "LabelResult";
            this.LabelResult.Size = new System.Drawing.Size(86, 28);
            this.LabelResult.TabIndex = 8;
            this.LabelResult.Text = "Result:";
            // 
            // ExchangeCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(864, 491);
            this.Controls.Add(this.LabelResult);
            this.Controls.Add(this.ComboBoxType);
            this.Controls.Add(this.LabelTo);
            this.Controls.Add(this.TextBoxResult);
            this.Controls.Add(this.LabelEnterValue);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.TextBoxValue);
            this.Controls.Add(this.PanelMain);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ExchangeCalculator";
            this.Text = "Exchange Calculator";
            this.PanelMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureArrow)).EndInit();
            this.PanelTitle.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMain;
        private System.Windows.Forms.Panel PanelTitle;
        private System.Windows.Forms.Label LabelTitle;
        private System.Windows.Forms.TextBox TextBoxValue;
        private System.Windows.Forms.Button ButtonCalculate;
        private System.Windows.Forms.Label LabelEnterValue;
        private System.Windows.Forms.TextBox TextBoxResult;
        private System.Windows.Forms.Label LabelTo;
        private System.Windows.Forms.ComboBox ComboBoxType;
        private System.Windows.Forms.PictureBox PictureArrow;
        private System.Windows.Forms.Label LabelResult;
    }
}
