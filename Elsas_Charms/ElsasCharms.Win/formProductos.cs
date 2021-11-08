﻿using ElsasCharms.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ElsasCharms.Win
{
    public partial class formProductos : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public formProductos()
        {
            InitializeComponent();

            var productosBL = new ProductosBL();
            var listadeProductos = productosBL.ObtenerProductos();

            listadeProductosBindingSource.DataSource = listadeProductos;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void formProductos_Load(object sender, EventArgs e)
        {

        }
    }
}
