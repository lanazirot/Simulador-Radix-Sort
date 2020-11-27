using Sorter;

namespace Radix_Sort_GUI {
    class Empleado : IRadixable {

        public int ID {
            get; set;
        }

        public int Edad {
            get; set;
        }

        public string Nombre {
            get; set;
        }

        public int HorasTrabajadas {
            get; set;
        }


        public int ObtenerAtributoParaOrdenar() {
            return ID;
        }
    }
}
