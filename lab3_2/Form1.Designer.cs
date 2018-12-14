namespace lab3_2
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
			this.bCalc = new System.Windows.Forms.Button();
			this.outbox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// inbox
			// 
			this.inbox.Location = new System.Drawing.Point(13, 13);
			this.inbox.Name = "inbox";
			this.inbox.Size = new System.Drawing.Size(311, 20);
			this.inbox.TabIndex = 0;
			// 
			// bAdd
			// 
			this.bAdd.Location = new System.Drawing.Point(13, 40);
			this.bAdd.Name = "bAdd";
			this.bAdd.Size = new System.Drawing.Size(75, 23);
			this.bAdd.TabIndex = 1;
			this.bAdd.Text = "Добавить";
			this.bAdd.UseVisualStyleBackColor = true;
			this.bAdd.Click += new System.EventHandler(this.bAdd_Click);
			// 
			// bCalc
			// 
			this.bCalc.Location = new System.Drawing.Point(94, 39);
			this.bCalc.Name = "bCalc";
			this.bCalc.Size = new System.Drawing.Size(75, 23);
			this.bCalc.TabIndex = 2;
			this.bCalc.Text = "Посчитать";
			this.bCalc.UseVisualStyleBackColor = true;
			this.bCalc.Click += new System.EventHandler(this.bCalc_Click);
			// 
			// outbox
			// 
			this.outbox.Location = new System.Drawing.Point(175, 39);
			this.outbox.Name = "outbox";
			this.outbox.Size = new System.Drawing.Size(149, 20);
			this.outbox.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(336, 78);
			this.Controls.Add(this.outbox);
			this.Controls.Add(this.bCalc);
			this.Controls.Add(this.bAdd);
			this.Controls.Add(this.inbox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox inbox;
		private System.Windows.Forms.Button bAdd;
		private System.Windows.Forms.Button bCalc;
		private System.Windows.Forms.TextBox outbox;
	}
}

