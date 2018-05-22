namespace Aplikacija
{
    partial class PKorisnika
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PKorisnika));
            this.label2 = new System.Windows.Forms.Label();
            this.tabLogovanjeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tab_LogovanjeTableAdapter = new Aplikacija.EDUDataSet3TableAdapters.tab_LogovanjeTableAdapter();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aktivnostDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adminDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tabLogovanjeBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.eDUDataSet6 = new Aplikacija.EDUDataSet6();
            this.tab_LogovanjeTableAdapter1 = new Aplikacija.EDUDataSet6TableAdapters.tab_LogovanjeTableAdapter();
            this.btnOdobri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabLogovanjeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabLogovanjeBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDUDataSet6)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Agency FB", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(279, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(305, 59);
            this.label2.TabIndex = 1;
            this.label2.Text = "Pregled korisnika";
            // 
            // tab_LogovanjeTableAdapter
            // 
            this.tab_LogovanjeTableAdapter.ClearBeforeFill = true;
            // 
            // Exit
            // 
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(808, 12);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(41, 41);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Exit.TabIndex = 6;
            this.Exit.TabStop = false;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.aktivnostDataGridViewCheckBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.adminDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.tabLogovanjeBindingSource1;
            this.dataGridView1.Location = new System.Drawing.Point(32, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(744, 265);
            this.dataGridView1.TabIndex = 7;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "Username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Username";
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // aktivnostDataGridViewCheckBoxColumn
            // 
            this.aktivnostDataGridViewCheckBoxColumn.DataPropertyName = "Aktivnost";
            this.aktivnostDataGridViewCheckBoxColumn.HeaderText = "Aktivnost";
            this.aktivnostDataGridViewCheckBoxColumn.Name = "aktivnostDataGridViewCheckBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "lastname";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "lastname";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // adminDataGridViewCheckBoxColumn
            // 
            this.adminDataGridViewCheckBoxColumn.DataPropertyName = "Admin";
            this.adminDataGridViewCheckBoxColumn.HeaderText = "Admin";
            this.adminDataGridViewCheckBoxColumn.Name = "adminDataGridViewCheckBoxColumn";
            // 
            // tabLogovanjeBindingSource1
            // 
            this.tabLogovanjeBindingSource1.DataMember = "tab_Logovanje";
            this.tabLogovanjeBindingSource1.DataSource = this.eDUDataSet6;
            // 
            // eDUDataSet6
            // 
            this.eDUDataSet6.DataSetName = "EDUDataSet6";
            this.eDUDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tab_LogovanjeTableAdapter1
            // 
            this.tab_LogovanjeTableAdapter1.ClearBeforeFill = true;
            // 
            // btnOdobri
            // 
            this.btnOdobri.Font = new System.Drawing.Font("Agency FB", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdobri.Location = new System.Drawing.Point(363, 404);
            this.btnOdobri.Name = "btnOdobri";
            this.btnOdobri.Size = new System.Drawing.Size(128, 38);
            this.btnOdobri.TabIndex = 8;
            this.btnOdobri.Text = "Sacuvaj promene";
            this.btnOdobri.UseVisualStyleBackColor = true;
            this.btnOdobri.Click += new System.EventHandler(this.btnOdobri_Click);
            // 
            // PKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Crimson;
            this.ClientSize = new System.Drawing.Size(855, 513);
            this.ControlBox = false;
            this.Controls.Add(this.btnOdobri);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PKorisnika";
            this.ShowIcon = false;
            this.Text = "PKorisnika";
            this.Load += new System.EventHandler(this.PKorisnika_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabLogovanjeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabLogovanjeBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eDUDataSet6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource tabLogovanjeBindingSource;
        private EDUDataSet3TableAdapters.tab_LogovanjeTableAdapter tab_LogovanjeTableAdapter;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private EDUDataSet6 eDUDataSet6;
        private System.Windows.Forms.BindingSource tabLogovanjeBindingSource1;
        private EDUDataSet6TableAdapters.tab_LogovanjeTableAdapter tab_LogovanjeTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn aktivnostDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn adminDataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btnOdobri;
    }
}