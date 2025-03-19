namespace SimpleFormsAppWithComboBox
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
            cmb = new ComboBox();
            button1 = new Button();
            clb = new CheckedListBox();
            lb = new ListBox();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // cmb
            // 
            cmb.FormattingEnabled = true;
            cmb.Location = new Point(26, 80);
            cmb.Name = "cmb";
            cmb.Size = new Size(121, 23);
            cmb.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(26, 109);
            button1.Name = "button1";
            button1.Size = new Size(121, 23);
            button1.TabIndex = 1;
            button1.Text = "Select";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // clb
            // 
            clb.FormattingEnabled = true;
            clb.Location = new Point(190, 80);
            clb.Name = "clb";
            clb.Size = new Size(120, 112);
            clb.TabIndex = 2;
            // 
            // lb
            // 
            lb.FormattingEnabled = true;
            lb.ItemHeight = 15;
            lb.Location = new Point(342, 80);
            lb.Name = "lb";
            lb.Size = new Size(120, 109);
            lb.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(189, 199);
            button2.Name = "button2";
            button2.Size = new Size(121, 23);
            button2.TabIndex = 4;
            button2.Text = "Add";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(468, 80);
            button3.Name = "button3";
            button3.Size = new Size(121, 23);
            button3.TabIndex = 5;
            button3.Text = "Remove";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(468, 109);
            button4.Name = "button4";
            button4.Size = new Size(121, 23);
            button4.TabIndex = 6;
            button4.Text = "Clear All";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Subheading", 15.7499981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(26, 9);
            label1.Name = "label1";
            label1.Size = new Size(385, 30);
            label1.TabIndex = 7;
            label1.Text = "SIMPLE FAVORITE FOOD PICKER APP";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(26, 62);
            label2.Name = "label2";
            label2.Size = new Size(53, 17);
            label2.TabIndex = 8;
            label2.Text = "Cuisine";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(190, 62);
            label3.Name = "label3";
            label3.Size = new Size(65, 17);
            label3.TabIndex = 9;
            label3.Text = "Food List";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(342, 62);
            label4.Name = "label4";
            label4.Size = new Size(140, 17);
            label4.TabIndex = 10;
            label4.Text = "My favorite Food List";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            ClientSize = new Size(626, 288);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(lb);
            Controls.Add(clb);
            Controls.Add(button1);
            Controls.Add(cmb);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmb;
        private Button button1;
        private CheckedListBox clb;
        private ListBox lb;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}
