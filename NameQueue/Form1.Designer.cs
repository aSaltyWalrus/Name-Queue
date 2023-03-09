namespace NameQueue
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
            this.inputBox = new System.Windows.Forms.TextBox();
            this.enqueueButton = new System.Windows.Forms.Button();
            this.peekButton = new System.Windows.Forms.Button();
            this.dequeueButton = new System.Windows.Forms.Button();
            this.printListButton = new System.Windows.Forms.Button();
            this.actionLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.lengthButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(30, 46);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(171, 20);
            this.inputBox.TabIndex = 0;
            // 
            // enqueueButton
            // 
            this.enqueueButton.Location = new System.Drawing.Point(223, 46);
            this.enqueueButton.Name = "enqueueButton";
            this.enqueueButton.Size = new System.Drawing.Size(75, 23);
            this.enqueueButton.TabIndex = 1;
            this.enqueueButton.Text = "Enqueue";
            this.enqueueButton.UseVisualStyleBackColor = true;
            this.enqueueButton.Click += new System.EventHandler(this.enqueueButton_Click);
            // 
            // peekButton
            // 
            this.peekButton.Location = new System.Drawing.Point(30, 115);
            this.peekButton.Name = "peekButton";
            this.peekButton.Size = new System.Drawing.Size(75, 23);
            this.peekButton.TabIndex = 2;
            this.peekButton.Text = "Peek";
            this.peekButton.UseVisualStyleBackColor = true;
            this.peekButton.Click += new System.EventHandler(this.peekButton_Click);
            // 
            // dequeueButton
            // 
            this.dequeueButton.Location = new System.Drawing.Point(126, 115);
            this.dequeueButton.Name = "dequeueButton";
            this.dequeueButton.Size = new System.Drawing.Size(75, 23);
            this.dequeueButton.TabIndex = 3;
            this.dequeueButton.Text = "Dequeue";
            this.dequeueButton.UseVisualStyleBackColor = true;
            this.dequeueButton.Click += new System.EventHandler(this.dequeueButton_Click);
            // 
            // printListButton
            // 
            this.printListButton.Location = new System.Drawing.Point(223, 115);
            this.printListButton.Name = "printListButton";
            this.printListButton.Size = new System.Drawing.Size(75, 23);
            this.printListButton.TabIndex = 4;
            this.printListButton.Text = "Print List";
            this.printListButton.UseVisualStyleBackColor = true;
            this.printListButton.Click += new System.EventHandler(this.printListButton_Click);
            // 
            // actionLabel
            // 
            this.actionLabel.AutoSize = true;
            this.actionLabel.Location = new System.Drawing.Point(38, 353);
            this.actionLabel.Name = "actionLabel";
            this.actionLabel.Size = new System.Drawing.Size(0, 13);
            this.actionLabel.TabIndex = 5;
            // 
            // outputLabel
            // 
            this.outputLabel.AutoSize = true;
            this.outputLabel.Location = new System.Drawing.Point(38, 191);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(0, 13);
            this.outputLabel.TabIndex = 6;
            // 
            // lengthButton
            // 
            this.lengthButton.Location = new System.Drawing.Point(319, 115);
            this.lengthButton.Name = "lengthButton";
            this.lengthButton.Size = new System.Drawing.Size(84, 23);
            this.lengthButton.TabIndex = 7;
            this.lengthButton.Text = "Queue Length";
            this.lengthButton.UseVisualStyleBackColor = true;
            this.lengthButton.Click += new System.EventHandler(this.lengthButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 450);
            this.Controls.Add(this.lengthButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.actionLabel);
            this.Controls.Add(this.printListButton);
            this.Controls.Add(this.dequeueButton);
            this.Controls.Add(this.peekButton);
            this.Controls.Add(this.enqueueButton);
            this.Controls.Add(this.inputBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Button enqueueButton;
        private System.Windows.Forms.Button peekButton;
        private System.Windows.Forms.Button dequeueButton;
        private System.Windows.Forms.Button printListButton;
        private System.Windows.Forms.Label actionLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button lengthButton;
    }
}

