# NetCoreAPI
## 1. Cấu trúc thư mục dự án ASP.NET Core MVC

- Controllers/
 - Thư mục chứa các controller (code để xử lý yêu cầu từ View gửi về)
- Models/
  - Chứa các lớp mô tả dữ liệu (Entity, ViewModel)
  - Chứa các lớp đại diện cho CSDL của ứng dụng

- Views/
  - Thư mục chứa các thành phần hiển thị giao diện người dùng (cshtml)
  - Mỗi Controller có một thư mục View tương ứng

- wwwroot/
  - Thư mục Chứa các file của dự án (HTML, CSS, JS)
- Program.cs
  - Cấu hình ứng dụng, middleware và routing
- appsettings.json
  - Cấu hình ứng dụng (connection string, logging)
-appsetting và Program
  -File chứa code cấu hình dự án

## 2.định tuyến (Route) trong .Net MVC 
MVC sẽ gọi bộ điều khiển (Controller) và các hành động bên trong (Action) thông qua URL
Logic định tuyến MVC sử dụng dạng: /[Controller]/[Action]/[Parameters]
Định tuyến được cấu hình trong file Program.cs: 
                            app.MapControllerRoute(
                              name: "default",
                              pattern: "{controller=Home}/{action=Index}/{id?}");
Giải thích:
- controller: tên Controller
- action: tên phương thức
- id: tham số tùy chọn
Ví dụ:
- /Home/Index
- /Demo/Index

## Namespace trong C#
-Namespace dùng để tổ chức code
-Tránh trùng tên class
-Ví dụ:
namespace DemoMvcProject.Controllers
{
    public class DemoController : Controller
    {
    }
}
## Controller, View trong .Net MVC
Tên của Controller bắt buộc phải có phần hậu tố Controller: Ví dụ StudentController, PersonController
Nằm trong thư mục Controllers
Nhiệm vụ của Controller:
Xử lý các yêu cầu của người dùng gửi tới từ View.
Truy xuất dữ liệu trong cơ sở dữ liệu.
Gọi các mẫu View và trả về dữ liệu
Mặc định khi tạo project sẽ có HomeController
Trong controller sẽ chứa các action (ví dụ: Index, Privacy), mỗi action sẽ thực thi một nhiệm vụ cụ thể (trả về các view tương ứng)
Chọn thư mục Controllers, click chuột phải => New File => đặt tên file là HelloWorldController.cs:
## View
Có phần mở rộng là “.cshtml”
Nằm trong thư mục Views/Controler_Name (tương ứng với HelloWorldController sẽ có thư mục HelloWorld trong thư mục Views)
Nhiệm vụ của View: Cung cấp giao diện người dùng (HTML) bằng C#
Trong thư mục Views =>Tạo thư mục HelloWorld => tạo file Index.cshtml

