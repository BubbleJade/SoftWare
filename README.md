## 项目概述
PdfImageConverter 是一个使用 C# 和 .NET 8.0 框架在 Visual Studio 2022 中构建的 Windows 桌面应用程序。它提供图像转 PDF 和 PDF 转图像的工具，支持批量处理和自定义设置。该应用程序优先使用 WPF 来实现现代、响应式的用户界面，提供流畅的用户体验。

## 主要功能
### 1. 图像转 PDF 转换
- 从文件夹中选择多个图像文件（JPG、PNG、BMP、GIF 等常见格式）。
- 将它们合并成一个 PDF 文件。
- 自定义输出 PDF 路径、页面大小（默认：A4，支持自定义选项）和压缩级别（低/中/高，默认：中）。
- 预览并重新排序图像（通过拖拽或箭头）。

### 2. PDF 转图像转换
- 选择一个或多个 PDF 文件。
- 将每个 PDF 页面转换为单个 PNG 或 JPG 图像。
- 为每个 PDF 创建一个新文件夹（文件夹名为 PDF 文件名，不含扩展名）来存储输出图像。
- 自定义图像格式（PNG 或 JPG，默认：PNG）、质量（1-100，默认：85）、分辨率（DPI，默认：300）和输出根目录。

### 附加功能
- **批量处理**：一次性处理多个文件夹或 PDF。
- **进度跟踪**：实时进度条，显示百分比和剩余时间估计。
- **日志记录**：记录转换历史和错误到本地日志文件，支持查看和导出。
- **拖拽支持**：通过拖拽将文件或文件夹轻松添加到 UI。
- **设置菜单**：主题切换（浅色/深色，默认：系统主题）、默认路径配置。
- **配置导出/导入**：以 JSON 格式保存和加载用户设置。

## 要求
- **操作系统**：Windows 10 或更高版本。
- **框架**：.NET 8.0 运行时（通过 Visual Studio 自动安装，或从 Microsoft 下载）。
- **开发环境**：Visual Studio 2022（用于从源代码构建）。
- **高 DPI 支持**：UI 针对高分辨率屏幕进行了优化。

## 依赖项
项目使用以下 NuGet 包：
- PdfSharpCore：用于 PDF 处理（`dotnet add package PdfSharpCore`）。
- SkiaSharp：用于图像处理（`dotnet add package SkiaSharp`）。
- CommunityToolkit.Mvvm：用于 MVVM 模式（`dotnet add package CommunityToolkit.Mvvm`）。
- 可选：Microsoft.Extensions.Logging 用于日志记录，Newtonsoft.Json 用于配置处理。

## 项目结构
- **解决方案**：PdfImageConverter.sln
- **项目**：PdfImageConverter.csproj（WPF 应用程序）
- **文件夹**：
  - Models：数据模型（例如，ImageModel、PdfSettings）。
  - Views：UI XAML 文件（例如，MainWindow.xaml）。
  - ViewModels：MVVM 逻辑（例如，MainViewModel）。
  - Services：转换服务（例如，PdfConversionService）。
  - Helpers：实用类（例如，FileHelper、Logger）。
- **图标**：appicon.ico（在项目属性下的应用程序 > 图标和清单中设置）。

## 构建和运行
1. 克隆仓库或下载源代码。
2. 在 Visual Studio 2022 中打开 PdfImageConverter.sln。
3. 还原 NuGet 包（右键点击解决方案 > 还原 NuGet 包）。
4. 构建解决方案（`dotnet build` 或 VS 中的构建 > 构建解决方案）。
5. 运行应用程序（`dotnet run` 或 VS 中的 F5）。
6. 对于发布构建：通过 Visual Studio 发布（右键点击项目 > 发布）或 `dotnet publish -c Release`。

## 使用方法
1. 启动应用程序。
2. 在主窗口中：
   - 通过菜单或按钮选择转换模式（图像转 PDF 或 PDF 转图像）。
   - 选择文件/文件夹（或拖拽）。
   - 在面板中调整设置（例如，压缩、质量）。
   - 如适用，进行预览。
   - 点击“转换”并监控进度。
3. 通过菜单访问设置，用于主题、默认值或日志查看。
4. 处理错误：会出现用户友好的消息；检查日志以获取详细信息。

## 测试
- **图像转 PDF 测试**：选择包含图像的文件夹，设置自定义页面大小，重新排序预览，转换，并验证输出 PDF。
- **PDF 转图像测试**：选择 PDF，设置 JPG 格式和低质量，转换，并检查生成的文件夹/图像。
- **批量测试**：添加多个项，开始转换，中途取消，并查看日志。
- **边缘案例**：测试大文件、无效路径、高 DPI 和主题切换。

## 最佳实践和注意事项
- 应用程序使用异步操作来保持 UI 响应。
- 通过流式传输和释放来优化大文件的内存使用。
- 支持转换期间的取消。
- 代码遵循 MVVM 以提高可维护性，并可进行单元测试（使用 xUnit 为 Services 层添加测试项目）。

对于问题或贡献，请在 GitHub 上打开 issue（假设托管在 GitHub 上）。此项目采用 MIT 许可开源。
