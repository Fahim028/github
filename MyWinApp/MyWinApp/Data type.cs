using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWinApp
{
    public partial class DataType : Form
    {
        public DataType()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            int firstnumber;
              firstnumber = 10;

            int secondnumber = firstnumber  ;

            double thirdnumber = secondnumber;

            MessageBox.Show(" firstnumber :" + firstnumber + " secondnumber :" + secondnumber + " thirdnumber :" + thirdnumber);

        }
    }
}
