using System.Collections.Generic;

namespace Domain.CommandResult
{
    public class ResultCommand
    {
        public ResultCommand()
        {
            Generos = new List<string>();
        }

        public string Filme { get; set; }
        public List<string> Generos { get; set; }
        public string DataLancamento { get; set; }
    }
}
