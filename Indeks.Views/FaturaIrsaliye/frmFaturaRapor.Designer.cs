﻿namespace Indeks.Views {
    partial class frmFaturaRapor {
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFaturaRapor));
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageFiltre = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnRapor = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gbVadeTarih = new System.Windows.Forms.GroupBox();
            this.dtVadeBitTar = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtVadeBasTar = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.gbTarih = new System.Windows.Forms.GroupBox();
            this.dtTarBitTar = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.dtTarBasTar = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.grbCariKodu = new System.Windows.Forms.GroupBox();
            this.txtCariKodu = new IndeksControl.AutoCompleteTextBox();
            this.btnCariRehber = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBoxFaturaTipleri = new System.Windows.Forms.GroupBox();
            this.checkedListBoxFatTipleri = new System.Windows.Forms.CheckedListBox();
            this.groupBoxIrsaliyeFatura = new System.Windows.Forms.GroupBox();
            this.checkedListBoxFaturalar = new System.Windows.Forms.CheckedListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslabToplamKdvTutar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslabToplamBrutTutar = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslabToplamIskonto = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.tslabToplamTutar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPageFiltre.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox4.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbVadeTarih.SuspendLayout();
            this.gbTarih.SuspendLayout();
            this.grbCariKodu.SuspendLayout();
            this.groupBoxFaturaTipleri.SuspendLayout();
            this.groupBoxIrsaliyeFatura.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tabControl1);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(0, 0);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(945, 474);
            this.groupBox5.TabIndex = 21;
            this.groupBox5.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageFiltre);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 16);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(939, 455);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPageFiltre
            // 
            this.tabPageFiltre.BackColor = System.Drawing.Color.Transparent;
            this.tabPageFiltre.Controls.Add(this.groupBox2);
            this.tabPageFiltre.Controls.Add(this.groupBox4);
            this.tabPageFiltre.Location = new System.Drawing.Point(4, 22);
            this.tabPageFiltre.Name = "tabPageFiltre";
            this.tabPageFiltre.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFiltre.Size = new System.Drawing.Size(931, 429);
            this.tabPageFiltre.TabIndex = 0;
            this.tabPageFiltre.Text = "StokMaliyetRaporu";
            this.tabPageFiltre.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Location = new System.Drawing.Point(3, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(925, 172);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.Desktop;
            this.dataGridView1.Location = new System.Drawing.Point(3, 16);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 21;
            this.dataGridView1.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.dataGridView1.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(919, 153);
            this.dataGridView1.TabIndex = 1003;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnPrint);
            this.groupBox4.Controls.Add(this.btnRapor);
            this.groupBox4.Controls.Add(this.groupBox1);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Location = new System.Drawing.Point(3, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(925, 251);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            // 
            // btnRapor
            // 
            this.btnRapor.BackColor = System.Drawing.SystemColors.MenuBar;
            this.btnRapor.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnRapor.Location = new System.Drawing.Point(519, 19);
            this.btnRapor.Name = "btnRapor";
            this.btnRapor.Size = new System.Drawing.Size(75, 66);
            this.btnRapor.TabIndex = 12;
            this.btnRapor.Text = "Rapor";
            this.btnRapor.UseVisualStyleBackColor = false;
            this.btnRapor.Click += new System.EventHandler(this.btnRapor_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gbVadeTarih);
            this.groupBox1.Controls.Add(this.gbTarih);
            this.groupBox1.Controls.Add(this.grbCariKodu);
            this.groupBox1.Controls.Add(this.groupBoxFaturaTipleri);
            this.groupBox1.Controls.Add(this.groupBoxIrsaliyeFatura);
            this.groupBox1.Location = new System.Drawing.Point(6, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(496, 228);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arama Seçenekleri";
            // 
            // gbVadeTarih
            // 
            this.gbVadeTarih.Controls.Add(this.dtVadeBitTar);
            this.gbVadeTarih.Controls.Add(this.label2);
            this.gbVadeTarih.Controls.Add(this.dtVadeBasTar);
            this.gbVadeTarih.Controls.Add(this.label6);
            this.gbVadeTarih.Location = new System.Drawing.Point(275, 121);
            this.gbVadeTarih.Name = "gbVadeTarih";
            this.gbVadeTarih.Size = new System.Drawing.Size(177, 96);
            this.gbVadeTarih.TabIndex = 28;
            this.gbVadeTarih.TabStop = false;
            this.gbVadeTarih.Text = "Vade Tarih";
            // 
            // dtVadeBitTar
            // 
            this.dtVadeBitTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVadeBitTar.Location = new System.Drawing.Point(11, 71);
            this.dtVadeBitTar.Name = "dtVadeBitTar";
            this.dtVadeBitTar.Size = new System.Drawing.Size(153, 20);
            this.dtVadeBitTar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Bitiş Tarih";
            // 
            // dtVadeBasTar
            // 
            this.dtVadeBasTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtVadeBasTar.Location = new System.Drawing.Point(11, 32);
            this.dtVadeBasTar.Name = "dtVadeBasTar";
            this.dtVadeBasTar.Size = new System.Drawing.Size(153, 20);
            this.dtVadeBasTar.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Başlangıç Tarih";
            // 
            // gbTarih
            // 
            this.gbTarih.Controls.Add(this.dtTarBitTar);
            this.gbTarih.Controls.Add(this.label1);
            this.gbTarih.Controls.Add(this.dtTarBasTar);
            this.gbTarih.Controls.Add(this.label4);
            this.gbTarih.Location = new System.Drawing.Point(275, 19);
            this.gbTarih.Name = "gbTarih";
            this.gbTarih.Size = new System.Drawing.Size(177, 96);
            this.gbTarih.TabIndex = 27;
            this.gbTarih.TabStop = false;
            this.gbTarih.Text = "Tarih";
            // 
            // dtTarBitTar
            // 
            this.dtTarBitTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarBitTar.Location = new System.Drawing.Point(11, 71);
            this.dtTarBitTar.Name = "dtTarBitTar";
            this.dtTarBitTar.Size = new System.Drawing.Size(153, 20);
            this.dtTarBitTar.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Bitiş Tarih";
            // 
            // dtTarBasTar
            // 
            this.dtTarBasTar.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtTarBasTar.Location = new System.Drawing.Point(11, 32);
            this.dtTarBasTar.Name = "dtTarBasTar";
            this.dtTarBasTar.Size = new System.Drawing.Size(153, 20);
            this.dtTarBasTar.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Başlangıç Tarih";
            // 
            // grbCariKodu
            // 
            this.grbCariKodu.Controls.Add(this.txtCariKodu);
            this.grbCariKodu.Controls.Add(this.btnCariRehber);
            this.grbCariKodu.Controls.Add(this.label5);
            this.grbCariKodu.Location = new System.Drawing.Point(9, 174);
            this.grbCariKodu.Margin = new System.Windows.Forms.Padding(3, 0, 0, 3);
            this.grbCariKodu.Name = "grbCariKodu";
            this.grbCariKodu.Size = new System.Drawing.Size(242, 47);
            this.grbCariKodu.TabIndex = 14;
            this.grbCariKodu.TabStop = false;
            // 
            // txtCariKodu
            // 
            this.txtCariKodu.Ayirac = "";
            this.txtCariKodu.AyracBoslukKullan = true;
            this.txtCariKodu.DataSource = null;
            this.txtCariKodu.ListForeColor = System.Drawing.Color.White;
            this.txtCariKodu.ListItemColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.txtCariKodu.Location = new System.Drawing.Point(61, 16);
            this.txtCariKodu.Name = "txtCariKodu";
            this.txtCariKodu.NextTabControlName = "";
            this.txtCariKodu.Size = new System.Drawing.Size(137, 20);
            this.txtCariKodu.TabIndex = 11;
            this.txtCariKodu.WidthAutoComplete = 200;
            this.txtCariKodu.WidthKod = 15;
            // 
            // btnCariRehber
            // 
            this.btnCariRehber.Location = new System.Drawing.Point(204, 15);
            this.btnCariRehber.Name = "btnCariRehber";
            this.btnCariRehber.Size = new System.Drawing.Size(34, 20);
            this.btnCariRehber.TabIndex = 4;
            this.btnCariRehber.TabStop = false;
            this.btnCariRehber.Text = "...";
            this.btnCariRehber.UseVisualStyleBackColor = true;
            this.btnCariRehber.Click += new System.EventHandler(this.btnCariRehber_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(5, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "CariKodu";
            // 
            // groupBoxFaturaTipleri
            // 
            this.groupBoxFaturaTipleri.Controls.Add(this.checkedListBoxFatTipleri);
            this.groupBoxFaturaTipleri.Location = new System.Drawing.Point(9, 82);
            this.groupBoxFaturaTipleri.Name = "groupBoxFaturaTipleri";
            this.groupBoxFaturaTipleri.Size = new System.Drawing.Size(242, 89);
            this.groupBoxFaturaTipleri.TabIndex = 13;
            this.groupBoxFaturaTipleri.TabStop = false;
            this.groupBoxFaturaTipleri.Text = "Fatura Tipleri";
            // 
            // checkedListBoxFatTipleri
            // 
            this.checkedListBoxFatTipleri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxFatTipleri.FormattingEnabled = true;
            this.checkedListBoxFatTipleri.Items.AddRange(new object[] {
            "Vadeli",
            "Peşin",
            "Iade",
            "KrediKartı"});
            this.checkedListBoxFatTipleri.Location = new System.Drawing.Point(3, 16);
            this.checkedListBoxFatTipleri.Name = "checkedListBoxFatTipleri";
            this.checkedListBoxFatTipleri.Size = new System.Drawing.Size(236, 64);
            this.checkedListBoxFatTipleri.TabIndex = 14;
            // 
            // groupBoxIrsaliyeFatura
            // 
            this.groupBoxIrsaliyeFatura.Controls.Add(this.checkedListBoxFaturalar);
            this.groupBoxIrsaliyeFatura.Location = new System.Drawing.Point(6, 19);
            this.groupBoxIrsaliyeFatura.Name = "groupBoxIrsaliyeFatura";
            this.groupBoxIrsaliyeFatura.Size = new System.Drawing.Size(245, 57);
            this.groupBoxIrsaliyeFatura.TabIndex = 12;
            this.groupBoxIrsaliyeFatura.TabStop = false;
            this.groupBoxIrsaliyeFatura.Text = "Faturalar";
            // 
            // checkedListBoxFaturalar
            // 
            this.checkedListBoxFaturalar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkedListBoxFaturalar.FormattingEnabled = true;
            this.checkedListBoxFaturalar.Items.AddRange(new object[] {
            "AlışFaturası",
            "SatışFaturası"});
            this.checkedListBoxFaturalar.Location = new System.Drawing.Point(3, 16);
            this.checkedListBoxFaturalar.Name = "checkedListBoxFaturalar";
            this.checkedListBoxFaturalar.Size = new System.Drawing.Size(239, 34);
            this.checkedListBoxFaturalar.TabIndex = 14;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.statusStrip1);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox3.Location = new System.Drawing.Point(0, 474);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(945, 46);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.tslabToplamKdvTutar,
            this.toolStripStatusLabel2,
            this.tslabToplamBrutTutar,
            this.toolStripStatusLabel4,
            this.tslabToplamIskonto,
            this.toolStripStatusLabel3,
            this.tslabToplamTutar});
            this.statusStrip1.Location = new System.Drawing.Point(3, 16);
            this.statusStrip1.Margin = new System.Windows.Forms.Padding(3, 0, 3, 3);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(939, 27);
            this.statusStrip1.TabIndex = 1006;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(99, 22);
            this.toolStripStatusLabel1.Text = "ToplamKdvTutar:";
            // 
            // tslabToplamKdvTutar
            // 
            this.tslabToplamKdvTutar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tslabToplamKdvTutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslabToplamKdvTutar.Name = "tslabToplamKdvTutar";
            this.tslabToplamKdvTutar.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(101, 22);
            this.toolStripStatusLabel2.Text = "ToplamBrütTutar:";
            // 
            // tslabToplamBrutTutar
            // 
            this.tslabToplamBrutTutar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tslabToplamBrutTutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslabToplamBrutTutar.Name = "tslabToplamBrutTutar";
            this.tslabToplamBrutTutar.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(87, 22);
            this.toolStripStatusLabel4.Text = "ToplamIskonto";
            // 
            // tslabToplamIskonto
            // 
            this.tslabToplamIskonto.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tslabToplamIskonto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslabToplamIskonto.Name = "tslabToplamIskonto";
            this.tslabToplamIskonto.Size = new System.Drawing.Size(0, 22);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(79, 22);
            this.toolStripStatusLabel3.Text = "ToplamTutar:";
            // 
            // tslabToplamTutar
            // 
            this.tslabToplamTutar.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tslabToplamTutar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.tslabToplamTutar.Name = "tslabToplamTutar";
            this.tslabToplamTutar.Size = new System.Drawing.Size(0, 22);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.SystemColors.Control;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(600, 19);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(49, 31);
            this.btnPrint.TabIndex = 13;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmFaturaRapor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 520);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox3);
            this.Name = "frmFaturaRapor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FaturaRapor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox5.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPageFiltre.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox4.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.gbVadeTarih.ResumeLayout(false);
            this.gbVadeTarih.PerformLayout();
            this.gbTarih.ResumeLayout(false);
            this.gbTarih.PerformLayout();
            this.grbCariKodu.ResumeLayout(false);
            this.grbCariKodu.PerformLayout();
            this.groupBoxFaturaTipleri.ResumeLayout(false);
            this.groupBoxIrsaliyeFatura.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageFiltre;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnRapor;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel tslabToplamKdvTutar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel tslabToplamBrutTutar;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel tslabToplamTutar;
        private System.Windows.Forms.GroupBox groupBoxIrsaliyeFatura;
        private System.Windows.Forms.CheckedListBox checkedListBoxFaturalar;
        private System.Windows.Forms.GroupBox groupBoxFaturaTipleri;
        private System.Windows.Forms.CheckedListBox checkedListBoxFatTipleri;
        private System.Windows.Forms.GroupBox grbCariKodu;
        public IndeksControl.AutoCompleteTextBox txtCariKodu;
        private System.Windows.Forms.Button btnCariRehber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbTarih;
        private System.Windows.Forms.DateTimePicker dtTarBitTar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtTarBasTar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox gbVadeTarih;
        private System.Windows.Forms.DateTimePicker dtVadeBitTar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtVadeBasTar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel tslabToplamIskonto;
    }
}