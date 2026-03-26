public class AccountModel
{

    public long Id { get; set; }
    public string EmailAddress { get; set; }

    public string Password { get; set; }

    public string FullName { get; set; }

    public AccountModel(long id, string email, string password, string fullname)
    {
        Id = id;
        EmailAddress = email;
        Password = password;
        FullName = fullname;
    }


}



