
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.productNameLabel = new System.Windows.Forms.Label();
            this.frmNombre = new System.Windows.Forms.TextBox();
            this.priceLabel = new System.Windows.Forms.Label();
            this.frmCosto = new System.Windows.Forms.TextBox();
            this.idOculto = new System.Windows.Forms.TextBox();
            this.frmStock = new System.Windows.Forms.TextBox();
            this.stockLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.frmEstado = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.bntModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.frmBuscar = new System.Windows.Forms.TextBox();
            this.btnExportar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.totalRegistros = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // productNameLabel
            // 
            this.productNameLabel.AutoSize = true;
            this.productNameLabel.Location = new System.Drawing.Point(6, 65);
            this.productNameLabel.Name = "productNameLabel";
            this.productNameLabel.Size = new System.Drawing.Size(142, 17);
            this.productNameLabel.TabIndex = 1;
            this.productNameLabel.Text = "Nombre del Producto";
            this.productNameLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // frmNombre
            // 
            this.frmNombre.Location = new System.Drawing.Point(154, 62);
            this.frmNombre.Name = "frmNombre";
            this.frmNombre.Size = new System.Drawing.Size(616, 22);
            this.frmNombre.TabIndex = 2;
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(6, 114);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(44, 17);
            this.priceLabel.TabIndex = 3;
            this.priceLabel.Text = "Costo";
            this.priceLabel.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // frmCosto
            // 
            this.frmCosto.Location = new System.Drawing.Point(56, 111);
            this.frmCosto.Name = "frmCosto";
            this.frmCosto.Size = new System.Drawing.Size(92, 22);
            this.frmCosto.TabIndex = 4;
            // 
            // idOculto
            // 
            this.idOculto.Location = new System.Drawing.Point(735, 21);
            this.idOculto.Name = "idOculto";
            this.idOculto.Size = new System.Drawing.Size(35, 22);
            this.idOculto.TabIndex = 5;
            // 
            // frmStock
            // 
            this.frmStock.Location = new System.Drawing.Point(344, 111);
            this.frmStock.Name = "frmStock";
            this.frmStock.Size = new System.Drawing.Size(105, 22);
            this.frmStock.TabIndex = 7;
            // 
            // stockLabel
            // 
            this.stockLabel.AutoSize = true;
            this.stockLabel.Location = new System.Drawing.Point(294, 114);
            this.stockLabel.Name = "stockLabel";
            this.stockLabel.Size = new System.Drawing.Size(43, 17);
            this.stockLabel.TabIndex = 6;
            this.stockLabel.Text = "Stock";
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Location = new System.Drawing.Point(583, 114);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(52, 17);
            this.stateLabel.TabIndex = 8;
            this.stateLabel.Text = "Estado";
            // 
            // frmEstado
            // 
            this.frmEstado.FormattingEnabled = true;
            this.frmEstado.Location = new System.Drawing.Point(641, 111);
            this.frmEstado.Name = "frmEstado";
            this.frmEstado.Size = new System.Drawing.Size(129, 24);
            this.frmEstado.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.frmNombre);
            this.groupBox1.Controls.Add(this.frmEstado);
            this.groupBox1.Controls.Add(this.productNameLabel);
            this.groupBox1.Controls.Add(this.stateLabel);
            this.groupBox1.Controls.Add(this.priceLabel);
            this.groupBox1.Controls.Add(this.frmStock);
            this.groupBox1.Controls.Add(this.frmCosto);
            this.groupBox1.Controls.Add(this.stockLabel);
            this.groupBox1.Controls.Add(this.idOculto);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 148);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Antecedentes de Productos";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnLimpiar);
            this.groupBox2.Controls.Add(this.btnEliminar);
            this.groupBox2.Controls.Add(this.bntModificar);
            this.groupBox2.Controls.Add(this.btnIngresar);
            this.groupBox2.Location = new System.Drawing.Point(12, 186);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 124);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(9, 52);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // bntModificar
            // 
            this.bntModificar.Location = new System.Drawing.Point(217, 52);
            this.bntModificar.Name = "bntModificar";
            this.bntModificar.Size = new System.Drawing.Size(75, 23);
            this.bntModificar.TabIndex = 1;
            this.bntModificar.Text = "Modificar";
            this.bntModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(460, 52);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(677, 52);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 3;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.totalRegistros);
            this.groupBox3.Controls.Add(this.panel1);
            this.groupBox3.Controls.Add(this.btnExportar);
            this.groupBox3.Controls.Add(this.frmBuscar);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 345);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(776, 296);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Listado de Productos";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Buscar";
            this.label1.Click += new System.EventHandler(this.label1_Click_3);
            // 
            // frmBuscar
            // 
            this.frmBuscar.Location = new System.Drawing.Point(73, 44);
            this.frmBuscar.Name = "frmBuscar";
            this.frmBuscar.Size = new System.Drawing.Size(219, 22);
            this.frmBuscar.TabIndex = 10;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(677, 44);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 4;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(9, 73);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(761, 178);
            this.panel1.TabIndex = 11;
            // 
            // totalRegistros
            // 
            this.totalRegistros.AutoSize = true;
            this.totalRegistros.Location = new System.Drawing.Point(6, 267);
            this.totalRegistros.Name = "totalRegistros";
            this.totalRegistros.Size = new System.Drawing.Size(68, 17);
            this.totalRegistros.TabIndex = 12;
            this.totalRegistros.Text = "Registros";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 653);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label productNameLabel;
        private System.Windows.Forms.TextBox frmNombre;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox frmCosto;
        private System.Windows.Forms.TextBox idOculto;
        private System.Windows.Forms.TextBox frmStock;
        private System.Windows.Forms.Label stockLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.ComboBox frmEstado;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button bntModificar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label totalRegistros;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.TextBox frmBuscar;
    }
}

