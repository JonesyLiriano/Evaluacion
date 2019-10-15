namespace Evaluacion
{
    partial class Menu
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.Ejercicio1 = new System.Windows.Forms.ToolStripLabel();
            this.Ejercicio2 = new System.Windows.Forms.ToolStripLabel();
            this.Ejercicio3 = new System.Windows.Forms.ToolStripLabel();
            this.Ejercicio4 = new System.Windows.Forms.ToolStripLabel();
            this.Salir = new System.Windows.Forms.ToolStripLabel();
            this.GeneradorEjercicios = new System.Windows.Forms.ToolStripLabel();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Ejercicio1,
            this.Ejercicio2,
            this.Ejercicio3,
            this.Ejercicio4,
            this.GeneradorEjercicios,
            this.Salir});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(745, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // Ejercicio1
            // 
            this.Ejercicio1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Ejercicio1.Name = "Ejercicio1";
            this.Ejercicio1.Size = new System.Drawing.Size(97, 22);
            this.Ejercicio1.Text = "Ejercicio #1";
            this.Ejercicio1.Click += new System.EventHandler(this.Ejercicio1_Click);
            // 
            // Ejercicio2
            // 
            this.Ejercicio2.Name = "Ejercicio2";
            this.Ejercicio2.Size = new System.Drawing.Size(97, 22);
            this.Ejercicio2.Text = "Ejercicio #2";
            this.Ejercicio2.Click += new System.EventHandler(this.Ejercicio2_Click);
            // 
            // Ejercicio3
            // 
            this.Ejercicio3.Name = "Ejercicio3";
            this.Ejercicio3.Size = new System.Drawing.Size(97, 22);
            this.Ejercicio3.Text = "Ejercicio #3";
            this.Ejercicio3.Click += new System.EventHandler(this.Ejercicio3_Click);
            // 
            // Ejercicio4
            // 
            this.Ejercicio4.Name = "Ejercicio4";
            this.Ejercicio4.Size = new System.Drawing.Size(97, 22);
            this.Ejercicio4.Text = "Ejercicio #4";
            this.Ejercicio4.Click += new System.EventHandler(this.Ejercicio4_Click_1);
            // 
            // Salir
            // 
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(44, 22);
            this.Salir.Text = "Salir";
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // GeneradorEjercicios
            // 
            this.GeneradorEjercicios.Name = "GeneradorEjercicios";
            this.GeneradorEjercicios.Size = new System.Drawing.Size(166, 22);
            this.GeneradorEjercicios.Text = "Generador Ejercicios";
            this.GeneradorEjercicios.Click += new System.EventHandler(this.GeneradorEjercicios_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Evaluacion.Properties.Resources.sea_edge_79ab30e2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(745, 369);
            this.Controls.Add(this.toolStrip1);
            this.DoubleBuffered = true;
            this.IsMdiContainer = true;
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel Ejercicio1;
        private System.Windows.Forms.ToolStripLabel Ejercicio2;
        private System.Windows.Forms.ToolStripLabel Ejercicio3;
        private System.Windows.Forms.ToolStripLabel Salir;
        private System.Windows.Forms.ToolStripLabel Ejercicio4;
        private System.Windows.Forms.ToolStripLabel GeneradorEjercicios;
        }
}

