namespace DIPLOM
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
            this.button_downloadmany = new System.Windows.Forms.Button();
            this.button_download_one = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_downloadmany
            // 
            this.button_downloadmany.Location = new System.Drawing.Point(810, 10);
            this.button_downloadmany.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_downloadmany.Name = "button_downloadmany";
            this.button_downloadmany.Size = new System.Drawing.Size(140, 79);
            this.button_downloadmany.TabIndex = 0;
            this.button_downloadmany.Text = "загрузить много файлов";
            this.button_downloadmany.UseVisualStyleBackColor = true;
            this.button_downloadmany.Click += new System.EventHandler(this.button_downloadmany_Click);
            // 
            // button_download_one
            // 
            this.button_download_one.Location = new System.Drawing.Point(438, 10);
            this.button_download_one.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_download_one.Name = "button_download_one";
            this.button_download_one.Size = new System.Drawing.Size(140, 79);
            this.button_download_one.TabIndex = 1;
            this.button_download_one.Text = "загрузить один файл";
            this.button_download_one.UseVisualStyleBackColor = true;
            this.button_download_one.Click += new System.EventHandler(this.button_download_one_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(11, 11);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(423, 512);
            this.dataGridView1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1081, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(246, 46);
            this.button1.TabIndex = 3;
            this.button1.Text = "показать данные всех экспериментов";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(1081, 136);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 46);
            this.button2.TabIndex = 4;
            this.button2.Text = "показать данные одного эксперимента";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1459, 544);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_download_one);
            this.Controls.Add(this.button_downloadmany);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_downloadmany;
        private System.Windows.Forms.Button button_download_one;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

