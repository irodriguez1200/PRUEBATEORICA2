using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PRUEBATEORICA2.Models
{
    public class Employee
    {
        public int ID { get; set; } //Identificador para cada película.
        public string Name { get; set; }
        public string Surname { get; set; }
        [Display(Name = "Birthday")]
        [DataType(DataType.Date)]
        public string Birthday { get; set; }
        public string Email { get; set; }
        public int Telephone { get; set; }
    }
}
