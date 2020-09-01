using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa; // El cálculo del precio total del alfajor debería estar en la clsae alfajor, ya que tiene la información necesaria para hacerlo, no cumple con EXPERT.
        }

        // Este método podría ir en otra clase que se encargue de hacer conversiones entre monedas, no tiene por qué ser responsabilidad de la clase Kiosco, no cumple con SRP.
        private Double ConvertirAPesos(Double dinero, String moneda)
        {
            if (moneda.Equals("U$S")) 
            {
                return dinero / 30;
            } 
            else if (moneda.Equals("$")) 
            {
                return dinero;
            }
            else 
            {
                return -1;
            }
        }
    }
}