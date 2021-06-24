﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TSgui {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            int x = 10;
            int y = 10;
            for (int i = 0; i < x; i++) {
                for (int j = 0; j < y; j++) {
                    Label tmpLabel = new Label();
                    tmpLabel.BackColor = System.Drawing.SystemColors.ActiveCaption;
                    tmpLabel.Margin = new System.Windows.Forms.Padding(1);
                    tmpLabel.Name = $"C{i:D2}_{j:D2}";
                    tmpLabel.Size = new System.Drawing.Size(64, 64);
                    tmpLabel.TabIndex = 0;
                    tmpLabel.Text = $"00 00 00\n00    00\n00    00";
                    tmpLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    tmpLabel.Visible = true;
                    //tmpLabel.MouseDown += new MouseEventHandler(MasulabelClick);
                    this.flowLayoutPanel1.Controls.Add(tmpLabel);
                    if (j == y - 1) this.flowLayoutPanel1.SetFlowBreak(tmpLabel, true);
                }
            }

        }
    }
}
