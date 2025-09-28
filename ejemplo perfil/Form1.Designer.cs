namespace ejemplo_perfil
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
            this.txtelemento = new System.Windows.Forms.TextBox();
            this.btnagregar = new System.Windows.Forms.Button();
            this.lwelementos = new System.Windows.Forms.ListView();
            this.lblnombre = new System.Windows.Forms.Label();
            this.lblnacimiento = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.chocolate1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.rbtwizard = new System.Windows.Forms.RadioButton();
            this.rbtmuggle = new System.Windows.Forms.RadioButton();
            this.rbtsquibs = new System.Windows.Forms.RadioButton();
            this.lblcolor = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.numerofavorito = new System.Windows.Forms.NumericUpDown();
            this.btnperfil = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numerofavorito)).BeginInit();
            this.SuspendLayout();
            // 
            // txtelemento
            // 
            this.txtelemento.Location = new System.Drawing.Point(204, 96);
            this.txtelemento.Name = "txtelemento";
            this.txtelemento.Size = new System.Drawing.Size(100, 20);
            this.txtelemento.TabIndex = 0;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(436, 574);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(75, 23);
            this.btnagregar.TabIndex = 1;
            this.btnagregar.Text = "agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // lwelementos
            // 
            this.lwelementos.HideSelection = false;
            this.lwelementos.Location = new System.Drawing.Point(133, 430);
            this.lwelementos.Name = "lwelementos";
            this.lwelementos.Size = new System.Drawing.Size(287, 167);
            this.lwelementos.TabIndex = 2;
            this.lwelementos.UseCompatibleStateImageBehavior = false;
            this.lwelementos.View = System.Windows.Forms.View.List;
            // 
            // lblnombre
            // 
            this.lblnombre.AutoSize = true;
            this.lblnombre.Location = new System.Drawing.Point(121, 96);
            this.lblnombre.Name = "lblnombre";
            this.lblnombre.Size = new System.Drawing.Size(53, 13);
            this.lblnombre.TabIndex = 3;
            this.lblnombre.Text = "Nombre : ";
            // 
            // lblnacimiento
            // 
            this.lblnacimiento.AutoSize = true;
            this.lblnacimiento.Location = new System.Drawing.Point(60, 132);
            this.lblnacimiento.Name = "lblnacimiento";
            this.lblnacimiento.Size = new System.Drawing.Size(114, 13);
            this.lblnacimiento.TabIndex = 4;
            this.lblnacimiento.Text = "Fecha de Nacimiento :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(204, 132);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // chocolate1
            // 
            this.chocolate1.AutoSize = true;
            this.chocolate1.Location = new System.Drawing.Point(204, 174);
            this.chocolate1.Name = "chocolate1";
            this.chocolate1.Size = new System.Drawing.Size(138, 17);
            this.chocolate1.TabIndex = 6;
            this.chocolate1.Text = "Te gusta el chocolate ?";
            this.chocolate1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 31);
            this.label1.TabIndex = 7;
            this.label1.Text = "Perfil Persona";
            // 
            // rbtwizard
            // 
            this.rbtwizard.AutoSize = true;
            this.rbtwizard.Checked = true;
            this.rbtwizard.Location = new System.Drawing.Point(24, 36);
            this.rbtwizard.Name = "rbtwizard";
            this.rbtwizard.Size = new System.Drawing.Size(58, 17);
            this.rbtwizard.TabIndex = 8;
            this.rbtwizard.TabStop = true;
            this.rbtwizard.Text = "Wizard";
            this.rbtwizard.UseVisualStyleBackColor = true;
            // 
            // rbtmuggle
            // 
            this.rbtmuggle.AutoSize = true;
            this.rbtmuggle.Location = new System.Drawing.Point(124, 36);
            this.rbtmuggle.Name = "rbtmuggle";
            this.rbtmuggle.Size = new System.Drawing.Size(60, 17);
            this.rbtmuggle.TabIndex = 9;
            this.rbtmuggle.Text = "Muggle";
            this.rbtmuggle.UseVisualStyleBackColor = true;
            // 
            // rbtsquibs
            // 
            this.rbtsquibs.AutoSize = true;
            this.rbtsquibs.Location = new System.Drawing.Point(242, 36);
            this.rbtsquibs.Name = "rbtsquibs";
            this.rbtsquibs.Size = new System.Drawing.Size(57, 17);
            this.rbtsquibs.TabIndex = 10;
            this.rbtsquibs.Text = "Squibs";
            this.rbtsquibs.UseVisualStyleBackColor = true;
            // 
            // lblcolor
            // 
            this.lblcolor.AutoSize = true;
            this.lblcolor.Location = new System.Drawing.Point(155, 308);
            this.lblcolor.Name = "lblcolor";
            this.lblcolor.Size = new System.Drawing.Size(37, 13);
            this.lblcolor.TabIndex = 11;
            this.lblcolor.Text = "Color :";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(204, 308);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 12;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtsquibs);
            this.groupBox1.Controls.Add(this.rbtmuggle);
            this.groupBox1.Controls.Add(this.rbtwizard);
            this.groupBox1.Location = new System.Drawing.Point(124, 208);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(331, 79);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(106, 349);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "numero favorito :";
            // 
            // numerofavorito
            // 
            this.numerofavorito.Location = new System.Drawing.Point(204, 349);
            this.numerofavorito.Name = "numerofavorito";
            this.numerofavorito.Size = new System.Drawing.Size(120, 20);
            this.numerofavorito.TabIndex = 15;
            // 
            // btnperfil
            // 
            this.btnperfil.Location = new System.Drawing.Point(133, 384);
            this.btnperfil.Name = "btnperfil";
            this.btnperfil.Size = new System.Drawing.Size(75, 23);
            this.btnperfil.TabIndex = 16;
            this.btnperfil.Text = "ver perfil";
            this.btnperfil.UseVisualStyleBackColor = true;
            this.btnperfil.Click += new System.EventHandler(this.btnperfil_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(599, 628);
            this.Controls.Add(this.btnperfil);
            this.Controls.Add(this.numerofavorito);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblcolor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chocolate1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblnacimiento);
            this.Controls.Add(this.lblnombre);
            this.Controls.Add(this.lwelementos);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.txtelemento);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numerofavorito)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtelemento;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.ListView lwelementos;
        private System.Windows.Forms.Label lblnombre;
        private System.Windows.Forms.Label lblnacimiento;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox chocolate1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbtwizard;
        private System.Windows.Forms.RadioButton rbtmuggle;
        private System.Windows.Forms.RadioButton rbtsquibs;
        private System.Windows.Forms.Label lblcolor;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numerofavorito;
        private System.Windows.Forms.Button btnperfil;
    }
}

