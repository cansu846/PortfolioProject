using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Skill
    {
        [Key] // Primary key olduğunu belirtir
        public int SkillID { get; set; }
        public string Header { get; set; }
        public string Value { get; set; }
    }
}
