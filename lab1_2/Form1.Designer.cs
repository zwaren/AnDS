namespace lab1_2
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
			this.buttonSort = new System.Windows.Forms.Button();
			this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
			this.buttonFastSort = new System.Windows.Forms.Button();
			this.textBoxInput = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// buttonSort
			// 
			this.buttonSort.Location = new System.Drawing.Point(12, 39);
			this.buttonSort.Name = "buttonSort";
			this.buttonSort.Size = new System.Drawing.Size(290, 23);
			this.buttonSort.TabIndex = 1;
			this.buttonSort.Text = "Пузырьковая сортировка";
			this.buttonSort.UseVisualStyleBackColor = true;
			this.buttonSort.Click += new System.EventHandler(this.buttonSort_Click);
			// 
			// richTextBoxOutput
			// 
			this.richTextBoxOutput.Location = new System.Drawing.Point(13, 97);
			this.richTextBoxOutput.Name = "richTextBoxOutput";
			this.richTextBoxOutput.ReadOnly = true;
			this.richTextBoxOutput.Size = new System.Drawing.Size(289, 111);
			this.richTextBoxOutput.TabIndex = 2;
			this.richTextBoxOutput.Text = "";
			// 
			// buttonFastSort
			// 
			this.buttonFastSort.Location = new System.Drawing.Point(12, 68);
			this.buttonFastSort.Name = "buttonFastSort";
			this.buttonFastSort.Size = new System.Drawing.Size(290, 23);
			this.buttonFastSort.TabIndex = 3;
			this.buttonFastSort.Text = "Быстрая сортировка";
			this.buttonFastSort.UseVisualStyleBackColor = true;
			this.buttonFastSort.Click += new System.EventHandler(this.buttonFastSort_Click);
			// 
			// textBoxInput
			// 
			this.textBoxInput.Location = new System.Drawing.Point(13, 13);
			this.textBoxInput.Name = "textBoxInput";
			this.textBoxInput.Size = new System.Drawing.Size(289, 20);
			this.textBoxInput.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(314, 221);
			this.Controls.Add(this.textBoxInput);
			this.Controls.Add(this.buttonFastSort);
			this.Controls.Add(this.richTextBoxOutput);
			this.Controls.Add(this.buttonSort);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button buttonSort;
		private System.Windows.Forms.RichTextBox richTextBoxOutput;
		private System.Windows.Forms.Button buttonFastSort;
		private System.Windows.Forms.TextBox textBoxInput;
	}
}

