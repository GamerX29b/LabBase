namespace База_банка
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ContactData = new System.Windows.Forms.TextBox();
            this.textAdress = new System.Windows.Forms.TextBox();
            this.TelephoneBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.CreditTipBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SummCreditUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.ProcentUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.LSComboBox = new System.Windows.Forms.ComboBox();
            this.dateTimeIssuance = new System.Windows.Forms.DateTimePicker();
            this.dateTimeBack = new System.Windows.Forms.DateTimePicker();
            this.CreditComboBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SumUpDown3 = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimeRepa = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.ClientName = new System.Windows.Forms.Label();
            this.ClientTel = new System.Windows.Forms.Label();
            this.dataSet12 = new База_банка.DataSet1();
            this.ContactDataLabel = new System.Windows.Forms.Label();
            this.LScomboBox2 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.remainder = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.LsNewClient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.SummCreditUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcentUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SumUpDown3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(40, 128);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Новый клиент";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Контактные данные";
            // 
            // ContactData
            // 
            this.ContactData.Location = new System.Drawing.Point(40, 25);
            this.ContactData.Name = "ContactData";
            this.ContactData.Size = new System.Drawing.Size(100, 20);
            this.ContactData.TabIndex = 2;
            // 
            // textAdress
            // 
            this.textAdress.Location = new System.Drawing.Point(40, 64);
            this.textAdress.Name = "textAdress";
            this.textAdress.Size = new System.Drawing.Size(100, 20);
            this.textAdress.TabIndex = 3;
            // 
            // TelephoneBox
            // 
            this.TelephoneBox.Location = new System.Drawing.Point(40, 102);
            this.TelephoneBox.Name = "TelephoneBox";
            this.TelephoneBox.Size = new System.Drawing.Size(100, 20);
            this.TelephoneBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Адрес";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Телефон";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Новый тип кредита";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(27, 263);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(117, 25);
            this.button2.TabIndex = 8;
            this.button2.Text = "Новый тип кредита";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CreditTipBox
            // 
            this.CreditTipBox.Location = new System.Drawing.Point(38, 237);
            this.CreditTipBox.Name = "CreditTipBox";
            this.CreditTipBox.Size = new System.Drawing.Size(100, 20);
            this.CreditTipBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Выдача кредита";
            // 
            // SummCreditUpDown1
            // 
            this.SummCreditUpDown1.Location = new System.Drawing.Point(236, 36);
            this.SummCreditUpDown1.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.SummCreditUpDown1.Name = "SummCreditUpDown1";
            this.SummCreditUpDown1.Size = new System.Drawing.Size(120, 20);
            this.SummCreditUpDown1.TabIndex = 11;
            // 
            // ProcentUpDown2
            // 
            this.ProcentUpDown2.Location = new System.Drawing.Point(236, 78);
            this.ProcentUpDown2.Name = "ProcentUpDown2";
            this.ProcentUpDown2.Size = new System.Drawing.Size(51, 20);
            this.ProcentUpDown2.TabIndex = 12;
            // 
            // LSComboBox
            // 
            this.LSComboBox.FormattingEnabled = true;
            this.LSComboBox.Location = new System.Drawing.Point(236, 133);
            this.LSComboBox.Name = "LSComboBox";
            this.LSComboBox.Size = new System.Drawing.Size(121, 21);
            this.LSComboBox.TabIndex = 13;
            this.LSComboBox.SelectedIndexChanged += new System.EventHandler(this.LSComboBox_SelectedIndexChanged);
            // 
            // dateTimeIssuance
            // 
            this.dateTimeIssuance.Location = new System.Drawing.Point(381, 36);
            this.dateTimeIssuance.Name = "dateTimeIssuance";
            this.dateTimeIssuance.Size = new System.Drawing.Size(138, 20);
            this.dateTimeIssuance.TabIndex = 14;
            // 
            // dateTimeBack
            // 
            this.dateTimeBack.Location = new System.Drawing.Point(381, 74);
            this.dateTimeBack.Name = "dateTimeBack";
            this.dateTimeBack.Size = new System.Drawing.Size(138, 20);
            this.dateTimeBack.TabIndex = 15;
            // 
            // CreditComboBox
            // 
            this.CreditComboBox.FormattingEnabled = true;
            this.CreditComboBox.Location = new System.Drawing.Point(381, 133);
            this.CreditComboBox.Name = "CreditComboBox";
            this.CreditComboBox.Size = new System.Drawing.Size(121, 21);
            this.CreditComboBox.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(237, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(85, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Сумма кредита";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(237, 58);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Процент";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(378, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Дата выдачи";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(378, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Дата возврата";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(237, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Лицевой счёт";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(378, 116);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Тип кредита";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(606, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Выплата по кредиту";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(335, 192);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 24;
            this.button3.Text = "Новый кредит";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(609, 246);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 25;
            this.button4.Text = "Выплата";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // SumUpDown3
            // 
            this.SumUpDown3.Location = new System.Drawing.Point(609, 79);
            this.SumUpDown3.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
            this.SumUpDown3.Name = "SumUpDown3";
            this.SumUpDown3.Size = new System.Drawing.Size(120, 20);
            this.SumUpDown3.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(606, 64);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(89, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Сумма выплаты";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(606, 21);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(120, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Лицевой счёт кредита";
            // 
            // dateTimeRepa
            // 
            this.dateTimeRepa.Location = new System.Drawing.Point(609, 116);
            this.dateTimeRepa.Name = "dateTimeRepa";
            this.dateTimeRepa.Size = new System.Drawing.Size(121, 20);
            this.dateTimeRepa.TabIndex = 30;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(606, 99);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(81, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Дата выплаты";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(606, 165);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 32;
            this.label16.Text = "Данные клиента";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(606, 202);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(93, 13);
            this.label17.TabIndex = 33;
            this.label17.Text = "Номер телефона";
            // 
            // ClientName
            // 
            this.ClientName.AutoSize = true;
            this.ClientName.Location = new System.Drawing.Point(606, 185);
            this.ClientName.Name = "ClientName";
            this.ClientName.Size = new System.Drawing.Size(0, 13);
            this.ClientName.TabIndex = 34;
            // 
            // ClientTel
            // 
            this.ClientTel.AutoSize = true;
            this.ClientTel.Location = new System.Drawing.Point(606, 221);
            this.ClientTel.Name = "ClientTel";
            this.ClientTel.Size = new System.Drawing.Size(0, 13);
            this.ClientTel.TabIndex = 35;
            // 
            // dataSet12
            // 
            this.dataSet12.DataSetName = "DataSet1";
            this.dataSet12.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ContactDataLabel
            // 
            this.ContactDataLabel.AutoSize = true;
            this.ContactDataLabel.Location = new System.Drawing.Point(237, 165);
            this.ContactDataLabel.Name = "ContactDataLabel";
            this.ContactDataLabel.Size = new System.Drawing.Size(0, 13);
            this.ContactDataLabel.TabIndex = 36;
            // 
            // LScomboBox2
            // 
            this.LScomboBox2.FormattingEnabled = true;
            this.LScomboBox2.Location = new System.Drawing.Point(609, 40);
            this.LScomboBox2.Name = "LScomboBox2";
            this.LScomboBox2.Size = new System.Drawing.Size(121, 21);
            this.LScomboBox2.TabIndex = 37;
            this.LScomboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(741, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 13);
            this.label18.TabIndex = 38;
            this.label18.Text = "Остаток по кредиту";
            // 
            // remainder
            // 
            this.remainder.AutoSize = true;
            this.remainder.Location = new System.Drawing.Point(741, 86);
            this.remainder.Name = "remainder";
            this.remainder.Size = new System.Drawing.Size(0, 13);
            this.remainder.TabIndex = 39;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(37, 154);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(158, 13);
            this.label19.TabIndex = 40;
            this.label19.Text = "Лицевой счёт нового клиента";
            // 
            // LsNewClient
            // 
            this.LsNewClient.AutoSize = true;
            this.LsNewClient.Location = new System.Drawing.Point(37, 167);
            this.LsNewClient.Name = "LsNewClient";
            this.LsNewClient.Size = new System.Drawing.Size(0, 13);
            this.LsNewClient.TabIndex = 41;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(864, 306);
            this.Controls.Add(this.LsNewClient);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.remainder);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.LScomboBox2);
            this.Controls.Add(this.ContactDataLabel);
            this.Controls.Add(this.ClientTel);
            this.Controls.Add(this.ClientName);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dateTimeRepa);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.SumUpDown3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CreditComboBox);
            this.Controls.Add(this.dateTimeBack);
            this.Controls.Add(this.dateTimeIssuance);
            this.Controls.Add(this.LSComboBox);
            this.Controls.Add(this.ProcentUpDown2);
            this.Controls.Add(this.SummCreditUpDown1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CreditTipBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TelephoneBox);
            this.Controls.Add(this.textAdress);
            this.Controls.Add(this.ContactData);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Банк";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SummCreditUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProcentUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SumUpDown3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ContactData;
        private System.Windows.Forms.TextBox textAdress;
        private System.Windows.Forms.TextBox TelephoneBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox CreditTipBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown SummCreditUpDown1;
        private System.Windows.Forms.NumericUpDown ProcentUpDown2;
        private System.Windows.Forms.ComboBox LSComboBox;
        private System.Windows.Forms.DateTimePicker dateTimeIssuance;
        private System.Windows.Forms.DateTimePicker dateTimeBack;
        private System.Windows.Forms.ComboBox CreditComboBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.NumericUpDown SumUpDown3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimeRepa;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label ClientName;
        private System.Windows.Forms.Label ClientTel;
        private DataSet1 dataSet12;
        private System.Windows.Forms.Label ContactDataLabel;
        private System.Windows.Forms.ComboBox LScomboBox2;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label remainder;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label LsNewClient;
    }
}

