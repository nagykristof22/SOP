namespace GrpcClient
{
    partial class ADD
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            label7 = new Label();
            addBTN = new Button();
            nameBOX = new TextBox();
            writerBOX = new TextBox();
            catBox = new TextBox();
            descriptionBOX = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(263, 32);
            label1.Name = "label1";
            label1.Size = new Size(228, 20);
            label1.TabIndex = 0;
            label1.Text = "Add kölcsönbe kedvenc könyved:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(50, 106);
            label2.Name = "label2";
            label2.Size = new Size(38, 20);
            label2.TabIndex = 1;
            label2.Text = "Cím:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 69);
            label3.Name = "label3";
            label3.Size = new Size(280, 20);
            label3.TabIndex = 2;
            label3.Text = "Kérlek adj meg a könyvről információkat:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(50, 159);
            label4.Name = "label4";
            label4.Size = new Size(53, 20);
            label4.TabIndex = 3;
            label4.Text = "Szerző";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 277);
            label6.Name = "label6";
            label6.Size = new Size(145, 20);
            label6.TabIndex = 5;
            label6.Text = "Adj egy rövid leírást:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(50, 223);
            label7.Name = "label7";
            label7.Size = new Size(74, 20);
            label7.TabIndex = 6;
            label7.Text = "Kategória";
            // 
            // addBTN
            // 
            addBTN.Location = new Point(338, 395);
            addBTN.Name = "addBTN";
            addBTN.Size = new Size(94, 29);
            addBTN.TabIndex = 7;
            addBTN.Text = "Hozzáad";
            addBTN.UseVisualStyleBackColor = true;
            addBTN.Click += addBTN_Click;
            // 
            // nameBOX
            // 
            nameBOX.Location = new Point(50, 129);
            nameBOX.Name = "nameBOX";
            nameBOX.Size = new Size(125, 27);
            nameBOX.TabIndex = 8;
            // 
            // writerBOX
            // 
            writerBOX.Location = new Point(50, 193);
            writerBOX.Name = "writerBOX";
            writerBOX.Size = new Size(125, 27);
            writerBOX.TabIndex = 9;
            // 
            // catBox
            // 
            catBox.Location = new Point(50, 247);
            catBox.Name = "catBox";
            catBox.Size = new Size(125, 27);
            catBox.TabIndex = 10;
            // 
            // descriptionBOX
            // 
            descriptionBOX.Location = new Point(50, 312);
            descriptionBOX.Name = "descriptionBOX";
            descriptionBOX.Size = new Size(125, 27);
            descriptionBOX.TabIndex = 11;
            // 
            // ADD
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(descriptionBOX);
            Controls.Add(catBox);
            Controls.Add(writerBOX);
            Controls.Add(nameBOX);
            Controls.Add(addBTN);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ADD";
            Text = "ADD";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private Label label7;
        private Button addBTN;
        private TextBox nameBOX;
        private TextBox writerBOX;
        private TextBox catBox;
        private TextBox descriptionBOX;
    }
}