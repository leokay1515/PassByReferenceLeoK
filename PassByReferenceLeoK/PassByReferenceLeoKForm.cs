using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PassByReferenceLeoK
{
    public partial class frmPassByReferenceLeoK : Form
    {
        public frmPassByReferenceLeoK()
        {
            InitializeComponent();
        }

        private void RoundNum(ref double decimalNum, int roundNum)
        {
            //multiply the decimal by 10^roundNum
            decimalNum = decimalNum * Math.Pow(10, roundNum);

            //add 0.5 to it
            decimalNum = decimalNum + 0.5;

            //get rid of the numbers following the decimal
            decimalNum = Math.Truncate(decimalNum);

            //move the decimal place back
            decimalNum = decimalNum / Math.Pow(10, roundNum);

            //display it
            MessageBox.Show(decimalNum + " is your rounded number.", "Rounded Number");
        }

        private void btnRound_Click(object sender, EventArgs e)
        {
            //Get the number from the user
            double userDecimal = Convert.ToDouble(txtDecimal.Text);

            //Get the number of decimal places the user wants to round to
            int userRound = Convert.ToInt32(nudRound.Value);

            //round and display the number
            RoundNum(ref userDecimal, userRound);
        }
    }
}
