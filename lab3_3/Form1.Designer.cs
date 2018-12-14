namespace lab3_3
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
			this.inbox = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.outbox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// inbox
			// 
			this.inbox.Location = new System.Drawing.Point(13, 13);
			this.inbox.Name = "inbox";
			this.inbox.Size = new System.Drawing.Size(303, 20);
			this.inbox.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(13, 40);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(85, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Создать";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(104, 40);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(100, 23);
			this.button2.TabIndex = 2;
			this.button2.Text = "Добавить";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(210, 40);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(105, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "Подсчитать";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// outbox
			// 
			this.outbox.Location = new System.Drawing.Point(13, 70);
			this.outbox.Name = "outbox";
			this.outbox.Size = new System.Drawing.Size(302, 249);
			this.outbox.TabIndex = 4;
			this.outbox.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(328, 331);
			this.Controls.Add(this.outbox);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.inbox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox inbox;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.RichTextBox outbox;
	}
}

