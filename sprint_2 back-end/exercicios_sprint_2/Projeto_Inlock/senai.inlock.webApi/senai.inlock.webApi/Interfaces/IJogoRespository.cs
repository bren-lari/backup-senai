﻿using senai.inlock.webApi_.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.inlock.webApi_.Interfaces
{
    interface IJogoRespository
    {

        List<JogoDomain> Listar();

        JogoDomain BuscarPorId(int id);

        void Atulizar(int id, JogoDomain atualizarJogo);

        void Cadastrar(JogoDomain cadastrarJogo);

        void Deletar(int id);
    }
}
