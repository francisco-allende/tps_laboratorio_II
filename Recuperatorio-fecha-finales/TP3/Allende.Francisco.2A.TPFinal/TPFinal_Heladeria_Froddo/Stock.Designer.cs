
namespace TPFinal_Heladeria_Froddo
{
    partial class Stock
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
            this.datagrid_Stock = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sabor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Remove = new System.Windows.Forms.Button();
            this.btn_SortId = new System.Windows.Forms.Button();
            this.btn_SortCantidad = new System.Windows.Forms.Button();
            this.btn_EditCantidad = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Guardar = new System.Windows.Forms.Button();
            this.textBox_capacidadMaxima = new System.Windows.Forms.TextBox();
            this.textBox_capacidadOcupada = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_disponible = new System.Windows.Forms.Label();
            this.textBox_CapacidadDisponible = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Stock)).BeginInit();
            this.SuspendLayout();
            // 
            // datagrid_Stock
            // 
            this.datagrid_Stock.AllowUserToAddRows = false;
            this.datagrid_Stock.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_Stock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.datagrid_Stock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_Stock.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Tipo,
            this.Sabor,
            this.Cantidad});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.datagrid_Stock.DefaultCellStyle = dataGridViewCellStyle2;
            this.datagrid_Stock.Location = new System.Drawing.Point(168, 12);
            this.datagrid_Stock.Name = "datagrid_Stock";
            this.datagrid_Stock.ReadOnly = true;
            this.datagrid_Stock.RowTemplate.Height = 25;
            this.datagrid_Stock.Size = new System.Drawing.Size(582, 452);
            this.datagrid_Stock.TabIndex = 9;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 80;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Postre";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            this.Tipo.Width = 150;
            // 
            // Sabor
            // 
            this.Sabor.HeaderText = "Sabor";
            this.Sabor.Name = "Sabor";
            this.Sabor.ReadOnly = true;
            this.Sabor.Width = 200;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Stock (en kilos)";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            this.Cantidad.Width = 105;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Add.Location = new System.Drawing.Point(27, 57);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(114, 42);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "Agregar";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // btn_Remove
            // 
            this.btn_Remove.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Remove.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Remove.Location = new System.Drawing.Point(27, 105);
            this.btn_Remove.Name = "btn_Remove";
            this.btn_Remove.Size = new System.Drawing.Size(114, 42);
            this.btn_Remove.TabIndex = 2;
            this.btn_Remove.Text = "Remover";
            this.btn_Remove.UseVisualStyleBackColor = false;
            this.btn_Remove.Click += new System.EventHandler(this.btn_Remove_Click);
            // 
            // btn_SortId
            // 
            this.btn_SortId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SortId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_SortId.Location = new System.Drawing.Point(27, 218);
            this.btn_SortId.Name = "btn_SortId";
            this.btn_SortId.Size = new System.Drawing.Size(114, 52);
            this.btn_SortId.TabIndex = 4;
            this.btn_SortId.Text = "Ordenar por Id";
            this.btn_SortId.UseVisualStyleBackColor = false;
            this.btn_SortId.Click += new System.EventHandler(this.btn_SortId_Click);
            // 
            // btn_SortCantidad
            // 
            this.btn_SortCantidad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_SortCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_SortCantidad.Location = new System.Drawing.Point(27, 276);
            this.btn_SortCantidad.Name = "btn_SortCantidad";
            this.btn_SortCantidad.Size = new System.Drawing.Size(114, 53);
            this.btn_SortCantidad.TabIndex = 5;
            this.btn_SortCantidad.Text = "Ordenar por Cantidad";
            this.btn_SortCantidad.UseVisualStyleBackColor = false;
            this.btn_SortCantidad.Click += new System.EventHandler(this.btn_SortCantidad_Click);
            // 
            // btn_EditCantidad
            // 
            this.btn_EditCantidad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EditCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_EditCantidad.Location = new System.Drawing.Point(27, 153);
            this.btn_EditCantidad.Name = "btn_EditCantidad";
            this.btn_EditCantidad.Size = new System.Drawing.Size(114, 59);
            this.btn_EditCantidad.TabIndex = 3;
            this.btn_EditCantidad.Text = "Editar Cantidad";
            this.btn_EditCantidad.UseVisualStyleBackColor = false;
            this.btn_EditCantidad.Click += new System.EventHandler(this.btn_EditCantidad_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.Location = new System.Drawing.Point(27, 432);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(114, 32);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Volver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Volver.Location = new System.Drawing.Point(27, 385);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(114, 41);
            this.btn_Volver.TabIndex = 7;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.BackColor = System.Drawing.Color.Lime;
            this.btn_Guardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Guardar.Location = new System.Drawing.Point(27, 335);
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(114, 44);
            this.btn_Guardar.TabIndex = 6;
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.UseVisualStyleBackColor = false;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
            // 
            // textBox_capacidadMaxima
            // 
            this.textBox_capacidadMaxima.Location = new System.Drawing.Point(609, 470);
            this.textBox_capacidadMaxima.Name = "textBox_capacidadMaxima";
            this.textBox_capacidadMaxima.Size = new System.Drawing.Size(139, 23);
            this.textBox_capacidadMaxima.TabIndex = 10;
            // 
            // textBox_capacidadOcupada
            // 
            this.textBox_capacidadOcupada.Location = new System.Drawing.Point(611, 504);
            this.textBox_capacidadOcupada.Name = "textBox_capacidadOcupada";
            this.textBox_capacidadOcupada.Size = new System.Drawing.Size(139, 23);
            this.textBox_capacidadOcupada.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(334, 470);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Capacidad Total de la Heladera";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(517, 502);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ocupada";
            // 
            // label_disponible
            // 
            this.label_disponible.AutoSize = true;
            this.label_disponible.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_disponible.Location = new System.Drawing.Point(501, 536);
            this.label_disponible.Name = "label_disponible";
            this.label_disponible.Size = new System.Drawing.Size(102, 25);
            this.label_disponible.TabIndex = 19;
            this.label_disponible.Text = "Disponible";
            // 
            // textBox_CapacidadDisponible
            // 
            this.textBox_CapacidadDisponible.Location = new System.Drawing.Point(609, 536);
            this.textBox_CapacidadDisponible.Name = "textBox_CapacidadDisponible";
            this.textBox_CapacidadDisponible.Size = new System.Drawing.Size(139, 23);
            this.textBox_CapacidadDisponible.TabIndex = 12;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(760, 567);
            this.Controls.Add(this.btn_Guardar);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.label_disponible);
            this.Controls.Add(this.textBox_CapacidadDisponible);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btn_EditCantidad);
            this.Controls.Add(this.btn_SortCantidad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_capacidadOcupada);
            this.Controls.Add(this.textBox_capacidadMaxima);
            this.Controls.Add(this.btn_SortId);
            this.Controls.Add(this.btn_Remove);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.datagrid_Stock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Stock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Stock";
            this.Load += new System.EventHandler(this.Stock_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_Stock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagrid_Stock;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Remove;
        private System.Windows.Forms.Button btn_SortId;
        private System.Windows.Forms.Button btn_SortCantidad;
        private System.Windows.Forms.Button btn_EditCantidad;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_Guardar;
        private System.Windows.Forms.TextBox textBox_capacidadMaxima;
        private System.Windows.Forms.TextBox textBox_capacidadOcupada;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_disponible;
        private System.Windows.Forms.TextBox textBox_CapacidadDisponible;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sabor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
    }
}