namespace Praktikum8
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
            this.comboBox_Home = new System.Windows.Forms.ComboBox();
            this.comboBox_Away = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label_ManagerHome = new System.Windows.Forms.Label();
            this.label_ManagerAway = new System.Windows.Forms.Label();
            this.label_CaptainHome = new System.Windows.Forms.Label();
            this.label_CaptainAway = new System.Windows.Forms.Label();
            this.label_Stadium = new System.Windows.Forms.Label();
            this.label_Capacity = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.dgvplayer = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label_Tanggal = new System.Windows.Forms.Label();
            this.label_Skor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvplayer)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox_Home
            // 
            this.comboBox_Home.FormattingEnabled = true;
            this.comboBox_Home.Location = new System.Drawing.Point(32, 12);
            this.comboBox_Home.Name = "comboBox_Home";
            this.comboBox_Home.Size = new System.Drawing.Size(268, 28);
            this.comboBox_Home.TabIndex = 0;
            this.comboBox_Home.SelectedIndexChanged += new System.EventHandler(this.comboBox_Home_SelectedIndexChanged);
            // 
            // comboBox_Away
            // 
            this.comboBox_Away.FormattingEnabled = true;
            this.comboBox_Away.Location = new System.Drawing.Point(481, 12);
            this.comboBox_Away.Name = "comboBox_Away";
            this.comboBox_Away.Size = new System.Drawing.Size(268, 28);
            this.comboBox_Away.TabIndex = 1;
            this.comboBox_Away.SelectedIndexChanged += new System.EventHandler(this.comboBox_Away_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(362, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "VS";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Manager:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(477, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Manager:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Captain:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 6;
            this.label5.Text = "Captain:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 20);
            this.label6.TabIndex = 7;
            this.label6.Text = "Stadium:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(239, 176);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Capacity:";
            // 
            // label_ManagerHome
            // 
            this.label_ManagerHome.AutoSize = true;
            this.label_ManagerHome.Location = new System.Drawing.Point(110, 62);
            this.label_ManagerHome.Name = "label_ManagerHome";
            this.label_ManagerHome.Size = new System.Drawing.Size(23, 20);
            this.label_ManagerHome.TabIndex = 9;
            this.label_ManagerHome.Text = "- -";
            // 
            // label_ManagerAway
            // 
            this.label_ManagerAway.AutoSize = true;
            this.label_ManagerAway.Location = new System.Drawing.Point(559, 62);
            this.label_ManagerAway.Name = "label_ManagerAway";
            this.label_ManagerAway.Size = new System.Drawing.Size(23, 20);
            this.label_ManagerAway.TabIndex = 10;
            this.label_ManagerAway.Text = "- -";
            // 
            // label_CaptainHome
            // 
            this.label_CaptainHome.AutoSize = true;
            this.label_CaptainHome.Location = new System.Drawing.Point(110, 98);
            this.label_CaptainHome.Name = "label_CaptainHome";
            this.label_CaptainHome.Size = new System.Drawing.Size(23, 20);
            this.label_CaptainHome.TabIndex = 11;
            this.label_CaptainHome.Text = "- -";
            // 
            // label_CaptainAway
            // 
            this.label_CaptainAway.AutoSize = true;
            this.label_CaptainAway.Location = new System.Drawing.Point(559, 98);
            this.label_CaptainAway.Name = "label_CaptainAway";
            this.label_CaptainAway.Size = new System.Drawing.Size(23, 20);
            this.label_CaptainAway.TabIndex = 12;
            this.label_CaptainAway.Text = "- -";
            // 
            // label_Stadium
            // 
            this.label_Stadium.AutoSize = true;
            this.label_Stadium.Location = new System.Drawing.Point(319, 146);
            this.label_Stadium.Name = "label_Stadium";
            this.label_Stadium.Size = new System.Drawing.Size(23, 20);
            this.label_Stadium.TabIndex = 13;
            this.label_Stadium.Text = "- -";
            // 
            // label_Capacity
            // 
            this.label_Capacity.AutoSize = true;
            this.label_Capacity.Location = new System.Drawing.Point(319, 176);
            this.label_Capacity.Name = "label_Capacity";
            this.label_Capacity.Size = new System.Drawing.Size(23, 20);
            this.label_Capacity.TabIndex = 14;
            this.label_Capacity.Text = "- -";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(254, 296);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(46, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "Skor:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(239, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 20);
            this.label11.TabIndex = 21;
            this.label11.Text = "Tanggal:";
            // 
            // dgvplayer
            // 
            this.dgvplayer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvplayer.Location = new System.Drawing.Point(13, 340);
            this.dgvplayer.Name = "dgvplayer";
            this.dgvplayer.RowHeadersWidth = 62;
            this.dgvplayer.RowTemplate.Height = 28;
            this.dgvplayer.Size = new System.Drawing.Size(767, 268);
            this.dgvplayer.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(321, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 29);
            this.button1.TabIndex = 23;
            this.button1.Text = "Check";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label_Tanggal
            // 
            this.label_Tanggal.AutoSize = true;
            this.label_Tanggal.Location = new System.Drawing.Point(315, 262);
            this.label_Tanggal.Name = "label_Tanggal";
            this.label_Tanggal.Size = new System.Drawing.Size(23, 20);
            this.label_Tanggal.TabIndex = 24;
            this.label_Tanggal.Text = "- -";
            // 
            // label_Skor
            // 
            this.label_Skor.AutoSize = true;
            this.label_Skor.Location = new System.Drawing.Point(315, 296);
            this.label_Skor.Name = "label_Skor";
            this.label_Skor.Size = new System.Drawing.Size(23, 20);
            this.label_Skor.TabIndex = 25;
            this.label_Skor.Text = "- -";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 620);
            this.Controls.Add(this.label_Skor);
            this.Controls.Add(this.label_Tanggal);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvplayer);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label_Capacity);
            this.Controls.Add(this.label_Stadium);
            this.Controls.Add(this.label_CaptainAway);
            this.Controls.Add(this.label_CaptainHome);
            this.Controls.Add(this.label_ManagerAway);
            this.Controls.Add(this.label_ManagerHome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox_Away);
            this.Controls.Add(this.comboBox_Home);
            this.Name = "Form1";
            this.Text = "Hasil Pertandingan";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvplayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox_Home;
        private System.Windows.Forms.ComboBox comboBox_Away;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_ManagerHome;
        private System.Windows.Forms.Label label_ManagerAway;
        private System.Windows.Forms.Label label_CaptainHome;
        private System.Windows.Forms.Label label_CaptainAway;
        private System.Windows.Forms.Label label_Stadium;
        private System.Windows.Forms.Label label_Capacity;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DataGridView dgvplayer;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_Tanggal;
        private System.Windows.Forms.Label label_Skor;
    }
}

