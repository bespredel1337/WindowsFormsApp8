namespace WindowsFormsApp8
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.directorNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.officialAdressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iDProductDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ratingDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.orgTypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalSalesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.partnerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.partnerDataSet = new WindowsFormsApp8.partnerDataSet();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.iDDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coastDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.partnerTableAdapter = new WindowsFormsApp8.partnerDataSetTableAdapters.partnerTableAdapter();
            this.productTableAdapter = new WindowsFormsApp8.partnerDataSetTableAdapters.productTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerDataSet)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(673, 356);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.flowLayoutPanel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(665, 330);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Список";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(6, 6);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(653, 321);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tabControl2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(665, 330);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Редактирование";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Location = new System.Drawing.Point(6, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(636, 304);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(628, 278);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Партнеры";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.directorNameDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.phoneDataGridViewTextBoxColumn,
            this.officialAdressDataGridViewTextBoxColumn,
            this.iDProductDataGridViewTextBoxColumn,
            this.ratingDataGridViewTextBoxColumn,
            this.orgTypeDataGridViewTextBoxColumn,
            this.totalSalesDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.partnerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(26, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(596, 253);
            this.dataGridView1.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // directorNameDataGridViewTextBoxColumn
            // 
            this.directorNameDataGridViewTextBoxColumn.DataPropertyName = "DirectorName";
            this.directorNameDataGridViewTextBoxColumn.HeaderText = "DirectorName";
            this.directorNameDataGridViewTextBoxColumn.Name = "directorNameDataGridViewTextBoxColumn";
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // phoneDataGridViewTextBoxColumn
            // 
            this.phoneDataGridViewTextBoxColumn.DataPropertyName = "Phone";
            this.phoneDataGridViewTextBoxColumn.HeaderText = "Phone";
            this.phoneDataGridViewTextBoxColumn.Name = "phoneDataGridViewTextBoxColumn";
            // 
            // officialAdressDataGridViewTextBoxColumn
            // 
            this.officialAdressDataGridViewTextBoxColumn.DataPropertyName = "OfficialAdress";
            this.officialAdressDataGridViewTextBoxColumn.HeaderText = "OfficialAdress";
            this.officialAdressDataGridViewTextBoxColumn.Name = "officialAdressDataGridViewTextBoxColumn";
            // 
            // iDProductDataGridViewTextBoxColumn
            // 
            this.iDProductDataGridViewTextBoxColumn.DataPropertyName = "ID_Product";
            this.iDProductDataGridViewTextBoxColumn.HeaderText = "ID_Product";
            this.iDProductDataGridViewTextBoxColumn.Name = "iDProductDataGridViewTextBoxColumn";
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            this.ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            this.ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            this.ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            // 
            // orgTypeDataGridViewTextBoxColumn
            // 
            this.orgTypeDataGridViewTextBoxColumn.DataPropertyName = "OrgType";
            this.orgTypeDataGridViewTextBoxColumn.HeaderText = "OrgType";
            this.orgTypeDataGridViewTextBoxColumn.Name = "orgTypeDataGridViewTextBoxColumn";
            // 
            // totalSalesDataGridViewTextBoxColumn
            // 
            this.totalSalesDataGridViewTextBoxColumn.DataPropertyName = "TotalSales";
            this.totalSalesDataGridViewTextBoxColumn.HeaderText = "TotalSales";
            this.totalSalesDataGridViewTextBoxColumn.Name = "totalSalesDataGridViewTextBoxColumn";
            // 
            // partnerBindingSource
            // 
            this.partnerBindingSource.DataMember = "partner";
            this.partnerBindingSource.DataSource = this.partnerDataSet;
            // 
            // partnerDataSet
            // 
            this.partnerDataSet.DataSetName = "partnerDataSet";
            this.partnerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView2);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(628, 278);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Продукция";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn1,
            this.nameDataGridViewTextBoxColumn,
            this.coastDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.productBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(22, 7);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(484, 202);
            this.dataGridView2.TabIndex = 0;
            // 
            // iDDataGridViewTextBoxColumn1
            // 
            this.iDDataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn1.Name = "iDDataGridViewTextBoxColumn1";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // coastDataGridViewTextBoxColumn
            // 
            this.coastDataGridViewTextBoxColumn.DataPropertyName = "Coast";
            this.coastDataGridViewTextBoxColumn.HeaderText = "Coast";
            this.coastDataGridViewTextBoxColumn.Name = "coastDataGridViewTextBoxColumn";
            // 
            // productBindingSource
            // 
            this.productBindingSource.DataMember = "product";
            this.productBindingSource.DataSource = this.partnerDataSet;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(665, 330);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Отчет";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // partnerTableAdapter
            // 
            this.partnerTableAdapter.ClearBeforeFill = true;
            // 
            // productTableAdapter
            // 
            this.productTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(26, 364);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.partnerDataSet)).EndInit();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage3;
        private partnerDataSet partnerDataSet;
        private System.Windows.Forms.BindingSource partnerBindingSource;
        private partnerDataSetTableAdapters.partnerTableAdapter partnerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn directorNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn officialAdressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDProductDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn orgTypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalSalesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource productBindingSource;
        private partnerDataSetTableAdapters.productTableAdapter productTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn coastDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}

