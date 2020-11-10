using System;

namespace Simple_Game
{
    partial class btn_welcome
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
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_Startgame = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.btn_desplay = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_desplay)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_help
            // 
            this.btn_help.BackColor = System.Drawing.Color.Yellow;
            this.btn_help.Location = new System.Drawing.Point(165, 88);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(75, 43);
            this.btn_help.TabIndex = 1;
            this.btn_help.Text = "Help";
            this.btn_help.UseVisualStyleBackColor = false;
            // 
            // btn_Startgame
            // 
            this.btn_Startgame.BackColor = System.Drawing.Color.Yellow;
            this.btn_Startgame.Location = new System.Drawing.Point(246, 128);
            this.btn_Startgame.Name = "btn_Startgame";
            this.btn_Startgame.Size = new System.Drawing.Size(75, 44);
            this.btn_Startgame.TabIndex = 2;
            this.btn_Startgame.Text = "Start Game";
            this.btn_Startgame.UseVisualStyleBackColor = false;
            this.btn_Startgame.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Yellow;
            this.btn_Exit.Location = new System.Drawing.Point(327, 169);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 40);
            this.btn_Exit.TabIndex = 3;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.button3_Click);
            // 
            // btn_desplay
            // 
            this.btn_desplay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_desplay.BackgroundImage = global::Simple_Game.Properties.Resources.welcome_game;
            this.btn_desplay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_desplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btn_desplay.Location = new System.Drawing.Point(138, 43);
            this.btn_desplay.Name = "btn_desplay";
            this.btn_desplay.Size = new System.Drawing.Size(309, 209);
            this.btn_desplay.TabIndex = 0;
            this.btn_desplay.TabStop = false;
            this.btn_desplay.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 312);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_Startgame);
            this.Controls.Add(this.btn_help);
            this.Controls.Add(this.btn_desplay);
            this.Name = "btn_welcome";
            this.Text = "Welcome to the game";
            this.Load += new System.EventHandler(this.btn_welcome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_desplay)).EndInit();
            this.ResumeLayout(false);

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.PictureBox btn_desplay;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_Startgame;
        private System.Windows.Forms.Button btn_Exit;
    }
}