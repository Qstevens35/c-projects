namespace SearchAndSortAlgorithms
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
            this.label_Yes = new System.Windows.Forms.Label();
            this.button_BinSerach = new System.Windows.Forms.Button();
            this.button_SelecSort = new System.Windows.Forms.Button();
            this.button_InsertSort = new System.Windows.Forms.Button();
            this.button_MergeSort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Yes
            // 
            this.label_Yes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label_Yes.Location = new System.Drawing.Point(12, 57);
            this.label_Yes.Name = "label_Yes";
            this.label_Yes.Size = new System.Drawing.Size(776, 384);
            this.label_Yes.TabIndex = 0;
            // 
            // button_BinSerach
            // 
            this.button_BinSerach.Location = new System.Drawing.Point(30, 13);
            this.button_BinSerach.Name = "button_BinSerach";
            this.button_BinSerach.Size = new System.Drawing.Size(97, 23);
            this.button_BinSerach.TabIndex = 1;
            this.button_BinSerach.Text = "Binary Search";
            this.button_BinSerach.UseVisualStyleBackColor = true;
            this.button_BinSerach.Click += new System.EventHandler(this.button1_Click);
            // 
            // button_SelecSort
            // 
            this.button_SelecSort.Location = new System.Drawing.Point(220, 13);
            this.button_SelecSort.Name = "button_SelecSort";
            this.button_SelecSort.Size = new System.Drawing.Size(101, 23);
            this.button_SelecSort.TabIndex = 2;
            this.button_SelecSort.Text = "Selection Sort";
            this.button_SelecSort.UseVisualStyleBackColor = true;
            this.button_SelecSort.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_InsertSort
            // 
            this.button_InsertSort.Location = new System.Drawing.Point(419, 13);
            this.button_InsertSort.Name = "button_InsertSort";
            this.button_InsertSort.Size = new System.Drawing.Size(98, 23);
            this.button_InsertSort.TabIndex = 3;
            this.button_InsertSort.Text = "Insertion Sort";
            this.button_InsertSort.UseVisualStyleBackColor = true;
            this.button_InsertSort.Click += new System.EventHandler(this.button_InsertSort_Click);
            // 
            // button_MergeSort
            // 
            this.button_MergeSort.Location = new System.Drawing.Point(619, 13);
            this.button_MergeSort.Name = "button_MergeSort";
            this.button_MergeSort.Size = new System.Drawing.Size(75, 23);
            this.button_MergeSort.TabIndex = 4;
            this.button_MergeSort.Text = "Merge Sort";
            this.button_MergeSort.UseVisualStyleBackColor = true;
            this.button_MergeSort.Click += new System.EventHandler(this.button_MergeSort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sort first*";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(85, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(713, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "New Array";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_MergeSort);
            this.Controls.Add(this.button_InsertSort);
            this.Controls.Add(this.button_SelecSort);
            this.Controls.Add(this.button_BinSerach);
            this.Controls.Add(this.label_Yes);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Yes;
        private System.Windows.Forms.Button button_BinSerach;
        private System.Windows.Forms.Button button_SelecSort;
        private System.Windows.Forms.Button button_InsertSort;
        private System.Windows.Forms.Button button_MergeSort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

