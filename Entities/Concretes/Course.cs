using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concretes;

public class Course:Entity<int>
{
    public int CategoryId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }

    public Category Category { get; set; }

}
