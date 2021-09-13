using ExchangeCalculator.Handler;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace ExchangeCalculator
{
    public partial class ExchangeCalculator : Form
    {
        private decimal Value { get; set; }
        private object Type { get; set; }
        private decimal Result { get; set; }

        public ExchangeCalculator()
        {
            InitializeComponent();
        }

        private void TextBoxValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            char dot = ',';
            //char[] pontucations = { '.', '!', '#', '"', '#', '%', '$', '&', '(', ')', '*', '-', '/', ':', ';', '?', '@', '[', ']', '_', '{', '}' };
            if (char.IsLetter(e.KeyChar) || char.IsSymbol(e.KeyChar) || char.IsWhiteSpace(e.KeyChar) || double.IsNegativeInfinity(e.KeyChar) || char.IsPunctuation(e.KeyChar) && e.KeyChar != ',' || e.KeyChar == ',' && dot > 2)
            {
                e.Handled = true;
            }
        }

        private void TextBoxValue_TextChanged(object sender, EventArgs e)
        {
            try
            {
                Value = decimal.Parse(TextBoxValue.Text);
            }
            catch (FormatException exception)
            {
                TextBoxResult.Text = $@"Some error has occurred! Error: {exception.Message}";
                return;
            }
            if (Value <= 0)
            {
                TextBoxResult.Text = @"Please input a value!";
                return;
            }
        }

        private void ComboBoxType_SelectedIndexChanged(object sender, EventArgs e)
        {
            Type = ComboBoxType.SelectedItem;

            switch (Type)
            {
                case 0:
                    Result = Value * decimal.Parse(ExchangeHandler.GetExchangeRate("USD").Result);
                    break;
                case 1:
                    Result = Value * decimal.Parse(ExchangeHandler.GetExchangeRate("EUR").Result);
                    break;
            }

            if (ComboBoxType.SelectedItem == null)
            {
                TextBoxResult.Text = @"Please select a option of type!";
                return;
            }
        }

        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            TextBoxResult.Text = $@"{Value.ToString(CultureInfo.CurrentCulture)} in {Type} is: {Result:C}";
        }
    }
}
