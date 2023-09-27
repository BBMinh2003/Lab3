using System.ComponentModel.DataAnnotations;

namespace Thực_hành_1.Models
{
    public class Student
    {
        public int Id { get; set; }//Mã sinh viên
        [StringLength(100, MinimumLength = 4, ErrorMessage = "Họ tên tối thiểu 4 ký tự, tối đa 100 ký tự")]
        [Required(ErrorMessage = "Họ tên bắt buộc phải được nhập")]
        [Display(Name = "Họ tên")]
        public string? Name { get; set; } //Họ tên
        [Required(ErrorMessage = "Địa chỉ email bắt buộc phải được nhập")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@+gmail\.com", ErrorMessage = "Địa chỉ email phải có đuôi gmail.com")]
        public string? Email { get; set; } //Email
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[^\w\s]).{8,}$", ErrorMessage = "Mật khẩu phải có từ 8 ký tự trở lên ký tự viết hoa, viết thường, chữ số và ký tự đặc biệt")]
        [Required(ErrorMessage = "Mật khẩu bắt buộc phải được nhập")]
        [Display(Name = "Mật khẩu")]
        public string? Password { get; set; }//Mật khẩu
        [Required(ErrorMessage = "Ngành học bắt buộc phải được chọn")]
        [Display(Name = "Ngành học")]
        public Branch? Branch { get; set; }//Ngành học
        [Required(ErrorMessage = "Giới tính bắt buộc phải được chọn")]
        [Display(Name = "Giới tính")]
        public Gender? Gender { get; set; }//Giới tính
        [Display(Name = "Hệ chính quy")]
        public bool IsRegular { get; set; }//Hệ: true-chính quy, false-phi chính quy
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Địa chỉ bắt buộc phải được nhập")]
        [Display(Name = "Địa chỉ")]
        public string? Address { get; set; }//Địa chỉ
        [Range(typeof(DateTime), "1/1/1963", "12/31/2005")]
        [DataType(DataType.Date, ErrorMessage = "Ngày sinh bắt buộc phải được nhập")]
        [Display(Name = "Ngày sinh")]
        public DateTime DateOfBirth { get; set; }//Ngày sinh
        [RegularExpression(@"^(10(\.0)?|[0-9](\.[0-9])?)$", ErrorMessage = "Điểm bắt buộc là kiểu số thực và miền giá trị từ 0.0 đến 10.0")]
        [Required(ErrorMessage = "Điểm bắt buộc phải được nhập")]
        [Display(Name = "Điểm")]
        public float Score { get; set; }
    }
}
