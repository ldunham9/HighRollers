namespace HighRollers
{
    partial class HighRollers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HighRollers));
            this.picDie15 = new System.Windows.Forms.PictureBox();
            this.picdie14 = new System.Windows.Forms.PictureBox();
            this.picDie11 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picDie15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdie14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie11)).BeginInit();
            this.SuspendLayout();
            // 
            // picDie15
            // 
            this.picDie15.ErrorImage = null;
            this.picDie15.Image = ((System.Drawing.Image)(resources.GetObject("picDie15.Image")));
            this.picDie15.Location = new System.Drawing.Point(13, 27);
            this.picDie15.Name = "picDie15";
            this.picDie15.Size = new System.Drawing.Size(95, 94);
            this.picDie15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDie15.TabIndex = 0;
            this.picDie15.TabStop = false;
            // 
            // picdie14
            // 
            this.picdie14.Image = ((System.Drawing.Image)(resources.GetObject("picdie14.Image")));
            this.picdie14.Location = new System.Drawing.Point(13, 147);
            this.picdie14.Name = "picdie14";
            this.picdie14.Size = new System.Drawing.Size(95, 86);
            this.picdie14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picdie14.TabIndex = 1;
            this.picdie14.TabStop = false;
            // 
            // picDie11
            // 
            this.picDie11.Image = ((System.Drawing.Image)(resources.GetObject("picDie11.Image")));
            this.picDie11.Location = new System.Drawing.Point(13, 282);
            this.picDie11.Name = "picDie11";
            this.picDie11.Size = new System.Drawing.Size(95, 86);
            this.picDie11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picDie11.TabIndex = 2;
            this.picDie11.TabStop = false;
            // 
            // HighRollers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(831, 380);
            this.Controls.Add(this.picDie11);
            this.Controls.Add(this.picdie14);
            this.Controls.Add(this.picDie15);
            this.DoubleBuffered = true;
            this.Name = "HighRollers";
            this.Text = "HighRollers";
            ((System.ComponentModel.ISupportInitialize)(this.picDie15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picdie14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDie11)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picDie15;
        private System.Windows.Forms.PictureBox picdie14;
        private System.Windows.Forms.PictureBox picDie11;
    }
}

