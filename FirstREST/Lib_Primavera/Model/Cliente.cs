﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FirstREST.Lib_Primavera.Model
{
    public class Cliente
    {
        public string Morada;

        /* Exemplo para POST e GET com valores específicos
         public string Morada
        {
            get
            {
                return "MORADA: " + _morada;
            }
            set
            {
                _morada = value;
            }
        }
    
*/       
        public string CodCliente
        {
            get;
            set;
        }

        public string NomeCliente
        {
            get;
            set;
        }

        public string NumContribuinte
        {
            get;
            set;
        }

        public string Moeda
        {
            get;
            set;
        }

        public string Cidade
        {
            get;
            set;
        }

        public string CodigoPostal
        {
            get;
            set;
        }

        public string Pais
        {
            get;
            set;
        }

        public string NumeroTelefone
        {
            get;
            set;
        }

        public string Email
        {
            get;
            set;
        }


    }
}