namespace kt25
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
            this.umnikithubDataSet = new kt25.umnikithubDataSet();
            this.uspevaemostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.uspevaemostTableAdapter = new kt25.umnikithubDataSetTableAdapters.uspevaemostTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umnikithubDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspevaemostBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.DataSource = this.uspevaemostBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // umnikithubDataSet
            // 
            this.umnikithubDataSet.DataSetName = "umnikithubDataSet";
            this.umnikithubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspevaemostBindingSource
            // 
            this.uspevaemostBindingSource.DataMember = "uspevaemost";
            this.uspevaemostBindingSource.DataSource = this.umnikithubDataSet;
            // 
            // uspevaemostTableAdapter
            // 
            this.uspevaemostTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umnikithubDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspevaemostBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private umnikithubDataSet umnikithubDataSet;
        private System.Windows.Forms.BindingSource uspevaemostBindingSource;
        private umnikithubDataSetTableAdapters.uspevaemostTableAdapter uspevaemostTableAdapter;
    }
}

