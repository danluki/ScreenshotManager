﻿namespace ScreenManagerView.View.ScreenshotWindow
{
    partial class ScreenWindow
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
            this.SuspendLayout();
            // 
            // ScreenWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Cursor = System.Windows.Forms.Cursors.Cross;
            this.DisplayHeader = false;
            this.Movable = false;
            this.Name = "ScreenWindow";
            this.Opacity = 0.2D;
            this.Padding = new System.Windows.Forms.Padding(20, 30, 20, 20);
            this.Resizable = false;
            this.ShadowType = MetroFramework.Forms.MetroForm.MetroFormShadowType.None;
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScreenWindow_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScreenWindow_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.ScreenWindow_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion
    }
}