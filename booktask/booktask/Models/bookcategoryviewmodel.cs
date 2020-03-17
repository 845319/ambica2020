using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;
namespace booktask.Models
{
    public class bookcategoryviewmodel
    {
        public List<one> ones { get; set; }
        public SelectList Categories { get; set; }
        public string Bookcategory { get; set; }
        public string searcher { get; set; }
        public SelectList publishers { get; set; }
        public string publishercategory { get; set; }
    }
}    