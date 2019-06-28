using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_Lesson9A
{
    public partial class Lesson9Form : Form
    {
        /// <summary>
        /// This is the constructor method
        /// </summary>
        public Lesson9Form()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This is shared event handler for all calculator buttons click event
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculatorButtons_Click(object sender, EventArgs e)
        {
            Button selectedButton = sender as Button;

            try
            {
                int.Parse(selectedButton.Text);
                ResultLabel.Text = selectedButton.Text;
            }
            catch
            {
                ResultLabel.Text = "Not a number";
            }

            //switch (selectedButton.Text)
            //{
            //    case "1":

            //        break;
            //    default:
            //        break;
            //}
        }
    }
}
