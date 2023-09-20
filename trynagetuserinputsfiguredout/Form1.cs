using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace trynagetuserinputsfiguredout
{
    public partial class form1 : Form
    {
       
        string Input = string.Empty;
        string Difficulty = string.Empty;
        public form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

            
            Input = heroName.Text;
            
           

        }

        private void easyButton_Click(object sender, EventArgs e)
        {
            mediumButton.BackColor = Color.Black;
            easyButton.BackColor = Color.Green;
            hardButton.BackColor = Color.Black;
            Difficulty = "easy";
        }

        private void mediumButton_Click(object sender, EventArgs e)
        {
            

            mediumButton.BackColor = Color.Orange;
            easyButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Black;
            Difficulty = "medium";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mediumButton.BackColor = Color.Black;
            easyButton.BackColor = Color.Black;
            hardButton.BackColor = Color.Red;
            Difficulty = "hard";
        }

        private void hardButton_Load(object sender, EventArgs e)
        {

        }

        private void beginButton_Click(object sender, EventArgs e)
        {
            if(Input == string.Empty)
            {
                outputLabel.Text = $"Please choose name.";
            }
           else if (Difficulty == string.Empty)
            { outputLabel.Text = $"Please choose difficulty."; }
            else
            {
                outputLabel.Text = $"Hello, {Input}. You have chosen {Difficulty} mode.";
            }
        }
    }
}