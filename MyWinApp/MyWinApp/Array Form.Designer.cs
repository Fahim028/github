namespace MyWinApp
{
    partial class ArrayForm
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
            this.ShowRichTextBox = new System.Windows.Forms.RichTextBox();
            this.ShowButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ShowRichTextBox
            // 
            this.ShowRichTextBox.Location = new System.Drawing.Point(26, 73);
            this.ShowRichTextBox.Name = "ShowRichTextBox";
            this.ShowRichTextBox.Size = new System.Drawing.Size(191, 134);
            this.ShowRichTextBox.TabIndex = 0;
            this.ShowRichTextBox.Text = "";
            this.ShowRichTextBox.TextChanged += new System.EventHandler(this.ShowRichTextBox_TextChanged);
            // 
            // ShowButton
            // 
            this.ShowButton.Location = new System.Drawing.Point(245, 31);
            this.ShowButton.Name = "ShowButton";
            this.ShowButton.Size = new System.Drawing.Size(75, 23);
            this.ShowButton.TabIndex = 1;
            this.ShowButton.Text = "Show";
            this.ShowButton.UseVisualStyleBackColor = true;
            this.ShowButton.Click += new System.EventHandler(this.ShowButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(142, 44);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 2;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(36, 44);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(100, 20);
            this.numberTextBox.TabIndex = 3;
            // 
            // ArrayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 360);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.ShowButton);
            this.Controls.Add(this.ShowRichTextBox);
            this.Name = "ArrayForm";
            this.Text = "Array Form";
            this.Load += new System.EventHandler(this.ArrayForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox ShowRichTextBox;
        private System.Windows.Forms.Button ShowButton;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox numberTextBox;
    }
}