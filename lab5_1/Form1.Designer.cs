namespace lab5_1
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
			this.bApply = new System.Windows.Forms.Button();
			this.outbox = new System.Windows.Forms.ListBox();
			this.SuspendLayout();
			// 
			// inbox
			// 
			this.inbox.Location = new System.Drawing.Point(13, 13);
			this.inbox.Name = "inbox";
			this.inbox.Size = new System.Drawing.Size(103, 20);
			this.inbox.TabIndex = 0;
			// 
			// bApply
			// 
			this.bApply.Location = new System.Drawing.Point(122, 11);
			this.bApply.Name = "bApply";
			this.bApply.Size = new System.Drawing.Size(139, 22);
			this.bApply.TabIndex = 1;
			this.bApply.Text = "Применить";
			this.bApply.UseVisualStyleBackColor = true;
			this.bApply.Click += new System.EventHandler(this.bApply_Click);
			// 
			// outbox
			// 
			this.outbox.FormattingEnabled = true;
			this.outbox.Location = new System.Drawing.Point(13, 40);
			this.outbox.Name = "outbox";
			this.outbox.Size = new System.Drawing.Size(248, 498);
			this.outbox.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(273, 542);
			this.Controls.Add(this.outbox);
			this.Controls.Add(this.bApply);
			this.Controls.Add(this.inbox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox inbox;
		private System.Windows.Forms.Button bApply;
		private System.Windows.Forms.ListBox outbox;
	}
}

