namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
            veiculos.Sort();
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veiculo para remover:");
            string placa = Console.ReadLine();

            // Verifica se o vei­culo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veiculo permaneceu estacionado:");
                int horas = int.Parse(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;
                Console.WriteLine($"O veiculo {placa} foi removido e o preçoo total foi de: R$ {valorTotal}");
                veiculos.Remove(placa);
            }
            else
            {
                Console.WriteLine("Desculpe, esse veiculo nao esta estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se ha vei­culos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veiculos estacionados sao:");
                foreach (string placa in veiculos)
                {
                    Console.WriteLine($"Placa: {placa}");
                }
            }
            else
            {
                Console.WriteLine("Nao ha veiculos estacionados.");
            }
        }
    }
}
