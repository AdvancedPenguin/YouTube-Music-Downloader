namespace YouTubeDownloader
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private TextBox txtLinks;
        private Button btnDownload;
        private TextBox txtStatus;

        private void InitializeComponent()
        {
            txtLinks = new TextBox();
            btnDownload = new Button();
            txtStatus = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // txtLinks
            // 
            txtLinks.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            txtLinks.Location = new Point(20, 81);
            txtLinks.Margin = new Padding(5, 6, 5, 6);
            txtLinks.Multiline = true;
            txtLinks.Name = "txtLinks";
            txtLinks.ScrollBars = ScrollBars.Vertical;
            txtLinks.Size = new Size(675, 239);
            txtLinks.TabIndex = 0;
            // 
            // btnDownload
            // 
            btnDownload.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnDownload.BackColor = Color.PaleTurquoise;
            btnDownload.Location = new Point(247, 348);
            btnDownload.Margin = new Padding(5, 6, 5, 6);
            btnDownload.Name = "btnDownload";
            btnDownload.Size = new Size(204, 72);
            btnDownload.TabIndex = 1;
            btnDownload.Text = "Download";
            btnDownload.UseVisualStyleBackColor = false;
            btnDownload.Click += btnDownload_Click;
            // 
            // txtStatus
            // 
            txtStatus.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtStatus.Location = new Point(52, 444);
            txtStatus.Margin = new Padding(5, 6, 5, 6);
            txtStatus.Multiline = true;
            txtStatus.Name = "txtStatus";
            txtStatus.ReadOnly = true;
            txtStatus.ScrollBars = ScrollBars.Vertical;
            txtStatus.Size = new Size(643, 235);
            txtStatus.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 33);
            label1.Name = "label1";
            label1.Size = new Size(55, 25);
            label1.TabIndex = 3;
            label1.Text = "Links:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(247, 33);
            label2.Name = "label2";
            label2.Size = new Size(392, 25);
            label2.TabIndex = 4;
            label2.Text = "To download in bulk, put one link per line below";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(724, 694);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtStatus);
            Controls.Add(btnDownload);
            Controls.Add(txtLinks);
            Margin = new Padding(5, 6, 5, 6);
            Name = "Form1";
            Text = "YouTube Downloader";
            ResumeLayout(false);
            PerformLayout();
        }

        private Label label1;
        private Label label2;
    }
}