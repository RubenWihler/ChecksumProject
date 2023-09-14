namespace ChecksumProject
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
            panel1 = new Panel();
            groupBox1 = new GroupBox();
            btn_search_file = new Button();
            label1 = new Label();
            tbox_path = new TextBox();
            panel2 = new Panel();
            btn_calculate = new Button();
            label2 = new Label();
            tbox_checksum = new TextBox();
            panel1.SuspendLayout();
            groupBox1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel1.Controls.Add(groupBox1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(414, 119);
            panel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            groupBox1.Controls.Add(btn_search_file);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(tbox_path);
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(408, 113);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "File Selection";
            // 
            // btn_search_file
            // 
            btn_search_file.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_search_file.Location = new Point(20, 31);
            btn_search_file.Name = "btn_search_file";
            btn_search_file.Size = new Size(376, 23);
            btn_search_file.TabIndex = 2;
            btn_search_file.Text = "search file";
            btn_search_file.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(20, 69);
            label1.Name = "label1";
            label1.Size = new Size(57, 25);
            label1.TabIndex = 1;
            label1.Text = "path :";
            // 
            // tbox_path
            // 
            tbox_path.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            tbox_path.Location = new Point(83, 69);
            tbox_path.Name = "tbox_path";
            tbox_path.Size = new Size(313, 23);
            tbox_path.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.Controls.Add(btn_calculate);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(tbox_checksum);
            panel2.Location = new Point(12, 146);
            panel2.Name = "panel2";
            panel2.Size = new Size(414, 315);
            panel2.TabIndex = 1;
            // 
            // btn_calculate
            // 
            btn_calculate.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            btn_calculate.Location = new Point(23, 20);
            btn_calculate.Name = "btn_calculate";
            btn_calculate.Size = new Size(376, 23);
            btn_calculate.TabIndex = 2;
            btn_calculate.Text = "Calculate";
            btn_calculate.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(23, 64);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 1;
            label2.Text = "checksum :";
            // 
            // tbox_checksum
            // 
            tbox_checksum.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tbox_checksum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbox_checksum.Location = new Point(23, 97);
            tbox_checksum.Multiline = true;
            tbox_checksum.Name = "tbox_checksum";
            tbox_checksum.ReadOnly = true;
            tbox_checksum.Size = new Size(376, 203);
            tbox_checksum.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(438, 473);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Checksum Project";
            panel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private GroupBox groupBox1;
        private Label label1;
        private TextBox tbox_path;
        private Panel panel2;
        private Button btn_search_file;
        private Label label2;
        private TextBox tbox_checksum;
        private Button btn_calculate;
    }
}