using Microsoft.Web.WebView2.Core;
using System.Windows.Forms;

namespace Inversity1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string selecteddestination = "https://www.google.com/maps/search/nearby+ev+chargers+in+denton/@53.4541012,-2.1781792,13z/data=!3m1!4b1?authuser=0&entry=ttu";
            string amtToPay = "N/A";
            switch (SelectChargerCb.SelectedIndex)
            {
                case 0:
                    selecteddestination = "https://www.google.com/maps/dir/Morrisons,+Saxon+Street,+Denton,+Manchester/52+Market+St,+Denton,+Manchester+M34+2AQ/@53.4534922,-2.1114957,16.11z/data=!4m14!4m13!1m5!1m1!1s0x487bb429797ba2b5:0xb48e2a7786306934!2m2!1d-2.111995!2d53.455114!1m5!1m1!1s0x487bb42935a880af:0x21b5b837a133daea!2m2!1d-2.1134471!2d53.4534177!3e0?authuser=0&entry=ttu";
                    amtToPay = "5.00";
                    break;
                case 1:
                    selecteddestination = "https://www.google.com/maps/dir/Morrisons,+Saxon+Street,+Denton,+Manchester/Fawcett+Cl,+Denton,+Manchester/@53.4534922,-2.1114957,16.11z/data=!3m1!4b1!4m14!4m13!1m5!1m1!1s0x487bb429797ba2b5:0xb48e2a7786306934!2m2!1d-2.111995!2d53.455114!1m5!1m1!1s0x487bb42a6310ceb3:0xdba4ee9f31a58e55!2m2!1d-2.1089735!2d53.4576834!3e0?authuser=0&entry=ttu";
                    amtToPay = "3.00";
                    break;
                case 2:
                    selecteddestination = "https://www.google.com/maps/dir/Morrisons,+Saxon+Street,+Denton,+Manchester/42+Acre+St,+Denton,+Manchester+M34+2AL/@53.4534922,-2.1114957,16.11z/data=!3m1!4b1!4m14!4m13!1m5!1m1!1s0x487bb429797ba2b5:0xb48e2a7786306934!2m2!1d-2.111995!2d53.455114!1m5!1m1!1s0x487bb4288e7aefdb:0x4957b41f8327159a!2m2!1d-2.1171423!2d53.4550807!3e0?authuser=0&entry=ttu";
                    amtToPay = "2.00";
                    break;
            }
            MapView.Source = new Uri(selecteddestination);
            AmtToPayLb.Text = "£" + amtToPay;
        }
        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SelectChargerCb.Items.Add("52 Market Street, Denton, Manchester, M34 2AQ");
            SelectChargerCb.Items.Add("3 Fawcett Close, Denton, Manchester, M34 3FY");
            SelectChargerCb.Items.Add("42 Acre Street, Denton, Manchester, M34 2AE");
        }

        private void FindNearbyChargersBt_Click(object sender, EventArgs e)
        {
            SelectChargerCb.Text = "";
            AmtToPayLb.Text = "N/A";
            MapView.Source = new Uri("https://www.google.com/maps/search/nearby+ev+chargers+in+denton/@53.4541012,-2.1781792,13z/data=!3m1!4b1?authuser=0&entry=ttu");
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void PaymentBt_Click(object sender, EventArgs e)
        {
            bool paymentGoneThrough = true;
            string cardnumber = cardnum.Text;
            string 
            //code for taking payment will be implemented here
            if (PaymentConf.Checked && paymentGoneThrough)
            {
                MessageBox.Show("Payment Confirmed.");
                Random rnd = new Random();
                for (int i = 0; i < 4; i++)
                {
                    int randomKey = rnd.Next(0, 9);
                    Controls.Find($"RandomKey{i + 1}", true)[0].Text = Convert.ToString(randomKey);
                }

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
