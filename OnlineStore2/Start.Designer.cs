namespace OnlineStore2
{
    partial class Start
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            itemsListBox = new ListBox();
            add_button = new Button();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            cartListBox = new ListBox();
            label3 = new Label();
            checkout_button = new Button();
            remove_button = new Button();
            username_textbox = new TextBox();
            label4 = new Label();
            password_textbox = new TextBox();
            login_button = new Button();
            register_button = new Button();
            label5 = new Label();
            label6 = new Label();
            removeItem_button = new Button();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            tabPage3.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Location = new Point(1, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(730, 453);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(removeItem_button);
            tabPage1.Controls.Add(label6);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(label1);
            tabPage1.Controls.Add(textBox1);
            tabPage1.Controls.Add(add_button);
            tabPage1.Controls.Add(itemsListBox);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(722, 420);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(remove_button);
            tabPage2.Controls.Add(checkout_button);
            tabPage2.Controls.Add(label3);
            tabPage2.Controls.Add(cartListBox);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(722, 420);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(label5);
            tabPage3.Controls.Add(register_button);
            tabPage3.Controls.Add(login_button);
            tabPage3.Controls.Add(password_textbox);
            tabPage3.Controls.Add(label4);
            tabPage3.Controls.Add(username_textbox);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(722, 420);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // itemsListBox
            // 
            itemsListBox.FormattingEnabled = true;
            itemsListBox.ItemHeight = 20;
            itemsListBox.Location = new Point(40, 75);
            itemsListBox.Name = "itemsListBox";
            itemsListBox.Size = new Size(248, 304);
            itemsListBox.TabIndex = 0;
            // 
            // add_button
            // 
            add_button.Location = new Point(329, 184);
            add_button.Name = "add_button";
            add_button.Size = new Size(137, 29);
            add_button.TabIndex = 1;
            add_button.Text = "Add To Cart";
            add_button.UseVisualStyleBackColor = true;
            add_button.Click += add_button_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(360, 83);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(177, 27);
            textBox1.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(279, 3);
            label1.Name = "label1";
            label1.Size = new Size(151, 35);
            label1.TabIndex = 4;
            label1.Text = "Online Store";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(294, 84);
            label2.Name = "label2";
            label2.Size = new Size(65, 23);
            label2.TabIndex = 5;
            label2.Text = "Search:";
            // 
            // cartListBox
            // 
            cartListBox.FormattingEnabled = true;
            cartListBox.ItemHeight = 20;
            cartListBox.Location = new Point(62, 82);
            cartListBox.Name = "cartListBox";
            cartListBox.Size = new Size(247, 264);
            cartListBox.TabIndex = 0;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(62, 44);
            label3.Name = "label3";
            label3.Size = new Size(113, 30);
            label3.TabIndex = 1;
            label3.Text = "Your Cart: ";
            // 
            // checkout_button
            // 
            checkout_button.Location = new Point(336, 182);
            checkout_button.Name = "checkout_button";
            checkout_button.Size = new Size(173, 29);
            checkout_button.TabIndex = 2;
            checkout_button.Text = "Check Out";
            checkout_button.UseVisualStyleBackColor = true;
            checkout_button.Click += checkout_button_Click;
            // 
            // remove_button
            // 
            remove_button.Location = new Point(336, 251);
            remove_button.Name = "remove_button";
            remove_button.Size = new Size(173, 29);
            remove_button.TabIndex = 3;
            remove_button.Text = "Remove from cart";
            remove_button.UseVisualStyleBackColor = true;
            remove_button.Click += remove_button_Click;
            // 
            // username_textbox
            // 
            username_textbox.Location = new Point(60, 107);
            username_textbox.Name = "username_textbox";
            username_textbox.PlaceholderText = "Username";
            username_textbox.Size = new Size(165, 27);
            username_textbox.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(89, 47);
            label4.Name = "label4";
            label4.Size = new Size(78, 30);
            label4.TabIndex = 1;
            label4.Text = "Log In:";
            // 
            // password_textbox
            // 
            password_textbox.Location = new Point(60, 171);
            password_textbox.Name = "password_textbox";
            password_textbox.PlaceholderText = "Password";
            password_textbox.Size = new Size(165, 27);
            password_textbox.TabIndex = 2;
            // 
            // login_button
            // 
            login_button.Location = new Point(89, 234);
            login_button.Name = "login_button";
            login_button.Size = new Size(94, 29);
            login_button.TabIndex = 3;
            login_button.Text = "Log in";
            login_button.UseVisualStyleBackColor = true;
            login_button.Click += login_button_Click;
            // 
            // register_button
            // 
            register_button.Location = new Point(478, 123);
            register_button.Name = "register_button";
            register_button.RightToLeft = RightToLeft.No;
            register_button.Size = new Size(94, 29);
            register_button.TabIndex = 4;
            register_button.Text = "register";
            register_button.UseVisualStyleBackColor = true;
            register_button.Click += register_button_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(422, 47);
            label5.Name = "label5";
            label5.Size = new Size(206, 30);
            label5.TabIndex = 5;
            label5.Text = "Register an account:";
            // 
            // label6
            // 
            label6.AccessibleName = "";
            label6.AutoSize = true;
            label6.Location = new Point(40, 41);
            label6.Name = "label6";
            label6.Size = new Size(106, 20);
            label6.TabIndex = 6;
            label6.Text = "Avalible Items:";
            // 
            // removeItem_button
            // 
            removeItem_button.Location = new Point(329, 238);
            removeItem_button.Name = "removeItem_button";
            removeItem_button.Size = new Size(137, 29);
            removeItem_button.TabIndex = 7;
            removeItem_button.Text = "Remove from cart";
            removeItem_button.UseVisualStyleBackColor = true;
            removeItem_button.Click += removeItem_button_Click;
            // 
            // Start
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(730, 450);
            Controls.Add(tabControl1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Start";
            Text = "Online Store";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private Label label2;
        private Label label1;
        private TextBox textBox1;
        private Button add_button;
        private ListBox itemsListBox;
        private Button remove_button;
        private Button checkout_button;
        private Label label3;
        private ListBox cartListBox;
        private Label label5;
        private Button register_button;
        private Button login_button;
        private TextBox password_textbox;
        private Label label4;
        private TextBox username_textbox;
        private Button removeItem_button;
        private Label label6;
    }
}