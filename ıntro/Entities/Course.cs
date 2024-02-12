using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ıntro.Entities;

public class Course
{
    internal int Id;

    public string Description { get; set; }
    public double Price { get; set; }
    public string Name { get; internal set; }
}
