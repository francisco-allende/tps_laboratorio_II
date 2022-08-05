
namespace TPFinal_Heladeria_Froddo
{
    partial class TomarPedido
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid_Pedidos = new System.Windows.Forms.DataGridView();
            this.IdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sabor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_AgregarPedido = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.textBox_Precio = new System.Windows.Forms.TextBox();
            this.btn_Cobrar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.listBox_Factura = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.labelPrecioTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Pedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Pedidos
            // 
            this.dataGrid_Pedidos.AllowUserToAddRows = false;
            this.dataGrid_Pedidos.AllowUserToDeleteRows = false;
            this.dataGrid_Pedidos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Pedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGrid_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_Pedidos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPedido,
            this.NombreCliente,
            this.DNI,
            this.Tipo,
            this.Sabor,
            this.Cantidad,
            this.Direccion,
            this.Precio});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Pedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_Pedidos.Location = new System.Drawing.Point(2, 72);
            this.dataGrid_Pedidos.Name = "dataGrid_Pedidos";
            this.dataGrid_Pedidos.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Pedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGrid_Pedidos.RowTemplate.Height = 25;
            this.dataGrid_Pedidos.Size = new System.Drawing.Size(926, 291);
            this.dataGrid_Pedidos.TabIndex = 6;
            // 
            // IdPedido
            // 
            this.IdPedido.HeaderText = "Id Pedido";
            this.IdPedido.Name = "IdPedido";
            this.IdPedido.ReadOnly = true;
            this.IdPedido.Width = 80;
            // 
            // NombreCliente
            // 
            this.NombreCliente.HeaderText = "Nombre Cliente";
            this.NombreCliente.Name = "NombreCliente";
            this.NombreCliente.ReadOnly = true;
            this.NombreCliente.Width = 150;
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            this.DNI.ReadOnly = true;
            this.DNI.Width = 80;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // Sabor
            // 
            this.Sabor.HeaderText = "Sabor";
            this.Sabor.Name = "Sabor";
            this.Sabor.ReadOnly = true;
            this.Sabor.Width = 150;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Direccion
            // 
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.ReadOnly = true;
            this.Direccion.Width = 120;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // btn_AgregarPedido
            // 
            this.btn_AgregarPedido.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_AgregarPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AgregarPedido.Location = new System.Drawing.Point(2, 16);
            this.btn_AgregarPedido.Name = "btn_AgregarPedido";
            this.btn_AgregarPedido.Size = new System.Drawing.Size(108, 50);
            this.btn_AgregarPedido.TabIndex = 1;
            this.btn_AgregarPedido.Text = "Agregar Pedido";
            this.btn_AgregarPedido.UseVisualStyleBackColor = false;
            this.btn_AgregarPedido.Click += new System.EventHandler(this.btn_AgregarPedido_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Volver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Volver.Location = new System.Drawing.Point(609, 16);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(108, 50);
            this.btn_Volver.TabIndex = 4;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Salir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.Location = new System.Drawing.Point(820, 16);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(108, 50);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // textBox_Precio
            // 
            this.textBox_Precio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox_Precio.Location = new System.Drawing.Point(1036, -53);
            this.textBox_Precio.Name = "textBox_Precio";
            this.textBox_Precio.ReadOnly = true;
            this.textBox_Precio.Size = new System.Drawing.Size(96, 24);
            this.textBox_Precio.TabIndex = 20;
            // 
            // btn_Cobrar
            // 
            this.btn_Cobrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Cobrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cobrar.Location = new System.Drawing.Point(386, 16);
            this.btn_Cobrar.Name = "btn_Cobrar";
            this.btn_Cobrar.Size = new System.Drawing.Size(108, 50);
            this.btn_Cobrar.TabIndex = 3;
            this.btn_Cobrar.Text = "Cobrar";
            this.btn_Cobrar.UseVisualStyleBackColor = false;
            this.btn_Cobrar.Click += new System.EventHandler(this.btn_Cobrar_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Remover.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Remover.Location = new System.Drawing.Point(185, 16);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(108, 50);
            this.btn_Remover.TabIndex = 2;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = false;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // listBox_Factura
            // 
            this.listBox_Factura.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_Factura.FormattingEnabled = true;
            this.listBox_Factura.ItemHeight = 20;
            this.listBox_Factura.Location = new System.Drawing.Point(2, 434);
            this.listBox_Factura.Name = "listBox_Factura";
            this.listBox_Factura.Size = new System.Drawing.Size(926, 104);
            this.listBox_Factura.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(2, 386);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 45);
            this.label10.TabIndex = 40;
            this.label10.Text = "Factura";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_total.Location = new System.Drawing.Point(687, 366);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(81, 41);
            this.label_total.TabIndex = 41;
            this.label_total.Text = "Total";
            // 
            // labelPrecioTotal
            // 
            this.labelPrecioTotal.AutoSize = true;
            this.labelPrecioTotal.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrecioTotal.Location = new System.Drawing.Point(829, 375);
            this.labelPrecioTotal.Name = "labelPrecioTotal";
            this.labelPrecioTotal.Size = new System.Drawing.Size(25, 30);
            this.labelPrecioTotal.TabIndex = 42;
            this.labelPrecioTotal.Text = "0";
            // 
            // TomarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(939, 551);
            this.Controls.Add(this.labelPrecioTotal);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBox_Factura);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_Cobrar);
            this.Controls.Add(this.textBox_Precio);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.btn_AgregarPedido);
            this.Controls.Add(this.dataGrid_Pedidos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TomarPedido";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tomar Pedido";
            this.Load += new System.EventHandler(this.Vender_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Pedidos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGrid_Pedidos;
        private System.Windows.Forms.Button btn_AgregarPedido;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.TextBox textBox_Precio;
        private System.Windows.Forms.Button btn_Cobrar;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.ListBox listBox_Factura;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sabor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Label labelPrecioTotal;
    }
}