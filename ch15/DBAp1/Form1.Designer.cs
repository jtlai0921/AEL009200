namespace DBAp1
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
            this.ch15DBDataSet = new DBAp1.ch15DBDataSet();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.產品編號DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.品名DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.單價DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.上架日期DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.是否供貨DataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.產品資料BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.產品資料TableAdapter = new DBAp1.ch15DBDataSetTableAdapters.產品資料TableAdapter();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch15DBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.產品資料BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.ch15DBDataSet;
            this.bindingSource1.Position = 0;
            // 
            // ch15DBDataSet
            // 
            this.ch15DBDataSet.DataSetName = "ch15DBDataSet";
            this.ch15DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.產品編號DataGridViewTextBoxColumn,
            this.品名DataGridViewTextBoxColumn,
            this.單價DataGridViewTextBoxColumn,
            this.上架日期DataGridViewTextBoxColumn,
            this.是否供貨DataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.產品資料BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 10);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(519, 190);
            this.dataGridView1.TabIndex = 0;
            // 
            // 產品編號DataGridViewTextBoxColumn
            // 
            this.產品編號DataGridViewTextBoxColumn.DataPropertyName = "產品編號";
            this.產品編號DataGridViewTextBoxColumn.HeaderText = "產品編號";
            this.產品編號DataGridViewTextBoxColumn.Name = "產品編號DataGridViewTextBoxColumn";
            // 
            // 品名DataGridViewTextBoxColumn
            // 
            this.品名DataGridViewTextBoxColumn.DataPropertyName = "品名";
            this.品名DataGridViewTextBoxColumn.HeaderText = "品名";
            this.品名DataGridViewTextBoxColumn.Name = "品名DataGridViewTextBoxColumn";
            // 
            // 單價DataGridViewTextBoxColumn
            // 
            this.單價DataGridViewTextBoxColumn.DataPropertyName = "單價";
            this.單價DataGridViewTextBoxColumn.HeaderText = "單價";
            this.單價DataGridViewTextBoxColumn.Name = "單價DataGridViewTextBoxColumn";
            // 
            // 上架日期DataGridViewTextBoxColumn
            // 
            this.上架日期DataGridViewTextBoxColumn.DataPropertyName = "上架日期";
            this.上架日期DataGridViewTextBoxColumn.HeaderText = "上架日期";
            this.上架日期DataGridViewTextBoxColumn.Name = "上架日期DataGridViewTextBoxColumn";
            // 
            // 是否供貨DataGridViewCheckBoxColumn
            // 
            this.是否供貨DataGridViewCheckBoxColumn.DataPropertyName = "是否供貨";
            this.是否供貨DataGridViewCheckBoxColumn.HeaderText = "是否供貨";
            this.是否供貨DataGridViewCheckBoxColumn.Name = "是否供貨DataGridViewCheckBoxColumn";
            // 
            // 產品資料BindingSource
            // 
            this.產品資料BindingSource.DataMember = "產品資料";
            this.產品資料BindingSource.DataSource = this.ch15DBDataSet;
            // 
            // 產品資料TableAdapter
            // 
            this.產品資料TableAdapter.ClearBeforeFill = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(11, 216);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(84, 23);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "更新資料庫";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnEnd
            // 
            this.btnEnd.Location = new System.Drawing.Point(112, 216);
            this.btnEnd.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnEnd.Name = "btnEnd";
            this.btnEnd.Size = new System.Drawing.Size(84, 23);
            this.btnEnd.TabIndex = 2;
            this.btnEnd.Text = "結束";
            this.btnEnd.UseVisualStyleBackColor = true;
            this.btnEnd.Click += new System.EventHandler(this.btnEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 244);
            this.Controls.Add(this.btnEnd);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ch15DBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.產品資料BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource bindingSource1;
        private ch15DBDataSet ch15DBDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource 產品資料BindingSource;
        private ch15DBDataSetTableAdapters.產品資料TableAdapter 產品資料TableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn 產品編號DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 品名DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 單價DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn 上架日期DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn 是否供貨DataGridViewCheckBoxColumn;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnEnd;
    }
}

