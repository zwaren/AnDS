namespace lab3_1
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
			this.bAdd = new System.Windows.Forms.Button();
			this.bDel = new System.Windows.Forms.Button();
			this.outbox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.outbox)).BeginInit();
			this.SuspendLayout();
			// 
			// inbox
			// 
			this.inbox.Location = new System.Drawing.Point(13, 13);
			this.inbox.Name = "inbox";
			this.inbox.Size = new System.Drawing.Size(253, 20);
			this.inbox.TabIndex = 0;
			// 
			// bAdd
			// 
			this.bAdd.Location = new System.Drawing.Point(272, 13);
			this.bAdd.Name = "bAdd";
			this.bAdd.Size = new System.Drawing.Size(75, 23);
			this.bAdd.TabIndex = 1;
			this.bAdd.Text = "Добавить";
			this.bAdd.UseVisualStyleBackColor = true;
			this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
			// 
			// bDel
			// 
			this.bDel.Location = new System.Drawing.Point(353, 12);
			this.bDel.Name = "bDel";
			this.bDel.Size = new System.Drawing.Size(75, 23);
			this.bDel.TabIndex = 2;
			this.bDel.Text = "Удалить";
			this.bDel.UseVisualStyleBackColor = true;
			this.bDel.Click += new System.EventHandler(this.bDel_Click);
			// 
			// outbox
			// 
			this.outbox.Location = new System.Drawing.Point(13, 40);
			this.outbox.Name = "outbox";
			this.outbox.Size = new System.Drawing.Size(415, 479);
			this.outbox.TabIndex = 3;
			this.outbox.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(440, 531);
			this.Controls.Add(this.outbox);
			this.Controls.Add(this.bDel);
			this.Controls.Add(this.bAdd);
			this.Controls.Add(this.inbox);
			this.Name = "Form1";
			this.Text = "Form1";
			((System.ComponentModel.ISupportInitialize)(this.outbox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox inbox;
		private System.Windows.Forms.Button bAdd;
		private System.Windows.Forms.Button bDel;
		private System.Windows.Forms.PictureBox outbox;
	}
}

