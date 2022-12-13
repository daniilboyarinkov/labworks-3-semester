namespace WinFormView
{
    partial class MainForm
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
            this.StudentList = new System.Windows.Forms.ListView();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.AddGroupBox = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.StudentGroup = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.StudentSpeciality = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.StudentName = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.ShowGistogrameButton = new System.Windows.Forms.Button();
            this.AddGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // StudentList
            // 
            this.StudentList.AllowColumnReorder = true;
            this.StudentList.FullRowSelect = true;
            this.StudentList.GridLines = true;
            this.StudentList.Location = new System.Drawing.Point(14, 15);
            this.StudentList.Margin = new System.Windows.Forms.Padding(4);
            this.StudentList.MultiSelect = false;
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(420, 374);
            this.StudentList.TabIndex = 25;
            this.StudentList.UseCompatibleStateImageBehavior = false;
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(65, 407);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(4);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(299, 57);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "Удалить";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // AddGroupBox
            // 
            this.AddGroupBox.Controls.Add(this.label3);
            this.AddGroupBox.Controls.Add(this.StudentGroup);
            this.AddGroupBox.Controls.Add(this.label2);
            this.AddGroupBox.Controls.Add(this.StudentSpeciality);
            this.AddGroupBox.Controls.Add(this.label1);
            this.AddGroupBox.Controls.Add(this.StudentName);
            this.AddGroupBox.Controls.Add(this.AddButton);
            this.AddGroupBox.Location = new System.Drawing.Point(475, 15);
            this.AddGroupBox.Margin = new System.Windows.Forms.Padding(4);
            this.AddGroupBox.Name = "AddGroupBox";
            this.AddGroupBox.Padding = new System.Windows.Forms.Padding(4);
            this.AddGroupBox.Size = new System.Drawing.Size(335, 308);
            this.AddGroupBox.TabIndex = 2;
            this.AddGroupBox.TabStop = false;
            this.AddGroupBox.Text = "Добавление студента";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Группа";
            // 
            // StudentGroup
            // 
            this.StudentGroup.Location = new System.Drawing.Point(149, 142);
            this.StudentGroup.Margin = new System.Windows.Forms.Padding(4);
            this.StudentGroup.Name = "StudentGroup";
            this.StudentGroup.Size = new System.Drawing.Size(158, 22);
            this.StudentGroup.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 99);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Специальность";
            // 
            // StudentSpeciality
            // 
            this.StudentSpeciality.Location = new System.Drawing.Point(149, 99);
            this.StudentSpeciality.Margin = new System.Windows.Forms.Padding(4);
            this.StudentSpeciality.Name = "StudentSpeciality";
            this.StudentSpeciality.Size = new System.Drawing.Size(158, 22);
            this.StudentSpeciality.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "ФИО студента";
            // 
            // StudentName
            // 
            this.StudentName.Location = new System.Drawing.Point(149, 52);
            this.StudentName.Margin = new System.Windows.Forms.Padding(4);
            this.StudentName.Name = "StudentName";
            this.StudentName.Size = new System.Drawing.Size(158, 22);
            this.StudentName.TabIndex = 5;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(29, 231);
            this.AddButton.Margin = new System.Windows.Forms.Padding(4);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(299, 57);
            this.AddButton.TabIndex = 4;
            this.AddButton.Text = "Добавить";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // ShowGistogrameButton
            // 
            this.ShowGistogrameButton.Location = new System.Drawing.Point(504, 407);
            this.ShowGistogrameButton.Margin = new System.Windows.Forms.Padding(4);
            this.ShowGistogrameButton.Name = "ShowGistogrameButton";
            this.ShowGistogrameButton.Size = new System.Drawing.Size(299, 57);
            this.ShowGistogrameButton.TabIndex = 3;
            this.ShowGistogrameButton.Text = "Показать гистограмму";
            this.ShowGistogrameButton.UseVisualStyleBackColor = true;
            this.ShowGistogrameButton.Click += new System.EventHandler(this.ShowGistogrameButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 488);
            this.Controls.Add(this.ShowGistogrameButton);
            this.Controls.Add(this.AddGroupBox);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.StudentList);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.AddGroupBox.ResumeLayout(false);
            this.AddGroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView StudentList;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.GroupBox AddGroupBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox StudentName;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button ShowGistogrameButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox StudentGroup;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox StudentSpeciality;
    }
}

