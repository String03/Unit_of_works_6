namespace Unit_of_works_6
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
            this.grillaCompra = new System.Windows.Forms.DataGridView();
            this.btn_agregar_producto = new System.Windows.Forms.Button();
            this.btn_realizar_compra = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_producto_id_compra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.num_cantidad_compra = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.grillaCompra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad_compra)).BeginInit();
            this.SuspendLayout();
            // 
            // grillaCompra
            // 
            this.grillaCompra.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grillaCompra.Location = new System.Drawing.Point(44, 49);
            this.grillaCompra.MultiSelect = false;
            this.grillaCompra.Name = "grillaCompra";
            this.grillaCompra.ReadOnly = true;
            this.grillaCompra.RowTemplate.Height = 24;
            this.grillaCompra.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grillaCompra.Size = new System.Drawing.Size(732, 186);
            this.grillaCompra.TabIndex = 0;
            // 
            // btn_agregar_producto
            // 
            this.btn_agregar_producto.Location = new System.Drawing.Point(53, 272);
            this.btn_agregar_producto.Name = "btn_agregar_producto";
            this.btn_agregar_producto.Size = new System.Drawing.Size(154, 23);
            this.btn_agregar_producto.TabIndex = 1;
            this.btn_agregar_producto.Text = "Agregar Producto";
            this.btn_agregar_producto.UseVisualStyleBackColor = true;
            this.btn_agregar_producto.Click += new System.EventHandler(this.btn_agregar_producto_Click);
            // 
            // btn_realizar_compra
            // 
            this.btn_realizar_compra.Location = new System.Drawing.Point(309, 272);
            this.btn_realizar_compra.Name = "btn_realizar_compra";
            this.btn_realizar_compra.Size = new System.Drawing.Size(145, 23);
            this.btn_realizar_compra.TabIndex = 2;
            this.btn_realizar_compra.Text = "Realizar Compra";
            this.btn_realizar_compra.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 350);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Producto Id";
            // 
            // txt_producto_id_compra
            // 
            this.txt_producto_id_compra.Location = new System.Drawing.Point(142, 350);
            this.txt_producto_id_compra.Name = "txt_producto_id_compra";
            this.txt_producto_id_compra.Size = new System.Drawing.Size(208, 22);
            this.txt_producto_id_compra.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(388, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cantidad";
            // 
            // num_cantidad_compra
            // 
            this.num_cantidad_compra.Location = new System.Drawing.Point(468, 350);
            this.num_cantidad_compra.Name = "num_cantidad_compra";
            this.num_cantidad_compra.Size = new System.Drawing.Size(271, 22);
            this.num_cantidad_compra.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.num_cantidad_compra);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_producto_id_compra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_realizar_compra);
            this.Controls.Add(this.btn_agregar_producto);
            this.Controls.Add(this.grillaCompra);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.grillaCompra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_cantidad_compra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grillaCompra;
        private System.Windows.Forms.Button btn_agregar_producto;
        private System.Windows.Forms.Button btn_realizar_compra;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_producto_id_compra;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown num_cantidad_compra;
    }
}

