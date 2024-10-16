using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace _8EkimFormOdevi1
{
    public partial class Form1 : Form
    {
        int randomNum;
        int counter = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            randomNum = random.Next(0,100)+1;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            for(; ; )
            {
                if (int.TryParse(tahminKutusuTextBox.Text , out int guess))
                

            if ( guess == randomNum)
            {
                MessageBox.Show("Correct guess", "RESULT");
                break;
            }
            else
            {
                if (guess > randomNum)
                        {
                            MessageBox.Show("Enter less value");
                        }
                else
                        {
                            MessageBox.Show("Enter high value");
                        }
                        counter++;
                MessageBox.Show($"You have {5-counter} chacne", "RESULT");
                tahminKutusuTextBox.Clear();
                if (counter == 5)
                    {
                            MessageBox.Show($"You lost the game . The correct number is {randomNum}", "RESULT");
                            this.Close();
                            break;
                    }
                    return;
                
            }
            }
        }

        private void tahminKutusuTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
