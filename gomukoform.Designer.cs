namespace gomukofinalcs
{
    partial class gomuko
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.wincounttext = new System.Windows.Forms.Label();
            this.wincount = new System.Windows.Forms.TextBox();
            this.startbutton = new System.Windows.Forms.Button();
            this.optionselect = new System.Windows.Forms.Label();
            this.threexthree = new System.Windows.Forms.RadioButton();
            this.fivexfive = new System.Windows.Forms.RadioButton();
            this.tenxten = new System.Windows.Forms.RadioButton();
            this.cellspanel = new System.Windows.Forms.FlowLayoutPanel();
            this.customdimension = new System.Windows.Forms.TextBox();
            this.cdim = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cdim);
            this.panel1.Controls.Add(this.customdimension);
            this.panel1.Controls.Add(this.wincounttext);
            this.panel1.Controls.Add(this.wincount);
            this.panel1.Controls.Add(this.startbutton);
            this.panel1.Controls.Add(this.optionselect);
            this.panel1.Controls.Add(this.threexthree);
            this.panel1.Controls.Add(this.fivexfive);
            this.panel1.Controls.Add(this.tenxten);
            this.panel1.Location = new System.Drawing.Point(93, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(488, 87);
            this.panel1.TabIndex = 4;
            // 
            // wincounttext
            // 
            this.wincounttext.AutoSize = true;
            this.wincounttext.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wincounttext.Location = new System.Drawing.Point(20, 60);
            this.wincounttext.Name = "wincounttext";
            this.wincounttext.Size = new System.Drawing.Size(76, 20);
            this.wincounttext.TabIndex = 6;
            this.wincounttext.Text = "win count";
            // 
            // wincount
            // 
            this.wincount.Location = new System.Drawing.Point(101, 58);
            this.wincount.Name = "wincount";
            this.wincount.Size = new System.Drawing.Size(104, 20);
            this.wincount.TabIndex = 0;
            // 
            // startbutton
            // 
            this.startbutton.Location = new System.Drawing.Point(339, 57);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(109, 29);
            this.startbutton.TabIndex = 4;
            this.startbutton.Text = "start";
            this.startbutton.UseVisualStyleBackColor = true;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // optionselect
            // 
            this.optionselect.AutoSize = true;
            this.optionselect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.optionselect.Location = new System.Drawing.Point(56, 12);
            this.optionselect.Name = "optionselect";
            this.optionselect.Size = new System.Drawing.Size(99, 20);
            this.optionselect.TabIndex = 3;
            this.optionselect.Text = "select option";
            // 
            // threexthree
            // 
            this.threexthree.AutoSize = true;
            this.threexthree.Location = new System.Drawing.Point(196, 31);
            this.threexthree.Name = "threexthree";
            this.threexthree.Size = new System.Drawing.Size(42, 17);
            this.threexthree.TabIndex = 6;
            this.threexthree.TabStop = true;
            this.threexthree.Text = "3x3";
            this.threexthree.UseVisualStyleBackColor = true;
            // 
            // fivexfive
            // 
            this.fivexfive.AutoSize = true;
            this.fivexfive.Location = new System.Drawing.Point(25, 31);
            this.fivexfive.Name = "fivexfive";
            this.fivexfive.Size = new System.Drawing.Size(42, 17);
            this.fivexfive.TabIndex = 0;
            this.fivexfive.TabStop = true;
            this.fivexfive.Text = "5x5";
            this.fivexfive.UseVisualStyleBackColor = true;
            // 
            // tenxten
            // 
            this.tenxten.AutoSize = true;
            this.tenxten.Location = new System.Drawing.Point(395, 31);
            this.tenxten.Name = "tenxten";
            this.tenxten.Size = new System.Drawing.Size(54, 17);
            this.tenxten.TabIndex = 1;
            this.tenxten.TabStop = true;
            this.tenxten.Text = "10x10";
            this.tenxten.UseVisualStyleBackColor = true;
            // 
            // cellspanel
            // 
            this.cellspanel.Location = new System.Drawing.Point(94, 120);
            this.cellspanel.Name = "cellspanel";
            this.cellspanel.Size = new System.Drawing.Size(487, 245);
            this.cellspanel.TabIndex = 5;
            // 
            // customdimension
            // 
            this.customdimension.Location = new System.Drawing.Point(224, 58);
            this.customdimension.Name = "customdimension";
            this.customdimension.Size = new System.Drawing.Size(100, 20);
            this.customdimension.TabIndex = 7;
            // 
            // cdim
            // 
            this.cdim.AutoSize = true;
            this.cdim.Location = new System.Drawing.Point(244, 42);
            this.cdim.Name = "cdim";
            this.cdim.Size = new System.Drawing.Size(91, 13);
            this.cdim.TabIndex = 8;
            this.cdim.Text = "custom dimension";
            // 
            // gomuko
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cellspanel);
            this.Controls.Add(this.panel1);
            this.Name = "gomuko";
            this.Text = "gomuko";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label wincounttext;
        private System.Windows.Forms.TextBox wincount;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label optionselect;
        private System.Windows.Forms.RadioButton threexthree;
        private System.Windows.Forms.RadioButton fivexfive;
        private System.Windows.Forms.RadioButton tenxten;
        private System.Windows.Forms.FlowLayoutPanel cellspanel;
        private System.Windows.Forms.Label cdim;
        private System.Windows.Forms.TextBox customdimension;
    }
}

