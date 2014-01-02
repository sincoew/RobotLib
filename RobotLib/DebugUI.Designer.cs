namespace RobotLib
{
    partial class DebugUI
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
            this.LogListbox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Enter_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LogListbox
            // 
            this.LogListbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogListbox.FormattingEnabled = true;
            this.LogListbox.HorizontalExtent = 1000;
            this.LogListbox.HorizontalScrollbar = true;
            this.LogListbox.ItemHeight = 12;
            this.LogListbox.Location = new System.Drawing.Point(0, 0);
            this.LogListbox.Name = "LogListbox";
            this.LogListbox.ScrollAlwaysVisible = true;
            this.LogListbox.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.LogListbox.Size = new System.Drawing.Size(284, 219);
            this.LogListbox.TabIndex = 17;
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 219);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 22);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "Debug Command";
            // 
            // Enter_Btn
            // 
            this.Enter_Btn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Enter_Btn.Location = new System.Drawing.Point(0, 241);
            this.Enter_Btn.Name = "Enter_Btn";
            this.Enter_Btn.Size = new System.Drawing.Size(284, 21);
            this.Enter_Btn.TabIndex = 15;
            this.Enter_Btn.Text = "Enter";
            this.Enter_Btn.UseVisualStyleBackColor = true;
            this.Enter_Btn.Click += new System.EventHandler(this.Enter_Btn_Click);
            // 
            // DebugUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.LogListbox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Enter_Btn);
            this.Name = "DebugUI";
            this.Text = "Debug UI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LogListbox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Enter_Btn;
    }
}

