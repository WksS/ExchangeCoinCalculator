using Newtonsoft.Json.Linq;
using System;
using System.Net.Http;
using System.Threading.Tasks;
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
            var result = 0.0m;
            var value = 0.0m;

            value = decimal.Parse(TextBoxValue.Text);
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
