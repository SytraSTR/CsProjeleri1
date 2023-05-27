using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kacanButon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tebrikler yakaladın Fakat zamanını çaldım");
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            int xf = 700;
            int yf = 400;
            Random xk=new Random();
            Random yk = new Random();
            int x = xk.Next(0, xf), y = yk.Next(0, yf);
            button1.Location = new Point(x,y);
        }
    }
}
