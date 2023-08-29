namespace ProyCambioGrupo4_IIB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.bCambio = new System.Windows.Forms.Button();
            this.tBTotal = new System.Windows.Forms.TextBox();
            this.tBPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lBResultDinamico = new System.Windows.Forms.ListBox();
            this.lBResultVoraz = new System.Windows.Forms.ListBox();
            this.tBCambio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ilabel = new System.Windows.Forms.Label();
            this.tBD100 = new System.Windows.Forms.TextBox();
            this.tBD50 = new System.Windows.Forms.TextBox();
            this.tBD25 = new System.Windows.Forms.TextBox();
            this.tBD10 = new System.Windows.Forms.TextBox();
            this.tBD5 = new System.Windows.Forms.TextBox();
            this.tBD1 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.tBV100 = new System.Windows.Forms.TextBox();
            this.tBV50 = new System.Windows.Forms.TextBox();
            this.tBV25 = new System.Windows.Forms.TextBox();
            this.tBV10 = new System.Windows.Forms.TextBox();
            this.tBV5 = new System.Windows.Forms.TextBox();
            this.tBV1 = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.xyLabelDinamico = new System.Windows.Forms.GroupBox();
            this.txtExecutionTimeD = new System.Windows.Forms.TextBox();
            this.lblExecutionTimeD = new System.Windows.Forms.Label();
            this.lBDinamico = new System.Windows.Forms.ListBox();
            this.xyLabelVoraz = new System.Windows.Forms.GroupBox();
            this.txtExecutionTimeV = new System.Windows.Forms.TextBox();
            this.lblExecutionTimeV = new System.Windows.Forms.Label();
            this.lBVoraz = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.xyLabelDinamico.SuspendLayout();
            this.xyLabelVoraz.SuspendLayout();
            this.SuspendLayout();
            // 
            // bCambio
            // 
            this.bCambio.Location = new System.Drawing.Point(133, 91);
            this.bCambio.Name = "bCambio";
            this.bCambio.Size = new System.Drawing.Size(136, 23);
            this.bCambio.TabIndex = 0;
            this.bCambio.Text = "Generar Cambio";
            this.bCambio.UseVisualStyleBackColor = true;
            this.bCambio.Click += new System.EventHandler(this.bCambio_Click);
            // 
            // tBTotal
            // 
            this.tBTotal.Location = new System.Drawing.Point(105, 25);
            this.tBTotal.Name = "tBTotal";
            this.tBTotal.Size = new System.Drawing.Size(150, 20);
            this.tBTotal.TabIndex = 1;
            this.tBTotal.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBTotal_KeyPress);
            // 
            // tBPrecio
            // 
            this.tBPrecio.Location = new System.Drawing.Point(105, 55);
            this.tBPrecio.Name = "tBPrecio";
            this.tBPrecio.Size = new System.Drawing.Size(150, 20);
            this.tBPrecio.TabIndex = 3;
            this.tBPrecio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tBPrecio_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "TOTAL : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "PRECIO : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "CAMBIO DINAMICO : ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "CAMBIO VORAZ :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(261, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(14, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "$";
            // 
            // lBResultDinamico
            // 
            this.lBResultDinamico.FormattingEnabled = true;
            this.lBResultDinamico.Location = new System.Drawing.Point(125, 19);
            this.lBResultDinamico.Name = "lBResultDinamico";
            this.lBResultDinamico.Size = new System.Drawing.Size(132, 95);
            this.lBResultDinamico.TabIndex = 14;
            // 
            // lBResultVoraz
            // 
            this.lBResultVoraz.FormattingEnabled = true;
            this.lBResultVoraz.Location = new System.Drawing.Point(125, 121);
            this.lBResultVoraz.Name = "lBResultVoraz";
            this.lBResultVoraz.Size = new System.Drawing.Size(132, 95);
            this.lBResultVoraz.TabIndex = 15;
            // 
            // tBCambio
            // 
            this.tBCambio.Location = new System.Drawing.Point(125, 223);
            this.tBCambio.Name = "tBCambio";
            this.tBCambio.Size = new System.Drawing.Size(132, 20);
            this.tBCambio.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 226);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(95, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "CAMBIO TOTAL : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(261, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(14, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "$";
            // 
            // ilabel
            // 
            this.ilabel.Location = new System.Drawing.Point(24, 20);
            this.ilabel.Name = "ilabel";
            this.ilabel.Size = new System.Drawing.Size(51, 45);
            this.ilabel.TabIndex = 19;
            // 
            // tBD100
            // 
            this.tBD100.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBD100.Location = new System.Drawing.Point(54, 19);
            this.tBD100.Name = "tBD100";
            this.tBD100.Size = new System.Drawing.Size(37, 29);
            this.tBD100.TabIndex = 20;
            // 
            // tBD50
            // 
            this.tBD50.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBD50.Location = new System.Drawing.Point(54, 87);
            this.tBD50.Name = "tBD50";
            this.tBD50.Size = new System.Drawing.Size(37, 29);
            this.tBD50.TabIndex = 21;
            // 
            // tBD25
            // 
            this.tBD25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBD25.Location = new System.Drawing.Point(54, 156);
            this.tBD25.Name = "tBD25";
            this.tBD25.Size = new System.Drawing.Size(37, 29);
            this.tBD25.TabIndex = 22;
            // 
            // tBD10
            // 
            this.tBD10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBD10.Location = new System.Drawing.Point(54, 204);
            this.tBD10.Name = "tBD10";
            this.tBD10.Size = new System.Drawing.Size(37, 29);
            this.tBD10.TabIndex = 23;
            // 
            // tBD5
            // 
            this.tBD5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBD5.Location = new System.Drawing.Point(54, 252);
            this.tBD5.Name = "tBD5";
            this.tBD5.Size = new System.Drawing.Size(37, 29);
            this.tBD5.TabIndex = 24;
            // 
            // tBD1
            // 
            this.tBD1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBD1.Location = new System.Drawing.Point(54, 297);
            this.tBD1.Name = "tBD1";
            this.tBD1.Size = new System.Drawing.Size(37, 29);
            this.tBD1.TabIndex = 25;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tBD100);
            this.groupBox1.Controls.Add(this.tBD50);
            this.groupBox1.Controls.Add(this.tBD25);
            this.groupBox1.Controls.Add(this.tBD10);
            this.groupBox1.Controls.Add(this.tBD5);
            this.groupBox1.Controls.Add(this.tBD1);
            this.groupBox1.Location = new System.Drawing.Point(185, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(106, 339);
            this.groupBox1.TabIndex = 32;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cambio Dinámico";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(3, 305);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "1ctv  X";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 263);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(43, 13);
            this.label12.TabIndex = 30;
            this.label12.Text = "5ctvs X";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(3, 215);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 13);
            this.label11.TabIndex = 29;
            this.label11.Text = "10ctvs X";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 167);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(49, 13);
            this.label10.TabIndex = 28;
            this.label10.Text = "25ctvs X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(3, 98);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 13);
            this.label8.TabIndex = 27;
            this.label8.Text = "50ctvs X";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "1$ X";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.tBV100);
            this.groupBox2.Controls.Add(this.tBV50);
            this.groupBox2.Controls.Add(this.tBV25);
            this.groupBox2.Controls.Add(this.tBV10);
            this.groupBox2.Controls.Add(this.tBV5);
            this.groupBox2.Controls.Add(this.tBV1);
            this.groupBox2.Location = new System.Drawing.Point(317, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(106, 339);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cambio Voraz";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(3, 305);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 13);
            this.label14.TabIndex = 31;
            this.label14.Text = "1ctv  X";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(3, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 13);
            this.label15.TabIndex = 30;
            this.label15.Text = "5ctvs X";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(3, 215);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(49, 13);
            this.label16.TabIndex = 29;
            this.label16.Text = "10ctvs X";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(3, 167);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 13);
            this.label17.TabIndex = 28;
            this.label17.Text = "25ctvs X";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(3, 98);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(49, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "50ctvs X";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(10, 27);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(29, 13);
            this.label19.TabIndex = 26;
            this.label19.Text = "1$ X";
            // 
            // tBV100
            // 
            this.tBV100.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBV100.Location = new System.Drawing.Point(54, 19);
            this.tBV100.Name = "tBV100";
            this.tBV100.Size = new System.Drawing.Size(37, 29);
            this.tBV100.TabIndex = 20;
            // 
            // tBV50
            // 
            this.tBV50.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBV50.Location = new System.Drawing.Point(54, 87);
            this.tBV50.Name = "tBV50";
            this.tBV50.Size = new System.Drawing.Size(37, 29);
            this.tBV50.TabIndex = 21;
            // 
            // tBV25
            // 
            this.tBV25.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBV25.Location = new System.Drawing.Point(54, 156);
            this.tBV25.Name = "tBV25";
            this.tBV25.Size = new System.Drawing.Size(37, 29);
            this.tBV25.TabIndex = 22;
            // 
            // tBV10
            // 
            this.tBV10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBV10.Location = new System.Drawing.Point(54, 204);
            this.tBV10.Name = "tBV10";
            this.tBV10.Size = new System.Drawing.Size(37, 29);
            this.tBV10.TabIndex = 23;
            // 
            // tBV5
            // 
            this.tBV5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBV5.Location = new System.Drawing.Point(54, 252);
            this.tBV5.Name = "tBV5";
            this.tBV5.Size = new System.Drawing.Size(37, 29);
            this.tBV5.TabIndex = 24;
            // 
            // tBV1
            // 
            this.tBV1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tBV1.Location = new System.Drawing.Point(54, 297);
            this.tBV1.Name = "tBV1";
            this.tBV1.Size = new System.Drawing.Size(37, 29);
            this.tBV1.TabIndex = 25;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lBResultDinamico);
            this.groupBox3.Controls.Add(this.lBResultVoraz);
            this.groupBox3.Controls.Add(this.tBCambio);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(12, 134);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(263, 248);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "RESULTADOS";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ilabel);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Controls.Add(this.groupBox2);
            this.groupBox4.Location = new System.Drawing.Point(264, 383);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(432, 360);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "MONEDAS";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 23);
            this.button1.TabIndex = 36;
            this.button1.Text = "Nuevo Cálculo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // xyLabelDinamico
            // 
            this.xyLabelDinamico.Controls.Add(this.txtExecutionTimeD);
            this.xyLabelDinamico.Controls.Add(this.lblExecutionTimeD);
            this.xyLabelDinamico.Controls.Add(this.lBDinamico);
            this.xyLabelDinamico.Location = new System.Drawing.Point(281, 25);
            this.xyLabelDinamico.Name = "xyLabelDinamico";
            this.xyLabelDinamico.Size = new System.Drawing.Size(336, 357);
            this.xyLabelDinamico.TabIndex = 37;
            this.xyLabelDinamico.TabStop = false;
            this.xyLabelDinamico.Text = "CAMBIO DINAMICO";
            // 
            // txtExecutionTimeD
            // 
            this.txtExecutionTimeD.Location = new System.Drawing.Point(210, 315);
            this.txtExecutionTimeD.Name = "txtExecutionTimeD";
            this.txtExecutionTimeD.Size = new System.Drawing.Size(104, 20);
            this.txtExecutionTimeD.TabIndex = 2;
            // 
            // lblExecutionTimeD
            // 
            this.lblExecutionTimeD.AutoSize = true;
            this.lblExecutionTimeD.Location = new System.Drawing.Point(23, 318);
            this.lblExecutionTimeD.Name = "lblExecutionTimeD";
            this.lblExecutionTimeD.Size = new System.Drawing.Size(181, 13);
            this.lblExecutionTimeD.TabIndex = 1;
            this.lblExecutionTimeD.Text = "Tiempo de ejecución (milisegundos): ";
            // 
            // lBDinamico
            // 
            this.lBDinamico.FormattingEnabled = true;
            this.lBDinamico.Location = new System.Drawing.Point(26, 25);
            this.lBDinamico.Name = "lBDinamico";
            this.lBDinamico.Size = new System.Drawing.Size(288, 277);
            this.lBDinamico.TabIndex = 0;
            this.lBDinamico.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lBDinamico_KeyPress);
            // 
            // xyLabelVoraz
            // 
            this.xyLabelVoraz.Controls.Add(this.txtExecutionTimeV);
            this.xyLabelVoraz.Controls.Add(this.lblExecutionTimeV);
            this.xyLabelVoraz.Controls.Add(this.lBVoraz);
            this.xyLabelVoraz.Location = new System.Drawing.Point(623, 25);
            this.xyLabelVoraz.Name = "xyLabelVoraz";
            this.xyLabelVoraz.Size = new System.Drawing.Size(336, 357);
            this.xyLabelVoraz.TabIndex = 38;
            this.xyLabelVoraz.TabStop = false;
            this.xyLabelVoraz.Text = "CAMBIO VORAZ";
            // 
            // txtExecutionTimeV
            // 
            this.txtExecutionTimeV.Location = new System.Drawing.Point(210, 315);
            this.txtExecutionTimeV.Name = "txtExecutionTimeV";
            this.txtExecutionTimeV.Size = new System.Drawing.Size(104, 20);
            this.txtExecutionTimeV.TabIndex = 3;
            // 
            // lblExecutionTimeV
            // 
            this.lblExecutionTimeV.AutoSize = true;
            this.lblExecutionTimeV.Location = new System.Drawing.Point(23, 318);
            this.lblExecutionTimeV.Name = "lblExecutionTimeV";
            this.lblExecutionTimeV.Size = new System.Drawing.Size(181, 13);
            this.lblExecutionTimeV.TabIndex = 2;
            this.lblExecutionTimeV.Text = "Tiempo de ejecución (milisegundos): ";
            // 
            // lBVoraz
            // 
            this.lBVoraz.FormattingEnabled = true;
            this.lBVoraz.Location = new System.Drawing.Point(26, 25);
            this.lBVoraz.Name = "lBVoraz";
            this.lBVoraz.Size = new System.Drawing.Size(288, 277);
            this.lBVoraz.TabIndex = 0;
            this.lBVoraz.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.lBVoraz_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 749);
            this.Controls.Add(this.xyLabelVoraz);
            this.Controls.Add(this.xyLabelDinamico);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBPrecio);
            this.Controls.Add(this.tBTotal);
            this.Controls.Add(this.bCambio);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAMBIO DE MONEDA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.xyLabelDinamico.ResumeLayout(false);
            this.xyLabelDinamico.PerformLayout();
            this.xyLabelVoraz.ResumeLayout(false);
            this.xyLabelVoraz.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bCambio;
        private System.Windows.Forms.TextBox tBTotal;
        private System.Windows.Forms.TextBox tBPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox lBResultDinamico;
        private System.Windows.Forms.ListBox lBResultVoraz;
        private System.Windows.Forms.TextBox tBCambio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ilabel;
        private System.Windows.Forms.TextBox tBD100;
        private System.Windows.Forms.TextBox tBD50;
        private System.Windows.Forms.TextBox tBD25;
        private System.Windows.Forms.TextBox tBD10;
        private System.Windows.Forms.TextBox tBD5;
        private System.Windows.Forms.TextBox tBD1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox tBV100;
        private System.Windows.Forms.TextBox tBV50;
        private System.Windows.Forms.TextBox tBV25;
        private System.Windows.Forms.TextBox tBV10;
        private System.Windows.Forms.TextBox tBV5;
        private System.Windows.Forms.TextBox tBV1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox xyLabelDinamico;
        private System.Windows.Forms.ListBox lBDinamico;
        private System.Windows.Forms.GroupBox xyLabelVoraz;
        private System.Windows.Forms.ListBox lBVoraz;
        private System.Windows.Forms.TextBox txtExecutionTimeD;
        private System.Windows.Forms.Label lblExecutionTimeD;
        private System.Windows.Forms.TextBox txtExecutionTimeV;
        private System.Windows.Forms.Label lblExecutionTimeV;
    }
}

