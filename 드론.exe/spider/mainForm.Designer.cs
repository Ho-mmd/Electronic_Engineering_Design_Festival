namespace BLE_Sample
{
    partial class mainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnConnect = new System.Windows.Forms.Button();
            this.charListBox = new System.Windows.Forms.ListBox();
            this.btnYLED = new System.Windows.Forms.Button();
            this.btnCLED = new System.Windows.Forms.Button();
            this.btnRLED = new System.Windows.Forms.Button();
            this.PetorneDeviceListBox = new System.Windows.Forms.ListBox();
            this.btnTakeOff = new System.Windows.Forms.Button();
            this.btnEmergencyStop = new System.Windows.Forms.Button();
            this.btnLanding = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ProgressStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRead = new System.Windows.Forms.Button();
            this.LogTextBox = new System.Windows.Forms.RichTextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnTimer = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAccx = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAccy = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAccz = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtgyroRoll = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtgyroPitch = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtgyroYaw = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtangleRoll = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtanglePitch = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtangleYaw = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPressure = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTemp = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBattery = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(328, 10);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(115, 52);
            this.btnConnect.TabIndex = 3;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.Connect_Click);
            // 
            // charListBox
            // 
            this.charListBox.ItemHeight = 12;
            this.charListBox.Items.AddRange(new object[] {
            "No Petrone Selected",
            "Connect and Select Petorne"});
            this.charListBox.Location = new System.Drawing.Point(7, 10);
            this.charListBox.Margin = new System.Windows.Forms.Padding(2);
            this.charListBox.Name = "charListBox";
            this.charListBox.Size = new System.Drawing.Size(315, 52);
            this.charListBox.TabIndex = 2;
            // 
            // btnYLED
            // 
            this.btnYLED.Location = new System.Drawing.Point(327, 107);
            this.btnYLED.Name = "btnYLED";
            this.btnYLED.Size = new System.Drawing.Size(115, 27);
            this.btnYLED.TabIndex = 5;
            this.btnYLED.Text = "Dimming Yellow";
            this.btnYLED.UseVisualStyleBackColor = true;
            this.btnYLED.Click += new System.EventHandler(this.btnYLED_Click);
            // 
            // btnCLED
            // 
            this.btnCLED.Location = new System.Drawing.Point(327, 140);
            this.btnCLED.Name = "btnCLED";
            this.btnCLED.Size = new System.Drawing.Size(115, 27);
            this.btnCLED.TabIndex = 6;
            this.btnCLED.Text = "Dimming Cyan";
            this.btnCLED.UseVisualStyleBackColor = true;
            this.btnCLED.Click += new System.EventHandler(this.btnCLED_Click);
            // 
            // btnRLED
            // 
            this.btnRLED.Location = new System.Drawing.Point(327, 74);
            this.btnRLED.Name = "btnRLED";
            this.btnRLED.Size = new System.Drawing.Size(115, 27);
            this.btnRLED.TabIndex = 7;
            this.btnRLED.Text = "Dimming RED";
            this.btnRLED.UseVisualStyleBackColor = true;
            this.btnRLED.Click += new System.EventHandler(this.btnRLED_Click);
            // 
            // PetorneDeviceListBox
            // 
            this.PetorneDeviceListBox.ItemHeight = 12;
            this.PetorneDeviceListBox.Location = new System.Drawing.Point(7, 74);
            this.PetorneDeviceListBox.Margin = new System.Windows.Forms.Padding(2);
            this.PetorneDeviceListBox.Name = "PetorneDeviceListBox";
            this.PetorneDeviceListBox.Size = new System.Drawing.Size(315, 64);
            this.PetorneDeviceListBox.TabIndex = 8;
            this.PetorneDeviceListBox.SelectedIndexChanged += new System.EventHandler(this.PetroneDeviceListBox_SelectedIndexChanged);
            // 
            // btnTakeOff
            // 
            this.btnTakeOff.Location = new System.Drawing.Point(328, 281);
            this.btnTakeOff.Name = "btnTakeOff";
            this.btnTakeOff.Size = new System.Drawing.Size(115, 27);
            this.btnTakeOff.TabIndex = 11;
            this.btnTakeOff.Text = "Take Off";
            this.btnTakeOff.UseVisualStyleBackColor = true;
            this.btnTakeOff.Click += new System.EventHandler(this.btnTakeOff_Click);
            // 
            // btnEmergencyStop
            // 
            this.btnEmergencyStop.Location = new System.Drawing.Point(328, 347);
            this.btnEmergencyStop.Name = "btnEmergencyStop";
            this.btnEmergencyStop.Size = new System.Drawing.Size(115, 27);
            this.btnEmergencyStop.TabIndex = 10;
            this.btnEmergencyStop.Text = "Emergency Stop";
            this.btnEmergencyStop.UseVisualStyleBackColor = true;
            this.btnEmergencyStop.Click += new System.EventHandler(this.btnEmergencyStop_Click);
            // 
            // btnLanding
            // 
            this.btnLanding.Location = new System.Drawing.Point(328, 314);
            this.btnLanding.Name = "btnLanding";
            this.btnLanding.Size = new System.Drawing.Size(115, 27);
            this.btnLanding.TabIndex = 9;
            this.btnLanding.Text = "Landing";
            this.btnLanding.UseVisualStyleBackColor = true;
            this.btnLanding.Click += new System.EventHandler(this.btnLanding_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ProgressStatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 375);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(966, 24);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ProgressStatusLabel
            // 
            this.ProgressStatusLabel.Name = "ProgressStatusLabel";
            this.ProgressStatusLabel.Size = new System.Drawing.Size(62, 19);
            this.ProgressStatusLabel.Text = "Progress";
            // 
            // btnRead
            // 
            this.btnRead.Location = new System.Drawing.Point(328, 178);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(115, 27);
            this.btnRead.TabIndex = 13;
            this.btnRead.Text = "Read";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // LogTextBox
            // 
            this.LogTextBox.Location = new System.Drawing.Point(7, 144);
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.Size = new System.Drawing.Size(314, 230);
            this.LogTextBox.TabIndex = 14;
            this.LogTextBox.Text = "";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btnTimer
            // 
            this.btnTimer.Location = new System.Drawing.Point(328, 211);
            this.btnTimer.Name = "btnTimer";
            this.btnTimer.Size = new System.Drawing.Size(115, 27);
            this.btnTimer.TabIndex = 15;
            this.btnTimer.Text = "Timer";
            this.btnTimer.UseVisualStyleBackColor = true;
            this.btnTimer.Click += new System.EventHandler(this.btnTimer_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(464, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 14);
            this.label1.TabIndex = 16;
            this.label1.Text = "AccX : ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAccx
            // 
            this.txtAccx.Location = new System.Drawing.Point(522, 39);
            this.txtAccx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAccx.Name = "txtAccx";
            this.txtAccx.Size = new System.Drawing.Size(88, 21);
            this.txtAccx.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(464, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 14);
            this.label2.TabIndex = 16;
            this.label2.Text = "AccY : ";
            this.label2.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAccy
            // 
            this.txtAccy.Location = new System.Drawing.Point(522, 64);
            this.txtAccy.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAccy.Name = "txtAccy";
            this.txtAccy.Size = new System.Drawing.Size(88, 21);
            this.txtAccy.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(464, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 14);
            this.label3.TabIndex = 16;
            this.label3.Text = "AccZ : ";
            this.label3.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAccz
            // 
            this.txtAccz.Location = new System.Drawing.Point(522, 89);
            this.txtAccz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtAccz.Name = "txtAccz";
            this.txtAccz.Size = new System.Drawing.Size(88, 21);
            this.txtAccz.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(464, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 14);
            this.label4.TabIndex = 16;
            this.label4.Text = "gyroRoll : ";
            this.label4.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtgyroRoll
            // 
            this.txtgyroRoll.Location = new System.Drawing.Point(550, 114);
            this.txtgyroRoll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgyroRoll.Name = "txtgyroRoll";
            this.txtgyroRoll.Size = new System.Drawing.Size(88, 21);
            this.txtgyroRoll.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(464, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 14);
            this.label5.TabIndex = 16;
            this.label5.Text = "gyroPitch : ";
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtgyroPitch
            // 
            this.txtgyroPitch.Location = new System.Drawing.Point(550, 138);
            this.txtgyroPitch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgyroPitch.Name = "txtgyroPitch";
            this.txtgyroPitch.Size = new System.Drawing.Size(88, 21);
            this.txtgyroPitch.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(464, 164);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 14);
            this.label6.TabIndex = 16;
            this.label6.Text = "gyroYaw : ";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtgyroYaw
            // 
            this.txtgyroYaw.Location = new System.Drawing.Point(550, 163);
            this.txtgyroYaw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtgyroYaw.Name = "txtgyroYaw";
            this.txtgyroYaw.Size = new System.Drawing.Size(88, 21);
            this.txtgyroYaw.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.Location = new System.Drawing.Point(464, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 14);
            this.label7.TabIndex = 16;
            this.label7.Text = "angleRoll : ";
            this.label7.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtangleRoll
            // 
            this.txtangleRoll.Location = new System.Drawing.Point(558, 189);
            this.txtangleRoll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtangleRoll.Name = "txtangleRoll";
            this.txtangleRoll.Size = new System.Drawing.Size(88, 21);
            this.txtangleRoll.TabIndex = 17;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.Location = new System.Drawing.Point(464, 214);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 14);
            this.label8.TabIndex = 16;
            this.label8.Text = "anglePitch : ";
            this.label8.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtanglePitch
            // 
            this.txtanglePitch.Location = new System.Drawing.Point(558, 214);
            this.txtanglePitch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtanglePitch.Name = "txtanglePitch";
            this.txtanglePitch.Size = new System.Drawing.Size(88, 21);
            this.txtanglePitch.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label9.Location = new System.Drawing.Point(464, 239);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 14);
            this.label9.TabIndex = 16;
            this.label9.Text = "angleYaw : ";
            this.label9.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtangleYaw
            // 
            this.txtangleYaw.Location = new System.Drawing.Point(558, 238);
            this.txtangleYaw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtangleYaw.Name = "txtangleYaw";
            this.txtangleYaw.Size = new System.Drawing.Size(88, 21);
            this.txtangleYaw.TabIndex = 17;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label10.Location = new System.Drawing.Point(465, 264);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 14);
            this.label10.TabIndex = 16;
            this.label10.Text = "Pressure : ";
            this.label10.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtPressure
            // 
            this.txtPressure.Location = new System.Drawing.Point(559, 263);
            this.txtPressure.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPressure.Name = "txtPressure";
            this.txtPressure.Size = new System.Drawing.Size(88, 21);
            this.txtPressure.TabIndex = 17;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label11.Location = new System.Drawing.Point(465, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(115, 14);
            this.label11.TabIndex = 16;
            this.label11.Text = "Temperature : ";
            this.label11.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTemp
            // 
            this.txtTemp.Location = new System.Drawing.Point(572, 288);
            this.txtTemp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTemp.Name = "txtTemp";
            this.txtTemp.Size = new System.Drawing.Size(88, 21);
            this.txtTemp.TabIndex = 17;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label12.Location = new System.Drawing.Point(464, 340);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 14);
            this.label12.TabIndex = 16;
            this.label12.Text = "Height : ";
            this.label12.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtBattery
            // 
            this.txtBattery.Location = new System.Drawing.Point(535, 313);
            this.txtBattery.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBattery.Name = "txtBattery";
            this.txtBattery.Size = new System.Drawing.Size(88, 21);
            this.txtBattery.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(798, 356);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(66, 18);
            this.button1.TabIndex = 18;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(883, 356);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(66, 18);
            this.button2.TabIndex = 18;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(536, 338);
            this.textBox4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(88, 21);
            this.textBox4.TabIndex = 17;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("굴림", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label13.Location = new System.Drawing.Point(464, 315);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(78, 14);
            this.label13.TabIndex = 16;
            this.label13.Text = "Battery : ";
            this.label13.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(835, 107);
            this.textBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(48, 21);
            this.textBox1.TabIndex = 17;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(666, 214);
            this.textBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(88, 21);
            this.textBox2.TabIndex = 17;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(666, 238);
            this.textBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(88, 21);
            this.textBox3.TabIndex = 17;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 399);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBattery);
            this.Controls.Add(this.txtTemp);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.txtangleYaw);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtgyroYaw);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtPressure);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtanglePitch);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.txtgyroPitch);
            this.Controls.Add(this.txtangleRoll);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtgyroRoll);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAccz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAccy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtAccx);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnTimer);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.btnRead);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnTakeOff);
            this.Controls.Add(this.btnEmergencyStop);
            this.Controls.Add(this.btnLanding);
            this.Controls.Add(this.PetorneDeviceListBox);
            this.Controls.Add(this.btnRLED);
            this.Controls.Add(this.btnCLED);
            this.Controls.Add(this.btnYLED);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.charListBox);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "mainForm";
            this.Text = "Windows-Petrone BLE Connector (v150427)";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.ListBox charListBox;
        private System.Windows.Forms.Button btnYLED;
        private System.Windows.Forms.Button btnCLED;
        private System.Windows.Forms.Button btnRLED;
        private System.Windows.Forms.ListBox PetorneDeviceListBox;
        private System.Windows.Forms.Button btnTakeOff;
        private System.Windows.Forms.Button btnEmergencyStop;
        private System.Windows.Forms.Button btnLanding;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ProgressStatusLabel;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.RichTextBox LogTextBox;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAccx;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAccy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAccz;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtgyroRoll;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtgyroPitch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtgyroYaw;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtangleRoll;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtanglePitch;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtangleYaw;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPressure;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTemp;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBattery;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}

