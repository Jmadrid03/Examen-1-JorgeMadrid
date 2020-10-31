namespace Examen1_EdwinLeonardoMolinaFlores.Formularios
{
    partial class FrmSalarioNeto
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
            this.BtnPagosT = new System.Windows.Forms.Button();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txttotaldeduccion = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtcantidadmensual = new System.Windows.Forms.TextBox();
            this.txtprestamo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtpagototal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtpagoxhorasnm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnguardar = new System.Windows.Forms.Button();
            this.txtpagoporhoraextra = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnsalir = new System.Windows.Forms.Button();
            this.btncalcular = new System.Windows.Forms.Button();
            this.txtcooperativa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtrap = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtsegurosocial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txthorasextras = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtsalariobase = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnPagosT
            // 
            this.BtnPagosT.BackColor = System.Drawing.Color.Silver;
            this.BtnPagosT.Location = new System.Drawing.Point(773, 443);
            this.BtnPagosT.Name = "BtnPagosT";
            this.BtnPagosT.Size = new System.Drawing.Size(139, 55);
            this.BtnPagosT.TabIndex = 75;
            this.BtnPagosT.Text = "Calcular Pagos Totales";
            this.BtnPagosT.UseVisualStyleBackColor = false;
            // 
            // txtbox1
            // 
            this.txtbox1.ForeColor = System.Drawing.Color.Red;
            this.txtbox1.Location = new System.Drawing.Point(708, 504);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.ReadOnly = true;
            this.txtbox1.Size = new System.Drawing.Size(110, 27);
            this.txtbox1.TabIndex = 74;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(510, 190);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(115, 19);
            this.label14.TabIndex = 73;
            this.label14.Text = "Deducciones";
            // 
            // txttotal
            // 
            this.txttotal.Location = new System.Drawing.Point(942, 504);
            this.txttotal.Name = "txttotal";
            this.txttotal.ReadOnly = true;
            this.txttotal.Size = new System.Drawing.Size(110, 27);
            this.txttotal.TabIndex = 72;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(835, 507);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(101, 19);
            this.label13.TabIndex = 71;
            this.label13.Text = "Pago Total";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(532, 507);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 19);
            this.label12.TabIndex = 70;
            this.label12.Text = "Total Deducciones";
            // 
            // txttotaldeduccion
            // 
            this.txttotaldeduccion.ForeColor = System.Drawing.Color.Red;
            this.txttotaldeduccion.Location = new System.Drawing.Point(640, 187);
            this.txttotaldeduccion.Name = "txttotaldeduccion";
            this.txttotaldeduccion.Size = new System.Drawing.Size(110, 27);
            this.txttotaldeduccion.TabIndex = 69;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(702, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(19, 19);
            this.label11.TabIndex = 68;
            this.label11.Text = "=";
            // 
            // txtcantidadmensual
            // 
            this.txtcantidadmensual.Location = new System.Drawing.Point(731, 113);
            this.txtcantidadmensual.Name = "txtcantidadmensual";
            this.txtcantidadmensual.Size = new System.Drawing.Size(87, 27);
            this.txtcantidadmensual.TabIndex = 67;
            // 
            // txtprestamo
            // 
            this.txtprestamo.Location = new System.Drawing.Point(624, 113);
            this.txtprestamo.Name = "txtprestamo";
            this.txtprestamo.Size = new System.Drawing.Size(73, 27);
            this.txtprestamo.TabIndex = 66;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(504, 117);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 19);
            this.label9.TabIndex = 65;
            this.label9.Text = "Prestamos";
            // 
            // txtpagototal
            // 
            this.txtpagototal.Location = new System.Drawing.Point(630, 147);
            this.txtpagototal.Name = "txtpagototal";
            this.txtpagototal.Size = new System.Drawing.Size(140, 27);
            this.txtpagototal.TabIndex = 64;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(500, 150);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 19);
            this.label8.TabIndex = 63;
            this.label8.Text = "Pago Neto:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column7,
            this.Column6});
            this.dataGridView1.Location = new System.Drawing.Point(13, 218);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1039, 219);
            this.dataGridView1.TabIndex = 62;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre";
            this.Column1.Name = "Column1";
            this.Column1.Width = 180;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Pago De Horas Extras";
            this.Column2.Name = "Column2";
            this.Column2.Width = 180;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Cooperativa";
            this.Column3.Name = "Column3";
            this.Column3.Width = 120;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Seguro Social";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "RAP";
            this.Column5.Name = "Column5";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Prestamo";
            this.Column8.Name = "Column8";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Deducciones";
            this.Column7.Name = "Column7";
            this.Column7.Width = 120;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Pago Neto";
            this.Column6.Name = "Column6";
            this.Column6.Width = 95;
            // 
            // txtpagoxhorasnm
            // 
            this.txtpagoxhorasnm.Location = new System.Drawing.Point(704, 46);
            this.txtpagoxhorasnm.Name = "txtpagoxhorasnm";
            this.txtpagoxhorasnm.Size = new System.Drawing.Size(58, 27);
            this.txtpagoxhorasnm.TabIndex = 61;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(769, 49);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(19, 19);
            this.label7.TabIndex = 60;
            this.label7.Text = "=";
            // 
            // btnguardar
            // 
            this.btnguardar.BackColor = System.Drawing.Color.Silver;
            this.btnguardar.Location = new System.Drawing.Point(376, 174);
            this.btnguardar.Name = "btnguardar";
            this.btnguardar.Size = new System.Drawing.Size(107, 40);
            this.btnguardar.TabIndex = 59;
            this.btnguardar.Text = "Guardar";
            this.btnguardar.UseVisualStyleBackColor = false;
            // 
            // txtpagoporhoraextra
            // 
            this.txtpagoporhoraextra.Location = new System.Drawing.Point(794, 45);
            this.txtpagoporhoraextra.Name = "txtpagoporhoraextra";
            this.txtpagoporhoraextra.Size = new System.Drawing.Size(88, 27);
            this.txtpagoporhoraextra.TabIndex = 58;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(501, 48);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(197, 19);
            this.label10.TabIndex = 57;
            this.label10.Text = "Pago De Horas Extras:";
            // 
            // btnsalir
            // 
            this.btnsalir.BackColor = System.Drawing.Color.Silver;
            this.btnsalir.Location = new System.Drawing.Point(908, 18);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(121, 49);
            this.btnsalir.TabIndex = 56;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = false;
            // 
            // btncalcular
            // 
            this.btncalcular.BackColor = System.Drawing.Color.Silver;
            this.btncalcular.Location = new System.Drawing.Point(376, 105);
            this.btncalcular.Name = "btncalcular";
            this.btncalcular.Size = new System.Drawing.Size(107, 40);
            this.btncalcular.TabIndex = 55;
            this.btncalcular.Text = "Calcular";
            this.btncalcular.UseVisualStyleBackColor = false;
            this.btncalcular.Click += new System.EventHandler(this.btncalcular_Click_1);
            // 
            // txtcooperativa
            // 
            this.txtcooperativa.Location = new System.Drawing.Point(218, 147);
            this.txtcooperativa.Name = "txtcooperativa";
            this.txtcooperativa.Size = new System.Drawing.Size(135, 27);
            this.txtcooperativa.TabIndex = 54;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 146);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 19);
            this.label6.TabIndex = 53;
            this.label6.Text = "Cooperativa:";
            // 
            // txtrap
            // 
            this.txtrap.Location = new System.Drawing.Point(577, 80);
            this.txtrap.Name = "txtrap";
            this.txtrap.Size = new System.Drawing.Size(135, 27);
            this.txtrap.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(500, 147);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 51;
            this.label5.Text = "RAP";
            // 
            // txtsegurosocial
            // 
            this.txtsegurosocial.Location = new System.Drawing.Point(219, 184);
            this.txtsegurosocial.Name = "txtsegurosocial";
            this.txtsegurosocial.Size = new System.Drawing.Size(140, 27);
            this.txtsegurosocial.TabIndex = 50;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 19);
            this.label4.TabIndex = 49;
            this.label4.Text = "Seguro Social:";
            // 
            // txthorasextras
            // 
            this.txthorasextras.Location = new System.Drawing.Point(218, 109);
            this.txthorasextras.Name = "txthorasextras";
            this.txthorasextras.Size = new System.Drawing.Size(135, 27);
            this.txthorasextras.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 19);
            this.label3.TabIndex = 47;
            this.label3.Text = "Horas Extras:";
            // 
            // txtsalariobase
            // 
            this.txtsalariobase.Location = new System.Drawing.Point(218, 79);
            this.txtsalariobase.Name = "txtsalariobase";
            this.txtsalariobase.Size = new System.Drawing.Size(135, 27);
            this.txtsalariobase.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 19);
            this.label2.TabIndex = 45;
            this.label2.Text = "Salario Base:";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(218, 46);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(255, 27);
            this.txtnombre.TabIndex = 44;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 19);
            this.label1.TabIndex = 43;
            this.label1.Text = "Nombre Del Empleado:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(501, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(50, 19);
            this.label15.TabIndex = 76;
            this.label15.Text = "RAP:";
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label16.Location = new System.Drawing.Point(0, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(207, 35);
            this.label16.TabIndex = 77;
            this.label16.Text = "Datos del Empleado";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FrmSalarioNeto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1070, 546);
            this.ControlBox = false;
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.BtnPagosT);
            this.Controls.Add(this.txtbox1);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txttotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txttotaldeduccion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtcantidadmensual);
            this.Controls.Add(this.txtprestamo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtpagototal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtpagoxhorasnm);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnguardar);
            this.Controls.Add(this.txtpagoporhoraextra);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btncalcular);
            this.Controls.Add(this.txtcooperativa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtrap);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtsegurosocial);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txthorasextras);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtsalariobase);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Schoolbook", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.MaximizeBox = false;
            this.Name = "FrmSalarioNeto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salario Neto";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnPagosT;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txttotaldeduccion;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtcantidadmensual;
        private System.Windows.Forms.TextBox txtprestamo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtpagototal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txtpagoxhorasnm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnguardar;
        private System.Windows.Forms.TextBox txtpagoporhoraextra;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnsalir;
        private System.Windows.Forms.Button btncalcular;
        private System.Windows.Forms.TextBox txtcooperativa;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtrap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtsegurosocial;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txthorasextras;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtsalariobase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
    }
}