using System;

namespace DevFrom.API.Dtos
{
    public class PhotoReturnDto
    {
        public int Id { get; set; } 
        public string Url { get; set; } 
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsMain { get; set; }  
        public string PublicId { get; set; }     
  
    }
}