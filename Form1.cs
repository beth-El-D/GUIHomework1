using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HomeWorkGUI1.Model;

namespace HomeWorkGUI1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            productModel p = new productModel();
            p.invNumber = int.Parse(txtNumber.Text);
            p.date = dtpReg.Text;
            p.unknown = int.Parse(txtUnknown.Text);
            p.itemName = txtItemName.Text;
            p.count = int.Parse(txtCount.Text);
            p.price = double.Parse(txtPrice.Text);

            p.Save();

            MessageBox.Show(p.itemName + " added successfully.");

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
