# WEBSITE_HLSDL
WEBSITE HỖ TRỢ DẠY HỌC LỊCH SỬ - ĐỊA LÝ ĐỊA PHƯƠNG
## 🚀 Tính năng chính

- Quản lý nội dung bài viết (thêm/sửa/xóa)
- Quản lý tác giả, nhà xuất bản, thể loại
- Giao diện người dùng thân thiện
- Tìm kiếm tài liệu theo danh mục
- Hệ thống phân quyền người dùng
- Hỗ trợ đa ngôn ngữ
- Xác thực người dùng và bảo mật cao

## 🧱 Công nghệ sử dụng

- ASP.NET Core MVC
- SQL Server 2019
- Entity Framework Core
- HTML/CSS/JS

## ⚙️ Cài đặt và chạy dự án

### Yêu cầu hệ thống
- .NET SDK 6.0 trở lên
- SQL Server 2019 hoặc bản tương đương
- Visual Studio 2022 hoặc VS Code
### Các bước cài đặt

1. Clone dự án:
   ```bash
   git clone https://github.com/your-username/ten-du-an.git
   cd ten-du-an
2. Cấu hình chuỗi kết nối trong appsettings.json:
"ConnectionStrings": {
  "DefaultConnection": "Server=localhost;Database=TenCSDL;Trusted_Connection=True;"
}
   Khởi tạo cơ sở dữ liệu:
dotnet ef database update
4.Chạy dự án:
dotnet run
Truy cập website tại http://localhost:5000

📁 Cấu trúc thư mục
├── Controllers/
├── Models/
├── Views/
├── wwwroot/
├── Data/
├── Migrations/
├── appsettings.json
└── Program.cs
