namespace HoloLauncher
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
        private void InitializeComponent() {
            btn_InstallPlay = new Button();
            progressBar1 = new ProgressBar();
            label1 = new Label();
            SuspendLayout();
            // 
            // btn_InstallPlay
            // 
            btn_InstallPlay.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btn_InstallPlay.Location = new Point(149, 79);
            btn_InstallPlay.Name = "btn_InstallPlay";
            btn_InstallPlay.Size = new Size(121, 48);
            btn_InstallPlay.TabIndex = 0;
            btn_InstallPlay.Text = "Install";
            btn_InstallPlay.UseVisualStyleBackColor = true;
            btn_InstallPlay.Click += btn_InstallPlay_Click;
            // 
            // progressBar1
            // 
            progressBar1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            progressBar1.Location = new Point(12, 193);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(387, 23);
            progressBar1.TabIndex = 1;
            progressBar1.Visible = false;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            label1.BackColor = Color.Black;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 157);
            label1.Name = "label1";
            label1.Size = new Size(387, 33);
            label1.TabIndex = 2;
            label1.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BackgroundImage;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(411, 228);
            Controls.Add(label1);
            Controls.Add(progressBar1);
            Controls.Add(btn_InstallPlay);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MinimumSize = new Size(427, 267);
            Name = "Form1";
            Text = "HoloLauncher";
            SizeChanged += Form1_SizeChanged;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_InstallPlay;
        private ProgressBar progressBar1;
        private Label label1;
    }
}
