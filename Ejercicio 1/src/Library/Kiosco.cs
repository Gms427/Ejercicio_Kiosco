using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        
        /* 
        Este método podría estar también en la clase Alfajor como un método de instancia, ya que la clase alfajor tiene acceso a su precio y se podría 
        ahorrar el primer parámetro, pero para esto se debería cumplir que el método de convertir moneda este en otra clase, y que dicha clase sea accesible
        desde Alfajor
        */
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConvertirAPesos(dinero, moneda);
            return pesos >= a.PrecioDulce + a.PrecioMasa;
        }

        // Este método podría ir en otra clase que se encargue de hacer conversiones entre monedas, no tiene por qué ser responsabilidad de la clase Kiosco
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