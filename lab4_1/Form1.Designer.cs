namespace lab4_1
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
			this.keybox = new System.Windows.Forms.TextBox();
			this.valuebox = new System.Windows.Forms.TextBox();
			this.bInsert = new System.Windows.Forms.Button();
			this.listbox = new System.Windows.Forms.ListBox();
			this.bDelete = new System.Windows.Forms.Button();
			this.outbox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// keybox
			// 
			this.keybox.Location = new System.Drawing.Point(13, 13);
			this.keybox.Name = "keybox";
			this.keybox.Size = new System.Drawing.Size(100, 20);
			this.keybox.TabIndex = 0;
			// 
			// valuebox
			// 
			this.valuebox.Location = new System.Drawing.Point(120, 13);
			this.valuebox.Name = "valuebox";
			this.valuebox.Size = new System.Drawing.Size(101, 20);
			this.valuebox.TabIndex = 1;
			// 
			// bInsert
			// 
			this.bInsert.Location = new System.Drawing.Point(13, 40);
			this.bInsert.Name = "bInsert";
			this.bInsert.Size = new System.Drawing.Size(100, 23);
			this.bInsert.TabIndex = 2;
			this.bInsert.Text = "Insert";
			this.bInsert.UseVisualStyleBackColor = true;
			this.bInsert.Click += new System.EventHandler(this.bInsert_Click);
			// 
			// listbox
			// 
			this.listbox.FormattingEnabled = true;
			this.listbox.Location = new System.Drawing.Point(227, 13);
			this.listbox.Name = "listbox";
			this.listbox.Size = new System.Drawing.Size(251, 433);
			this.listbox.TabIndex = 3;
			this.listbox.SelectedIndexChanged += new System.EventHandler(this.listbox_SelectedIndexChanged);
			// 
			// bDelete
			// 
			this.bDelete.Location = new System.Drawing.Point(120, 40);
			this.bDelete.Name = "bDelete";
			this.bDelete.Size = new System.Drawing.Size(101, 23);
			this.bDelete.TabIndex = 4;
			this.bDelete.Text = "Delete";
			this.bDelete.UseVisualStyleBackColor = true;
			this.bDelete.Click += new System.EventHandler(this.bDelete_Click);
			// 
			// outbox
			// 
			this.outbox.Location = new System.Drawing.Point(13, 70);
			this.outbox.Name = "outbox";
			this.outbox.Size = new System.Drawing.Size(208, 100);
			this.outbox.TabIndex = 5;
			this.outbox.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(490, 463);
			this.Controls.Add(this.outbox);
			this.Controls.Add(this.bDelete);
			this.Controls.Add(this.listbox);
			this.Controls.Add(this.bInsert);
			this.Controls.Add(this.valuebox);
			this.Controls.Add(this.keybox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox keybox;
		private System.Windows.Forms.TextBox valuebox;
		private System.Windows.Forms.Button bInsert;
		private System.Windows.Forms.ListBox listbox;
		private System.Windows.Forms.Button bDelete;
		private System.Windows.Forms.RichTextBox outbox;
	}
}

