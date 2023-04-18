using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Freeeze.Models
{
    public class tbKategorie
    {
        [Key]
        public int idKategorie { get; set; }
        public string Name { get; set; }
        public string Blog { get; set; }
        public ICollection<tbProducts> tbProducts { get; set; }
    }
}