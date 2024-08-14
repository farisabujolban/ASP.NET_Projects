//The convention is to name the class: "UserProfileVM"
namespace SchoolManagementApp.MVC.Models;

public class UserProfileViewModel
{
    public string? Name {get; internal set; }
    public string? EmailAddress {get; internal set; }
    public string? ProfileImage {get; internal set; }
}