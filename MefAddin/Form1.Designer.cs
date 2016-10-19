namespace MefAddin
{
    partial class Form1
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
            this.updateButton = new System.Windows.Forms.Button();
            this.executeButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.addinsListBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(239, 26);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(75, 33);
            this.updateButton.TabIndex = 1;
            this.updateButton.Text = "更新";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // executeButton
            // 
            this.executeButton.Location = new System.Drawing.Point(239, 65);
            this.executeButton.Name = "executeButton";
            this.executeButton.Size = new System.Drawing.Size(75, 33);
            this.executeButton.TabIndex = 1;
            this.executeButton.Text = "実行";
            this.executeButton.UseVisualStyleBackColor = true;
            this.executeButton.Click += new System.EventHandler(this.executeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(239, 240);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 33);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "閉じる";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // addinsListBox
            // 
            this.addinsListBox.FormattingEnabled = true;
            this.addinsListBox.ItemHeight = 16;
            this.addinsListBox.Location = new System.Drawing.Point(6, 8);
            this.addinsListBox.Name = "addinsListBox";
            this.addinsListBox.Size = new System.Drawing.Size(220, 260);
            this.addinsListBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 291);
            this.Controls.Add(this.addinsListBox);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.executeButton);
            this.Controls.Add(this.updateButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button executeButton;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ListBox addinsListBox;
    }
}

