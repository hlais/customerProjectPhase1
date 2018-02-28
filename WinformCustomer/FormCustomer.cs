using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiddleLayer;
using FactoryCustomer;


namespace WinformCustomer
{
    public partial class FormCustomer : Form
    {
        private CustomerBase _customer = null;
       
        public FormCustomer()
        {
            InitializeComponent();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _customer = Factory.Create(comboBox1.Text);
        }
        private void SetCustomer()
        {
            _customer.CusterName = textBox1.Text;
            _customer.PhoneNumber = textBox2.Text;
            _customer.BillDate = Convert.ToDateTime(textBox4.Text);
            _customer.BillAmount = Convert.ToDecimal(textBox3.Text);
            _customer.Address = textBox5.Text;
        }

        private void FormCustomer_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SetCustomer();
                _customer.Validate();
            }
            catch (Exception ex)
            {

            }
        }
    }
}
