﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoCSharp.ClassesEMetodos {

    interface IPonto {//uma interface é como se fosse um abstract. Precisa implementar os métodos daqui
        void AlterarEixos(int x, int y);
    }

    struct StructEixos: IPonto { //como se fosse um "with" do dart

        public int X;
        public int Y;
        public void AlterarEixos(int x, int y) {
            X = x;
            Y = y;
        }
    }

    class ClassEixos: IPonto { //como se fosse um "with" do dart

        public int X;
        public int Y;
        public void AlterarEixos(int x, int y) {
            X = x;
            Y = y;
        }
    }

    internal class ExemploStruct {
        static public void Executar() {
            Console.WriteLine("Um struct é muito parecido com uma classe. O que muda entre os dois são apenas duas coisas:\n 1: A única coisa que muda na estrutura dos dois é que um usa class na definição e outro usa struct\n 2: Quando faz uma cópia de um struct, não faz referência ao mesmo local da memória. Já quando faz uma cópia de uma classe, está fazendo referência ao mesmo local de memória. Por isso, se mudar o valor da cópia da classe, vai alterar o valor dos dois (original e cópia). Já no struct, não altera dos dois\n");

            StructEixos structEixos1 = new() {
                X = 0, Y = 0
            };
            StructEixos copiaStructEixos = structEixos1;
            structEixos1.AlterarEixos(10, 10);

            Console.WriteLine($"struct X: {structEixos1.X}, struct Y: {structEixos1.Y}");
            Console.WriteLine($"copia Struct X: {copiaStructEixos.X}, copia Struct Y: {copiaStructEixos.Y}");

            //QUANDO ATRIBUI UM STRUCT À OUTRO STRUCT, A ATRIBUIÇÃO É POR VALOR, NÃO É POR
            //REFERÊNCIA. ELES OCUPAM LUGARES DIFERENTES DA MEMÓRIA, POR ISSO SE ALTERAR O
            //VALOR DE UM NÃO VAI ALTERAR O VALOR DO OUTRO

            Console.WriteLine($"");


            ClassEixos classEixos2 = new() {
                X = 0, Y = 0
            };
            ClassEixos copiasClassEixos2 = classEixos2;
            classEixos2.AlterarEixos(10, 10);


            Console.WriteLine($"classEixos X: {classEixos2.X}, classEixos Y: {classEixos2.Y}");
            Console.WriteLine($"copias Class X: {copiasClassEixos2.X}, copias Class Y: {copiasClassEixos2.Y}");

            //QUANDO ATRIBUI UMA CLASS À OUTRA CLASSE, A ATRIBUIÇÃO É POR REFERÊNCIA, NÃO É POR
            //VALOR. ELES OCUPAM O MESMO LOCAL DA MEMÓRIA, POR ISSO SE ALTERAR O VALOR DE UM, VAI
            //ALTERAR O VALOR DO OUTRO
        }
    }
}
