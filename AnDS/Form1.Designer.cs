namespace AnDS
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
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.buttonPush = new System.Windows.Forms.Button();
			this.buttonPop = new System.Windows.Forms.Button();
			this.richTextBoxPresent = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// textBoxInput
			// 
			this.textBoxInput.Location = new System.Drawing.Point(13, 13);
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.Size = new System.Drawing.Size(291, 20);
			this.textBoxInput.TabIndex = 0;
			// 
			// buttonPush
			// 
			this.buttonPush.Location = new System.Drawing.Point(13, 40);
			this.buttonPush.Name = "buttonPush";
			this.buttonPush.Size = new System.Drawing.Size(142, 23);
			this.buttonPush.TabIndex = 1;
			this.buttonPush.Text = "push";
			this.buttonPush.UseVisualStyleBackColor = true;
			this.buttonPush.Click += new System.EventHandler(this.buttonPush_Click);
			// 
			// buttonPop
			// 
			this.buttonPop.Location = new System.Drawing.Point(162, 40);
			this.buttonPop.Name = "buttonPop";
			this.buttonPop.Size = new System.Drawing.Size(142, 23);
			this.buttonPop.TabIndex = 2;
			this.buttonPop.Text = "pop";
			this.buttonPop.UseVisualStyleBackColor = true;
			this.buttonPop.Click += new System.EventHandler(this.buttonPop_Click);
			// 
			// richTextBoxPresent
			// 
			this.richTextBoxPresent.Location = new System.Drawing.Point(13, 70);
			this.richTextBoxPresent.Name = "richTextBoxPresent";
			this.richTextBoxPresent.ReadOnly = true;
			this.richTextBoxPresent.Size = new System.Drawing.Size(291, 96);
			this.richTextBoxPresent.TabIndex = 3;
			this.richTextBoxPresent.Text = "";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(316, 184);
			this.Controls.Add(this.richTextBoxPresent);
			this.Controls.Add(this.buttonPop);
			this.Controls.Add(this.buttonPush);
			this.Controls.Add(this.textBoxInput);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBoxInput;
		private System.Windows.Forms.Button buttonPush;
		private System.Windows.Forms.Button buttonPop;
		private System.Windows.Forms.RichTextBox richTextBoxPresent;
	}
}

