﻿using CursoCSharp.Fundamentos;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;

namespace CursoCSharp {
    class Program {
        static void Main() {
            var central = new CentralDeExercicios(new Dictionary<string, Action>(){
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentario - Comentários", Comentario.Executar},
                {"Variaveis E Constantes - Variáveis e constantes", ValorDasVariaveisNumericas.Executar},
                {"Inferencia - Inferência", Inferencia.Executar},
                {"Interpolacao - Interpolação", Interpolacao.Executar},
                {"Lendo Dados Do Console - Interpolação", LendoDadosDoConsole.Executar},
                {"Formatando Numeros - Formatando números", FormatandoNumeros.Executar},
                {"Conversoes - Conversões", Conversoes.Executar},

                //Classes e métodos - coloquei somente o que não sabia
                {"Params - Classes e métodos", Params.Executar},
                {"Parametros Nomeados - Classes e métodos", ParametrosNomeados.Executar},
                {"Propriedades - Classes e métodos", Propriedades.Executar},
                {"Readonly - Classes e métodos", ReadOnly.Executar},
                {"Exemplo Enum - Classes e métodos", ExemploEnum.Executar},
                {"Exemplo Struct - Classes e métodos", ExemploStruct.Executar},
                {"Parmâmetros por referência - Classes e métodos", ParametrosPorReferenciaRefOut.Executar},

                //Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", Colecoes.List.Executar},
                {"Queue = Fila - Coleções", FilaQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", Stack.Executar},

                //OO
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}