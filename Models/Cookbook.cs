using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InstaFood.Models
{
    public class Cookbook
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public Recipe Recipe { get; set; }
    }
}
