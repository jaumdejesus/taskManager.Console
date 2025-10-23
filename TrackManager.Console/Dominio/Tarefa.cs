using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackManager.Console.Dominio.Enums;

namespace TrackManager.Console.Dominio
{
    class Tarefa
    {
        public int IdTarefa { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime DataConclusao { get; set; }
        public PrioridadeEnum Prioridade { get; set; }
        public StatusEnum Status { get; set; }
        public List<Tarefa> ListaTarefas { get; set; }

        public Tarefa(string titulo, string descricao, DateTime dataCriacao, DateTime dataConclusao, int prioridade, int status)
        {
            Titulo = titulo;
            Descricao = descricao;
            DataCriacao = dataCriacao;
            DataConclusao = dataConclusao;
            Prioridade = (PrioridadeEnum)prioridade;
            Status = (StatusEnum)status;
        }
    }
}
