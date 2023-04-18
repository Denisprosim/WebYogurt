using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Freeeze.Models
{
    public class tbProducts
    {
        [Key]
        public int idProducts { get; set; }
        [ForeignKey("tbKategorie")]
        public int idKategorie { get; set; }
        public tbKategorie tbKategorie { get; set; }
        public string Name { get; set; }
        public string Photo { get; set; }
        
    }
}