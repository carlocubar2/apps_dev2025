﻿namespace SimpleFormsAppWithListBox
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtbox = new TextBox();
            lstBox = new ListBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // txtbox
            // 
            txtbox.Location = new Point(72, 29);
            txtbox.Multiline = true;
            txtbox.Name = "txtbox";
            txtbox.Size = new Size(190, 24);
            txtbox.TabIndex = 0;
            // 
            // lstBox
            // 
            lstBox.FormattingEnabled = true;
            lstBox.ItemHeight = 15;
            lstBox.Location = new Point(72, 62);
            lstBox.Name = "lstBox";
            lstBox.Size = new Size(284, 154);
            lstBox.TabIndex = 1;
            lstBox.SelectedIndexChanged += lstBox_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(264, 22);
            button1.Name = "button1";
            button1.Size = new Size(92, 34);
            button1.TabIndex = 2;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(375, 86);
            button2.Name = "button2";
            button2.Size = new Size(120, 23);
            button2.TabIndex = 3;
            button2.Text = "Remove";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(375, 127);
            button3.Name = "button3";
            button3.Size = new Size(120, 23);
            button3.TabIndex = 4;
            button3.Text = "Clear";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(lstBox);
            Controls.Add(txtbox);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtbox;
        private ListBox lstBox;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}
