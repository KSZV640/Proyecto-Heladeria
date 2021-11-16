namespace heladeria
{
    partial class FormFactura
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label activoLabel;
            System.Windows.Forms.Label clienteIdLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label idLabel;
            System.Windows.Forms.Label impuestoLabel;
            System.Windows.Forms.Label subtotalLabel;
            System.Windows.Forms.Label totalLabel;
            this.facturaBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.listaFacturasBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.activoCheckBox = new System.Windows.Forms.CheckBox();
            this.clienteIdTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.impuestoTextBox = new System.Windows.Forms.TextBox();
            this.subtotalTextBox = new System.Windows.Forms.TextBox();
            this.totalTextBox = new System.Windows.Forms.TextBox();
            this.clienteBLBindingSource = new System.Windows.Forms.BindingSource(this.components);
            activoLabel = new System.Windows.Forms.Label();
            clienteIdLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            idLabel = new System.Windows.Forms.Label();
            impuestoLabel = new System.Windows.Forms.Label();
            subtotalLabel = new System.Windows.Forms.Label();
            totalLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBLBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFacturasBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBLBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // facturaBLBindingSource
            // 
            this.facturaBLBindingSource.DataSource = typeof(BL.Heladeria.FacturaBL);
            // 
            // listaFacturasBindingSource
            // 
            this.listaFacturasBindingSource.DataMember = "ListaFacturas";
            this.listaFacturasBindingSource.DataSource = this.facturaBLBindingSource;
            // 
            // activoLabel
            // 
            activoLabel.AutoSize = true;
            activoLabel.Location = new System.Drawing.Point(36, 147);
            activoLabel.Name = "activoLabel";
            activoLabel.Size = new System.Drawing.Size(40, 13);
            activoLabel.TabIndex = 0;
            activoLabel.Text = "Activo:";
            activoLabel.Click += new System.EventHandler(this.activoLabel_Click);
            // 
            // activoCheckBox
            // 
            this.activoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.listaFacturasBindingSource, "Activo", true));
            this.activoCheckBox.Location = new System.Drawing.Point(96, 142);
            this.activoCheckBox.Name = "activoCheckBox";
            this.activoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.activoCheckBox.TabIndex = 1;
            this.activoCheckBox.UseVisualStyleBackColor = true;
            this.activoCheckBox.CheckedChanged += new System.EventHandler(this.activoCheckBox_CheckedChanged);
            // 
            // clienteIdLabel
            // 
            clienteIdLabel.AutoSize = true;
            clienteIdLabel.Location = new System.Drawing.Point(36, 123);
            clienteIdLabel.Name = "clienteIdLabel";
            clienteIdLabel.Size = new System.Drawing.Size(54, 13);
            clienteIdLabel.TabIndex = 2;
            clienteIdLabel.Text = "Cliente Id:";
            // 
            // clienteIdTextBox
            // 
            this.clienteIdTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFacturasBindingSource, "ClienteId", true));
            this.clienteIdTextBox.Location = new System.Drawing.Point(96, 116);
            this.clienteIdTextBox.Name = "clienteIdTextBox";
            this.clienteIdTextBox.Size = new System.Drawing.Size(200, 20);
            this.clienteIdTextBox.TabIndex = 3;
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Location = new System.Drawing.Point(36, 94);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(40, 13);
            fechaLabel.TabIndex = 4;
            fechaLabel.Text = "Fecha:";
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.listaFacturasBindingSource, "Fecha", true));
            this.fechaDateTimePicker.Location = new System.Drawing.Point(96, 90);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.fechaDateTimePicker.TabIndex = 5;
            // 
            // idLabel
            // 
            idLabel.AutoSize = true;
            idLabel.Location = new System.Drawing.Point(36, 67);
            idLabel.Name = "idLabel";
            idLabel.Size = new System.Drawing.Size(18, 13);
            idLabel.TabIndex = 6;
            idLabel.Text = "id:";
            idLabel.Click += new System.EventHandler(this.idLabel_Click);
            // 
            // idTextBox
            // 
            this.idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFacturasBindingSource, "id", true));
            this.idTextBox.Location = new System.Drawing.Point(96, 64);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(200, 20);
            this.idTextBox.TabIndex = 7;
            this.idTextBox.TextChanged += new System.EventHandler(this.idTextBox_TextChanged);
            // 
            // impuestoLabel
            // 
            impuestoLabel.AutoSize = true;
            impuestoLabel.Location = new System.Drawing.Point(243, 374);
            impuestoLabel.Name = "impuestoLabel";
            impuestoLabel.Size = new System.Drawing.Size(53, 13);
            impuestoLabel.TabIndex = 8;
            impuestoLabel.Text = "Impuesto:";
            // 
            // impuestoTextBox
            // 
            this.impuestoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFacturasBindingSource, "Impuesto", true));
            this.impuestoTextBox.Location = new System.Drawing.Point(303, 371);
            this.impuestoTextBox.Name = "impuestoTextBox";
            this.impuestoTextBox.Size = new System.Drawing.Size(200, 20);
            this.impuestoTextBox.TabIndex = 9;
            // 
            // subtotalLabel
            // 
            subtotalLabel.AutoSize = true;
            subtotalLabel.Location = new System.Drawing.Point(243, 345);
            subtotalLabel.Name = "subtotalLabel";
            subtotalLabel.Size = new System.Drawing.Size(49, 13);
            subtotalLabel.TabIndex = 10;
            subtotalLabel.Text = "Subtotal:";
            // 
            // subtotalTextBox
            // 
            this.subtotalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFacturasBindingSource, "Subtotal", true));
            this.subtotalTextBox.Location = new System.Drawing.Point(303, 338);
            this.subtotalTextBox.Name = "subtotalTextBox";
            this.subtotalTextBox.Size = new System.Drawing.Size(200, 20);
            this.subtotalTextBox.TabIndex = 11;
            // 
            // totalLabel
            // 
            totalLabel.AutoSize = true;
            totalLabel.Location = new System.Drawing.Point(243, 409);
            totalLabel.Name = "totalLabel";
            totalLabel.Size = new System.Drawing.Size(34, 13);
            totalLabel.TabIndex = 12;
            totalLabel.Text = "Total:";
            // 
            // totalTextBox
            // 
            this.totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.listaFacturasBindingSource, "Total", true));
            this.totalTextBox.Location = new System.Drawing.Point(303, 406);
            this.totalTextBox.Name = "totalTextBox";
            this.totalTextBox.Size = new System.Drawing.Size(200, 20);
            this.totalTextBox.TabIndex = 13;
            // 
            // clienteBLBindingSource
            // 
            this.clienteBLBindingSource.DataSource = typeof(BL.Heladeria.ClienteBL);
            // 
            // FormFactura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 473);
            this.Controls.Add(activoLabel);
            this.Controls.Add(this.activoCheckBox);
            this.Controls.Add(clienteIdLabel);
            this.Controls.Add(this.clienteIdTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(idLabel);
            this.Controls.Add(this.idTextBox);
            this.Controls.Add(impuestoLabel);
            this.Controls.Add(this.impuestoTextBox);
            this.Controls.Add(subtotalLabel);
            this.Controls.Add(this.subtotalTextBox);
            this.Controls.Add(totalLabel);
            this.Controls.Add(this.totalTextBox);
            this.Name = "FormFactura";
            this.Text = "Factura";
            this.Load += new System.EventHandler(this.FormFactura_Load);
            ((System.ComponentModel.ISupportInitialize)(this.facturaBLBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.listaFacturasBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBLBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource facturaBLBindingSource;
        private System.Windows.Forms.BindingSource listaFacturasBindingSource;
        private System.Windows.Forms.CheckBox activoCheckBox;
        private System.Windows.Forms.TextBox clienteIdTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.TextBox impuestoTextBox;
        private System.Windows.Forms.TextBox subtotalTextBox;
        private System.Windows.Forms.TextBox totalTextBox;
        private System.Windows.Forms.BindingSource clienteBLBindingSource;
    }
}