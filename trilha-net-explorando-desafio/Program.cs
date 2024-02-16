using System.Text;
using DesafioProjetoHospedagem.Models;

Console.OutputEncoding = Encoding.UTF8;

// Cria os modelos de hóspedes e cadastra na lista de hóspedes
List<Pessoa> hospedes = new List<Pessoa>();

Pessoa p1 = new Pessoa(nome: "Ygor", sobrenome: "Lima");
Pessoa p2 = new Pessoa(nome: "Julia", sobrenome: "Costa");

hospedes.Add(p1);
hospedes.Add(p2);


Suite suite = new Suite(tipoSuite: "Premium", capacidade: 2, valorDiaria: 50);


Reserva reserva = new Reserva(diasReservados: 5);
reserva.CadastrarSuite(suite);
reserva.CadastrarHospedes(hospedes);


Console.WriteLine($"Hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");