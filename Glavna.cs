﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edn2023B
{
    public partial class Glavna : Form
    {
        public Glavna()
        {
            InitializeComponent();
        }

        private void osobaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Osoba frm_osoba = new Osoba();
            frm_osoba.Show();
        }

        private void raspodelaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            raspodela nova = new raspodela();
            nova.Show();
        }

        private void predmetiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik novi = new  Sifarnik("predmet");
            novi.Show();
        }

        private void skGodineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik novi = new Sifarnik("skolska_godina");
            novi.ShowDialog();
        }

        private void smerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Sifarnik novi = new Sifarnik("smer");
            novi.Show();
        }
    }
}
