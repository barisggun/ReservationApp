using System.ComponentModel.DataAnnotations;

namespace ReservationApp.Panel.UI.Models
{
	public class UserRegisterViewModel
	{
		[Required(ErrorMessage ="Lütfen ad giriniz.")]
		public string Name { get; set; }

		[Required(ErrorMessage = "Lütfen soyad giriniz.")]
		public string Surname { get; set; }

		[Required(ErrorMessage = "Lütfen kullanıcı adı giriniz.")]
		public string Username { get; set; }

		[Required(ErrorMessage = "Lütfen mail giriniz.")]
		public string Email { get; set; }

		[Required(ErrorMessage = "Lütfen şifre giriniz.")]
		public string Password { get; set; }

		[Required(ErrorMessage = "Lütfen şifreyi tekrar giriniz.")]
		[Compare("Password",ErrorMessage ="Şifreler uyumlu değil")]
		public string ConfirmPassword { get; set; }
	}
}
