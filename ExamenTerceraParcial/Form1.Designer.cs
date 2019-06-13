namespace ExamenTerceraParcial
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
            this.components = new System.ComponentModel.Container();
            this.listajugadores = new System.Windows.Forms.ListBox();
            this.listaequipos = new System.Windows.Forms.ListBox();
            this.btnaequipo = new System.Windows.Forms.Button();
            this.comboequipo1 = new System.Windows.Forms.ComboBox();
            this.comboequipo2 = new System.Windows.Forms.ComboBox();
            this.btnguardar = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.jornadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.jornadaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lble = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtnequipo = new System.Windows.Forms.TextBox();
            this.btnjuegen = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.contextMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // listajugadores
            // 
            this.listajugadores.FormattingEnabled = true;
            this.listajugadores.Location = new System.Drawing.Point(506, 19);
            this.listajugadores.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listajugadores.Name = "listajugadores";
            this.listajugadores.Size = new System.Drawing.Size(134, 134);
            this.listajugadores.TabIndex = 0;
            // 
            // listaequipos
            // 
            this.listaequipos.FormattingEnabled = true;
            this.listaequipos.Location = new System.Drawing.Point(506, 169);
            this.listaequipos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listaequipos.Name = "listaequipos";
            this.listaequipos.Size = new System.Drawing.Size(134, 147);
            this.listaequipos.TabIndex = 1;
            // 
            // btnaequipo
            // 
            this.btnaequipo.Location = new System.Drawing.Point(70, 154);
            this.btnaequipo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnaequipo.Name = "btnaequipo";
            this.btnaequipo.Size = new System.Drawing.Size(76, 50);
            this.btnaequipo.TabIndex = 2;
            this.btnaequipo.Text = "agregar equipo";
            this.btnaequipo.UseVisualStyleBackColor = true;
            this.btnaequipo.Click += new System.EventHandler(this.btnaequipo_Click);
            // 
            // comboequipo1
            // 
            this.comboequipo1.FormattingEnabled = true;
            this.comboequipo1.Location = new System.Drawing.Point(240, 63);
            this.comboequipo1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboequipo1.Name = "comboequipo1";
            this.comboequipo1.Size = new System.Drawing.Size(92, 21);
            this.comboequipo1.TabIndex = 3;
            // 
            // comboequipo2
            // 
            this.comboequipo2.FormattingEnabled = true;
            this.comboequipo2.Location = new System.Drawing.Point(369, 63);
            this.comboequipo2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboequipo2.Name = "comboequipo2";
            this.comboequipo2.Size = new System.Drawing.Size(92, 21);
            this.comboequipo2.TabIndex = 4;
            // 
            // btnguardar
            // 
            this.btnguardar.Location = new System.Drawing.Point(49, 267);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(117, 70);
            this.btnguardar.TabIndex = 5;
            this.btnguardar.Text = "guardar";
            this.btnguardar.UseVisualStyleBackColor = true;
            this.btnguardar.Click += new System.EventHandler(this.btnguardar_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jornadaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(116, 26);
            // 
            // jornadaToolStripMenuItem
            // 
            this.jornadaToolStripMenuItem.Name = "jornadaToolStripMenuItem";
            this.jornadaToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.jornadaToolStripMenuItem.Text = "Jornada";
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.jornadaToolStripMenuItem1});
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(116, 26);
            // 
            // jornadaToolStripMenuItem1
            // 
            this.jornadaToolStripMenuItem1.Name = "jornadaToolStripMenuItem1";
            this.jornadaToolStripMenuItem1.Size = new System.Drawing.Size(115, 22);
            this.jornadaToolStripMenuItem1.Text = "Jornada";
            // 
            // lble
            // 
            this.lble.AutoSize = true;
            this.lble.Location = new System.Drawing.Point(262, 33);
            this.lble.Name = "lble";
            this.lble.Size = new System.Drawing.Size(49, 13);
            this.lble.TabIndex = 8;
            this.lble.Text = "Equipo 1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(394, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Equipo 2";
            // 
            // txtnequipo
            // 
            this.txtnequipo.Location = new System.Drawing.Point(49, 125);
            this.txtnequipo.Name = "txtnequipo";
            this.txtnequipo.Size = new System.Drawing.Size(127, 20);
            this.txtnequipo.TabIndex = 10;
            // 
            // btnjuegen
            // 
            this.btnjuegen.Location = new System.Drawing.Point(322, 103);
            this.btnjuegen.Name = "btnjuegen";
            this.btnjuegen.Size = new System.Drawing.Size(64, 42);
            this.btnjuegen.TabIndex = 11;
            this.btnjuegen.Text = "Juegan";
            this.btnjuegen.UseVisualStyleBackColor = true;
            this.btnjuegen.Click += new System.EventHandler(this.btnjuegen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 433);
            this.Controls.Add(this.btnjuegen);
            this.Controls.Add(this.txtnequipo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lble);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.comboequipo2);
            this.Controls.Add(this.comboequipo1);
            this.Controls.Add(this.btnaequipo);
            this.Controls.Add(this.listaequipos);
            this.Controls.Add(this.listajugadores);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.contextMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listajugadores;
        private System.Windows.Forms.ListBox listaequipos;
        private System.Windows.Forms.Button btnaequipo;
        private System.Windows.Forms.ComboBox comboequipo1;
        private System.Windows.Forms.ComboBox comboequipo2;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem jornadaToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        private System.Windows.Forms.ToolStripMenuItem jornadaToolStripMenuItem1;
        private System.Windows.Forms.Label lble;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtnequipo;
        private System.Windows.Forms.Button btnjuegen;
    }
}

