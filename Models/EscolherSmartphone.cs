namespace DesafioPOO.Models
{
    public class EscolherSmartphone
    {
        public static TipoCelular Escolher(){
            int tipo = 0;
            bool escolheu = false;

            while(!escolheu){
                try{
                    Console.WriteLine("Qual o seu tipo de celular?");
                    Console.WriteLine("Digite 1 para Iphone");
                    Console.WriteLine("Digite 2 para Nokia");
                    tipo = int.Parse(Console.ReadLine());

                    if(tipo == 1){
                        escolheu = true;
                        return TipoCelular.Iphone;
                    }
                    else if(tipo == 2){
                        escolheu = true;
                        return TipoCelular.Nokia;
                    }
                    else {
                        Console.WriteLine("Modelo inválido");
                        Console.WriteLine("---------------");
                    }
                }catch{
                    Console.WriteLine("Modelo inválido");
                    Console.WriteLine("---------------");
                }
            }

            return TipoCelular.Padrao;
        }
    }
}