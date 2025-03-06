using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteList.Models
{
    public class Notes
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime CreacionDate { get; set; } = DateTime.UtcNow;
        public DateTime LastModifiedDate { get; set; } = DateTime.UtcNow;
        public bool IsArchived { get; set; }

        [NotMapped]
        //public ICollection<Photos> Photos { get; set; } = new List<Photos>();
        public int Top_Aux { get; set; }
    }
}
