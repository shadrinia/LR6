namespace LR6.Forms
{
    partial class FormAddActivity
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
            this.eventBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonAddJuri = new System.Windows.Forms.Button();
            this.buttonAddActivity = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.eventPlanIDComboBox = new System.Windows.Forms.ComboBox();
            this.juriComboBox = new System.Windows.Forms.ComboBox();
            this.ModeratorComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.dayTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // eventBindingSource
            // 
            this.eventBindingSource.DataSource = typeof(LR6.DBCon.Event);
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataSource = typeof(LR6.DBCon.User);
            // 
            // userBindingSource2
            // 
            this.userBindingSource2.DataSource = typeof(LR6.DBCon.User);
            // 
            // buttonBack
            // 
            this.buttonBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack.Location = new System.Drawing.Point(12, 13);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(109, 40);
            this.buttonBack.TabIndex = 0;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonAddJuri
            // 
            this.buttonAddJuri.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddJuri.Location = new System.Drawing.Point(581, 306);
            this.buttonAddJuri.Name = "buttonAddJuri";
            this.buttonAddJuri.Size = new System.Drawing.Size(165, 34);
            this.buttonAddJuri.TabIndex = 1;
            this.buttonAddJuri.Text = "Добавить";
            this.buttonAddJuri.UseVisualStyleBackColor = true;
            this.buttonAddJuri.Click += new System.EventHandler(this.buttonAddJuri_Click);
            // 
            // buttonAddActivity
            // 
            this.buttonAddActivity.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAddActivity.Location = new System.Drawing.Point(151, 373);
            this.buttonAddActivity.Name = "buttonAddActivity";
            this.buttonAddActivity.Size = new System.Drawing.Size(347, 37);
            this.buttonAddActivity.TabIndex = 2;
            this.buttonAddActivity.Text = "Добавить новую активность";
            this.buttonAddActivity.UseVisualStyleBackColor = true;
            this.buttonAddActivity.Click += new System.EventHandler(this.buttonAddActivity_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(198, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 25);
            this.label1.TabIndex = 3;
            this.label1.Text = "Добавление новой активности";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(151, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Название";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(151, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "День";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(151, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "План события";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(151, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Начало мер.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(151, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 25);
            this.label6.TabIndex = 9;
            this.label6.Text = "Жюри";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(151, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 25);
            this.label7.TabIndex = 8;
            this.label7.Text = "Модератор";
            // 
            // eventPlanIDComboBox
            // 
            this.eventPlanIDComboBox.DataSource = this.eventBindingSource;
            this.eventPlanIDComboBox.DisplayMember = "Title";
            this.eventPlanIDComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.eventPlanIDComboBox.FormattingEnabled = true;
            this.eventPlanIDComboBox.Location = new System.Drawing.Point(314, 142);
            this.eventPlanIDComboBox.Name = "eventPlanIDComboBox";
            this.eventPlanIDComboBox.Size = new System.Drawing.Size(242, 21);
            this.eventPlanIDComboBox.TabIndex = 10;
            this.eventPlanIDComboBox.ValueMember = "ID";
            // 
            // juriComboBox
            // 
            this.juriComboBox.DataSource = this.userBindingSource2;
            this.juriComboBox.DisplayMember = "Surname";
            this.juriComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.juriComboBox.FormattingEnabled = true;
            this.juriComboBox.Location = new System.Drawing.Point(314, 311);
            this.juriComboBox.Name = "juriComboBox";
            this.juriComboBox.Size = new System.Drawing.Size(242, 21);
            this.juriComboBox.TabIndex = 11;
            this.juriComboBox.ValueMember = "ID";
            // 
            // ModeratorComboBox
            // 
            this.ModeratorComboBox.DataSource = this.userBindingSource;
            this.ModeratorComboBox.DisplayMember = "Surname";
            this.ModeratorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ModeratorComboBox.FormattingEnabled = true;
            this.ModeratorComboBox.Location = new System.Drawing.Point(314, 268);
            this.ModeratorComboBox.Name = "ModeratorComboBox";
            this.ModeratorComboBox.Size = new System.Drawing.Size(242, 21);
            this.ModeratorComboBox.TabIndex = 12;
            this.ModeratorComboBox.ValueMember = "ID";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker.Location = new System.Drawing.Point(314, 229);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(242, 20);
            this.dateTimePicker.TabIndex = 13;
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(314, 94);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(242, 20);
            this.titleTextBox.TabIndex = 14;
            // 
            // dayTextBox
            // 
            this.dayTextBox.Location = new System.Drawing.Point(314, 188);
            this.dayTextBox.Name = "dayTextBox";
            this.dayTextBox.Size = new System.Drawing.Size(242, 20);
            this.dayTextBox.TabIndex = 15;
            // 
            // FormAddActivity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 443);
            this.Controls.Add(this.dayTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.ModeratorComboBox);
            this.Controls.Add(this.juriComboBox);
            this.Controls.Add(this.eventPlanIDComboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAddActivity);
            this.Controls.Add(this.buttonAddJuri);
            this.Controls.Add(this.buttonBack);
            this.Name = "FormAddActivity";
            this.Text = "FormAddActivity";
            this.Load += new System.EventHandler(this.FormAddActivity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.eventBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource eventBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource;
        private System.Windows.Forms.BindingSource userBindingSource2;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAddJuri;
        private System.Windows.Forms.Button buttonAddActivity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox eventPlanIDComboBox;
        private System.Windows.Forms.ComboBox juriComboBox;
        private System.Windows.Forms.ComboBox ModeratorComboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox dayTextBox;
    }
}