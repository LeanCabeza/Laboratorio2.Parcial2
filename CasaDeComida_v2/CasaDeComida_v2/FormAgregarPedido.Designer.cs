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
            this.lbl_PedidoCliente = new System.Windows.Forms.Label();
            this.lbl_Clase = new System.Windows.Forms.Label();
            this.cb_Tipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_AgregarPedido
            // 
            this.btn_AgregarPedido.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarPedido.Location = new System.Drawing.Point(121, 294);
            this.btn_AgregarPedido.Name = "btn_AgregarPedido";
            this.btn_AgregarPedido.Size = new System.Drawing.Size(137, 36);
            this.btn_AgregarPedido.TabIndex = 37;
            this.btn_AgregarPedido.Text = "Agregar Pedido";
            this.btn_AgregarPedido.UseVisualStyleBackColor = true;
            this.btn_AgregarPedido.Click += new System.EventHandler(this.btn_AgregarPedido_Click);
            // 
            // tb_precio
            // 
            this.tb_precio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_precio.Location = new System.Drawing.Point(83, 246);
            this.tb_precio.Name = "tb_precio";
            this.tb_precio.Size = new System.Drawing.Size(211, 27);
            this.tb_precio.TabIndex = 36;
            // 
            // lbl_Precio
            // 
            this.lbl_Precio.AutoSize = true;
            this.lbl_Precio.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Precio.Location = new System.Drawing.Point(79, 224);
            this.lbl_Precio.Name = "lbl_Precio";
            this.lbl_Precio.Size = new System.Drawing.Size(52, 19);
            this.lbl_Precio.TabIndex = 35;
            this.lbl_Precio.Text = "Precio";
            // 
            // lbl_Pedido
            // 
            this.lbl_Pedido.AutoSize = true;
            this.lbl_Pedido.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Pedido.Location = new System.Drawing.Point(117, 46);
            this.lbl_Pedido.Name = "lbl_Pedido";
            this.lbl_Pedido.Size = new System.Drawing.Size(156, 23);
            this.lbl_Pedido.TabIndex = 34;
            this.lbl_Pedido.Text = "Agregar Pedido";
            // 
            // tb_pedido
            // 
            this.tb_pedido.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_pedido.Location = new System.Drawing.Point(82, 124);
            this.tb_pedido.Name = "tb_pedido";
            this.tb_pedido.Size = new System.Drawing.Size(213, 27);
            this.tb_pedido.TabIndex = 33;
            // 
            // lbl_PedidoCliente
            // 
            this.lbl_PedidoCliente.AutoSize = true;
            this.lbl_PedidoCliente.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PedidoCliente.Location = new System.Drawing.Point(79, 102);
            this.lbl_PedidoCliente.Name = "lbl_PedidoCliente";
            this.lbl_PedidoCliente.Size = new System.Drawing.Size(216, 19);
            this.lbl_PedidoCliente.TabIndex = 32;
            this.lbl_PedidoCliente.Text = "Que quiere comer el cliente ?";
            this.lbl_PedidoCliente.Click += new System.EventHandler(this.lbl_Cliente_Click);
            // 
            // lbl_Clase
            // 
            this.lbl_Clase.AutoSize = true;
            this.lbl_Clase.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Clase.Location = new System.Drawing.Point(78, 166);
            this.lbl_Clase.Name = "lbl_Clase";
            this.lbl_Clase.Size = new System.Drawing.Size(263, 19);
            this.lbl_Clase.TabIndex = 31;
            this.lbl_Clase.Text = "Clase a la que pertenece el pedido ?";
            // 
            // cb_Tipo
            // 
            this.cb_Tipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Tipo.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Tipo.FormattingEnabled = true;
            this.cb_Tipo.Items.AddRange(new object[] {
            "Comida Rapida",
            "Comida Gurmet",
            "Postre",
            "Indefinido"});
            this.cb_Tipo.Location = new System.Drawing.Point(82, 189);
            this.cb_Tipo.Name = "cb_Tipo";
            this.cb_Tipo.Size = new System.Drawing.Size(212, 27);
            this.cb_Tipo.TabIndex = 38;
            // 
            // FormAgregarPedido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(399, 420);
            this.Controls.Add(this.cb_Tipo);
            this.Controls.Add(this.btn_AgregarPedido);
            this.Controls.Add(this.tb_precio);
            this.Controls.Add(this.lbl_Precio);
            this.Controls.Add(this.lbl_Pedido);
            this.Controls.Add(this.tb_pedido);
            this.Controls.Add(this.lbl_PedidoCliente);
            this.Controls.Add(this.lbl_Clase);
            this.Name = "FormAgregarPedido";
            this.Text = "Agregar Pedido";
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
        private System.Windows.Forms.Label lbl_PedidoCliente;
        private System.Windows.Forms.Label lbl_Clase;
        private System.Windows.Forms.ComboBox cb_Tipo;
    }
}