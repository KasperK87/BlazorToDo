namespace mysqlefcore
{
  public class Book
  {
    public string ISBN { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }
    public string Language { get; set; }   
    public int Pages { get; set; }
    public virtual Publisher Publisher { get; set; }
  }

  public class Publisher
  {
    public int ID { get; set; }
    public string Name { get; set; }
    public virtual ICollection<Book> Books { get; set; }
  }


  public class Msg
  {
      public string? sender { get; set; }
      public string? msg { get; set; }

      public Msg(string setSender, string setMsg){
          sender = setSender;
          msg = setMsg;
      }
  }
  
}