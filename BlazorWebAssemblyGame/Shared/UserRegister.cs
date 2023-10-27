using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebAssemblyGame.Shared;
public class UserRegister
{
	[Required, EmailAddress]
	public string Email { get; set; } = string.Empty;
	[StringLength(16, ErrorMessage = "Your username is too long (16 characters max)")]
	public string Username { get; set; } = string.Empty;
	public string Bio { get; set; } = string.Empty;
	[Required, StringLength(100, MinimumLength = 6)]
	public string Password { get; set; } = string.Empty;
	[Compare("Password", ErrorMessage = "The passwords do not match.")]
	public string ConfirmPassword { get; set; } = string.Empty;
	[Range(0, 1000, ErrorMessage = "Please choose a number between 0 and 1000")]
	public int Bananas { get; set; } = 100;
	public string StartUnitId { get; set; } = "1";
	public DateTime DateOfBirth { get; set; } = DateTime.Now;

	[Range(typeof(bool), "true", "true", ErrorMessage = "Only confirmed users can play!")]
	public bool IsConfirmed { get; set; } = true;
}
