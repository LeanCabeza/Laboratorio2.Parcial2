namespace CasaDeComida_v2
{
    partial class FormAgregarPedido
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
            this.btn_AgregarPedido = new System.Windows.Forms.Button();
            this.tb_precio = new System.Windows.Forms.TextBox();
            this.lbl_Precio = new System.Windows.Forms.Label();
            this.lbl_Pedido = new System.Windows.Forms.Label();
            this.tb_pedido = new System.Windows.Forms.TextBox();
            this.lbl_Cliente = new System.Windows.Forms.Label();
            this.lbl_Clase = new System.Windows.Forms.Label();
            this.cb_Tipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_AgregarPedido
            // 
            this.btn_AgregarPedido.Location = new System.Drawing.Point(325, 281);
            this.btn_AgregarPedido.Name = "btn_AgregarPedido";
            this.btn_AgregarPedido.Size = new System.Drawing.Size(109, 36);
            this.btn_AgregarPedido.TabIndex = 37;
            this.btn_AgregarPedido.Text = "Agregar Pedido";
            this.btn_AgregarPedido.UseVisualStyleBackColor = true;
            this.btn_AgregarPedido.Click += new System.EventHandler(this.btn_AgregarPedido_Click);
            // 
            // tb_precio
            // 
            this.tb_precio.Location = new System.Drawing.Point(302, 244);
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.Size = new System.Drawing.Size(145, 20);
            this.tb_precio.TabIndex = 36;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Location = new System.Drawing.Point(299, 228);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(37, 13);
            this.lbl_Precio.TabIndex = 35;
            this.lbl_Precio.Text = "Precio";
            // 
            // lbl_Pedido
            // 
            this.lbl_Pedido.AutoSize = true;
            this.lbl_Pedido.Location = new System.Drawing.Point(322, 90);
            this.lbl_Pedido.Name = "lbl_Pedido";
            this.lbl_Pedido.Size = new System.Drawing.Size(80, 13);
            this.lbl_Pedido.TabIndex = 34;
            this.lbl_Pedido.Text = "Agregar Pedido";
            // 
            // tb_pedido
            // 
            this.tb_pedido.Location = new System.Drawing.Point(302, 142);
            this.tb_pedido.Name = "tb_pedido";
            this.tb_pedido.Size = new System.Drawing.Size(145, 20);
            this.tb_pedido.TabIndex = 33;
            // 
            // lbl_Cliente
            // 
            this.lbl_Cliente.AutoSize = true;
            this.lbl_Cliente.Location = new System.Drawing.Point(299, 123);
            this.lbl_Cliente.Name = "lbl_Cliente";
            this.lbl_Cliente.Size = new System.Drawing.Size(145, 13);
            this.lbl_Cliente.TabIndex = 32;
            this.lbl_Cliente.Text = "Que quiere comer el cliente ?";
            // 
            // lbl_Clase
            // 
            this.lbl_Clase.AutoSize = true;
            this.lbl_Clase.Location = new System.Drawing.Point(299, 180);
            this.lbl_Clase.Name = "lbl_Clase";
            this.lbl_Clase.Size = new System.Drawing.Size(180, 13);
            this.lbl_Clase.TabIndex = 31;
            this.lbl_Clase.Text = "Clase a la que pertenece el pedido ?";
            // 
            // cb_Tipo
            // 
            this.cb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Tipo.FormattingEnabled = true;
            this.cb_Tipo.Items.AddRange(new object[] {
            "Comida Rapida",
            "Comida Gurmet",
            "Postre",
            "Indefinido"});
            this.cb_Tipo.Location = new System.Drawing.Point(299, 204);
            this.cb_Tipo.Name = "cb_Tipo";
            this.cb_Tipo.Size = new System.Drawing.Size(145, 21);
            this.cb_Tipo.TabIndex = 38;
            // 
            // FormAgregarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cb_Tipo);
            this.Controls.Add(this.btn_AgregarPedido);
            this.Controls.Add(this.tb_precio);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.lbl_Pedido);
            this.Controls.Add(this.tb_pedido);
            this.Controls.Add(this.lbl_Cliente);
            this.Controls.Add(this.lbl_Clase);
            this.Name = "FormAgregarPedido";
            this.Text = "AgregarPedido";
            this.Load += new System.EventHandler(this.AgregarPedido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_AgregarPedido;
        private System.Windows.Forms.TextBox tb_precio;
        private System.Windows.Forms.Label lbl_Precio;
        private System.Windows.Forms.Label lbl_Pedido;
        private System.Windows.Forms.TextBox tb_pedido;
        private System.Windows.Forms.Label lbl_Cliente;
        private System.Windows.Forms.Label lbl_Clase;
        private System.Windows.Forms.ComboBox cb_Tipo;
    }
}