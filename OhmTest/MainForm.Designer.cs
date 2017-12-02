namespace OhmTest
{
    partial class MainForm
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
            this.cmbSerial = new System.Windows.Forms.ComboBox();
            this.lblCmbPort = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.chkConnect = new System.Windows.Forms.CheckBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.txtVolt = new System.Windows.Forms.TextBox();
            this.voltmetro = new System.Windows.Forms.AGauge();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAmpere = new System.Windows.Forms.TextBox();
            this.amperometro = new System.Windows.Forms.AGauge();
            this.txtOhm = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.mainSwitch = new System.Windows.Forms.PictureBox();
            this.wire1 = new System.Windows.Forms.PictureBox();
            this.wire2 = new System.Windows.Forms.PictureBox();
            this.wire3 = new System.Windows.Forms.PictureBox();
            this.wire4 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.wire6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSwitch)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wire1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wire2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wire3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wire4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wire6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbSerial
            // 
            this.cmbSerial.FormattingEnabled = true;
            this.cmbSerial.Location = new System.Drawing.Point(12, 36);
            this.cmbSerial.Name = "cmbSerial";
            this.cmbSerial.Size = new System.Drawing.Size(143, 21);
            this.cmbSerial.TabIndex = 0;
            // 
            // lblCmbPort
            // 
            this.lblCmbPort.AutoSize = true;
            this.lblCmbPort.Location = new System.Drawing.Point(9, 20);
            this.lblCmbPort.Name = "lblCmbPort";
            this.lblCmbPort.Size = new System.Drawing.Size(32, 13);
            this.lblCmbPort.TabIndex = 1;
            this.lblCmbPort.Text = "Porta";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(172, 36);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(117, 20);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connetti";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // chkConnect
            // 
            this.chkConnect.AutoSize = true;
            this.chkConnect.Enabled = false;
            this.chkConnect.Location = new System.Drawing.Point(172, 11);
            this.chkConnect.Name = "chkConnect";
            this.chkConnect.Size = new System.Drawing.Size(117, 17);
            this.chkConnect.TabIndex = 3;
            this.chkConnect.Text = "Connessione Attiva";
            this.chkConnect.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(451, 36);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(115, 20);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(451, 11);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(50, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Pin 1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Visible = false;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(516, 11);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(50, 17);
            this.checkBox2.TabIndex = 6;
            this.checkBox2.Text = "Pin 2";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.Visible = false;
            // 
            // txtVolt
            // 
            this.txtVolt.Location = new System.Drawing.Point(224, 265);
            this.txtVolt.Name = "txtVolt";
            this.txtVolt.Size = new System.Drawing.Size(54, 20);
            this.txtVolt.TabIndex = 7;
            this.txtVolt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // voltmetro
            // 
            this.voltmetro.BaseArcColor = System.Drawing.SystemColors.Highlight;
            this.voltmetro.BaseArcRadius = 60;
            this.voltmetro.BaseArcStart = 135;
            this.voltmetro.BaseArcSweep = 270;
            this.voltmetro.BaseArcWidth = 2;
            this.voltmetro.Center = new System.Drawing.Point(80, 80);
            this.voltmetro.Location = new System.Drawing.Point(172, 141);
            this.voltmetro.MaxValue = 5F;
            this.voltmetro.MinValue = 0F;
            this.voltmetro.Name = "voltmetro";
            this.voltmetro.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.voltmetro.NeedleColor2 = System.Drawing.Color.DimGray;
            this.voltmetro.NeedleRadius = 60;
            this.voltmetro.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.voltmetro.NeedleWidth = 2;
            this.voltmetro.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.voltmetro.ScaleLinesInterInnerRadius = 55;
            this.voltmetro.ScaleLinesInterOuterRadius = 60;
            this.voltmetro.ScaleLinesInterWidth = 1;
            this.voltmetro.ScaleLinesMajorColor = System.Drawing.SystemColors.Highlight;
            this.voltmetro.ScaleLinesMajorInnerRadius = 50;
            this.voltmetro.ScaleLinesMajorOuterRadius = 60;
            this.voltmetro.ScaleLinesMajorStepValue = 0.5F;
            this.voltmetro.ScaleLinesMajorWidth = 2;
            this.voltmetro.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.voltmetro.ScaleLinesMinorInnerRadius = 53;
            this.voltmetro.ScaleLinesMinorOuterRadius = 60;
            this.voltmetro.ScaleLinesMinorTicks = 4;
            this.voltmetro.ScaleLinesMinorWidth = 1;
            this.voltmetro.ScaleNumbersColor = System.Drawing.Color.Black;
            this.voltmetro.ScaleNumbersFormat = null;
            this.voltmetro.ScaleNumbersRadius = 70;
            this.voltmetro.ScaleNumbersRotation = 0;
            this.voltmetro.ScaleNumbersStartScaleLine = 0;
            this.voltmetro.ScaleNumbersStepScaleLines = 1;
            this.voltmetro.Size = new System.Drawing.Size(161, 144);
            this.voltmetro.TabIndex = 8;
            this.voltmetro.Text = "aGauge1";
            this.voltmetro.Value = 0F;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(243, 242);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "V";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(455, 242);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "mA";
            // 
            // txtAmpere
            // 
            this.txtAmpere.Location = new System.Drawing.Point(444, 265);
            this.txtAmpere.Name = "txtAmpere";
            this.txtAmpere.Size = new System.Drawing.Size(54, 20);
            this.txtAmpere.TabIndex = 10;
            this.txtAmpere.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // amperometro
            // 
            this.amperometro.BaseArcColor = System.Drawing.Color.Red;
            this.amperometro.BaseArcRadius = 60;
            this.amperometro.BaseArcStart = 135;
            this.amperometro.BaseArcSweep = 270;
            this.amperometro.BaseArcWidth = 2;
            this.amperometro.Center = new System.Drawing.Point(80, 80);
            this.amperometro.Location = new System.Drawing.Point(392, 141);
            this.amperometro.MaxValue = 5F;
            this.amperometro.MinValue = 0F;
            this.amperometro.Name = "amperometro";
            this.amperometro.NeedleColor1 = System.Windows.Forms.AGaugeNeedleColor.Gray;
            this.amperometro.NeedleColor2 = System.Drawing.Color.DimGray;
            this.amperometro.NeedleRadius = 60;
            this.amperometro.NeedleType = System.Windows.Forms.NeedleType.Advance;
            this.amperometro.NeedleWidth = 2;
            this.amperometro.ScaleLinesInterColor = System.Drawing.Color.Black;
            this.amperometro.ScaleLinesInterInnerRadius = 55;
            this.amperometro.ScaleLinesInterOuterRadius = 60;
            this.amperometro.ScaleLinesInterWidth = 1;
            this.amperometro.ScaleLinesMajorColor = System.Drawing.Color.Red;
            this.amperometro.ScaleLinesMajorInnerRadius = 50;
            this.amperometro.ScaleLinesMajorOuterRadius = 60;
            this.amperometro.ScaleLinesMajorStepValue = 0.5F;
            this.amperometro.ScaleLinesMajorWidth = 2;
            this.amperometro.ScaleLinesMinorColor = System.Drawing.Color.Gray;
            this.amperometro.ScaleLinesMinorInnerRadius = 53;
            this.amperometro.ScaleLinesMinorOuterRadius = 60;
            this.amperometro.ScaleLinesMinorTicks = 4;
            this.amperometro.ScaleLinesMinorWidth = 1;
            this.amperometro.ScaleNumbersColor = System.Drawing.Color.Black;
            this.amperometro.ScaleNumbersFormat = null;
            this.amperometro.ScaleNumbersRadius = 70;
            this.amperometro.ScaleNumbersRotation = 0;
            this.amperometro.ScaleNumbersStartScaleLine = 0;
            this.amperometro.ScaleNumbersStepScaleLines = 1;
            this.amperometro.Size = new System.Drawing.Size(161, 144);
            this.amperometro.TabIndex = 11;
            this.amperometro.Text = "aGauge1";
            this.amperometro.Value = 0F;
            // 
            // txtOhm
            // 
            this.txtOhm.Location = new System.Drawing.Point(121, 104);
            this.txtOhm.Name = "txtOhm";
            this.txtOhm.Size = new System.Drawing.Size(49, 20);
            this.txtOhm.TabIndex = 13;
            this.txtOhm.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::OhmTest.Properties.Resources.batteria;
            this.pictureBox3.Location = new System.Drawing.Point(12, 221);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(88, 142);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 16;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::OhmTest.Properties.Resources.resistenza_1000;
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(247, 92);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(230, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::OhmTest.Properties.Resources.resistenza_neutra;
            this.pictureBox2.InitialImage = null;
            this.pictureBox2.Location = new System.Drawing.Point(39, 92);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(213, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 15;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 247);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 20);
            this.label3.TabIndex = 17;
            this.label3.Text = "5V";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(135, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Ω";
            // 
            // mainSwitch
            // 
            this.mainSwitch.Image = global::OhmTest.Properties.Resources.interruttore_off;
            this.mainSwitch.Location = new System.Drawing.Point(12, 141);
            this.mainSwitch.Name = "mainSwitch";
            this.mainSwitch.Size = new System.Drawing.Size(53, 54);
            this.mainSwitch.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.mainSwitch.TabIndex = 24;
            this.mainSwitch.TabStop = false;
            this.mainSwitch.Click += new System.EventHandler(this.mainSwitch_Click);
            // 
            // wire1
            // 
            this.wire1.Image = global::OhmTest.Properties.Resources.wire_vert;
            this.wire1.Location = new System.Drawing.Point(474, 116);
            this.wire1.Name = "wire1";
            this.wire1.Size = new System.Drawing.Size(4, 206);
            this.wire1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wire1.TabIndex = 25;
            this.wire1.TabStop = false;
            // 
            // wire2
            // 
            this.wire2.Image = global::OhmTest.Properties.Resources.wire_vert;
            this.wire2.Location = new System.Drawing.Point(252, 116);
            this.wire2.Name = "wire2";
            this.wire2.Size = new System.Drawing.Size(4, 206);
            this.wire2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wire2.TabIndex = 26;
            this.wire2.TabStop = false;
            // 
            // wire3
            // 
            this.wire3.Image = global::OhmTest.Properties.Resources.wire_vert;
            this.wire3.Location = new System.Drawing.Point(38, 116);
            this.wire3.Name = "wire3";
            this.wire3.Size = new System.Drawing.Size(4, 206);
            this.wire3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wire3.TabIndex = 27;
            this.wire3.TabStop = false;
            // 
            // wire4
            // 
            this.wire4.Image = global::OhmTest.Properties.Resources.wire_vert;
            this.wire4.Location = new System.Drawing.Point(128, 206);
            this.wire4.Name = "wire4";
            this.wire4.Size = new System.Drawing.Size(4, 116);
            this.wire4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wire4.TabIndex = 28;
            this.wire4.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::OhmTest.Properties.Resources.wire_vert;
            this.pictureBox4.Location = new System.Drawing.Point(73, 206);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(4, 116);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 29;
            this.pictureBox4.TabStop = false;
            // 
            // wire6
            // 
            this.wire6.Image = global::OhmTest.Properties.Resources.wire_or;
            this.wire6.Location = new System.Drawing.Point(128, 322);
            this.wire6.Name = "wire6";
            this.wire6.Size = new System.Drawing.Size(350, 4);
            this.wire6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.wire6.TabIndex = 30;
            this.wire6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::OhmTest.Properties.Resources.wire_or;
            this.pictureBox5.Location = new System.Drawing.Point(75, 203);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(56, 4);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 31;
            this.pictureBox5.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 375);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.wire6);
            this.Controls.Add(this.wire4);
            this.Controls.Add(this.mainSwitch);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.txtOhm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtAmpere);
            this.Controls.Add(this.amperometro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVolt);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.chkConnect);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblCmbPort);
            this.Controls.Add(this.cmbSerial);
            this.Controls.Add(this.voltmetro);
            this.Controls.Add(this.wire1);
            this.Controls.Add(this.wire2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.wire3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox4);
            this.Name = "MainForm";
            this.Text = "Ohm Test wirh Arduino";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainSwitch)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wire1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wire2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wire3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wire4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wire6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbSerial;
        private System.Windows.Forms.Label lblCmbPort;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.CheckBox chkConnect;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox txtVolt;
        private System.Windows.Forms.AGauge voltmetro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmpere;
        private System.Windows.Forms.AGauge amperometro;
        private System.Windows.Forms.TextBox txtOhm;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox mainSwitch;
        private System.Windows.Forms.PictureBox wire1;
        private System.Windows.Forms.PictureBox wire2;
        private System.Windows.Forms.PictureBox wire3;
        private System.Windows.Forms.PictureBox wire4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox wire6;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}