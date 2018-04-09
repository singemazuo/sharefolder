namespace WindowsFormsApp22
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
            this.btnGo = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtCriteria = new System.Windows.Forms.TextBox();
            this.Frame3 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.DateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.DateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chkFirstTimer = new System.Windows.Forms.CheckBox();
            this.cmbHut = new System.Windows.Forms.ComboBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.Label3 = new System.Windows.Forms.Label();
            this.Label2 = new System.Windows.Forms.Label();
            this.Frame2 = new System.Windows.Forms.GroupBox();
            this.Frame1 = new System.Windows.Forms.GroupBox();
            this.lstFamily = new System.Windows.Forms.ListBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtStreet = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.dgvChildren = new System.Windows.Forms.DataGridView();
            this.Frame3.SuspendLayout();
            this.Frame2.SuspendLayout();
            this.Frame1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChildren)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGo
            // 
            this.btnGo.Location = new System.Drawing.Point(451, 18);
            this.btnGo.Margin = new System.Windows.Forms.Padding(4);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(43, 30);
            this.btnGo.TabIndex = 39;
            this.btnGo.Text = "&Go";
            this.btnGo.Click += new System.EventHandler(this.ButtonGo_Click);
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(67, 18);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(192, 20);
            this.Label5.TabIndex = 43;
            this.Label5.Text = "Enter your search criteria";
            // 
            // txtCriteria
            // 
            this.txtCriteria.Location = new System.Drawing.Point(291, 18);
            this.txtCriteria.Margin = new System.Windows.Forms.Padding(4);
            this.txtCriteria.Name = "txtCriteria";
            this.txtCriteria.Size = new System.Drawing.Size(127, 22);
            this.txtCriteria.TabIndex = 38;
            // 
            // Frame3
            // 
            this.Frame3.BackColor = System.Drawing.SystemColors.Control;
            this.Frame3.Controls.Add(this.btnUpdate);
            this.Frame3.Controls.Add(this.DateTimePicker2);
            this.Frame3.Controls.Add(this.DateTimePicker1);
            this.Frame3.Controls.Add(this.chkFirstTimer);
            this.Frame3.Controls.Add(this.cmbHut);
            this.Frame3.Controls.Add(this.Label4);
            this.Frame3.Controls.Add(this.Label3);
            this.Frame3.Controls.Add(this.Label2);
            this.Frame3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame3.Location = new System.Drawing.Point(46, 314);
            this.Frame3.Margin = new System.Windows.Forms.Padding(4);
            this.Frame3.Name = "Frame3";
            this.Frame3.Padding = new System.Windows.Forms.Padding(4);
            this.Frame3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame3.Size = new System.Drawing.Size(545, 128);
            this.Frame3.TabIndex = 42;
            this.Frame3.TabStop = false;
            this.Frame3.Text = "Enter Camp Information";
            this.Frame3.Visible = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Default;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnUpdate.Location = new System.Drawing.Point(427, 81);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnUpdate.Size = new System.Drawing.Size(87, 25);
            this.btnUpdate.TabIndex = 21;
            this.btnUpdate.Text = "&Insert";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // DateTimePicker2
            // 
            this.DateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker2.Location = new System.Drawing.Point(96, 59);
            this.DateTimePicker2.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePicker2.Name = "DateTimePicker2";
            this.DateTimePicker2.Size = new System.Drawing.Size(127, 23);
            this.DateTimePicker2.TabIndex = 1;
            this.DateTimePicker2.Value = new System.DateTime(2003, 11, 29, 0, 0, 0, 0);
            // 
            // DateTimePicker1
            // 
            this.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DateTimePicker1.Location = new System.Drawing.Point(96, 30);
            this.DateTimePicker1.Margin = new System.Windows.Forms.Padding(4);
            this.DateTimePicker1.Name = "DateTimePicker1";
            this.DateTimePicker1.Size = new System.Drawing.Size(127, 23);
            this.DateTimePicker1.TabIndex = 0;
            this.DateTimePicker1.Value = new System.DateTime(2003, 11, 29, 0, 0, 0, 0);
            // 
            // chkFirstTimer
            // 
            this.chkFirstTimer.BackColor = System.Drawing.SystemColors.Control;
            this.chkFirstTimer.Cursor = System.Windows.Forms.Cursors.Default;
            this.chkFirstTimer.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkFirstTimer.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkFirstTimer.Location = new System.Drawing.Point(288, 59);
            this.chkFirstTimer.Margin = new System.Windows.Forms.Padding(4);
            this.chkFirstTimer.Name = "chkFirstTimer";
            this.chkFirstTimer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.chkFirstTimer.Size = new System.Drawing.Size(119, 21);
            this.chkFirstTimer.TabIndex = 3;
            this.chkFirstTimer.Text = "First Timer";
            this.chkFirstTimer.UseVisualStyleBackColor = false;
            // 
            // cmbHut
            // 
            this.cmbHut.BackColor = System.Drawing.SystemColors.Window;
            this.cmbHut.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbHut.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbHut.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmbHut.Location = new System.Drawing.Point(384, 30);
            this.cmbHut.Margin = new System.Windows.Forms.Padding(4);
            this.cmbHut.Name = "cmbHut";
            this.cmbHut.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cmbHut.Size = new System.Drawing.Size(128, 24);
            this.cmbHut.TabIndex = 2;
            // 
            // Label4
            // 
            this.Label4.BackColor = System.Drawing.SystemColors.Control;
            this.Label4.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label4.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label4.Location = new System.Drawing.Point(256, 30);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label4.Size = new System.Drawing.Size(108, 21);
            this.Label4.TabIndex = 20;
            this.Label4.Text = "Hut Information";
            // 
            // Label3
            // 
            this.Label3.BackColor = System.Drawing.SystemColors.Control;
            this.Label3.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label3.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label3.Location = new System.Drawing.Point(11, 59);
            this.Label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label3.Name = "Label3";
            this.Label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label3.Size = new System.Drawing.Size(76, 21);
            this.Label3.TabIndex = 19;
            this.Label3.Text = "Departure";
            // 
            // Label2
            // 
            this.Label2.BackColor = System.Drawing.SystemColors.Control;
            this.Label2.Cursor = System.Windows.Forms.Cursors.Default;
            this.Label2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Label2.Location = new System.Drawing.Point(11, 30);
            this.Label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label2.Name = "Label2";
            this.Label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Label2.Size = new System.Drawing.Size(65, 21);
            this.Label2.TabIndex = 18;
            this.Label2.Text = "Arrival";
            // 
            // Frame2
            // 
            this.Frame2.BackColor = System.Drawing.SystemColors.Control;
            this.Frame2.Controls.Add(this.dgvChildren);
            this.Frame2.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame2.Location = new System.Drawing.Point(125, 184);
            this.Frame2.Margin = new System.Windows.Forms.Padding(4);
            this.Frame2.Name = "Frame2";
            this.Frame2.Padding = new System.Windows.Forms.Padding(4);
            this.Frame2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame2.Size = new System.Drawing.Size(381, 120);
            this.Frame2.TabIndex = 41;
            this.Frame2.TabStop = false;
            this.Frame2.Text = "Select a Child";
            this.Frame2.Visible = false;
            // 
            // Frame1
            // 
            this.Frame1.BackColor = System.Drawing.SystemColors.Control;
            this.Frame1.Controls.Add(this.lstFamily);
            this.Frame1.Controls.Add(this.txtCity);
            this.Frame1.Controls.Add(this.txtStreet);
            this.Frame1.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Frame1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Frame1.Location = new System.Drawing.Point(70, 58);
            this.Frame1.Margin = new System.Windows.Forms.Padding(4);
            this.Frame1.Name = "Frame1";
            this.Frame1.Padding = new System.Windows.Forms.Padding(4);
            this.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Frame1.Size = new System.Drawing.Size(488, 118);
            this.Frame1.TabIndex = 40;
            this.Frame1.TabStop = false;
            this.Frame1.Text = "Select a Family";
            this.Frame1.Visible = false;
            // 
            // lstFamily
            // 
            this.lstFamily.ItemHeight = 16;
            this.lstFamily.Location = new System.Drawing.Point(28, 30);
            this.lstFamily.Margin = new System.Windows.Forms.Padding(4);
            this.lstFamily.Name = "lstFamily";
            this.lstFamily.Size = new System.Drawing.Size(185, 68);
            this.lstFamily.TabIndex = 0;
            this.lstFamily.SelectedValueChanged += new System.EventHandler(this.Family_SelectedValueChanged);
            // 
            // txtCity
            // 
            this.txtCity.AcceptsReturn = true;
            this.txtCity.BackColor = System.Drawing.SystemColors.Window;
            this.txtCity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCity.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtCity.Location = new System.Drawing.Point(245, 59);
            this.txtCity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCity.MaxLength = 0;
            this.txtCity.Name = "txtCity";
            this.txtCity.ReadOnly = true;
            this.txtCity.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCity.Size = new System.Drawing.Size(213, 23);
            this.txtCity.TabIndex = 2;
            // 
            // txtStreet
            // 
            this.txtStreet.AcceptsReturn = true;
            this.txtStreet.BackColor = System.Drawing.SystemColors.Window;
            this.txtStreet.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStreet.Font = new System.Drawing.Font("Arial", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtStreet.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtStreet.Location = new System.Drawing.Point(245, 30);
            this.txtStreet.Margin = new System.Windows.Forms.Padding(4);
            this.txtStreet.MaxLength = 0;
            this.txtStreet.Name = "txtStreet";
            this.txtStreet.ReadOnly = true;
            this.txtStreet.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtStreet.Size = new System.Drawing.Size(213, 23);
            this.txtStreet.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.Location = new System.Drawing.Point(259, 215);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(256, 30);
            this.Label1.TabIndex = 44;
            this.Label1.Text = "No children";
            this.Label1.Visible = false;
            // 
            // dgvChildren
            // 
            this.dgvChildren.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvChildren.Location = new System.Drawing.Point(25, 27);
            this.dgvChildren.Name = "dgvChildren";
            this.dgvChildren.RowTemplate.Height = 24;
            this.dgvChildren.Size = new System.Drawing.Size(330, 79);
            this.dgvChildren.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 460);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtCriteria);
            this.Controls.Add(this.Frame3);
            this.Controls.Add(this.Frame2);
            this.Controls.Add(this.Frame1);
            this.Controls.Add(this.Label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Frame3.ResumeLayout(false);
            this.Frame2.ResumeLayout(false);
            this.Frame1.ResumeLayout(false);
            this.Frame1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvChildren)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnGo;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtCriteria;
        public System.Windows.Forms.GroupBox Frame3;
        public System.Windows.Forms.Button btnUpdate;
        internal System.Windows.Forms.DateTimePicker DateTimePicker2;
        internal System.Windows.Forms.DateTimePicker DateTimePicker1;
        public System.Windows.Forms.CheckBox chkFirstTimer;
        public System.Windows.Forms.ComboBox cmbHut;
        public System.Windows.Forms.Label Label4;
        public System.Windows.Forms.Label Label3;
        public System.Windows.Forms.Label Label2;
        public System.Windows.Forms.GroupBox Frame2;
        public System.Windows.Forms.GroupBox Frame1;
        internal System.Windows.Forms.ListBox lstFamily;
        public System.Windows.Forms.TextBox txtCity;
        public System.Windows.Forms.TextBox txtStreet;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.DataGridView dgvChildren;
    }
}

