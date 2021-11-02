﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SegundoProjeto
{
    class Instituicao
    {
        public string Nome { get; set; }
        public Endereco Endereco { get; set; }

        public Departamento[] Departamentos { get; } = new Departamento[10];
        private int quantidadeDepartamentos = 0;

        public void RegistrarDepartamento(Departamento d)
        {
            if (quantidadeDepartamentos < 10)
                Departamentos[quantidadeDepartamentos++] = d;
        }

        public int ObterQuantidadeDepartamentos()
        {
            return quantidadeDepartamentos;
        }

        public Departamento DepartamentoPorIndice(int indice)
        {
            return Departamentos[indice];
        }


        //private int quantidadeDepartamentos = 0;
        //public void RegistrarDepartamento(Departamento d)
        //{
        //    if (quantidadeDepartamentos < 10)
        //        Departamentos[quantidadeDepartamentos++] = d;
        //}
        //public int ObterQuantidadeDepartamentos()
        //{
        //    return quantidadeDepartamentos;
        //}
        //public Departamento DepartamentoPorIndice(int indice)
        //{
        //    return Departamentos[indice];
        //}

    }
}
