﻿namespace MyCompilation
{
    partial class SResult
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.listView1 = new System.Windows.Forms.ListView();
            this.NoColum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.InputColum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.OutputColum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TopColum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.StackColum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.listView1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(900, 356);
            this.panel1.TabIndex = 0;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NoColum,
            this.InputColum,
            this.OutputColum,
            this.TopColum,
            this.StackColum});
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(4, 26);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(893, 330);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // NoColum
            // 
            this.NoColum.Text = "No.";
            this.NoColum.Width = 25;
            // 
            // InputColum
            // 
            this.InputColum.Text = "Input";
            this.InputColum.Width = 25;
            // 
            // OutputColum
            // 
            this.OutputColum.Text = "Output";
            this.OutputColum.Width = 25;
            // 
            // TopColum
            // 
            this.TopColum.Text = "Stack Top";
            this.TopColum.Width = 25;
            // 
            // StackColum
            // 
            this.StackColum.Text = "Stack";
            this.StackColum.Width = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "LL(1)文法分析结果";
            // 
            // SResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 355);
            this.Controls.Add(this.panel1);
            this.Name = "SResult";
            this.Text = "SResult";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader NoColum;
        private System.Windows.Forms.ColumnHeader InputColum;
        private System.Windows.Forms.ColumnHeader OutputColum;
        private System.Windows.Forms.ColumnHeader TopColum;
        private System.Windows.Forms.ColumnHeader StackColum;
    }
}