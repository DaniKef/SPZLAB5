﻿
namespace SPZLAB5
{
    partial class ChangeStudent
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddNameTbx = new System.Windows.Forms.TextBox();
            this.AddSurnameTbx = new System.Windows.Forms.TextBox();
            this.AddPatroTbx = new System.Windows.Forms.TextBox();
            this.AddStudentBtn = new System.Windows.Forms.Button();
            this.OKBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 22);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(360, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(13, 209);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Добавить студента";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(13, 249);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Имя";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(13, 291);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Фамилия";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(13, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 4;
            this.label4.Text = "Отчество";
            // 
            // AddNameTbx
            // 
            this.AddNameTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddNameTbx.Location = new System.Drawing.Point(166, 248);
            this.AddNameTbx.Name = "AddNameTbx";
            this.AddNameTbx.Size = new System.Drawing.Size(189, 26);
            this.AddNameTbx.TabIndex = 5;
            // 
            // AddSurnameTbx
            // 
            this.AddSurnameTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddSurnameTbx.Location = new System.Drawing.Point(166, 288);
            this.AddSurnameTbx.Name = "AddSurnameTbx";
            this.AddSurnameTbx.Size = new System.Drawing.Size(189, 26);
            this.AddSurnameTbx.TabIndex = 6;
            // 
            // AddPatroTbx
            // 
            this.AddPatroTbx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPatroTbx.Location = new System.Drawing.Point(166, 330);
            this.AddPatroTbx.Name = "AddPatroTbx";
            this.AddPatroTbx.Size = new System.Drawing.Size(189, 26);
            this.AddPatroTbx.TabIndex = 7;
            // 
            // AddStudentBtn
            // 
            this.AddStudentBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddStudentBtn.Location = new System.Drawing.Point(37, 393);
            this.AddStudentBtn.Name = "AddStudentBtn";
            this.AddStudentBtn.Size = new System.Drawing.Size(115, 32);
            this.AddStudentBtn.TabIndex = 8;
            this.AddStudentBtn.Text = "Добавить";
            this.AddStudentBtn.UseVisualStyleBackColor = true;
            this.AddStudentBtn.Click += new System.EventHandler(this.AddStudentBtn_Click);
            // 
            // OKBtn
            // 
            this.OKBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OKBtn.Location = new System.Drawing.Point(194, 393);
            this.OKBtn.Name = "OKBtn";
            this.OKBtn.Size = new System.Drawing.Size(115, 32);
            this.OKBtn.TabIndex = 9;
            this.OKBtn.Text = "ОК";
            this.OKBtn.UseVisualStyleBackColor = true;
            this.OKBtn.Click += new System.EventHandler(this.OKBtn_Click);
            // 
            // ChangeStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 450);
            this.Controls.Add(this.OKBtn);
            this.Controls.Add(this.AddStudentBtn);
            this.Controls.Add(this.AddPatroTbx);
            this.Controls.Add(this.AddSurnameTbx);
            this.Controls.Add(this.AddNameTbx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "ChangeStudent";
            this.Text = "ChangeStudent";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddNameTbx;
        private System.Windows.Forms.TextBox AddSurnameTbx;
        private System.Windows.Forms.TextBox AddPatroTbx;
        private System.Windows.Forms.Button AddStudentBtn;
        private System.Windows.Forms.Button OKBtn;
    }
}