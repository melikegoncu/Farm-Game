namespace Melikenin_Çiftligi
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btn_Keçi_Yem = new System.Windows.Forms.Button();
            this.btn_Inek_Yem = new System.Windows.Forms.Button();
            this.lbl_Keci_Sut = new System.Windows.Forms.Label();
            this.lbl_Ord_Yum = new System.Windows.Forms.Label();
            this.lbl_Inek_Süt = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_ÖlüKeçi = new System.Windows.Forms.Label();
            this.Progress_İnekCan = new System.Windows.Forms.ProgressBar();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btn_KeçiSüt_Sat = new System.Windows.Forms.Button();
            this.btn_InekSüt_Sat = new System.Windows.Forms.Button();
            this.btn_OrdekYum_Sat = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.btn_TavukYum_Sat = new System.Windows.Forms.Button();
            this.lbl_Kasa = new System.Windows.Forms.Label();
            this.lbl_Süre = new System.Windows.Forms.Label();
            this.Progress_KeçiCan = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lbl_Tav_Yum = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.picBoxTavuk = new System.Windows.Forms.PictureBox();
            this.picBoxOrdek = new System.Windows.Forms.PictureBox();
            this.lbl_ÖlüTavuk = new System.Windows.Forms.Label();
            this.Progress_TavukCan = new System.Windows.Forms.ProgressBar();
            this.btn_Tavuk_Yem = new System.Windows.Forms.Button();
            this.lbl_ÖlüÖrdek = new System.Windows.Forms.Label();
            this.Progress_ÖrdekCan = new System.Windows.Forms.ProgressBar();
            this.Btn_Ordek_Yem = new System.Windows.Forms.Button();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Ölüİnek = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picBoxInek = new System.Windows.Forms.PictureBox();
            this.picBoxKeci = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTavuk)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOrdek)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKeci)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Keçi_Yem
            // 
            this.btn_Keçi_Yem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Keçi_Yem.Location = new System.Drawing.Point(113, 194);
            this.btn_Keçi_Yem.Name = "btn_Keçi_Yem";
            this.btn_Keçi_Yem.Size = new System.Drawing.Size(278, 22);
            this.btn_Keçi_Yem.TabIndex = 8;
            this.btn_Keçi_Yem.Text = "Yem Ver";
            this.btn_Keçi_Yem.UseVisualStyleBackColor = true;
            this.btn_Keçi_Yem.Click += new System.EventHandler(this.btn_Keçi_Yem_Click);
            // 
            // btn_Inek_Yem
            // 
            this.btn_Inek_Yem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Inek_Yem.Location = new System.Drawing.Point(113, 105);
            this.btn_Inek_Yem.Name = "btn_Inek_Yem";
            this.btn_Inek_Yem.Size = new System.Drawing.Size(278, 23);
            this.btn_Inek_Yem.TabIndex = 9;
            this.btn_Inek_Yem.Text = "Yem Ver";
            this.btn_Inek_Yem.UseVisualStyleBackColor = true;
            this.btn_Inek_Yem.Click += new System.EventHandler(this.btn_Inek_Yem_Click);
            // 
            // lbl_Keci_Sut
            // 
            this.lbl_Keci_Sut.AutoSize = true;
            this.lbl_Keci_Sut.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_Keci_Sut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Keci_Sut.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Keci_Sut.Location = new System.Drawing.Point(200, 155);
            this.lbl_Keci_Sut.Name = "lbl_Keci_Sut";
            this.lbl_Keci_Sut.Size = new System.Drawing.Size(191, 64);
            this.lbl_Keci_Sut.TabIndex = 8;
            this.lbl_Keci_Sut.Text = "0 Kilo";
            this.lbl_Keci_Sut.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Ord_Yum
            // 
            this.lbl_Ord_Yum.AutoSize = true;
            this.lbl_Ord_Yum.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_Ord_Yum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Ord_Yum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Ord_Yum.Location = new System.Drawing.Point(3, 155);
            this.lbl_Ord_Yum.Name = "lbl_Ord_Yum";
            this.lbl_Ord_Yum.Size = new System.Drawing.Size(191, 64);
            this.lbl_Ord_Yum.TabIndex = 7;
            this.lbl_Ord_Yum.Text = "0 Tane";
            this.lbl_Ord_Yum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Inek_Süt
            // 
            this.lbl_Inek_Süt.AutoSize = true;
            this.lbl_Inek_Süt.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_Inek_Süt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Inek_Süt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Inek_Süt.Location = new System.Drawing.Point(200, 61);
            this.lbl_Inek_Süt.Name = "lbl_Inek_Süt";
            this.lbl_Inek_Süt.Size = new System.Drawing.Size(191, 70);
            this.lbl_Inek_Süt.TabIndex = 6;
            this.lbl_Inek_Süt.Text = "0 Kilo";
            this.lbl_Inek_Süt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel2.SetColumnSpan(this.label1, 2);
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün Deposu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.PeachPuff;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(3, 34);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(191, 27);
            this.label4.TabIndex = 1;
            this.label4.Text = "Tavuk Yumurtası";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.PeachPuff;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(200, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 27);
            this.label5.TabIndex = 2;
            this.label5.Text = "İnek Sütü";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.PeachPuff;
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(191, 24);
            this.label6.TabIndex = 3;
            this.label6.Text = "Ördek Yumurtası";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.PeachPuff;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(200, 131);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 24);
            this.label7.TabIndex = 4;
            this.label7.Text = "Keçi Sütü";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_ÖlüKeçi
            // 
            this.lbl_ÖlüKeçi.AutoSize = true;
            this.lbl_ÖlüKeçi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ÖlüKeçi.Location = new System.Drawing.Point(113, 131);
            this.lbl_ÖlüKeçi.Name = "lbl_ÖlüKeçi";
            this.lbl_ÖlüKeçi.Size = new System.Drawing.Size(278, 31);
            this.lbl_ÖlüKeçi.TabIndex = 7;
            this.lbl_ÖlüKeçi.Text = "Canlı";
            this.lbl_ÖlüKeçi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Progress_İnekCan
            // 
            this.Progress_İnekCan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Progress_İnekCan.ForeColor = System.Drawing.Color.LimeGreen;
            this.Progress_İnekCan.Location = new System.Drawing.Point(113, 71);
            this.Progress_İnekCan.Name = "Progress_İnekCan";
            this.Progress_İnekCan.Size = new System.Drawing.Size(278, 28);
            this.Progress_İnekCan.TabIndex = 10;
            this.Progress_İnekCan.Value = 100;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.72081F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 189F));
            this.tableLayoutPanel3.Controls.Add(this.btn_KeçiSüt_Sat, 0, 4);
            this.tableLayoutPanel3.Controls.Add(this.btn_InekSüt_Sat, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.btn_OrdekYum_Sat, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.label16, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label18, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.label17, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.btn_TavukYum_Sat, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Kasa, 1, 4);
            this.tableLayoutPanel3.Controls.Add(this.lbl_Süre, 1, 2);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(403, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 52.22222F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(394, 219);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btn_KeçiSüt_Sat
            // 
            this.btn_KeçiSüt_Sat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_KeçiSüt_Sat.Location = new System.Drawing.Point(3, 183);
            this.btn_KeçiSüt_Sat.Name = "btn_KeçiSüt_Sat";
            this.btn_KeçiSüt_Sat.Size = new System.Drawing.Size(199, 33);
            this.btn_KeçiSüt_Sat.TabIndex = 9;
            this.btn_KeçiSüt_Sat.Text = "Keçi Sütü Sat";
            this.btn_KeçiSüt_Sat.UseVisualStyleBackColor = true;
            this.btn_KeçiSüt_Sat.Click += new System.EventHandler(this.btn_KeçiSüt_Sat_Click);
            // 
            // btn_InekSüt_Sat
            // 
            this.btn_InekSüt_Sat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_InekSüt_Sat.Location = new System.Drawing.Point(3, 137);
            this.btn_InekSüt_Sat.Name = "btn_InekSüt_Sat";
            this.btn_InekSüt_Sat.Size = new System.Drawing.Size(199, 40);
            this.btn_InekSüt_Sat.TabIndex = 8;
            this.btn_InekSüt_Sat.Text = "İnek Sütü Sat";
            this.btn_InekSüt_Sat.UseVisualStyleBackColor = true;
            this.btn_InekSüt_Sat.Click += new System.EventHandler(this.btn_InekSüt_Sat_Click);
            // 
            // btn_OrdekYum_Sat
            // 
            this.btn_OrdekYum_Sat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_OrdekYum_Sat.Location = new System.Drawing.Point(3, 93);
            this.btn_OrdekYum_Sat.Name = "btn_OrdekYum_Sat";
            this.btn_OrdekYum_Sat.Size = new System.Drawing.Size(199, 38);
            this.btn_OrdekYum_Sat.TabIndex = 7;
            this.btn_OrdekYum_Sat.Text = "Ördek Yumurtası Sat";
            this.btn_OrdekYum_Sat.UseVisualStyleBackColor = true;
            this.btn_OrdekYum_Sat.Click += new System.EventHandler(this.btn_OrdekYum_Sat_Click);
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel3.SetColumnSpan(this.label16, 2);
            this.label16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label16.Location = new System.Drawing.Point(3, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(388, 47);
            this.label16.TabIndex = 0;
            this.label16.Text = "Gıda Fabrikası";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.NavajoWhite;
            this.label18.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label18.Location = new System.Drawing.Point(208, 134);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(183, 46);
            this.label18.TabIndex = 2;
            this.label18.Text = "Kasa";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.NavajoWhite;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label17.Location = new System.Drawing.Point(208, 47);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(183, 43);
            this.label17.TabIndex = 3;
            this.label17.Text = "Geçen Süre";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_TavukYum_Sat
            // 
            this.btn_TavukYum_Sat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_TavukYum_Sat.Location = new System.Drawing.Point(3, 50);
            this.btn_TavukYum_Sat.Name = "btn_TavukYum_Sat";
            this.btn_TavukYum_Sat.Size = new System.Drawing.Size(199, 37);
            this.btn_TavukYum_Sat.TabIndex = 6;
            this.btn_TavukYum_Sat.Text = "Tavuk Yumurtası Sat";
            this.btn_TavukYum_Sat.UseVisualStyleBackColor = true;
            this.btn_TavukYum_Sat.Click += new System.EventHandler(this.btn_TavukYum_Sat_Click);
            // 
            // lbl_Kasa
            // 
            this.lbl_Kasa.AutoSize = true;
            this.lbl_Kasa.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_Kasa.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Kasa.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Kasa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Kasa.Location = new System.Drawing.Point(208, 180);
            this.lbl_Kasa.Name = "lbl_Kasa";
            this.lbl_Kasa.Size = new System.Drawing.Size(183, 39);
            this.lbl_Kasa.TabIndex = 10;
            this.lbl_Kasa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Süre
            // 
            this.lbl_Süre.AutoSize = true;
            this.lbl_Süre.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_Süre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Süre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Süre.Location = new System.Drawing.Point(208, 90);
            this.lbl_Süre.Name = "lbl_Süre";
            this.lbl_Süre.Size = new System.Drawing.Size(183, 44);
            this.lbl_Süre.TabIndex = 11;
            this.lbl_Süre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Progress_KeçiCan
            // 
            this.Progress_KeçiCan.BackColor = System.Drawing.SystemColors.Control;
            this.Progress_KeçiCan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Progress_KeçiCan.ForeColor = System.Drawing.Color.LimeGreen;
            this.Progress_KeçiCan.Location = new System.Drawing.Point(113, 165);
            this.Progress_KeçiCan.Name = "Progress_KeçiCan";
            this.Progress_KeçiCan.Size = new System.Drawing.Size(278, 23);
            this.Progress_KeçiCan.TabIndex = 11;
            this.Progress_KeçiCan.Value = 100;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lbl_Tav_Yum
            // 
            this.lbl_Tav_Yum.AutoSize = true;
            this.lbl_Tav_Yum.BackColor = System.Drawing.Color.LightBlue;
            this.lbl_Tav_Yum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_Tav_Yum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Tav_Yum.Location = new System.Drawing.Point(3, 61);
            this.lbl_Tav_Yum.Name = "lbl_Tav_Yum";
            this.lbl_Tav_Yum.Size = new System.Drawing.Size(191, 70);
            this.lbl_Tav_Yum.TabIndex = 5;
            this.lbl_Tav_Yum.Text = "0 Tane";
            this.lbl_Tav_Yum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel5, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 1, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.picBoxTavuk, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.picBoxOrdek, 0, 4);
            this.tableLayoutPanel5.Controls.Add(this.lbl_ÖlüTavuk, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.Progress_TavukCan, 1, 2);
            this.tableLayoutPanel5.Controls.Add(this.btn_Tavuk_Yem, 1, 3);
            this.tableLayoutPanel5.Controls.Add(this.lbl_ÖlüÖrdek, 1, 4);
            this.tableLayoutPanel5.Controls.Add(this.Progress_ÖrdekCan, 1, 5);
            this.tableLayoutPanel5.Controls.Add(this.Btn_Ordek_Yem, 1, 6);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 228);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 6;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.16438F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.83562F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(394, 219);
            this.tableLayoutPanel5.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel5.SetColumnSpan(this.label3, 2);
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(388, 41);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kümes";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxTavuk
            // 
            this.picBoxTavuk.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxTavuk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxTavuk.Image = global::Melikenin_Çiftligi.Properties.Resources.tavuk;
            this.picBoxTavuk.InitialImage = null;
            this.picBoxTavuk.Location = new System.Drawing.Point(3, 44);
            this.picBoxTavuk.Name = "picBoxTavuk";
            this.tableLayoutPanel5.SetRowSpan(this.picBoxTavuk, 3);
            this.picBoxTavuk.Size = new System.Drawing.Size(104, 88);
            this.picBoxTavuk.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxTavuk.TabIndex = 3;
            this.picBoxTavuk.TabStop = false;
            // 
            // picBoxOrdek
            // 
            this.picBoxOrdek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxOrdek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxOrdek.Image = global::Melikenin_Çiftligi.Properties.Resources.ordek;
            this.picBoxOrdek.InitialImage = null;
            this.picBoxOrdek.Location = new System.Drawing.Point(3, 138);
            this.picBoxOrdek.Name = "picBoxOrdek";
            this.tableLayoutPanel5.SetRowSpan(this.picBoxOrdek, 3);
            this.picBoxOrdek.Size = new System.Drawing.Size(104, 78);
            this.picBoxOrdek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxOrdek.TabIndex = 4;
            this.picBoxOrdek.TabStop = false;
            // 
            // lbl_ÖlüTavuk
            // 
            this.lbl_ÖlüTavuk.AutoSize = true;
            this.lbl_ÖlüTavuk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ÖlüTavuk.Location = new System.Drawing.Point(113, 41);
            this.lbl_ÖlüTavuk.Name = "lbl_ÖlüTavuk";
            this.lbl_ÖlüTavuk.Size = new System.Drawing.Size(278, 32);
            this.lbl_ÖlüTavuk.TabIndex = 5;
            this.lbl_ÖlüTavuk.Text = "Canlı";
            this.lbl_ÖlüTavuk.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Progress_TavukCan
            // 
            this.Progress_TavukCan.BackColor = System.Drawing.Color.LimeGreen;
            this.Progress_TavukCan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Progress_TavukCan.ForeColor = System.Drawing.Color.Ivory;
            this.Progress_TavukCan.Location = new System.Drawing.Point(113, 76);
            this.Progress_TavukCan.Name = "Progress_TavukCan";
            this.Progress_TavukCan.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Progress_TavukCan.Size = new System.Drawing.Size(278, 25);
            this.Progress_TavukCan.Step = 24;
            this.Progress_TavukCan.TabIndex = 6;
            this.Progress_TavukCan.Value = 100;
            // 
            // btn_Tavuk_Yem
            // 
            this.btn_Tavuk_Yem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Tavuk_Yem.Location = new System.Drawing.Point(113, 107);
            this.btn_Tavuk_Yem.Name = "btn_Tavuk_Yem";
            this.btn_Tavuk_Yem.Size = new System.Drawing.Size(278, 25);
            this.btn_Tavuk_Yem.TabIndex = 7;
            this.btn_Tavuk_Yem.Text = "Yem Ver";
            this.btn_Tavuk_Yem.UseVisualStyleBackColor = true;
            this.btn_Tavuk_Yem.Click += new System.EventHandler(this.btn_Tavuk_Yem_Click);
            // 
            // lbl_ÖlüÖrdek
            // 
            this.lbl_ÖlüÖrdek.AutoSize = true;
            this.lbl_ÖlüÖrdek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_ÖlüÖrdek.Location = new System.Drawing.Point(113, 135);
            this.lbl_ÖlüÖrdek.Name = "lbl_ÖlüÖrdek";
            this.lbl_ÖlüÖrdek.Size = new System.Drawing.Size(278, 25);
            this.lbl_ÖlüÖrdek.TabIndex = 8;
            this.lbl_ÖlüÖrdek.Text = "Canlı";
            this.lbl_ÖlüÖrdek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Progress_ÖrdekCan
            // 
            this.Progress_ÖrdekCan.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Progress_ÖrdekCan.ForeColor = System.Drawing.Color.LimeGreen;
            this.Progress_ÖrdekCan.Location = new System.Drawing.Point(113, 163);
            this.Progress_ÖrdekCan.Name = "Progress_ÖrdekCan";
            this.Progress_ÖrdekCan.Size = new System.Drawing.Size(278, 24);
            this.Progress_ÖrdekCan.TabIndex = 9;
            this.Progress_ÖrdekCan.Value = 100;
            // 
            // Btn_Ordek_Yem
            // 
            this.Btn_Ordek_Yem.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Btn_Ordek_Yem.Location = new System.Drawing.Point(113, 193);
            this.Btn_Ordek_Yem.Name = "Btn_Ordek_Yem";
            this.Btn_Ordek_Yem.Size = new System.Drawing.Size(278, 23);
            this.Btn_Ordek_Yem.TabIndex = 10;
            this.Btn_Ordek_Yem.Text = "Yem Ver";
            this.Btn_Ordek_Yem.UseVisualStyleBackColor = true;
            this.Btn_Ordek_Yem.Click += new System.EventHandler(this.Btn_Ordek_Yem_Click);
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.lbl_Keci_Sut, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Ord_Yum, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Inek_Süt, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.label5, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.lbl_Tav_Yum, 0, 2);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 55.73771F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 44.26229F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 63F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(394, 219);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 284F));
            this.tableLayoutPanel4.Controls.Add(this.lbl_Ölüİnek, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.picBoxInek, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.picBoxKeci, 0, 4);
            this.tableLayoutPanel4.Controls.Add(this.lbl_ÖlüKeçi, 1, 4);
            this.tableLayoutPanel4.Controls.Add(this.btn_Keçi_Yem, 1, 6);
            this.tableLayoutPanel4.Controls.Add(this.btn_Inek_Yem, 1, 3);
            this.tableLayoutPanel4.Controls.Add(this.Progress_İnekCan, 1, 2);
            this.tableLayoutPanel4.Controls.Add(this.Progress_KeçiCan, 1, 5);
            this.tableLayoutPanel4.Location = new System.Drawing.Point(403, 228);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 6;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 54.79452F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.20548F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 31F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(394, 219);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // lbl_Ölüİnek
            // 
            this.lbl_Ölüİnek.AutoSize = true;
            this.lbl_Ölüİnek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_Ölüİnek.Location = new System.Drawing.Point(113, 37);
            this.lbl_Ölüİnek.Name = "lbl_Ölüİnek";
            this.lbl_Ölüİnek.Size = new System.Drawing.Size(278, 31);
            this.lbl_Ölüİnek.TabIndex = 6;
            this.lbl_Ölüİnek.Text = "Canlı";
            this.lbl_Ölüİnek.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tableLayoutPanel4.SetColumnSpan(this.label2, 2);
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(388, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ahır";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picBoxInek
            // 
            this.picBoxInek.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxInek.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxInek.Image = global::Melikenin_Çiftligi.Properties.Resources.inek;
            this.picBoxInek.InitialImage = null;
            this.picBoxInek.Location = new System.Drawing.Point(3, 40);
            this.picBoxInek.Name = "picBoxInek";
            this.tableLayoutPanel4.SetRowSpan(this.picBoxInek, 3);
            this.picBoxInek.Size = new System.Drawing.Size(104, 88);
            this.picBoxInek.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxInek.TabIndex = 3;
            this.picBoxInek.TabStop = false;
            // 
            // picBoxKeci
            // 
            this.picBoxKeci.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBoxKeci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBoxKeci.Image = global::Melikenin_Çiftligi.Properties.Resources.keci;
            this.picBoxKeci.InitialImage = null;
            this.picBoxKeci.Location = new System.Drawing.Point(3, 134);
            this.picBoxKeci.Name = "picBoxKeci";
            this.tableLayoutPanel4.SetRowSpan(this.picBoxKeci, 3);
            this.picBoxKeci.Size = new System.Drawing.Size(104, 82);
            this.picBoxKeci.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBoxKeci.TabIndex = 4;
            this.picBoxKeci.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxTavuk)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxOrdek)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxInek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxKeci)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBoxKeci;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Label lbl_Ölüİnek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picBoxInek;
        private System.Windows.Forms.Label lbl_ÖlüKeçi;
        private System.Windows.Forms.Button btn_Keçi_Yem;
        private System.Windows.Forms.Button btn_Inek_Yem;
        private System.Windows.Forms.ProgressBar Progress_İnekCan;
        private System.Windows.Forms.ProgressBar Progress_KeçiCan;
        private System.Windows.Forms.Label lbl_Keci_Sut;
        private System.Windows.Forms.Label lbl_Ord_Yum;
        private System.Windows.Forms.Label lbl_Inek_Süt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbl_Tav_Yum;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btn_KeçiSüt_Sat;
        private System.Windows.Forms.Button btn_InekSüt_Sat;
        private System.Windows.Forms.Button btn_OrdekYum_Sat;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btn_TavukYum_Sat;
        private System.Windows.Forms.Label lbl_Kasa;
        private System.Windows.Forms.Label lbl_Süre;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox picBoxTavuk;
        private System.Windows.Forms.PictureBox picBoxOrdek;
        private System.Windows.Forms.Label lbl_ÖlüTavuk;
        private System.Windows.Forms.ProgressBar Progress_TavukCan;
        private System.Windows.Forms.Button btn_Tavuk_Yem;
        private System.Windows.Forms.Label lbl_ÖlüÖrdek;
        private System.Windows.Forms.ProgressBar Progress_ÖrdekCan;
        private System.Windows.Forms.Button Btn_Ordek_Yem;
    }
}

