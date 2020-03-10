namespace Semana2
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
            this.cboAnios = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DgPedidos = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DgDetalles = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblNumero = new System.Windows.Forms.TextBox();
            this.LblMonto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DgPedidos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgDetalles)).BeginInit();
            this.SuspendLayout();
            // 
            // cboAnios
            // 
            this.cboAnios.FormattingEnabled = true;
            this.cboAnios.Location = new System.Drawing.Point(519, 15);
            this.cboAnios.Name = "cboAnios";
            this.cboAnios.Size = new System.Drawing.Size(269, 21);
            this.cboAnios.TabIndex = 0;
            this.cboAnios.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Selecciona el año del pedido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // DgPedidos
            // 
            this.DgPedidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgPedidos.Location = new System.Drawing.Point(12, 115);
            this.DgPedidos.Name = "DgPedidos";
            this.DgPedidos.Size = new System.Drawing.Size(776, 181);
            this.DgPedidos.TabIndex = 2;
            this.DgPedidos.DoubleClick += new System.EventHandler(this.DgPedidos_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lista de pedidos";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lista de detalles";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DgDetalles
            // 
            this.DgDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgDetalles.Location = new System.Drawing.Point(12, 369);
            this.DgDetalles.Name = "DgDetalles";
            this.DgDetalles.Size = new System.Drawing.Size(776, 190);
            this.DgDetalles.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(519, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Nro de Pedido";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(519, 581);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Monto del pedido";
            // 
            // LblNumero
            // 
            this.LblNumero.Location = new System.Drawing.Point(644, 316);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(100, 20);
            this.LblNumero.TabIndex = 8;
            // 
            // LblMonto
            // 
            this.LblMonto.Location = new System.Drawing.Point(644, 573);
            this.LblMonto.Name = "LblMonto";
            this.LblMonto.Size = new System.Drawing.Size(100, 20);
            this.LblMonto.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 616);
            this.Controls.Add(this.LblMonto);
            this.Controls.Add(this.LblNumero);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.DgDetalles);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DgPedidos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboAnios);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgPedidos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgDetalles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAnios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgPedidos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView DgDetalles;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox LblNumero;
        private System.Windows.Forms.TextBox LblMonto;
    }
}

