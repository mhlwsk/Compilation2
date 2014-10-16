﻿namespace MyCompilation
{
    partial class STableForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.predictionListView = new System.Windows.Forms.ListView();
            this.NoColum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LeftColum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.RightColum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SelectColum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FollowColum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstColum = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(382, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prediction Table";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.predictionListView);
            this.panel1.Location = new System.Drawing.Point(13, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(828, 308);
            this.panel1.TabIndex = 1;
            // 
            // predictionListView
            // 
            this.predictionListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NoColum,
            this.LeftColum,
            this.RightColum,
            this.SelectColum,
            this.FollowColum,
            this.FirstColum});
            this.predictionListView.GridLines = true;
            this.predictionListView.Location = new System.Drawing.Point(0, 14);
            this.predictionListView.Name = "predictionListView";
            this.predictionListView.Size = new System.Drawing.Size(824, 304);
            this.predictionListView.TabIndex = 0;
            this.predictionListView.UseCompatibleStateImageBehavior = false;
            this.predictionListView.View = System.Windows.Forms.View.Details;
            // 
            // NoColum
            // 
            this.NoColum.Text = "No.";
            this.NoColum.Width = 37;
            // 
            // LeftColum
            // 
            this.LeftColum.Text = "Left";
            this.LeftColum.Width = 96;
            // 
            // RightColum
            // 
            this.RightColum.Text = "Right";
            this.RightColum.Width = 128;
            // 
            // SelectColum
            // 
            this.SelectColum.Text = "SELECT";
            this.SelectColum.Width = 213;
            // 
            // FollowColum
            // 
            this.FollowColum.Text = "FOLLOW";
            this.FollowColum.Width = 147;
            // 
            // FirstColum
            // 
            this.FirstColum.Text = "FIRST";
            this.FirstColum.Width = 189;
            // 
            // STableForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 348);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "STableForm";
            this.Text = "STableForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ListView predictionListView;
        private System.Windows.Forms.ColumnHeader NoColum;
        private System.Windows.Forms.ColumnHeader LeftColum;
        private System.Windows.Forms.ColumnHeader RightColum;
        private System.Windows.Forms.ColumnHeader SelectColum;
        private System.Windows.Forms.ColumnHeader FollowColum;
        private System.Windows.Forms.ColumnHeader FirstColum;
    }
}