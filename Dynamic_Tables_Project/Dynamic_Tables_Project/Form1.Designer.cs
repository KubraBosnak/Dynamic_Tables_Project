
namespace Dynamic_Tables_Project
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbDynamicTablesDataSet = new Dynamic_Tables_Project.DbDynamicTablesDataSet();
            this.dYNAMICTABLEPROJECTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dYNAMICTABLEPROJECTTableAdapter = new Dynamic_Tables_Project.DbDynamicTablesDataSetTableAdapters.DYNAMICTABLEPROJECTTableAdapter();
            this.cmbSatici = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUrunAdi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.btnSat = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDynamicTablesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dYNAMICTABLEPROJECTBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(518, 411);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 18);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(512, 390);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbDynamicTablesDataSet
            // 
            this.dbDynamicTablesDataSet.DataSetName = "DbDynamicTablesDataSet";
            this.dbDynamicTablesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dYNAMICTABLEPROJECTBindingSource
            // 
            this.dYNAMICTABLEPROJECTBindingSource.DataMember = "DYNAMICTABLEPROJECT";
            this.dYNAMICTABLEPROJECTBindingSource.DataSource = this.dbDynamicTablesDataSet;
            // 
            // dYNAMICTABLEPROJECTTableAdapter
            // 
            this.dYNAMICTABLEPROJECTTableAdapter.ClearBeforeFill = true;
            // 
            // cmbSatici
            // 
            this.cmbSatici.FormattingEnabled = true;
            this.cmbSatici.Location = new System.Drawing.Point(634, 198);
            this.cmbSatici.Name = "cmbSatici";
            this.cmbSatici.Size = new System.Drawing.Size(154, 24);
            this.cmbSatici.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(577, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Satıcı";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ürün Adı :";
            // 
            // cmbUrunAdi
            // 
            this.cmbUrunAdi.FormattingEnabled = true;
            this.cmbUrunAdi.Location = new System.Drawing.Point(634, 41);
            this.cmbUrunAdi.Name = "cmbUrunAdi";
            this.cmbUrunAdi.Size = new System.Drawing.Size(154, 24);
            this.cmbUrunAdi.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(582, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Adet :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(634, 84);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(154, 22);
            this.textBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(583, 127);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Stok :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(631, 127);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(44, 17);
            this.lblStok.TabIndex = 8;
            this.lblStok.Text = "00,00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(631, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "00,00";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(581, 153);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(46, 17);
            this.lblFiyat.TabIndex = 9;
            this.lblFiyat.Text = "Fiyat :";
            // 
            // btnSat
            // 
            this.btnSat.Location = new System.Drawing.Point(634, 240);
            this.btnSat.Name = "btnSat";
            this.btnSat.Size = new System.Drawing.Size(154, 26);
            this.btnSat.TabIndex = 11;
            this.btnSat.Text = "Satış";
            this.btnSat.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbUrunAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSatici);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbDynamicTablesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dYNAMICTABLEPROJECTBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DbDynamicTablesDataSet dbDynamicTablesDataSet;
        private System.Windows.Forms.BindingSource dYNAMICTABLEPROJECTBindingSource;
        private DbDynamicTablesDataSetTableAdapters.DYNAMICTABLEPROJECTTableAdapter dYNAMICTABLEPROJECTTableAdapter;
        private System.Windows.Forms.ComboBox cmbSatici;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUrunAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Button btnSat;
    }
}

