using System.ComponentModel.DataAnnotations.Schema;

namespace Nomenclatures
{
    public class ComponentQty
    {
        public IComponent Component { get; set; }

        public double Qty{ get; set; }
    }
}