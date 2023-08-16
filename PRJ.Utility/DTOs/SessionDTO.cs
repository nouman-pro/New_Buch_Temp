namespace PRJ.Utility.DTOs;
public class SessionDTO
{
    public long UserId { get; set; }
    public string Name { get; set; }
    public int RoleId { get; set; }
    public string Role { get; set; }
    public long? SubRoleId { get; set; }
    public string SubRole { get; set; }
  
    public string Address { get; set; }
    public string Email { get; set; }
    public string PhoneNumber { get; set; }
    public string ProfilePicture { get; set; }
    public string? Timezone { get; set; }
    public DateTime? DOB  { get; set; }
    public int GenderId { get; set; }
    public bool? IsApproved { get; set; }
    public bool IsOnBoardingCompleted { get; set; }
    public string? AddionalReason { get; set; }
    public bool? IsCardAdded { get; set; }
    public string? StripeCustomerId { get; set; }
    public bool? IsPlanSubscripted { get; set; }
    public bool? IsAppoientmentRemained { get; set; }
}
