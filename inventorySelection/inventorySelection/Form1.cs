/*Project: Ch 3 Practice 1
 * Date: October 2022
 * Programmer: Rania Maaraba
 * Description: Create a project that allows user input for inventory that will exput values for total sold, average inventory, and total turonver for the product.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace inventorySelection
{
    public partial class Form1 : Form
    {
      
        public Form1()
        {
            InitializeComponent();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            beginningTextBox1.Clear();
            beginningTextBox2.Clear();
            beginningTextBox3.Clear();
            endingTextBox1.Clear();
            endingTextBox2.Clear();
            endingTextBox3.Clear();
        }

        private void beginningTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void beginningTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void beginningTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void endingTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void endingTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void endingTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            // Calculate the difference, leftover inventory, and turnover

            //Delcare the variables. 
            

            

        }

        private void averageLabel1_Click(object sender, EventArgs e)
        {
            
        }

        private void averageLabel2_Click(object sender, EventArgs e)
        {

        }

        private void averageLabel3_Click(object sender, EventArgs e)
        {

        }

        private void totalLabel1_Click(object sender, EventArgs e)
        {

        }

        private void totalLabel2_Click(object sender, EventArgs e)
        {

        }

        private void totalLabel3_Click(object sender, EventArgs e)
        {

        }

        private void turnoverLabel1_Click(object sender, EventArgs e)
        {

        }

        private void turnoverLabel2_Click(object sender, EventArgs e)
        {

        }

        private void turnoverLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}