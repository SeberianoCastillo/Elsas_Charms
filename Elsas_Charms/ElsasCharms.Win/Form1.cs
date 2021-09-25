﻿using ElsasCharms.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElsasCharms.Win
{
    public partial class formProductos : Form
    {
        public formProductos()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductos();

            foreach (var productos in listadeProductos)
            {
                MessageBox.Show(productos.Descripcion);
            }
        }
    }
}