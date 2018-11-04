namespace lab2_2
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
            this.inbox = new System.Windows.Forms.RichTextBox();
            this.button = new System.Windows.Forms.Button();
            this.outbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // inbox
            // 
            this.inbox.Location = new System.Drawing.Point(13, 13);
            this.inbox.Name = "inbox";
            this.inbox.Size = new System.Drawing.Size(291, 102);
            this.inbox.TabIndex = 0;
            this.inbox.Text = "";
            // 
            // button
            // 
            this.button.Location = new System.Drawing.Point(13, 122);
            this.button.Name = "button";
            this.button.Size = new System.Drawing.Size(291, 23);
            this.button.TabIndex = 1;
            this.button.Text = "Find longest increasing sequence";
            this.button.UseVisualStyleBackColor = true;
            this.button.Click += new System.EventHandler(this.button_Click);
            // 
            // outbox
            // 
            this.outbox.Location = new System.Drawing.Point(13, 152);
            this.outbox.Name = "outbox";
            this.outbox.Size = new System.Drawing.Size(291, 72);
            this.outbox.TabIndex = 2;
            this.outbox.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 247);
            this.Controls.Add(this.outbox);
            this.Controls.Add(this.button);
            this.Controls.Add(this.inbox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox inbox;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.RichTextBox outbox;
    }
}

