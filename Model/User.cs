namespace MySqlConnector.Model
{

  public class User
  {
    public int id { get; set; }
    public string? name { get; set; }
    public string? family { get; set; }

    public string nationalCode { get; set; }
  }
}