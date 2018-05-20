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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnBrisi = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.eDUDataSet = new Aplikacija.EDUDataSet();
            this.eDUDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabObjektiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab_ObjektiTableAdapter = new Aplikacija.EDUDataSetTableAdapters.tab_ObjektiTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifobjDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipadresaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivnostDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tipBODataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabKaseBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab_KaseTableAdapter = new Aplikacija.EDUDataSetTableAdapters.tab_KaseTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sifobjDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.brojkaseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ipadresaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivnostDataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDUDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDUDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabObjektiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabKaseBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.sifobjDataGridViewTextBoxColumn,
            this.ipadresaDataGridViewTextBoxColumn,
            this.aktivnostDataGridViewCheckBoxColumn,
            this.tipBODataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tabObjektiBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 77);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(544, 218);
            this.dataGridView1.TabIndex = 1;
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.sifobjDataGridViewTextBoxColumn1,
            this.brojkaseDataGridViewTextBoxColumn,
            this.ipadresaDataGridViewTextBoxColumn1,
            this.aktivnostDataGridViewCheckBoxColumn1});
            this.dataGridView2.DataSource = this.tabKaseBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(659, 87);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(543, 208);
            this.dataGridView2.TabIndex = 3;
            // 
            // pictureBox1
            // 
         /*   this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(1161, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(41, 41);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;*/
         //   this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // eDUDataSet
            // 
            this.eDUDataSet.DataSetName = "EDUDataSet";
            this.eDUDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eDUDataSetBindingSource
            // 
            this.eDUDataSetBindingSource.DataSource = this.eDUDataSet;
            this.eDUDataSetBindingSource.Position = 0;
            // 
            // tabObjektiBindingSource
            // 
            this.tabObjektiBindingSource.DataMember = "tab_Objekti";
            this.tabObjektiBindingSource.DataSource = this.eDUDataSetBindingSource;
            // 
            // tab_ObjektiTableAdapter
            // 
            this.tab_ObjektiTableAdapter.ClearBeforeFill = true;
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
            // tipBODataGridViewTextBoxColumn
            // 
            this.tipBODataGridViewTextBoxColumn.DataPropertyName = "TipBO";
            this.tipBODataGridViewTextBoxColumn.HeaderText = "TipBO";
            this.tipBODataGridViewTextBoxColumn.Name = "tipBODataGridViewTextBoxColumn";
            // 
            // tabKaseBindingSource
            // 
            this.tabKaseBindingSource.DataMember = "tab_Kase";
            this.tabKaseBindingSource.DataSource = this.eDUDataSetBindingSource;
            // 
            // tab_KaseTableAdapter
            // 
            this.tab_KaseTableAdapter.ClearBeforeFill = true;
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
            // brojkaseDataGridViewTextBoxColumn
            // 
            this.brojkaseDataGridViewTextBoxColumn.DataPropertyName = "brojkase";
            this.brojkaseDataGridViewTextBoxColumn.HeaderText = "brojkase";
            this.brojkaseDataGridViewTextBoxColumn.Name = "brojkaseDataGridViewTextBoxColumn";
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
            this.label1.Location = new System.Drawing.Point(488, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 59);
            this.label1.TabIndex = 7;
            this.label1.Text = "Administrator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(1214, 607);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView4);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnBrisi);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnRegistracija);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDUDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDUDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabObjektiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabKaseBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRegistracija;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnBrisi;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource eDUDataSetBindingSource;
        private EDUDataSet eDUDataSet;
        private System.Windows.Forms.BindingSource tabObjektiBindingSource;
        private EDUDataSetTableAdapters.tab_ObjektiTableAdapter tab_ObjektiTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifobjDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipadresaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktivnostDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipBODataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource tabKaseBindingSource;
        private EDUDataSetTableAdapters.tab_KaseTableAdapter tab_KaseTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn sifobjDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn brojkaseDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ipadresaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktivnostDataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Label label1;
    }
}