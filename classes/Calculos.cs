using System;
using System.Linq;

namespace calculadora_poo.classes{
    public class Calculos
    {
         /*

_________________________________________|funções de operações|_________________________________________________________________________________________

*/















        public static void Somar(double num1, double num2){

            double resultado = num1 + num2;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuPrincipal();
        }













        public static void Subtrair(double num1, double num2){

            double resultado = num1 - num2;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuPrincipal();

        }














        public static void Multiplicar(double num1, double num2){

            double resultado = num1 * num2;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuPrincipal();

        }













        public static void Dividir(double num1, double num2){

            double resultado = num1 / num2;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuPrincipal();

        }












        public static void Exponenciar(double num1, double num2){

            double resultado = Math.Pow(num1, num2);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuPrincipal();

        }











        public static void TirarRaizQuadrada(double num1){

            double resultado = Math.Sqrt(num1);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuRadiciacao();

        }












        public static void TirarRaizCubica(double num1){

            double resultado = Math.Cbrt(num1);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuRadiciacao();
            
        }













        public static void MediaSimples(int indicador){
            //a variavel "indicador" deve ser usada para determinar o número de itens("item{valor}").
            double[] numeros = new double[indicador];
            //o looping abaixo solicita que o usuário digite o valor de cada item, e depois guarda no array declarado acima.
            for(int i = 0; i < indicador; i++){
                Console.WriteLine(" ");
                Console.WriteLine($"Digite o {i+1}º numero:");
                numeros[i] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
            }
            //a variavel abaixo recebe: (a soma de todos os itens do array "numeros") dividido pela variavel "indicador".
            double resultado = (numeros.Sum()) / indicador;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuMedia();

        }












        public static void MediaPonderada(int indicador){
            //a variavel "indicador" deve ser usada para determinar o número de itens("item{peso, valor}").
            double[] peso =  new double[indicador];
            double[] valor = new double[indicador];
            double[] produto = new double[indicador];
            //o looping abaixo solicita que o usuário digite o peso de cada item, e depois guarda no array "peso", declarado acima.
            for(int i = 0; i < indicador; i++){
                Console.WriteLine(" ");
                Console.WriteLine($"Digite o {i+1}º peso:");
                peso[i] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
            }
            //o looping abaixo solicita que o usuário digite o valor de cada item, e depois guarda no array "valor", declarado acima.
            for(int i = 0; i < indicador; i++){
                Console.WriteLine(" ");
                Console.WriteLine($"Digite o {i+1}º valor:");
                valor[i] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
            }
            //o looping abaixo determina o produto entre o peso e valor dos itens, e depois guarda no array "produto", declarado acima.
            for(int i =0; i < indicador; i++){
                produto[i] = peso[i] * valor[i];
            }
            //a variavel abaixo recebe: (a soma de todos os itens do array "produto") dividido por (a soma de todos os itens do array "peso").
            double resultado = (produto.Sum()) / (peso.Sum());

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuMedia();

        }














        public static void AreaHexagono(double _ladoTriangulo_){
            //a variavel ladoTriangulo refere-se a um lado de um dos 6 triângulos do hexágono
            double resultado = 6*( (Math.Pow(_ladoTriangulo_, 2)) * 1.73 / 4);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuAreaDosPoligonos();

        }













        public static void AreaQuadrado(double _lado_){
            //a variavel lado refere-se a medida do lado do quadrado
            double resultado = Math.Pow(_lado_, 2);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuAreaDosPoligonosSubquadrilateros();

        }











        public static void AreaRetangulo(double _ladoMaior_, double _ladoMenor_){
            
            double resultado = _ladoMaior_ * _ladoMenor_;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuAreaDosPoligonosSubquadrilateros();

        }











        public static void AreaParalelogramo(double _base_, double _altura_){

            double resultado = _base_ * _altura_;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuAreaDosPoligonos();

        }
















