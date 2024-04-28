namespace приложение
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.первое_число = new System.Windows.Forms.TextBox();
            this.второе_число = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.кнопка_для_сложения = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.сс_первого = new System.Windows.Forms.TextBox();
            this.сс_второго = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.сс_ответа = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.кнопка_для_вычитания = new System.Windows.Forms.Button();
            this.кнопка_для_умножения = new System.Windows.Forms.Button();
            this.кнопка_для_деления = new System.Windows.Forms.Button();
            this.кнопка_для_сравнения = new System.Windows.Forms.Button();
            this.кнопка_для_перевода_в10сс = new System.Windows.Forms.Button();
            this.кнопка_для_переводаиз10сс = new System.Windows.Forms.Button();
            this.приколюха = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // первое_число
            // 
            this.первое_число.Location = new System.Drawing.Point(1144, 97);
            this.первое_число.Name = "первое_число";
            this.первое_число.Size = new System.Drawing.Size(170, 39);
            this.первое_число.TabIndex = 1;
            this.первое_число.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // второе_число
            // 
            this.второе_число.Location = new System.Drawing.Point(1144, 173);
            this.второе_число.Name = "второе_число";
            this.второе_число.Size = new System.Drawing.Size(170, 39);
            this.второе_число.TabIndex = 2;
            this.второе_число.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Simplex_IV25", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(763, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(366, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Введите первое число: ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Simplex_IV25", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Purple;
            this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label2.Location = new System.Drawing.Point(764, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 32);
            this.label2.TabIndex = 4;
            this.label2.Text = "Введите второе число: ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // кнопка_для_сложения
            // 
            this.кнопка_для_сложения.AutoSize = true;
            this.кнопка_для_сложения.BackColor = System.Drawing.Color.BlueViolet;
            this.кнопка_для_сложения.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.кнопка_для_сложения.Font = new System.Drawing.Font("Simplex_IV25", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.кнопка_для_сложения.ForeColor = System.Drawing.Color.White;
            this.кнопка_для_сложения.Location = new System.Drawing.Point(99, 438);
            this.кнопка_для_сложения.Name = "кнопка_для_сложения";
            this.кнопка_для_сложения.Size = new System.Drawing.Size(261, 58);
            this.кнопка_для_сложения.TabIndex = 5;
            this.кнопка_для_сложения.Text = "сложение";
            this.кнопка_для_сложения.UseVisualStyleBackColor = false;
            this.кнопка_для_сложения.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Simplex_IV25", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Purple;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(54, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(431, 32);
            this.label3.TabIndex = 6;
            this.label3.Text = "Укажите систему счисления:";
            this.label3.Click += new System.EventHandler(this.label3_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.label4.Font = new System.Drawing.Font("Simplex_IV25", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.Purple;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label4.Location = new System.Drawing.Point(54, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(431, 32);
            this.label4.TabIndex = 7;
            this.label4.Text = "Укажите систему счисления:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // сс_первого
            // 
            this.сс_первого.Location = new System.Drawing.Point(524, 97);
            this.сс_первого.Name = "сс_первого";
            this.сс_первого.Size = new System.Drawing.Size(170, 39);
            this.сс_первого.TabIndex = 8;
            this.сс_первого.TextChanged += new System.EventHandler(this.сс_первого_TextChanged);
            // 
            // сс_второго
            // 
            this.сс_второго.Location = new System.Drawing.Point(524, 169);
            this.сс_второго.Name = "сс_второго";
            this.сс_второго.Size = new System.Drawing.Size(170, 39);
            this.сс_второго.TabIndex = 9;
            this.сс_второго.TextChanged += new System.EventHandler(this.сс_второго_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.label5.Font = new System.Drawing.Font("Simplex_IV25", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.Purple;
            this.label5.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label5.Location = new System.Drawing.Point(321, 268);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(443, 32);
            this.label5.TabIndex = 10;
            this.label5.Text = "В какой СС показать ответ?";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // сс_ответа
            // 
            this.сс_ответа.Location = new System.Drawing.Point(836, 261);
            this.сс_ответа.Name = "сс_ответа";
            this.сс_ответа.Size = new System.Drawing.Size(170, 39);
            this.сс_ответа.TabIndex = 11;
            this.сс_ответа.TextChanged += new System.EventHandler(this.сс_ответа_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.label6.Font = new System.Drawing.Font("Simplex_IV25", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label6.Location = new System.Drawing.Point(54, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(313, 32);
            this.label6.TabIndex = 12;
            this.label6.Text = "Выберите действие:";
            // 
            // кнопка_для_вычитания
            // 
            this.кнопка_для_вычитания.AutoSize = true;
            this.кнопка_для_вычитания.BackColor = System.Drawing.Color.BlueViolet;
            this.кнопка_для_вычитания.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.кнопка_для_вычитания.Font = new System.Drawing.Font("Simplex_IV25", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.кнопка_для_вычитания.ForeColor = System.Drawing.Color.White;
            this.кнопка_для_вычитания.Location = new System.Drawing.Point(408, 438);
            this.кнопка_для_вычитания.Name = "кнопка_для_вычитания";
            this.кнопка_для_вычитания.Size = new System.Drawing.Size(261, 58);
            this.кнопка_для_вычитания.TabIndex = 13;
            this.кнопка_для_вычитания.Text = "вычитание";
            this.кнопка_для_вычитания.UseVisualStyleBackColor = false;
            this.кнопка_для_вычитания.Click += new System.EventHandler(this.кнопка_для_вычитания_Click);
            // 
            // кнопка_для_умножения
            // 
            this.кнопка_для_умножения.AutoSize = true;
            this.кнопка_для_умножения.BackColor = System.Drawing.Color.BlueViolet;
            this.кнопка_для_умножения.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.кнопка_для_умножения.Font = new System.Drawing.Font("Simplex_IV25", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.кнопка_для_умножения.ForeColor = System.Drawing.Color.White;
            this.кнопка_для_умножения.Location = new System.Drawing.Point(717, 438);
            this.кнопка_для_умножения.Name = "кнопка_для_умножения";
            this.кнопка_для_умножения.Size = new System.Drawing.Size(261, 58);
            this.кнопка_для_умножения.TabIndex = 14;
            this.кнопка_для_умножения.Text = "умножение";
            this.кнопка_для_умножения.UseVisualStyleBackColor = false;
            this.кнопка_для_умножения.Click += new System.EventHandler(this.кнопка_для_умножения_Click);
            // 
            // кнопка_для_деления
            // 
            this.кнопка_для_деления.AutoSize = true;
            this.кнопка_для_деления.BackColor = System.Drawing.Color.BlueViolet;
            this.кнопка_для_деления.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.кнопка_для_деления.Font = new System.Drawing.Font("Simplex_IV25", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.кнопка_для_деления.ForeColor = System.Drawing.Color.White;
            this.кнопка_для_деления.Location = new System.Drawing.Point(1040, 438);
            this.кнопка_для_деления.Name = "кнопка_для_деления";
            this.кнопка_для_деления.Size = new System.Drawing.Size(261, 58);
            this.кнопка_для_деления.TabIndex = 15;
            this.кнопка_для_деления.Text = "деление";
            this.кнопка_для_деления.UseVisualStyleBackColor = false;
            this.кнопка_для_деления.Click += new System.EventHandler(this.кнопка_для_деления_Click);
            // 
            // кнопка_для_сравнения
            // 
            this.кнопка_для_сравнения.AutoSize = true;
            this.кнопка_для_сравнения.BackColor = System.Drawing.Color.BlueViolet;
            this.кнопка_для_сравнения.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.кнопка_для_сравнения.Font = new System.Drawing.Font("Simplex_IV25", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.кнопка_для_сравнения.ForeColor = System.Drawing.Color.White;
            this.кнопка_для_сравнения.Location = new System.Drawing.Point(241, 541);
            this.кнопка_для_сравнения.Name = "кнопка_для_сравнения";
            this.кнопка_для_сравнения.Size = new System.Drawing.Size(261, 58);
            this.кнопка_для_сравнения.TabIndex = 16;
            this.кнопка_для_сравнения.Text = "сравнение";
            this.кнопка_для_сравнения.UseVisualStyleBackColor = false;
            this.кнопка_для_сравнения.Click += new System.EventHandler(this.button1_Click);
            // 
            // кнопка_для_перевода_в10сс
            // 
            this.кнопка_для_перевода_в10сс.AutoSize = true;
            this.кнопка_для_перевода_в10сс.BackColor = System.Drawing.Color.BlueViolet;
            this.кнопка_для_перевода_в10сс.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.кнопка_для_перевода_в10сс.Font = new System.Drawing.Font("Simplex_IV25", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.кнопка_для_перевода_в10сс.ForeColor = System.Drawing.Color.White;
            this.кнопка_для_перевода_в10сс.Location = new System.Drawing.Point(567, 541);
            this.кнопка_для_перевода_в10сс.Name = "кнопка_для_перевода_в10сс";
            this.кнопка_для_перевода_в10сс.Size = new System.Drawing.Size(261, 58);
            this.кнопка_для_перевода_в10сс.TabIndex = 17;
            this.кнопка_для_перевода_в10сс.Text = "перевод в 10сс";
            this.кнопка_для_перевода_в10сс.UseVisualStyleBackColor = false;
            this.кнопка_для_перевода_в10сс.Click += new System.EventHandler(this.кнопка_для_переводав10сс_Click);
            // 
            // кнопка_для_переводаиз10сс
            // 
            this.кнопка_для_переводаиз10сс.AutoSize = true;
            this.кнопка_для_переводаиз10сс.BackColor = System.Drawing.Color.BlueViolet;
            this.кнопка_для_переводаиз10сс.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.кнопка_для_переводаиз10сс.Font = new System.Drawing.Font("Simplex_IV25", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.кнопка_для_переводаиз10сс.ForeColor = System.Drawing.Color.White;
            this.кнопка_для_переводаиз10сс.Location = new System.Drawing.Point(896, 541);
            this.кнопка_для_переводаиз10сс.Name = "кнопка_для_переводаиз10сс";
            this.кнопка_для_переводаиз10сс.Size = new System.Drawing.Size(261, 58);
            this.кнопка_для_переводаиз10сс.TabIndex = 18;
            this.кнопка_для_переводаиз10сс.Text = "перевод из 10сс";
            this.кнопка_для_переводаиз10сс.UseVisualStyleBackColor = false;
            this.кнопка_для_переводаиз10сс.Click += new System.EventHandler(this.кнопка_для_переводаиз10сс_Click);
            // 
            // приколюха
            // 
            this.приколюха.AutoSize = true;
            this.приколюха.BackColor = System.Drawing.Color.Plum;
            this.приколюха.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.приколюха.Font = new System.Drawing.Font("Simplex_IV25", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.приколюха.ForeColor = System.Drawing.Color.White;
            this.приколюха.Location = new System.Drawing.Point(1187, 655);
            this.приколюха.Name = "приколюха";
            this.приколюха.Size = new System.Drawing.Size(240, 45);
            this.приколюха.TabIndex = 19;
            this.приколюха.Text = "тыкни сюда с:";
            this.приколюха.UseVisualStyleBackColor = false;
            this.приколюха.Click += new System.EventHandler(this.приколюха_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(220)))), ((int)(((byte)(255)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(1439, 712);
            this.Controls.Add(this.приколюха);
            this.Controls.Add(this.кнопка_для_переводаиз10сс);
            this.Controls.Add(this.кнопка_для_перевода_в10сс);
            this.Controls.Add(this.кнопка_для_сравнения);
            this.Controls.Add(this.кнопка_для_деления);
            this.Controls.Add(this.кнопка_для_умножения);
            this.Controls.Add(this.кнопка_для_вычитания);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.сс_ответа);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.сс_второго);
            this.Controls.Add(this.сс_первого);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.кнопка_для_сложения);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.второе_число);
            this.Controls.Add(this.первое_число);
            this.Font = new System.Drawing.Font("Simplex_IV25", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "приложение :)))";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TextBox первое_число;
        private TextBox второе_число;
        private Label label1;
        private Label label2;
        private Button кнопка_для_сложения;
        private Label label3;
        private Label label4;
        private TextBox сс_первого;
        private TextBox сс_второго;
        private Label label5;
        private TextBox сс_ответа;
        private Label label6;
        private Button кнопка_для_вычитания;
        private Button кнопка_для_умножения;
        private Button кнопка_для_деления;
        private Button кнопка_для_сравнения;
        private Button кнопка_для_перевода_в10сс;
        private Button кнопка_для_переводаиз10сс;
        private Button приколюха;
    }
}