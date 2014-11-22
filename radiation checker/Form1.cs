using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace radiation_checker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == 3)
            {
                eminus.Text = "e-";
            }
            else
            {
                eminus.Text = "";
            }
        }

        public void decayButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text.Equals(""))
            {
                MessageBox.Show("You need to choose a decay mode!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //ele1Label.Text.Equals("")

            if (ele1AtomNum.Text.Equals("") || ele1MassNum.Text.Equals(""))
            {
                MessageBox.Show("Fill in your starting element!", "Stupid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Product eleStart = new Product(int.Parse(ele1MassNum.Text), int.Parse(ele1AtomNum.Text), ele1Label.Text);
            
            List<Product> listParse = new List<Product>();

            if (comboBox1.SelectedIndex == 0)
            {
                listParse = eleStart.doDecay(Product.DecayMode.AlphaDecay);
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                listParse = eleStart.doDecay(Product.DecayMode.BetaDecay);
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                listParse = eleStart.doDecay(Product.DecayMode.Positron);
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                listParse = eleStart.doDecay(Product.DecayMode.ElectronCap);
            }

            if (listParse.Count > 3)
            {
                throw new Exception("Something is REALLY wrong here");
            }

            int counter = 0;
            foreach (Product p in listParse)
            {
                if (counter == 0)
                {
                    ele2AtomNum.Text = p.getAtomNum().ToString();
                    ele2MassNum.Text = p.getMassNum().ToString();
                    ele2FullName.Text = p.getFullName();
                    ele2Label.Text = p.getSymbol();
                }
                else if (counter == 1)
                {
                    ele3AtomNum.Text = p.getAtomNum().ToString();
                    ele3MassNum.Text = p.getMassNum().ToString();
                    ele3FullName.Text = p.getFullName();
                    ele3Label.Text = p.getSymbol();
                }
                else if (counter == 2)
                {
                    ele4AtomNum.Text = p.getAtomNum().ToString();
                    ele4MassNum.Text = p.getMassNum().ToString();
                    ele4FullName.Text = p.getFullName();
                    ele4Label.Text = p.getSymbol();
                }
                counter += 1;
            }
        }

        private void ele1AtomNum_TextChanged(object sender, EventArgs e)
        {
            if (ele1AtomNum.Text.Equals(""))
            {
                ele1Label.Text = "";
                return;
            }

            try
            {
                ele1Label.Text = Product.doElementMatch(int.Parse(ele1AtomNum.Text));
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Only numbers go in the atomic number field!", "Stupid", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ele1AtomNum.Text = "";
                
                // This is just because the warning sign under ex is pissing me off
                string a = ex.Message;
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
