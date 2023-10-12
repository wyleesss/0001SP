using System.Diagnostics;

namespace _0001SP
{
    partial class Form1
    {
        Process notepadProcess;

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
            openButton = new Button();
            closeButton = new Button();
            SuspendLayout();
            // 
            // openButton
            // 
            openButton.BackColor = SystemColors.ControlLightLight;
            openButton.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            openButton.Location = new Point(148, 63);
            openButton.Name = "openButton";
            openButton.Size = new Size(219, 60);
            openButton.TabIndex = 0;
            openButton.Text = "Open Notebook";
            openButton.UseVisualStyleBackColor = false;
            openButton.Click += openButton_Click;
            // 
            // closeButton
            // 
            closeButton.BackColor = SystemColors.ControlLightLight;
            closeButton.Font = new Font("Yu Gothic UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            closeButton.Location = new Point(148, 146);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(219, 60);
            closeButton.TabIndex = 1;
            closeButton.Text = "Close Notebook";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(530, 270);
            Controls.Add(closeButton);
            Controls.Add(openButton);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Systems Programming";
            ResumeLayout(false);
        }

        #endregion

        private Button openButton;
        private Button closeButton;
    }
}