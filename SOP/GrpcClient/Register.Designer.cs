namespace GrpcClient
{
    partial class Register
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
            registerBTN = new Button();
            usernameBOX = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lgLB = new Label();
            emailBOX = new TextBox();
            passwordBOX = new TextBox();
            SuspendLayout();
            // 
            // registerBTN
            // 
            registerBTN.Location = new Point(316, 331);
            registerBTN.Name = "registerBTN";
            registerBTN.Size = new Size(112, 29);
            registerBTN.TabIndex = 0;
            registerBTN.Text = "Regisztráció";
            registerBTN.UseVisualStyleBackColor = true;
            registerBTN.Click += registerBTN_Click;
            // 
            // usernameBOX
            // 
            usernameBOX.Location = new Point(316, 144);
            usernameBOX.Name = "usernameBOX";
            usernameBOX.Size = new Size(125, 27);
            usernameBOX.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(333, 68);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.TabIndex = 1;
            label1.Text = "Regisztráció";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(316, 121);
            label2.Name = "label2";
            label2.Size = new Size(109, 20);
            label2.TabIndex = 3;
            label2.Text = "Felhasználónév";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(316, 184);
            label3.Name = "label3";
            label3.Size = new Size(46, 20);
            label3.TabIndex = 4;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(316, 249);
            label4.Name = "label4";
            label4.Size = new Size(48, 20);
            label4.TabIndex = 5;
            label4.Text = "Jelszó";
            // 
            // lgLB
            // 
            lgLB.AutoSize = true;
            lgLB.Location = new Point(280, 386);
            lgLB.Name = "lgLB";
            lgLB.Size = new Size(203, 20);
            lgLB.TabIndex = 6;
            lgLB.Text = "Már van fiókod?Jelenkezz be!";
            lgLB.Click += lgLB_Click;
            // 
            // emailBOX
            // 
            emailBOX.Location = new Point(316, 219);
            emailBOX.Name = "emailBOX";
            emailBOX.Size = new Size(125, 27);
            emailBOX.TabIndex = 7;
            // 
            // passwordBOX
            // 
            passwordBOX.Location = new Point(316, 281);
            passwordBOX.Name = "passwordBOX";
            passwordBOX.Size = new Size(125, 27);
            passwordBOX.TabIndex = 8;
            // 
            // Register
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(passwordBOX);
            Controls.Add(emailBOX);
            Controls.Add(lgLB);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(usernameBOX);
            Controls.Add(label1);
            Controls.Add(registerBTN);
            Name = "Register";
            Text = "Register";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button registerBTN;
        private TextBox usernameBOX;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label lgLB;
        private TextBox emailBOX;
        private TextBox passwordBOX;
    }
}