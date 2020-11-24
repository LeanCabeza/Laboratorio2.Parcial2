namespace CasaDeComida_v2
{
    partial class Main
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbl_PedidosPorEntregar = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.lbl_PedidosEntregados = new System.Windows.Forms.Label();
            this.dgv_Cocinandose = new System.Windows.Forms.DataGridView();
            this.dgv_Entregados = new System.Windows.Forms.DataGridView();
            this.btn_ActualizarPedidos = new System.Windows.Forms.Button();
            this.btn_ActualizarEntregados = new System.Windows.Forms.Button();
            this.lbl_RecaudacionTotal = new System.Windows.Forms.Label();
            this.btn_AgregarPedido = new System.Windows.Forms.Button();
            this.lbl_NroCocinandose = new System.Windows.Forms.Label();
            this.lbl_NroEntregados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cocinandose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entregados)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_PedidosPorEntregar
            // 
            this.lbl_PedidosPorEntregar.AutoSize = true;
            this.lbl_PedidosPorEntregar.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PedidosPorEntregar.Location = new System.Drawing.Point(12, 21);
            this.lbl_PedidosPorEntregar.Name = "lbl_PedidosPorEntregar";
            this.lbl_PedidosPorEntregar.Size = new System.Drawing.Size(193, 19);
            this.lbl_PedidosPorEntregar.TabIndex = 18;
            this.lbl_PedidosPorEntregar.Text = "Pedidos cocinandose : ";
            // 
            // lbl_PedidosEntregados
            // 
            this.lbl_PedidosEntregados.AutoSize = true;
            this.lbl_PedidosEntregados.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.lbl_PedidosEntregados.Location = new System.Drawing.Point(499, 21);
            this.lbl_PedidosEntregados.Name = "lbl_PedidosEntregados";
            this.lbl_PedidosEntregados.Size = new System.Drawing.Size(186, 19);
            this.lbl_PedidosEntregados.TabIndex = 20;
            this.lbl_PedidosEntregados.Text = "Pedidos Entregados : ";
            // 
            // dgv_Cocinandose
            // 
            this.dgv_Cocinandose.BackgroundColor = System.Drawing.SystemColors.GrayText;
            this.dgv_Cocinandose.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_Cocinandose.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Cocinandose.Location = new System.Drawing.Point(12, 51);
            this.dgv_Cocinandose.Name = "dgv_Cocinandose";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Cocinandose.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Cocinandose.Size = new System.Drawing.Size(460, 200);
            this.dgv_Cocinandose.TabIndex = 27;
            // 
            // dgv_Entregados
            // 
            this.dgv_Entregados.BackgroundColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dgv_Entregados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Entregados.Location = new System.Drawing.Point(500, 51);
            this.dgv_Entregados.Name = "dgv_Entregados";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Entregados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgv_Entregados.Size = new System.Drawing.Size(460, 200);
            this.dgv_Entregados.TabIndex = 28;
            // 
            // btn_ActualizarPedidos
            // 
            this.btn_ActualizarPedidos.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActualizarPedidos.Location = new System.Drawing.Point(152, 257);
            this.btn_ActualizarPedidos.Name = "btn_ActualizarPedidos";
            this.btn_ActualizarPedidos.Size = new System.Drawing.Size(145, 35);
            this.btn_ActualizarPedidos.TabIndex = 29;
            this.btn_ActualizarPedidos.Text = "Recargar";
            this.btn_ActualizarPedidos.UseVisualStyleBackColor = true;
            this.btn_ActualizarPedidos.Click += new System.EventHandler(this.btn_ActualizarPedidos_Click);
            // 
            // btn_ActualizarEntregados
            // 
            this.btn_ActualizarEntregados.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ActualizarEntregados.Location = new System.Drawing.Point(650, 257);
            this.btn_ActualizarEntregados.Name = "btn_ActualizarEntregados";
            this.btn_ActualizarEntregados.Size = new System.Drawing.Size(145, 35);
            this.btn_ActualizarEntregados.TabIndex = 30;
            this.btn_ActualizarEntregados.Text = "Recargar";
            this.btn_ActualizarEntregados.UseVisualStyleBackColor = true;
            this.btn_ActualizarEntregados.Click += new System.EventHandler(this.btn_ActualizarEntregados_Click);
            // 
            // lbl_RecaudacionTotal
            // 
            this.lbl_RecaudacionTotal.AutoSize = true;
            this.lbl_RecaudacionTotal.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RecaudacionTotal.Location = new System.Drawing.Point(495, 346);
            this.lbl_RecaudacionTotal.Name = "lbl_RecaudacionTotal";
            this.lbl_RecaudacionTotal.Size = new System.Drawing.Size(233, 29);
            this.lbl_RecaudacionTotal.TabIndex = 31;
            this.lbl_RecaudacionTotal.Text = "Recaudacion Total";
            // 
            // btn_AgregarPedido
            // 
            this.btn_AgregarPedido.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarPedido.Location = new System.Drawing.Point(12, 346);
            this.btn_AgregarPedido.Name = "btn_AgregarPedido";
            this.btn_AgregarPedido.Size = new System.Drawing.Size(145, 35);
            this.btn_AgregarPedido.TabIndex = 32;
            this.btn_AgregarPedido.Text = "Agregar Pedido";
            this.btn_AgregarPedido.UseVisualStyleBackColor = true;
            this.btn_AgregarPedido.Click += new System.EventHandler(this.btn_AgregarPedido_Click);
            // 
            // lbl_NroCocinandose
            // 
            this.lbl_NroCocinandose.AutoSize = true;
            this.lbl_NroCocinandose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NroCocinandose.Location = new System.Drawing.Point(211, 21);
            this.lbl_NroCocinandose.Name = "lbl_NroCocinandose";
            this.lbl_NroCocinandose.Size = new System.Drawing.Size(0, 19);
            this.lbl_NroCocinandose.TabIndex = 33;
            // 
            // lbl_NroEntregados
            // 
            this.lbl_NroEntregados.AutoSize = true;
            this.lbl_NroEntregados.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NroEntregados.Location = new System.Drawing.Point(691, 21);
            this.lbl_NroEntregados.Name = "lbl_NroEntregados";
            this.lbl_NroEntregados.Size = new System.Drawing.Size(0, 19);
            this.lbl_NroEntregados.TabIndex = 34;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(978, 384);
            this.Controls.Add(this.lbl_NroEntregados);
            this.Controls.Add(this.lbl_NroCocinandose);
            this.Controls.Add(this.btn_AgregarPedido);
            this.Controls.Add(this.lbl_RecaudacionTotal);
            this.Controls.Add(this.btn_ActualizarEntregados);
            this.Controls.Add(this.btn_ActualizarPedidos);
            this.Controls.Add(this.dgv_Entregados);
            this.Controls.Add(this.dgv_Cocinandose);
            this.Controls.Add(this.lbl_PedidosEntregados);
            this.Controls.Add(this.lbl_PedidosPorEntregar);
            this.Name = "Main";
            this.Text = "Casa de Comida de Leandro Cabeza 2ºD";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Cocinandose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Entregados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_PedidosPorEntregar;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbl_PedidosEntregados;
        private System.Windows.Forms.DataGridView dgv_Cocinandose;
        private System.Windows.Forms.DataGridView dgv_Entregados;
        private System.Windows.Forms.Button btn_ActualizarPedidos;
        private System.Windows.Forms.Button btn_ActualizarEntregados;
        private System.Windows.Forms.Label lbl_RecaudacionTotal;
        private System.Windows.Forms.Button btn_AgregarPedido;
        private System.Windows.Forms.Label lbl_NroCocinandose;
        private System.Windows.Forms.Label lbl_NroEntregados;
    }
}

