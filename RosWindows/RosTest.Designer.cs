namespace RosWindows
{
    partial class RosTest
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
            this.BaglantiSonucu = new System.Windows.Forms.Label();
            this.baglantiSonucu_TextBox = new System.Windows.Forms.TextBox();
            this.BaglantiButonu = new System.Windows.Forms.Button();
            this.RosMasterHost = new System.Windows.Forms.Label();
            this.RosMasterIP = new System.Windows.Forms.Label();
            this.rosMasterHost_TextBox = new System.Windows.Forms.TextBox();
            this.rosMasterIP_TextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BaglantiSonucu
            // 
            this.BaglantiSonucu.AutoSize = true;
            this.BaglantiSonucu.Location = new System.Drawing.Point(153, 207);
            this.BaglantiSonucu.Name = "BaglantiSonucu";
            this.BaglantiSonucu.Size = new System.Drawing.Size(85, 13);
            this.BaglantiSonucu.TabIndex = 20;
            this.BaglantiSonucu.Text = "Bağlantı Sonucu";
            // 
            // baglantiSonucu_TextBox
            // 
            this.baglantiSonucu_TextBox.Location = new System.Drawing.Point(256, 204);
            this.baglantiSonucu_TextBox.Name = "baglantiSonucu_TextBox";
            this.baglantiSonucu_TextBox.Size = new System.Drawing.Size(353, 20);
            this.baglantiSonucu_TextBox.TabIndex = 19;
            // 
            // BaglantiButonu
            // 
            this.BaglantiButonu.Location = new System.Drawing.Point(499, 103);
            this.BaglantiButonu.Name = "BaglantiButonu";
            this.BaglantiButonu.Size = new System.Drawing.Size(110, 66);
            this.BaglantiButonu.TabIndex = 18;
            this.BaglantiButonu.Text = "Ros Bağlan";
            this.BaglantiButonu.UseVisualStyleBackColor = true;
            this.BaglantiButonu.Click += new System.EventHandler(this.BaglantiButonu_Click);
            // 
            // RosMasterHost
            // 
            this.RosMasterHost.AutoSize = true;
            this.RosMasterHost.Location = new System.Drawing.Point(153, 152);
            this.RosMasterHost.Name = "RosMasterHost";
            this.RosMasterHost.Size = new System.Drawing.Size(80, 13);
            this.RosMasterHost.TabIndex = 17;
            this.RosMasterHost.Text = "RosMasterHost";
            // 
            // RosMasterIP
            // 
            this.RosMasterIP.AutoSize = true;
            this.RosMasterIP.Location = new System.Drawing.Point(153, 106);
            this.RosMasterIP.Name = "RosMasterIP";
            this.RosMasterIP.Size = new System.Drawing.Size(68, 13);
            this.RosMasterIP.TabIndex = 16;
            this.RosMasterIP.Text = "RosMasterIP";
            // 
            // rosMasterHost_TextBox
            // 
            this.rosMasterHost_TextBox.Location = new System.Drawing.Point(256, 149);
            this.rosMasterHost_TextBox.Name = "rosMasterHost_TextBox";
            this.rosMasterHost_TextBox.Size = new System.Drawing.Size(141, 20);
            this.rosMasterHost_TextBox.TabIndex = 15;
            // 
            // rosMasterIP_TextBox
            // 
            this.rosMasterIP_TextBox.Location = new System.Drawing.Point(256, 103);
            this.rosMasterIP_TextBox.Name = "rosMasterIP_TextBox";
            this.rosMasterIP_TextBox.Size = new System.Drawing.Size(141, 20);
            this.rosMasterIP_TextBox.TabIndex = 14;
            // 
            // RosTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BaglantiSonucu);
            this.Controls.Add(this.baglantiSonucu_TextBox);
            this.Controls.Add(this.BaglantiButonu);
            this.Controls.Add(this.RosMasterHost);
            this.Controls.Add(this.RosMasterIP);
            this.Controls.Add(this.rosMasterHost_TextBox);
            this.Controls.Add(this.rosMasterIP_TextBox);
            this.Name = "RosTest";
            this.Text = "ROVENSE";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BaglantiSonucu;
        private System.Windows.Forms.TextBox baglantiSonucu_TextBox;
        private System.Windows.Forms.Button BaglantiButonu;
        private System.Windows.Forms.Label RosMasterHost;
        private System.Windows.Forms.Label RosMasterIP;
        private System.Windows.Forms.TextBox rosMasterHost_TextBox;
        private System.Windows.Forms.TextBox rosMasterIP_TextBox;
    }
}

