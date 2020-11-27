namespace Radix_Sort_GUI {
    partial class FormPrincipal {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tabOperaciones = new System.Windows.Forms.TabControl();
            this.tabNormal = new System.Windows.Forms.TabPage();
            this.lblTiempoNormal = new System.Windows.Forms.Label();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hasta = new System.Windows.Forms.NumericUpDown();
            this.desde = new System.Windows.Forms.NumericUpDown();
            this.listNumerosOrdenadosTabNormal = new System.Windows.Forms.ListBox();
            this.listNumerosTabNormal = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCuantosNumerosNormales = new System.Windows.Forms.TextBox();
            this.btnGenerar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label19 = new System.Windows.Forms.Label();
            this.lblTiempoOrdenamientoObjetos = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCantidadObjetos = new System.Windows.Forms.TextBox();
            this.dtgObjetos = new System.Windows.Forms.DataGridView();
            this.clmnIDEmpleado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnEdad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmnHorasTrabajadas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOrdenarObjetos = new System.Windows.Forms.Button();
            this.btnGeneraObjetos = new System.Windows.Forms.Button();
            this.tabBuckets = new System.Windows.Forms.TabPage();
            this.lblIteraciones = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBeingOrdered = new System.Windows.Forms.ListBox();
            this.numericDelay = new System.Windows.Forms.NumericUpDown();
            this.lblDelay = new System.Windows.Forms.Label();
            this.numericNumerosBuckets = new System.Windows.Forms.NumericUpDown();
            this.btnSimular = new System.Windows.Forms.Button();
            this.btnGenerarBuckets = new System.Windows.Forms.Button();
            this.listNumerosEnBuckets = new System.Windows.Forms.ListBox();
            this.bucket9 = new System.Windows.Forms.ListBox();
            this.bucket8 = new System.Windows.Forms.ListBox();
            this.bucket7 = new System.Windows.Forms.ListBox();
            this.bucket6 = new System.Windows.Forms.ListBox();
            this.bucket5 = new System.Windows.Forms.ListBox();
            this.bucket4 = new System.Windows.Forms.ListBox();
            this.bucket3 = new System.Windows.Forms.ListBox();
            this.bucket2 = new System.Windows.Forms.ListBox();
            this.bucket1 = new System.Windows.Forms.ListBox();
            this.bucket0 = new System.Windows.Forms.ListBox();
            this.tabVSQuicksort = new System.Windows.Forms.TabPage();
            this.listQuick = new System.Windows.Forms.ListBox();
            this.listRadix = new System.Windows.Forms.ListBox();
            this.grbOpciones = new System.Windows.Forms.GroupBox();
            this.txtCtdVersus = new System.Windows.Forms.TextBox();
            this.chkLongitudFija = new System.Windows.Forms.CheckBox();
            this.btnGenerarVersus = new System.Windows.Forms.Button();
            this.listVersusNumeros = new System.Windows.Forms.ListBox();
            this.tiempoQuick = new System.Windows.Forms.Label();
            this.tiempoRadix = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.tabOperaciones.SuspendLayout();
            this.tabNormal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hasta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.desde)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgObjetos)).BeginInit();
            this.tabBuckets.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelay)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumerosBuckets)).BeginInit();
            this.tabVSQuicksort.SuspendLayout();
            this.grbOpciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabOperaciones
            // 
            this.tabOperaciones.Controls.Add(this.tabNormal);
            this.tabOperaciones.Controls.Add(this.tabPage2);
            this.tabOperaciones.Controls.Add(this.tabBuckets);
            this.tabOperaciones.Controls.Add(this.tabVSQuicksort);
            this.tabOperaciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabOperaciones.Location = new System.Drawing.Point(12, 12);
            this.tabOperaciones.Name = "tabOperaciones";
            this.tabOperaciones.SelectedIndex = 0;
            this.tabOperaciones.Size = new System.Drawing.Size(1019, 535);
            this.tabOperaciones.TabIndex = 0;
            // 
            // tabNormal
            // 
            this.tabNormal.Controls.Add(this.lblTiempoNormal);
            this.tabNormal.Controls.Add(this.btnOrdenar);
            this.tabNormal.Controls.Add(this.label3);
            this.tabNormal.Controls.Add(this.label2);
            this.tabNormal.Controls.Add(this.hasta);
            this.tabNormal.Controls.Add(this.desde);
            this.tabNormal.Controls.Add(this.listNumerosOrdenadosTabNormal);
            this.tabNormal.Controls.Add(this.listNumerosTabNormal);
            this.tabNormal.Controls.Add(this.label1);
            this.tabNormal.Controls.Add(this.txtCuantosNumerosNormales);
            this.tabNormal.Controls.Add(this.btnGenerar);
            this.tabNormal.Location = new System.Drawing.Point(4, 33);
            this.tabNormal.Name = "tabNormal";
            this.tabNormal.Padding = new System.Windows.Forms.Padding(3);
            this.tabNormal.Size = new System.Drawing.Size(1011, 498);
            this.tabNormal.TabIndex = 0;
            this.tabNormal.Text = "Radix Sort General";
            this.tabNormal.UseVisualStyleBackColor = true;
            // 
            // lblTiempoNormal
            // 
            this.lblTiempoNormal.AutoSize = true;
            this.lblTiempoNormal.Location = new System.Drawing.Point(61, 60);
            this.lblTiempoNormal.Name = "lblTiempoNormal";
            this.lblTiempoNormal.Size = new System.Drawing.Size(183, 24);
            this.lblTiempoNormal.TabIndex = 12;
            this.lblTiempoNormal.Text = "Tiempo en ordenar: ";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenar.Location = new System.Drawing.Point(508, 226);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(176, 95);
            this.btnOrdenar.TabIndex = 11;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Hasta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(60, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 24);
            this.label2.TabIndex = 9;
            this.label2.Text = "Desde";
            // 
            // hasta
            // 
            this.hasta.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hasta.Location = new System.Drawing.Point(177, 240);
            this.hasta.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.hasta.Name = "hasta";
            this.hasta.Size = new System.Drawing.Size(59, 29);
            this.hasta.TabIndex = 8;
            // 
            // desde
            // 
            this.desde.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desde.Location = new System.Drawing.Point(177, 196);
            this.desde.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.desde.Name = "desde";
            this.desde.Size = new System.Drawing.Size(59, 29);
            this.desde.TabIndex = 7;
            // 
            // listNumerosOrdenadosTabNormal
            // 
            this.listNumerosOrdenadosTabNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listNumerosOrdenadosTabNormal.FormattingEnabled = true;
            this.listNumerosOrdenadosTabNormal.ItemHeight = 24;
            this.listNumerosOrdenadosTabNormal.Location = new System.Drawing.Point(690, 60);
            this.listNumerosOrdenadosTabNormal.Name = "listNumerosOrdenadosTabNormal";
            this.listNumerosOrdenadosTabNormal.Size = new System.Drawing.Size(148, 412);
            this.listNumerosOrdenadosTabNormal.TabIndex = 4;
            // 
            // listNumerosTabNormal
            // 
            this.listNumerosTabNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listNumerosTabNormal.FormattingEnabled = true;
            this.listNumerosTabNormal.ItemHeight = 24;
            this.listNumerosTabNormal.Location = new System.Drawing.Point(358, 60);
            this.listNumerosTabNormal.Name = "listNumerosTabNormal";
            this.listNumerosTabNormal.Size = new System.Drawing.Size(144, 412);
            this.listNumerosTabNormal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cantidad de numeros";
            // 
            // txtCuantosNumerosNormales
            // 
            this.txtCuantosNumerosNormales.Location = new System.Drawing.Point(64, 153);
            this.txtCuantosNumerosNormales.Name = "txtCuantosNumerosNormales";
            this.txtCuantosNumerosNormales.Size = new System.Drawing.Size(173, 29);
            this.txtCuantosNumerosNormales.TabIndex = 1;
            // 
            // btnGenerar
            // 
            this.btnGenerar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerar.Location = new System.Drawing.Point(52, 280);
            this.btnGenerar.Name = "btnGenerar";
            this.btnGenerar.Size = new System.Drawing.Size(198, 58);
            this.btnGenerar.TabIndex = 0;
            this.btnGenerar.Text = "Generar numeros aleatorios";
            this.btnGenerar.UseVisualStyleBackColor = true;
            this.btnGenerar.Click += new System.EventHandler(this.btnGenerar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.lblTiempoOrdenamientoObjetos);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.txtCantidadObjetos);
            this.tabPage2.Controls.Add(this.dtgObjetos);
            this.tabPage2.Controls.Add(this.btnOrdenarObjetos);
            this.tabPage2.Controls.Add(this.btnGeneraObjetos);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1011, 498);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Radix con Objetos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(15, 18);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(269, 24);
            this.label19.TabIndex = 6;
            this.label19.Text = "Empleados (ordenados por ID)";
            // 
            // lblTiempoOrdenamientoObjetos
            // 
            this.lblTiempoOrdenamientoObjetos.AutoSize = true;
            this.lblTiempoOrdenamientoObjetos.Location = new System.Drawing.Point(182, 477);
            this.lblTiempoOrdenamientoObjetos.Name = "lblTiempoOrdenamientoObjetos";
            this.lblTiempoOrdenamientoObjetos.Size = new System.Drawing.Size(0, 24);
            this.lblTiempoOrdenamientoObjetos.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(800, 341);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 24);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cantidad de objetos";
            // 
            // txtCantidadObjetos
            // 
            this.txtCantidadObjetos.Location = new System.Drawing.Point(804, 368);
            this.txtCantidadObjetos.Name = "txtCantidadObjetos";
            this.txtCantidadObjetos.Size = new System.Drawing.Size(163, 29);
            this.txtCantidadObjetos.TabIndex = 3;
            // 
            // dtgObjetos
            // 
            this.dtgObjetos.AllowUserToAddRows = false;
            this.dtgObjetos.AllowUserToDeleteRows = false;
            this.dtgObjetos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgObjetos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgObjetos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmnIDEmpleado,
            this.clmnNombre,
            this.clmnEdad,
            this.clmnHorasTrabajadas});
            this.dtgObjetos.GridColor = System.Drawing.SystemColors.Control;
            this.dtgObjetos.Location = new System.Drawing.Point(19, 57);
            this.dtgObjetos.Name = "dtgObjetos";
            this.dtgObjetos.ReadOnly = true;
            this.dtgObjetos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgObjetos.Size = new System.Drawing.Size(969, 272);
            this.dtgObjetos.TabIndex = 2;
            // 
            // clmnIDEmpleado
            // 
            this.clmnIDEmpleado.HeaderText = "ID";
            this.clmnIDEmpleado.Name = "clmnIDEmpleado";
            this.clmnIDEmpleado.ReadOnly = true;
            // 
            // clmnNombre
            // 
            this.clmnNombre.HeaderText = "Nombre";
            this.clmnNombre.Name = "clmnNombre";
            this.clmnNombre.ReadOnly = true;
            // 
            // clmnEdad
            // 
            this.clmnEdad.HeaderText = "Edad";
            this.clmnEdad.Name = "clmnEdad";
            this.clmnEdad.ReadOnly = true;
            // 
            // clmnHorasTrabajadas
            // 
            this.clmnHorasTrabajadas.HeaderText = "Horas Trabajadas";
            this.clmnHorasTrabajadas.Name = "clmnHorasTrabajadas";
            this.clmnHorasTrabajadas.ReadOnly = true;
            // 
            // btnOrdenarObjetos
            // 
            this.btnOrdenarObjetos.Location = new System.Drawing.Point(804, 444);
            this.btnOrdenarObjetos.Name = "btnOrdenarObjetos";
            this.btnOrdenarObjetos.Size = new System.Drawing.Size(163, 35);
            this.btnOrdenarObjetos.TabIndex = 1;
            this.btnOrdenarObjetos.Text = "Ordenar objetos";
            this.btnOrdenarObjetos.UseVisualStyleBackColor = true;
            this.btnOrdenarObjetos.Click += new System.EventHandler(this.btnOrdenarObjetos_Click);
            // 
            // btnGeneraObjetos
            // 
            this.btnGeneraObjetos.Location = new System.Drawing.Point(804, 403);
            this.btnGeneraObjetos.Name = "btnGeneraObjetos";
            this.btnGeneraObjetos.Size = new System.Drawing.Size(163, 35);
            this.btnGeneraObjetos.TabIndex = 0;
            this.btnGeneraObjetos.Text = "Generar objetos";
            this.btnGeneraObjetos.UseVisualStyleBackColor = true;
            this.btnGeneraObjetos.Click += new System.EventHandler(this.btnGeneraObjetos_Click);
            // 
            // tabBuckets
            // 
            this.tabBuckets.Controls.Add(this.lblIteraciones);
            this.tabBuckets.Controls.Add(this.label16);
            this.tabBuckets.Controls.Add(this.label15);
            this.tabBuckets.Controls.Add(this.label14);
            this.tabBuckets.Controls.Add(this.label13);
            this.tabBuckets.Controls.Add(this.label12);
            this.tabBuckets.Controls.Add(this.label11);
            this.tabBuckets.Controls.Add(this.label10);
            this.tabBuckets.Controls.Add(this.label9);
            this.tabBuckets.Controls.Add(this.label8);
            this.tabBuckets.Controls.Add(this.label7);
            this.tabBuckets.Controls.Add(this.label6);
            this.tabBuckets.Controls.Add(this.label5);
            this.tabBuckets.Controls.Add(this.listBeingOrdered);
            this.tabBuckets.Controls.Add(this.numericDelay);
            this.tabBuckets.Controls.Add(this.lblDelay);
            this.tabBuckets.Controls.Add(this.numericNumerosBuckets);
            this.tabBuckets.Controls.Add(this.btnSimular);
            this.tabBuckets.Controls.Add(this.btnGenerarBuckets);
            this.tabBuckets.Controls.Add(this.listNumerosEnBuckets);
            this.tabBuckets.Controls.Add(this.bucket9);
            this.tabBuckets.Controls.Add(this.bucket8);
            this.tabBuckets.Controls.Add(this.bucket7);
            this.tabBuckets.Controls.Add(this.bucket6);
            this.tabBuckets.Controls.Add(this.bucket5);
            this.tabBuckets.Controls.Add(this.bucket4);
            this.tabBuckets.Controls.Add(this.bucket3);
            this.tabBuckets.Controls.Add(this.bucket2);
            this.tabBuckets.Controls.Add(this.bucket1);
            this.tabBuckets.Controls.Add(this.bucket0);
            this.tabBuckets.Location = new System.Drawing.Point(4, 33);
            this.tabBuckets.Name = "tabBuckets";
            this.tabBuckets.Padding = new System.Windows.Forms.Padding(3);
            this.tabBuckets.Size = new System.Drawing.Size(1011, 498);
            this.tabBuckets.TabIndex = 2;
            this.tabBuckets.Text = "Cubetas";
            this.tabBuckets.UseVisualStyleBackColor = true;
            // 
            // lblIteraciones
            // 
            this.lblIteraciones.AutoSize = true;
            this.lblIteraciones.Location = new System.Drawing.Point(612, 33);
            this.lblIteraciones.Name = "lblIteraciones";
            this.lblIteraciones.Size = new System.Drawing.Size(91, 24);
            this.lblIteraciones.TabIndex = 30;
            this.lblIteraciones.Text = "Iteracion: ";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(333, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(184, 24);
            this.label16.TabIndex = 29;
            this.label16.Text = "Numeros ordenados";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(28, 22);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(184, 24);
            this.label15.TabIndex = 28;
            this.label15.Text = "Numeros generados";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(893, 303);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(20, 24);
            this.label14.TabIndex = 27;
            this.label14.Text = "9";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(800, 303);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(20, 24);
            this.label13.TabIndex = 26;
            this.label13.Text = "8";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(711, 303);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(20, 24);
            this.label12.TabIndex = 25;
            this.label12.Text = "7";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(622, 303);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(20, 24);
            this.label11.TabIndex = 24;
            this.label11.Text = "6";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(531, 303);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 24);
            this.label10.TabIndex = 23;
            this.label10.Text = "5";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(443, 303);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 24);
            this.label9.TabIndex = 22;
            this.label9.Text = "4";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(352, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 24);
            this.label8.TabIndex = 21;
            this.label8.Text = "3";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(267, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 24);
            this.label7.TabIndex = 20;
            this.label7.Text = "2";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(171, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 24);
            this.label6.TabIndex = 19;
            this.label6.Text = "1";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(84, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 24);
            this.label5.TabIndex = 18;
            this.label5.Text = "0";
            // 
            // listBeingOrdered
            // 
            this.listBeingOrdered.FormattingEnabled = true;
            this.listBeingOrdered.ItemHeight = 24;
            this.listBeingOrdered.Location = new System.Drawing.Point(356, 60);
            this.listBeingOrdered.Name = "listBeingOrdered";
            this.listBeingOrdered.Size = new System.Drawing.Size(120, 196);
            this.listBeingOrdered.TabIndex = 17;
            // 
            // numericDelay
            // 
            this.numericDelay.Location = new System.Drawing.Point(832, 60);
            this.numericDelay.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numericDelay.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericDelay.Name = "numericDelay";
            this.numericDelay.Size = new System.Drawing.Size(120, 29);
            this.numericDelay.TabIndex = 16;
            this.numericDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericDelay.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericDelay.ValueChanged += new System.EventHandler(this.numericDelay_ValueChanged);
            this.numericDelay.Scroll += new System.Windows.Forms.ScrollEventHandler(this.numericDelay_Scroll);
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.Location = new System.Drawing.Point(851, 33);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(87, 24);
            this.lblDelay.TabIndex = 15;
            this.lblDelay.Text = "Delay: 10";
            // 
            // numericNumerosBuckets
            // 
            this.numericNumerosBuckets.Location = new System.Drawing.Point(202, 49);
            this.numericNumerosBuckets.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.numericNumerosBuckets.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericNumerosBuckets.Name = "numericNumerosBuckets";
            this.numericNumerosBuckets.Size = new System.Drawing.Size(120, 29);
            this.numericNumerosBuckets.TabIndex = 14;
            this.numericNumerosBuckets.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // btnSimular
            // 
            this.btnSimular.Enabled = false;
            this.btnSimular.Location = new System.Drawing.Point(202, 184);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(120, 61);
            this.btnSimular.TabIndex = 12;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnGenerarBuckets
            // 
            this.btnGenerarBuckets.Location = new System.Drawing.Point(202, 104);
            this.btnGenerarBuckets.Name = "btnGenerarBuckets";
            this.btnGenerarBuckets.Size = new System.Drawing.Size(120, 56);
            this.btnGenerarBuckets.TabIndex = 11;
            this.btnGenerarBuckets.Text = "Generar  numeros aleatorios";
            this.btnGenerarBuckets.UseVisualStyleBackColor = true;
            this.btnGenerarBuckets.Click += new System.EventHandler(this.btnGenerarBuckets_Click);
            // 
            // listNumerosEnBuckets
            // 
            this.listNumerosEnBuckets.FormattingEnabled = true;
            this.listNumerosEnBuckets.ItemHeight = 24;
            this.listNumerosEnBuckets.Location = new System.Drawing.Point(58, 49);
            this.listNumerosEnBuckets.Name = "listNumerosEnBuckets";
            this.listNumerosEnBuckets.Size = new System.Drawing.Size(120, 196);
            this.listNumerosEnBuckets.TabIndex = 10;
            // 
            // bucket9
            // 
            this.bucket9.FormattingEnabled = true;
            this.bucket9.ItemHeight = 24;
            this.bucket9.Location = new System.Drawing.Point(868, 330);
            this.bucket9.Name = "bucket9";
            this.bucket9.Size = new System.Drawing.Size(84, 148);
            this.bucket9.TabIndex = 9;
            // 
            // bucket8
            // 
            this.bucket8.FormattingEnabled = true;
            this.bucket8.ItemHeight = 24;
            this.bucket8.Location = new System.Drawing.Point(778, 330);
            this.bucket8.Name = "bucket8";
            this.bucket8.Size = new System.Drawing.Size(84, 148);
            this.bucket8.TabIndex = 8;
            // 
            // bucket7
            // 
            this.bucket7.FormattingEnabled = true;
            this.bucket7.ItemHeight = 24;
            this.bucket7.Location = new System.Drawing.Point(688, 330);
            this.bucket7.Name = "bucket7";
            this.bucket7.Size = new System.Drawing.Size(84, 148);
            this.bucket7.TabIndex = 7;
            // 
            // bucket6
            // 
            this.bucket6.FormattingEnabled = true;
            this.bucket6.ItemHeight = 24;
            this.bucket6.Location = new System.Drawing.Point(598, 330);
            this.bucket6.Name = "bucket6";
            this.bucket6.Size = new System.Drawing.Size(84, 148);
            this.bucket6.TabIndex = 6;
            // 
            // bucket5
            // 
            this.bucket5.FormattingEnabled = true;
            this.bucket5.ItemHeight = 24;
            this.bucket5.Location = new System.Drawing.Point(508, 330);
            this.bucket5.Name = "bucket5";
            this.bucket5.Size = new System.Drawing.Size(84, 148);
            this.bucket5.TabIndex = 5;
            // 
            // bucket4
            // 
            this.bucket4.FormattingEnabled = true;
            this.bucket4.ItemHeight = 24;
            this.bucket4.Location = new System.Drawing.Point(418, 330);
            this.bucket4.Name = "bucket4";
            this.bucket4.Size = new System.Drawing.Size(84, 148);
            this.bucket4.TabIndex = 4;
            // 
            // bucket3
            // 
            this.bucket3.FormattingEnabled = true;
            this.bucket3.ItemHeight = 24;
            this.bucket3.Location = new System.Drawing.Point(328, 330);
            this.bucket3.Name = "bucket3";
            this.bucket3.Size = new System.Drawing.Size(84, 148);
            this.bucket3.TabIndex = 3;
            // 
            // bucket2
            // 
            this.bucket2.FormattingEnabled = true;
            this.bucket2.ItemHeight = 24;
            this.bucket2.Location = new System.Drawing.Point(238, 330);
            this.bucket2.Name = "bucket2";
            this.bucket2.Size = new System.Drawing.Size(84, 148);
            this.bucket2.TabIndex = 2;
            // 
            // bucket1
            // 
            this.bucket1.FormattingEnabled = true;
            this.bucket1.ItemHeight = 24;
            this.bucket1.Location = new System.Drawing.Point(148, 330);
            this.bucket1.Name = "bucket1";
            this.bucket1.Size = new System.Drawing.Size(84, 148);
            this.bucket1.TabIndex = 1;
            // 
            // bucket0
            // 
            this.bucket0.FormattingEnabled = true;
            this.bucket0.ItemHeight = 24;
            this.bucket0.Location = new System.Drawing.Point(58, 330);
            this.bucket0.Name = "bucket0";
            this.bucket0.Size = new System.Drawing.Size(84, 148);
            this.bucket0.TabIndex = 0;
            // 
            // tabVSQuicksort
            // 
            this.tabVSQuicksort.Controls.Add(this.listQuick);
            this.tabVSQuicksort.Controls.Add(this.listRadix);
            this.tabVSQuicksort.Controls.Add(this.grbOpciones);
            this.tabVSQuicksort.Controls.Add(this.btnGenerarVersus);
            this.tabVSQuicksort.Controls.Add(this.listVersusNumeros);
            this.tabVSQuicksort.Controls.Add(this.tiempoQuick);
            this.tabVSQuicksort.Controls.Add(this.tiempoRadix);
            this.tabVSQuicksort.Controls.Add(this.label18);
            this.tabVSQuicksort.Controls.Add(this.label17);
            this.tabVSQuicksort.Location = new System.Drawing.Point(4, 33);
            this.tabVSQuicksort.Name = "tabVSQuicksort";
            this.tabVSQuicksort.Padding = new System.Windows.Forms.Padding(3);
            this.tabVSQuicksort.Size = new System.Drawing.Size(1011, 498);
            this.tabVSQuicksort.TabIndex = 3;
            this.tabVSQuicksort.Text = "Radix vs QuickSort";
            this.tabVSQuicksort.UseVisualStyleBackColor = true;
            // 
            // listQuick
            // 
            this.listQuick.FormattingEnabled = true;
            this.listQuick.ItemHeight = 24;
            this.listQuick.Location = new System.Drawing.Point(685, 203);
            this.listQuick.Name = "listQuick";
            this.listQuick.Size = new System.Drawing.Size(187, 76);
            this.listQuick.TabIndex = 8;
            // 
            // listRadix
            // 
            this.listRadix.FormattingEnabled = true;
            this.listRadix.ItemHeight = 24;
            this.listRadix.Location = new System.Drawing.Point(82, 203);
            this.listRadix.Name = "listRadix";
            this.listRadix.Size = new System.Drawing.Size(196, 76);
            this.listRadix.TabIndex = 7;
            // 
            // grbOpciones
            // 
            this.grbOpciones.Controls.Add(this.txtCtdVersus);
            this.grbOpciones.Controls.Add(this.chkLongitudFija);
            this.grbOpciones.Location = new System.Drawing.Point(352, 228);
            this.grbOpciones.Name = "grbOpciones";
            this.grbOpciones.Size = new System.Drawing.Size(234, 141);
            this.grbOpciones.TabIndex = 6;
            this.grbOpciones.TabStop = false;
            this.grbOpciones.Text = "Ajustes";
            // 
            // txtCtdVersus
            // 
            this.txtCtdVersus.Location = new System.Drawing.Point(54, 93);
            this.txtCtdVersus.Name = "txtCtdVersus";
            this.txtCtdVersus.Size = new System.Drawing.Size(120, 29);
            this.txtCtdVersus.TabIndex = 1;
            // 
            // chkLongitudFija
            // 
            this.chkLongitudFija.AutoSize = true;
            this.chkLongitudFija.Location = new System.Drawing.Point(12, 43);
            this.chkLongitudFija.Name = "chkLongitudFija";
            this.chkLongitudFija.Size = new System.Drawing.Size(206, 28);
            this.chkLongitudFija.TabIndex = 0;
            this.chkLongitudFija.Text = "Longitud fija (1 digito)";
            this.chkLongitudFija.UseVisualStyleBackColor = true;
            // 
            // btnGenerarVersus
            // 
            this.btnGenerarVersus.Location = new System.Drawing.Point(406, 388);
            this.btnGenerarVersus.Name = "btnGenerarVersus";
            this.btnGenerarVersus.Size = new System.Drawing.Size(120, 59);
            this.btnGenerarVersus.TabIndex = 5;
            this.btnGenerarVersus.Text = "Empezar carrera";
            this.btnGenerarVersus.UseVisualStyleBackColor = true;
            this.btnGenerarVersus.Click += new System.EventHandler(this.btnGenerarVersus_Click);
            // 
            // listVersusNumeros
            // 
            this.listVersusNumeros.FormattingEnabled = true;
            this.listVersusNumeros.ItemHeight = 24;
            this.listVersusNumeros.Location = new System.Drawing.Point(352, 34);
            this.listVersusNumeros.Name = "listVersusNumeros";
            this.listVersusNumeros.Size = new System.Drawing.Size(234, 172);
            this.listVersusNumeros.TabIndex = 4;
            // 
            // tiempoQuick
            // 
            this.tiempoQuick.AutoSize = true;
            this.tiempoQuick.Location = new System.Drawing.Point(660, 423);
            this.tiempoQuick.Name = "tiempoQuick";
            this.tiempoQuick.Size = new System.Drawing.Size(200, 24);
            this.tiempoQuick.TabIndex = 3;
            this.tiempoQuick.Text = "Tiempo de ejecución: ";
            // 
            // tiempoRadix
            // 
            this.tiempoRadix.AutoSize = true;
            this.tiempoRadix.Location = new System.Drawing.Point(78, 423);
            this.tiempoRadix.Name = "tiempoRadix";
            this.tiempoRadix.Size = new System.Drawing.Size(200, 24);
            this.tiempoRadix.TabIndex = 2;
            this.tiempoRadix.Text = "Tiempo de ejecución: ";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(727, 160);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(92, 24);
            this.label18.TabIndex = 1;
            this.label18.Text = "QuickSort";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(124, 160);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(96, 24);
            this.label17.TabIndex = 0;
            this.label17.Text = "Radix Sort";
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 559);
            this.Controls.Add(this.tabOperaciones);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Radix Sort GUI (LZ)";
            this.tabOperaciones.ResumeLayout(false);
            this.tabNormal.ResumeLayout(false);
            this.tabNormal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hasta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.desde)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgObjetos)).EndInit();
            this.tabBuckets.ResumeLayout(false);
            this.tabBuckets.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDelay)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericNumerosBuckets)).EndInit();
            this.tabVSQuicksort.ResumeLayout(false);
            this.tabVSQuicksort.PerformLayout();
            this.grbOpciones.ResumeLayout(false);
            this.grbOpciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabOperaciones;
        private System.Windows.Forms.TabPage tabNormal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCuantosNumerosNormales;
        private System.Windows.Forms.Button btnGenerar;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ListBox listNumerosOrdenadosTabNormal;
        private System.Windows.Forms.ListBox listNumerosTabNormal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown hasta;
        private System.Windows.Forms.NumericUpDown desde;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Label lblTiempoNormal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCantidadObjetos;
        private System.Windows.Forms.DataGridView dtgObjetos;
        private System.Windows.Forms.Button btnOrdenarObjetos;
        private System.Windows.Forms.Button btnGeneraObjetos;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnIDEmpleado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnEdad;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmnHorasTrabajadas;
        private System.Windows.Forms.Label lblTiempoOrdenamientoObjetos;
        private System.Windows.Forms.TabPage tabBuckets;
        private System.Windows.Forms.ListBox bucket9;
        private System.Windows.Forms.ListBox bucket8;
        private System.Windows.Forms.ListBox bucket7;
        private System.Windows.Forms.ListBox bucket6;
        private System.Windows.Forms.ListBox bucket5;
        private System.Windows.Forms.ListBox bucket4;
        private System.Windows.Forms.ListBox bucket3;
        private System.Windows.Forms.ListBox bucket2;
        private System.Windows.Forms.ListBox bucket1;
        private System.Windows.Forms.ListBox bucket0;
        private System.Windows.Forms.Button btnGenerarBuckets;
        private System.Windows.Forms.ListBox listNumerosEnBuckets;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.NumericUpDown numericNumerosBuckets;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.NumericUpDown numericDelay;
        private System.Windows.Forms.ListBox listBeingOrdered;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblIteraciones;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TabPage tabVSQuicksort;
        private System.Windows.Forms.ListBox listQuick;
        private System.Windows.Forms.ListBox listRadix;
        private System.Windows.Forms.GroupBox grbOpciones;
        private System.Windows.Forms.TextBox txtCtdVersus;
        private System.Windows.Forms.CheckBox chkLongitudFija;
        private System.Windows.Forms.Button btnGenerarVersus;
        private System.Windows.Forms.ListBox listVersusNumeros;
        private System.Windows.Forms.Label tiempoQuick;
        private System.Windows.Forms.Label tiempoRadix;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
    }
}

