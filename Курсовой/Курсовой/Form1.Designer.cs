namespace Курсовой
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.museumDataSet = new Курсовой.museumDataSet();
            this.museumDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.excursionsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.excursionsTableAdapter = new Курсовой.museumDataSetTableAdapters.ExcursionsTableAdapter();
            this.idexcursionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shortdescriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.museumDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.museumDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idexcursionDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.shortdescriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.excursionsBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 450);
            this.dataGridView1.TabIndex = 0;
            // 
            // museumDataSet
            // 
            this.museumDataSet.DataSetName = "museumDataSet";
            this.museumDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // museumDataSetBindingSource
            // 
            this.museumDataSetBindingSource.DataSource = this.museumDataSet;
            this.museumDataSetBindingSource.Position = 0;
            // 
            // excursionsBindingSource
            // 
            this.excursionsBindingSource.DataMember = "Excursions";
            this.excursionsBindingSource.DataSource = this.museumDataSetBindingSource;
            // 
            // excursionsTableAdapter
            // 
            this.excursionsTableAdapter.ClearBeforeFill = true;
            // 
            // idexcursionDataGridViewTextBoxColumn
            // 
            this.idexcursionDataGridViewTextBoxColumn.DataPropertyName = "id_excursion";
            this.idexcursionDataGridViewTextBoxColumn.HeaderText = "id_excursion";
            this.idexcursionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idexcursionDataGridViewTextBoxColumn.Name = "idexcursionDataGridViewTextBoxColumn";
            this.idexcursionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idexcursionDataGridViewTextBoxColumn.Width = 125;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.Width = 125;
            // 
            // shortdescriptionDataGridViewTextBoxColumn
            // 
            this.shortdescriptionDataGridViewTextBoxColumn.DataPropertyName = "short_description";
            this.shortdescriptionDataGridViewTextBoxColumn.HeaderText = "short_description";
            this.shortdescriptionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shortdescriptionDataGridViewTextBoxColumn.Name = "shortdescriptionDataGridViewTextBoxColumn";
            this.shortdescriptionDataGridViewTextBoxColumn.Width = 125;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "price";
            this.priceDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.museumDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.museumDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excursionsBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource museumDataSetBindingSource;
        private museumDataSet museumDataSet;
        private System.Windows.Forms.BindingSource excursionsBindingSource;
        private museumDataSetTableAdapters.ExcursionsTableAdapter excursionsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idexcursionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shortdescriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
    }
}

