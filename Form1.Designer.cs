namespace CS_Week01_23017057_MyBusinessCard
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button1 = new Button();
            button2 = new Button();
            btnchangephoto = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(118, 119);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(158, 203);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.MouseEnter += pictureBox1_MouseEnter;
            pictureBox1.MouseLeave += pictureBox1_MouseLeave;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("궁서체", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label1.Location = new Point(318, 198);
            label1.Name = "label1";
            label1.Size = new Size(134, 37);
            label1.TabIndex = 1;
            label1.Text = "이기주";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("맑은 고딕", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label2.Location = new Point(318, 266);
            label2.Name = "label2";
            label2.Size = new Size(174, 23);
            label2.TabIndex = 2;
            label2.Text = "컴퓨터학부 컴퓨터sw";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("맑은 고딕", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 129);
            label3.Location = new Point(318, 289);
            label3.Name = "label3";
            label3.Size = new Size(184, 23);
            label3.TabIndex = 3;
            label3.Text = "leegiju01@naver.com";
            label3.Click += label3_Click;
            // 
            // button1
            // 
            button1.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button1.Location = new Point(318, 323);
            button1.Name = "button1";
            button1.Size = new Size(189, 46);
            button1.TabIndex = 4;
            button1.Text = "배경색 랜덤 변경";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            button2.Location = new Point(513, 323);
            button2.Name = "button2";
            button2.Size = new Size(189, 46);
            button2.TabIndex = 5;
            button2.Text = "Instagram";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // btnchangephoto
            // 
            btnchangephoto.Font = new Font("맑은 고딕", 15F, FontStyle.Bold, GraphicsUnit.Point, 129);
            btnchangephoto.Location = new Point(130, 328);
            btnchangephoto.Name = "btnchangephoto";
            btnchangephoto.Size = new Size(136, 37);
            btnchangephoto.TabIndex = 6;
            btnchangephoto.Text = "사진 변경";
            btnchangephoto.UseVisualStyleBackColor = true;
            btnchangephoto.Click += button3_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnchangephoto);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button1;
        private Button button2;
        private Button btnchangephoto;
    }
}
