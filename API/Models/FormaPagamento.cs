using System;

namespace API.Models
{

    public class FormaPagamento
    {
        //Construtor
        public FormaPagamento() => CriadoEm = DateTime.Now;

        //Atributos ou propriedades
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Prazo { get; set; }
        public DateTime CriadoEm { get; set; }

        //ToString
        public override string ToString() =>
            $"Descrição: {Descricao} | Prazo: {Prazo} | Criado em: {CriadoEm}";
    }
}