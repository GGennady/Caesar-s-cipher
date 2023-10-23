using System.Text;

namespace Lab3_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputTextBox_TextChanged(object sender, EventArgs e)
        {
            int shift = 3; 
            string inputText = inputTextBox.Text;
            string outputText = Caesar(inputText, shift);
            outputTextBox.Text = outputText;
        }

        private string Caesar(string input, int shift)
        {
            StringBuilder result = new StringBuilder();

            foreach (char c in input)
            {
                char move;
                if (char.IsUpper(c))
                {
                    move = 'A';
                }
                else
                {
                    move = 'a';
                }

                if (char.IsLetter(c))
                {
                    result.Append((char)(move + (c - move + shift) % 26));
                }
                else
                {
                    result.Append(c);
                }
            }

            return result.ToString();
        }
    }
}