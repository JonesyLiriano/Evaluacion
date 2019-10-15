namespace Evaluacion
    {
    partial class GeneradorEjercicio
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEjercicio4 = new System.Windows.Forms.RadioButton();
            this.rbEjercicio3 = new System.Windows.Forms.RadioButton();
            this.rbEjercicio2 = new System.Windows.Forms.RadioButton();
            this.problem = new System.Windows.Forms.Label();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtIntruction = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtProblem1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbOpcion6 = new System.Windows.Forms.Label();
            this.lbOpcion5 = new System.Windows.Forms.Label();
            this.txtOption1 = new System.Windows.Forms.TextBox();
            this.txtOption2 = new System.Windows.Forms.TextBox();
            this.txtOption3 = new System.Windows.Forms.TextBox();
            this.txtOption4 = new System.Windows.Forms.TextBox();
            this.txtOption5 = new System.Windows.Forms.TextBox();
            this.txtOption6 = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtProblem2 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEjercicio4);
            this.groupBox1.Controls.Add(this.rbEjercicio3);
            this.groupBox1.Controls.Add(this.rbEjercicio2);
            this.groupBox1.Location = new System.Drawing.Point(45, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 56);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            // 
            // rbEjercicio4
            // 
            this.rbEjercicio4.AutoSize = true;
            this.rbEjercicio4.Location = new System.Drawing.Point(244, 20);
            this.rbEjercicio4.Name = "rbEjercicio4";
            this.rbEjercicio4.Size = new System.Drawing.Size(71, 17);
            this.rbEjercicio4.TabIndex = 2;
            this.rbEjercicio4.Text = "Ejercicio4";
            this.rbEjercicio4.UseVisualStyleBackColor = true;
            this.rbEjercicio4.CheckedChanged += new System.EventHandler(this.rbEjercicio4_CheckedChanged);
            // 
            // rbEjercicio3
            // 
            this.rbEjercicio3.AutoSize = true;
            this.rbEjercicio3.Location = new System.Drawing.Point(139, 20);
            this.rbEjercicio3.Name = "rbEjercicio3";
            this.rbEjercicio3.Size = new System.Drawing.Size(71, 17);
            this.rbEjercicio3.TabIndex = 1;
            this.rbEjercicio3.Text = "Ejercicio3";
            this.rbEjercicio3.UseVisualStyleBackColor = true;
            this.rbEjercicio3.CheckedChanged += new System.EventHandler(this.rbEjercicio3_CheckedChanged);
            // 
            // rbEjercicio2
            // 
            this.rbEjercicio2.AutoSize = true;
            this.rbEjercicio2.Checked = true;
            this.rbEjercicio2.Location = new System.Drawing.Point(33, 20);
            this.rbEjercicio2.Name = "rbEjercicio2";
            this.rbEjercicio2.Size = new System.Drawing.Size(71, 17);
            this.rbEjercicio2.TabIndex = 0;
            this.rbEjercicio2.TabStop = true;
            this.rbEjercicio2.Text = "Ejercicio2";
            this.rbEjercicio2.UseVisualStyleBackColor = true;
            this.rbEjercicio2.CheckedChanged += new System.EventHandler(this.rbEjercicio2_CheckedChanged);
            // 
            // problem
            // 
            this.problem.AutoSize = true;
            this.problem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problem.Location = new System.Drawing.Point(23, 28);
            this.problem.Name = "problem";
            this.problem.Size = new System.Drawing.Size(415, 20);
            this.problem.TabIndex = 7;
            this.problem.Text = "Por favor elija que tipo de ejercicos desea generar:";
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(159, 538);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(125, 63);
            this.btnGenerar.TabIndex = 16;
            this.btnGenerar.Text = "GENERAR";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtProblem2);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtResult);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtProblem1);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtIntruction);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(45, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(363, 408);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos del ejercicio";
            // 
            // txtIntruction
            // 
            this.txtIntruction.Location = new System.Drawing.Point(90, 43);
            this.txtIntruction.Multiline = true;
            this.txtIntruction.Name = "txtIntruction";
            this.txtIntruction.Size = new System.Drawing.Size(267, 58);
            this.txtIntruction.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Intruccion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Problema:";
            // 
            // txtProblem1
            // 
            this.txtProblem1.Location = new System.Drawing.Point(91, 107);
            this.txtProblem1.Multiline = true;
            this.txtProblem1.Name = "txtProblem1";
            this.txtProblem1.Size = new System.Drawing.Size(265, 32);
            this.txtProblem1.TabIndex = 20;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtOption6);
            this.groupBox3.Controls.Add(this.txtOption5);
            this.groupBox3.Controls.Add(this.txtOption4);
            this.groupBox3.Controls.Add(this.txtOption3);
            this.groupBox3.Controls.Add(this.txtOption2);
            this.groupBox3.Controls.Add(this.txtOption1);
            this.groupBox3.Controls.Add(this.lbOpcion5);
            this.groupBox3.Controls.Add(this.lbOpcion6);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(9, 177);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(347, 168);
            this.groupBox3.TabIndex = 21;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Opciones";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 16);
            this.label3.TabIndex = 22;
            this.label3.Text = "#1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(17, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 23;
            this.label4.Text = "#2";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(17, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "#3";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(17, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 25;
            this.label6.Text = "#4";
            // 
            // lbOpcion6
            // 
            this.lbOpcion6.AutoSize = true;
            this.lbOpcion6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOpcion6.Location = new System.Drawing.Point(206, 110);
            this.lbOpcion6.Name = "lbOpcion6";
            this.lbOpcion6.Size = new System.Drawing.Size(24, 16);
            this.lbOpcion6.TabIndex = 26;
            this.lbOpcion6.Text = "#6";
            // 
            // lbOpcion5
            // 
            this.lbOpcion5.AutoSize = true;
            this.lbOpcion5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbOpcion5.Location = new System.Drawing.Point(206, 45);
            this.lbOpcion5.Name = "lbOpcion5";
            this.lbOpcion5.Size = new System.Drawing.Size(24, 16);
            this.lbOpcion5.TabIndex = 27;
            this.lbOpcion5.Text = "#5";
            // 
            // txtOption1
            // 
            this.txtOption1.Location = new System.Drawing.Point(47, 27);
            this.txtOption1.Name = "txtOption1";
            this.txtOption1.Size = new System.Drawing.Size(100, 22);
            this.txtOption1.TabIndex = 28;
            // 
            // txtOption2
            // 
            this.txtOption2.Location = new System.Drawing.Point(47, 60);
            this.txtOption2.Name = "txtOption2";
            this.txtOption2.Size = new System.Drawing.Size(100, 22);
            this.txtOption2.TabIndex = 29;
            // 
            // txtOption3
            // 
            this.txtOption3.Location = new System.Drawing.Point(47, 94);
            this.txtOption3.Name = "txtOption3";
            this.txtOption3.Size = new System.Drawing.Size(100, 22);
            this.txtOption3.TabIndex = 30;
            // 
            // txtOption4
            // 
            this.txtOption4.Location = new System.Drawing.Point(47, 130);
            this.txtOption4.Name = "txtOption4";
            this.txtOption4.Size = new System.Drawing.Size(100, 22);
            this.txtOption4.TabIndex = 31;
            // 
            // txtOption5
            // 
            this.txtOption5.Location = new System.Drawing.Point(236, 42);
            this.txtOption5.Name = "txtOption5";
            this.txtOption5.Size = new System.Drawing.Size(100, 22);
            this.txtOption5.TabIndex = 32;
            // 
            // txtOption6
            // 
            this.txtOption6.Location = new System.Drawing.Point(236, 107);
            this.txtOption6.Name = "txtOption6";
            this.txtOption6.Size = new System.Drawing.Size(100, 22);
            this.txtOption6.TabIndex = 33;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(90, 351);
            this.txtResult.Multiline = true;
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(266, 51);
            this.txtResult.TabIndex = 34;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(6, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 16);
            this.label7.TabIndex = 35;
            this.label7.Text = "Resultado:";
            // 
            // txtProblem2
            // 
            this.txtProblem2.Location = new System.Drawing.Point(92, 145);
            this.txtProblem2.Multiline = true;
            this.txtProblem2.Name = "txtProblem2";
            this.txtProblem2.Size = new System.Drawing.Size(265, 32);
            this.txtProblem2.TabIndex = 36;
            // 
            // GeneradorEjercicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 613);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnGenerar);
            this.Controls.Add(this.problem);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.Name = "GeneradorEjercicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generador de Ejercicios";
            this.Load += new System.EventHandler(this.GeneradorEjercicio_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

            }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEjercicio4;
        private System.Windows.Forms.RadioButton rbEjercicio3;
        private System.Windows.Forms.RadioButton rbEjercicio2;
        private System.Windows.Forms.Label problem;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIntruction;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtOption6;
        private System.Windows.Forms.TextBox txtOption5;
        private System.Windows.Forms.TextBox txtOption4;
        private System.Windows.Forms.TextBox txtOption3;
        private System.Windows.Forms.TextBox txtOption2;
        private System.Windows.Forms.TextBox txtOption1;
        private System.Windows.Forms.Label lbOpcion5;
        private System.Windows.Forms.Label lbOpcion6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtProblem1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.TextBox txtProblem2;
        }
    }