﻿namespace PacMan
{
    partial class MainGame
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
            this.timer_Refresh_Graphic = new System.Windows.Forms.Timer(this.components);
            this.timer_Sprite_Animation_Speed = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // timer_Refresh_Graphic
            // 
            this.timer_Refresh_Graphic.Enabled = true;
            this.timer_Refresh_Graphic.Interval = 50;
            this.timer_Refresh_Graphic.Tick += new System.EventHandler(this.timerRefresh);
            // 
            // timer_Sprite_Animation_Speed
            // 
            this.timer_Sprite_Animation_Speed.Enabled = true;
            this.timer_Sprite_Animation_Speed.Interval = 30;
            this.timer_Sprite_Animation_Speed.Tick += new System.EventHandler(this.timer_Sprite_Animation_Speed_Tick);
            // 
            // Pacman
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(768, 806);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.Name = "Pacman";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Pacman";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Pacman_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer timer_Refresh_Graphic;
        private System.Windows.Forms.Timer timer_Sprite_Animation_Speed;

    }
}
