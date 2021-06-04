namespace Patron.Modelos
{
    using System;
    /// <summary>
    /// modelo base que contiene  
    /// identificador tipo Guid, 
    /// fecha de creado y 
    /// fecha de actualizado
    /// </summary>
    public class BaseModel   
    {
        public Guid Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
}
