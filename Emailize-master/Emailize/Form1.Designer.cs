namespace Emailize
{
    partial class EmalizeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmalizeForm));
            this.richTextBoxBody = new System.Windows.Forms.RichTextBox();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.buttonDone = new System.Windows.Forms.Button();
            this.labelCompuerHeader = new System.Windows.Forms.Label();
            this.labelGmailHeader = new System.Windows.Forms.Label();
            this.labelSendTo = new System.Windows.Forms.Label();
            this.labelSubject = new System.Windows.Forms.Label();
            this.labelBody = new System.Windows.Forms.Label();
            this.textBoxComputer = new System.Windows.Forms.TextBox();
            this.textBoxGmail = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCredit = new System.Windows.Forms.Label();
            this.textBoxSendTo = new Demo.PlaceholderTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBoxBody
            // 
            this.richTextBoxBody.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxBody.Location = new System.Drawing.Point(82, 217);
            this.richTextBoxBody.Name = "richTextBoxBody";
            this.richTextBoxBody.Size = new System.Drawing.Size(509, 114);
            this.richTextBoxBody.TabIndex = 0;
            this.richTextBoxBody.Text = "";
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSubject.Location = new System.Drawing.Point(82, 186);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(509, 25);
            this.textBoxSubject.TabIndex = 1;
            // 
            // buttonDone
            // 
            this.buttonDone.BackColor = System.Drawing.Color.Transparent;
            this.buttonDone.Font = new System.Drawing.Font("Assistant SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDone.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonDone.Location = new System.Drawing.Point(277, 339);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(103, 43);
            this.buttonDone.TabIndex = 3;
            this.buttonDone.Text = "Get links";
            this.buttonDone.UseVisualStyleBackColor = false;
            this.buttonDone.Click += new System.EventHandler(this.ButtonDone_Click);
            // 
            // labelCompuerHeader
            // 
            this.labelCompuerHeader.AutoSize = true;
            this.labelCompuerHeader.Font = new System.Drawing.Font("Assistant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCompuerHeader.Location = new System.Drawing.Point(4, 388);
            this.labelCompuerHeader.Name = "labelCompuerHeader";
            this.labelCompuerHeader.Size = new System.Drawing.Size(69, 21);
            this.labelCompuerHeader.TabIndex = 5;
            this.labelCompuerHeader.Text = "Outlook:";
            // 
            // labelGmailHeader
            // 
            this.labelGmailHeader.AutoSize = true;
            this.labelGmailHeader.Font = new System.Drawing.Font("Assistant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGmailHeader.Location = new System.Drawing.Point(4, 419);
            this.labelGmailHeader.Name = "labelGmailHeader";
            this.labelGmailHeader.Size = new System.Drawing.Size(53, 21);
            this.labelGmailHeader.TabIndex = 6;
            this.labelGmailHeader.Text = "Gmail:";
            // 
            // labelSendTo
            // 
            this.labelSendTo.AutoSize = true;
            this.labelSendTo.Font = new System.Drawing.Font("Assistant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSendTo.Location = new System.Drawing.Point(3, 155);
            this.labelSendTo.Name = "labelSendTo";
            this.labelSendTo.Size = new System.Drawing.Size(65, 21);
            this.labelSendTo.TabIndex = 8;
            this.labelSendTo.Text = "Send to:";
            // 
            // labelSubject
            // 
            this.labelSubject.AutoSize = true;
            this.labelSubject.Font = new System.Drawing.Font("Assistant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSubject.Location = new System.Drawing.Point(4, 186);
            this.labelSubject.Name = "labelSubject";
            this.labelSubject.Size = new System.Drawing.Size(64, 21);
            this.labelSubject.TabIndex = 9;
            this.labelSubject.Text = "Subject:";
            // 
            // labelBody
            // 
            this.labelBody.AutoSize = true;
            this.labelBody.Font = new System.Drawing.Font("Assistant", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBody.Location = new System.Drawing.Point(4, 217);
            this.labelBody.Name = "labelBody";
            this.labelBody.Size = new System.Drawing.Size(48, 21);
            this.labelBody.TabIndex = 10;
            this.labelBody.Text = "Body:";
            // 
            // textBoxComputer
            // 
            this.textBoxComputer.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxComputer.Location = new System.Drawing.Point(82, 388);
            this.textBoxComputer.MaxLength = 1000000;
            this.textBoxComputer.Name = "textBoxComputer";
            this.textBoxComputer.Size = new System.Drawing.Size(440, 25);
            this.textBoxComputer.TabIndex = 11;
            // 
            // textBoxGmail
            // 
            this.textBoxGmail.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxGmail.Location = new System.Drawing.Point(82, 419);
            this.textBoxGmail.MaxLength = 1000000;
            this.textBoxGmail.Name = "textBoxGmail";
            this.textBoxGmail.Size = new System.Drawing.Size(440, 25);
            this.textBoxGmail.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(229, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(179, 124);
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // labelCredit
            // 
            this.labelCredit.AutoSize = true;
            this.labelCredit.Font = new System.Drawing.Font("Assistant SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCredit.Location = new System.Drawing.Point(4, 455);
            this.labelCredit.Name = "labelCredit";
            this.labelCredit.Size = new System.Drawing.Size(382, 21);
            this.labelCredit.TabIndex = 14;
            this.labelCredit.Text = "Powered by Nadav Weisler || weisler.nadav@gmail.com";
            // 
            // textBoxSendTo
            // 
            this.textBoxSendTo.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSendTo.Location = new System.Drawing.Point(82, 155);
            this.textBoxSendTo.Name = "textBoxSendTo";
            this.textBoxSendTo.PlaceholderText = "Contacts must be sepreated by \';\'";
            this.textBoxSendTo.Size = new System.Drawing.Size(509, 25);
            this.textBoxSendTo.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(528, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 25);
            this.button1.TabIndex = 16;
            this.button1.Text = "Copy";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Assistant", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(528, 419);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 25);
            this.button2.TabIndex = 17;
            this.button2.Text = "Copy";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // EmalizeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(612, 485);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxSendTo);
            this.Controls.Add(this.labelCredit);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.textBoxGmail);
            this.Controls.Add(this.textBoxComputer);
            this.Controls.Add(this.labelBody);
            this.Controls.Add(this.labelSubject);
            this.Controls.Add(this.labelSendTo);
            this.Controls.Add(this.labelGmailHeader);
            this.Controls.Add(this.labelCompuerHeader);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.textBoxSubject);
            this.Controls.Add(this.richTextBoxBody);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "EmalizeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Emailize";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxBody;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.Label labelCompuerHeader;
        private System.Windows.Forms.Label labelGmailHeader;
        private System.Windows.Forms.Label labelSendTo;
        private System.Windows.Forms.Label labelSubject;
        private System.Windows.Forms.Label labelBody;
        private System.Windows.Forms.TextBox textBoxComputer;
        private System.Windows.Forms.TextBox textBoxGmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCredit;
        private Demo.PlaceholderTextBox textBoxSendTo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

