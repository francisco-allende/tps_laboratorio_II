
namespace TPFinal_Heladeria_Froddo
{
    partial class Form_MenuPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_MenuPrincipal));
            this.label_Menu = new System.Windows.Forms.Label();
            this.label_HeadLine = new System.Windows.Forms.Label();
            this.button_Salir = new System.Windows.Forms.Button();
            this.btn_AdminStock = new System.Windows.Forms.Button();
            this.btn_TomarPedido = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_Menu
            // 
            this.label_Menu.AutoSize = true;
            this.label_Menu.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_Menu.Font = new System.Drawing.Font("Lucida Calligraphy", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_Menu.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_Menu.Location = new System.Drawing.Point(100, 99);
            this.label_Menu.Name = "label_Menu";
            this.label_Menu.Size = new System.Drawing.Size(306, 41);
            this.label_Menu.TabIndex = 0;
            this.label_Menu.Text = "Página principal";
            // 
            // label_HeadLine
            // 
            this.label_HeadLine.AutoSize = true;
            this.label_HeadLine.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_HeadLine.Font = new System.Drawing.Font("Bernard MT Condensed", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_HeadLine.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_HeadLine.Location = new System.Drawing.Point(45, 23);
            this.label_HeadLine.Name = "label_HeadLine";
            this.label_HeadLine.Size = new System.Drawing.Size(416, 76);
            this.label_HeadLine.TabIndex = 0;
            this.label_HeadLine.Text = "Helados Froddo";
            // 
            // button_Salir
            // 
            this.button_Salir.BackColor = System.Drawing.Color.Firebrick;
            this.button_Salir.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_Salir.Location = new System.Drawing.Point(158, 392);
            this.button_Salir.Name = "button_Salir";
            this.button_Salir.Size = new System.Drawing.Size(155, 62);
            this.button_Salir.TabIndex = 5;
            this.button_Salir.Text = "Salir";
            this.button_Salir.UseVisualStyleBackColor = false;
            this.button_Salir.Click += new System.EventHandler(this.button_Salir_Click);
            // 
            // btn_AdminStock
            // 
            this.btn_AdminStock.BackColor = System.Drawing.Color.SlateBlue;
            this.btn_AdminStock.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_AdminStock.Location = new System.Drawing.Point(158, 285);
            this.btn_AdminStock.Name = "btn_AdminStock";
            this.btn_AdminStock.Size = new System.Drawing.Size(155, 65);
            this.btn_AdminStock.TabIndex = 2;
            this.btn_AdminStock.Text = "Stock";
            this.btn_AdminStock.UseVisualStyleBackColor = false;
            this.btn_AdminStock.Click += new System.EventHandler(this.btn_AdminStock_Click);
            // 
            // btn_TomarPedido
            // 
            this.btn_TomarPedido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_TomarPedido.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_TomarPedido.Location = new System.Drawing.Point(158, 158);
            this.btn_TomarPedido.Name = "btn_TomarPedido";
            this.btn_TomarPedido.Size = new System.Drawing.Size(155, 74);
            this.btn_TomarPedido.TabIndex = 1;
            this.btn_TomarPedido.Text = "Tomar Pedido";
            this.btn_TomarPedido.UseVisualStyleBackColor = false;
            this.btn_TomarPedido.Click += new System.EventHandler(this.btn_TomarPedido_Click);
            // 
            // Form_MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(494, 466);
            this.Controls.Add(this.btn_TomarPedido);
            this.Controls.Add(this.btn_AdminStock);
            this.Controls.Add(this.button_Salir);
            this.Controls.Add(this.label_HeadLine);
            this.Controls.Add(this.label_Menu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_MenuPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu principal";
            this.Load += new System.EventHandler(this.Form_MenuPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_Menu;
        private System.Windows.Forms.Label label_HeadLine;
        private System.Windows.Forms.Button button_Salir;
        private System.Windows.Forms.Button btn_AdminStock;
        private System.Windows.Forms.Button btn_TomarPedido;
    }
}

