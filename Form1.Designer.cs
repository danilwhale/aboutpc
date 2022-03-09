using AboutPC;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.WinInfoTitle = new System.Windows.Forms.Label();
            this.WinVerLab = new System.Windows.Forms.Label();
            this.WindowsVersion = new System.Windows.Forms.Label();
            this.WinEdLab = new System.Windows.Forms.Label();
            this.WindowsEdition = new System.Windows.Forms.Label();
            this.WinArchLab = new System.Windows.Forms.Label();
            this.WindowsArch = new System.Windows.Forms.Label();
            this.WindowsBuild = new System.Windows.Forms.Label();
            this.WinBuildLab = new System.Windows.Forms.Label();
            this.EnvironmentTitle = new System.Windows.Forms.Label();
            this.UsrnmLab = new System.Windows.Forms.Label();
            this.PCNLab = new System.Windows.Forms.Label();
            this.Username = new System.Windows.Forms.Label();
            this.PCName = new System.Windows.Forms.Label();
            this.CPUs = new System.Windows.Forms.Label();
            this.CPULab = new System.Windows.Forms.Label();
            this.PCTitle = new System.Windows.Forms.Label();
            this.GPUs = new System.Windows.Forms.Label();
            this.GPULab = new System.Windows.Forms.Label();
            this.RAMs = new System.Windows.Forms.Label();
            this.RAMLab = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.LogoBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.sdsdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свернутьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.закрытьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.оПрограммеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // WinInfoTitle
            // 
            this.WinInfoTitle.AutoSize = true;
            this.WinInfoTitle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WinInfoTitle.ForeColor = System.Drawing.Color.White;
            this.WinInfoTitle.Location = new System.Drawing.Point(91, 36);
            this.WinInfoTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WinInfoTitle.Name = "WinInfoTitle";
            this.WinInfoTitle.Size = new System.Drawing.Size(185, 22);
            this.WinInfoTitle.TabIndex = 0;
            this.WinInfoTitle.Text = "Информация Windows";
            // 
            // WinVerLab
            // 
            this.WinVerLab.AutoSize = true;
            this.WinVerLab.ForeColor = System.Drawing.Color.White;
            this.WinVerLab.Location = new System.Drawing.Point(13, 69);
            this.WinVerLab.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.WinVerLab.Name = "WinVerLab";
            this.WinVerLab.Size = new System.Drawing.Size(52, 18);
            this.WinVerLab.TabIndex = 1;
            this.WinVerLab.Text = "Версия:";
            // 
            // WindowsVersion
            // 
            this.WindowsVersion.AutoSize = true;
            this.WindowsVersion.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WindowsVersion.ForeColor = System.Drawing.Color.White;
            this.WindowsVersion.Location = new System.Drawing.Point(133, 69);
            this.WindowsVersion.Name = "WindowsVersion";
            this.WindowsVersion.Size = new System.Drawing.Size(108, 18);
            this.WindowsVersion.TabIndex = 2;
            this.WindowsVersion.Text = "$WindowsVersion$";
            // 
            // WinEdLab
            // 
            this.WinEdLab.AutoSize = true;
            this.WinEdLab.ForeColor = System.Drawing.Color.White;
            this.WinEdLab.Location = new System.Drawing.Point(13, 87);
            this.WinEdLab.Name = "WinEdLab";
            this.WinEdLab.Size = new System.Drawing.Size(59, 18);
            this.WinEdLab.TabIndex = 3;
            this.WinEdLab.Text = "Издание:";
            // 
            // WindowsEdition
            // 
            this.WindowsEdition.AutoSize = true;
            this.WindowsEdition.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WindowsEdition.ForeColor = System.Drawing.Color.White;
            this.WindowsEdition.Location = new System.Drawing.Point(133, 87);
            this.WindowsEdition.Name = "WindowsEdition";
            this.WindowsEdition.Size = new System.Drawing.Size(108, 18);
            this.WindowsEdition.TabIndex = 4;
            this.WindowsEdition.Text = "$WindowsEdition$";
            // 
            // WinArchLab
            // 
            this.WinArchLab.AutoSize = true;
            this.WinArchLab.ForeColor = System.Drawing.Color.White;
            this.WinArchLab.Location = new System.Drawing.Point(13, 105);
            this.WinArchLab.Name = "WinArchLab";
            this.WinArchLab.Size = new System.Drawing.Size(81, 18);
            this.WinArchLab.TabIndex = 5;
            this.WinArchLab.Text = "Архитектура:";
            // 
            // WindowsArch
            // 
            this.WindowsArch.AutoSize = true;
            this.WindowsArch.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WindowsArch.ForeColor = System.Drawing.Color.White;
            this.WindowsArch.Location = new System.Drawing.Point(133, 105);
            this.WindowsArch.Name = "WindowsArch";
            this.WindowsArch.Size = new System.Drawing.Size(95, 18);
            this.WindowsArch.TabIndex = 6;
            this.WindowsArch.Text = "$WindowsArch$";
            // 
            // WindowsBuild
            // 
            this.WindowsBuild.AutoSize = true;
            this.WindowsBuild.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.WindowsBuild.ForeColor = System.Drawing.Color.White;
            this.WindowsBuild.Location = new System.Drawing.Point(133, 123);
            this.WindowsBuild.Name = "WindowsBuild";
            this.WindowsBuild.Size = new System.Drawing.Size(98, 18);
            this.WindowsBuild.TabIndex = 9;
            this.WindowsBuild.Text = "$WindowsBuild$";
            // 
            // WinBuildLab
            // 
            this.WinBuildLab.AutoSize = true;
            this.WinBuildLab.ForeColor = System.Drawing.Color.White;
            this.WinBuildLab.Location = new System.Drawing.Point(13, 123);
            this.WinBuildLab.Name = "WinBuildLab";
            this.WinBuildLab.Size = new System.Drawing.Size(40, 18);
            this.WinBuildLab.TabIndex = 8;
            this.WinBuildLab.Text = "Билд:";
            // 
            // EnvironmentTitle
            // 
            this.EnvironmentTitle.AutoSize = true;
            this.EnvironmentTitle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EnvironmentTitle.ForeColor = System.Drawing.Color.White;
            this.EnvironmentTitle.Location = new System.Drawing.Point(82, 176);
            this.EnvironmentTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EnvironmentTitle.Name = "EnvironmentTitle";
            this.EnvironmentTitle.Size = new System.Drawing.Size(202, 22);
            this.EnvironmentTitle.TabIndex = 10;
            this.EnvironmentTitle.Text = "Информация окружения";
            // 
            // UsrnmLab
            // 
            this.UsrnmLab.AutoSize = true;
            this.UsrnmLab.ForeColor = System.Drawing.Color.White;
            this.UsrnmLab.Location = new System.Drawing.Point(13, 208);
            this.UsrnmLab.Name = "UsrnmLab";
            this.UsrnmLab.Size = new System.Drawing.Size(114, 18);
            this.UsrnmLab.TabIndex = 11;
            this.UsrnmLab.Text = "Имя пользователя:";
            // 
            // PCNLab
            // 
            this.PCNLab.AutoSize = true;
            this.PCNLab.ForeColor = System.Drawing.Color.White;
            this.PCNLab.Location = new System.Drawing.Point(13, 226);
            this.PCNLab.Name = "PCNLab";
            this.PCNLab.Size = new System.Drawing.Size(106, 18);
            this.PCNLab.TabIndex = 12;
            this.PCNLab.Text = "Имя компьютера:";
            // 
            // Username
            // 
            this.Username.AutoSize = true;
            this.Username.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Username.ForeColor = System.Drawing.Color.White;
            this.Username.Location = new System.Drawing.Point(133, 208);
            this.Username.Name = "Username";
            this.Username.Size = new System.Drawing.Size(74, 18);
            this.Username.TabIndex = 13;
            this.Username.Text = "$Username$";
            // 
            // PCName
            // 
            this.PCName.AutoSize = true;
            this.PCName.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PCName.ForeColor = System.Drawing.Color.White;
            this.PCName.Location = new System.Drawing.Point(133, 226);
            this.PCName.Name = "PCName";
            this.PCName.Size = new System.Drawing.Size(65, 18);
            this.PCName.TabIndex = 14;
            this.PCName.Text = "$PCName$";
            // 
            // CPUs
            // 
            this.CPUs.AutoSize = true;
            this.CPUs.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CPUs.ForeColor = System.Drawing.Color.White;
            this.CPUs.Location = new System.Drawing.Point(133, 290);
            this.CPUs.Name = "CPUs";
            this.CPUs.Size = new System.Drawing.Size(42, 18);
            this.CPUs.TabIndex = 19;
            this.CPUs.Text = "$CPU$";
            // 
            // CPULab
            // 
            this.CPULab.AutoSize = true;
            this.CPULab.ForeColor = System.Drawing.Color.White;
            this.CPULab.Location = new System.Drawing.Point(7, 290);
            this.CPULab.Name = "CPULab";
            this.CPULab.Size = new System.Drawing.Size(28, 18);
            this.CPULab.TabIndex = 17;
            this.CPULab.Text = "ЦП:";
            // 
            // PCTitle
            // 
            this.PCTitle.AutoSize = true;
            this.PCTitle.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PCTitle.ForeColor = System.Drawing.Color.White;
            this.PCTitle.Location = new System.Drawing.Point(71, 258);
            this.PCTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PCTitle.Name = "PCTitle";
            this.PCTitle.Size = new System.Drawing.Size(213, 22);
            this.PCTitle.TabIndex = 16;
            this.PCTitle.Text = "Информация компьютера";
            // 
            // GPUs
            // 
            this.GPUs.AutoSize = true;
            this.GPUs.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.GPUs.ForeColor = System.Drawing.Color.White;
            this.GPUs.Location = new System.Drawing.Point(133, 308);
            this.GPUs.Name = "GPUs";
            this.GPUs.Size = new System.Drawing.Size(43, 18);
            this.GPUs.TabIndex = 21;
            this.GPUs.Text = "$GPU$";
            // 
            // GPULab
            // 
            this.GPULab.AutoSize = true;
            this.GPULab.ForeColor = System.Drawing.Color.White;
            this.GPULab.Location = new System.Drawing.Point(7, 308);
            this.GPULab.Name = "GPULab";
            this.GPULab.Size = new System.Drawing.Size(26, 18);
            this.GPULab.TabIndex = 20;
            this.GPULab.Text = "ГП:";
            // 
            // RAMs
            // 
            this.RAMs.AutoSize = true;
            this.RAMs.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RAMs.ForeColor = System.Drawing.Color.White;
            this.RAMs.Location = new System.Drawing.Point(133, 326);
            this.RAMs.Name = "RAMs";
            this.RAMs.Size = new System.Drawing.Size(44, 18);
            this.RAMs.TabIndex = 23;
            this.RAMs.Text = "$RAM$";
            // 
            // RAMLab
            // 
            this.RAMLab.AutoSize = true;
            this.RAMLab.ForeColor = System.Drawing.Color.White;
            this.RAMLab.Location = new System.Drawing.Point(7, 326);
            this.RAMLab.Name = "RAMLab";
            this.RAMLab.Size = new System.Drawing.Size(33, 18);
            this.RAMLab.TabIndex = 22;
            this.RAMLab.Text = "ОЗУ:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.panel1.Controls.Add(this.LogoBox);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 27);
            this.panel1.TabIndex = 24;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.contextMenuStrip1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sdsdToolStripMenuItem,
            this.toolStripSeparator1,
            this.свернутьToolStripMenuItem,
            this.закрытьToolStripMenuItem,
            this.toolStripSeparator2,
            this.оПрограммеToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.contextMenuStrip1.Size = new System.Drawing.Size(225, 126);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(221, 6);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(221, 6);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "*.txt";
            this.saveFileDialog1.FileName = "sys-info";
            this.saveFileDialog1.Filter = "Текстовой документ|*.txt|Все файлы|*.*";
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // LogoBox
            // 
            this.LogoBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LogoBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.LogoBox.Location = new System.Drawing.Point(27, 0);
            this.LogoBox.Name = "LogoBox";
            this.LogoBox.Size = new System.Drawing.Size(27, 27);
            this.LogoBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.LogoBox.TabIndex = 7;
            this.LogoBox.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.ContextMenuStrip = this.contextMenuStrip1;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(27, 27);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Right;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(12)))), ((int)(((byte)(12)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(313, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 27);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(340, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 27);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // sdsdToolStripMenuItem
            // 
            this.sdsdToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sdsdToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sdsdToolStripMenuItem.Image")));
            this.sdsdToolStripMenuItem.Name = "sdsdToolStripMenuItem";
            this.sdsdToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.sdsdToolStripMenuItem.Text = "Сохранить информацию...";
            this.sdsdToolStripMenuItem.Click += new System.EventHandler(this.sdsdToolStripMenuItem_Click);
            // 
            // свернутьToolStripMenuItem
            // 
            this.свернутьToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.свернутьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("свернутьToolStripMenuItem.Image")));
            this.свернутьToolStripMenuItem.Name = "свернутьToolStripMenuItem";
            this.свернутьToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.свернутьToolStripMenuItem.Text = "Свернуть";
            this.свернутьToolStripMenuItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // закрытьToolStripMenuItem
            // 
            this.закрытьToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.закрытьToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("закрытьToolStripMenuItem.Image")));
            this.закрытьToolStripMenuItem.Name = "закрытьToolStripMenuItem";
            this.закрытьToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.закрытьToolStripMenuItem.Text = "Закрыть";
            this.закрытьToolStripMenuItem.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // оПрограммеToolStripMenuItem
            // 
            this.оПрограммеToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.оПрограммеToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("оПрограммеToolStripMenuItem.Image")));
            this.оПрограммеToolStripMenuItem.Name = "оПрограммеToolStripMenuItem";
            this.оПрограммеToolStripMenuItem.Size = new System.Drawing.Size(224, 22);
            this.оПрограммеToolStripMenuItem.Text = "О программе";
            this.оПрограммеToolStripMenuItem.Click += new System.EventHandler(this.оПрограммеToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(16)))));
            this.ClientSize = new System.Drawing.Size(367, 361);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.RAMs);
            this.Controls.Add(this.RAMLab);
            this.Controls.Add(this.GPUs);
            this.Controls.Add(this.GPULab);
            this.Controls.Add(this.CPUs);
            this.Controls.Add(this.CPULab);
            this.Controls.Add(this.PCTitle);
            this.Controls.Add(this.PCName);
            this.Controls.Add(this.Username);
            this.Controls.Add(this.PCNLab);
            this.Controls.Add(this.UsrnmLab);
            this.Controls.Add(this.EnvironmentTitle);
            this.Controls.Add(this.WindowsBuild);
            this.Controls.Add(this.WinBuildLab);
            this.Controls.Add(this.WindowsArch);
            this.Controls.Add(this.WinArchLab);
            this.Controls.Add(this.WindowsEdition);
            this.Controls.Add(this.WinEdLab);
            this.Controls.Add(this.WindowsVersion);
            this.Controls.Add(this.WinVerLab);
            this.Controls.Add(this.WinInfoTitle);
            this.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "О компьютере";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogoBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WinInfoTitle;
        private System.Windows.Forms.Label WinVerLab;
        private System.Windows.Forms.Label WindowsVersion;
        private System.Windows.Forms.Label WinEdLab;
        private System.Windows.Forms.Label WindowsEdition;
        private System.Windows.Forms.Label WinArchLab;
        private System.Windows.Forms.Label WindowsArch;
        private System.Windows.Forms.PictureBox LogoBox;
        private System.Windows.Forms.Label WindowsBuild;
        private System.Windows.Forms.Label WinBuildLab;
        private System.Windows.Forms.Label EnvironmentTitle;
        private System.Windows.Forms.Label UsrnmLab;
        private System.Windows.Forms.Label PCNLab;
        private System.Windows.Forms.Label Username;
        private System.Windows.Forms.Label PCName;
        private System.Windows.Forms.Label CPUs;
        private System.Windows.Forms.Label CPULab;
        private System.Windows.Forms.Label PCTitle;
        private System.Windows.Forms.Label GPUs;
        private System.Windows.Forms.Label GPULab;
        private System.Windows.Forms.Label RAMs;
        private System.Windows.Forms.Label RAMLab;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sdsdToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem свернутьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem закрытьToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem оПрограммеToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

