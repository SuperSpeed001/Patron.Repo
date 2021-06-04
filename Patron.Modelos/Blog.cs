namespace Patron.Modelos
{    
    using System.Collections.Generic;
   
    /// <summary>
    /// Hereda de basemodel con sus propios atributos
    /// </summary>
    public class Blog: BaseModel
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public List<Post> Posts { get; } = new List<Post>();
    }
}
