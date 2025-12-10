using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using iTextSharp.text.pdf;
using Docnet.Core;
using Docnet.Core.Models;

namespace PDFImageConverter
{
    public partial class MainForm : Form
    {
        private List<string> selectedImages = new List<string>();
        private string selectedPdfPath = "";

        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            // 设置默认值
            cmbImageFormat.SelectedIndex = 0;
            trackBarQuality.Value = 95; // 提高默认质量到95
            lblQualityValue.Text = "95%";
            numericDPI.Value = 300; // 默认300 DPI
            UpdateImageList();
        }

        // 图片转PDF - 选择图片
        private void btnSelectImages_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "图片文件|*.jpg;*.jpeg;*.png;*.bmp;*.gif;*.tiff|所有文件|*.*";
                ofd.Multiselect = true;
                ofd.Title = "选择要转换为PDF的图片";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedImages.AddRange(ofd.FileNames);
                    UpdateImageList();
                }
            }
        }

        // 更新图片列表显示
        private void UpdateImageList()
        {
            listBoxImages.Items.Clear();
            foreach (var img in selectedImages)
            {
                listBoxImages.Items.Add(Path.GetFileName(img));
            }
            lblImageCount.Text = $"已选择 {selectedImages.Count} 张图片";
        }

        // 清空图片列表
        private void btnClearImages_Click(object sender, EventArgs e)
        {
            selectedImages.Clear();
            UpdateImageList();
        }

        // 上移图片
        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (listBoxImages.SelectedIndex > 0)
            {
                int index = listBoxImages.SelectedIndex;
                var temp = selectedImages[index];
                selectedImages[index] = selectedImages[index - 1];
                selectedImages[index - 1] = temp;
                UpdateImageList();
                listBoxImages.SelectedIndex = index - 1;
            }
        }

        // 下移图片
        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (listBoxImages.SelectedIndex >= 0 && listBoxImages.SelectedIndex < selectedImages.Count - 1)
            {
                int index = listBoxImages.SelectedIndex;
                var temp = selectedImages[index];
                selectedImages[index] = selectedImages[index + 1];
                selectedImages[index + 1] = temp;
                UpdateImageList();
                listBoxImages.SelectedIndex = index + 1;
            }
        }

        // 删除选中的图片
        private void btnRemoveSelected_Click(object sender, EventArgs e)
        {
            if (listBoxImages.SelectedIndex >= 0)
            {
                selectedImages.RemoveAt(listBoxImages.SelectedIndex);
                UpdateImageList();
            }
        }

        // 生成PDF
        private void btnConvertToPDF_Click(object sender, EventArgs e)
        {
            if (selectedImages.Count == 0)
            {
                MessageBox.Show("请先选择图片！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PDF文件|*.pdf";
                sfd.Title = "保存PDF文件";
                sfd.FileName = "合并图片_" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + ".pdf";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        progressBar.Value = 0;
                        progressBar.Maximum = selectedImages.Count;
                        lblStatus.Text = "正在生成PDF...";

                        ConvertImagesToPDF(selectedImages, sfd.FileName);

                        progressBar.Value = progressBar.Maximum;
                        lblStatus.Text = "PDF生成成功！";
                        MessageBox.Show($"PDF文件已保存至：\n{sfd.FileName}", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        lblStatus.Text = "生成失败";
                        MessageBox.Show($"生成PDF时出错：\n{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // 图片转PDF核心方法
        private void ConvertImagesToPDF(List<string> imagePaths, string outputPath)
        {
            using (FileStream fs = new FileStream(outputPath, FileMode.Create))
            {
                iTextSharp.text.Document document = new iTextSharp.text.Document();
                PdfWriter writer = PdfWriter.GetInstance(document, fs);
                document.Open();

                for (int i = 0; i < imagePaths.Count; i++)
                {
                    iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance(imagePaths[i]);

                    // 根据图片大小设置页面大小
                    document.SetPageSize(new iTextSharp.text.Rectangle(img.Width, img.Height));
                    document.NewPage();

                    // 图片适应页面
                    img.SetAbsolutePosition(0, 0);
                    document.Add(img);

                    progressBar.Value = i + 1;
                    Application.DoEvents();
                }

                document.Close();
            }
        }

        // PDF转图片 - 选择PDF
        private void btnSelectPDF_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "PDF文件|*.pdf|所有文件|*.*";
                ofd.Title = "选择要转换的PDF文件";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedPdfPath = ofd.FileName;
                    txtPdfPath.Text = selectedPdfPath;

                    // 获取PDF页数
                    try
                    {
                        using (var library = DocLib.Instance)
                        using (var docReader = library.GetDocReader(selectedPdfPath, new PageDimensions()))
                        {
                            lblPdfInfo.Text = $"PDF页数：{docReader.GetPageCount()} 页";
                        }
                    }
                    catch
                    {
                        lblPdfInfo.Text = "无法读取PDF信息";
                    }
                }
            }
        }

        // 质量滑块变化
        private void trackBarQuality_Scroll(object sender, EventArgs e)
        {
            lblQualityValue.Text = trackBarQuality.Value + "%";
        }

        // PDF转图片
        private void btnConvertToImages_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(selectedPdfPath))
            {
                MessageBox.Show("请先选择PDF文件！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int dpi = (int)numericDPI.Value;

            // 高DPI警告
            if (dpi > 1920)
            {
                var result = MessageBox.Show(
                    $"您选择了超高分辨率 {dpi} DPI！\n\n" +
                    "⚠️ 警告：\n" +
                    "• 转换速度将非常慢\n" +
                    "• 每页可能需要 1 秒\n" +
                    "• 可能占用大量内存（建议至少 8GB RAM）\n" +
                    "• 生成的图片文件可能非常大（每页 2-5MB）\n\n" +
                    "是否继续？",
                    "超高分辨率警告",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                {
                    return;
                }
            }

            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                fbd.Description = "选择图片保存文件夹";
                fbd.ShowNewFolderButton = true;

                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        lblStatus.Text = "正在转换PDF...";
                        string format = cmbImageFormat.SelectedItem.ToString().ToLower();
                        int quality = trackBarQuality.Value;

                        ConvertPDFToImages(selectedPdfPath, fbd.SelectedPath, format, quality, dpi);

                        lblStatus.Text = "转换完成！";
                        MessageBox.Show($"图片已保存至：\n{fbd.SelectedPath}", "成功", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        lblStatus.Text = "转换失败";
                        MessageBox.Show($"转换PDF时出错：\n{ex.Message}", "错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        // PDF转图片核心方法 - 增强版（支持超高DPI）
        private void ConvertPDFToImages(string pdfPath, string outputFolder, string format, int quality, int dpi)
        {
            string pdfFileName = Path.GetFileNameWithoutExtension(pdfPath);

            using (var library = DocLib.Instance)
            {
                // 使用更高的渲染质量设置
                var pageDimensions = new PageDimensions(dpi, dpi);

                using (var docReader = library.GetDocReader(pdfPath, pageDimensions))
                {
                    int pageCount = docReader.GetPageCount();
                    progressBar.Value = 0;
                    progressBar.Maximum = pageCount;

                    var startTime = DateTime.Now;

                    for (int i = 0; i < pageCount; i++)
                    {
                        // 更新状态显示
                        lblStatus.Text = $"正在转换第 {i + 1}/{pageCount} 页... (DPI: {dpi})";
                        Application.DoEvents();

                        using (var pageReader = docReader.GetPageReader(i))
                        {
                            // 获取原始图像数据
                            var rawBytes = pageReader.GetImage();
                            var width = pageReader.GetPageWidth();
                            var height = pageReader.GetPageHeight();

                            // 显示当前页面信息
                            double sizeMB = (rawBytes.Length / 1024.0 / 1024.0);
                            lblStatus.Text = $"正在处理第 {i + 1}/{pageCount} 页 ({width}x{height}px, {sizeMB:F1}MB)...";
                            Application.DoEvents();

                            // 创建高质量位图
                            using (var bitmap = new Bitmap(width, height, PixelFormat.Format32bppArgb))
                            {
                                // 设置高质量渲染
                                bitmap.SetResolution(dpi, dpi);

                                var bitmapData = bitmap.LockBits(
                                    new Rectangle(0, 0, width, height),
                                    ImageLockMode.WriteOnly,
                                    bitmap.PixelFormat);

                                // 复制图像数据
                                System.Runtime.InteropServices.Marshal.Copy(rawBytes, 0, bitmapData.Scan0, rawBytes.Length);
                                bitmap.UnlockBits(bitmapData);

                                // 保存图片
                                string outputPath = Path.Combine(outputFolder, $"{pdfFileName}_页{i + 1}.{format}");

                                lblStatus.Text = $"正在保存第 {i + 1}/{pageCount} 页...";
                                Application.DoEvents();

                                if (format == "jpg" || format == "jpeg")
                                {
                                    SaveJpegWithQuality(bitmap, outputPath, quality);
                                }
                                else // PNG - 无损格式
                                {
                                    bitmap.Save(outputPath, ImageFormat.Png);
                                }
                            }
                        }

                        progressBar.Value = i + 1;

                        // 显示已用时间和预计剩余时间
                        var elapsed = DateTime.Now - startTime;
                        var avgTimePerPage = elapsed.TotalSeconds / (i + 1);
                        var remainingPages = pageCount - (i + 1);
                        var estimatedRemaining = TimeSpan.FromSeconds(avgTimePerPage * remainingPages);

                        lblStatus.Text = $"已完成 {i + 1}/{pageCount} 页 | 预计剩余时间: {estimatedRemaining:mm\\:ss}";
                        Application.DoEvents();

                        // 强制垃圾回收（高DPI时释放内存）
                        if (dpi > 1200 && (i + 1) % 5 == 0)
                        {
                            GC.Collect();
                            GC.WaitForPendingFinalizers();
                        }
                    }

                    var totalTime = DateTime.Now - startTime;
                    lblStatus.Text = $"转换完成！总用时: {totalTime:mm\\:ss}";
                }
            }
        }

        // 保存JPEG并设置质量
        private void SaveJpegWithQuality(Bitmap image, string path, int quality)
        {
            var encoderParameters = new EncoderParameters(1);
            encoderParameters.Param[0] = new EncoderParameter(System.Drawing.Imaging.Encoder.Quality, quality);
            var codec = ImageCodecInfo.GetImageDecoders().FirstOrDefault(c => c.FormatID == ImageFormat.Jpeg.Guid);
            image.Save(path, codec, encoderParameters);
        }

        // 打开输出文件夹
        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog())
            {
                if (fbd.ShowDialog() == DialogResult.OK)
                {
                    System.Diagnostics.Process.Start("explorer.exe", fbd.SelectedPath);
                }
            }
        }
    }
}