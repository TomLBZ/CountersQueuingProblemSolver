namespace CountersQueuingProblemSolver
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtArrival = new System.Windows.Forms.TextBox();
            this.lblArrival = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.txtLevels = new System.Windows.Forms.TextBox();
            this.lblLvlNum = new System.Windows.Forms.Label();
            this.txtLvlNum = new System.Windows.Forms.TextBox();
            this.lblProcTime = new System.Windows.Forms.Label();
            this.txtProcTime = new System.Windows.Forms.TextBox();
            this.lblTime = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblPplInSys = new System.Windows.Forms.Label();
            this.txtPplNum = new System.Windows.Forms.TextBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnSimulate = new System.Windows.Forms.Button();
            this.lblInitial = new System.Windows.Forms.Label();
            this.txtIniState = new System.Windows.Forms.TextBox();
            this.lblStudentNum = new System.Windows.Forms.Label();
            this.txtNumStudent = new System.Windows.Forms.TextBox();
            this.lblQ = new System.Windows.Forms.Label();
            this.txtQ = new System.Windows.Forms.TextBox();
            this.lblStuYetCome = new System.Windows.Forms.Label();
            this.txtYet = new System.Windows.Forms.TextBox();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnSimulateOnce = new System.Windows.Forms.Button();
            this.lblPplAtLvl = new System.Windows.Forms.Label();
            this.txtPplAtLvl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(397, 426);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtArrival
            // 
            this.txtArrival.Location = new System.Drawing.Point(615, 12);
            this.txtArrival.Name = "txtArrival";
            this.txtArrival.Size = new System.Drawing.Size(173, 20);
            this.txtArrival.TabIndex = 1;
            this.txtArrival.Text = "8";
            // 
            // lblArrival
            // 
            this.lblArrival.AutoSize = true;
            this.lblArrival.Location = new System.Drawing.Point(415, 12);
            this.lblArrival.Name = "lblArrival";
            this.lblArrival.Size = new System.Drawing.Size(197, 13);
            this.lblArrival.TabIndex = 2;
            this.lblArrival.Text = "No. of Minutes for each student to arrive";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(415, 38);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(90, 13);
            this.lblLevel.TabIndex = 4;
            this.lblLevel.Text = "Number of Levels";
            // 
            // txtLevels
            // 
            this.txtLevels.Location = new System.Drawing.Point(615, 38);
            this.txtLevels.Name = "txtLevels";
            this.txtLevels.Size = new System.Drawing.Size(173, 20);
            this.txtLevels.TabIndex = 3;
            this.txtLevels.Text = "3";
            // 
            // lblLvlNum
            // 
            this.lblLvlNum.AutoSize = true;
            this.lblLvlNum.Location = new System.Drawing.Point(415, 64);
            this.lblLvlNum.Name = "lblLvlNum";
            this.lblLvlNum.Size = new System.Drawing.Size(144, 13);
            this.lblLvlNum.TabIndex = 6;
            this.lblLvlNum.Text = "No. of Counters in each level";
            // 
            // txtLvlNum
            // 
            this.txtLvlNum.Location = new System.Drawing.Point(615, 64);
            this.txtLvlNum.Name = "txtLvlNum";
            this.txtLvlNum.Size = new System.Drawing.Size(173, 20);
            this.txtLvlNum.TabIndex = 5;
            this.txtLvlNum.Text = "1,3,4";
            // 
            // lblProcTime
            // 
            this.lblProcTime.AutoSize = true;
            this.lblProcTime.Location = new System.Drawing.Point(415, 90);
            this.lblProcTime.Name = "lblProcTime";
            this.lblProcTime.Size = new System.Drawing.Size(157, 13);
            this.lblProcTime.TabIndex = 8;
            this.lblProcTime.Text = "Processing Time for Each Level";
            // 
            // txtProcTime
            // 
            this.txtProcTime.Location = new System.Drawing.Point(615, 90);
            this.txtProcTime.Name = "txtProcTime";
            this.txtProcTime.Size = new System.Drawing.Size(173, 20);
            this.txtProcTime.TabIndex = 7;
            this.txtProcTime.Text = "2,10,20";
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(415, 224);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(98, 13);
            this.lblTime.TabIndex = 10;
            this.lblTime.Text = "Time Stamp Output";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(615, 224);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(173, 20);
            this.txtTime.TabIndex = 9;
            this.txtTime.Text = "0";
            // 
            // lblPplInSys
            // 
            this.lblPplInSys.AutoSize = true;
            this.lblPplInSys.Location = new System.Drawing.Point(415, 250);
            this.lblPplInSys.Name = "lblPplInSys";
            this.lblPplInSys.Size = new System.Drawing.Size(120, 13);
            this.lblPplInSys.TabIndex = 12;
            this.lblPplInSys.Text = "No. of People in System";
            // 
            // txtPplNum
            // 
            this.txtPplNum.Location = new System.Drawing.Point(615, 250);
            this.txtPplNum.Name = "txtPplNum";
            this.txtPplNum.Size = new System.Drawing.Size(173, 20);
            this.txtPplNum.TabIndex = 11;
            this.txtPplNum.Text = "0";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(615, 168);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(173, 50);
            this.btnReset.TabIndex = 13;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnSimulate
            // 
            this.btnSimulate.Location = new System.Drawing.Point(418, 168);
            this.btnSimulate.Name = "btnSimulate";
            this.btnSimulate.Size = new System.Drawing.Size(173, 50);
            this.btnSimulate.TabIndex = 14;
            this.btnSimulate.Text = "Simulate";
            this.btnSimulate.UseVisualStyleBackColor = true;
            this.btnSimulate.Click += new System.EventHandler(this.btnSimulate_Click);
            // 
            // lblInitial
            // 
            this.lblInitial.AutoSize = true;
            this.lblInitial.Location = new System.Drawing.Point(415, 116);
            this.lblInitial.Name = "lblInitial";
            this.lblInitial.Size = new System.Drawing.Size(96, 13);
            this.lblInitial.TabIndex = 16;
            this.lblInitial.Text = "System Initial State";
            // 
            // txtIniState
            // 
            this.txtIniState.Location = new System.Drawing.Point(615, 116);
            this.txtIniState.Name = "txtIniState";
            this.txtIniState.Size = new System.Drawing.Size(173, 20);
            this.txtIniState.TabIndex = 15;
            this.txtIniState.Text = "0;0,0,0;0,0,0,0";
            // 
            // lblStudentNum
            // 
            this.lblStudentNum.AutoSize = true;
            this.lblStudentNum.Location = new System.Drawing.Point(415, 142);
            this.lblStudentNum.Name = "lblStudentNum";
            this.lblStudentNum.Size = new System.Drawing.Size(136, 13);
            this.lblStudentNum.TabIndex = 18;
            this.lblStudentNum.Text = "Number of students coming";
            // 
            // txtNumStudent
            // 
            this.txtNumStudent.Location = new System.Drawing.Point(615, 142);
            this.txtNumStudent.Name = "txtNumStudent";
            this.txtNumStudent.Size = new System.Drawing.Size(173, 20);
            this.txtNumStudent.TabIndex = 17;
            this.txtNumStudent.Text = "20";
            // 
            // lblQ
            // 
            this.lblQ.AutoSize = true;
            this.lblQ.Location = new System.Drawing.Point(415, 276);
            this.lblQ.Name = "lblQ";
            this.lblQ.Size = new System.Drawing.Size(118, 13);
            this.lblQ.TabIndex = 20;
            this.lblQ.Text = "Queue Length by Level";
            // 
            // txtQ
            // 
            this.txtQ.Location = new System.Drawing.Point(615, 276);
            this.txtQ.Name = "txtQ";
            this.txtQ.Size = new System.Drawing.Size(173, 20);
            this.txtQ.TabIndex = 19;
            this.txtQ.Text = "0";
            // 
            // lblStuYetCome
            // 
            this.lblStuYetCome.AutoSize = true;
            this.lblStuYetCome.Location = new System.Drawing.Point(415, 354);
            this.lblStuYetCome.Name = "lblStuYetCome";
            this.lblStuYetCome.Size = new System.Drawing.Size(110, 13);
            this.lblStuYetCome.TabIndex = 22;
            this.lblStuYetCome.Text = "Students Yet to Come";
            // 
            // txtYet
            // 
            this.txtYet.Location = new System.Drawing.Point(615, 354);
            this.txtYet.Name = "txtYet";
            this.txtYet.Size = new System.Drawing.Size(173, 20);
            this.txtYet.TabIndex = 21;
            this.txtYet.Text = "0";
            // 
            // btnPause
            // 
            this.btnPause.Location = new System.Drawing.Point(615, 380);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(173, 58);
            this.btnPause.TabIndex = 23;
            this.btnPause.Text = "Pause";
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnSimulateOnce
            // 
            this.btnSimulateOnce.Location = new System.Drawing.Point(418, 380);
            this.btnSimulateOnce.Name = "btnSimulateOnce";
            this.btnSimulateOnce.Size = new System.Drawing.Size(173, 58);
            this.btnSimulateOnce.TabIndex = 24;
            this.btnSimulateOnce.Text = "Simulate 1 Step";
            this.btnSimulateOnce.UseVisualStyleBackColor = true;
            this.btnSimulateOnce.Click += new System.EventHandler(this.btnSimulateOnce_Click);
            // 
            // lblPplAtLvl
            // 
            this.lblPplAtLvl.AutoSize = true;
            this.lblPplAtLvl.Location = new System.Drawing.Point(415, 302);
            this.lblPplAtLvl.Name = "lblPplAtLvl";
            this.lblPplAtLvl.Size = new System.Drawing.Size(82, 13);
            this.lblPplAtLvl.TabIndex = 26;
            this.lblPplAtLvl.Text = "People At Level";
            // 
            // txtPplAtLvl
            // 
            this.txtPplAtLvl.Location = new System.Drawing.Point(615, 302);
            this.txtPplAtLvl.Name = "txtPplAtLvl";
            this.txtPplAtLvl.Size = new System.Drawing.Size(173, 20);
            this.txtPplAtLvl.TabIndex = 25;
            this.txtPplAtLvl.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(415, 328);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 28;
            this.label2.Text = "Queue Length";
            this.label2.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(615, 328);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(173, 20);
            this.textBox2.TabIndex = 27;
            this.textBox2.Text = "0";
            this.textBox2.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.lblPplAtLvl);
            this.Controls.Add(this.txtPplAtLvl);
            this.Controls.Add(this.btnSimulateOnce);
            this.Controls.Add(this.btnPause);
            this.Controls.Add(this.lblStuYetCome);
            this.Controls.Add(this.txtYet);
            this.Controls.Add(this.lblQ);
            this.Controls.Add(this.txtQ);
            this.Controls.Add(this.lblStudentNum);
            this.Controls.Add(this.txtNumStudent);
            this.Controls.Add(this.lblInitial);
            this.Controls.Add(this.txtIniState);
            this.Controls.Add(this.btnSimulate);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.lblPplInSys);
            this.Controls.Add(this.txtPplNum);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblProcTime);
            this.Controls.Add(this.txtProcTime);
            this.Controls.Add(this.lblLvlNum);
            this.Controls.Add(this.txtLvlNum);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.txtLevels);
            this.Controls.Add(this.lblArrival);
            this.Controls.Add(this.txtArrival);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtArrival;
        private System.Windows.Forms.Label lblArrival;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.TextBox txtLevels;
        private System.Windows.Forms.Label lblLvlNum;
        private System.Windows.Forms.TextBox txtLvlNum;
        private System.Windows.Forms.Label lblProcTime;
        private System.Windows.Forms.TextBox txtProcTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblPplInSys;
        private System.Windows.Forms.TextBox txtPplNum;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnSimulate;
        private System.Windows.Forms.Label lblInitial;
        private System.Windows.Forms.TextBox txtIniState;
        private System.Windows.Forms.Label lblStudentNum;
        private System.Windows.Forms.TextBox txtNumStudent;
        private System.Windows.Forms.Label lblQ;
        private System.Windows.Forms.TextBox txtQ;
        private System.Windows.Forms.Label lblStuYetCome;
        private System.Windows.Forms.TextBox txtYet;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnSimulateOnce;
        private System.Windows.Forms.Label lblPplAtLvl;
        private System.Windows.Forms.TextBox txtPplAtLvl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
    }
}

