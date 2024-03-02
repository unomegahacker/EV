using Microsoft.Web.WebView2.Core;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Inversity1
{
    public partial class Form1 : Form
    { 
        public bool regexMatch = true;
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e) //button wired up to set up the google maps connection
        {
            string selecteddestination = "https://www.google.com/maps/search/nearby+ev+chargers+in+denton/@53.4541012,-2.1781792,13z/data=!3m1!4b1?authuser=0&entry=ttu"; //sets a default case so nearby chargers are shown if user does not select a charging station
            string amtToPay = "N/A"; //sets a not applicacble payrate if no station is chosen
            switch (SelectChargerCb.SelectedIndex)
            {
                case 0: //52 market street
                    selecteddestination = "https://www.google.com/maps/dir/Morrisons,+Saxon+Street,+Denton,+Manchester/52+Market+St,+Denton,+Manchester+M34+2AQ/@53.4534922,-2.1114957,16.11z/data=!4m14!4m13!1m5!1m1!1s0x487bb429797ba2b5:0xb48e2a7786306934!2m2!1d-2.111995!2d53.455114!1m5!1m1!1s0x487bb42935a880af:0x21b5b837a133daea!2m2!1d-2.1134471!2d53.4534177!3e0?authuser=0&entry=ttu";
                    amtToPay = "£5.00/h";
                    break;
                case 1: //3 fawcett close
                    selecteddestination = "https://www.google.com/maps/dir/Morrisons,+Saxon+Street,+Denton,+Manchester/Fawcett+Cl,+Denton,+Manchester/@53.4534922,-2.1114957,16.11z/data=!3m1!4b1!4m14!4m13!1m5!1m1!1s0x487bb429797ba2b5:0xb48e2a7786306934!2m2!1d-2.111995!2d53.455114!1m5!1m1!1s0x487bb42a6310ceb3:0xdba4ee9f31a58e55!2m2!1d-2.1089735!2d53.4576834!3e0?authuser=0&entry=ttu";
                    amtToPay = "£3.00/h";
                    break;
                case 2: //42 acre street
                    selecteddestination = "https://www.google.com/maps/dir/Morrisons,+Saxon+Street,+Denton,+Manchester/42+Acre+St,+Denton,+Manchester+M34+2AL/@53.4534922,-2.1114957,16.11z/data=!3m1!4b1!4m14!4m13!1m5!1m1!1s0x487bb429797ba2b5:0xb48e2a7786306934!2m2!1d-2.111995!2d53.455114!1m5!1m1!1s0x487bb4288e7aefdb:0x4957b41f8327159a!2m2!1d-2.1171423!2d53.4550807!3e0?authuser=0&entry=ttu";
                    amtToPay = "£2.00/h";
                    break;
            }
            MapView.Source = new Uri(selecteddestination); //sets destination to users chosen (or default if no choice made)
            AmtToPayLb.Text = amtToPay; //sets label to tell user how much tehy will pay
        }
        private void webView21_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e) //sets up combobox with addresses for user selection - these are placeholders
        {
            SelectChargerCb.Items.Add("52 Market Street, Denton, Manchester, M34 2AQ");
            SelectChargerCb.Items.Add("3 Fawcett Close, Denton, Manchester, M34 3FY");
            SelectChargerCb.Items.Add("42 Acre Street, Denton, Manchester, M34 2AE");
        }

        private void FindNearbyChargersBt_Click(object sender, EventArgs e) //button wired up to show nearby stations on map
        {
            SelectChargerCb.Text = ""; //sets selected charger blank if nearby chargers selected
            AmtToPayLb.Text = "N/A"; //sets not applicable for price blank if nearby chargers selected
            MapView.Source = new Uri("https://www.google.com/maps/search/nearby+ev+chargers+in+denton/@53.4541012,-2.1781792,13z/data=!3m1!4b1?authuser=0&entry=ttu"); //SetScrollState webview control to show nearby stations
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void PaymentBt_Click(object sender, EventArgs e)
        {
            bool paymentGoneThrough = true; //in real implementation payment will be taken here and it will be confirmed 
            
            if (PaymentConf.Checked && paymentGoneThrough) //if the payment is confirmed by user and has gone thru
            {
                MessageBox.Show("Payment Confirmed."); //tell user
                Random rnd = new Random(); //establish random generator
                for (int i = 0; i < 4; i++)
                {
                    int randomKey = rnd.Next(0, 9); //create new random int between 0-9; used to set up security to allow charger use
                    Controls.Find($"RandomKey{i + 1}", true)[0].Text = Convert.ToString(randomKey); //locates the four RandomKey textboxes and fills the code up
                }

            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
