using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Freeeze.Models
{
    public class tbBlog
    {
        [Key]
        public int idBlog { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Blog { get; set; }
        public string Photo { get; set; }
        public string User { get; set; }
    }
}