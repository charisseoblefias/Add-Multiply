/*
 * Created by SharpDevelop.
 * User: Charisse Oblefias
 * Date: 4/24/2021
 * Time: 5:23 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Add_Multiply
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox xtextBox;
		private System.Windows.Forms.TextBox ytextBox;
		private System.Windows.Forms.Button AddButton;
		private System.Windows.Forms.Button MultiplyButton;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Label resultlabel;
		private System.Windows.Forms.Button ExitButton;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.xtextBox = new System.Windows.Forms.TextBox();
			this.ytextBox = new System.Windows.Forms.TextBox();
			this.AddButton = new System.Windows.Forms.Button();
			this.MultiplyButton = new System.Windows.Forms.Button();
			this.ClearButton = new System.Windows.Forms.Button();
			this.resultlabel = new System.Windows.Forms.Label();
			this.ExitButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
			this.label1.Location = new System.Drawing.Point(68, 78);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(220, 24);
			this.label1.TabIndex = 0;
			this.label1.Text = "Enter the first number :";
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(68, 139);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(226, 24);
			this.label2.TabIndex = 1;
			this.label2.Text = "Enter the second number:";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(68, 199);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(112, 24);
			this.label3.TabIndex = 2;
			this.label3.Text = "Answer:";
			// 
			// xtextBox
			// 
			this.xtextBox.Location = new System.Drawing.Point(327, 78);
			this.xtextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.xtextBox.Name = "xtextBox";
			this.xtextBox.Size = new System.Drawing.Size(112, 25);
			this.xtextBox.TabIndex = 3;
			// 
			// ytextBox
			// 
			this.ytextBox.Location = new System.Drawing.Point(327, 139);
			this.ytextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ytextBox.Name = "ytextBox";
			this.ytextBox.Size = new System.Drawing.Size(112, 25);
			this.ytextBox.TabIndex = 4;
			// 
			// AddButton
			// 
			this.AddButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.AddButton.Location = new System.Drawing.Point(68, 255);
			this.AddButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.AddButton.Name = "AddButton";
			this.AddButton.Size = new System.Drawing.Size(87, 39);
			this.AddButton.TabIndex = 6;
			this.AddButton.Text = "Add";
			this.AddButton.UseVisualStyleBackColor = false;
			this.AddButton.Click += new System.EventHandler(this.AddButtonClick);
			// 
			// MultiplyButton
			// 
			this.MultiplyButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.MultiplyButton.Location = new System.Drawing.Point(202, 255);
			this.MultiplyButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.MultiplyButton.Name = "MultiplyButton";
			this.MultiplyButton.Size = new System.Drawing.Size(86, 40);
			this.MultiplyButton.TabIndex = 7;
			this.MultiplyButton.Text = "Multiply";
			this.MultiplyButton.UseVisualStyleBackColor = false;
			this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButtonClick);
			// 
			// ClearButton
			// 
			this.ClearButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClearButton.Location = new System.Drawing.Point(342, 254);
			this.ClearButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(86, 40);
			this.ClearButton.TabIndex = 8;
			this.ClearButton.Text = "Clear";
			this.ClearButton.UseVisualStyleBackColor = false;
			this.ClearButton.Click += new System.EventHandler(this.ClearButtonClick);
			// 
			// resultlabel
			// 
			this.resultlabel.Location = new System.Drawing.Point(327, 199);
			this.resultlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.resultlabel.Name = "resultlabel";
			this.resultlabel.Size = new System.Drawing.Size(112, 24);
			this.resultlabel.TabIndex = 9;
			this.resultlabel.Text = "label4";
			// 
			// ExitButton
			// 
			this.ExitButton.BackColor = System.Drawing.Color.SlateGray;
			this.ExitButton.ForeColor = System.Drawing.SystemColors.ControlText;
			this.ExitButton.Location = new System.Drawing.Point(202, 324);
			this.ExitButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.ExitButton.Name = "ExitButton";
			this.ExitButton.Size = new System.Drawing.Size(86, 39);
			this.ExitButton.TabIndex = 10;
			this.ExitButton.Text = "Exit";
			this.ExitButton.UseVisualStyleBackColor = false;
			this.ExitButton.Click += new System.EventHandler(this.ExitButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Tan;
			this.ClientSize = new System.Drawing.Size(517, 418);
			this.Controls.Add(this.ExitButton);
			this.Controls.Add(this.resultlabel);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.MultiplyButton);
			this.Controls.Add(this.AddButton);
			this.Controls.Add(this.ytextBox);
			this.Controls.Add(this.xtextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
			this.Name = "MainForm";
			this.Text = "Add&Multiply";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
