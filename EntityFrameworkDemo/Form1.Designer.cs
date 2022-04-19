
namespace EntityFrameworkDemo
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
            this.button_Delete = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_Add_StockAmount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Add_UnitPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Add_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_Update_UnitPrice = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_Update_Name = new System.Windows.Forms.TextBox();
            this.button_Add = new System.Windows.Forms.Button();
            this.textBox_Update_StockAmount = new System.Windows.Forms.TextBox();
            this.groupBox_Update = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_Update = new System.Windows.Forms.Button();
            this.groupBox_Add = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox_Search = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox_Update.SuspendLayout();
            this.groupBox_Add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_Delete
            // 
            this.button_Delete.Location = new System.Drawing.Point(713, 7);
            this.button_Delete.Name = "button_Delete";
            this.button_Delete.Size = new System.Drawing.Size(75, 23);
            this.button_Delete.TabIndex = 7;
            this.button_Delete.Text = "Delete";
            this.button_Delete.UseVisualStyleBackColor = true;
            this.button_Delete.Click += new System.EventHandler(this.button_Delete_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Name";
            // 
            // textBox_Add_StockAmount
            // 
            this.textBox_Add_StockAmount.Location = new System.Drawing.Point(190, 90);
            this.textBox_Add_StockAmount.Name = "textBox_Add_StockAmount";
            this.textBox_Add_StockAmount.Size = new System.Drawing.Size(118, 20);
            this.textBox_Add_StockAmount.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "StockAmount";
            // 
            // textBox_Add_UnitPrice
            // 
            this.textBox_Add_UnitPrice.Location = new System.Drawing.Point(190, 64);
            this.textBox_Add_UnitPrice.Name = "textBox_Add_UnitPrice";
            this.textBox_Add_UnitPrice.Size = new System.Drawing.Size(118, 20);
            this.textBox_Add_UnitPrice.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "UnitPrice";
            // 
            // textBox_Add_Name
            // 
            this.textBox_Add_Name.Location = new System.Drawing.Point(190, 38);
            this.textBox_Add_Name.Name = "textBox_Add_Name";
            this.textBox_Add_Name.Size = new System.Drawing.Size(118, 20);
            this.textBox_Add_Name.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // textBox_Update_UnitPrice
            // 
            this.textBox_Update_UnitPrice.Location = new System.Drawing.Point(190, 64);
            this.textBox_Update_UnitPrice.Name = "textBox_Update_UnitPrice";
            this.textBox_Update_UnitPrice.Size = new System.Drawing.Size(118, 20);
            this.textBox_Update_UnitPrice.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "UnitPrice";
            // 
            // textBox_Update_Name
            // 
            this.textBox_Update_Name.Location = new System.Drawing.Point(190, 38);
            this.textBox_Update_Name.Name = "textBox_Update_Name";
            this.textBox_Update_Name.Size = new System.Drawing.Size(118, 20);
            this.textBox_Update_Name.TabIndex = 2;
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(233, 116);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(75, 23);
            this.button_Add.TabIndex = 0;
            this.button_Add.Text = "Add";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // textBox_Update_StockAmount
            // 
            this.textBox_Update_StockAmount.Location = new System.Drawing.Point(190, 90);
            this.textBox_Update_StockAmount.Name = "textBox_Update_StockAmount";
            this.textBox_Update_StockAmount.Size = new System.Drawing.Size(118, 20);
            this.textBox_Update_StockAmount.TabIndex = 6;
            // 
            // groupBox_Update
            // 
            this.groupBox_Update.Controls.Add(this.textBox_Update_StockAmount);
            this.groupBox_Update.Controls.Add(this.label4);
            this.groupBox_Update.Controls.Add(this.textBox_Update_UnitPrice);
            this.groupBox_Update.Controls.Add(this.label5);
            this.groupBox_Update.Controls.Add(this.textBox_Update_Name);
            this.groupBox_Update.Controls.Add(this.label6);
            this.groupBox_Update.Controls.Add(this.button_Update);
            this.groupBox_Update.Location = new System.Drawing.Point(474, 299);
            this.groupBox_Update.Name = "groupBox_Update";
            this.groupBox_Update.Size = new System.Drawing.Size(314, 145);
            this.groupBox_Update.TabIndex = 6;
            this.groupBox_Update.TabStop = false;
            this.groupBox_Update.Text = "Update a product";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "StockAmount";
            // 
            // button_Update
            // 
            this.button_Update.Location = new System.Drawing.Point(233, 116);
            this.button_Update.Name = "button_Update";
            this.button_Update.Size = new System.Drawing.Size(75, 23);
            this.button_Update.TabIndex = 0;
            this.button_Update.Text = "Update";
            this.button_Update.UseVisualStyleBackColor = true;
            this.button_Update.Click += new System.EventHandler(this.button_Update_Click);
            // 
            // groupBox_Add
            // 
            this.groupBox_Add.Controls.Add(this.textBox_Add_StockAmount);
            this.groupBox_Add.Controls.Add(this.label3);
            this.groupBox_Add.Controls.Add(this.textBox_Add_UnitPrice);
            this.groupBox_Add.Controls.Add(this.label2);
            this.groupBox_Add.Controls.Add(this.textBox_Add_Name);
            this.groupBox_Add.Controls.Add(this.label1);
            this.groupBox_Add.Controls.Add(this.button_Add);
            this.groupBox_Add.Location = new System.Drawing.Point(12, 299);
            this.groupBox_Add.Name = "groupBox_Add";
            this.groupBox_Add.Size = new System.Drawing.Size(314, 145);
            this.groupBox_Add.TabIndex = 5;
            this.groupBox_Add.TabStop = false;
            this.groupBox_Add.Text = "Add a product";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 36);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 257);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // textBox_Search
            // 
            this.textBox_Search.Location = new System.Drawing.Point(521, 9);
            this.textBox_Search.Name = "textBox_Search";
            this.textBox_Search.Size = new System.Drawing.Size(156, 20);
            this.textBox_Search.TabIndex = 8;
            this.textBox_Search.TextChanged += new System.EventHandler(this.textBox_Search_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(471, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Search";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_Search);
            this.Controls.Add(this.button_Delete);
            this.Controls.Add(this.groupBox_Update);
            this.Controls.Add(this.groupBox_Add);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox_Update.ResumeLayout(false);
            this.groupBox_Update.PerformLayout();
            this.groupBox_Add.ResumeLayout(false);
            this.groupBox_Add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_Delete;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_Add_StockAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Add_UnitPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Add_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_Update_UnitPrice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_Update_Name;
        private System.Windows.Forms.Button button_Add;
        private System.Windows.Forms.TextBox textBox_Update_StockAmount;
        private System.Windows.Forms.GroupBox groupBox_Update;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_Update;
        private System.Windows.Forms.GroupBox groupBox_Add;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox_Search;
        private System.Windows.Forms.Label label7;
    }
}

