namespace LibreriaUI
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
            this.dgvLibrosAutor = new System.Windows.Forms.DataGridView();
            this.txtBuscarAutor = new System.Windows.Forms.TextBox();
            this.lblBuscaAutor = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnNuevoLibro = new System.Windows.Forms.Button();
            this.gbxLibros = new System.Windows.Forms.GroupBox();
            this.txtBuscaLibro = new System.Windows.Forms.TextBox();
            this.lblBuscarTituloLibro = new System.Windows.Forms.Label();
            this.gbxInfoLibro = new System.Windows.Forms.GroupBox();
            this.dgvlibros = new System.Windows.Forms.DataGridView();
            this.btnBuscarLibro = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrosAutor)).BeginInit();
            this.gbxLibros.SuspendLayout();
            this.gbxInfoLibro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvlibros)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvLibrosAutor
            // 
            this.dgvLibrosAutor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLibrosAutor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLibrosAutor.Location = new System.Drawing.Point(6, 19);
            this.dgvLibrosAutor.Name = "dgvLibrosAutor";
            this.dgvLibrosAutor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLibrosAutor.Size = new System.Drawing.Size(377, 357);
            this.dgvLibrosAutor.TabIndex = 0;
            this.dgvLibrosAutor.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLibrosAutor_CellClick);
            // 
            // txtBuscarAutor
            // 
            this.txtBuscarAutor.Location = new System.Drawing.Point(163, 24);
            this.txtBuscarAutor.Name = "txtBuscarAutor";
            this.txtBuscarAutor.Size = new System.Drawing.Size(111, 20);
            this.txtBuscarAutor.TabIndex = 1;
            // 
            // lblBuscaAutor
            // 
            this.lblBuscaAutor.AutoSize = true;
            this.lblBuscaAutor.Location = new System.Drawing.Point(71, 26);
            this.lblBuscaAutor.Name = "lblBuscaAutor";
            this.lblBuscaAutor.Size = new System.Drawing.Size(68, 13);
            this.lblBuscaAutor.TabIndex = 2;
            this.lblBuscaAutor.Text = "Buscar Autor";
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(280, 23);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnNuevoLibro
            // 
            this.btnNuevoLibro.Location = new System.Drawing.Point(713, 20);
            this.btnNuevoLibro.Name = "btnNuevoLibro";
            this.btnNuevoLibro.Size = new System.Drawing.Size(75, 23);
            this.btnNuevoLibro.TabIndex = 4;
            this.btnNuevoLibro.Text = "Nuevo Libro";
            this.btnNuevoLibro.UseVisualStyleBackColor = true;
            this.btnNuevoLibro.Click += new System.EventHandler(this.btnNuevoLibro_Click);
            // 
            // gbxLibros
            // 
            this.gbxLibros.Controls.Add(this.dgvLibrosAutor);
            this.gbxLibros.Location = new System.Drawing.Point(12, 50);
            this.gbxLibros.Name = "gbxLibros";
            this.gbxLibros.Size = new System.Drawing.Size(389, 382);
            this.gbxLibros.TabIndex = 5;
            this.gbxLibros.TabStop = false;
            this.gbxLibros.Text = "Libros";
            // 
            // txtBuscaLibro
            // 
            this.txtBuscaLibro.Location = new System.Drawing.Point(515, 23);
            this.txtBuscaLibro.Name = "txtBuscaLibro";
            this.txtBuscaLibro.Size = new System.Drawing.Size(111, 20);
            this.txtBuscaLibro.TabIndex = 6;
            // 
            // lblBuscarTituloLibro
            // 
            this.lblBuscarTituloLibro.AutoSize = true;
            this.lblBuscarTituloLibro.Location = new System.Drawing.Point(411, 27);
            this.lblBuscarTituloLibro.Name = "lblBuscarTituloLibro";
            this.lblBuscarTituloLibro.Size = new System.Drawing.Size(92, 13);
            this.lblBuscarTituloLibro.TabIndex = 7;
            this.lblBuscarTituloLibro.Text = "Buscar TituloLibro";
            // 
            // gbxInfoLibro
            // 
            this.gbxInfoLibro.Controls.Add(this.dgvlibros);
            this.gbxInfoLibro.Location = new System.Drawing.Point(407, 52);
            this.gbxInfoLibro.Name = "gbxInfoLibro";
            this.gbxInfoLibro.Size = new System.Drawing.Size(381, 380);
            this.gbxInfoLibro.TabIndex = 6;
            this.gbxInfoLibro.TabStop = false;
            this.gbxInfoLibro.Text = "Información Libro";
            // 
            // dgvlibros
            // 
            this.dgvlibros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvlibros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvlibros.Location = new System.Drawing.Point(6, 19);
            this.dgvlibros.Name = "dgvlibros";
            this.dgvlibros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvlibros.Size = new System.Drawing.Size(364, 351);
            this.dgvlibros.TabIndex = 0;
            // 
            // btnBuscarLibro
            // 
            this.btnBuscarLibro.Location = new System.Drawing.Point(632, 20);
            this.btnBuscarLibro.Name = "btnBuscarLibro";
            this.btnBuscarLibro.Size = new System.Drawing.Size(75, 23);
            this.btnBuscarLibro.TabIndex = 8;
            this.btnBuscarLibro.Text = "Buscar";
            this.btnBuscarLibro.UseVisualStyleBackColor = true;
            this.btnBuscarLibro.Click += new System.EventHandler(this.btnBuscarLibro_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBuscarLibro);
            this.Controls.Add(this.gbxInfoLibro);
            this.Controls.Add(this.txtBuscaLibro);
            this.Controls.Add(this.lblBuscarTituloLibro);
            this.Controls.Add(this.gbxLibros);
            this.Controls.Add(this.btnNuevoLibro);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblBuscaAutor);
            this.Controls.Add(this.txtBuscarAutor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLibrosAutor)).EndInit();
            this.gbxLibros.ResumeLayout(false);
            this.gbxInfoLibro.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvlibros)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvLibrosAutor;
        private System.Windows.Forms.TextBox txtBuscarAutor;
        private System.Windows.Forms.Label lblBuscaAutor;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnNuevoLibro;
        private System.Windows.Forms.GroupBox gbxLibros;
        private System.Windows.Forms.TextBox txtBuscaLibro;
        private System.Windows.Forms.Label lblBuscarTituloLibro;
        private System.Windows.Forms.GroupBox gbxInfoLibro;
        private System.Windows.Forms.DataGridView dgvlibros;
        private System.Windows.Forms.Button btnBuscarLibro;
    }
}

