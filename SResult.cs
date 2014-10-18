﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MyCompilation
{
    public partial class SResult : Form
    {
        public SResult()
        {
            InitializeComponent();
        }

        public void setWidth()
        {
            this.NoColum.Width = -2;
            this.InputColum.Width = -1;
            this.OutputColum.Width = -1;
            this.TopColum.Width = -1;
            this.StackColum.Width = -1;
        }

        public void addListItem(int No, string input, string output, string top, string stack)
        {
            ListViewItem item = new ListViewItem(No.ToString());
            item.SubItems.Add(input);
            item.SubItems.Add(output);
            item.SubItems.Add(top);
            item.SubItems.Add(stack);
            this.listView1.Items.Add(item);
            setWidth();
        }

    }
}
