namespace AutoRun
{
	partial class AutoRun
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.listBoxProg = new System.Windows.Forms.ListBox();
			this.btnAdd = new System.Windows.Forms.Button();
			this.btnRemove = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			this.SuspendLayout();
			// 
			// listBoxProg
			// 
			this.listBoxProg.FormattingEnabled = true;
			this.listBoxProg.Location = new System.Drawing.Point(13, 13);
			this.listBoxProg.Name = "listBoxProg";
			this.listBoxProg.Size = new System.Drawing.Size(248, 420);
			this.listBoxProg.TabIndex = 0;
			// 
			// btnAdd
			// 
			this.btnAdd.Location = new System.Drawing.Point(278, 13);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(94, 23);
			this.btnAdd.TabIndex = 1;
			this.btnAdd.Text = "Add Prog";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// btnRemove
			// 
			this.btnRemove.Location = new System.Drawing.Point(278, 57);
			this.btnRemove.Name = "btnRemove";
			this.btnRemove.Size = new System.Drawing.Size(94, 23);
			this.btnRemove.TabIndex = 2;
			this.btnRemove.Text = "Remove Prog";
			this.btnRemove.UseVisualStyleBackColor = true;
			// 
			// openFileDialog
			// 
			this.openFileDialog.FileName = "openFileDialog";
			// 
			// AutoRun
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(393, 450);
			this.Controls.Add(this.btnRemove);
			this.Controls.Add(this.btnAdd);
			this.Controls.Add(this.listBoxProg);
			this.Name = "AutoRun";
			this.Text = "AutoRun";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ListBox listBoxProg;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.Button btnRemove;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}

