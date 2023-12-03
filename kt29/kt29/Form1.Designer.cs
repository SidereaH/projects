namespace kt29
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
            this.кодDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.фамилияDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.иОDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.колвоБалловПоДисциплинеООПНаCDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uspevaemostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.umnikithubDataSet = new kt29.umnikithubDataSet();
            this.uspevaemostTableAdapter = new kt29.umnikithubDataSetTableAdapters.uspevaemostTableAdapter();
            this.SaveButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspevaemostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.umnikithubDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодDataGridViewTextBoxColumn,
            this.фамилияDataGridViewTextBoxColumn,
            this.иОDataGridViewTextBoxColumn,
            this.колвоБалловПоДисциплинеООПНаCDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.uspevaemostBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(1, 1);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(442, 172);
            this.dataGridView1.TabIndex = 0;
            // 
            // кодDataGridViewTextBoxColumn
            // 
            this.кодDataGridViewTextBoxColumn.DataPropertyName = "Код";
            this.кодDataGridViewTextBoxColumn.HeaderText = "Код";
            this.кодDataGridViewTextBoxColumn.Name = "кодDataGridViewTextBoxColumn";
            // 
            // фамилияDataGridViewTextBoxColumn
            // 
            this.фамилияDataGridViewTextBoxColumn.DataPropertyName = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.фамилияDataGridViewTextBoxColumn.Name = "фамилияDataGridViewTextBoxColumn";
            // 
            // иОDataGridViewTextBoxColumn
            // 
            this.иОDataGridViewTextBoxColumn.DataPropertyName = "ИО";
            this.иОDataGridViewTextBoxColumn.HeaderText = "ИО";
            this.иОDataGridViewTextBoxColumn.Name = "иОDataGridViewTextBoxColumn";
            // 
            // колвоБалловПоДисциплинеООПНаCDataGridViewTextBoxColumn
            // 
            this.колвоБалловПоДисциплинеООПНаCDataGridViewTextBoxColumn.DataPropertyName = "Кол-во баллов по дисциплине ООП на C#";
            this.колвоБалловПоДисциплинеООПНаCDataGridViewTextBoxColumn.HeaderText = "Кол-во баллов по дисциплине ООП на C#";
            this.колвоБалловПоДисциплинеООПНаCDataGridViewTextBoxColumn.Name = "колвоБалловПоДисциплинеООПНаCDataGridViewTextBoxColumn";
            // 
            // uspevaemostBindingSource
            // 
            this.uspevaemostBindingSource.DataMember = "uspevaemost";
            this.uspevaemostBindingSource.DataSource = this.umnikithubDataSet;
            // 
            // umnikithubDataSet
            // 
            this.umnikithubDataSet.DataSetName = "umnikithubDataSet";
            this.umnikithubDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // uspevaemostTableAdapter
            // 
            this.uspevaemostTableAdapter.ClearBeforeFill = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(1, 179);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(120, 30);
            this.SaveButton.TabIndex = 1;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(323, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 2;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.uspevaemostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.umnikithubDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.DataGridView dataGridView1;
        public umnikithubDataSet umnikithubDataSet;
        public System.Windows.Forms.BindingSource uspevaemostBindingSource;
        public umnikithubDataSetTableAdapters.uspevaemostTableAdapter uspevaemostTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn фамилияDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn иОDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn колвоБалловПоДисциплинеООПНаCDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button button1;
    }
}