        public static void AreaTrapezio(double _baseMaior_, double _baseMenor_, double _altura_){

            double resultado = ((_baseMaior_ + _baseMenor_)*_altura_) / 2;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuAreaDosPoligonos();

        }








        


        public static void AreaLosango(double _diagonalMaior_, double _diagonalMenor_){

            double resultado = (_diagonalMaior_ * _diagonalMenor_) / 2;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuAreaDosPoligonos();

        }













        public static void AreaTrianguloIsoceles(double _base_, double _altura_){

            double resultado = (_base_ * _altura_) / 2;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuAreaDosPoligonosSubTriangulos();

        }











        public static void AreaTrianguloRetangulo(double _catetoOposto_, double _catetoAdjacente_){

            double resultado = (_catetoOposto_ * _catetoAdjacente_) / 2;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuAreaDosPoligonosSubTriangulos();

        }













        public static void AreaTrianguloEquilatero(double _lado_){
            //a variavel lado refere-se a medida do lado do quadrado
            double resultado = (Math.Pow(_lado_, 2)) * 1.73 / 4;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuAreaDosPoligonosSubTriangulos();

        }















        public static void VolumeParalelepipedo(double _comprimento_, double _largura_, double _profundidade_){

            double resultado = _comprimento_ * _largura_ * _profundidade_;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuVolumeDosPoligonos();

        }











        public static void VolumeCubo(double _lado_){

            double resultado = Math.Pow(_lado_, 3);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuVolumeDosPoligonos();

        }












        public static void VolumeCilindro(double _raio_, double _altura_){

            double resultado = 3.14 * (Math.Pow(_raio_, 2)) * _altura_;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuVolumeDosPoligonos();

        }













        public static void VolumeCone(double _raio_, double _altura_){

            double resultado = (3.14 * (Math.Pow(_raio_, 2)) * _altura_) / 3;

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuVolumeDosPoligonos();

        }














        public static void PegarValorSeno(double _angulo_){

            double resultado = Math.Sin(_angulo_);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuTrigonometria();

        }













        public static void PegarValorCosseno(double _angulo_){

            double resultado = Math.Cos(_angulo_);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuTrigonometria();

        }












        public static void PegarValorTagente(double _angulo_){

            double resultado = Math.Tan(_angulo_);

            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($" O resultado é : {resultado}.");
            Console.ResetColor();
            Console.ReadLine();
            Menus.MenuTrigonometria();

        }











        public static void TeoremaPitagoras(int _parteFaltando_){
            // (a² = b² + c²)
            // a variavel "_parteFaltando_" deve receber apenas os seguintes valores: 1 ou 2 (int)
            //lembre-se de fornecer uma tabela indicando os possiveis valores para a variavel "_parteFaltando_"
            double[] valores = new double[2];

            if(_parteFaltando_ == 1){
                //neste caso, a parte faltando é a hipotenusa.
                Console.WriteLine("Digite o valor do primeiro cateto");
                valores[0] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Digite o valor do segundo cateto:");
                valores[1] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                double resultado = Math.Sqrt((Math.Pow(valores[0], 2)) + (Math.Pow(valores[1], 2)));
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($" O valor da hipotenusa é : {resultado}.");
                Console.ResetColor();
                Console.ReadLine();
                Menus.MenuTrigonometria();

            }else if(_parteFaltando_ == 2){
                //neste caso, a parte faltando é um cateto.
                Console.WriteLine("Digite o valor da hipotenusa");
                valores[0] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine("Digite o valor do cateto:");
                valores[1] = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                double resultado = Math.Sqrt((Math.Pow(valores[0], 2)) - (Math.Pow(valores[1], 2)));
                Console.BackgroundColor = ConsoleColor.Gray;
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($" O valor do cateto é : {resultado}.");
                Console.ResetColor();
                Console.ReadLine();
                Menus.MenuTrigonometria();

            }else{

                Console.WriteLine("Valor inesperado, por favor forneça os valores de acordo com a tabela.");
                Console.ReadLine();
                Menus.MenuTrigonometria();

            }
        }
    }
}