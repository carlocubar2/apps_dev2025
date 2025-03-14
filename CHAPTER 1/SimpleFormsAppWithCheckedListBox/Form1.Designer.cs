namespace SimpleFormsAppWithCheckedListBox
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
            chcklstbox = new CheckedListBox();
            label1 = new Label();
            lstbox = new ListBox();
            label2 = new Label();
            label3 = new Label();
            addbtn = new Button();
            removebtn = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // chcklstbox
            // 
            chcklstbox.FormattingEnabled = true;
            chcklstbox.Location = new Point(21, 110);
            chcklstbox.Name = "chcklstbox";
            chcklstbox.Size = new Size(139, 148);
            chcklstbox.TabIndex = 0;
            chcklstbox.SelectedIndexChanged += chcklstbox_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 69);
            label1.Name = "label1";
            label1.Size = new Size(148, 23);
            label1.TabIndex = 1;
            label1.Text = "Movie/Series list";
            label1.Click += label1_Click;
            // 
            // lstbox
            // 
            lstbox.FormattingEnabled = true;
            lstbox.ItemHeight = 15;
            lstbox.Location = new Point(257, 110);
            lstbox.Name = "lstbox";
            lstbox.Size = new Size(136, 154);
            lstbox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Text", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(257, 69);
            label2.Name = "label2";
            label2.Size = new Size(136, 23);
            label2.TabIndex = 3;
            label2.Text = "Movie Selected \r\n";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bookman Old Style", 15.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            label3.Location = new Point(80, 26);
            label3.Name = "label3";
            label3.Size = new Size(218, 24);
            label3.TabIndex = 4;
            label3.Text = "MOVIE PICKER APP\r\n";
            label3.Click += label3_Click;
            // 
            // addbtn
            // 
            addbtn.ForeColor = Color.Red;
            addbtn.Location = new Point(44, 284);
            addbtn.Name = "addbtn";
            addbtn.Size = new Size(75, 23);
            addbtn.TabIndex = 5;
            addbtn.Text = "Add";
            addbtn.UseVisualStyleBackColor = true;
            addbtn.Click += addbtn_Click;
            // 
            // removebtn
            // 
            removebtn.ForeColor = Color.Red;
            removebtn.Location = new Point(435, 141);
            removebtn.Name = "removebtn";
            removebtn.Size = new Size(75, 23);
            removebtn.TabIndex = 6;
            removebtn.Text = "Remove";
            removebtn.UseVisualStyleBackColor = true;
            removebtn.Click += removebtn_Click;
            // 
            // button3
            // 
            button3.ForeColor = Color.Red;
            button3.Location = new Point(435, 207);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "Clear\r\n";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DodgerBlue;
            ClientSize = new Size(612, 337);
            Controls.Add(button3);
            Controls.Add(removebtn);
            Controls.Add(addbtn);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lstbox);
            Controls.Add(label1);
            Controls.Add(chcklstbox);
            Name = "Form1";
            Text = "Form1";
            Load += clrbtn_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox chcklstbox;
        private Label label1;
        private ListBox lstbox;
        private Label label2;
        private Label label3;
        private Button addbtn;
        private Button removebtn;
        private Button button3;
    }
}
