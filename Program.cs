using DesafioPOO.Models;

TipoCelular tipo = EscolherSmartphone.Escolher();

if(tipo == TipoCelular.Iphone){
    Iphone iphone = new("79912345678", "iphone15", "0123456789", 256);
    iphone.InstalarAplicativo("Teste");
    iphone.Ligar();
    iphone.ReceberLigacao();
}
else if(tipo == TipoCelular.Nokia){
    Nokia nokia = new("79912345678", "nokia8210", "0123456789", 128);
    nokia.InstalarAplicativo("Teste");
    nokia.Ligar();
    nokia.ReceberLigacao();
}
else{
    Console.WriteLine("Modelo não reconhecido " + tipo.ToString());
}