namespace deh.api.Requests;

public class UserRequest
{
    /// <summary>
    /// In Poland PESEL is unique number associated with only 1 person
    /// </summary>
    public string PESEL { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
}