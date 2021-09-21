using System;

    public interface Menus : Calculos
    {
         /*

_________________________________________________|funções de navegação|______________________________________________________________________________

*/
















        static void MenuPrincipal(){

            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("____________________| Calculadora |____________________");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" Escolha a operação a ser executada:");
            Console.WriteLine(" ");
            Console.WriteLine("(0) fechar programa.");
            Console.WriteLine("(1) Adição.");
            Console.WriteLine("(2) Subtração.");
            Console.WriteLine("(3) Multiplicação.");
            Console.WriteLine("(4) Divisão.");
            Console.WriteLine("(5) Exponenciação.");
            Console.WriteLine("(6) Radiciação.");
            Console.WriteLine("(7) Média.");
            Console.WriteLine("(8) Trigonometria.");
            Console.WriteLine("(9) Área de polígonos.");
            Console.WriteLine("(10) volume de polígonos.");
            Console.WriteLine("_____________________________________");
            var indicador = int.Parse(Console.ReadLine());

            if(indicador == 0){
                
                Console.Clear();
                Environment.Exit(0);

            }else if(indicador == 1){

                Console.Clear();
                Console.WriteLine("______________| Adição |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite o primeiro número:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" Digite o segundo número:");
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Somar(num1, num2);

            }else if(indicador == 2){

                Console.Clear();
                Console.WriteLine("______________| Subtração |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite o primeiro número:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" Digite o segundo número:");
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Subtrair(num1, num2);

            }else if(indicador == 3){

                Console.Clear();
                Console.WriteLine("______________| Multiplicação |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite o primeiro número:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" Digite o segundo número:");
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Multiplicar(num1, num2);

            }else if(indicador == 4){

                Console.Clear();
                Console.WriteLine("______________| Divisão |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite o primeiro número:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" Digite o segundo número:");
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Dividir(num1, num2);

            }else if(indicador == 5){

                Console.Clear();
                Console.WriteLine("______________| exponenciação |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a base:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a potência:");
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Exponenciar(num1, num2);

            }else if(indicador == 6){

                MenuRadiciacao();

            }else if(indicador == 7){

                MenuMedia();

            }else if(indicador == 8){

                MenuTrigonometria();

            }else if(indicador == 9){

                MenuAreaDosPoligonos();

            }else if(indicador == 10){

                MenuVolumeDosPoligonos();

            }else{

                MenuPrincipal();

            }
        }














        static void MenuAreaDosPoligonos(){

            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("_______________| Área dos polígonos |_______________");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" Escolha a operação a ser executada:");
            Console.WriteLine(" ");    
            Console.WriteLine("(0) Voltar ao inicio.");
            Console.WriteLine("(1) Área de um triângulo.");
            Console.WriteLine("(2) Área de um quadrilatero.");
            Console.WriteLine("(3) Área de um paralelogramo.");
            Console.WriteLine("(4) Área de um trapézio.");
            Console.WriteLine("(5) Área de um hexagono.");
            Console.WriteLine("(6) Área de um losango.");
            var indicador = int.Parse(Console.ReadLine());

            if(indicador == 0){
                
                MenuPrincipal();

            }else if(indicador == 1){

                MenuAreaDosPoligonosSubTriangulos();

            }else if(indicador == 2){

                MenuAreaDosPoligonosSubquadrilateros();

            }else if(indicador == 3){

                Console.Clear();
                Console.WriteLine("______________| Área de um paralelogramo |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a base:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a altura:");
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                AreaParalelogramo(num1, num2);
            
            }else if(indicador == 4){

                Console.Clear();
                Console.WriteLine("______________| Área de um trapézio |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a base maior:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a base menor:");
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a altura:");
                var num3 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                AreaTrapezio(num1, num2, num3);
            
            }else if(indicador == 5){

                Console.Clear();
                Console.WriteLine("______________| Área de um trapézio |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite o lado de um dos triângulos do hexagono:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                AreaHexagono(num1);

            }else if(indicador == 6){

                Console.Clear();
                Console.WriteLine("______________| Área de um paralelogramo |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a diagonal maior:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a diagonal menor:");
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                AreaLosango(num1, num2);
            
            }else{

                MenuAreaDosPoligonos();

            }

        }


        













        static void MenuAreaDosPoligonosSubTriangulos(){

            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("_______________| Área dos triângulos |_______________");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine(" Escolha a operação a ser executada:");
            Console.WriteLine(" ");    
            Console.WriteLine("(0) Voltar ao inicio.");
            Console.WriteLine("(1) Área de um triângulo Equilatero.");
            Console.WriteLine("(2) Área de um triângulo isoceles.");
            Console.WriteLine("(3) Área de um triângulo retângulo.");
            var indicador = int.Parse(Console.ReadLine());

            if(indicador == 0){

                MenuPrincipal();
                
            }else if(indicador == 1){

                Console.Clear();
                Console.WriteLine("______________| Área de um triângulo equilatero |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a medida do lado:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                AreaTrianguloEquilatero(num1);

            }else if(indicador == 2){

                Console.Clear();
                Console.WriteLine("______________| Área de um triângulo isoceles |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a medida da base:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a medida da altura:");
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                AreaTrianguloIsoceles(num1, num2);

            }else if(indicador == 3){

                Console.Clear();
                Console.WriteLine("______________| Área de um triângulo retângulo |_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a medida do cateto oposto:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                Console.WriteLine(" Digite a medida do cateto adjacente:");
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine(" ");
                AreaTrianguloRetangulo(num1, num2);

            }else{

                MenuAreaDosPoligonosSubTriangulos();

            }
        }















        static void MenuAreaDosPoligonosSubquadrilateros(){

            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("_______________| Área dos quadrilateros |_______________");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Escolha a operação a ser executada:");
            Console.WriteLine(" ");    
            Console.WriteLine("(0) Voltar ao inicio.");
            Console.WriteLine("(1) Área de um quadrado.");
            Console.WriteLine("(2) Área de um retângulo.");
            var indicador = int.Parse(Console.ReadLine());

                if(indicador == 0){
                    
                    MenuPrincipal();
                
                }else if(indicador == 1){

                    Console.WriteLine("_______________|Área Dos Quadrilateros|______________");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Digite a medida do lado do quadrilatero:");
                    var num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    AreaQuadrado(num1);

                }else if(indicador == 2){

                    Console.WriteLine("_______________|Área Dos Retângulos|______________");
                    Console.WriteLine(" ");
                    Console.WriteLine(" ");
                    Console.WriteLine("Digite a medida do lado menor:");
                    var num1 = double.Parse(Console.ReadLine());
                    Console.WriteLine(" ");
                    Console.WriteLine("Digite a medida do lado maior:");
                    var num2 = double.Parse(Console.ReadLine());
                    AreaRetangulo(num1, num2);

                }else{

                    MenuAreaDosPoligonosSubquadrilateros();

                }
        }
















        static void MenuRadiciacao(){

            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("_______________| Radiciação |_______________");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Escolha a operação a ser executada:");
            Console.WriteLine(" ");
            Console.WriteLine("(0) Voltar ao inicio.");
            Console.WriteLine("(1) Raíz quadrada.");
            Console.WriteLine("(2) Raíz cubica.");
            var indicador = int.Parse(Console.ReadLine());

            if(indicador == 0){

                MenuPrincipal();
            
            }else if(indicador == 1){

                Console.WriteLine("_______________|Raíz Quadrada|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Digite o número que você quer tirar a raíz:");
                var num1 = double.Parse(Console.ReadLine());

                TirarRaizQuadrada(num1);

            }else if(indicador == 2){

                Console.WriteLine("_______________|Raíz Cúbica|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Digite o número que você quer tirar a raíz:");
                var num1 = double.Parse(Console.ReadLine());
                TirarRaizCubica(num1);

            }else{
                
                MenuRadiciacao();
            
            }
       
        }













        static void MenuMedia(){

            Console.ResetColor();
            Console.Clear();
            Console.WriteLine("_______________| Calcular média |_______________");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Escolha a operação a ser executada:");
            Console.WriteLine(" ");
            Console.WriteLine("(0) Voltar ao inicio.");
            Console.WriteLine("(1) Média simples.");
            Console.WriteLine("(2) Média ponderada.");
            var indicador = int.Parse(Console.ReadLine());

            if(indicador == 0){

                MenuPrincipal();

            }else if(indicador == 1){

                Console.WriteLine("_______________|Média Simples|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Digite a quantidade de itens a ser contabilizados:");
                var num1 = int.Parse(Console.ReadLine());
                MediaSimples(num1);

            }else if(indicador == 2){

                Console.WriteLine("_______________|Média Ponderada|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Digite a quantidade de itens a ser contabilizados:");
                var num1 = int.Parse(Console.ReadLine());
                MediaPonderada(num1);

            }else{

                MenuMedia();

            }

        }














        static void MenuVolumeDosPoligonos(){

            Console.WriteLine("_______________|Volume Dos Polígonos|______________");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Escolha a operação a ser executada:");
            Console.WriteLine("");
            Console.WriteLine("(0) Voltar ao inicio.");
            Console.WriteLine("(1) Volume de um cubo.");
            Console.WriteLine("(2) Volume de um paralelepipedo.");
            Console.WriteLine("(3) Volume de um cilindro.");
            Console.WriteLine("(4) Volume de um cone.");
            Console.WriteLine("______________________________________");
            var indicador = int.Parse(Console.ReadLine());

            if(indicador == 0){

                MenuPrincipal();
            
            }else if(indicador == 1){

                Console.WriteLine("_______________|Volume De Um Cubo|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Digite a medida de um dos lados do cubo:");
                var num1 = double.Parse(Console.ReadLine());
                VolumeCubo(num1);

            }else if(indicador == 2){

                Console.WriteLine("_______________|Volume De Um Paralelepipedo|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Digite a medida do comprimento do paralelepipedo:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a medida da largura do paralelepipedo:");
                var num2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a medida da altura do paralelepipedo:");
                var num3 = double.Parse(Console.ReadLine());
                VolumeParalelepipedo(num1, num2, num3);

            }else if(indicador == 3){

                Console.WriteLine("_______________|Volume De Um Cilindro|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Digite a medida do raio do cilindro:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a medida da altura do cilindro:");
                var num2 = double.Parse(Console.ReadLine());
                VolumeCilindro(num1, num2);

            }else if(indicador == 4){

                Console.WriteLine("_______________|Volume De Um Cone|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Digite a medida do raio do cone:");
                var num1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Digite a medida da altura do cone:");
                var num2 = double.Parse(Console.ReadLine());
                VolumeCone(num1, num2);

            }else{

                MenuPrincipal();
 
            }

        }













        static void MenuTrigonometria(){
            Console.Clear();
            Console.WriteLine("_______________|Trigonometria|_______________");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Escolha a operação a ser executada:");
            Console.WriteLine(" ");
            Console.WriteLine("(0) Voltar ao inicio.");
            Console.WriteLine("(1) Seno.");
            Console.WriteLine("(2) Cosseno.");
            Console.WriteLine("(3) Tangente.");
            Console.WriteLine("(4) Teorema de Pitágoras");
            Console.WriteLine("(5) Area de um triângulo");
            var indicador = int.Parse(Console.ReadLine());

        
            if(indicador == 0){

                MenuPrincipal();
            
            }else if(indicador == 1){

                Console.Clear();
                Console.WriteLine("_______________|Determinar seno|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Digite o ângulo que você deseja determinar o seno:");
                double angulo = double.Parse(Console.ReadLine());
                PegarValorSeno(angulo);

            }else if(indicador == 2){

                Console.Clear();
                Console.WriteLine("_______________|Determinar cosseno|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Digite o ângulo que você deseja determinar o cosseno:");
                double angulo = double.Parse(Console.ReadLine());
                PegarValorCosseno(angulo);

            }else if(indicador == 3){

                Console.Clear();
                Console.WriteLine("_______________|Determinar tangente|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Digite o ângulo que você deseja determinar a tangente:");
                double angulo = double.Parse(Console.ReadLine());
                PegarValorTagente(angulo);

            }else if(indicador == 4){

                Console.Clear();
                Console.WriteLine("_______________|Teorema de pitágoras|_______________");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Escolha a situação em que você se encontra:");
                Console.WriteLine(" ");
                Console.WriteLine("(1) Você possui o valor da hipotenusa, mas precisa encontrar o valor de um dos catetos.");
                Console.WriteLine("(2) Você possui o valor dos dois catetos, mas precisa encontrar o valor da hipotenusa.");
                int i = int.Parse(Console.ReadLine());
                TeoremaPitagoras(i);

            }else if(indicador == 5){
                
                MenuAreaDosPoligonosSubTriangulos();

            }else{

                MenuPrincipal();
            
            }
        }

    }