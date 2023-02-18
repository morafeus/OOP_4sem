namespace lab2
{
    partial class SpecBox
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
            this.label1 = new System.Windows.Forms.Label();
            this.SurnameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SecNameBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LowCourse = new System.Windows.Forms.Button();
            this.CourseLabel = new System.Windows.Forms.Label();
            this.HighCourse = new System.Windows.Forms.Button();
            this.Group = new System.Windows.Forms.Label();
            this.HighButton = new System.Windows.Forms.Button();
            this.GroupLabel = new System.Windows.Forms.Label();
            this.GroupLow = new System.Windows.Forms.Button();
            this.AgePicker = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.AdresButton = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.AverageBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.MaleRadio = new System.Windows.Forms.RadioButton();
            this.FemaleRadio = new System.Windows.Forms.RadioButton();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Json_save = new System.Windows.Forms.Button();
            this.Json_Load = new System.Windows.Forms.Button();
            this.StudentList = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Surname";
            // 
            // SurnameBox
            // 
            this.SurnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SurnameBox.Location = new System.Drawing.Point(110, 37);
            this.SurnameBox.Multiline = true;
            this.SurnameBox.Name = "SurnameBox";
            this.SurnameBox.Size = new System.Drawing.Size(142, 32);
            this.SurnameBox.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name";
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameBox.Location = new System.Drawing.Point(110, 78);
            this.NameBox.Multiline = true;
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(142, 32);
            this.NameBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "SecName";
            // 
            // SecNameBox
            // 
            this.SecNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecNameBox.Location = new System.Drawing.Point(110, 119);
            this.SecNameBox.Multiline = true;
            this.SecNameBox.Name = "SecNameBox";
            this.SecNameBox.Size = new System.Drawing.Size(142, 32);
            this.SecNameBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Course";
            // 
            // LowCourse
            // 
            this.LowCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LowCourse.Location = new System.Drawing.Point(110, 157);
            this.LowCourse.Name = "LowCourse";
            this.LowCourse.Size = new System.Drawing.Size(33, 32);
            this.LowCourse.TabIndex = 9;
            this.LowCourse.Text = "<";
            this.LowCourse.UseVisualStyleBackColor = true;
            this.LowCourse.Click += new System.EventHandler(this.LowCourse_Click);
            // 
            // CourseLabel
            // 
            this.CourseLabel.AutoSize = true;
            this.CourseLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CourseLabel.Location = new System.Drawing.Point(169, 160);
            this.CourseLabel.Name = "CourseLabel";
            this.CourseLabel.Size = new System.Drawing.Size(23, 25);
            this.CourseLabel.TabIndex = 10;
            this.CourseLabel.Text = "0";
            // 
            // HighCourse
            // 
            this.HighCourse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HighCourse.Location = new System.Drawing.Point(219, 157);
            this.HighCourse.Name = "HighCourse";
            this.HighCourse.Size = new System.Drawing.Size(33, 32);
            this.HighCourse.TabIndex = 11;
            this.HighCourse.Text = ">";
            this.HighCourse.UseVisualStyleBackColor = true;
            this.HighCourse.Click += new System.EventHandler(this.HighCourse_Click);
            // 
            // Group
            // 
            this.Group.AutoSize = true;
            this.Group.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Group.Location = new System.Drawing.Point(12, 202);
            this.Group.Name = "Group";
            this.Group.Size = new System.Drawing.Size(66, 25);
            this.Group.TabIndex = 12;
            this.Group.Text = "Group";
            // 
            // HighButton
            // 
            this.HighButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HighButton.Location = new System.Drawing.Point(219, 199);
            this.HighButton.Name = "HighButton";
            this.HighButton.Size = new System.Drawing.Size(33, 32);
            this.HighButton.TabIndex = 15;
            this.HighButton.Text = ">";
            this.HighButton.UseVisualStyleBackColor = true;
            this.HighButton.Click += new System.EventHandler(this.HighButton_Click);
            // 
            // GroupLabel
            // 
            this.GroupLabel.AutoSize = true;
            this.GroupLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupLabel.Location = new System.Drawing.Point(169, 202);
            this.GroupLabel.Name = "GroupLabel";
            this.GroupLabel.Size = new System.Drawing.Size(23, 25);
            this.GroupLabel.TabIndex = 14;
            this.GroupLabel.Text = "0";
            // 
            // GroupLow
            // 
            this.GroupLow.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GroupLow.Location = new System.Drawing.Point(110, 199);
            this.GroupLow.Name = "GroupLow";
            this.GroupLow.Size = new System.Drawing.Size(33, 32);
            this.GroupLow.TabIndex = 13;
            this.GroupLow.Text = "<";
            this.GroupLow.UseVisualStyleBackColor = true;
            this.GroupLow.Click += new System.EventHandler(this.GroupLow_Click);
            // 
            // AgePicker
            // 
            this.AgePicker.Location = new System.Drawing.Point(110, 242);
            this.AgePicker.Name = "AgePicker";
            this.AgePicker.Size = new System.Drawing.Size(142, 22);
            this.AgePicker.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(15, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 25);
            this.label5.TabIndex = 17;
            this.label5.Text = "Age";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(15, 278);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Adres";
            // 
            // AdresButton
            // 
            this.AdresButton.Location = new System.Drawing.Point(110, 278);
            this.AdresButton.Name = "AdresButton";
            this.AdresButton.Size = new System.Drawing.Size(142, 25);
            this.AdresButton.TabIndex = 19;
            this.AdresButton.Text = "Set";
            this.AdresButton.UseVisualStyleBackColor = true;
            this.AdresButton.Click += new System.EventHandler(this.AdresButton_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(15, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 20;
            this.label7.Text = "Average";
            // 
            // AverageBox
            // 
            this.AverageBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AverageBox.Location = new System.Drawing.Point(110, 315);
            this.AverageBox.Multiline = true;
            this.AverageBox.Name = "AverageBox";
            this.AverageBox.Size = new System.Drawing.Size(142, 32);
            this.AverageBox.TabIndex = 21;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(15, 356);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 25);
            this.label8.TabIndex = 22;
            this.label8.Text = "Sex";
            // 
            // MaleRadio
            // 
            this.MaleRadio.AutoSize = true;
            this.MaleRadio.Location = new System.Drawing.Point(110, 361);
            this.MaleRadio.Name = "MaleRadio";
            this.MaleRadio.Size = new System.Drawing.Size(58, 20);
            this.MaleRadio.TabIndex = 23;
            this.MaleRadio.TabStop = true;
            this.MaleRadio.Text = "Male";
            this.MaleRadio.UseVisualStyleBackColor = true;
            // 
            // FemaleRadio
            // 
            this.FemaleRadio.AutoSize = true;
            this.FemaleRadio.Location = new System.Drawing.Point(178, 361);
            this.FemaleRadio.Name = "FemaleRadio";
            this.FemaleRadio.Size = new System.Drawing.Size(74, 20);
            this.FemaleRadio.TabIndex = 24;
            this.FemaleRadio.TabStop = true;
            this.FemaleRadio.Text = "Female";
            this.FemaleRadio.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(20, 397);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(232, 29);
            this.SaveButton.TabIndex = 25;
            this.SaveButton.Text = "Save this student";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Json_save
            // 
            this.Json_save.Location = new System.Drawing.Point(20, 446);
            this.Json_save.Name = "Json_save";
            this.Json_save.Size = new System.Drawing.Size(107, 23);
            this.Json_save.TabIndex = 26;
            this.Json_save.Text = "JsonSave";
            this.Json_save.UseVisualStyleBackColor = true;
            // 
            // Json_Load
            // 
            this.Json_Load.Location = new System.Drawing.Point(144, 446);
            this.Json_Load.Name = "Json_Load";
            this.Json_Load.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Json_Load.Size = new System.Drawing.Size(108, 23);
            this.Json_Load.TabIndex = 27;
            this.Json_Load.Text = "JsonLoad";
            this.Json_Load.UseVisualStyleBackColor = true;
            // 
            // StudentList
            // 
            this.StudentList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StudentList.FormattingEnabled = true;
            this.StudentList.ItemHeight = 18;
            this.StudentList.Location = new System.Drawing.Point(273, 37);
            this.StudentList.Name = "StudentList";
            this.StudentList.Size = new System.Drawing.Size(234, 256);
            this.StudentList.TabIndex = 28;
            // 
            // SpecBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 547);
            this.Controls.Add(this.StudentList);
            this.Controls.Add(this.Json_Load);
            this.Controls.Add(this.Json_save);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.FemaleRadio);
            this.Controls.Add(this.MaleRadio);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.AverageBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.AdresButton);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AgePicker);
            this.Controls.Add(this.HighButton);
            this.Controls.Add(this.GroupLabel);
            this.Controls.Add(this.GroupLow);
            this.Controls.Add(this.Group);
            this.Controls.Add(this.HighCourse);
            this.Controls.Add(this.CourseLabel);
            this.Controls.Add(this.LowCourse);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SecNameBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SurnameBox);
            this.Controls.Add(this.label1);
            this.Name = "SpecBox";
            this.Text = "University";
            this.Load += new System.EventHandler(this.SpecBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox SurnameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox SecNameBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button LowCourse;
        private System.Windows.Forms.Label CourseLabel;
        private System.Windows.Forms.Button HighCourse;
        private System.Windows.Forms.Label Group;
        private System.Windows.Forms.Button HighButton;
        private System.Windows.Forms.Label GroupLabel;
        private System.Windows.Forms.Button GroupLow;
        private System.Windows.Forms.DateTimePicker AgePicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button AdresButton;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox AverageBox;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton MaleRadio;
        private System.Windows.Forms.RadioButton FemaleRadio;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button Json_save;
        private System.Windows.Forms.Button Json_Load;
        private System.Windows.Forms.ListBox StudentList;
    }
}

