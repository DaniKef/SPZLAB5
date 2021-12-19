
namespace SPZLAB5
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.ChangeGroupBtn = new System.Windows.Forms.Button();
            this.ChangeStudentBtn = new System.Windows.Forms.Button();
            this.SortBySurnameBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.ShowAllBtn = new System.Windows.Forms.Button();
            this.WhatGroupTbx = new System.Windows.Forms.TextBox();
            this.ShowThisGroupBtn = new System.Windows.Forms.Button();
            this.SaveToJSONBtn = new System.Windows.Forms.Button();
            this.GetFromJSONBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(432, 218);
            this.dataGridView1.TabIndex = 0;
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddStudentBtn.Location = new System.Drawing.Point(469, 12);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(129, 50);
            this.AddStudentBtn.TabIndex = 1;
            this.AddStudentBtn.Text = "Добавить студента";
            this.AddStudentBtn.UseVisualStyleBackColor = true;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // ChangeGroupBtn
            // 
            this.ChangeGroupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeGroupBtn.Location = new System.Drawing.Point(469, 87);
            this.ChangeGroupBtn.Name = "ChangeGroupBtn";
            this.ChangeGroupBtn.Size = new System.Drawing.Size(129, 50);
            this.ChangeGroupBtn.TabIndex = 2;
            this.ChangeGroupBtn.Text = "Изменить группы";
            this.ChangeGroupBtn.UseVisualStyleBackColor = true;
            this.ChangeGroupBtn.Click += new System.EventHandler(this.ChangeGroupBtn_Click);
            // 
            // ChangeStudentBtn
            // 
            this.ChangeStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ChangeStudentBtn.Location = new System.Drawing.Point(469, 165);
            this.ChangeStudentBtn.Name = "ChangeStudentBtn";
            this.ChangeStudentBtn.Size = new System.Drawing.Size(129, 50);
            this.ChangeStudentBtn.TabIndex = 3;
            this.ChangeStudentBtn.Text = "Изменить студентов";
            this.ChangeStudentBtn.UseVisualStyleBackColor = true;
            this.ChangeStudentBtn.Click += new System.EventHandler(this.ChangeStudentBtn_Click);
            // 
            // SortBySurnameBtn
            // 
            this.SortBySurnameBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SortBySurnameBtn.Location = new System.Drawing.Point(12, 260);
            this.SortBySurnameBtn.Name = "SortBySurnameBtn";
            this.SortBySurnameBtn.Size = new System.Drawing.Size(129, 50);
            this.SortBySurnameBtn.TabIndex = 4;
            this.SortBySurnameBtn.Text = "Сортировать по фамилии";
            this.SortBySurnameBtn.UseVisualStyleBackColor = true;
            this.SortBySurnameBtn.Click += new System.EventHandler(this.SortBySurnameBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(147, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(129, 50);
            this.button1.TabIndex = 5;
            this.button1.Text = "Сортировать по группе";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowAllBtn
            // 
            this.ShowAllBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowAllBtn.Location = new System.Drawing.Point(12, 316);
            this.ShowAllBtn.Name = "ShowAllBtn";
            this.ShowAllBtn.Size = new System.Drawing.Size(129, 50);
            this.ShowAllBtn.TabIndex = 6;
            this.ShowAllBtn.Text = "Показать всех студентов";
            this.ShowAllBtn.UseVisualStyleBackColor = true;
            this.ShowAllBtn.Click += new System.EventHandler(this.ShowAllBtn_Click);
            // 
            // WhatGroupTbx
            // 
            this.WhatGroupTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WhatGroupTbx.Location = new System.Drawing.Point(217, 405);
            this.WhatGroupTbx.Name = "WhatGroupTbx";
            this.WhatGroupTbx.Size = new System.Drawing.Size(100, 26);
            this.WhatGroupTbx.TabIndex = 7;
            // 
            // ShowThisGroupBtn
            // 
            this.ShowThisGroupBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowThisGroupBtn.Location = new System.Drawing.Point(12, 388);
            this.ShowThisGroupBtn.Name = "ShowThisGroupBtn";
            this.ShowThisGroupBtn.Size = new System.Drawing.Size(187, 50);
            this.ShowThisGroupBtn.TabIndex = 8;
            this.ShowThisGroupBtn.Text = "Показать студентов этой группы";
            this.ShowThisGroupBtn.UseVisualStyleBackColor = true;
            this.ShowThisGroupBtn.Click += new System.EventHandler(this.ShowThisGroupBtn_Click);
            // 
            // SaveToJSONBtn
            // 
            this.SaveToJSONBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SaveToJSONBtn.Location = new System.Drawing.Point(394, 381);
            this.SaveToJSONBtn.Name = "SaveToJSONBtn";
            this.SaveToJSONBtn.Size = new System.Drawing.Size(129, 50);
            this.SaveToJSONBtn.TabIndex = 9;
            this.SaveToJSONBtn.Text = "Сохранить в JSON";
            this.SaveToJSONBtn.UseVisualStyleBackColor = true;
            this.SaveToJSONBtn.Click += new System.EventHandler(this.SaveToJSONBtn_Click);
            // 
            // GetFromJSONBtn
            // 
            this.GetFromJSONBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GetFromJSONBtn.Location = new System.Drawing.Point(529, 381);
            this.GetFromJSONBtn.Name = "GetFromJSONBtn";
            this.GetFromJSONBtn.Size = new System.Drawing.Size(129, 50);
            this.GetFromJSONBtn.TabIndex = 10;
            this.GetFromJSONBtn.Text = "Загрузить из JSON";
            this.GetFromJSONBtn.UseVisualStyleBackColor = true;
            this.GetFromJSONBtn.Click += new System.EventHandler(this.GetFromJSONBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 450);
            this.Controls.Add(this.GetFromJSONBtn);
            this.Controls.Add(this.SaveToJSONBtn);
            this.Controls.Add(this.ShowThisGroupBtn);
            this.Controls.Add(this.WhatGroupTbx);
            this.Controls.Add(this.ShowAllBtn);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SortBySurnameBtn);
            this.Controls.Add(this.ChangeStudentBtn);
            this.Controls.Add(this.ChangeGroupBtn);
            this.Controls.Add(this.AddStudentBtn);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.Text = "LB5";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button AddStudentBtn;
        private System.Windows.Forms.Button ChangeGroupBtn;
        private System.Windows.Forms.Button ChangeStudentBtn;
        private System.Windows.Forms.Button SortBySurnameBtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ShowAllBtn;
        private System.Windows.Forms.TextBox WhatGroupTbx;
        private System.Windows.Forms.Button ShowThisGroupBtn;
        private System.Windows.Forms.Button SaveToJSONBtn;
        private System.Windows.Forms.Button GetFromJSONBtn;
    }
}

