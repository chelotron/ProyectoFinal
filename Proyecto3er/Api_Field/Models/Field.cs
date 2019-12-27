using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Api_Field.Models
{
    public class Field
    {
        public enum TypeField {
            Casa,
            Quinta,
            Terreno,
            Departamento,

        }
        public int FieldID { get; set; }
        public string FieldName { get; set; }
        public TypeField Type { get; set; }
    }


}
