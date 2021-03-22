namespace a406530022_Project
{
    partial class Form4
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
            this.playTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Enemy2 = new System.Windows.Forms.PictureBox();
            this.Enemy1 = new System.Windows.Forms.PictureBox();
            this.Bullet = new System.Windows.Forms.PictureBox();
            this.PlayerTank = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTank)).BeginInit();
            this.SuspendLayout();
            // 
            // playTimer
            // 
            this.playTimer.Enabled = true;
            this.playTimer.Tick += new System.EventHandler(this.playTimer_Tick);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::a406530022_Project.Properties.Resources.forest;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Enemy2);
            this.panel1.Controls.Add(this.Enemy1);
            this.panel1.Controls.Add(this.Bullet);
            this.panel1.Controls.Add(this.PlayerTank);
            this.panel1.Location = new System.Drawing.Point(-13, -6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 555);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(474, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 91);
            this.label1.TabIndex = 4;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // Enemy2
            // 
            this.Enemy2.BackColor = System.Drawing.Color.Transparent;
            this.Enemy2.Image = global::a406530022_Project.Properties.Resources.helicopter__1_;
            this.Enemy2.Location = new System.Drawing.Point(859, 392);
            this.Enemy2.Name = "Enemy2";
            this.Enemy2.Size = new System.Drawing.Size(139, 108);
            this.Enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy2.TabIndex = 3;
            this.Enemy2.TabStop = false;
            // 
            // Enemy1
            // 
            this.Enemy1.BackColor = System.Drawing.Color.Transparent;
            this.Enemy1.Image = global::a406530022_Project.Properties.Resources.helicopter;
            this.Enemy1.Location = new System.Drawing.Point(859, 18);
            this.Enemy1.Name = "Enemy1";
            this.Enemy1.Size = new System.Drawing.Size(139, 108);
            this.Enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Enemy1.TabIndex = 2;
            this.Enemy1.TabStop = false;
            // 
            // Bullet
            // 
            this.Bullet.BackColor = System.Drawing.Color.Transparent;
            this.Bullet.Image = global::a406530022_Project.Properties.Resources.bullet;
            this.Bullet.Location = new System.Drawing.Point(143, 264);
            this.Bullet.Name = "Bullet";
            this.Bullet.Size = new System.Drawing.Size(59, 50);
            this.Bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Bullet.TabIndex = 1;
            this.Bullet.TabStop = false;
            // 
            // PlayerTank
            // 
            this.PlayerTank.BackColor = System.Drawing.Color.Transparent;
            this.PlayerTank.Image = global::a406530022_Project.Properties.Resources.armored_vehicle;
            this.PlayerTank.Location = new System.Drawing.Point(31, 241);
            this.PlayerTank.Name = "PlayerTank";
            this.PlayerTank.Size = new System.Drawing.Size(106, 90);
            this.PlayerTank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PlayerTank.TabIndex = 0;
            this.PlayerTank.TabStop = false;
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 506);
            this.Controls.Add(this.panel1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form4_Closing);
            this.Load += new System.EventHandler(this.Form4_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.onKeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.onKeyUp);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PlayerTank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox PlayerTank;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Enemy2;
        private System.Windows.Forms.PictureBox Enemy1;
        private System.Windows.Forms.PictureBox Bullet;
        private System.Windows.Forms.Timer playTimer;
        private System.Windows.Forms.Label label1;
    }
}