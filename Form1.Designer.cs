namespace Pasteleria
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
            this.listBoxRecetas = new System.Windows.Forms.ListBox();
            this.txtRecetaDB = new System.Windows.Forms.TextBox();
            this.buttonLeerDB = new System.Windows.Forms.Button();
            this.txtBoxReceta = new System.Windows.Forms.TextBox();
            this.buttonAgregar = new System.Windows.Forms.Button();
            this.txtIngRcp = new System.Windows.Forms.TextBox();
            this.txtDescRcp = new System.Windows.Forms.TextBox();
            this.txtCantRcp = new System.Windows.Forms.TextBox();
            this.txtTempRcp = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtTiempoRcp = new System.Windows.Forms.TextBox();
            this.buttonBorrarDB = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ingredientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listBoxRecetas
            // 
            this.listBoxRecetas.FormattingEnabled = true;
            this.listBoxRecetas.Location = new System.Drawing.Point(70, 22);
            this.listBoxRecetas.Name = "listBoxRecetas";
            this.listBoxRecetas.Size = new System.Drawing.Size(198, 121);
            this.listBoxRecetas.TabIndex = 0;
            // 
            // txtRecetaDB
            // 
            this.txtRecetaDB.Location = new System.Drawing.Point(527, 22);
            this.txtRecetaDB.Multiline = true;
            this.txtRecetaDB.Name = "txtRecetaDB";
            this.txtRecetaDB.Size = new System.Drawing.Size(340, 370);
            this.txtRecetaDB.TabIndex = 1;
            // 
            // buttonLeerDB
            // 
            this.buttonLeerDB.Location = new System.Drawing.Point(297, 22);
            this.buttonLeerDB.Name = "buttonLeerDB";
            this.buttonLeerDB.Size = new System.Drawing.Size(74, 37);
            this.buttonLeerDB.TabIndex = 2;
            this.buttonLeerDB.Text = "Leer de DB";
            this.buttonLeerDB.UseVisualStyleBackColor = true;
            this.buttonLeerDB.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtBoxReceta
            // 
            this.txtBoxReceta.Location = new System.Drawing.Point(70, 198);
            this.txtBoxReceta.Name = "txtBoxReceta";
            this.txtBoxReceta.Size = new System.Drawing.Size(198, 20);
            this.txtBoxReceta.TabIndex = 3;
            // 
            // buttonAgregar
            // 
            this.buttonAgregar.Location = new System.Drawing.Point(297, 189);
            this.buttonAgregar.Name = "buttonAgregar";
            this.buttonAgregar.Size = new System.Drawing.Size(74, 29);
            this.buttonAgregar.TabIndex = 4;
            this.buttonAgregar.Text = "Agregar";
            this.buttonAgregar.UseVisualStyleBackColor = true;
            this.buttonAgregar.Click += new System.EventHandler(this.buttonAgregar_Click);
            // 
            // txtIngRcp
            // 
            this.txtIngRcp.Location = new System.Drawing.Point(70, 238);
            this.txtIngRcp.Name = "txtIngRcp";
            this.txtIngRcp.Size = new System.Drawing.Size(134, 20);
            this.txtIngRcp.TabIndex = 6;
            // 
            // txtDescRcp
            // 
            this.txtDescRcp.Location = new System.Drawing.Point(70, 282);
            this.txtDescRcp.Name = "txtDescRcp";
            this.txtDescRcp.Size = new System.Drawing.Size(198, 20);
            this.txtDescRcp.TabIndex = 7;
            // 
            // txtCantRcp
            // 
            this.txtCantRcp.Location = new System.Drawing.Point(229, 238);
            this.txtCantRcp.Name = "txtCantRcp";
            this.txtCantRcp.Size = new System.Drawing.Size(39, 20);
            this.txtCantRcp.TabIndex = 8;
            // 
            // txtTempRcp
            // 
            this.txtTempRcp.Location = new System.Drawing.Point(70, 325);
            this.txtTempRcp.Name = "txtTempRcp";
            this.txtTempRcp.Size = new System.Drawing.Size(63, 20);
            this.txtTempRcp.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(297, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(74, 45);
            this.button1.TabIndex = 10;
            this.button1.Text = "Carga Ing";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(140, 373);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 19);
            this.button2.TabIndex = 11;
            this.button2.Text = "CARGAR A DB";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtTiempoRcp
            // 
            this.txtTiempoRcp.Location = new System.Drawing.Point(205, 325);
            this.txtTiempoRcp.Name = "txtTiempoRcp";
            this.txtTiempoRcp.Size = new System.Drawing.Size(63, 20);
            this.txtTiempoRcp.TabIndex = 12;
            // 
            // buttonBorrarDB
            // 
            this.buttonBorrarDB.Location = new System.Drawing.Point(300, 86);
            this.buttonBorrarDB.Name = "buttonBorrarDB";
            this.buttonBorrarDB.Size = new System.Drawing.Size(81, 31);
            this.buttonBorrarDB.TabIndex = 13;
            this.buttonBorrarDB.Text = "Borrar de DB";
            this.buttonBorrarDB.UseVisualStyleBackColor = true;
            this.buttonBorrarDB.Click += new System.EventHandler(this.buttonBorrarDB_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ingredientesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(888, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ingredientesToolStripMenuItem
            // 
            this.ingredientesToolStripMenuItem.Name = "ingredientesToolStripMenuItem";
            this.ingredientesToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.ingredientesToolStripMenuItem.Text = "Ingredientes";
            this.ingredientesToolStripMenuItem.Click += new System.EventHandler(this.ingredientesToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(888, 652);
            this.Controls.Add(this.buttonBorrarDB);
            this.Controls.Add(this.txtTiempoRcp);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTempRcp);
            this.Controls.Add(this.txtCantRcp);
            this.Controls.Add(this.txtDescRcp);
            this.Controls.Add(this.txtIngRcp);
            this.Controls.Add(this.buttonAgregar);
            this.Controls.Add(this.txtBoxReceta);
            this.Controls.Add(this.buttonLeerDB);
            this.Controls.Add(this.txtRecetaDB);
            this.Controls.Add(this.listBoxRecetas);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "ABM DE RECETAS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBoxRecetas;
        private System.Windows.Forms.TextBox txtRecetaDB;
        private System.Windows.Forms.Button buttonLeerDB;
        private System.Windows.Forms.TextBox txtBoxReceta;
        private System.Windows.Forms.Button buttonAgregar;
        private System.Windows.Forms.TextBox txtIngRcp;
        private System.Windows.Forms.TextBox txtDescRcp;
        private System.Windows.Forms.TextBox txtCantRcp;
        private System.Windows.Forms.TextBox txtTempRcp;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txtTiempoRcp;
        private System.Windows.Forms.Button buttonBorrarDB;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ingredientesToolStripMenuItem;
    }
}

