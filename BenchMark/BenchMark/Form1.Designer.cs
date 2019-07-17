namespace BenchMark
{
    partial class FormBenchWork
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblConnected = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblDisconnected = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblEntity = new System.Windows.Forms.Label();
            this.lbConnected = new System.Windows.Forms.ListBox();
            this.lbDisconnected = new System.Windows.Forms.ListBox();
            this.lbEntityFramework = new System.Windows.Forms.ListBox();
            this.btnConnected = new System.Windows.Forms.Button();
            this.btnDisconnected = new System.Windows.Forms.Button();
            this.btnEntityFramework = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Connected";
            // 
            // lblConnected
            // 
            this.lblConnected.AutoSize = true;
            this.lblConnected.Location = new System.Drawing.Point(78, 244);
            this.lblConnected.Name = "lblConnected";
            this.lblConnected.Size = new System.Drawing.Size(0, 13);
            this.lblConnected.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Disconnected";
            // 
            // lblDisconnected
            // 
            this.lblDisconnected.AutoSize = true;
            this.lblDisconnected.Location = new System.Drawing.Point(83, 244);
            this.lblDisconnected.Name = "lblDisconnected";
            this.lblDisconnected.Size = new System.Drawing.Size(0, 13);
            this.lblDisconnected.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Entity Framework";
            // 
            // lblEntity
            // 
            this.lblEntity.AutoSize = true;
            this.lblEntity.Location = new System.Drawing.Point(73, 244);
            this.lblEntity.Name = "lblEntity";
            this.lblEntity.Size = new System.Drawing.Size(0, 13);
            this.lblEntity.TabIndex = 5;
            // 
            // lbConnected
            // 
            this.lbConnected.FormattingEnabled = true;
            this.lbConnected.Location = new System.Drawing.Point(25, 56);
            this.lbConnected.Name = "lbConnected";
            this.lbConnected.Size = new System.Drawing.Size(150, 173);
            this.lbConnected.TabIndex = 6;
            // 
            // lbDisconnected
            // 
            this.lbDisconnected.FormattingEnabled = true;
            this.lbDisconnected.Location = new System.Drawing.Point(21, 56);
            this.lbDisconnected.Name = "lbDisconnected";
            this.lbDisconnected.Size = new System.Drawing.Size(156, 173);
            this.lbDisconnected.TabIndex = 7;
            // 
            // lbEntityFramework
            // 
            this.lbEntityFramework.FormattingEnabled = true;
            this.lbEntityFramework.Location = new System.Drawing.Point(27, 56);
            this.lbEntityFramework.Name = "lbEntityFramework";
            this.lbEntityFramework.Size = new System.Drawing.Size(152, 173);
            this.lbEntityFramework.TabIndex = 8;
            // 
            // btnConnected
            // 
            this.btnConnected.Location = new System.Drawing.Point(25, 270);
            this.btnConnected.Name = "btnConnected";
            this.btnConnected.Size = new System.Drawing.Size(150, 23);
            this.btnConnected.TabIndex = 9;
            this.btnConnected.Text = "Çalıştır";
            this.btnConnected.UseVisualStyleBackColor = true;
            this.btnConnected.Click += new System.EventHandler(this.btnConnected_Click);
            // 
            // btnDisconnected
            // 
            this.btnDisconnected.Location = new System.Drawing.Point(21, 270);
            this.btnDisconnected.Name = "btnDisconnected";
            this.btnDisconnected.Size = new System.Drawing.Size(156, 23);
            this.btnDisconnected.TabIndex = 10;
            this.btnDisconnected.Text = "Çalıştır";
            this.btnDisconnected.UseVisualStyleBackColor = true;
            this.btnDisconnected.Click += new System.EventHandler(this.btnDisconnected_Click);
            // 
            // btnEntityFramework
            // 
            this.btnEntityFramework.Location = new System.Drawing.Point(27, 270);
            this.btnEntityFramework.Name = "btnEntityFramework";
            this.btnEntityFramework.Size = new System.Drawing.Size(152, 23);
            this.btnEntityFramework.TabIndex = 11;
            this.btnEntityFramework.Text = "Çalıştır";
            this.btnEntityFramework.UseVisualStyleBackColor = true;
            this.btnEntityFramework.Click += new System.EventHandler(this.btnEntityFramework_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblConnected);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnConnected);
            this.groupBox1.Controls.Add(this.lbConnected);
            this.groupBox1.Location = new System.Drawing.Point(40, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 309);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbDisconnected);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.lblDisconnected);
            this.groupBox2.Controls.Add(this.btnDisconnected);
            this.groupBox2.Location = new System.Drawing.Point(306, 40);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 309);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "2";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.lblEntity);
            this.groupBox3.Controls.Add(this.lbEntityFramework);
            this.groupBox3.Controls.Add(this.btnEntityFramework);
            this.groupBox3.Location = new System.Drawing.Point(563, 40);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 309);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "3";
            // 
            // FormBenchWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormBenchWork";
            this.Text = "Bench Mark";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblConnected;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblDisconnected;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblEntity;
        private System.Windows.Forms.ListBox lbConnected;
        private System.Windows.Forms.ListBox lbDisconnected;
        private System.Windows.Forms.ListBox lbEntityFramework;
        private System.Windows.Forms.Button btnConnected;
        private System.Windows.Forms.Button btnDisconnected;
        private System.Windows.Forms.Button btnEntityFramework;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

