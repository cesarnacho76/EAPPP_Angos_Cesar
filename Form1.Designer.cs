namespace cafe
{
    partial class Form1
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
            this.lvCatalogo = new System.Windows.Forms.ListView();
            this.txtCliente = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.rbtnEntrega = new System.Windows.Forms.RadioButton();
            this.rbtnMostrador = new System.Windows.Forms.RadioButton();
            this.chkPostre = new System.Windows.Forms.CheckBox();
            this.chkServilletas = new System.Windows.Forms.CheckBox();
            this.lvPedido = new System.Windows.Forms.ListView();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnQuitar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvCatalogo
            // 
            this.lvCatalogo.FullRowSelect = true;
            this.lvCatalogo.HideSelection = false;
            this.lvCatalogo.Location = new System.Drawing.Point(20, 172);
            this.lvCatalogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvCatalogo.Name = "lvCatalogo";
            this.lvCatalogo.Size = new System.Drawing.Size(253, 233);
            this.lvCatalogo.TabIndex = 0;
            this.lvCatalogo.UseCompatibleStateImageBehavior = false;
            this.lvCatalogo.SelectedIndexChanged += new System.EventHandler(this.lvCatalogo_SelectedIndexChanged);
            // 
            // txtCliente
            // 
            this.txtCliente.Location = new System.Drawing.Point(401, 82);
            this.txtCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCliente.Name = "txtCliente";
            this.txtCliente.Size = new System.Drawing.Size(171, 22);
            this.txtCliente.TabIndex = 1;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(665, 143);
            this.txtCantidad.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(68, 22);
            this.txtCantidad.TabIndex = 2;
            // 
            // txtProducto
            // 
            this.txtProducto.Location = new System.Drawing.Point(401, 143);
            this.txtProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.ReadOnly = true;
            this.txtProducto.Size = new System.Drawing.Size(171, 22);
            this.txtProducto.TabIndex = 3;
            // 
            // rbtnEntrega
            // 
            this.rbtnEntrega.AutoSize = true;
            this.rbtnEntrega.Location = new System.Drawing.Point(191, 23);
            this.rbtnEntrega.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnEntrega.Name = "rbtnEntrega";
            this.rbtnEntrega.Size = new System.Drawing.Size(156, 20);
            this.rbtnEntrega.TabIndex = 4;
            this.rbtnEntrega.Text = "Entrega en aula +0.5$";
            this.rbtnEntrega.UseVisualStyleBackColor = true;
            // 
            // rbtnMostrador
            // 
            this.rbtnMostrador.AutoSize = true;
            this.rbtnMostrador.Checked = true;
            this.rbtnMostrador.Location = new System.Drawing.Point(8, 23);
            this.rbtnMostrador.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbtnMostrador.Name = "rbtnMostrador";
            this.rbtnMostrador.Size = new System.Drawing.Size(146, 20);
            this.rbtnMostrador.TabIndex = 5;
            this.rbtnMostrador.TabStop = true;
            this.rbtnMostrador.Text = "Retiro en mostrador";
            this.rbtnMostrador.UseVisualStyleBackColor = true;
            // 
            // chkPostre
            // 
            this.chkPostre.AutoSize = true;
            this.chkPostre.Location = new System.Drawing.Point(8, 39);
            this.chkPostre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkPostre.Name = "chkPostre";
            this.chkPostre.Size = new System.Drawing.Size(161, 20);
            this.chkPostre.TabIndex = 6;
            this.chkPostre.Text = "Postre del dia (+1.00$)";
            this.chkPostre.UseVisualStyleBackColor = true;
            // 
            // chkServilletas
            // 
            this.chkServilletas.AutoSize = true;
            this.chkServilletas.Location = new System.Drawing.Point(208, 39);
            this.chkServilletas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkServilletas.Name = "chkServilletas";
            this.chkServilletas.Size = new System.Drawing.Size(153, 20);
            this.chkServilletas.TabIndex = 7;
            this.chkServilletas.Text = "Servilletas/Cubiertos";
            this.chkServilletas.UseVisualStyleBackColor = true;
            // 
            // lvPedido
            // 
            this.lvPedido.FullRowSelect = true;
            this.lvPedido.HideSelection = false;
            this.lvPedido.Location = new System.Drawing.Point(791, 172);
            this.lvPedido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lvPedido.Name = "lvPedido";
            this.lvPedido.Size = new System.Drawing.Size(233, 233);
            this.lvPedido.TabIndex = 8;
            this.lvPedido.UseCompatibleStateImageBehavior = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Enabled = false;
            this.btnAgregar.Location = new System.Drawing.Point(329, 426);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 28);
            this.btnAgregar.TabIndex = 9;
            this.btnAgregar.Text = "Agregar item";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnQuitar
            // 
            this.btnQuitar.Enabled = false;
            this.btnQuitar.Location = new System.Drawing.Point(473, 426);
            this.btnQuitar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnQuitar.Name = "btnQuitar";
            this.btnQuitar.Size = new System.Drawing.Size(100, 28);
            this.btnQuitar.TabIndex = 10;
            this.btnQuitar.Text = "Quitar seleccionado";
            this.btnQuitar.UseVisualStyleBackColor = true;
            this.btnQuitar.Click += new System.EventHandler(this.btnQuitar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(627, 426);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 28);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar Pedido";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(16, 495);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(197, 16);
            this.lblEstado.TabIndex = 12;
            this.lblEstado.Text = "Estado: Seleccione un producto";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(905, 452);
            this.lblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(88, 16);
            this.lblTotal.TabIndex = 13;
            this.lblTotal.Text = "Total : \"00.0$\"";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkPostre);
            this.groupBox1.Controls.Add(this.chkServilletas);
            this.groupBox1.Location = new System.Drawing.Point(363, 313);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(389, 81);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Extras";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnMostrador);
            this.groupBox2.Controls.Add(this.rbtnEntrega);
            this.groupBox2.Location = new System.Drawing.Point(363, 204);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(391, 81);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Modalidad de Atencion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 16);
            this.label1.TabIndex = 16;
            this.label1.Text = "CATALOGO DE PRODUCTOS :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(800, 143);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "DETALLE DEL PEDIDO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(325, 86);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 16);
            this.label3.TabIndex = 18;
            this.label3.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 146);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 16);
            this.label4.TabIndex = 19;
            this.label4.Text = "Prodcuto :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(615, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 16);
            this.label5.TabIndex = 20;
            this.label5.Text = "Cant:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnQuitar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lvPedido);
            this.Controls.Add(this.txtProducto);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.txtCliente);
            this.Controls.Add(this.lvCatalogo);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvCatalogo;
        private System.Windows.Forms.TextBox txtCliente;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.RadioButton rbtnEntrega;
        private System.Windows.Forms.RadioButton rbtnMostrador;
        private System.Windows.Forms.CheckBox chkPostre;
        private System.Windows.Forms.CheckBox chkServilletas;
        private System.Windows.Forms.ListView lvPedido;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnQuitar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}

