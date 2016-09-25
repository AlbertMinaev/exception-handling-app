namespace exceptionhandlingapp
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
            this.tbzdigit = new System.Windows.Forms.TextBox();
            this.rbdigit = new System.Windows.Forms.RadioButton();
            this.rbdate = new System.Windows.Forms.RadioButton();
            this.rbchar = new System.Windows.Forms.RadioButton();
            this.rbword = new System.Windows.Forms.RadioButton();
            this.btn_check = new System.Windows.Forms.Button();
            this.infolbl = new System.Windows.Forms.Label();
            this.ttpforbtn = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbzword = new System.Windows.Forms.TextBox();
            this.tbzchar = new System.Windows.Forms.TextBox();
            this.tbzdate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbzdigit
            // 
            this.tbzdigit.Location = new System.Drawing.Point(6, 19);
            this.tbzdigit.Name = "tbzdigit";
            this.tbzdigit.Size = new System.Drawing.Size(221, 20);
            this.tbzdigit.TabIndex = 0;
            this.tbzdigit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbz_KeyPress);
            // 
            // rbdigit
            // 
            this.rbdigit.AutoSize = true;
            this.rbdigit.Location = new System.Drawing.Point(6, 19);
            this.rbdigit.Name = "rbdigit";
            this.rbdigit.Size = new System.Drawing.Size(89, 17);
            this.rbdigit.TabIndex = 1;
            this.rbdigit.TabStop = true;
            this.rbdigit.Text = "Целое число";
            this.rbdigit.UseVisualStyleBackColor = true;
            // 
            // rbdate
            // 
            this.rbdate.AutoSize = true;
            this.rbdate.Location = new System.Drawing.Point(6, 42);
            this.rbdate.Name = "rbdate";
            this.rbdate.Size = new System.Drawing.Size(51, 17);
            this.rbdate.TabIndex = 2;
            this.rbdate.TabStop = true;
            this.rbdate.Text = "Дата";
            this.rbdate.UseVisualStyleBackColor = true;
            // 
            // rbchar
            // 
            this.rbchar.AutoSize = true;
            this.rbchar.Location = new System.Drawing.Point(6, 65);
            this.rbchar.Name = "rbchar";
            this.rbchar.Size = new System.Drawing.Size(64, 17);
            this.rbchar.TabIndex = 3;
            this.rbchar.TabStop = true;
            this.rbchar.Text = "Символ";
            this.rbchar.UseVisualStyleBackColor = true;
            // 
            // rbword
            // 
            this.rbword.AutoSize = true;
            this.rbword.Location = new System.Drawing.Point(6, 88);
            this.rbword.Name = "rbword";
            this.rbword.Size = new System.Drawing.Size(206, 17);
            this.rbword.TabIndex = 4;
            this.rbword.TabStop = true;
            this.rbword.Text = "Буквы без сиволов, чисел и знаков";
            this.rbword.UseVisualStyleBackColor = true;
            // 
            // btn_check
            // 
            this.btn_check.Location = new System.Drawing.Point(43, 111);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(149, 23);
            this.btn_check.TabIndex = 5;
            this.btn_check.Text = "Подтвердить";
            this.btn_check.UseVisualStyleBackColor = true;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            this.btn_check.MouseHover += new System.EventHandler(this.btn_check_MouseHover);
            // 
            // infolbl
            // 
            this.infolbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infolbl.Location = new System.Drawing.Point(9, 9);
            this.infolbl.Name = "infolbl";
            this.infolbl.Size = new System.Drawing.Size(343, 23);
            this.infolbl.TabIndex = 6;
            this.infolbl.Text = "Обработка исключений. Демонстрация работы";
            // 
            // ttpforbtn
            // 
            this.ttpforbtn.IsBalloon = true;
            this.ttpforbtn.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.ttpforbtn.ToolTipTitle = "После нажатия на кнопку будет произведена проверка введенного значения в поле выш" +
    "е. В случае, если введенное значение не соответсвует  выбранному типу данных поя" +
    "вится сообщение об этом.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_check);
            this.groupBox1.Controls.Add(this.rbdigit);
            this.groupBox1.Controls.Add(this.rbdate);
            this.groupBox1.Controls.Add(this.rbchar);
            this.groupBox1.Controls.Add(this.rbword);
            this.groupBox1.Location = new System.Drawing.Point(57, 35);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 143);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор типа вводимых данных";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbzword);
            this.groupBox2.Controls.Add(this.tbzchar);
            this.groupBox2.Controls.Add(this.tbzdate);
            this.groupBox2.Controls.Add(this.tbzdigit);
            this.groupBox2.Location = new System.Drawing.Point(57, 184);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(233, 54);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Проверка значений";
            // 
            // tbzword
            // 
            this.tbzword.Location = new System.Drawing.Point(6, 19);
            this.tbzword.Name = "tbzword";
            this.tbzword.Size = new System.Drawing.Size(221, 20);
            this.tbzword.TabIndex = 8;
            this.tbzword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbzword_KeyPress);
            // 
            // tbzchar
            // 
            this.tbzchar.Location = new System.Drawing.Point(6, 19);
            this.tbzchar.Name = "tbzchar";
            this.tbzchar.Size = new System.Drawing.Size(221, 20);
            this.tbzchar.TabIndex = 7;
            this.tbzchar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbzchar_KeyPress);
            // 
            // tbzdate
            // 
            this.tbzdate.Location = new System.Drawing.Point(6, 19);
            this.tbzdate.MaxLength = 10;
            this.tbzdate.Name = "tbzdate";
            this.tbzdate.Size = new System.Drawing.Size(221, 20);
            this.tbzdate.TabIndex = 6;
            this.tbzdate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbzdate_KeyPress);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 254);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.infolbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbzdigit;
        private System.Windows.Forms.RadioButton rbdigit;
        private System.Windows.Forms.RadioButton rbdate;
        private System.Windows.Forms.RadioButton rbchar;
        private System.Windows.Forms.RadioButton rbword;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Label infolbl;
        private System.Windows.Forms.ToolTip ttpforbtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbzword;
        private System.Windows.Forms.TextBox tbzchar;
        private System.Windows.Forms.TextBox tbzdate;
    }
}

