namespace AboutPC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WindowsVersion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Processor = new System.Windows.Forms.Label();
            this.Videocard = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UserName = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.PCName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.RAMCapacity = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.logoBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).BeginInit();
            this.SuspendLayout();
            // 
            // WindowsVersion
            // 
            this.WindowsVersion.AutoSize = true;
            this.WindowsVersion.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WindowsVersion.Location = new System.Drawing.Point(140, 37);
            this.WindowsVersion.Name = "WindowsVersion";
            this.WindowsVersion.Size = new System.Drawing.Size(113, 13);
            this.WindowsVersion.TabIndex = 1;
            this.WindowsVersion.Text = "$WindowsVersion$";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(11, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ОС:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Процессор: ";
            // 
            // Processor
            // 
            this.Processor.AutoSize = true;
            this.Processor.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Processor.Location = new System.Drawing.Point(104, 135);
            this.Processor.Name = "Processor";
            this.Processor.Size = new System.Drawing.Size(83, 13);
            this.Processor.TabIndex = 4;
            this.Processor.Text = "$Proccessor$";
            // 
            // Videocard
            // 
            this.Videocard.AutoSize = true;
            this.Videocard.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Videocard.Location = new System.Drawing.Point(104, 160);
            this.Videocard.Name = "Videocard";
            this.Videocard.Size = new System.Drawing.Size(78, 13);
            this.Videocard.TabIndex = 6;
            this.Videocard.Text = "$Videocard$";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Видеокарта: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(66, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 18);
            this.label5.TabIndex = 7;
            this.label5.Text = "Об ОС";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(11, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(123, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Имя пользователя: ";
            // 
            // UserName
            // 
            this.UserName.AutoSize = true;
            this.UserName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.UserName.Location = new System.Drawing.Point(140, 59);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(80, 13);
            this.UserName.TabIndex = 8;
            this.UserName.Text = "$UserName$";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.Location = new System.Drawing.Point(11, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Имя ПК: ";
            // 
            // PCName
            // 
            this.PCName.AutoSize = true;
            this.PCName.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PCName.Location = new System.Drawing.Point(140, 81);
            this.PCName.Name = "PCName";
            this.PCName.Size = new System.Drawing.Size(70, 13);
            this.PCName.TabIndex = 10;
            this.PCName.Text = "$PCName$";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.Location = new System.Drawing.Point(47, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 18);
            this.label10.TabIndex = 12;
            this.label10.Text = "Характеристики";
            // 
            // RAMCapacity
            // 
            this.RAMCapacity.AutoSize = true;
            this.RAMCapacity.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RAMCapacity.Location = new System.Drawing.Point(104, 184);
            this.RAMCapacity.Name = "RAMCapacity";
            this.RAMCapacity.Size = new System.Drawing.Size(96, 13);
            this.RAMCapacity.TabIndex = 14;
            this.RAMCapacity.Text = "$RAMCapacity$";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label11.Location = new System.Drawing.Point(12, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "ОЗУ: ";
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::AboutPC.Properties.Resources.Settings_16x;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Location = new System.Drawing.Point(665, 269);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 24);
            this.button1.TabIndex = 15;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // logoBox
            // 
            this.logoBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoBox.Location = new System.Drawing.Point(538, 12);
            this.logoBox.Name = "logoBox";
            this.logoBox.Size = new System.Drawing.Size(151, 137);
            this.logoBox.TabIndex = 0;
            this.logoBox.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.RAMCapacity);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.PCName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Videocard);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Processor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WindowsVersion);
            this.Controls.Add(this.logoBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Об моём компьютере";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox logoBox;
        private System.Windows.Forms.Label WindowsVersion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Processor;
        private System.Windows.Forms.Label Videocard;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label UserName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label PCName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label RAMCapacity;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
    }
}

