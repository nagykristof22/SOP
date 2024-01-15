namespace GrpcClient
{
    partial class Login
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
            loginBTN = new Button();
            label1 = new Label();
            passwordBOX = new TextBox();
            label2 = new Label();
            label3 = new Label();
            regLB = new Label();
            usernameBox = new TextBox();
            SuspendLayout();
            // 
            // loginBTN
            // 
            loginBTN.Location = new Point(67, 269);
            loginBTN.Name = "loginBTN";
            loginBTN.Size = new Size(125, 43);
            loginBTN.TabIndex = 0;
            loginBTN.Text = "Bejelentkezés";
            loginBTN.UseVisualStyleBackColor = true;
            loginBTN.Click += loginBTN_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 39);
            label1.Name = "label1";
            label1.Size = new Size(99, 20);
            label1.TabIndex = 1;
            label1.Text = "Bejelentkezés";
            // 
            // passwordBOX
            // 
            passwordBOX.Location = new Point(67, 220);
            passwordBOX.Name = "passwordBOX";
            passwordBOX.Size = new Size(125, 27);
            passwordBOX.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(67, 100);
            label2.Name = "label2";
            label2.Size = new Size(86, 20);
            label2.TabIndex = 3;
            label2.Text = "Felhasználó";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(67, 187);
            label3.Name = "label3";
            label3.Size = new Size(48, 20);
            label3.TabIndex = 4;
            label3.Text = "Jelszó";
            // 
            // regLB
            // 
            regLB.AutoSize = true;
            regLB.Location = new Point(27, 315);
            regLB.Name = "regLB";
            regLB.Size = new Size(207, 20);
            regLB.TabIndex = 5;
            regLB.Text = "Még nincs fiókod? Regisztrálj!";
            regLB.Click += regLB_Click;
            // 
            // usernameBox
            // 
            usernameBox.Location = new Point(67, 141);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(125, 27);
            usernameBox.TabIndex = 6;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(272, 378);
            Controls.Add(usernameBox);
            Controls.Add(regLB);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(passwordBOX);
            Controls.Add(label1);
            Controls.Add(loginBTN);
            Name = "Login";
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button loginBTN;
        private Label label1;
        private TextBox passwordBOX;
        private Label label2;
        private Label label3;
        private Label regLB;
        private TextBox usernameBox;
    }
}