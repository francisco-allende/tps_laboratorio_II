
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
            this.btn_ChooseType = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.radioBtn_Helado = new System.Windows.Forms.RadioButton();
            this.radioBtn_Yogur = new System.Windows.Forms.RadioButton();
            this.radioBtn_Cafe = new System.Windows.Forms.RadioButton();
            this.dataGrid_Pedidos = new System.Windows.Forms.DataGridView();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPedido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NombreCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sabor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Donde_Consume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nro_Mesa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Confirmar = new System.Windows.Forms.Button();
            this.textBox_CantidadPostre = new System.Windows.Forms.TextBox();
            this.textBox_CantidadCafe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_ChooseSabor = new System.Windows.Forms.Button();
            this.btn_ChooseCantidad = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox_SaborCafe = new System.Windows.Forms.TextBox();
            this.textBox_SaborHelado = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_SaborYogur = new System.Windows.Forms.TextBox();
            this.btn_PlaceToConsume = new System.Windows.Forms.Button();
            this.radioBtn_ParaLlevar = new System.Windows.Forms.RadioButton();
            this.radioBtn_ComerAca = new System.Windows.Forms.RadioButton();
            this.btn_ChooseTable = new System.Windows.Forms.Button();
            this.textBox_Mesa = new System.Windows.Forms.TextBox();
            this.btn_Volver = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.textBox_Precio = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Cobrar = new System.Windows.Forms.Button();
            this.textBox_Tipo = new System.Windows.Forms.TextBox();
            this.textBox_NombreCliente = new System.Windows.Forms.TextBox();
            this.btn_NombreCliente = new System.Windows.Forms.Button();
            this.btn_Remover = new System.Windows.Forms.Button();
            this.listBox_Factura = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_Pedidos)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ChooseType
            // 
            this.btn_ChooseType.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ChooseType.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ChooseType.Location = new System.Drawing.Point(245, 7);
            this.btn_ChooseType.Name = "btn_ChooseType";
            this.btn_ChooseType.Size = new System.Drawing.Size(95, 41);
            this.btn_ChooseType.TabIndex = 3;
            this.btn_ChooseType.Text = "Elegir Tipo";
            this.btn_ChooseType.UseVisualStyleBackColor = false;
            this.btn_ChooseType.Click += new System.EventHandler(this.btn_ChooseType_Click);
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Cancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cancel.Location = new System.Drawing.Point(406, 509);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(108, 50);
            this.btn_Cancel.TabIndex = 24;
            this.btn_Cancel.Text = "Cancelar ";
            this.btn_Cancel.UseVisualStyleBackColor = false;
            this.btn_Cancel.Click += new System.EventHandler(this.btn_Cancel_Click);
            // 
            // radioBtn_Helado
            // 
            this.radioBtn_Helado.AutoSize = true;
            this.radioBtn_Helado.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioBtn_Helado.Location = new System.Drawing.Point(245, 58);
            this.radioBtn_Helado.Name = "radioBtn_Helado";
            this.radioBtn_Helado.Size = new System.Drawing.Size(76, 24);
            this.radioBtn_Helado.TabIndex = 4;
            this.radioBtn_Helado.TabStop = true;
            this.radioBtn_Helado.Text = "Helado";
            this.radioBtn_Helado.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Yogur
            // 
            this.radioBtn_Yogur.AutoSize = true;
            this.radioBtn_Yogur.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioBtn_Yogur.Location = new System.Drawing.Point(245, 86);
            this.radioBtn_Yogur.Name = "radioBtn_Yogur";
            this.radioBtn_Yogur.Size = new System.Drawing.Size(68, 24);
            this.radioBtn_Yogur.TabIndex = 5;
            this.radioBtn_Yogur.TabStop = true;
            this.radioBtn_Yogur.Text = "Yogur";
            this.radioBtn_Yogur.UseVisualStyleBackColor = true;
            // 
            // radioBtn_Cafe
            // 
            this.radioBtn_Cafe.AutoSize = true;
            this.radioBtn_Cafe.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioBtn_Cafe.Location = new System.Drawing.Point(245, 111);
            this.radioBtn_Cafe.Name = "radioBtn_Cafe";
            this.radioBtn_Cafe.Size = new System.Drawing.Size(59, 24);
            this.radioBtn_Cafe.TabIndex = 6;
            this.radioBtn_Cafe.TabStop = true;
            this.radioBtn_Cafe.Text = "Café";
            this.radioBtn_Cafe.UseVisualStyleBackColor = true;
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
            this.IdCliente,
            this.IdPedido,
            this.NombreCliente,
            this.Tipo,
            this.Sabor,
            this.Cantidad,
            this.Donde_Consume,
            this.Nro_Mesa,
            this.Precio,
            this.Total});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGrid_Pedidos.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGrid_Pedidos.Location = new System.Drawing.Point(2, 212);
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
            this.dataGrid_Pedidos.Size = new System.Drawing.Size(1130, 291);
            this.dataGrid_Pedidos.TabIndex = 21;
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "Id Cliente";
            this.IdCliente.Name = "IdCliente";
            this.IdCliente.ReadOnly = true;
            this.IdCliente.Width = 80;
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
            // Donde_Consume
            // 
            this.Donde_Consume.HeaderText = "Donde Consume";
            this.Donde_Consume.Name = "Donde_Consume";
            this.Donde_Consume.ReadOnly = true;
            this.Donde_Consume.Width = 120;
            // 
            // Nro_Mesa
            // 
            this.Nro_Mesa.HeaderText = "Nro Mesa";
            this.Nro_Mesa.Name = "Nro_Mesa";
            this.Nro_Mesa.ReadOnly = true;
            this.Nro_Mesa.Width = 80;
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            this.Total.Width = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(2, 157);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Tabla pedidos";
            // 
            // btn_Confirmar
            // 
            this.btn_Confirmar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Confirmar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Confirmar.Location = new System.Drawing.Point(1, 509);
            this.btn_Confirmar.Name = "btn_Confirmar";
            this.btn_Confirmar.Size = new System.Drawing.Size(108, 50);
            this.btn_Confirmar.TabIndex = 22;
            this.btn_Confirmar.Text = "Confirmar";
            this.btn_Confirmar.UseVisualStyleBackColor = false;
            this.btn_Confirmar.Click += new System.EventHandler(this.btn_Confirmar_Click);
            // 
            // textBox_CantidadPostre
            // 
            this.textBox_CantidadPostre.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_CantidadPostre.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox_CantidadPostre.Location = new System.Drawing.Point(575, 103);
            this.textBox_CantidadPostre.Name = "textBox_CantidadPostre";
            this.textBox_CantidadPostre.ReadOnly = true;
            this.textBox_CantidadPostre.Size = new System.Drawing.Size(100, 24);
            this.textBox_CantidadPostre.TabIndex = 13;
            // 
            // textBox_CantidadCafe
            // 
            this.textBox_CantidadCafe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_CantidadCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox_CantidadCafe.Location = new System.Drawing.Point(575, 156);
            this.textBox_CantidadCafe.Name = "textBox_CantidadCafe";
            this.textBox_CantidadCafe.ReadOnly = true;
            this.textBox_CantidadCafe.Size = new System.Drawing.Size(100, 24);
            this.textBox_CantidadCafe.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(573, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Cantidad Café";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(573, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Cantidad Postre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(573, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "(Helado o Yogur)";
            // 
            // btn_ChooseSabor
            // 
            this.btn_ChooseSabor.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ChooseSabor.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ChooseSabor.Location = new System.Drawing.Point(379, 8);
            this.btn_ChooseSabor.Name = "btn_ChooseSabor";
            this.btn_ChooseSabor.Size = new System.Drawing.Size(112, 40);
            this.btn_ChooseSabor.TabIndex = 8;
            this.btn_ChooseSabor.Text = "Elegir Sabor";
            this.btn_ChooseSabor.UseVisualStyleBackColor = false;
            this.btn_ChooseSabor.Click += new System.EventHandler(this.btn_ChooseSabor_Click);
            // 
            // btn_ChooseCantidad
            // 
            this.btn_ChooseCantidad.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ChooseCantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ChooseCantidad.Location = new System.Drawing.Point(573, 7);
            this.btn_ChooseCantidad.Name = "btn_ChooseCantidad";
            this.btn_ChooseCantidad.Size = new System.Drawing.Size(127, 41);
            this.btn_ChooseCantidad.TabIndex = 12;
            this.btn_ChooseCantidad.Text = "Elegir Cantidad";
            this.btn_ChooseCantidad.UseVisualStyleBackColor = false;
            this.btn_ChooseCantidad.Click += new System.EventHandler(this.btn_ChooseCantidad_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(379, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Sabor Helado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(379, 156);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Sabor Café";
            // 
            // textBox_SaborCafe
            // 
            this.textBox_SaborCafe.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_SaborCafe.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox_SaborCafe.Location = new System.Drawing.Point(381, 179);
            this.textBox_SaborCafe.Name = "textBox_SaborCafe";
            this.textBox_SaborCafe.ReadOnly = true;
            this.textBox_SaborCafe.Size = new System.Drawing.Size(161, 24);
            this.textBox_SaborCafe.TabIndex = 11;
            // 
            // textBox_SaborHelado
            // 
            this.textBox_SaborHelado.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_SaborHelado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox_SaborHelado.Location = new System.Drawing.Point(379, 74);
            this.textBox_SaborHelado.Name = "textBox_SaborHelado";
            this.textBox_SaborHelado.ReadOnly = true;
            this.textBox_SaborHelado.Size = new System.Drawing.Size(159, 24);
            this.textBox_SaborHelado.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(379, 105);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 20);
            this.label6.TabIndex = 22;
            this.label6.Text = "Sabor Yogur";
            // 
            // textBox_SaborYogur
            // 
            this.textBox_SaborYogur.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_SaborYogur.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox_SaborYogur.Location = new System.Drawing.Point(381, 130);
            this.textBox_SaborYogur.Name = "textBox_SaborYogur";
            this.textBox_SaborYogur.ReadOnly = true;
            this.textBox_SaborYogur.Size = new System.Drawing.Size(159, 24);
            this.textBox_SaborYogur.TabIndex = 10;
            // 
            // btn_PlaceToConsume
            // 
            this.btn_PlaceToConsume.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_PlaceToConsume.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_PlaceToConsume.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_PlaceToConsume.Location = new System.Drawing.Point(756, 8);
            this.btn_PlaceToConsume.Name = "btn_PlaceToConsume";
            this.btn_PlaceToConsume.Size = new System.Drawing.Size(102, 62);
            this.btn_PlaceToConsume.TabIndex = 15;
            this.btn_PlaceToConsume.Text = "Donde se consume";
            this.btn_PlaceToConsume.UseVisualStyleBackColor = false;
            this.btn_PlaceToConsume.Click += new System.EventHandler(this.btn_PlaceToConsume_Click);
            // 
            // radioBtn_ParaLlevar
            // 
            this.radioBtn_ParaLlevar.AutoSize = true;
            this.radioBtn_ParaLlevar.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioBtn_ParaLlevar.Location = new System.Drawing.Point(756, 106);
            this.radioBtn_ParaLlevar.Name = "radioBtn_ParaLlevar";
            this.radioBtn_ParaLlevar.Size = new System.Drawing.Size(106, 24);
            this.radioBtn_ParaLlevar.TabIndex = 17;
            this.radioBtn_ParaLlevar.TabStop = true;
            this.radioBtn_ParaLlevar.Text = "Para Llevar";
            this.radioBtn_ParaLlevar.UseVisualStyleBackColor = true;
            // 
            // radioBtn_ComerAca
            // 
            this.radioBtn_ComerAca.AutoSize = true;
            this.radioBtn_ComerAca.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.radioBtn_ComerAca.Location = new System.Drawing.Point(756, 76);
            this.radioBtn_ComerAca.Name = "radioBtn_ComerAca";
            this.radioBtn_ComerAca.Size = new System.Drawing.Size(135, 24);
            this.radioBtn_ComerAca.TabIndex = 16;
            this.radioBtn_ComerAca.TabStop = true;
            this.radioBtn_ComerAca.Text = "Para comer acá";
            this.radioBtn_ComerAca.UseVisualStyleBackColor = true;
            // 
            // btn_ChooseTable
            // 
            this.btn_ChooseTable.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_ChooseTable.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_ChooseTable.Location = new System.Drawing.Point(906, 11);
            this.btn_ChooseTable.Name = "btn_ChooseTable";
            this.btn_ChooseTable.Size = new System.Drawing.Size(104, 49);
            this.btn_ChooseTable.TabIndex = 18;
            this.btn_ChooseTable.Text = "Elegir Mesa";
            this.btn_ChooseTable.UseVisualStyleBackColor = false;
            this.btn_ChooseTable.Click += new System.EventHandler(this.btn_ChooseTable_Click);
            // 
            // textBox_Mesa
            // 
            this.textBox_Mesa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_Mesa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox_Mesa.Location = new System.Drawing.Point(906, 74);
            this.textBox_Mesa.Name = "textBox_Mesa";
            this.textBox_Mesa.ReadOnly = true;
            this.textBox_Mesa.Size = new System.Drawing.Size(104, 24);
            this.textBox_Mesa.TabIndex = 19;
            // 
            // btn_Volver
            // 
            this.btn_Volver.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Volver.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Volver.Location = new System.Drawing.Point(822, 509);
            this.btn_Volver.Name = "btn_Volver";
            this.btn_Volver.Size = new System.Drawing.Size(108, 50);
            this.btn_Volver.TabIndex = 26;
            this.btn_Volver.Text = "Volver";
            this.btn_Volver.UseVisualStyleBackColor = false;
            this.btn_Volver.Click += new System.EventHandler(this.btn_Volver_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Salir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.Location = new System.Drawing.Point(1024, 509);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(108, 50);
            this.btn_Salir.TabIndex = 27;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // textBox_Precio
            // 
            this.textBox_Precio.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox_Precio.Location = new System.Drawing.Point(1036, 74);
            this.textBox_Precio.Name = "textBox_Precio";
            this.textBox_Precio.ReadOnly = true;
            this.textBox_Precio.Size = new System.Drawing.Size(96, 24);
            this.textBox_Precio.TabIndex = 20;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Thistle;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 16.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(1036, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 30);
            this.label8.TabIndex = 31;
            this.label8.Text = "Precio ";
            // 
            // btn_Cobrar
            // 
            this.btn_Cobrar.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_Cobrar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Cobrar.Location = new System.Drawing.Point(624, 509);
            this.btn_Cobrar.Name = "btn_Cobrar";
            this.btn_Cobrar.Size = new System.Drawing.Size(108, 50);
            this.btn_Cobrar.TabIndex = 25;
            this.btn_Cobrar.Text = "Cobrar";
            this.btn_Cobrar.UseVisualStyleBackColor = false;
            this.btn_Cobrar.Click += new System.EventHandler(this.btn_Cobrar_Click);
            // 
            // textBox_Tipo
            // 
            this.textBox_Tipo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_Tipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox_Tipo.Location = new System.Drawing.Point(245, 141);
            this.textBox_Tipo.Name = "textBox_Tipo";
            this.textBox_Tipo.ReadOnly = true;
            this.textBox_Tipo.Size = new System.Drawing.Size(100, 24);
            this.textBox_Tipo.TabIndex = 7;
            // 
            // textBox_NombreCliente
            // 
            this.textBox_NombreCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBox_NombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.textBox_NombreCliente.Location = new System.Drawing.Point(12, 75);
            this.textBox_NombreCliente.Name = "textBox_NombreCliente";
            this.textBox_NombreCliente.Size = new System.Drawing.Size(193, 24);
            this.textBox_NombreCliente.TabIndex = 2;
            // 
            // btn_NombreCliente
            // 
            this.btn_NombreCliente.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_NombreCliente.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_NombreCliente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btn_NombreCliente.Location = new System.Drawing.Point(12, 11);
            this.btn_NombreCliente.Name = "btn_NombreCliente";
            this.btn_NombreCliente.Size = new System.Drawing.Size(138, 57);
            this.btn_NombreCliente.TabIndex = 1;
            this.btn_NombreCliente.Text = "Guardar Nombre Cliente";
            this.btn_NombreCliente.UseVisualStyleBackColor = false;
            this.btn_NombreCliente.Click += new System.EventHandler(this.btn_NombreCliente_Click);
            // 
            // btn_Remover
            // 
            this.btn_Remover.BackColor = System.Drawing.Color.RoyalBlue;
            this.btn_Remover.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Remover.Location = new System.Drawing.Point(203, 509);
            this.btn_Remover.Name = "btn_Remover";
            this.btn_Remover.Size = new System.Drawing.Size(108, 50);
            this.btn_Remover.TabIndex = 23;
            this.btn_Remover.Text = "Remover";
            this.btn_Remover.UseVisualStyleBackColor = false;
            this.btn_Remover.Click += new System.EventHandler(this.btn_Remover_Click);
            // 
            // listBox_Factura
            // 
            this.listBox_Factura.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.listBox_Factura.FormattingEnabled = true;
            this.listBox_Factura.ItemHeight = 20;
            this.listBox_Factura.Location = new System.Drawing.Point(2, 621);
            this.listBox_Factura.Name = "listBox_Factura";
            this.listBox_Factura.Size = new System.Drawing.Size(1131, 64);
            this.listBox_Factura.TabIndex = 22;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(1, 576);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(122, 45);
            this.label10.TabIndex = 40;
            this.label10.Text = "Factura";
            // 
            // TomarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.ClientSize = new System.Drawing.Size(1142, 697);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.listBox_Factura);
            this.Controls.Add(this.btn_Remover);
            this.Controls.Add(this.btn_NombreCliente);
            this.Controls.Add(this.textBox_NombreCliente);
            this.Controls.Add(this.textBox_Tipo);
            this.Controls.Add(this.btn_Cobrar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox_Precio);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_Volver);
            this.Controls.Add(this.textBox_Mesa);
            this.Controls.Add(this.btn_ChooseTable);
            this.Controls.Add(this.radioBtn_ComerAca);
            this.Controls.Add(this.radioBtn_ParaLlevar);
            this.Controls.Add(this.btn_PlaceToConsume);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox_SaborYogur);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_SaborCafe);
            this.Controls.Add(this.textBox_SaborHelado);
            this.Controls.Add(this.btn_ChooseCantidad);
            this.Controls.Add(this.btn_ChooseSabor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_CantidadCafe);
            this.Controls.Add(this.textBox_CantidadPostre);
            this.Controls.Add(this.btn_Confirmar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGrid_Pedidos);
            this.Controls.Add(this.radioBtn_Cafe);
            this.Controls.Add(this.radioBtn_Yogur);
            this.Controls.Add(this.radioBtn_Helado);
            this.Controls.Add(this.btn_Cancel);
            this.Controls.Add(this.btn_ChooseType);
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

        private System.Windows.Forms.Button btn_ChooseType;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.RadioButton radioBtn_Helado;
        private System.Windows.Forms.RadioButton radioBtn_Yogur;
        private System.Windows.Forms.RadioButton radioBtn_Cafe;
        private System.Windows.Forms.DataGridView dataGrid_Pedidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Confirmar;
        private System.Windows.Forms.TextBox textBox_CantidadPostre;
        private System.Windows.Forms.TextBox textBox_CantidadCafe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_ChooseSabor;
        private System.Windows.Forms.Button btn_ChooseCantidad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox_SaborCafe;
        private System.Windows.Forms.TextBox textBox_SaborHelado;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_SaborYogur;
        private System.Windows.Forms.Button btn_PlaceToConsume;
        private System.Windows.Forms.RadioButton radioBtn_ParaLlevar;
        private System.Windows.Forms.RadioButton radioBtn_ComerAca;
        private System.Windows.Forms.Button btn_ChooseTable;
        private System.Windows.Forms.TextBox textBox_Mesa;
        private System.Windows.Forms.Button btn_Volver;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.TextBox textBox_Precio;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_Cobrar;
        private System.Windows.Forms.TextBox textBox_Tipo;
        private System.Windows.Forms.TextBox textBox_NombreCliente;
        private System.Windows.Forms.Button btn_NombreCliente;
        private System.Windows.Forms.Button btn_Remover;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPedido;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sabor;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Donde_Consume;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nro_Mesa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.ListBox listBox_Factura;
        private System.Windows.Forms.Label label10;
    }
}