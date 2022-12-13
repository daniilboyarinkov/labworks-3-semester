namespace WinFormView
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
            this.delbtn = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.group_field = new System.Windows.Forms.TextBox();
            this.addbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.speciality_field = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.name_field = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statisticbtn = new System.Windows.Forms.Button();
            this.zedGraph = new ZedGraph.ZedGraphControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.StudentBox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // delbtn
            // 
            this.delbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.delbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.delbtn.Location = new System.Drawing.Point(6, 296);
            this.delbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.delbtn.Name = "delbtn";
            this.delbtn.Size = new System.Drawing.Size(324, 41);
            this.delbtn.TabIndex = 1;
            this.delbtn.Text = "Удалить студента";
            this.delbtn.UseVisualStyleBackColor = false;
            this.delbtn.Click += new System.EventHandler(this.delbtn_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.group_field);
            this.groupBox1.Controls.Add(this.addbtn);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.speciality_field);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.name_field);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.groupBox1.Location = new System.Drawing.Point(358, 6);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox1.Size = new System.Drawing.Size(219, 269);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Добавить студента";
            // 
            // group_field
            // 
            this.group_field.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.group_field.Location = new System.Drawing.Point(15, 170);
            this.group_field.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.group_field.Multiline = true;
            this.group_field.Name = "group_field";
            this.group_field.Size = new System.Drawing.Size(196, 28);
            this.group_field.TabIndex = 5;
            // 
            // addbtn
            // 
            this.addbtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.addbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addbtn.Location = new System.Drawing.Point(15, 218);
            this.addbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(194, 41);
            this.addbtn.TabIndex = 4;
            this.addbtn.Text = "Добавить";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 148);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Группа";
            // 
            // speciality_field
            // 
            this.speciality_field.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speciality_field.Location = new System.Drawing.Point(15, 113);
            this.speciality_field.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.speciality_field.Multiline = true;
            this.speciality_field.Name = "speciality_field";
            this.speciality_field.Size = new System.Drawing.Size(196, 28);
            this.speciality_field.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Специализация";
            // 
            // name_field
            // 
            this.name_field.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.name_field.Location = new System.Drawing.Point(15, 53);
            this.name_field.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.name_field.Multiline = true;
            this.name_field.Name = "name_field";
            this.name_field.Size = new System.Drawing.Size(196, 28);
            this.name_field.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Имя";
            // 
            // statisticbtn
            // 
            this.statisticbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.statisticbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.statisticbtn.Location = new System.Drawing.Point(6, 348);
            this.statisticbtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.statisticbtn.Name = "statisticbtn";
            this.statisticbtn.Size = new System.Drawing.Size(324, 41);
            this.statisticbtn.TabIndex = 3;
            this.statisticbtn.Text = "Посмотреть статистику";
            this.statisticbtn.UseVisualStyleBackColor = false;
            this.statisticbtn.Click += new System.EventHandler(this.statisticbtn_Click_1);
            // 
            // zedGraph
            // 
            this.zedGraph.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.zedGraph.Location = new System.Drawing.Point(68, 9);
            this.zedGraph.Name = "zedGraph";
            this.zedGraph.ScrollGrace = 0D;
            this.zedGraph.ScrollMaxX = 0D;
            this.zedGraph.ScrollMaxY = 0D;
            this.zedGraph.ScrollMaxY2 = 0D;
            this.zedGraph.ScrollMinX = 0D;
            this.zedGraph.ScrollMinY = 0D;
            this.zedGraph.ScrollMinY2 = 0D;
            this.zedGraph.Size = new System.Drawing.Size(151, 93);
            this.zedGraph.TabIndex = 5;
            this.zedGraph.UseExtendedPrintDialog = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.zedGraph);
            this.groupBox2.Location = new System.Drawing.Point(358, 287);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.groupBox2.Size = new System.Drawing.Size(219, 102);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Статистика";
            // 
            // StudentBox
            // 
            this.StudentBox.FormattingEnabled = true;
            this.StudentBox.Location = new System.Drawing.Point(6, 6);
            this.StudentBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.StudentBox.Name = "StudentBox";
            this.StudentBox.Size = new System.Drawing.Size(326, 277);
            this.StudentBox.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(592, 404);
            this.Controls.Add(this.StudentBox);
            this.Controls.Add(this.statisticbtn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.delbtn);
            this.Controls.Add(this.groupBox2);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "My Cool App";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button delbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox group_field;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox speciality_field;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox name_field;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button statisticbtn;
        private System.Windows.Forms.Button addbtn;
        private ZedGraph.ZedGraphControl zedGraph;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox StudentBox;
    }
}

