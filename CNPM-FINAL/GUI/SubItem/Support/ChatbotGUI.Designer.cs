namespace CNPM_FINAL.GUI.SubItem.Support
{
    partial class ChatbotGUI
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
            this.panelHistory = new System.Windows.Forms.Panel();
            this.textBoxHistory = new System.Windows.Forms.RichTextBox();
            this.lbNewMessage = new System.Windows.Forms.Label();
            this.textBoxResponse = new System.Windows.Forms.RichTextBox();
            this.panelInput = new CNPM_FINAL.GUI.CustomControl.BorderPanel();
            this.textBox = new System.Windows.Forms.TextBox();
            this.btnFile = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            this.btnSend = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            this.btnDel = new CNPM_FINAL.GUI.CustomControl.BorderButton();
            this.panelHistory.SuspendLayout();
            this.panelInput.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHistory
            // 
            this.panelHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(211)))), ((int)(((byte)(226)))));
            this.panelHistory.Controls.Add(this.textBoxHistory);
            this.panelHistory.Controls.Add(this.lbNewMessage);
            this.panelHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelHistory.Location = new System.Drawing.Point(0, 0);
            this.panelHistory.Margin = new System.Windows.Forms.Padding(0);
            this.panelHistory.Name = "panelHistory";
            this.panelHistory.Size = new System.Drawing.Size(200, 760);
            this.panelHistory.TabIndex = 0;
            // 
            // textBoxHistory
            // 
            this.textBoxHistory.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxHistory.Dock = System.Windows.Forms.DockStyle.Left;
            this.textBoxHistory.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.textBoxHistory.Location = new System.Drawing.Point(0, 30);
            this.textBoxHistory.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxHistory.Name = "textBoxHistory";
            this.textBoxHistory.ReadOnly = true;
            this.textBoxHistory.Size = new System.Drawing.Size(200, 730);
            this.textBoxHistory.TabIndex = 0;
            this.textBoxHistory.Text = "";
            this.textBoxHistory.MouseClick += new System.Windows.Forms.MouseEventHandler(this.history_MouseClick);
            // 
            // lbNewMessage
            // 
            this.lbNewMessage.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbNewMessage.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewMessage.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbNewMessage.Location = new System.Drawing.Point(0, 0);
            this.lbNewMessage.Margin = new System.Windows.Forms.Padding(0);
            this.lbNewMessage.Name = "lbNewMessage";
            this.lbNewMessage.Size = new System.Drawing.Size(200, 30);
            this.lbNewMessage.TabIndex = 0;
            this.lbNewMessage.Text = "Tạo mới";
            this.lbNewMessage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbNewMessage.Click += new System.EventHandler(this.lbHistory_Click);
            // 
            // textBoxResponse
            // 
            this.textBoxResponse.Cursor = System.Windows.Forms.Cursors.Default;
            this.textBoxResponse.Location = new System.Drawing.Point(250, 50);
            this.textBoxResponse.Margin = new System.Windows.Forms.Padding(0);
            this.textBoxResponse.Name = "textBoxResponse";
            this.textBoxResponse.ReadOnly = true;
            this.textBoxResponse.Size = new System.Drawing.Size(800, 600);
            this.textBoxResponse.TabIndex = 0;
            this.textBoxResponse.Text = "";
            // 
            // panelInput
            // 
            this.panelInput.BackColor = System.Drawing.Color.Gainsboro;
            this.panelInput.BackgroundColor = System.Drawing.Color.White;
            this.panelInput.BorderColor = System.Drawing.Color.Transparent;
            this.panelInput.BorderRadius = 20;
            this.panelInput.BorderSize = 1;
            this.panelInput.Controls.Add(this.textBox);
            this.panelInput.Controls.Add(this.btnFile);
            this.panelInput.Controls.Add(this.btnSend);
            this.panelInput.Location = new System.Drawing.Point(250, 680);
            this.panelInput.Margin = new System.Windows.Forms.Padding(0);
            this.panelInput.Name = "panelInput";
            this.panelInput.Size = new System.Drawing.Size(800, 45);
            this.panelInput.TabIndex = 1;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox.Location = new System.Drawing.Point(110, 10);
            this.textBox.Margin = new System.Windows.Forms.Padding(0);
            this.textBox.Name = "textBox";
            this.textBox.Size = new System.Drawing.Size(580, 27);
            this.textBox.TabIndex = 1;
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.Color.Gainsboro;
            this.btnFile.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.btnFile.BorderColor = System.Drawing.Color.Transparent;
            this.btnFile.BorderRadius = 5;
            this.btnFile.BorderSize = 1;
            this.btnFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFile.FlatAppearance.BorderSize = 0;
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.ForeColor = System.Drawing.Color.White;
            this.btnFile.Image = global::CNPM_FINAL.Properties.Resources.attach_file_icon;
            this.btnFile.Location = new System.Drawing.Point(0, 0);
            this.btnFile.Margin = new System.Windows.Forms.Padding(0);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(100, 45);
            this.btnFile.TabIndex = 1;
            this.btnFile.UseVisualStyleBackColor = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Gainsboro;
            this.btnSend.BackgroundColor = System.Drawing.Color.White;
            this.btnSend.BorderColor = System.Drawing.Color.Transparent;
            this.btnSend.BorderRadius = 5;
            this.btnSend.BorderSize = 1;
            this.btnSend.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.ForeColor = System.Drawing.Color.White;
            this.btnSend.Image = global::CNPM_FINAL.Properties.Resources.airplane_send;
            this.btnSend.Location = new System.Drawing.Point(700, 0);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(100, 45);
            this.btnSend.TabIndex = 3;
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // btnDel
            // 
            this.btnDel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(81)))), ((int)(((byte)(129)))));
            this.btnDel.BackgroundColor = System.Drawing.Color.White;
            this.btnDel.BorderColor = System.Drawing.Color.Transparent;
            this.btnDel.BorderRadius = 5;
            this.btnDel.BorderSize = 1;
            this.btnDel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDel.FlatAppearance.BorderSize = 0;
            this.btnDel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDel.ForeColor = System.Drawing.Color.White;
            this.btnDel.Location = new System.Drawing.Point(900, 5);
            this.btnDel.Margin = new System.Windows.Forms.Padding(0);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(150, 40);
            this.btnDel.TabIndex = 0;
            this.btnDel.Text = "Delete";
            this.btnDel.UseVisualStyleBackColor = false;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // ChatbotGUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1100, 760);
            this.Controls.Add(this.panelInput);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.textBoxResponse);
            this.Controls.Add(this.panelHistory);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatbotGUI";
            this.Text = "ChatbotGUI";
            this.panelHistory.ResumeLayout(false);
            this.panelInput.ResumeLayout(false);
            this.panelInput.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHistory;
        private System.Windows.Forms.Label lbNewMessage;
        private System.Windows.Forms.RichTextBox textBoxHistory;
        private System.Windows.Forms.RichTextBox textBoxResponse;
        private CustomControl.BorderButton btnFile;
        private CustomControl.BorderButton btnSend;
        private System.Windows.Forms.TextBox textBox;
        private CustomControl.BorderButton btnDel;
        private CustomControl.BorderPanel panelInput;
    }
}