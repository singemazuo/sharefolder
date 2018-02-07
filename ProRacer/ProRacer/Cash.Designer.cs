namespace ProRacer
{
    partial class Cash
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
            this.lstRace = new System.Windows.Forms.ListBox();
            this.lstParticipants = new System.Windows.Forms.ListBox();
            this.lblCash = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstRace
            // 
            this.lstRace.FormattingEnabled = true;
            this.lstRace.ItemHeight = 16;
            this.lstRace.Location = new System.Drawing.Point(14, 22);
            this.lstRace.Name = "lstRace";
            this.lstRace.Size = new System.Drawing.Size(166, 116);
            this.lstRace.TabIndex = 0;
            // 
            // lstParticipants
            // 
            this.lstParticipants.FormattingEnabled = true;
            this.lstParticipants.ItemHeight = 16;
            this.lstParticipants.Location = new System.Drawing.Point(248, 41);
            this.lstParticipants.Name = "lstParticipants";
            this.lstParticipants.Size = new System.Drawing.Size(158, 116);
            this.lstParticipants.TabIndex = 1;
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Location = new System.Drawing.Point(188, 194);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(46, 17);
            this.lblCash.TabIndex = 2;
            this.lblCash.Text = "label1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstRace);
            this.groupBox1.Location = new System.Drawing.Point(21, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 156);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select a Sponsor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 194);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cash won";
            // 
            // Cash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 259);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.lstParticipants);
            this.Name = "Cash";
            this.Text = "Cash Won";
            this.Load += new System.EventHandler(this.Cash_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstRace;
        private System.Windows.Forms.ListBox lstParticipants;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
    }
}