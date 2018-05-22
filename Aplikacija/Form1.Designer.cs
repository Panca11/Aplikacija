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
            this.tabObjektiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabObjektiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eDUDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBrisi = new System.Windows.Forms.Button();
            this.tabKaseBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabKaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tab_ObjektiTableAdapter = new Aplikacija.EDUDataSetTableAdapters.tab_ObjektiTableAdapter();
            this.tab_KaseTableAdapter = new Aplikacija.EDUDataSetTableAdapters.tab_KaseTableAdapter();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tab_ObjektiTableAdapter1 = new Aplikacija.EDUDataSet1TableAdapters.tab_ObjektiTableAdapter();
            this.tab_KaseTableAdapter1 = new Aplikacija.EDUDataSet2TableAdapters.tab_KaseTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.eDUDataSet4 = new Aplikacija.EDUDataSet4();
            this.tabKaseBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tab_KaseTableAdapter2 = new Aplikacija.EDUDataSet4TableAdapters.tab_KaseTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifobjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojkaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipadresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivnostDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.eDUDataSet5 = new Aplikacija.EDUDataSet5();
            this.tabObjektiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.tab_ObjektiTableAdapter2 = new Aplikacija.EDUDataSet5TableAdapters.tab_ObjektiTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifobjDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipadresaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivnostDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tipBODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tabObjektiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabObjektiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDUDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabKaseBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabKaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDUDataSet4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabKaseBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDUDataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabObjektiBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistracija
            // 
            this.btnRegistracija.BackColor = System.Drawing.Color.LightGray;
            this.btnRegistracija.Font = new System.Drawing.Font("Agency FB", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistracija.Location = new System.Drawing.Point(13, 559);
            this.btnRegistracija.Name = "btnRegistracija";
            this.btnRegistracija.Size = new System.Drawing.Size(99, 36);
            this.btnRegistracija.TabIndex = 0;
            this.btnRegistracija.Text = "Registracija";
            this.btnRegistracija.UseVisualStyleBackColor = false;
            this.btnRegistracija.Click += new System.EventHandler(this.btnRegistracija_Click);
            // 
            // tabObjektiBindingSource
            // 
            this.tabObjektiBindingSource.DataSource = this.eDUDataSetBindingSource;
            // 
            // btnBrisi
            // 
            this.btnBrisi.BackColor = System.Drawing.Color.LightGray;
            this.btnBrisi.Font = new System.Drawing.Font("Agency FB", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrisi.Location = new System.Drawing.Point(133, 559);
            this.btnBrisi.Name = "btnBrisi";
            this.btnBrisi.Size = new System.Drawing.Size(99, 36);
            this.btnBrisi.TabIndex = 2;
            this.btnBrisi.Text = "Brisanje";
            this.btnBrisi.UseVisualStyleBackColor = false;
            // 
            // tabKaseBindingSource
            // 
            this.tabKaseBindingSource.DataSource = this.eDUDataSetBindingSource;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(1111, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tab_ObjektiTableAdapter
            // 
            this.tab_ObjektiTableAdapter.ClearBeforeFill = true;
            // 
            // tab_KaseTableAdapter
            // 
            this.tab_KaseTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(13, 311);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(543, 194);
            this.dataGridView3.TabIndex = 5;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(659, 311);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(543, 194);
            this.dataGridView4.TabIndex = 6;
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
            // tab_ObjektiTableAdapter1
            // 
            this.tab_ObjektiTableAdapter1.ClearBeforeFill = true;
            // 
            // tab_KaseTableAdapter1
            // 
            this.tab_KaseTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Agency FB", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(256, 559);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 36);
            this.button1.TabIndex = 12;
            this.button1.Text = "Pregled korisnika";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.dataGridView1.Location = new System.Drawing.Point(26, 80);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(530, 225);
            this.dataGridView1.TabIndex = 13;
            // 
            // eDUDataSet4
            // 
            this.eDUDataSet4.DataSetName = "EDUDataSet4";
            this.eDUDataSet4.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabKaseBindingSource2
            // 
            this.tabKaseBindingSource2.DataMember = "tab_Kase";
            this.tabKaseBindingSource2.DataSource = this.eDUDataSet4;
            // 
            // tab_KaseTableAdapter2
            // 
            this.tab_KaseTableAdapter2.ClearBeforeFill = true;
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
            this.dataGridView2.Location = new System.Drawing.Point(626, 80);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(550, 213);
            this.dataGridView2.TabIndex = 14;
            // 
            // eDUDataSet5
            // 
            this.eDUDataSet5.DataSetName = "EDUDataSet5";
            this.eDUDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabObjektiBindingSource2
            // 
            this.tabObjektiBindingSource2.DataMember = "tab_Objekti";
            this.tabObjektiBindingSource2.DataSource = this.eDUDataSet5;
            // 
            // tab_ObjektiTableAdapter2
            // 
            this.tab_ObjektiTableAdapter2.ClearBeforeFill = true;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1214, 607);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.btnRegistracija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabObjektiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabObjektiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDUDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabKaseBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabKaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDUDataSet4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabKaseBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDUDataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabObjektiBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource eDUDataSetBindingSource;
        private System.Windows.Forms.BindingSource tabObjektiBindingSource;
        private EDUDataSetTableAdapters.tab_ObjektiTableAdapter tab_ObjektiTableAdapter;
        private System.Windows.Forms.BindingSource tabKaseBindingSource;
        private EDUDataSetTableAdapters.tab_KaseTableAdapter tab_KaseTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.BindingSource tabObjektiBindingSource1;
        private EDUDataSet1TableAdapters.tab_ObjektiTableAdapter tab_ObjektiTableAdapter1;
        private System.Windows.Forms.BindingSource tabKaseBindingSource1;
        private EDUDataSet2TableAdapters.tab_KaseTableAdapter tab_KaseTableAdapter1;
        private System.Windows.Forms.Button button1;
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
    }
}