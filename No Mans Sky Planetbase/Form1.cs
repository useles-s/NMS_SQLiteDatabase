﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace No_Mans_Sky_Planetbase {
    public partial class Form1 : Form {
        private Form _form;
        
        public Form1() {
            InitializeComponent();
        }

        private void add_planet_btn_Click(object sender, EventArgs e) {
            _form = new AddPlanetForm();
            _form.Show(this);
        }

        private void rem_planet_btn_Click(object sender, EventArgs e) {
            throw new System.NotImplementedException();
        }

        private void search_btn_Click(object sender, EventArgs e) {
            throw new System.NotImplementedException();
        }
    }
}