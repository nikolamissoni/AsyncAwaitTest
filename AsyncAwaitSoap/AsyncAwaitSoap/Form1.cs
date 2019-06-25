using AsyncAwaitSoap.Controller;
using System.Windows.Forms;

namespace AsyncAwaitSoap
{
    public partial class Form1 : Form
    {
        MathOpController controller;

        public Form1()
        {
            InitializeComponent();
            controller = new MathOpController();
        }

        private void showMBoxButton_Click(object sender, System.EventArgs e)
        {
            System.Console.WriteLine("Button ShowMBox clicked");

            System.Console.WriteLine("ShowMBox method executing");
            MessageBox.Show("Test");
        }

        private async void calculateButton_Click(object sender, System.EventArgs e)
        {
            System.Console.WriteLine("Button Calculate clicked");
            resultTextBox.Text = await controller.Add(int.Parse(firstNumTextBox.Text), 
                                                        int.Parse(secondNumTextBox.Text));
        }
    }
}
