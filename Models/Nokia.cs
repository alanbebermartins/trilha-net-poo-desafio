namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // IMPLEMENTADO
    public class Nokia : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // IMPLEMENTADO
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Aplicativo {nomeApp} selecionado para instalação.");
            Console.WriteLine("Verificação de segurança...");
            Console.WriteLine("Instalando...");
            Console.WriteLine($"O aplicativo {nomeApp} do celular Nokia foi instalado com sucesso!");
        }
    }
}