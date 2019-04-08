namespace Kazak
{
    partial class VecForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.mainDataSet = new Kazak.mainDataSet();
            this.vecAllBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vecAllTableAdapter = new Kazak.mainDataSetTableAdapters.vecAllTableAdapter();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.voditelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.voditelTableAdapter = new Kazak.mainDataSetTableAdapters.voditelTableAdapter();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.oilBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.oilTableAdapter = new Kazak.mainDataSetTableAdapters.oilTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.namevecDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameOilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.normalOilDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vecAllBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voditelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oilBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.namevecDataGridViewTextBoxColumn,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.nameOilDataGridViewTextBoxColumn,
            this.normalOilDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.vecAllBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(592, 432);
            this.dataGridView1.TabIndex = 0;
            // 
            // mainDataSet
            // 
            this.mainDataSet.DataSetName = "mainDataSet";
            this.mainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vecAllBindingSource
            // 
            this.vecAllBindingSource.DataMember = "vecAll";
            this.vecAllBindingSource.DataSource = this.mainDataSet;
            // 
            // vecAllTableAdapter
            // 
            this.vecAllTableAdapter.ClearBeforeFill = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(780, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(217, 20);
            this.textBox1.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.voditelBindingSource;
            this.comboBox1.DisplayMember = "last_name";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(780, 88);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 21);
            this.comboBox1.TabIndex = 2;
            this.comboBox1.ValueMember = "id";
            // 
            // voditelBindingSource
            // 
            this.voditelBindingSource.DataMember = "voditel";
            this.voditelBindingSource.DataSource = this.mainDataSet;
            // 
            // voditelTableAdapter
            // 
            this.voditelTableAdapter.ClearBeforeFill = true;
            // 
            // comboBox2
            // 
            this.comboBox2.DataSource = this.oilBindingSource;
            this.comboBox2.DisplayMember = "nameOil";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(780, 143);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(217, 21);
            this.comboBox2.TabIndex = 3;
            this.comboBox2.ValueMember = "id";
            // 
            // oilBindingSource
            // 
            this.oilBindingSource.DataMember = "oil";
            this.oilBindingSource.DataSource = this.mainDataSet;
            // 
            // oilTableAdapter
            // 
            this.oilTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(674, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Наименование ТС";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Водитель";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(700, 151);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Тип топлива";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(780, 191);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(217, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(636, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Норма расхода на 100 км";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(824, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Добавить ТС";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // namevecDataGridViewTextBoxColumn
            // 
            this.namevecDataGridViewTextBoxColumn.DataPropertyName = "namevec";
            this.namevecDataGridViewTextBoxColumn.HeaderText = "namevec";
            this.namevecDataGridViewTextBoxColumn.Name = "namevecDataGridViewTextBoxColumn";
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // nameOilDataGridViewTextBoxColumn
            // 
            this.nameOilDataGridViewTextBoxColumn.DataPropertyName = "nameOil";
            this.nameOilDataGridViewTextBoxColumn.HeaderText = "nameOil";
            this.nameOilDataGridViewTextBoxColumn.Name = "nameOilDataGridViewTextBoxColumn";
            // 
            // normalOilDataGridViewTextBoxColumn
            // 
            this.normalOilDataGridViewTextBoxColumn.DataPropertyName = "normalOil";
            this.normalOilDataGridViewTextBoxColumn.HeaderText = "normalOil";
            this.normalOilDataGridViewTextBoxColumn.Name = "normalOilDataGridViewTextBoxColumn";
            // 
            // VecForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 476);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VecForm";
            this.Text = "VecForm";
            this.Load += new System.EventHandler(this.VecForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vecAllBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voditelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oilBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private mainDataSet mainDataSet;
        private System.Windows.Forms.BindingSource vecAllBindingSource;
        private mainDataSetTableAdapters.vecAllTableAdapter vecAllTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource voditelBindingSource;
        private mainDataSetTableAdapters.voditelTableAdapter voditelTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.BindingSource oilBindingSource;
        private mainDataSetTableAdapters.oilTableAdapter oilTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namevecDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameOilDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn normalOilDataGridViewTextBoxColumn;
    }
}