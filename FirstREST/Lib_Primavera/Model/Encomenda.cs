using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstREST.Lib_Primavera.Model
{
    public class Encomenda
    {
        public List<Model.LinhaEncomenda> LinhasEncomenda { get; set; }
        public string Entidade { get; set; }
        public DateTime Data { get; set; }
        public int NumDoc { get; set; }
        public String Estado { get; set; }
    }
}