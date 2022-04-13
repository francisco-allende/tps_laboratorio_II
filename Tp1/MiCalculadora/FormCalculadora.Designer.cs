
namespace MiCalculadora
{
    partial class FormCalculadora
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.comboBoxOperadores = new System.Windows.Forms.ComboBox();
            this.textNumero1 = new System.Windows.Forms.TextBox();
            this.textNumero2 = new System.Windows.Forms.TextBox();
            this.buttonOperar = new System.Windows.Forms.Button();
            this.buttonLimpiar = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.buttonConvertirABinario = new System.Windows.Forms.Button();
            this.buttonConvertirADecimal = new System.Windows.Forms.Button();
            this.listBoxOperaciones = new System.Windows.Forms.ListBox();
            this.labelResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxOperadores
            // 
            this.comboBoxOperadores.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxOperadores.FormattingEnabled = true;
            this.comboBoxOperadores.Items.AddRange(new object[] {
            "",
            "+",
            "-",
            "/",
            "*"});
            this.comboBoxOperadores.Location = new System.Drawing.Point(150, 90);
            this.comboBoxOperadores.Name = "comboBoxOperadores";
            this.comboBoxOperadores.Size = new System.Drawing.Size(121, 23);
            this.comboBoxOperadores.TabIndex = 1;
            // 
            // textNumero1
            // 
            this.textNumero1.Location = new System.Drawing.Point(12, 90);
            this.textNumero1.Name = "textNumero1";
            this.textNumero1.Size = new System.Drawing.Size(122, 23);
            this.textNumero1.TabIndex = 0;
            // 
            // textNumero2
            // 
            this.textNumero2.Location = new System.Drawing.Point(277, 90);
            this.textNumero2.Name = "textNumero2";
            this.textNumero2.Size = new System.Drawing.Size(122, 23);
            this.textNumero2.TabIndex = 2;
            // 
            // buttonOperar
            // 
            this.buttonOperar.Location = new System.Drawing.Point(12, 145);
            this.buttonOperar.Name = "buttonOperar";
            this.buttonOperar.Size = new System.Drawing.Size(131, 39);
            this.buttonOperar.TabIndex = 4;
            this.buttonOperar.Text = "Operar";
            this.buttonOperar.UseVisualStyleBackColor = true;
            this.buttonOperar.Click += new System.EventHandler(this.buttonOperar_Click);
            // 
            // buttonLimpiar
            // 
            this.buttonLimpiar.Location = new System.Drawing.Point(149, 145);
            this.buttonLimpiar.Name = "buttonLimpiar";
            this.buttonLimpiar.Size = new System.Drawing.Size(122, 39);
            this.buttonLimpiar.TabIndex = 5;
            this.buttonLimpiar.Text = "Limpiar";
            this.buttonLimpiar.UseVisualStyleBackColor = true;
            this.buttonLimpiar.Click += new System.EventHandler(this.buttonLimpiar_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.Location = new System.Drawing.Point(286, 145);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(122, 39);
            this.buttonCerrar.TabIndex = 6;
            this.buttonCerrar.Text = "Cerrar";
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // buttonConvertirABinario
            // 
            this.buttonConvertirABinario.Location = new System.Drawing.Point(27, 197);
            this.buttonConvertirABinario.Name = "buttonConvertirABinario";
            this.buttonConvertirABinario.Size = new System.Drawing.Size(150, 49);
            this.buttonConvertirABinario.TabIndex = 7;
            this.buttonConvertirABinario.Text = "Convertir a Binario";
            this.buttonConvertirABinario.UseVisualStyleBackColor = true;
            this.buttonConvertirABinario.Click += new System.EventHandler(this.buttonConvertirABinario_Click);
            // 
            // buttonConvertirADecimal
            // 
            this.buttonConvertirADecimal.Location = new System.Drawing.Point(225, 197);
            this.buttonConvertirADecimal.Name = "buttonConvertirADecimal";
            this.buttonConvertirADecimal.Size = new System.Drawing.Size(147, 49);
            this.buttonConvertirADecimal.TabIndex = 8;
            this.buttonConvertirADecimal.Text = "Convertir a Decimal";
            this.buttonConvertirADecimal.UseVisualStyleBackColor = true;
            this.buttonConvertirADecimal.Click += new System.EventHandler(this.buttonConvertirADecimal_Click);
            // 
            // listBoxOperaciones
            // 
            this.listBoxOperaciones.FormattingEnabled = true;
            this.listBoxOperaciones.ItemHeight = 15;
            this.listBoxOperaciones.Location = new System.Drawing.Point(423, 82);
            this.listBoxOperaciones.Name = "listBoxOperaciones";
            this.listBoxOperaciones.Size = new System.Drawing.Size(189, 244);
            this.listBoxOperaciones.TabIndex = 3;
            // 
            // labelResult
            // 
            this.labelResult.AutoSize = true;
            this.labelResult.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelResult.Location = new System.Drawing.Point(362, 24);
            this.labelResult.Name = "labelResult";
            this.labelResult.Size = new System.Drawing.Size(37, 45);
            this.labelResult.TabIndex = 9;
            this.labelResult.Text = "0";
            // 
            // FormCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(624, 338);
            this.Controls.Add(this.labelResult);
            this.Controls.Add(this.listBoxOperaciones);
            this.Controls.Add(this.buttonConvertirADecimal);
            this.Controls.Add(this.buttonConvertirABinario);
            this.Controls.Add(this.buttonCerrar);
            this.Controls.Add(this.buttonLimpiar);
            this.Controls.Add(this.buttonOperar);
            this.Controls.Add(this.textNumero2);
            this.Controls.Add(this.textNumero1);
            this.Controls.Add(this.comboBoxOperadores);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormCalculadora";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calculadora de Francisco Allende del curso 2A";
            this.Load += new System.EventHandler(this.FormCalculadora_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxOperadores;
        private System.Windows.Forms.TextBox textNumero1;
        private System.Windows.Forms.TextBox textNumero2;
        private System.Windows.Forms.Button buttonOperar;
        private System.Windows.Forms.Button buttonLimpiar;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonConvertirABinario;
        private System.Windows.Forms.Button buttonConvertirADecimal;
        private System.Windows.Forms.ListBox listBoxOperaciones;
        private System.Windows.Forms.Label labelResult;
    }
}

