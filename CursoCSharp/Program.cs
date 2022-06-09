using CursoCSharp.Fundamentos;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.API;

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
                {"List - Coleções", List.Executar},
                {"Queue = Fila - Coleções", FilaQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", FilaStack.Executar},
                {"Dictionary - OO", Dictionary.Executar},


                //OO
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},

                //Métodos e funções
                {"Action e Func - Métodos e funções", ActionEFunc.Executar},
                {"Delegate - Métodos e funções", MetodosEFuncoes.Delegate.Executar},
                {"Métodos de extensão - Métodos e funções", MetodosDeExtensao.Executar},

                //Exceções
                {"Exceções - Exceções", Excecoes.Excecoes.Executar},
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},

                //API
                {"Exemplo File Escrevendo - API",  ExemploFileEscrevendo.Executar},
                {"Exemplo File Lendo Dados - API",  ExemploFileLendoDados.Executar},
                {"Exemplo File Info Escrevendo - API",  ExemploFileInfoEscrevendo.Executar},
                {"Diretorios - API",  Diretorios.Executar},
                {"Exemplo Path - API",  ExemploPath.Executar},
                {"Datas - API",  Datas.Executar},
                {"TimeSpan - API",  ExemploTimeSpan.Executar},
            });

            central.SelecionarEExecutar();
        }
    }
}