namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    // IMPLEMENTADO
    public class Iphone : Smartphone
    {
        // TODO: Sobrescrever o método "InstalarAplicativo"
        // IMPLEMENTADO
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Aplicativo {nomeApp} selecionado para instalação.");
            Console.WriteLine("Metodo de pagamento selecionado: Débito.");
            Console.WriteLine("Confirmação de token para validação do pagamento.");
            Console.WriteLine("Verificação de segurança Apple...");
            Console.WriteLine("Instalando...");
            Console.WriteLine($"O aplicativo {nomeApp} do celular Nokia foi instalado com sucesso!");
        }
    }
}