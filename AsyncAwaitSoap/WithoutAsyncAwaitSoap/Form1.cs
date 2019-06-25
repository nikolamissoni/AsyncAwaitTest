using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WithoutAsyncAwaitSoap
{
    public partial class Form1 : Form
    {
        WithoutAsyncAwaitSoap.Controller.MathOpController mathOpCont;
        public Form1()
        {
            InitializeComponent();
            mathOpCont = new WithoutAsyncAwaitSoap.Controller.MathOpController();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("Button ShowMBox clicked");

            System.Console.WriteLine("ShowMBox method executing");
            MessageBox.Show("Test");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Console.WriteLine("Button Calculate clicked");
            resultTextBoxNoAsync.Text = mathOpCont.Add(int.Parse(firstNumTextBoxNoAsync.Text),
                                                        int.Parse(secondNumTextBoxNoAsync.Text));
        }
    }
}
