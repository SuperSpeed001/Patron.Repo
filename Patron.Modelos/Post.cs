namespace Patron.Modelos
{
    /// <summary>
    /// Clase Post que hereda de BaseModel
    /// Tiene sus propios atributos
    /// </summary>

    public class Post: BaseModel
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
