namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
          
    if (Suite.Capacidade >= hospedes.Count)
    {
        Hospedes = hospedes;
    }
    else
    {
       
        try
        {
            
            throw new Exception("A capacidade da suíte será excedida pelo número de pessoas.");
        }
        catch (Exception ex)
        {
            
            Console.WriteLine($"Mensagem: {ex.Message}");
        }
    }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
           
            return Hospedes.Count;
        }

        public decimal CalcularValorDiaria()
        {
          
            decimal valor = DiasReservados * Suite.ValorDiaria;

          
            if ( DiasReservados >= 10)
            {   
                decimal desconto  = valor * 0.10m;
                valor -= desconto;
            }

            return valor;
        }
    }
}