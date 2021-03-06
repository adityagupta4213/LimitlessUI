﻿namespace LimitlessUISample.Tabs
{
    partial class DropDown_Tab
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dropDown_WOC1 = new DropDown_WOC();
            this.chart_WOC1 = new LimitlessUISample.Chart_WOC();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.animator_WOC1 = new Animator_WOC();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F);
            this.button1.Location = new System.Drawing.Point(0, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(803, 104);
            this.button1.TabIndex = 1;
            this.button1.Text = "Random Button";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dropDown_WOC1
            // 
            this.dropDown_WOC1.ArrowSize = new System.Drawing.SizeF(12F, 12F);
            this.dropDown_WOC1.ArrowThinkness = 2F;
            this.dropDown_WOC1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dropDown_WOC1.DownImage = null;
            this.dropDown_WOC1.Location = new System.Drawing.Point(0, 0);
            this.dropDown_WOC1.Name = "dropDown_WOC1";
            this.dropDown_WOC1.PointsDown = true;
            this.dropDown_WOC1.SetLayout = this.button1;
            this.dropDown_WOC1.Size = new System.Drawing.Size(803, 32);
            this.dropDown_WOC1.TabIndex = 0;
            this.dropDown_WOC1.Text = "This is dropdown thingy";
            this.dropDown_WOC1.TextDistance = 35F;
            this.dropDown_WOC1.UpImage = null;
            // 
            // chart_WOC1
            // 
            this.chart_WOC1.Location = new System.Drawing.Point(42, 155);
            this.chart_WOC1.Name = "chart_WOC1";
            this.chart_WOC1.Padding = new System.Windows.Forms.Padding(20);
            this.chart_WOC1.Size = new System.Drawing.Size(728, 199);
            this.chart_WOC1.TabIndex = 2;
            this.chart_WOC1.Text = "chart_WOC1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 500;
            // 
            // animator_WOC1
            // 
            this.animator_WOC1.Controls = null;
            this.animator_WOC1.Delay = 17;
            // 
            // DropDown_Tab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.chart_WOC1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dropDown_WOC1);
            this.Name = "DropDown_Tab";
            this.Size = new System.Drawing.Size(803, 507);
            this.ResumeLayout(false);

        }

        #endregion

        private DropDown_WOC dropDown_WOC1;
        private System.Windows.Forms.Button button1;
        private Chart_WOC chart_WOC1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private Animator_WOC animator_WOC1;
    }
}
