
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGrid_Pedidos = new System.Windows.Forms.DataGridView();
            this.btn_AgregarPedido = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.textBox_Precio = new System.Windows.Forms.TextBox();
            this.btn_Cobrar = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.listBox_Factura = new System.Windows.Forms.ListBox();
            this.label_Factura = new System.Windows.Forms.Label();
            this.label_total = new System.Windows.Forms.Label();
            this.textBox_Total = new System.Windows.Forms.TextBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Pedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGrid_Pedidos
            // 
            this.dataGrid_Pedidos.AllowUserToAddRows = false;
            this.dataGrid_Pedidos.AllowUserToDeleteRows = false;
            this.dataGrid_Pedidos.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Pedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGrid_Pedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Pedidos.DefaultCellStyle = dataGridViewCellStyle5;
            this.dataGrid_Pedidos.Location = new System.Drawing.Point(2, 72);
            this.dataGrid_Pedidos.Name = "dataGrid_Pedidos";
            this.dataGrid_Pedidos.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGrid_Pedidos.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGrid_Pedidos.RowTemplate.Height = 25;
            this.dataGrid_Pedidos.Size = new System.Drawing.Size(985, 291);
            this.dataGrid_Pedidos.TabIndex = 6;
            // 
            // btn_AgregarPedido
            // 
            this.btn_AgregarPedido.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_AgregarPedido.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_AgregarPedido.Location = new System.Drawing.Point(2, 12);
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
            this.btn_Volver.Location = new System.Drawing.Point(699, 12);
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
            this.btn_Salir.Location = new System.Drawing.Point(879, 12);
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
            this.btn_Cobrar.Location = new System.Drawing.Point(523, 12);
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
            this.btn_Remover.Location = new System.Drawing.Point(168, 12);
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
            this.listBox_Factura.Size = new System.Drawing.Size(985, 104);
            this.listBox_Factura.TabIndex = 8;
            // 
            // label_Factura
            // 
            this.label_Factura.AutoSize = true;
            this.label_Factura.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Factura.Location = new System.Drawing.Point(2, 386);
            this.label_Factura.Name = "label_Factura";
            this.label_Factura.Size = new System.Drawing.Size(122, 45);
            this.label_Factura.TabIndex = 40;
            this.label_Factura.Text = "Factura";
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_total.Location = new System.Drawing.Point(709, 366);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(81, 41);
            this.label_total.TabIndex = 41;
            this.label_total.Text = "Total";
            // 
            // textBox_Total
            // 
            this.textBox_Total.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_Total.Location = new System.Drawing.Point(796, 379);
            this.textBox_Total.Name = "textBox_Total";
            this.textBox_Total.ReadOnly = true;
            this.textBox_Total.Size = new System.Drawing.Size(191, 29);
            this.textBox_Total.TabIndex = 7;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Modificar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Modificar.Location = new System.Drawing.Point(348, 12);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(108, 50);
            this.btn_Modificar.TabIndex = 42;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = false;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // TomarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(999, 551);
            this.Controls.Add(this.btn_Modificar);
            this.Controls.Add(this.textBox_Total);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.label_Factura);
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
        private System.Windows.Forms.Label label_Factura;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.TextBox textBox_Total;
        private System.Windows.Forms.Button btn_Modificar;
    }
}