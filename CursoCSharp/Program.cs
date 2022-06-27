using CursoCSharp.Fundamentos;
using CursoCSharp.ClassesEMetodos;
using CursoCSharp.Colecoes;
using CursoCSharp.OO;
using CursoCSharp.MetodosEFuncoes;
using CursoCSharp.Excecoes;
using CursoCSharp.API;
using CursoCSharp.TopicosAvancados;
using CursoCSharp.OO.Partial;

namespace CursoCSharp {
    class Program {
        static void Main() {
            var central = new CentralDeExercicios(new Dictionary<string, Action>(){

                #region Fundamentos
                {"Primeiro Programa - Fundamentos", PrimeiroPrograma.Executar},
                {"Comentario - Fundamentos", Comentario.Executar},
                {"Variaveis E Constantes - Fundamentos", ValorDasVariaveisNumericas.Executar},
                {"Inferencia - Fundamentos", Inferencia.Executar},
                {"Interpolacao - Fundamentos", Interpolacao.Executar},
                {"Lendo Dados Do Console - Fundamentos", LendoDadosDoConsole.Executar},
                {"Formatando Numeros - Fundamentos", FormatandoNumeros.Executar},
                {"Conversoes - Fundamentos", Conversoes.Executar},
                #endregion

                #region  Classes e métodos - coloquei somente o que não sabia
                {"Params - Classes e métodos", Params.Executar},
                {"Parametros Nomeados - Classes e métodos", ParametrosNomeados.Executar},
                {"Propriedades - Classes e métodos", Propriedades.Executar},
                {"Readonly - Classes e métodos", ReadOnly.Executar},
                {"Exemplo Enum - Classes e métodos", ExemploEnum.Executar},
                {"Exemplo Struct - Classes e métodos", ExemploStruct.Executar},
                {"Parmâmetros por referência - Classes e métodos", ParametrosPorReferenciaRefOut.Executar},
                {"Threads - Classes e métodos", Threads.Executar},
                #endregion

                #region  Coleções
                {"Array - Coleções", Colecoes.Array.Executar},
                {"List - Coleções", List.Executar},
                {"Queue = Fila - Coleções", FilaQueue.Executar},
                {"Igualdade - Coleções", Igualdade.Executar},
                {"Stack - Coleções", FilaStack.Executar},
                {"Dictionary - Coleções", Dictionary.Executar},
                {"Matriz - Coleções", Matriz.Executar},
                #endregion

                #region  OO
                {"Herança - OO", Heranca.Executar},
                {"Construtor This - OO", ConstrutorThis.Executar},
                {"Encapsulamento - OO", OO.Encapsulamento.Executar},
                {"Polimorfismo - OO", Polimorfismo.Executar},
                {"Abstract - OO", Abstract.Executar},
                {"Interface - OO", Interface.Executar},
                {"Sealed - OO", Sealed.Executar},
                {"Partial - OO", FulanoPessoa.Executar},
                #endregion

                #region  Métodos e funções
                {"Action e Func - Métodos e funções", ActionEFunc.Executar},
                {"Delegate - Métodos e funções", MetodosEFuncoes.Delegate.Executar},
                {"Métodos de extensão - Métodos e funções", MetodosDeExtensao.Executar},
                {"Recursividade - Métodos e funções", Recursividade.Executar},
                #endregion

                #region  Exceções
                {"Exceções - Exceções", Excecoes.Excecoes.Executar},
                {"Exceções Personalizadas - Exceções", ExcecoesPersonalizadas.Executar},
                #endregion

                #region  API
                {"Exemplo File Escrevendo - API",  ExemploFileEscrevendo.Executar},
                {"Exemplo File Lendo Dados - API",  ExemploFileLendoDados.Executar},
                {"Exemplo File Info Escrevendo - API",  ExemploFileInfoEscrevendo.Executar},
                {"Diretorios - API",  Diretorios.Executar},
                {"Exemplo Path - API",  ExemploPath.Executar},
                {"Datas - API",  Datas.Executar},
                {"TimeSpan - API",  ExemploTimeSpan.Executar},
                {"Environment - API",  Environments.Executar},
                 #endregion

                #region  Tópicos avançados
                {"LINQ1 - API",  LINQ1.Executar},
                #endregion
            });

            central.SelecionarEExecutar();
        }
    }
}