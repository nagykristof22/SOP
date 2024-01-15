namespace GrpcClient
{
    partial class BookShop
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BookShop));
            kolcsonBTN = new Button();
            listBTN = new Button();
            bookDGV = new DataGridView();
            toolStrip1 = new ToolStrip();
            beleptoolStripLabel1 = new ToolStripButton();
            borowtoolStripButton1 = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)bookDGV).BeginInit();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // kolcsonBTN
            // 
            kolcsonBTN.Location = new Point(648, 113);
            kolcsonBTN.Name = "kolcsonBTN";
            kolcsonBTN.Size = new Size(127, 33);
            kolcsonBTN.TabIndex = 1;
            kolcsonBTN.Text = "Kölcsönbe adás";
            kolcsonBTN.UseVisualStyleBackColor = true;
            kolcsonBTN.Click += kolcsonBTN_Click;
            // 
            // listBTN
            // 
            listBTN.Location = new Point(648, 163);
            listBTN.Name = "listBTN";
            listBTN.Size = new Size(127, 32);
            listBTN.TabIndex = 4;
            listBTN.Text = "Kölcsönözhető";
            listBTN.UseVisualStyleBackColor = true;
            listBTN.Click += listBTN_Click;
            // 
            // bookDGV
            // 
            bookDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            bookDGV.Location = new Point(12, 71);
            bookDGV.Name = "bookDGV";
            bookDGV.RowHeadersWidth = 51;
            bookDGV.RowTemplate.Height = 29;
            bookDGV.Size = new Size(604, 264);
            bookDGV.TabIndex = 5;
            // 
            // toolStrip1
            // 
            toolStrip1.BackColor = SystemColors.AppWorkspace;
            toolStrip1.GripStyle = ToolStripGripStyle.Hidden;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { beleptoolStripLabel1, borowtoolStripButton1, toolStripSeparator1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 6;
            toolStrip1.Text = "toolStrip1";
            // 
            // beleptoolStripLabel1
            // 
            beleptoolStripLabel1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            beleptoolStripLabel1.Image = (Image)resources.GetObject("beleptoolStripLabel1.Image");
            beleptoolStripLabel1.ImageTransparentColor = Color.Magenta;
            beleptoolStripLabel1.Name = "beleptoolStripLabel1";
            beleptoolStripLabel1.Size = new Size(65, 24);
            beleptoolStripLabel1.Text = "Belépés";
            beleptoolStripLabel1.Click += beleptoolStripLabel1_Click;
            // 
            // borowtoolStripButton1
            // 
            borowtoolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Text;
            borowtoolStripButton1.Image = (Image)resources.GetObject("borowtoolStripButton1.Image");
            borowtoolStripButton1.ImageTransparentColor = Color.Magenta;
            borowtoolStripButton1.Name = "borowtoolStripButton1";
            borowtoolStripButton1.Size = new Size(111, 24);
            borowtoolStripButton1.Text = "Kölcsönzéseim";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // BookShop
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(toolStrip1);
            Controls.Add(bookDGV);
            Controls.Add(listBTN);
            Controls.Add(kolcsonBTN);
            Name = "BookShop";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)bookDGV).EndInit();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button kolcsonBTN;
        private Button listBTN;
        private DataGridView bookDGV;
        private ToolStrip toolStrip1;
        private ToolStripButton beleptoolStripLabel1;
        private ToolStripButton borowtoolStripButton1;
        private ToolStripSeparator toolStripSeparator1;
    }
}