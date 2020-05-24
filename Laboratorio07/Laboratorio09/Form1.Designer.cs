namespace Laboratorio09
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.buttonInscripcion = new System.Windows.Forms.Button();
            this.buttonEstudiante = new System.Windows.Forms.Button();
            this.buttonMateria = new System.Windows.Forms.Button();
            this.registerStudent1 = new Laboratorio09.registerStudent();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.buttonConsultar, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonInscripcion, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonEstudiante, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonMateria, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.registerStudent1, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1062, 657);
            this.tableLayoutPanel1.TabIndex = 0;
            
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonConsultar.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonConsultar.Location = new System.Drawing.Point(798, 3);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(261, 59);
            this.buttonConsultar.TabIndex = 3;
            this.buttonConsultar.Text = "CONSULTAR";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // buttonInscripcion
            // 
            this.buttonInscripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonInscripcion.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonInscripcion.Location = new System.Drawing.Point(533, 3);
            this.buttonInscripcion.Name = "buttonInscripcion";
            this.buttonInscripcion.Size = new System.Drawing.Size(259, 59);
            this.buttonInscripcion.TabIndex = 2;
            this.buttonInscripcion.Text = "INSCRIBIR";
            this.buttonInscripcion.UseVisualStyleBackColor = true;
            this.buttonInscripcion.Click += new System.EventHandler(this.buttonInscripcion_Click);
            // 
            // buttonEstudiante
            // 
            this.buttonEstudiante.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonEstudiante.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonEstudiante.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonEstudiante.Location = new System.Drawing.Point(3, 3);
            this.buttonEstudiante.Name = "buttonEstudiante";
            this.buttonEstudiante.Size = new System.Drawing.Size(259, 59);
            this.buttonEstudiante.TabIndex = 0;
            this.buttonEstudiante.Text = "ESTUDIANTE";
            this.buttonEstudiante.UseVisualStyleBackColor = true;
            this.buttonEstudiante.Click += new System.EventHandler(this.buttonEstudiante_Click);
            // 
            // buttonMateria
            // 
            this.buttonMateria.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonMateria.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonMateria.Location = new System.Drawing.Point(268, 3);
            this.buttonMateria.Name = "buttonMateria";
            this.buttonMateria.Size = new System.Drawing.Size(259, 59);
            this.buttonMateria.TabIndex = 1;
            this.buttonMateria.Text = "MATERIA";
            this.buttonMateria.UseVisualStyleBackColor = true;
            this.buttonMateria.Click += new System.EventHandler(this.buttonMateria_Click);
            // 
            // registerStudent1
            // 
            this.registerStudent1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.registerStudent1, 4);
            this.registerStudent1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.registerStudent1.Location = new System.Drawing.Point(3, 68);
            this.registerStudent1.Name = "registerStudent1";
            this.registerStudent1.Size = new System.Drawing.Size(1056, 586);
            this.registerStudent1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 657);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button buttonEstudiante;
        private System.Windows.Forms.Button buttonMateria;
        private System.Windows.Forms.Button buttonInscripcion;
        private System.Windows.Forms.Button buttonConsultar;
        private Laboratorio09.registerStudent registerStudent1;
    }
}