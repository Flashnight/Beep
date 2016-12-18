namespace Beep
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
            this.KeyPreview = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.pressKey);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.button_Up);

            this.doButton = new System.Windows.Forms.Button();
            this.reButton = new System.Windows.Forms.Button();
            this.miButton = new System.Windows.Forms.Button();
            this.faButton = new System.Windows.Forms.Button();
            this.solButton = new System.Windows.Forms.Button();
            this.laButton = new System.Windows.Forms.Button();
            this.si_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // doButton
            // 
            this.doButton.Location = new System.Drawing.Point(13, 13);
            this.doButton.Name = "doButton";
            this.doButton.Size = new System.Drawing.Size(110, 110);
            this.doButton.TabIndex = 0;
            this.doButton.Text = "До";
            this.doButton.UseVisualStyleBackColor = true;
            //this.doButton.Click += new System.EventHandler(this.doButton_Click);
            this.doButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.doButton_Click);
            this.doButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Up);
            //this.doButton.MouseLeave += new System.EventHandler(this.button_Up);
            // 
            // reButton
            // 
            this.reButton.Location = new System.Drawing.Point(129, 13);
            this.reButton.Name = "reButton";
            this.reButton.Size = new System.Drawing.Size(110, 110);
            this.reButton.TabIndex = 1;
            this.reButton.Text = "Ре";
            this.reButton.UseVisualStyleBackColor = true;
            this.reButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.reButton_Click);
            this.reButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Up);
            //this.reButton.MouseLeave += new System.EventHandler(this.button_Up);
            // 
            // miButton
            // 
            this.miButton.Location = new System.Drawing.Point(245, 13);
            this.miButton.Name = "miButton";
            this.miButton.Size = new System.Drawing.Size(110, 110);
            this.miButton.TabIndex = 2;
            this.miButton.Text = "Ми";
            this.miButton.UseVisualStyleBackColor = true;
            this.miButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.miButton_Click);
            this.miButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Up);
            //this.miButton.MouseLeave += new System.EventHandler(this.button_Up);
            // 
            // faButton
            // 
            this.faButton.Location = new System.Drawing.Point(361, 13);
            this.faButton.Name = "faButton";
            this.faButton.Size = new System.Drawing.Size(110, 110);
            this.faButton.TabIndex = 3;
            this.faButton.Text = "Фа";
            this.faButton.UseVisualStyleBackColor = true;
            this.faButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.faButton_Click);
            this.faButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Up);
            //this.faButton.MouseLeave += new System.EventHandler(this.button_Up);
            // 
            // solButton
            // 
            this.solButton.Location = new System.Drawing.Point(477, 13);
            this.solButton.Name = "solButton";
            this.solButton.Size = new System.Drawing.Size(110, 110);
            this.solButton.TabIndex = 4;
            this.solButton.Text = "Соль";
            this.solButton.UseVisualStyleBackColor = true;
            this.solButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.solButton_Click);
            this.solButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Up);
            //this.solButton.MouseLeave += new System.EventHandler(this.button_Up);
            // 
            // laButton
            // 
            this.laButton.Location = new System.Drawing.Point(593, 12);
            this.laButton.Name = "laButton";
            this.laButton.Size = new System.Drawing.Size(110, 110);
            this.laButton.TabIndex = 5;
            this.laButton.Text = "Ля";
            this.laButton.UseVisualStyleBackColor = true;
            this.laButton.MouseDown += new System.Windows.Forms.MouseEventHandler(this.laButton_Click);
            this.laButton.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Up);
            //this.laButton.MouseLeave += new System.EventHandler(this.button_Up);
            // 
            // si_button
            // 
            this.si_button.Location = new System.Drawing.Point(709, 12);
            this.si_button.Name = "si_button";
            this.si_button.Size = new System.Drawing.Size(110, 110);
            this.si_button.TabIndex = 6;
            this.si_button.Text = "Си";
            this.si_button.UseVisualStyleBackColor = true;
            this.si_button.MouseDown += new System.Windows.Forms.MouseEventHandler(this.si_button_Click);
            this.si_button.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_Up);
            //this.si_button.MouseLeave += new System.EventHandler(this.button_Up);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 141);
            this.Controls.Add(this.si_button);
            this.Controls.Add(this.laButton);
            this.Controls.Add(this.solButton);
            this.Controls.Add(this.faButton);
            this.Controls.Add(this.miButton);
            this.Controls.Add(this.reButton);
            this.Controls.Add(this.doButton);
            this.Name = "Form1";
            this.Text = "Beep!";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button doButton;
        private System.Windows.Forms.Button reButton;
        private System.Windows.Forms.Button miButton;
        private System.Windows.Forms.Button faButton;
        private System.Windows.Forms.Button solButton;
        private System.Windows.Forms.Button laButton;
        private System.Windows.Forms.Button si_button;
    }
}

