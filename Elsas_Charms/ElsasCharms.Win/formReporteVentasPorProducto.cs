using ElsasCharms.BL;
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
    public partial class formReporteVentasPorProducto : Form
    {
        ReporteVentasPorProductoBL _reporteVentasPorProductoBL;

        public formReporteVentasPorProducto()
        {
            InitializeComponent();

            _reporteVentasPorProductoBL = new ReporteVentasPorProductoBL();
            RefrescarDatos();
        }

        private void btnRefrescarDatos_Click(object sender, EventArgs e)
        {
            RefrescarDatos();
        }

        private void RefrescarDatos()
        {
            var listaVentasPorProducto = _reporteVentasPorProductoBL.ObtenerVentasPorProducto();

            listaVentasPorProductoBindingSource.DataSource = listaVentasPorProducto;

            listaVentasPorProductoBindingSource.ResetBindings(false);
        }
    }
}
