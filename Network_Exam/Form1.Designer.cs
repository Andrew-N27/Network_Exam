namespace Exam
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
            this.tbLink = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAllTegs = new System.Windows.Forms.Button();
            this.btnMaxCouTeg = new System.Windows.Forms.Button();
            this.btnSearchTag = new System.Windows.Forms.Button();
            this.btnConn = new System.Windows.Forms.Button();
            this.tbNameTeg = new System.Windows.Forms.TextBox();
            this.btnSaveF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbLink
            // 
            this.tbLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbLink.Location = new System.Drawing.Point(65, 12);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(563, 26);
            this.tbLink.TabIndex = 0;
            this.tbLink.Text = "http://edda.in.ua/teksti/starsha-edda/pisni-pro-bogiv/povchannia-visokogo";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBox1.Location = new System.Drawing.Point(16, 41);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(694, 351);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Link:";
            // 
            // btnAllTegs
            // 
            this.btnAllTegs.Enabled = false;
            this.btnAllTegs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAllTegs.Location = new System.Drawing.Point(16, 398);
            this.btnAllTegs.Name = "btnAllTegs";
            this.btnAllTegs.Size = new System.Drawing.Size(232, 68);
            this.btnAllTegs.TabIndex = 4;
            this.btnAllTegs.Text = "Все теги";
            this.btnAllTegs.UseVisualStyleBackColor = true;
            this.btnAllTegs.Click += new System.EventHandler(this.btnAllTegs_Click);
            // 
            // btnMaxCouTeg
            // 
            this.btnMaxCouTeg.Enabled = false;
            this.btnMaxCouTeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMaxCouTeg.Location = new System.Drawing.Point(254, 398);
            this.btnMaxCouTeg.Name = "btnMaxCouTeg";
            this.btnMaxCouTeg.Size = new System.Drawing.Size(217, 68);
            this.btnMaxCouTeg.TabIndex = 5;
            this.btnMaxCouTeg.Text = "Макс. кол. тегов";
            this.btnMaxCouTeg.UseVisualStyleBackColor = true;
            this.btnMaxCouTeg.Click += new System.EventHandler(this.btnMaxCouTeg_Click);
            // 
            // btnSearchTag
            // 
            this.btnSearchTag.Enabled = false;
            this.btnSearchTag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSearchTag.Location = new System.Drawing.Point(478, 430);
            this.btnSearchTag.Name = "btnSearchTag";
            this.btnSearchTag.Size = new System.Drawing.Size(232, 36);
            this.btnSearchTag.TabIndex = 6;
            this.btnSearchTag.Text = "Поиск по тегу";
            this.btnSearchTag.UseVisualStyleBackColor = true;
            this.btnSearchTag.Click += new System.EventHandler(this.btnSearchTag_Click);
            // 
            // btnConn
            // 
            this.btnConn.Location = new System.Drawing.Point(634, 12);
            this.btnConn.Name = "btnConn";
            this.btnConn.Size = new System.Drawing.Size(75, 26);
            this.btnConn.TabIndex = 8;
            this.btnConn.Text = "GO";
            this.btnConn.UseVisualStyleBackColor = true;
            this.btnConn.Click += new System.EventHandler(this.btnConn_Click);
            // 
            // tbNameTeg
            // 
            this.tbNameTeg.Enabled = false;
            this.tbNameTeg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNameTeg.Location = new System.Drawing.Point(478, 398);
            this.tbNameTeg.Name = "tbNameTeg";
            this.tbNameTeg.Size = new System.Drawing.Size(231, 26);
            this.tbNameTeg.TabIndex = 9;
            this.tbNameTeg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSaveF
            // 
            this.btnSaveF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSaveF.Location = new System.Drawing.Point(17, 473);
            this.btnSaveF.Name = "btnSaveF";
            this.btnSaveF.Size = new System.Drawing.Size(693, 56);
            this.btnSaveF.TabIndex = 10;
            this.btnSaveF.Text = "Сохранить html страницу в txt файле";
            this.btnSaveF.UseVisualStyleBackColor = true;
            this.btnSaveF.Click += new System.EventHandler(this.btnSaveF_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 541);
            this.Controls.Add(this.btnSaveF);
            this.Controls.Add(this.tbNameTeg);
            this.Controls.Add(this.btnConn);
            this.Controls.Add(this.btnSearchTag);
            this.Controls.Add(this.btnMaxCouTeg);
            this.Controls.Add(this.btnAllTegs);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tbLink);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbLink;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAllTegs;
        private System.Windows.Forms.Button btnMaxCouTeg;
        private System.Windows.Forms.Button btnSearchTag;
        private System.Windows.Forms.Button btnConn;
        private System.Windows.Forms.TextBox tbNameTeg;
        private System.Windows.Forms.Button btnSaveF;
    }
}

