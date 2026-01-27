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
##ViewBag
ViewBag: là phương thức hỗ trợ gửi dữ liệu từ Controller tới View
Trong đó:
@ViewBag.Message: sử dụng để hiển thị dữ liệu từ Controller gửi về.
Ký tự @ để thể hiện cho mã C#.
ViewBag.Message: lấy từ bên Controller (code dòng 24) đưa sang.
Ví dụ:
@{
    ViewData["Title"] = "Home Page";    

}
<form asp-action="Index">
    <label>Nhập Họ tên: </label>
    <input type="text" name="FullName" />
    <label>Nhập địa chỉ: </label>
    <input type="text" name="Address" />
    <input type="submit" value="Gửi dữ liệu" />
</form>
##Gửi nhận dữ liệu giữa View và Controller thông qua Submit form.
Trong đó:
Thẻ form: dung để chứa các phần từ nhập liệu từ người dung.
asp-action="Index": chỉ định dữ liệu được gửi từ View lên action Index
input type="text": các ô để nhập dữ liệu gửi từ View
asp-action="submit": nút lệnh để thực hiện gửi dữ liệu từ form lên action ở controller
name của thẻ input: sử dụng để khớp với các thuộc tính ở phương thức Index trên Controller
HttpPost: sử dụng để chỉ định phương thức sẽ nhận dữ liệu từ View gửi lên.
2 thuộc tính FullName và Address của action Index: sử dụng để lưu dữ liệu từ View gửi lên, tên của 2 thuộc tính chính là name của các thẻ input muốn gửi dữ liệu trên View.
ViewBag: là phương thức hỗ trợ gửi dữ liệu từ Controller tới View


