namespace Simple_Game
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
            this.load = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // load
            // 
            this.load.BackColor = System.Drawing.Color.Yellow;
            this.load.Cursor = System.Windows.Forms.Cursors.Default;
            this.load.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.load.ForeColor = System.Drawing.Color.White;
            this.load.Image = global::Simple_Game.Properties.Resources.load_jpg_image;
            this.load.Location = new System.Drawing.Point(195, 92);
            this.load.MaximumSize = new System.Drawing.Size(2, 2);
            this.load.Name = "load";
            this.load.Size = new System.Drawing.Size(2, 2);
            this.load.TabIndex = 0;
            this.load.Text = "Load";
            this.load.UseVisualStyleBackColor = false;
            this.load.Visible = false;
            this.load.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Simple_Game.Properties.Resources.ballon;
            this.ClientSize = new System.Drawing.Size(626, 328);
            this.Controls.Add(this.load);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.Text = "simple game";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button load;
    }
}

