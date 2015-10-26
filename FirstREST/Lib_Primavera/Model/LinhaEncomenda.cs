﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstREST.Lib_Primavera.Model
{
    public class LinhaEncomenda
    {
        public string CodigoArtigo { get; set; }
        public double Quantidade { get; set; }
        public string DescricaoArtigo { get; set; }
        public double Desconto { get; set; }
        public double PrecoUnitario { get; set; }
        public double TotalILiquido { get; set; }
        public double TotalLiquido { get; set; }
    }
}