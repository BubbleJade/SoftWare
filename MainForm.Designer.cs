namespace PDFImageConverter
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabImageToPdf;
        private System.Windows.Forms.TabPage tabPdfToImage;
        private System.Windows.Forms.Button btnSelectImages;
        private System.Windows.Forms.ListBox listBoxImages;
        private System.Windows.Forms.Button btnConvertToPDF;
        private System.Windows.Forms.Button btnClearImages;
        private System.Windows.Forms.Button btnMoveUp;
        private System.Windows.Forms.Button btnMoveDown;
        private System.Windows.Forms.Button btnRemoveSelected;
        private System.Windows.Forms.Label lblImageCount;
        private System.Windows.Forms.Button btnSelectPDF;
        private System.Windows.Forms.TextBox txtPdfPath;
        private System.Windows.Forms.ComboBox cmbImageFormat;
        private System.Windows.Forms.TrackBar trackBarQuality;
        private System.Windows.Forms.Label lblQualityValue;
        private System.Windows.Forms.Button btnConvertToImages;
        private System.Windows.Forms.Label lblPdfInfo;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.NumericUpDown numericDPI;
        private System.Windows.Forms.Button btnOpenFolder;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabImageToPdf = new System.Windows.Forms.TabPage();
            this.tabPdfToImage = new System.Windows.Forms.TabPage();
            this.btnSelectImages = new System.Windows.Forms.Button();
            this.listBoxImages = new System.Windows.Forms.ListBox();
            this.btnConvertToPDF = new System.Windows.Forms.Button();
            this.btnClearImages = new System.Windows.Forms.Button();
            this.btnMoveUp = new System.Windows.Forms.Button();
            this.btnMoveDown = new System.Windows.Forms.Button();
            this.btnRemoveSelected = new System.Windows.Forms.Button();
            this.lblImageCount = new System.Windows.Forms.Label();
            this.btnSelectPDF = new System.Windows.Forms.Button();
            this.txtPdfPath = new System.Windows.Forms.TextBox();
            this.cmbImageFormat = new System.Windows.Forms.ComboBox();
            this.trackBarQuality = new System.Windows.Forms.TrackBar();
            this.lblQualityValue = new System.Windows.Forms.Label();
            this.btnConvertToImages = new System.Windows.Forms.Button();
            this.lblPdfInfo = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.lblStatus = new System.Windows.Forms.Label();
            this.numericDPI = new System.Windows.Forms.NumericUpDown();
            this.btnOpenFolder = new System.Windows.Forms.Button();

            this.tabControl.SuspendLayout();
            this.tabImageToPdf.SuspendLayout();
            this.tabPdfToImage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDPI)).BeginInit();
            this.SuspendLayout();

            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabImageToPdf);
            this.tabControl.Controls.Add(this.tabPdfToImage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControl.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(800, 450);
            this.tabControl.TabIndex = 0;

            // 
            // tabImageToPdf
            // 
            this.tabImageToPdf.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabImageToPdf.Controls.Add(this.btnSelectImages);
            this.tabImageToPdf.Controls.Add(this.listBoxImages);
            this.tabImageToPdf.Controls.Add(this.btnConvertToPDF);
            this.tabImageToPdf.Controls.Add(this.btnClearImages);
            this.tabImageToPdf.Controls.Add(this.btnMoveUp);
            this.tabImageToPdf.Controls.Add(this.btnMoveDown);
            this.tabImageToPdf.Controls.Add(this.btnRemoveSelected);
            this.tabImageToPdf.Controls.Add(this.lblImageCount);
            this.tabImageToPdf.Location = new System.Drawing.Point(4, 28);
            this.tabImageToPdf.Name = "tabImageToPdf";
            this.tabImageToPdf.Padding = new System.Windows.Forms.Padding(3);
            this.tabImageToPdf.Size = new System.Drawing.Size(792, 418);
            this.tabImageToPdf.TabIndex = 0;
            this.tabImageToPdf.Text = "📄 图片转PDF";

            // 
            // btnSelectImages
            // 
            this.btnSelectImages.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnSelectImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectImages.ForeColor = System.Drawing.Color.White;
            this.btnSelectImages.Location = new System.Drawing.Point(20, 20);
            this.btnSelectImages.Name = "btnSelectImages";
            this.btnSelectImages.Size = new System.Drawing.Size(150, 40);
            this.btnSelectImages.TabIndex = 0;
            this.btnSelectImages.Text = "📁 选择图片";
            this.btnSelectImages.UseVisualStyleBackColor = false;
            this.btnSelectImages.Click += new System.EventHandler(this.btnSelectImages_Click);

            // 
            // listBoxImages
            // 
            this.listBoxImages.BackColor = System.Drawing.Color.White;
            this.listBoxImages.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listBoxImages.FormattingEnabled = true;
            this.listBoxImages.ItemHeight = 19;
            this.listBoxImages.Location = new System.Drawing.Point(20, 100);
            this.listBoxImages.Name = "listBoxImages";
            this.listBoxImages.Size = new System.Drawing.Size(520, 250);
            this.listBoxImages.TabIndex = 1;

            // 
            // lblImageCount
            // 
            this.lblImageCount.AutoSize = true;
            this.lblImageCount.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblImageCount.ForeColor = System.Drawing.Color.Gray;
            this.lblImageCount.Location = new System.Drawing.Point(20, 75);
            this.lblImageCount.Name = "lblImageCount";
            this.lblImageCount.Size = new System.Drawing.Size(100, 17);
            this.lblImageCount.Text = "已选择 0 张图片";

            // 
            // btnMoveUp
            // 
            this.btnMoveUp.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.btnMoveUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveUp.ForeColor = System.Drawing.Color.White;
            this.btnMoveUp.Location = new System.Drawing.Point(560, 100);
            this.btnMoveUp.Name = "btnMoveUp";
            this.btnMoveUp.Size = new System.Drawing.Size(100, 35);
            this.btnMoveUp.TabIndex = 2;
            this.btnMoveUp.Text = "⬆️ 上移";
            this.btnMoveUp.UseVisualStyleBackColor = false;
            this.btnMoveUp.Click += new System.EventHandler(this.btnMoveUp_Click);

            // 
            // btnMoveDown
            // 
            this.btnMoveDown.BackColor = System.Drawing.Color.FromArgb(241, 196, 15);
            this.btnMoveDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMoveDown.ForeColor = System.Drawing.Color.White;
            this.btnMoveDown.Location = new System.Drawing.Point(560, 145);
            this.btnMoveDown.Name = "btnMoveDown";
            this.btnMoveDown.Size = new System.Drawing.Size(100, 35);
            this.btnMoveDown.TabIndex = 3;
            this.btnMoveDown.Text = "⬇️ 下移";
            this.btnMoveDown.UseVisualStyleBackColor = false;
            this.btnMoveDown.Click += new System.EventHandler(this.btnMoveDown_Click);

            // 
            // btnRemoveSelected
            // 
            this.btnRemoveSelected.BackColor = System.Drawing.Color.FromArgb(231, 76, 60);
            this.btnRemoveSelected.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveSelected.ForeColor = System.Drawing.Color.White;
            this.btnRemoveSelected.Location = new System.Drawing.Point(560, 190);
            this.btnRemoveSelected.Name = "btnRemoveSelected";
            this.btnRemoveSelected.Size = new System.Drawing.Size(100, 35);
            this.btnRemoveSelected.TabIndex = 4;
            this.btnRemoveSelected.Text = "🗑️ 删除";
            this.btnRemoveSelected.UseVisualStyleBackColor = false;
            this.btnRemoveSelected.Click += new System.EventHandler(this.btnRemoveSelected_Click);

            // 
            // btnClearImages
            // 
            this.btnClearImages.BackColor = System.Drawing.Color.FromArgb(149, 165, 166);
            this.btnClearImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearImages.ForeColor = System.Drawing.Color.White;
            this.btnClearImages.Location = new System.Drawing.Point(190, 20);
            this.btnClearImages.Name = "btnClearImages";
            this.btnClearImages.Size = new System.Drawing.Size(150, 40);
            this.btnClearImages.TabIndex = 5;
            this.btnClearImages.Text = "🔄 清空列表";
            this.btnClearImages.UseVisualStyleBackColor = false;
            this.btnClearImages.Click += new System.EventHandler(this.btnClearImages_Click);

            // 
            // btnConvertToPDF
            // 
            this.btnConvertToPDF.BackColor = System.Drawing.Color.FromArgb(46, 204, 113);
            this.btnConvertToPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertToPDF.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.btnConvertToPDF.ForeColor = System.Drawing.Color.White;
            this.btnConvertToPDF.Location = new System.Drawing.Point(20, 365);
            this.btnConvertToPDF.Name = "btnConvertToPDF";
            this.btnConvertToPDF.Size = new System.Drawing.Size(520, 45);
            this.btnConvertToPDF.TabIndex = 6;
            this.btnConvertToPDF.Text = "🚀 生成PDF文件";
            this.btnConvertToPDF.UseVisualStyleBackColor = false;
            this.btnConvertToPDF.Click += new System.EventHandler(this.btnConvertToPDF_Click);

            // 
            // tabPdfToImage
            // 
            this.tabPdfToImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPdfToImage.Controls.Add(this.btnSelectPDF);
            this.tabPdfToImage.Controls.Add(this.txtPdfPath);
            this.tabPdfToImage.Controls.Add(this.lblPdfInfo);
            this.tabPdfToImage.Controls.Add(this.cmbImageFormat);
            this.tabPdfToImage.Controls.Add(this.trackBarQuality);
            this.tabPdfToImage.Controls.Add(this.lblQualityValue);
            this.tabPdfToImage.Controls.Add(this.numericDPI);
            this.tabPdfToImage.Controls.Add(this.btnConvertToImages);
            this.tabPdfToImage.Controls.Add(this.btnOpenFolder);
            this.tabPdfToImage.Location = new System.Drawing.Point(4, 28);
            this.tabPdfToImage.Name = "tabPdfToImage";
            this.tabPdfToImage.Padding = new System.Windows.Forms.Padding(3);
            this.tabPdfToImage.Size = new System.Drawing.Size(792, 418);
            this.tabPdfToImage.TabIndex = 1;
            this.tabPdfToImage.Text = "🖼️ PDF转图片";

            // 
            // btnSelectPDF
            // 
            this.btnSelectPDF.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnSelectPDF.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelectPDF.ForeColor = System.Drawing.Color.White;
            this.btnSelectPDF.Location = new System.Drawing.Point(20, 20);
            this.btnSelectPDF.Name = "btnSelectPDF";
            this.btnSelectPDF.Size = new System.Drawing.Size(150, 40);
            this.btnSelectPDF.TabIndex = 0;
            this.btnSelectPDF.Text = "📁 选择PDF";
            this.btnSelectPDF.UseVisualStyleBackColor = false;
            this.btnSelectPDF.Click += new System.EventHandler(this.btnSelectPDF_Click);

            // 
            // txtPdfPath
            // 
            this.txtPdfPath.BackColor = System.Drawing.Color.White;
            this.txtPdfPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPdfPath.Location = new System.Drawing.Point(190, 25);
            this.txtPdfPath.Name = "txtPdfPath";
            this.txtPdfPath.ReadOnly = true;
            this.txtPdfPath.Size = new System.Drawing.Size(580, 25);
            this.txtPdfPath.TabIndex = 1;

            // 
            // lblPdfInfo
            // 
            this.lblPdfInfo.AutoSize = true;
            this.lblPdfInfo.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblPdfInfo.ForeColor = System.Drawing.Color.Gray;
            this.lblPdfInfo.Location = new System.Drawing.Point(20, 75);
            this.lblPdfInfo.Name = "lblPdfInfo";
            this.lblPdfInfo.Size = new System.Drawing.Size(80, 17);
            this.lblPdfInfo.Text = "PDF页数：0 页";

            // 
            // cmbImageFormat
            // 
            this.cmbImageFormat.BackColor = System.Drawing.Color.White;
            this.cmbImageFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbImageFormat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbImageFormat.FormattingEnabled = true;
            this.cmbImageFormat.Items.AddRange(new object[] { "PNG", "JPG" });
            this.cmbImageFormat.Location = new System.Drawing.Point(20, 130);
            this.cmbImageFormat.Name = "cmbImageFormat";
            this.cmbImageFormat.Size = new System.Drawing.Size(150, 27);
            this.cmbImageFormat.TabIndex = 2;

            // 
            // Label - 图片格式
            // 
            var lblFormat = new System.Windows.Forms.Label();
            lblFormat.AutoSize = true;
            lblFormat.Font = new System.Drawing.Font("微软雅黑", 9F);
            lblFormat.Location = new System.Drawing.Point(20, 105);
            lblFormat.Name = "lblFormat";
            lblFormat.Size = new System.Drawing.Size(80, 17);
            lblFormat.Text = "🎨 图片格式：";
            this.tabPdfToImage.Controls.Add(lblFormat);

            // 
            // trackBarQuality
            // 
            this.trackBarQuality.BackColor = System.Drawing.Color.WhiteSmoke;
            this.trackBarQuality.Location = new System.Drawing.Point(20, 210);
            this.trackBarQuality.Maximum = 100;
            this.trackBarQuality.Minimum = 10;
            this.trackBarQuality.Name = "trackBarQuality";
            this.trackBarQuality.Size = new System.Drawing.Size(400, 45);
            this.trackBarQuality.TabIndex = 3;
            this.trackBarQuality.TickFrequency = 10;
            this.trackBarQuality.Value = 90;
            this.trackBarQuality.Scroll += new System.EventHandler(this.trackBarQuality_Scroll);

            // 
            // Label - 图片质量
            // 
            var lblQuality = new System.Windows.Forms.Label();
            lblQuality.AutoSize = true;
            lblQuality.Font = new System.Drawing.Font("微软雅黑", 9F);
            lblQuality.Location = new System.Drawing.Point(20, 185);
            lblQuality.Name = "lblQuality";
            lblQuality.Size = new System.Drawing.Size(80, 17);
            lblQuality.Text = "✨ 图片质量：";
            this.tabPdfToImage.Controls.Add(lblQuality);

            // 
            // lblQualityValue
            // 
            this.lblQualityValue.AutoSize = true;
            this.lblQualityValue.Font = new System.Drawing.Font("微软雅黑", 10F, System.Drawing.FontStyle.Bold);
            this.lblQualityValue.ForeColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.lblQualityValue.Location = new System.Drawing.Point(430, 220);
            this.lblQualityValue.Name = "lblQualityValue";
            this.lblQualityValue.Size = new System.Drawing.Size(40, 19);
            this.lblQualityValue.Text = "90%";

            // 
            // numericDPI
            // 
            this.numericDPI.BackColor = System.Drawing.Color.White;
            this.numericDPI.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericDPI.Location = new System.Drawing.Point(20, 290);
            this.numericDPI.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            this.numericDPI.Minimum = new decimal(new int[] { 72, 0, 0, 0 });
            this.numericDPI.Name = "numericDPI";
            this.numericDPI.Size = new System.Drawing.Size(150, 25);
            this.numericDPI.TabIndex = 4;
            this.numericDPI.Value = new decimal(new int[] { 300, 0, 0, 0 });
            this.numericDPI.Increment = new decimal(new int[] { 50, 0, 0, 0 });

            // 
            // Label - DPI设置
            // 
            var lblDPI = new System.Windows.Forms.Label();
            lblDPI.AutoSize = true;
            lblDPI.Font = new System.Drawing.Font("微软雅黑", 9F);
            lblDPI.Location = new System.Drawing.Point(20, 265);
            lblDPI.Name = "lblDPI";
            lblDPI.Size = new System.Drawing.Size(180, 17);
            lblDPI.Text = "🔍 分辨率 (DPI)：72-3000";
            this.tabPdfToImage.Controls.Add(lblDPI);

            // 添加DPI提示标签
            var lblDPIHint = new System.Windows.Forms.Label();
            lblDPIHint.AutoSize = true;
            lblDPIHint.Font = new System.Drawing.Font("微软雅黑", 7.5F);
            lblDPIHint.ForeColor = System.Drawing.Color.Gray;
            lblDPIHint.Location = new System.Drawing.Point(180, 293);
            lblDPIHint.Name = "lblDPIHint";
            lblDPIHint.Size = new System.Drawing.Size(200, 15);
            lblDPIHint.Text = "⚠️ 超过1920以上可能很慢且占用大量内存";
            this.tabPdfToImage.Controls.Add(lblDPIHint);

            // 
            // btnConvertToImages
            // 
            this.btnConvertToImages.BackColor = System.Drawing.Color.FromArgb(155, 89, 182);
            this.btnConvertToImages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConvertToImages.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold);
            this.btnConvertToImages.ForeColor = System.Drawing.Color.White;
            this.btnConvertToImages.Location = new System.Drawing.Point(20, 350);
            this.btnConvertToImages.Name = "btnConvertToImages";
            this.btnConvertToImages.Size = new System.Drawing.Size(350, 50);
            this.btnConvertToImages.TabIndex = 5;
            this.btnConvertToImages.Text = "🚀 转换为图片";
            this.btnConvertToImages.UseVisualStyleBackColor = false;
            this.btnConvertToImages.Click += new System.EventHandler(this.btnConvertToImages_Click);

            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.BackColor = System.Drawing.Color.FromArgb(52, 152, 219);
            this.btnOpenFolder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOpenFolder.Font = new System.Drawing.Font("微软雅黑", 10F);
            this.btnOpenFolder.ForeColor = System.Drawing.Color.White;
            this.btnOpenFolder.Location = new System.Drawing.Point(390, 350);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(180, 50);
            this.btnOpenFolder.TabIndex = 6;
            this.btnOpenFolder.Text = "📂 打开文件夹";
            this.btnOpenFolder.UseVisualStyleBackColor = false;
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);

            // 
            // progressBar
            // 
            this.progressBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar.Location = new System.Drawing.Point(0, 470);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(800, 25);
            this.progressBar.TabIndex = 1;

            // 
            // lblStatus
            // 
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblStatus.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.lblStatus.Location = new System.Drawing.Point(0, 450);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.lblStatus.Size = new System.Drawing.Size(800, 20);
            this.lblStatus.TabIndex = 2;
            this.lblStatus.Text = "就绪";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 495);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PDF图片互转工具 v1.0";
            this.tabControl.ResumeLayout(false);
            this.tabImageToPdf.ResumeLayout(false);
            this.tabImageToPdf.PerformLayout();
            this.tabPdfToImage.ResumeLayout(false);
            this.tabPdfToImage.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericDPI)).EndInit();
            this.ResumeLayout(false);
        }
    }
}