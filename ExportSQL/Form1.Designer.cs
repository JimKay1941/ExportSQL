namespace ExportSQL
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
            this.OutputFullFarEastName = new System.Windows.Forms.TextBox();
            this.OutputCharBopoName = new System.Windows.Forms.TextBox();
            this.OutputPinBopoName = new System.Windows.Forms.TextBox();
            this.OutputPinMypinName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.radioBAX2ZAONV6 = new System.Windows.Forms.RadioButton();
            this.radioAMAZON1 = new System.Windows.Forms.RadioButton();
            this.radioACER0 = new System.Windows.Forms.RadioButton();
            this.grpSelectServer = new System.Windows.Forms.GroupBox();
            this.button7 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.OutputCeDictName = new System.Windows.Forms.TextBox();
            this.chkFullFarEast = new System.Windows.Forms.CheckBox();
            this.chkCharBopo = new System.Windows.Forms.CheckBox();
            this.chkPinBopo = new System.Windows.Forms.CheckBox();
            this.chkPinMypin = new System.Windows.Forms.CheckBox();
            this.chkCeDict = new System.Windows.Forms.CheckBox();
            this.chk_3000_ = new System.Windows.Forms.CheckBox();
            this.button8 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.Output_3000_Name = new System.Windows.Forms.TextBox();
            this.grpSelectServer.SuspendLayout();
            this.SuspendLayout();
            // 
            // OutputFullFarEastName
            // 
            this.OutputFullFarEastName.Location = new System.Drawing.Point(181, 17);
            this.OutputFullFarEastName.Name = "OutputFullFarEastName";
            this.OutputFullFarEastName.Size = new System.Drawing.Size(612, 20);
            this.OutputFullFarEastName.TabIndex = 0;
            this.OutputFullFarEastName.Text = "C:\\Users\\darkd\\Downloads\\Chinese Pod\\FOLDER\\FullFarEast.csv";
            // 
            // OutputCharBopoName
            // 
            this.OutputCharBopoName.Location = new System.Drawing.Point(181, 43);
            this.OutputCharBopoName.Name = "OutputCharBopoName";
            this.OutputCharBopoName.Size = new System.Drawing.Size(612, 20);
            this.OutputCharBopoName.TabIndex = 1;
            this.OutputCharBopoName.Text = "C:\\Users\\darkd\\Downloads\\Chinese Pod\\FOLDER\\CharBopo.csv";
            // 
            // OutputPinBopoName
            // 
            this.OutputPinBopoName.Location = new System.Drawing.Point(181, 69);
            this.OutputPinBopoName.Name = "OutputPinBopoName";
            this.OutputPinBopoName.Size = new System.Drawing.Size(612, 20);
            this.OutputPinBopoName.TabIndex = 2;
            this.OutputPinBopoName.Text = "C:\\Users\\darkd\\Downloads\\Chinese Pod\\FOLDER\\PinBopo.csv";
            // 
            // OutputPinMypinName
            // 
            this.OutputPinMypinName.Location = new System.Drawing.Point(181, 95);
            this.OutputPinMypinName.Name = "OutputPinMypinName";
            this.OutputPinMypinName.Size = new System.Drawing.Size(612, 20);
            this.OutputPinMypinName.TabIndex = 3;
            this.OutputPinMypinName.Text = "C:\\Users\\darkd\\Downloads\\Chinese Pod\\FOLDER\\PinMypin.csv";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "FullFarEast";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(98, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "CharBopo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "PinBopo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(98, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "PinMypin";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(10, 15);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 22);
            this.button1.TabIndex = 8;
            this.button1.Text = "Choose";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ChooseFullFareast_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(10, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 22);
            this.button2.TabIndex = 9;
            this.button2.Text = "Choose";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ChooseCharBopo_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(10, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 22);
            this.button3.TabIndex = 10;
            this.button3.Text = "Choose";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ChoosePinBopo_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(10, 93);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(82, 22);
            this.button4.TabIndex = 11;
            this.button4.Text = "Choose";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.ChoosePinMypin_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(10, 216);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(131, 49);
            this.button5.TabIndex = 12;
            this.button5.Text = "Run";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(165, 216);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(131, 49);
            this.button6.TabIndex = 13;
            this.button6.Text = "Exit";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // radioBAX2ZAONV6
            // 
            this.radioBAX2ZAONV6.AutoSize = true;
            this.radioBAX2ZAONV6.Location = new System.Drawing.Point(6, 28);
            this.radioBAX2ZAONV6.Name = "radioBAX2ZAONV6";
            this.radioBAX2ZAONV6.Size = new System.Drawing.Size(136, 17);
            this.radioBAX2ZAONV6.TabIndex = 14;
            this.radioBAX2ZAONV6.Text = "Azure Server Cambodia";
            this.radioBAX2ZAONV6.UseVisualStyleBackColor = true;
            // 
            // radioAMAZON1
            // 
            this.radioAMAZON1.AutoSize = true;
            this.radioAMAZON1.Location = new System.Drawing.Point(6, 51);
            this.radioAMAZON1.Name = "radioAMAZON1";
            this.radioAMAZON1.Size = new System.Drawing.Size(140, 17);
            this.radioAMAZON1.TabIndex = 15;
            this.radioAMAZON1.Text = "AWS Northern California";
            this.radioAMAZON1.UseVisualStyleBackColor = true;
            // 
            // radioACER0
            // 
            this.radioACER0.AutoSize = true;
            this.radioACER0.Checked = true;
            this.radioACER0.Location = new System.Drawing.Point(6, 74);
            this.radioACER0.Name = "radioACER0";
            this.radioACER0.Size = new System.Drawing.Size(149, 17);
            this.radioACER0.TabIndex = 16;
            this.radioACER0.TabStop = true;
            this.radioACER0.Text = "Local Workstation ACER0";
            this.radioACER0.UseVisualStyleBackColor = true;
            // 
            // grpSelectServer
            // 
            this.grpSelectServer.Controls.Add(this.radioAMAZON1);
            this.grpSelectServer.Controls.Add(this.radioACER0);
            this.grpSelectServer.Controls.Add(this.radioBAX2ZAONV6);
            this.grpSelectServer.Location = new System.Drawing.Point(10, 271);
            this.grpSelectServer.Name = "grpSelectServer";
            this.grpSelectServer.Size = new System.Drawing.Size(200, 100);
            this.grpSelectServer.TabIndex = 17;
            this.grpSelectServer.TabStop = false;
            this.grpSelectServer.Text = "Select SQL Server to Export From";
            this.grpSelectServer.Enter += new System.EventHandler(this.grpSelectServer_Enter);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(10, 120);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(82, 22);
            this.button7.TabIndex = 20;
            this.button7.Text = "Choose";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.ChooseCeDict_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(98, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "CeDict";
            // 
            // OutputCeDictName
            // 
            this.OutputCeDictName.Location = new System.Drawing.Point(181, 122);
            this.OutputCeDictName.Name = "OutputCeDictName";
            this.OutputCeDictName.Size = new System.Drawing.Size(612, 20);
            this.OutputCeDictName.TabIndex = 18;
            this.OutputCeDictName.Text = "C:\\Users\\darkd\\Downloads\\Chinese Pod\\FOLDER\\CeDict.csv";
            // 
            // chkFullFarEast
            // 
            this.chkFullFarEast.AutoSize = true;
            this.chkFullFarEast.Location = new System.Drawing.Point(160, 20);
            this.chkFullFarEast.Name = "chkFullFarEast";
            this.chkFullFarEast.Size = new System.Drawing.Size(15, 14);
            this.chkFullFarEast.TabIndex = 21;
            this.chkFullFarEast.UseVisualStyleBackColor = true;
            // 
            // chkCharBopo
            // 
            this.chkCharBopo.AutoSize = true;
            this.chkCharBopo.Location = new System.Drawing.Point(160, 46);
            this.chkCharBopo.Name = "chkCharBopo";
            this.chkCharBopo.Size = new System.Drawing.Size(15, 14);
            this.chkCharBopo.TabIndex = 22;
            this.chkCharBopo.UseVisualStyleBackColor = true;
            // 
            // chkPinBopo
            // 
            this.chkPinBopo.AutoSize = true;
            this.chkPinBopo.Location = new System.Drawing.Point(160, 72);
            this.chkPinBopo.Name = "chkPinBopo";
            this.chkPinBopo.Size = new System.Drawing.Size(15, 14);
            this.chkPinBopo.TabIndex = 23;
            this.chkPinBopo.UseVisualStyleBackColor = true;
            // 
            // chkPinMypin
            // 
            this.chkPinMypin.AutoSize = true;
            this.chkPinMypin.Location = new System.Drawing.Point(160, 98);
            this.chkPinMypin.Name = "chkPinMypin";
            this.chkPinMypin.Size = new System.Drawing.Size(15, 14);
            this.chkPinMypin.TabIndex = 24;
            this.chkPinMypin.UseVisualStyleBackColor = true;
            // 
            // chkCeDict
            // 
            this.chkCeDict.AutoSize = true;
            this.chkCeDict.Location = new System.Drawing.Point(160, 125);
            this.chkCeDict.Name = "chkCeDict";
            this.chkCeDict.Size = new System.Drawing.Size(15, 14);
            this.chkCeDict.TabIndex = 25;
            this.chkCeDict.UseVisualStyleBackColor = true;
            // 
            // chk_3000_
            // 
            this.chk_3000_.AutoSize = true;
            this.chk_3000_.Location = new System.Drawing.Point(160, 153);
            this.chk_3000_.Name = "chk_3000_";
            this.chk_3000_.Size = new System.Drawing.Size(15, 14);
            this.chk_3000_.TabIndex = 29;
            this.chk_3000_.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(10, 148);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(82, 22);
            this.button8.TabIndex = 28;
            this.button8.Text = "Choose";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.Choose_3000);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(98, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 27;
            this.label6.Text = "3000";
            // 
            // Output_3000_Name
            // 
            this.Output_3000_Name.Location = new System.Drawing.Point(181, 150);
            this.Output_3000_Name.Name = "Output_3000_Name";
            this.Output_3000_Name.Size = new System.Drawing.Size(612, 20);
            this.Output_3000_Name.TabIndex = 26;
            this.Output_3000_Name.Text = "C:\\Users\\darkd\\Downloads\\Chinese Pod\\FOLDER\\_3000_.csv";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 383);
            this.Controls.Add(this.chk_3000_);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Output_3000_Name);
            this.Controls.Add(this.chkCeDict);
            this.Controls.Add(this.chkPinMypin);
            this.Controls.Add(this.chkPinBopo);
            this.Controls.Add(this.chkCharBopo);
            this.Controls.Add(this.chkFullFarEast);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.OutputCeDictName);
            this.Controls.Add(this.grpSelectServer);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.OutputPinMypinName);
            this.Controls.Add(this.OutputPinBopoName);
            this.Controls.Add(this.OutputCharBopoName);
            this.Controls.Add(this.OutputFullFarEastName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpSelectServer.ResumeLayout(false);
            this.grpSelectServer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox OutputFullFarEastName;
        private System.Windows.Forms.TextBox OutputCharBopoName;
        private System.Windows.Forms.TextBox OutputPinBopoName;
        private System.Windows.Forms.TextBox OutputPinMypinName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RadioButton radioBAX2ZAONV6;
        private System.Windows.Forms.RadioButton radioAMAZON1;
        private System.Windows.Forms.RadioButton radioACER0;
        private System.Windows.Forms.GroupBox grpSelectServer;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox OutputCeDictName;
        private System.Windows.Forms.CheckBox chkFullFarEast;
        private System.Windows.Forms.CheckBox chkCharBopo;
        private System.Windows.Forms.CheckBox chkPinBopo;
        private System.Windows.Forms.CheckBox chkPinMypin;
        private System.Windows.Forms.CheckBox chkCeDict;
        private System.Windows.Forms.CheckBox chk_3000_;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Output_3000_Name;
    }
}

