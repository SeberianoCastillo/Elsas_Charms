namespace ElsasCharms.Win
{
    partial class formReporteVentasPorProducto
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
            this.components = new System.ComponentModel.Container();
            this.listaVentasPorProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaVentasPorProductoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnRefrescarDatos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.listaVentasPorProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaVentasPorProductoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // listaVentasPorProductoBindingSource
            // 
            this.listaVentasPorProductoBindingSource.DataSource = typeof(ElsasCharms.BL.ReporteVentasPorProducto);
            // 
            // listaVentasPorProductoDataGridView
            // 
            this.listaVentasPorProductoDataGridView.AutoGenerateColumns = false;
            this.listaVentasPorProductoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.listaVentasPorProductoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.listaVentasPorProductoDataGridView.DataSource = this.listaVentasPorProductoBindingSource;
            this.listaVentasPorProductoDataGridView.Location = new System.Drawing.Point(12, 56);
            this.listaVentasPorProductoDataGridView.Name = "listaVentasPorProductoDataGridView";
            this.listaVentasPorProductoDataGridView.RowTemplate.Height = 24;
            this.listaVentasPorProductoDataGridView.Size = new System.Drawing.Size(956, 363);
            this.listaVentasPorProductoDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Producto";
            this.dataGridViewTextBoxColumn1.HeaderText = "Producto";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Cantidad";
            this.dataGridViewTextBoxColumn2.HeaderText = "Cantidad";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Total";
            this.dataGridViewTextBoxColumn3.HeaderText = "Total";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // btnRefrescarDatos
            // 
            this.btnRefrescarDatos.AutoSize = true;
            this.btnRefrescarDatos.Location = new System.Drawing.Point(12, 12);
            this.btnRefrescarDatos.Name = "btnRefrescarDatos";
            this.btnRefrescarDatos.Size = new System.Drawing.Size(107, 38);
            this.btnRefrescarDatos.TabIndex = 2;
            this.btnRefrescarDatos.Text = "Refrescar";
            this.btnRefrescarDatos.UseVisualStyleBackColor = true;
            this.btnRefrescarDatos.Click += new System.EventHandler(this.btnRefrescarDatos_Click);
            // 
            // formReporteVentasPorProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(980, 438);
            this.Controls.Add(this.btnRefrescarDatos);
            this.Controls.Add(this.listaVentasPorProductoDataGridView);
            this.Name = "formReporteVentasPorProducto";
            this.Text = "formReporteVentasPorProducto";
            ((System.ComponentModel.ISupportInitialize)(this.listaVentasPorProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaVentasPorProductoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource listaVentasPorProductoBindingSource;
        private System.Windows.Forms.DataGridView listaVentasPorProductoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Button btnRefrescarDatos;
    }
}