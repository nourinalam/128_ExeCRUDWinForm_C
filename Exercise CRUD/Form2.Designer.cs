
namespace Exercise_CRUD
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.daftarlaptopDataSet = new Exercise_CRUD.daftarlaptopDataSet();
            this.asusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asusTableAdapter = new Exercise_CRUD.daftarlaptopDataSetTableAdapters.AsusTableAdapter();
            this.lenovoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lenovoTableAdapter = new Exercise_CRUD.daftarlaptopDataSetTableAdapters.LenovoTableAdapter();
            this.idLaptopLenovoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelLenovoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipeLenovoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarlaptopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenovoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(270, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Lenovo";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lenovoBindingSource, "id_Laptop_Lenovo", true));
            this.textBox1.Location = new System.Drawing.Point(154, 163);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(164, 22);
            this.textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lenovoBindingSource, "Model_Lenovo", true));
            this.textBox2.Location = new System.Drawing.Point(154, 206);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(164, 22);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.lenovoBindingSource, "Tipe_Lenovo", true));
            this.textBox3.Location = new System.Drawing.Point(154, 253);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 22);
            this.textBox3.TabIndex = 3;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 337);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(154, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(258, 337);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(154, 391);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Id Laptop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Model Laptop";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 258);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tipe Laptop";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLaptopLenovoDataGridViewTextBoxColumn,
            this.modelLenovoDataGridViewTextBoxColumn,
            this.tipeLenovoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.lenovoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(363, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(429, 165);
            this.dataGridView1.TabIndex = 11;
            // 
            // daftarlaptopDataSet
            // 
            this.daftarlaptopDataSet.DataSetName = "daftarlaptopDataSet";
            this.daftarlaptopDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // asusBindingSource
            // 
            this.asusBindingSource.DataMember = "Asus";
            this.asusBindingSource.DataSource = this.daftarlaptopDataSet;
            // 
            // asusTableAdapter
            // 
            this.asusTableAdapter.ClearBeforeFill = true;
            // 
            // lenovoBindingSource
            // 
            this.lenovoBindingSource.DataMember = "Lenovo";
            this.lenovoBindingSource.DataSource = this.daftarlaptopDataSet;
            // 
            // lenovoTableAdapter
            // 
            this.lenovoTableAdapter.ClearBeforeFill = true;
            // 
            // idLaptopLenovoDataGridViewTextBoxColumn
            // 
            this.idLaptopLenovoDataGridViewTextBoxColumn.DataPropertyName = "id_Laptop_Lenovo";
            this.idLaptopLenovoDataGridViewTextBoxColumn.HeaderText = "id_Laptop_Lenovo";
            this.idLaptopLenovoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idLaptopLenovoDataGridViewTextBoxColumn.Name = "idLaptopLenovoDataGridViewTextBoxColumn";
            this.idLaptopLenovoDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelLenovoDataGridViewTextBoxColumn
            // 
            this.modelLenovoDataGridViewTextBoxColumn.DataPropertyName = "Model_Lenovo";
            this.modelLenovoDataGridViewTextBoxColumn.HeaderText = "Model_Lenovo";
            this.modelLenovoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelLenovoDataGridViewTextBoxColumn.Name = "modelLenovoDataGridViewTextBoxColumn";
            this.modelLenovoDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipeLenovoDataGridViewTextBoxColumn
            // 
            this.tipeLenovoDataGridViewTextBoxColumn.DataPropertyName = "Tipe_Lenovo";
            this.tipeLenovoDataGridViewTextBoxColumn.HeaderText = "Tipe_Lenovo";
            this.tipeLenovoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipeLenovoDataGridViewTextBoxColumn.Name = "tipeLenovoDataGridViewTextBoxColumn";
            this.tipeLenovoDataGridViewTextBoxColumn.Width = 125;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(801, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarlaptopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lenovoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private daftarlaptopDataSet daftarlaptopDataSet;
        private System.Windows.Forms.BindingSource asusBindingSource;
        private daftarlaptopDataSetTableAdapters.AsusTableAdapter asusTableAdapter;
        private System.Windows.Forms.BindingSource lenovoBindingSource;
        private daftarlaptopDataSetTableAdapters.LenovoTableAdapter lenovoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLaptopLenovoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelLenovoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipeLenovoDataGridViewTextBoxColumn;
    }
}