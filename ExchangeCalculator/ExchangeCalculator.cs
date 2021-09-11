using ExchangeCalculator.Handler;
using System;
using System.Windows.Forms;

namespace ExchangeCalculator
{
    public partial class ExchangeCalculator : Form
    {
        public ExchangeCalculator()
        {
            InitializeComponent();
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            decimal result = 0.0m;
            decimal value = decimal.Parse(TextBoxValue.Text);
            var type = ComboBoxType.SelectedItem;

            if (value == null || value <= 0)
            {
                TextBoxResult.Text = "Please input a value!";
                return;
            }

            if (ComboBoxType.SelectedItem == null)
            {
                TextBoxResult.Text = "Please select a option of type!";
                return;
            }

            switch (type)
            {
                case 0:
                    result = value * decimal.Parse(ExchangeHandler.GetExchangeRate("USD").Result);
                    break;
                case 1:
                    result = value * decimal.Parse(ExchangeHandler.GetExchangeRate("EUR").Result);
                    break;
            }
            TextBoxResult.Text = $"{value} in {type} is: {result.ToString("C")}";
        }

        private void TextBoxValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            //char[] pontucations = { '.', '!', '#', '"', '#', '%', '$', '&', '(', ')', '*', '-', '/', ':', ';', '?', '@', '[', ']', '_', '{', '}' };
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || double.IsNegativeInfinity(e.KeyChar) || char.IsPunctuation(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true;
            }
        }
    }
}
