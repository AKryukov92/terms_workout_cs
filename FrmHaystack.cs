﻿using Sphinx.dto;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sphinx
{
    public partial class FrmHaystack : Form
    {
        private Presenter presenter;
        public FrmHaystack()
        {
            InitializeComponent();
            presenter = new Presenter(this);
            presenter.Init();
        }
        private void RtxtHaystack_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void BtnSelectNew_Click(object sender, EventArgs e)
        {

        }

        private void LbHaystacks_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
