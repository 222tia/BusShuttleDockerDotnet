namespace DomainModel;

public class UserModel {
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string UserName { get; set; }
    public string Password { get; set; }

    public UserModel(string username, string password) {
        UserName = username;
        Password = password;
    }

    public UserModel(int id, string firstname, string lastname, string username, string password) {
        Id = id;
        FirstName = firstname;
        LastName = lastname;
        UserName = username;
        Password = password;
    }

#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.
    public UserModel() {

    }
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

    public void Update(string firstname, string lastname, string username, string password) {
        FirstName = firstname;
        LastName = lastname;
        UserName = username;
        Password = password;
    }
}