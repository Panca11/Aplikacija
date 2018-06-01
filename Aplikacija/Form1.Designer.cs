namespace Aplikacija
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnRegistracija = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifobjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojkaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipadresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivnostDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabKaseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.eDUDataSet4 = new Aplikacija.EDUDataSet4();
            this.tab_KaseTableAdapter2 = new Aplikacija.EDUDataSet4TableAdapters.tab_KaseTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifobjDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipadresaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivnostDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tipBODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabObjektiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.eDUDataSet5 = new Aplikacija.EDUDataSet5();
            this.tab_ObjektiTableAdapter2 = new Aplikacija.EDUDataSet5TableAdapters.tab_ObjektiTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.tabLogoviBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eDUDataSet2 = new Aplikacija.EDUDataSet2();
            this.tab_LogoviTableAdapter = new Aplikacija.EDUDataSet2TableAdapters.tab_LogoviTableAdapter();
            this.btnNoviObjekat = new System.Windows.Forms.Button();
            this.tabObjektiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabObjektiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eDUDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabKaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabKaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnSveKase = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabKaseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDUDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabObjektiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDUDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabLogoviBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDUDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabObjektiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabObjektiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDUDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabKaseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabKaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.BackColor = System.Drawing.Color.LightGray;
            this.btnRegistracija.Font = new System.Drawing.Font("Agency FB", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistracija.Location = new System.Drawing.Point(26, 447);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(99, 36);
            this.btnRegistracija.TabIndex = 0;
            this.btnRegistracija.Text = "Registracija";
            this.btnRegistracija.UseVisualStyleBackColor = false;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Agency FB", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(486, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 59);
            this.label1.TabIndex = 7;
            this.label1.Text = "Administrator";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1161, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(41, 41);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sifobjDataGridViewTextBoxColumn,
            this.brojkaseDataGridViewTextBoxColumn,
            this.ipadresaDataGridViewTextBoxColumn,
            this.aktivnostDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tabKaseBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(26, 113);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(530, 225);
            this.dataGridView1.TabIndex = 13;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sifobjDataGridViewTextBoxColumn
            // 
            this.sifobjDataGridViewTextBoxColumn.DataPropertyName = "sif_obj";
            this.sifobjDataGridViewTextBoxColumn.HeaderText = "sif_obj";
            this.sifobjDataGridViewTextBoxColumn.Name = "sifobjDataGridViewTextBoxColumn";
            // 
            // brojkaseDataGridViewTextBoxColumn
            // 
            this.brojkaseDataGridViewTextBoxColumn.DataPropertyName = "brojkase";
            this.brojkaseDataGridViewTextBoxColumn.HeaderText = "brojkase";
            this.brojkaseDataGridViewTextBoxColumn.Name = "brojkaseDataGridViewTextBoxColumn";
            // 
            // ipadresaDataGridViewTextBoxColumn
            // 
            this.ipadresaDataGridViewTextBoxColumn.DataPropertyName = "ip_adresa";
            this.ipadresaDataGridViewTextBoxColumn.HeaderText = "ip_adresa";
            this.ipadresaDataGridViewTextBoxColumn.Name = "ipadresaDataGridViewTextBoxColumn";
            // 
            // aktivnostDataGridViewCheckBoxColumn
            // 
            this.aktivnostDataGridViewCheckBoxColumn.DataPropertyName = "Aktivnost";
            this.aktivnostDataGridViewCheckBoxColumn.HeaderText = "Aktivnost";
            this.aktivnostDataGridViewCheckBoxColumn.Name = "aktivnostDataGridViewCheckBoxColumn";
            // 
            // tabKaseBindingSource2
            // 
            this.tabKaseBindingSource2.DataMember = "tab_Kase";
            this.tabKaseBindingSource2.DataSource = this.eDUDataSet4;
            // 
            // eDUDataSet4
            // 
            this.eDUDataSet4.DataSetName = "EDUDataSet4";
            this.eDUDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tab_KaseTableAdapter2
            // 
            this.tab_KaseTableAdapter2.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.sifobjDataGridViewTextBoxColumn1,
            this.ipadresaDataGridViewTextBoxColumn1,
            this.aktivnostDataGridViewCheckBoxColumn1,
            this.tipBODataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.tabObjektiBindingSource2;
            this.dataGridView2.Location = new System.Drawing.Point(662, 113);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(540, 225);
            this.dataGridView2.TabIndex = 14;
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // sifobjDataGridViewTextBoxColumn1
            // 
            this.sifobjDataGridViewTextBoxColumn1.DataPropertyName = "sif_obj";
            this.sifobjDataGridViewTextBoxColumn1.HeaderText = "sif_obj";
            this.sifobjDataGridViewTextBoxColumn1.Name = "sifobjDataGridViewTextBoxColumn1";
            // 
            // ipadresaDataGridViewTextBoxColumn1
            // 
            this.ipadresaDataGridViewTextBoxColumn1.DataPropertyName = "ip_adresa";
            this.ipadresaDataGridViewTextBoxColumn1.HeaderText = "ip_adresa";
            this.ipadresaDataGridViewTextBoxColumn1.Name = "ipadresaDataGridViewTextBoxColumn1";
            // 
            // aktivnostDataGridViewCheckBoxColumn1
            // 
            this.aktivnostDataGridViewCheckBoxColumn1.DataPropertyName = "Aktivnost";
            this.aktivnostDataGridViewCheckBoxColumn1.HeaderText = "Aktivnost";
            this.aktivnostDataGridViewCheckBoxColumn1.Name = "aktivnostDataGridViewCheckBoxColumn1";
            // 
            // tipBODataGridViewTextBoxColumn
            // 
            this.tipBODataGridViewTextBoxColumn.DataPropertyName = "TipBO";
            this.tipBODataGridViewTextBoxColumn.HeaderText = "TipBO";
            this.tipBODataGridViewTextBoxColumn.Name = "tipBODataGridViewTextBoxColumn";
            // 
            // tabObjektiBindingSource2
            // 
            this.tabObjektiBindingSource2.DataMember = "tab_Objekti";
            this.tabObjektiBindingSource2.DataSource = this.eDUDataSet5;
            // 
            // eDUDataSet5
            // 
            this.eDUDataSet5.DataSetName = "EDUDataSet5";
            this.eDUDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tab_ObjektiTableAdapter2
            // 
            this.tab_ObjektiTableAdapter2.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Agency FB", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(151, 448);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(136, 35);
            this.button1.TabIndex = 15;
            this.button1.Text = "Pregled Korisnika";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabLogoviBindingSource
            // 
            this.tabLogoviBindingSource.DataMember = "tab_Logovi";
            this.tabLogoviBindingSource.DataSource = this.eDUDataSet2;
            // 
            // eDUDataSet2
            // 
            this.eDUDataSet2.DataSetName = "EDUDataSet2";
            this.eDUDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tab_LogoviTableAdapter
            // 
            this.tab_LogoviTableAdapter.ClearBeforeFill = true;
            // 
            // btnNoviObjekat
            // 
            this.btnNoviObjekat.Font = new System.Drawing.Font("Agency FB", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoviObjekat.Location = new System.Drawing.Point(26, 379);
            this.btnNoviObjekat.Name = "btnNoviObjekat";
            this.btnNoviObjekat.Size = new System.Drawing.Size(99, 36);
            this.btnNoviObjekat.TabIndex = 17;
            this.btnNoviObjekat.Text = "Dodaj objekat";
            this.btnNoviObjekat.UseVisualStyleBackColor = true;
            this.btnNoviObjekat.Click += new System.EventHandler(this.btnNoviObjekat_Click);
            // 
            // tabObjektiBindingSource
            // 
            this.tabObjektiBindingSource.DataSource = this.eDUDataSetBindingSource;
            // 
            // tabKaseBindingSource
            // 
            this.tabKaseBindingSource.DataSource = this.eDUDataSetBindingSource;
            // 
            // btnSveKase
            // 
            this.btnSveKase.Font = new System.Drawing.Font("Agency FB", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSveKase.Location = new System.Drawing.Point(161, 380);
            this.btnSveKase.Name = "btnSveKase";
            this.btnSveKase.Size = new System.Drawing.Size(106, 35);
            this.btnSveKase.TabIndex = 18;
            this.btnSveKase.Text = "Sve kase";
            this.btnSveKase.UseVisualStyleBackColor = true;
            this.btnSveKase.Click += new System.EventHandler(this.btnSveKase_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 24);
            this.label2.TabIndex = 19;
            this.label2.Text = "Kase";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Agency FB", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(658, 80);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 24);
            this.label3.TabIndex = 20;
            this.label3.Text = "Objekti";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Agency FB", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(319, 376);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 24);
            this.label4.TabIndex = 21;
            this.label4.Text = "Logovi";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(375, 416);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(773, 227);
            this.dataGridView3.TabIndex = 22;
            this.dataGridView3.SelectionChanged += new System.EventHandler(this.dataGridView3_SelectionChanged);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Agency FB", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(452, 364);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(104, 35);
            this.button2.TabIndex = 23;
            this.button2.Text = "Azuriraj Kase";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Agency FB", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(662, 365);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(136, 35);
            this.button3.TabIndex = 24;
            this.button3.Text = "Azuriraj Objekte";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1214, 697);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSveKase);
            this.Controls.Add(this.btnNoviObjekat);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegistracija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabKaseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDUDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabObjektiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDUDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabLogoviBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDUDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabObjektiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabObjektiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDUDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabKaseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabKaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.BindingSource eDUDataSetBindingSource;
        private System.Windows.Forms.BindingSource tabObjektiBindingSource;        
        private System.Windows.Forms.BindingSource tabKaseBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource tabObjektiBindingSource1;
        private System.Windows.Forms.BindingSource tabKaseBindingSource1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EDUDataSet4 eDUDataSet4;
        private System.Windows.Forms.BindingSource tabKaseBindingSource2;
        private EDUDataSet4TableAdapters.tab_KaseTableAdapter tab_KaseTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifobjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojkaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipadresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktivnostDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private EDUDataSet5 eDUDataSet5;
        private System.Windows.Forms.BindingSource tabObjektiBindingSource2;
        private EDUDataSet5TableAdapters.tab_ObjektiTableAdapter tab_ObjektiTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifobjDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipadresaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktivnostDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipBODataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private EDUDataSet2 eDUDataSet2;
        private System.Windows.Forms.BindingSource tabLogoviBindingSource;
        private EDUDataSet2TableAdapters.tab_LogoviTableAdapter tab_LogoviTableAdapter;
        private System.Windows.Forms.Button btnNoviObjekat;
        private System.Windows.Forms.Button btnSveKase;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}