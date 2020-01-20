namespace Sample_Connect {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.portNumber = new System.Windows.Forms.NumericUpDown();
            this.MeasureButton = new System.Windows.Forms.Button();
            this.LabeX = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxX = new System.Windows.Forms.TextBox();
            this.textBoxY = new System.Windows.Forms.TextBox();
            this.textBoxBigY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.profileList = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.profileIDNumber = new System.Windows.Forms.NumericUpDown();
            this.profileText = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.portNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileIDNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Connect";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Port Number";
            // 
            // portNumber
            // 
            this.portNumber.Location = new System.Drawing.Point(166, 16);
            this.portNumber.Name = "portNumber";
            this.portNumber.Size = new System.Drawing.Size(71, 20);
            this.portNumber.TabIndex = 2;
            // 
            // MeasureButton
            // 
            this.MeasureButton.Location = new System.Drawing.Point(13, 43);
            this.MeasureButton.Name = "MeasureButton";
            this.MeasureButton.Size = new System.Drawing.Size(75, 82);
            this.MeasureButton.TabIndex = 3;
            this.MeasureButton.Text = "Measure";
            this.MeasureButton.UseVisualStyleBackColor = true;
            this.MeasureButton.Click += new System.EventHandler(this.MeasureButton_Click);
            // 
            // LabeX
            // 
            this.LabeX.AutoSize = true;
            this.LabeX.Location = new System.Drawing.Point(93, 46);
            this.LabeX.Name = "LabeX";
            this.LabeX.Size = new System.Drawing.Size(15, 13);
            this.LabeX.TabIndex = 5;
            this.LabeX.Text = "x:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(94, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(93, 112);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Y:";
            // 
            // textBoxX
            // 
            this.textBoxX.Location = new System.Drawing.Point(117, 43);
            this.textBoxX.Name = "textBoxX";
            this.textBoxX.Size = new System.Drawing.Size(121, 20);
            this.textBoxX.TabIndex = 6;
            // 
            // textBoxY
            // 
            this.textBoxY.Location = new System.Drawing.Point(117, 73);
            this.textBoxY.Name = "textBoxY";
            this.textBoxY.Size = new System.Drawing.Size(121, 20);
            this.textBoxY.TabIndex = 6;
            // 
            // textBoxBigY
            // 
            this.textBoxBigY.Location = new System.Drawing.Point(117, 105);
            this.textBoxBigY.Name = "textBoxBigY";
            this.textBoxBigY.Size = new System.Drawing.Size(121, 20);
            this.textBoxBigY.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Profile List";
            // 
            // profileList
            // 
            this.profileList.FormattingEnabled = true;
            this.profileList.Location = new System.Drawing.Point(244, 43);
            this.profileList.Name = "profileList";
            this.profileList.Size = new System.Drawing.Size(120, 82);
            this.profileList.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(370, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Profile Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(370, 18);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Profile ID";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Set Profile ID";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // profileIDNumber
            // 
            this.profileIDNumber.Location = new System.Drawing.Point(370, 44);
            this.profileIDNumber.Name = "profileIDNumber";
            this.profileIDNumber.Size = new System.Drawing.Size(146, 20);
            this.profileIDNumber.TabIndex = 12;
            // 
            // profileText
            // 
            this.profileText.Location = new System.Drawing.Point(370, 99);
            this.profileText.Name = "profileText";
            this.profileText.Size = new System.Drawing.Size(146, 20);
            this.profileText.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(528, 131);
            this.Controls.Add(this.profileText);
            this.Controls.Add(this.profileIDNumber);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.profileList);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxBigY);
            this.Controls.Add(this.textBoxY);
            this.Controls.Add(this.textBoxX);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabeX);
            this.Controls.Add(this.MeasureButton);
            this.Controls.Add(this.portNumber);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.portNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileIDNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown portNumber;
        private System.Windows.Forms.Button MeasureButton;
        private System.Windows.Forms.Label LabeX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxX;
        private System.Windows.Forms.TextBox textBoxY;
        private System.Windows.Forms.TextBox textBoxBigY;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox profileList;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.NumericUpDown profileIDNumber;
        private System.Windows.Forms.TextBox profileText;
    }
}

