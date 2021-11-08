
namespace WinFormsDemo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonSend = new System.Windows.Forms.Button();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonLock = new System.Windows.Forms.Button();
            this.buttonClickCount = new System.Windows.Forms.Button();
            this.buttonUpper = new System.Windows.Forms.Button();
            this.buttonLower = new System.Windows.Forms.Button();
            this.buttonWordSwap = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.BackColor = System.Drawing.Color.MistyRose;
            this.buttonSend.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.buttonSend.FlatAppearance.BorderSize = 5;
            this.buttonSend.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSend.ForeColor = System.Drawing.Color.OrangeRed;
            this.buttonSend.Location = new System.Drawing.Point(864, 400);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(149, 38);
            this.buttonSend.TabIndex = 0;
            this.buttonSend.TabStop = false;
            this.buttonSend.Text = "Send";
            this.buttonSend.UseVisualStyleBackColor = false;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMessage.Location = new System.Drawing.Point(12, 12);
            this.textBoxMessage.MaximumSize = new System.Drawing.Size(1000, 500);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(1000, 382);
            this.textBoxMessage.TabIndex = 1;
            this.textBoxMessage.Text = "Hej jag heter Fredrik";
            // 
            // buttonLock
            // 
            this.buttonLock.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonLock.Location = new System.Drawing.Point(709, 400);
            this.buttonLock.Name = "buttonLock";
            this.buttonLock.Size = new System.Drawing.Size(149, 38);
            this.buttonLock.TabIndex = 2;
            this.buttonLock.Text = "Lock";
            this.buttonLock.UseVisualStyleBackColor = true;
            this.buttonLock.Click += new System.EventHandler(this.buttonLock_Click);
            // 
            // buttonClickCount
            // 
            this.buttonClickCount.Location = new System.Drawing.Point(329, 400);
            this.buttonClickCount.Name = "buttonClickCount";
            this.buttonClickCount.Size = new System.Drawing.Size(149, 38);
            this.buttonClickCount.TabIndex = 3;
            this.buttonClickCount.Text = "0";
            this.buttonClickCount.UseVisualStyleBackColor = true;
            this.buttonClickCount.Click += new System.EventHandler(this.buttonClickCount_Click);
            // 
            // buttonUpper
            // 
            this.buttonUpper.Location = new System.Drawing.Point(167, 400);
            this.buttonUpper.Name = "buttonUpper";
            this.buttonUpper.Size = new System.Drawing.Size(149, 38);
            this.buttonUpper.TabIndex = 4;
            this.buttonUpper.Text = "Upper";
            this.buttonUpper.UseVisualStyleBackColor = true;
            this.buttonUpper.Click += new System.EventHandler(this.buttonUpper_Click);
            // 
            // buttonLower
            // 
            this.buttonLower.Location = new System.Drawing.Point(12, 400);
            this.buttonLower.Name = "buttonLower";
            this.buttonLower.Size = new System.Drawing.Size(149, 38);
            this.buttonLower.TabIndex = 5;
            this.buttonLower.Text = "Lower";
            this.buttonLower.UseVisualStyleBackColor = true;
            this.buttonLower.Click += new System.EventHandler(this.buttonLower_Click);
            // 
            // buttonWordSwap
            // 
            this.buttonWordSwap.Location = new System.Drawing.Point(484, 400);
            this.buttonWordSwap.Name = "buttonWordSwap";
            this.buttonWordSwap.Size = new System.Drawing.Size(149, 38);
            this.buttonWordSwap.TabIndex = 6;
            this.buttonWordSwap.UseVisualStyleBackColor = true;
            this.buttonWordSwap.Click += new System.EventHandler(this.buttonWordSwap_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 450);
            this.Controls.Add(this.buttonWordSwap);
            this.Controls.Add(this.buttonLower);
            this.Controls.Add(this.buttonUpper);
            this.Controls.Add(this.buttonClickCount);
            this.Controls.Add(this.buttonLock);
            this.Controls.Add(this.textBoxMessage);
            this.Controls.Add(this.buttonSend);
            this.Name = "Form1";
            this.Text = "My Application";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonLock;
        private System.Windows.Forms.Button buttonClickCount;
        private System.Windows.Forms.Button buttonUpper;
        private System.Windows.Forms.Button buttonLower;
        private System.Windows.Forms.Button buttonWordSwap;
    }
}

