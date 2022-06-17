
namespace Exercise_CRUD
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.daftarlaptopDataSet = new Exercise_CRUD.daftarlaptopDataSet();
            this.asusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.asusTableAdapter = new Exercise_CRUD.daftarlaptopDataSetTableAdapters.AsusTableAdapter();
            this.idLaptopAsusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modelAsusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipeAsusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarlaptopDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.asusBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(38, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "My Asus";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 178);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Id Laptop";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Model Laptop";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 256);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tipe Laptop";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asusBindingSource, "id_Laptop_Asus", true));
            this.textBox1.Location = new System.Drawing.Point(180, 178);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(139, 22);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asusBindingSource, "Model_Asus", true));
            this.textBox2.Location = new System.Drawing.Point(180, 215);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 22);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.asusBindingSource, "Tipe_Asus", true));
            this.textBox3.Location = new System.Drawing.Point(180, 256);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(139, 22);
            this.textBox3.TabIndex = 6;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 313);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Create";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(149, 313);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(244, 313);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(48, 366);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(133, 23);
            this.button4.TabIndex = 10;
            this.button4.Text = "My Lenovo";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idLaptopAsusDataGridViewTextBoxColumn,
            this.modelAsusDataGridViewTextBoxColumn,
            this.tipeAsusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.asusBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(371, 178);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(417, 150);
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
            // idLaptopAsusDataGridViewTextBoxColumn
            // 
            this.idLaptopAsusDataGridViewTextBoxColumn.DataPropertyName = "id_Laptop_Asus";
            this.idLaptopAsusDataGridViewTextBoxColumn.HeaderText = "id_Laptop_Asus";
            this.idLaptopAsusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idLaptopAsusDataGridViewTextBoxColumn.Name = "idLaptopAsusDataGridViewTextBoxColumn";
            this.idLaptopAsusDataGridViewTextBoxColumn.Width = 125;
            // 
            // modelAsusDataGridViewTextBoxColumn
            // 
            this.modelAsusDataGridViewTextBoxColumn.DataPropertyName = "Model_Asus";
            this.modelAsusDataGridViewTextBoxColumn.HeaderText = "Model_Asus";
            this.modelAsusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.modelAsusDataGridViewTextBoxColumn.Name = "modelAsusDataGridViewTextBoxColumn";
            this.modelAsusDataGridViewTextBoxColumn.Width = 125;
            // 
            // tipeAsusDataGridViewTextBoxColumn
            // 
            this.tipeAsusDataGridViewTextBoxColumn.DataPropertyName = "Tipe_Asus";
            this.tipeAsusDataGridViewTextBoxColumn.HeaderText = "Tipe_Asus";
            this.tipeAsusDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.tipeAsusDataGridViewTextBoxColumn.Name = "tipeAsusDataGridViewTextBoxColumn";
            this.tipeAsusDataGridViewTextBoxColumn.Width = 125;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(191, 366);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(128, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "My Hp";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.daftarlaptopDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.asusBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private daftarlaptopDataSet daftarlaptopDataSet;
        private System.Windows.Forms.BindingSource asusBindingSource;
        private daftarlaptopDataSetTableAdapters.AsusTableAdapter asusTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idLaptopAsusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modelAsusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipeAsusDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button button5;
    }
}

