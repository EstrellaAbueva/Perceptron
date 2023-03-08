using System;
using System.Windows.Forms;

namespace Abueva_Perceptron
{
    public partial class Form1 : Form
    {
        Perceptron perceptron;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

       
        private void sol_Click(object sender, EventArgs e)
        {
            //get inputs from user
            int input1 = Convert.ToInt32(txt1.Text);
            int input2 = Convert.ToInt32(txt2.Text);
            int numOfEpochs = Convert.ToInt32(txt3.Text);

            //application of perceptron codes
            perceptron = new Perceptron(numInputs: 2);

            double[][] inputs = new double[][]
            {
                new double[] { 0, 0 },
                new double[] { 0, 1 },
                new double[] { 1, 0 },
                new double[] { 1, 1 }
            };

            //set target
            int[] targets = new int[] { 1, 0, 0, 0 };

            //train perceptron
            perceptron.Train(inputs, targets, numOfEpochs);

            //get output
            string output = perceptron.Predict(new double[] { input1, input2 }).ToString();

            //show output
            showw.Text = output;
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            showw.Text = "";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
