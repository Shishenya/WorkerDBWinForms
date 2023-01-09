namespace WorkersDB
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewWorkers = new System.Windows.Forms.DataGridView();
            this.updateAllWorkersBtn = new System.Windows.Forms.Button();
            this.saveDataBtn = new System.Windows.Forms.Button();
            this.Column_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_family = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_birthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column_salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.deleteIndexTextBox = new System.Windows.Forms.TextBox();
            this.deleteWorkerbtn = new System.Windows.Forms.Button();
            this.deleteWorkerLabel = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.nameNewWorkerTextBox = new System.Windows.Forms.TextBox();
            this.familyNewWorkerTextBox = new System.Windows.Forms.TextBox();
            this.positionNewWorkerTextBox = new System.Windows.Forms.TextBox();
            this.birthdayNewWorkerTextBox = new System.Windows.Forms.TextBox();
            this.salaryNewWorkerTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.newWorkerBtn = new System.Windows.Forms.Button();
            this.workerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.saveDataBtn);
            this.groupBox1.Controls.Add(this.updateAllWorkersBtn);
            this.groupBox1.Controls.Add(this.dataGridViewWorkers);
            this.groupBox1.Location = new System.Drawing.Point(21, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(666, 420);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Список сотрудников";
            // 
            // dataGridViewWorkers
            // 
            this.dataGridViewWorkers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewWorkers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column_id,
            this.Column_Name,
            this.Column_family,
            this.Column_position,
            this.Column_birthday,
            this.Column_salary});
            this.dataGridViewWorkers.Location = new System.Drawing.Point(24, 32);
            this.dataGridViewWorkers.Name = "dataGridViewWorkers";
            this.dataGridViewWorkers.Size = new System.Drawing.Size(606, 339);
            this.dataGridViewWorkers.TabIndex = 0;
            this.dataGridViewWorkers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewWorkers_CellContentClick);
            // 
            // updateAllWorkersBtn
            // 
            this.updateAllWorkersBtn.Location = new System.Drawing.Point(24, 379);
            this.updateAllWorkersBtn.Name = "updateAllWorkersBtn";
            this.updateAllWorkersBtn.Size = new System.Drawing.Size(145, 35);
            this.updateAllWorkersBtn.TabIndex = 1;
            this.updateAllWorkersBtn.Text = "Вернть начальные данные";
            this.updateAllWorkersBtn.UseVisualStyleBackColor = true;
            this.updateAllWorkersBtn.Click += new System.EventHandler(this.updateAllWorkersBtn_Click);
            // 
            // saveDataBtn
            // 
            this.saveDataBtn.Location = new System.Drawing.Point(485, 379);
            this.saveDataBtn.Name = "saveDataBtn";
            this.saveDataBtn.Size = new System.Drawing.Size(145, 35);
            this.saveDataBtn.TabIndex = 2;
            this.saveDataBtn.Text = "Сохранить изменения";
            this.saveDataBtn.UseVisualStyleBackColor = true;
            this.saveDataBtn.Click += new System.EventHandler(this.saveDataBtn_Click);
            // 
            // Column_id
            // 
            this.Column_id.HeaderText = "ID";
            this.Column_id.Name = "Column_id";
            this.Column_id.ReadOnly = true;
            this.Column_id.Width = 40;
            // 
            // Column_Name
            // 
            this.Column_Name.HeaderText = "Имя";
            this.Column_Name.Name = "Column_Name";
            // 
            // Column_family
            // 
            this.Column_family.HeaderText = "Фамилия";
            this.Column_family.Name = "Column_family";
            // 
            // Column_position
            // 
            this.Column_position.HeaderText = "Должность";
            this.Column_position.Name = "Column_position";
            // 
            // Column_birthday
            // 
            this.Column_birthday.HeaderText = "Год рождения";
            this.Column_birthday.Name = "Column_birthday";
            this.Column_birthday.Width = 120;
            // 
            // Column_salary
            // 
            this.Column_salary.HeaderText = "Зарплата";
            this.Column_salary.Name = "Column_salary";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.deleteWorkerLabel);
            this.groupBox2.Controls.Add(this.deleteWorkerbtn);
            this.groupBox2.Controls.Add(this.deleteIndexTextBox);
            this.groupBox2.Location = new System.Drawing.Point(713, 16);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(281, 98);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Удаление сотрудника";
            // 
            // deleteIndexTextBox
            // 
            this.deleteIndexTextBox.Location = new System.Drawing.Point(145, 33);
            this.deleteIndexTextBox.Name = "deleteIndexTextBox";
            this.deleteIndexTextBox.Size = new System.Drawing.Size(104, 20);
            this.deleteIndexTextBox.TabIndex = 0;
            // 
            // deleteWorkerbtn
            // 
            this.deleteWorkerbtn.Location = new System.Drawing.Point(41, 58);
            this.deleteWorkerbtn.Name = "deleteWorkerbtn";
            this.deleteWorkerbtn.Size = new System.Drawing.Size(208, 25);
            this.deleteWorkerbtn.TabIndex = 1;
            this.deleteWorkerbtn.Text = "Удалить";
            this.deleteWorkerbtn.UseVisualStyleBackColor = true;
            this.deleteWorkerbtn.Click += new System.EventHandler(this.deleteWorkerbtn_Click);
            // 
            // deleteWorkerLabel
            // 
            this.deleteWorkerLabel.AutoSize = true;
            this.deleteWorkerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteWorkerLabel.Location = new System.Drawing.Point(38, 33);
            this.deleteWorkerLabel.Name = "deleteWorkerLabel";
            this.deleteWorkerLabel.Size = new System.Drawing.Size(101, 17);
            this.deleteWorkerLabel.TabIndex = 2;
            this.deleteWorkerLabel.Text = "ID сотрудника";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.newWorkerBtn);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.salaryNewWorkerTextBox);
            this.groupBox3.Controls.Add(this.birthdayNewWorkerTextBox);
            this.groupBox3.Controls.Add(this.positionNewWorkerTextBox);
            this.groupBox3.Controls.Add(this.familyNewWorkerTextBox);
            this.groupBox3.Controls.Add(this.nameNewWorkerTextBox);
            this.groupBox3.Location = new System.Drawing.Point(715, 127);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(279, 308);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Добавление нового сотрудника";
            // 
            // nameNewWorkerTextBox
            // 
            this.nameNewWorkerTextBox.Location = new System.Drawing.Point(104, 26);
            this.nameNewWorkerTextBox.Name = "nameNewWorkerTextBox";
            this.nameNewWorkerTextBox.Size = new System.Drawing.Size(155, 20);
            this.nameNewWorkerTextBox.TabIndex = 0;
            // 
            // familyNewWorkerTextBox
            // 
            this.familyNewWorkerTextBox.Location = new System.Drawing.Point(104, 63);
            this.familyNewWorkerTextBox.Name = "familyNewWorkerTextBox";
            this.familyNewWorkerTextBox.Size = new System.Drawing.Size(155, 20);
            this.familyNewWorkerTextBox.TabIndex = 1;
            // 
            // positionNewWorkerTextBox
            // 
            this.positionNewWorkerTextBox.Location = new System.Drawing.Point(104, 103);
            this.positionNewWorkerTextBox.Name = "positionNewWorkerTextBox";
            this.positionNewWorkerTextBox.Size = new System.Drawing.Size(155, 20);
            this.positionNewWorkerTextBox.TabIndex = 2;
            // 
            // birthdayNewWorkerTextBox
            // 
            this.birthdayNewWorkerTextBox.Location = new System.Drawing.Point(104, 142);
            this.birthdayNewWorkerTextBox.Name = "birthdayNewWorkerTextBox";
            this.birthdayNewWorkerTextBox.Size = new System.Drawing.Size(155, 20);
            this.birthdayNewWorkerTextBox.TabIndex = 3;
            // 
            // salaryNewWorkerTextBox
            // 
            this.salaryNewWorkerTextBox.Location = new System.Drawing.Point(104, 182);
            this.salaryNewWorkerTextBox.Name = "salaryNewWorkerTextBox";
            this.salaryNewWorkerTextBox.Size = new System.Drawing.Size(155, 20);
            this.salaryNewWorkerTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(59, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(17, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Должность";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(59, 145);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Год";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(22, 185);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "Зарплата";
            // 
            // newWorkerBtn
            // 
            this.newWorkerBtn.Location = new System.Drawing.Point(67, 227);
            this.newWorkerBtn.Name = "newWorkerBtn";
            this.newWorkerBtn.Size = new System.Drawing.Size(167, 33);
            this.newWorkerBtn.TabIndex = 10;
            this.newWorkerBtn.Text = "Добавить сотрудника";
            this.newWorkerBtn.UseVisualStyleBackColor = true;
            this.newWorkerBtn.Click += new System.EventHandler(this.newWorkerBtn_Click);
            // 
            // workerBindingSource
            // 
            this.workerBindingSource.DataSource = typeof(WorkersDB.Models.Worker);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 461);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Демо проект";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewWorkers)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.workerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource workerBindingSource;
        private System.Windows.Forms.DataGridView dataGridViewWorkers;
        private System.Windows.Forms.Button updateAllWorkersBtn;
        private System.Windows.Forms.Button saveDataBtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_family;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_birthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column_salary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label deleteWorkerLabel;
        private System.Windows.Forms.Button deleteWorkerbtn;
        private System.Windows.Forms.TextBox deleteIndexTextBox;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox salaryNewWorkerTextBox;
        private System.Windows.Forms.TextBox birthdayNewWorkerTextBox;
        private System.Windows.Forms.TextBox positionNewWorkerTextBox;
        private System.Windows.Forms.TextBox familyNewWorkerTextBox;
        private System.Windows.Forms.TextBox nameNewWorkerTextBox;
        private System.Windows.Forms.Button newWorkerBtn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

