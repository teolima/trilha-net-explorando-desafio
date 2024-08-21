using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

try
{
    
    List<Pessoa> hospedes = new List<Pessoa>
    {
        new Pessoa(nome: "Hóspede 1"),
        new Pessoa(nome: "Hóspede 2"),
        new Pessoa(nome: "Hóspede 3")
    };

   
    Suite suite = new Suite(tipoSuite: "Premium", capacidade: 3, valorDiaria: 30); 
    Reserva reserva = new Reserva(diasReservados: 10);
    reserva.CadastrarSuite(suite);
    
   
    reserva.CadastrarHospedes(hospedes);

   
    
    Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
    Console.WriteLine($"Valor total da diária: {reserva.CalcularValorDiaria()}");
}
catch (Exception)
{
   
    Console.WriteLine($" mensagem: Número de Pessoas na Suite não permitido");
}