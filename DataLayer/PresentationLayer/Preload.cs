﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogicalLayer.Enums;

namespace PresentationLayer
{
    public partial class Preload : Form
    {
        public Preload()
        {
            InitializeComponent();
            checkRemember.Checked = Properties.Settings.Default.Remember;
            comboCurrency.DataSource = Enum.GetValues(typeof(Currency));

        }

        private void clickEnter(object sender, EventArgs e)
        {
            Properties.Settings.Default.Currency = (Currency)comboCurrency.SelectedItem;
            Properties.Settings.Default.Remember = checkRemember.Checked;
            new Main().Show();
            this.Close();
        }
    }
}