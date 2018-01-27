namespace Filtering
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GaussFilterButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ResetImageButton = new System.Windows.Forms.Button();
            this.ErrorLavel = new System.Windows.Forms.Label();
            this.AveragingButton = new System.Windows.Forms.Button();
            this.GrayScaleButton = new System.Windows.Forms.Button();
            this.SIGMA_trackBar = new System.Windows.Forms.TrackBar();
            this.SIGMA_Value = new System.Windows.Forms.Label();
            this.GaussFilterButton5 = new System.Windows.Forms.Button();
            this.ImageSaveButton = new System.Windows.Forms.Button();
            this.FileNameBox = new System.Windows.Forms.TextBox();
            this.EdgeDetect4Button = new System.Windows.Forms.Button();
            this.EdgeDetect8Button = new System.Windows.Forms.Button();
            this.GaussEdgeButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SIGMA_trackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // GaussFilterButton
            // 
            this.GaussFilterButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GaussFilterButton.Location = new System.Drawing.Point(281, 173);
            this.GaussFilterButton.Name = "GaussFilterButton";
            this.GaussFilterButton.Size = new System.Drawing.Size(187, 23);
            this.GaussFilterButton.TabIndex = 0;
            this.GaussFilterButton.Text = "ガウシアンフィルタ（3マス）";
            this.GaussFilterButton.UseVisualStyleBackColor = true;
            this.GaussFilterButton.Click += new System.EventHandler(this.GaussFilterButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 214);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // ResetImageButton
            // 
            this.ResetImageButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ResetImageButton.Location = new System.Drawing.Point(12, 286);
            this.ResetImageButton.Name = "ResetImageButton";
            this.ResetImageButton.Size = new System.Drawing.Size(238, 23);
            this.ResetImageButton.TabIndex = 2;
            this.ResetImageButton.Text = "RESET IMAGE";
            this.ResetImageButton.UseVisualStyleBackColor = true;
            this.ResetImageButton.Click += new System.EventHandler(this.ResetImageButton_Click);
            // 
            // ErrorLavel
            // 
            this.ErrorLavel.AutoSize = true;
            this.ErrorLavel.Location = new System.Drawing.Point(12, 271);
            this.ErrorLavel.Name = "ErrorLavel";
            this.ErrorLavel.Size = new System.Drawing.Size(0, 12);
            this.ErrorLavel.TabIndex = 3;
            // 
            // AveragingButton
            // 
            this.AveragingButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.AveragingButton.Location = new System.Drawing.Point(281, 56);
            this.AveragingButton.Name = "AveragingButton";
            this.AveragingButton.Size = new System.Drawing.Size(187, 23);
            this.AveragingButton.TabIndex = 4;
            this.AveragingButton.Text = "平均化フィルタ";
            this.AveragingButton.UseVisualStyleBackColor = true;
            this.AveragingButton.Click += new System.EventHandler(this.AveragingButton_Click);
            // 
            // GrayScaleButton
            // 
            this.GrayScaleButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GrayScaleButton.Location = new System.Drawing.Point(281, 12);
            this.GrayScaleButton.Name = "GrayScaleButton";
            this.GrayScaleButton.Size = new System.Drawing.Size(187, 23);
            this.GrayScaleButton.TabIndex = 5;
            this.GrayScaleButton.Text = "グレースケール";
            this.GrayScaleButton.UseVisualStyleBackColor = true;
            this.GrayScaleButton.Click += new System.EventHandler(this.GrayScaleButton_Click);
            // 
            // SIGMA_trackBar
            // 
            this.SIGMA_trackBar.Location = new System.Drawing.Point(320, 107);
            this.SIGMA_trackBar.Maximum = 30;
            this.SIGMA_trackBar.Minimum = 1;
            this.SIGMA_trackBar.Name = "SIGMA_trackBar";
            this.SIGMA_trackBar.Size = new System.Drawing.Size(148, 45);
            this.SIGMA_trackBar.TabIndex = 6;
            this.SIGMA_trackBar.Value = 10;
            this.SIGMA_trackBar.Scroll += new System.EventHandler(this.SIGMA_trackBar_Scroll);
            // 
            // SIGMA_Value
            // 
            this.SIGMA_Value.AutoSize = true;
            this.SIGMA_Value.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.SIGMA_Value.Location = new System.Drawing.Point(279, 120);
            this.SIGMA_Value.Name = "SIGMA_Value";
            this.SIGMA_Value.Size = new System.Drawing.Size(25, 17);
            this.SIGMA_Value.TabIndex = 7;
            this.SIGMA_Value.Text = "1.0";
            // 
            // GaussFilterButton5
            // 
            this.GaussFilterButton5.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GaussFilterButton5.Location = new System.Drawing.Point(281, 202);
            this.GaussFilterButton5.Name = "GaussFilterButton5";
            this.GaussFilterButton5.Size = new System.Drawing.Size(187, 23);
            this.GaussFilterButton5.TabIndex = 8;
            this.GaussFilterButton5.Text = "ガウシアンフィルタ（5マス）";
            this.GaussFilterButton5.UseVisualStyleBackColor = true;
            this.GaussFilterButton5.Click += new System.EventHandler(this.GaussFilterButton5_Click);
            // 
            // ImageSaveButton
            // 
            this.ImageSaveButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.ImageSaveButton.Location = new System.Drawing.Point(13, 257);
            this.ImageSaveButton.Name = "ImageSaveButton";
            this.ImageSaveButton.Size = new System.Drawing.Size(236, 23);
            this.ImageSaveButton.TabIndex = 9;
            this.ImageSaveButton.Text = "画像を保存";
            this.ImageSaveButton.UseVisualStyleBackColor = true;
            this.ImageSaveButton.Click += new System.EventHandler(this.ImageSaveButton_Click);
            // 
            // FileNameBox
            // 
            this.FileNameBox.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.FileNameBox.Location = new System.Drawing.Point(14, 232);
            this.FileNameBox.Name = "FileNameBox";
            this.FileNameBox.Size = new System.Drawing.Size(236, 25);
            this.FileNameBox.TabIndex = 10;
            this.FileNameBox.Text = "ファイル名";
            // 
            // EdgeDetect4Button
            // 
            this.EdgeDetect4Button.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EdgeDetect4Button.Location = new System.Drawing.Point(281, 232);
            this.EdgeDetect4Button.Name = "EdgeDetect4Button";
            this.EdgeDetect4Button.Size = new System.Drawing.Size(187, 23);
            this.EdgeDetect4Button.TabIndex = 11;
            this.EdgeDetect4Button.Text = "先鋭化（4近傍）";
            this.EdgeDetect4Button.UseVisualStyleBackColor = true;
            this.EdgeDetect4Button.Click += new System.EventHandler(this.EdgeDetect4Button_Click);
            // 
            // EdgeDetect8Button
            // 
            this.EdgeDetect8Button.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.EdgeDetect8Button.Location = new System.Drawing.Point(281, 257);
            this.EdgeDetect8Button.Name = "EdgeDetect8Button";
            this.EdgeDetect8Button.Size = new System.Drawing.Size(187, 23);
            this.EdgeDetect8Button.TabIndex = 12;
            this.EdgeDetect8Button.Text = "先鋭化（8近傍）";
            this.EdgeDetect8Button.UseVisualStyleBackColor = true;
            this.EdgeDetect8Button.Click += new System.EventHandler(this.EdgeDetect8Button_Click);
            // 
            // GaussEdgeButton
            // 
            this.GaussEdgeButton.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.GaussEdgeButton.Location = new System.Drawing.Point(281, 287);
            this.GaussEdgeButton.Name = "GaussEdgeButton";
            this.GaussEdgeButton.Size = new System.Drawing.Size(187, 23);
            this.GaussEdgeButton.TabIndex = 13;
            this.GaussEdgeButton.Text = "ガウス後先鋭化";
            this.GaussEdgeButton.UseVisualStyleBackColor = true;
            this.GaussEdgeButton.Click += new System.EventHandler(this.GaussEdgeButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 329);
            this.Controls.Add(this.GaussEdgeButton);
            this.Controls.Add(this.EdgeDetect8Button);
            this.Controls.Add(this.EdgeDetect4Button);
            this.Controls.Add(this.FileNameBox);
            this.Controls.Add(this.ImageSaveButton);
            this.Controls.Add(this.GaussFilterButton5);
            this.Controls.Add(this.SIGMA_Value);
            this.Controls.Add(this.SIGMA_trackBar);
            this.Controls.Add(this.GrayScaleButton);
            this.Controls.Add(this.AveragingButton);
            this.Controls.Add(this.ErrorLavel);
            this.Controls.Add(this.ResetImageButton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.GaussFilterButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SIGMA_trackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button GaussFilterButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ResetImageButton;
        private System.Windows.Forms.Label ErrorLavel;
        private System.Windows.Forms.Button AveragingButton;
        private System.Windows.Forms.Button GrayScaleButton;
        private System.Windows.Forms.TrackBar SIGMA_trackBar;
        private System.Windows.Forms.Label SIGMA_Value;
        private System.Windows.Forms.Button GaussFilterButton5;
        private System.Windows.Forms.Button ImageSaveButton;
        private System.Windows.Forms.TextBox FileNameBox;
        private System.Windows.Forms.Button EdgeDetect4Button;
        private System.Windows.Forms.Button EdgeDetect8Button;
        private System.Windows.Forms.Button GaussEdgeButton;
    }
}

