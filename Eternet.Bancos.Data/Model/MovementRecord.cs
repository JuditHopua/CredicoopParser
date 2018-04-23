using Eternet.Bancos.Parser.Models;

namespace Eternet.Bancos.Data.Model
{
    public class MovementRecord
    {
        public ProvinciaRecord ProvinciaRecord { get; set; }
        public bool Registered { get; set; }
    }
}
