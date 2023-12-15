namespace sql_ile_veri_bagla
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.bilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet2 = new sql_ile_veri_bagla.personelDataSet2();
            this.personelDataSet = new sql_ile_veri_bagla.personelDataSet();
            this.personelDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet1 = new sql_ile_veri_bagla.personelDataSet1();
            this.personelDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bilgiTableAdapter = new sql_ile_veri_bagla.personelDataSet2TableAdapters.bilgiTableAdapter();
            this.personelDataSet3 = new sql_ile_veri_bagla.personelDataSet3();
            this.bilgiBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bilgiTableAdapter1 = new sql_ile_veri_bagla.personelDataSet3TableAdapters.bilgiTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.adDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bilgiBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.personelDataSet5 = new sql_ile_veri_bagla.personelDataSet5();
            this.bilgiTableAdapter2 = new sql_ile_veri_bagla.personelDataSet5TableAdapters.bilgiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgiBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgiBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet5)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(125, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(125, 91);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "ad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "soyad";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(150, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // bilgiBindingSource
            // 
            this.bilgiBindingSource.DataMember = "bilgi";
            this.bilgiBindingSource.DataSource = this.personelDataSet2;
            // 
            // personelDataSet2
            // 
            this.personelDataSet2.DataSetName = "personelDataSet2";
            this.personelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelDataSet
            // 
            this.personelDataSet.DataSetName = "personelDataSet";
            this.personelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelDataSetBindingSource
            // 
            this.personelDataSetBindingSource.DataSource = this.personelDataSet;
            this.personelDataSetBindingSource.Position = 0;
            // 
            // personelDataSet1
            // 
            this.personelDataSet1.DataSetName = "personelDataSet1";
            this.personelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // personelDataSet1BindingSource
            // 
            this.personelDataSet1BindingSource.DataSource = this.personelDataSet1;
            this.personelDataSet1BindingSource.Position = 0;
            // 
            // bilgiTableAdapter
            // 
            this.bilgiTableAdapter.ClearBeforeFill = true;
            // 
            // personelDataSet3
            // 
            this.personelDataSet3.DataSetName = "personelDataSet3";
            this.personelDataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bilgiBindingSource1
            // 
            this.bilgiBindingSource1.DataMember = "bilgi";
            this.bilgiBindingSource1.DataSource = this.personelDataSet3;
            // 
            // bilgiTableAdapter1
            // 
            this.bilgiTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adDataGridViewTextBoxColumn,
            this.soyadDataGridViewTextBoxColumn,
            this.idDataGridViewTextBoxColumn,
            this.telDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bilgiBindingSource2;
            this.dataGridView1.Location = new System.Drawing.Point(150, 230);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 5;
            // 
            // adDataGridViewTextBoxColumn
            // 
            this.adDataGridViewTextBoxColumn.DataPropertyName = "ad";
            this.adDataGridViewTextBoxColumn.HeaderText = "ad";
            this.adDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adDataGridViewTextBoxColumn.Name = "adDataGridViewTextBoxColumn";
            this.adDataGridViewTextBoxColumn.Width = 125;
            // 
            // soyadDataGridViewTextBoxColumn
            // 
            this.soyadDataGridViewTextBoxColumn.DataPropertyName = "soyad";
            this.soyadDataGridViewTextBoxColumn.HeaderText = "soyad";
            this.soyadDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.soyadDataGridViewTextBoxColumn.Name = "soyadDataGridViewTextBoxColumn";
            this.soyadDataGridViewTextBoxColumn.Width = 125;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // telDataGridViewTextBoxColumn
            // 
            this.telDataGridViewTextBoxColumn.DataPropertyName = "tel";
            this.telDataGridViewTextBoxColumn.HeaderText = "tel";
            this.telDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.telDataGridViewTextBoxColumn.Name = "telDataGridViewTextBoxColumn";
            this.telDataGridViewTextBoxColumn.Width = 125;
            // 
            // bilgiBindingSource2
            // 
            this.bilgiBindingSource2.DataMember = "bilgi";
            this.bilgiBindingSource2.DataSource = this.personelDataSet5;
            // 
            // personelDataSet5
            // 
            this.personelDataSet5.DataSetName = "personelDataSet5";
            this.personelDataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bilgiTableAdapter2
            // 
            this.bilgiTableAdapter2.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "S";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgiBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bilgiBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelDataSet5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.BindingSource personelDataSetBindingSource;
        private personelDataSet personelDataSet;
        private System.Windows.Forms.BindingSource personelDataSet1BindingSource;
        private personelDataSet1 personelDataSet1;
        private personelDataSet2 personelDataSet2;
        private System.Windows.Forms.BindingSource bilgiBindingSource;
        private personelDataSet2TableAdapters.bilgiTableAdapter bilgiTableAdapter;
        private personelDataSet3 personelDataSet3;
        private System.Windows.Forms.BindingSource bilgiBindingSource1;
        private personelDataSet3TableAdapters.bilgiTableAdapter bilgiTableAdapter1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private personelDataSet5 personelDataSet5;
        private System.Windows.Forms.BindingSource bilgiBindingSource2;
        private personelDataSet5TableAdapters.bilgiTableAdapter bilgiTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn adDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyadDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn telDataGridViewTextBoxColumn;
    }
}

