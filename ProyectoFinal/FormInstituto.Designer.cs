﻿namespace ProyectoFinal
{
    partial class FormInstituto
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_CargarAlumno = new System.Windows.Forms.Button();
            this.chbx_analitico = new System.Windows.Forms.CheckBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.FechaNacAlumno = new System.Windows.Forms.DateTimePicker();
            this.txb_dni = new System.Windows.Forms.TextBox();
            this.txb_NomApAlumno = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre Apellido";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(197, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Nacimiento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(587, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Email";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(21, 26);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1038, 253);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_CargarAlumno);
            this.tabPage1.Controls.Add(this.chbx_analitico);
            this.tabPage1.Controls.Add(this.txb_email);
            this.tabPage1.Controls.Add(this.FechaNacAlumno);
            this.tabPage1.Controls.Add(this.txb_dni);
            this.tabPage1.Controls.Add(this.txb_NomApAlumno);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1030, 227);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Alumno";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_CargarAlumno
            // 
            this.btn_CargarAlumno.Location = new System.Drawing.Point(353, 121);
            this.btn_CargarAlumno.Name = "btn_CargarAlumno";
            this.btn_CargarAlumno.Size = new System.Drawing.Size(75, 23);
            this.btn_CargarAlumno.TabIndex = 10;
            this.btn_CargarAlumno.Text = "Cargar";
            this.btn_CargarAlumno.UseVisualStyleBackColor = true;
            this.btn_CargarAlumno.Click += new System.EventHandler(this.btn_CargarAlumno_Click);
            // 
            // chbx_analitico
            // 
            this.chbx_analitico.AutoSize = true;
            this.chbx_analitico.Location = new System.Drawing.Point(777, 41);
            this.chbx_analitico.Name = "chbx_analitico";
            this.chbx_analitico.Size = new System.Drawing.Size(66, 17);
            this.chbx_analitico.TabIndex = 9;
            this.chbx_analitico.Text = "Analitico";
            this.chbx_analitico.UseVisualStyleBackColor = true;
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(590, 41);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(118, 20);
            this.txb_email.TabIndex = 8;
            // 
            // FechaNacAlumno
            // 
            this.FechaNacAlumno.Location = new System.Drawing.Point(353, 41);
            this.FechaNacAlumno.Name = "FechaNacAlumno";
            this.FechaNacAlumno.Size = new System.Drawing.Size(200, 20);
            this.FechaNacAlumno.TabIndex = 7;
            // 
            // txb_dni
            // 
            this.txb_dni.Location = new System.Drawing.Point(200, 42);
            this.txb_dni.Name = "txb_dni";
            this.txb_dni.Size = new System.Drawing.Size(118, 20);
            this.txb_dni.TabIndex = 6;
            // 
            // txb_NomApAlumno
            // 
            this.txb_NomApAlumno.Location = new System.Drawing.Point(11, 42);
            this.txb_NomApAlumno.Name = "txb_NomApAlumno";
            this.txb_NomApAlumno.Size = new System.Drawing.Size(147, 20);
            this.txb_NomApAlumno.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.numericUpDown1);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1030, 227);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Materias";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(693, 57);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(90, 20);
            this.textBox7.TabIndex = 11;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(354, 56);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            2024,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2015,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            2023,
            0,
            0,
            0});
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(518, 57);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(90, 20);
            this.textBox6.TabIndex = 9;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(207, 57);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(90, 20);
            this.textBox5.TabIndex = 8;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(51, 57);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 7;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(690, 23);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "Nombre de Carrera";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(515, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Dia de cursado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(351, 23);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Año";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(204, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Nombre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Código";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox11);
            this.tabPage3.Controls.Add(this.textBox10);
            this.tabPage3.Controls.Add(this.textBox9);
            this.tabPage3.Controls.Add(this.textBox8);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label12);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1030, 227);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Cursado";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(346, 64);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(90, 20);
            this.textBox11.TabIndex = 15;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(471, 64);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(90, 20);
            this.textBox10.TabIndex = 14;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(208, 64);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(90, 20);
            this.textBox9.TabIndex = 13;
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(60, 64);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(90, 20);
            this.textBox8.TabIndex = 12;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(468, 28);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 4;
            this.label14.Text = "Condicion";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(343, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(30, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Nota";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(205, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Id_Materia";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(57, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(64, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "DNI Alumno";
            // 
            // FormInstituto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1353, 667);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormInstituto";
            this.Text = "FormInstituto";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txb_NomApAlumno;
        private System.Windows.Forms.CheckBox chbx_analitico;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.DateTimePicker FechaNacAlumno;
        private System.Windows.Forms.TextBox txb_dni;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button btn_CargarAlumno;
    }
}