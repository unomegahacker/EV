namespace Inversity1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            MapView = new Microsoft.Web.WebView2.WinForms.WebView2();
            DirectToAddressBt = new Button();
            SelectChargerCb = new ComboBox();
            FindNearbyChargersBt = new Button();
            PaymentBt = new Button();
            label1 = new Label();
            AmtToPayLb = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            cardnum = new TextBox();
            expdate = new TextBox();
            secnum = new TextBox();
            RandomKey1 = new TextBox();
            RandomKey2 = new TextBox();
            RandomKey4 = new TextBox();
            RandomKey3 = new TextBox();
            PaymentConf = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)MapView).BeginInit();
            SuspendLayout();
            // 
            // MapView
            // 
            MapView.AllowExternalDrop = true;
            MapView.BackColor = SystemColors.ActiveCaptionText;
            MapView.CreationProperties = null;
            MapView.DefaultBackgroundColor = Color.White;
            MapView.Location = new Point(12, 103);
            MapView.Name = "MapView";
            MapView.Size = new Size(883, 506);
            MapView.Source = new Uri("https://www.google.com/maps/@53.4534922,-2.1114957,16.11z?authuser=0&entry=ttu", UriKind.Absolute);
            MapView.TabIndex = 0;
            MapView.ZoomFactor = 0.5D;
            MapView.Click += webView21_Click;
            // 
            // DirectToAddressBt
            // 
            DirectToAddressBt.Location = new Point(12, 68);
            DirectToAddressBt.Name = "DirectToAddressBt";
            DirectToAddressBt.Size = new Size(154, 29);
            DirectToAddressBt.TabIndex = 1;
            DirectToAddressBt.Text = "Directions";
            DirectToAddressBt.UseVisualStyleBackColor = true;
            DirectToAddressBt.Click += button1_Click;
            // 
            // SelectChargerCb
            // 
            SelectChargerCb.FormattingEnabled = true;
            SelectChargerCb.Location = new Point(12, 34);
            SelectChargerCb.Name = "SelectChargerCb";
            SelectChargerCb.Size = new Size(442, 28);
            SelectChargerCb.TabIndex = 2;
            // 
            // FindNearbyChargersBt
            // 
            FindNearbyChargersBt.Location = new Point(528, 34);
            FindNearbyChargersBt.Name = "FindNearbyChargersBt";
            FindNearbyChargersBt.Size = new Size(367, 29);
            FindNearbyChargersBt.TabIndex = 3;
            FindNearbyChargersBt.Text = "Find Nearby Chargers";
            FindNearbyChargersBt.UseVisualStyleBackColor = true;
            FindNearbyChargersBt.Click += FindNearbyChargersBt_Click;
            // 
            // PaymentBt
            // 
            PaymentBt.Location = new Point(914, 330);
            PaymentBt.Name = "PaymentBt";
            PaymentBt.Size = new Size(276, 29);
            PaymentBt.TabIndex = 4;
            PaymentBt.Text = "Pay";
            PaymentBt.UseVisualStyleBackColor = true;
            PaymentBt.Click += PaymentBt_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(914, 37);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 5;
            label1.Text = "Amount to pay:";
            // 
            // AmtToPayLb
            // 
            AmtToPayLb.AutoSize = true;
            AmtToPayLb.Font = new Font("Segoe UI", 21F);
            AmtToPayLb.Location = new Point(914, 68);
            AmtToPayLb.Name = "AmtToPayLb";
            AmtToPayLb.Size = new Size(83, 47);
            AmtToPayLb.TabIndex = 6;
            AmtToPayLb.Text = "N/A";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(917, 128);
            label2.Name = "label2";
            label2.Size = new Size(108, 20);
            label2.TabIndex = 7;
            label2.Text = "Name on Card:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(917, 244);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 8;
            label3.Text = "Security Number:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(1065, 244);
            label4.Name = "label4";
            label4.Size = new Size(88, 20);
            label4.TabIndex = 9;
            label4.Text = "Expiry Date:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(924, 181);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 10;
            label5.Text = "Card Number";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(917, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(273, 27);
            textBox1.TabIndex = 11;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // cardnum
            // 
            cardnum.Location = new Point(914, 204);
            cardnum.Name = "cardnum";
            cardnum.Size = new Size(276, 27);
            cardnum.TabIndex = 12;
            // 
            // expdate
            // 
            expdate.Location = new Point(1065, 267);
            expdate.Name = "expdate";
            expdate.Size = new Size(125, 27);
            expdate.TabIndex = 13;
            // 
            // secnum
            // 
            secnum.Location = new Point(914, 267);
            secnum.Name = "secnum";
            secnum.Size = new Size(125, 27);
            secnum.TabIndex = 14;
            // 
            // RandomKey1
            // 
            RandomKey1.Location = new Point(914, 377);
            RandomKey1.Name = "RandomKey1";
            RandomKey1.ReadOnly = true;
            RandomKey1.Size = new Size(51, 27);
            RandomKey1.TabIndex = 15;
            // 
            // RandomKey2
            // 
            RandomKey2.Location = new Point(988, 377);
            RandomKey2.Name = "RandomKey2";
            RandomKey2.ReadOnly = true;
            RandomKey2.Size = new Size(51, 27);
            RandomKey2.TabIndex = 16;
            RandomKey2.TextChanged += textBox6_TextChanged;
            // 
            // RandomKey4
            // 
            RandomKey4.Location = new Point(1139, 377);
            RandomKey4.Name = "RandomKey4";
            RandomKey4.ReadOnly = true;
            RandomKey4.Size = new Size(51, 27);
            RandomKey4.TabIndex = 17;
            // 
            // RandomKey3
            // 
            RandomKey3.Location = new Point(1065, 377);
            RandomKey3.Name = "RandomKey3";
            RandomKey3.ReadOnly = true;
            RandomKey3.Size = new Size(51, 27);
            RandomKey3.TabIndex = 18;
            // 
            // PaymentConf
            // 
            PaymentConf.AutoSize = true;
            PaymentConf.Location = new Point(917, 300);
            PaymentConf.Name = "PaymentConf";
            PaymentConf.Size = new Size(144, 24);
            PaymentConf.TabIndex = 19;
            PaymentConf.Text = "Confirm Payment";
            PaymentConf.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1202, 637);
            Controls.Add(PaymentConf);
            Controls.Add(RandomKey3);
            Controls.Add(RandomKey4);
            Controls.Add(RandomKey2);
            Controls.Add(RandomKey1);
            Controls.Add(secnum);
            Controls.Add(expdate);
            Controls.Add(cardnum);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(AmtToPayLb);
            Controls.Add(label1);
            Controls.Add(PaymentBt);
            Controls.Add(FindNearbyChargersBt);
            Controls.Add(SelectChargerCb);
            Controls.Add(DirectToAddressBt);
            Controls.Add(MapView);
            Name = "Form1";
            Text = "Park To Charge";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)MapView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Microsoft.Web.WebView2.WinForms.WebView2 MapView;
        private Button DirectToAddressBt;
        private ComboBox SelectChargerCb;
        private Button FindNearbyChargersBt;
        private Button PaymentBt;
        private Label label1;
        private Label AmtToPayLb;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private TextBox cardnum;
        private TextBox expdate;
        private TextBox secnum;
        private TextBox RandomKey1;
        private TextBox RandomKey2;
        private TextBox RandomKey4;
        private TextBox RandomKey3;
        private CheckBox PaymentConf;
    }
}
