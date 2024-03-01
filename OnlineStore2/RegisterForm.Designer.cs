namespace OnlineStore2
{
    partial class RegisterForm
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
            create_button = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            back_button = new Button();
            name_textbox = new TextBox();
            address_textbox = new TextBox();
            SuspendLayout();
            // 
            // create_button
            // 
            create_button.Location = new Point(195, 362);
            create_button.Name = "create_button";
            create_button.Size = new Size(94, 29);
            create_button.TabIndex = 0;
            create_button.Text = "Create";
            create_button.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 238);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Email";
            textBox1.Size = new Size(181, 27);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 297);
            textBox2.Name = "textBox2";
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(181, 27);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(148, 79);
            label1.Name = "label1";
            label1.Size = new Size(198, 30);
            label1.TabIndex = 3;
            label1.Text = "Create an account: ";
            // 
            // back_button
            // 
            back_button.Location = new Point(397, 12);
            back_button.Name = "back_button";
            back_button.Size = new Size(94, 29);
            back_button.TabIndex = 4;
            back_button.Text = "back";
            back_button.UseVisualStyleBackColor = true;
            // 
            // name_textbox
            // 
            name_textbox.Location = new Point(148, 133);
            name_textbox.Name = "name_textbox";
            name_textbox.PlaceholderText = "Name";
            name_textbox.Size = new Size(181, 27);
            name_textbox.TabIndex = 5;
            // 
            // address_textbox
            // 
            address_textbox.Location = new Point(148, 185);
            address_textbox.Name = "address_textbox";
            address_textbox.PlaceholderText = "Address";
            address_textbox.Size = new Size(181, 27);
            address_textbox.TabIndex = 6;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(503, 450);
            Controls.Add(address_textbox);
            Controls.Add(name_textbox);
            Controls.Add(back_button);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(create_button);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "RegisterForm";
            Text = "RegisterForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button create_button;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label1;
        private Button back_button;
        private TextBox name_textbox;
        private TextBox address_textbox;
    }
}