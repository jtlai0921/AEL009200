namespace DBAp4
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.myDBDataSet = new DBAp4.MyDBDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.部門編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.部門名稱DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.部門BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.部門編號DataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.員工編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.姓名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.電話DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.薪資DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.部門員工BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.部門TableAdapter = new DBAp4.MyDBDataSetTableAdapters.部門TableAdapter();
            this.員工TableAdapter = new DBAp4.MyDBDataSetTableAdapters.員工TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.部門BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.部門員工BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.myDBDataSet;
            this.bindingSource1.Position = 0;
            // 
            // myDBDataSet
            // 
            this.myDBDataSet.DataSetName = "MyDBDataSet";
            this.myDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "部門";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 146);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "員工";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.部門編號DataGridViewTextBoxColumn,
            this.部門名稱DataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.部門BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(61, 15);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(294, 109);
            this.dataGridView1.TabIndex = 1;
            // 
            // 部門編號DataGridViewTextBoxColumn
            // 
            this.部門編號DataGridViewTextBoxColumn.DataPropertyName = "部門編號";
            this.部門編號DataGridViewTextBoxColumn.HeaderText = "部門編號";
            this.部門編號DataGridViewTextBoxColumn.Name = "部門編號DataGridViewTextBoxColumn";
            this.部門編號DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // 部門名稱DataGridViewTextBoxColumn
            // 
            this.部門名稱DataGridViewTextBoxColumn.DataPropertyName = "部門名稱";
            this.部門名稱DataGridViewTextBoxColumn.HeaderText = "部門名稱";
            this.部門名稱DataGridViewTextBoxColumn.Name = "部門名稱DataGridViewTextBoxColumn";
            // 
            // 部門BindingSource
            // 
            this.部門BindingSource.DataMember = "部門";
            this.部門BindingSource.DataSource = this.myDBDataSet;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.部門編號DataGridViewTextBoxColumn1,
            this.員工編號DataGridViewTextBoxColumn,
            this.姓名DataGridViewTextBoxColumn,
            this.電話DataGridViewTextBoxColumn,
            this.薪資DataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.部門員工BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(61, 144);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 27;
            this.dataGridView2.Size = new System.Drawing.Size(527, 175);
            this.dataGridView2.TabIndex = 1;
            // 
            // 部門編號DataGridViewTextBoxColumn1
            // 
            this.部門編號DataGridViewTextBoxColumn1.DataPropertyName = "部門編號";
            this.部門編號DataGridViewTextBoxColumn1.HeaderText = "部門編號";
            this.部門編號DataGridViewTextBoxColumn1.Name = "部門編號DataGridViewTextBoxColumn1";
            // 
            // 員工編號DataGridViewTextBoxColumn
            // 
            this.員工編號DataGridViewTextBoxColumn.DataPropertyName = "員工編號";
            this.員工編號DataGridViewTextBoxColumn.HeaderText = "員工編號";
            this.員工編號DataGridViewTextBoxColumn.Name = "員工編號DataGridViewTextBoxColumn";
            // 
            // 姓名DataGridViewTextBoxColumn
            // 
            this.姓名DataGridViewTextBoxColumn.DataPropertyName = "姓名";
            this.姓名DataGridViewTextBoxColumn.HeaderText = "姓名";
            this.姓名DataGridViewTextBoxColumn.Name = "姓名DataGridViewTextBoxColumn";
            // 
            // 電話DataGridViewTextBoxColumn
            // 
            this.電話DataGridViewTextBoxColumn.DataPropertyName = "電話";
            this.電話DataGridViewTextBoxColumn.HeaderText = "電話";
            this.電話DataGridViewTextBoxColumn.Name = "電話DataGridViewTextBoxColumn";
            // 
            // 薪資DataGridViewTextBoxColumn
            // 
            this.薪資DataGridViewTextBoxColumn.DataPropertyName = "薪資";
            this.薪資DataGridViewTextBoxColumn.HeaderText = "薪資";
            this.薪資DataGridViewTextBoxColumn.Name = "薪資DataGridViewTextBoxColumn";
            // 
            // 部門員工BindingSource
            // 
            this.部門員工BindingSource.DataMember = "部門_員工";
            this.部門員工BindingSource.DataSource = this.部門BindingSource;
            // 
            // 部門TableAdapter
            // 
            this.部門TableAdapter.ClearBeforeFill = true;
            // 
            // 員工TableAdapter
            // 
            this.員工TableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 343);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.myDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.部門BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.部門員工BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private MyDBDataSet myDBDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource 部門BindingSource;
        private MyDBDataSetTableAdapters.部門TableAdapter 部門TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 部門編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 部門名稱DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource 部門員工BindingSource;
        private MyDBDataSetTableAdapters.員工TableAdapter 員工TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 部門編號DataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn 員工編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 姓名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 電話DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 薪資DataGridViewTextBoxColumn;
    }
}

