using System;

namespace Expert_SRP
{
    public class Kiosco 
    {
        public Boolean PuedeComprar(Alfajor a, Double dinero, String moneda) 
        {
            Double pesos = ConversorMoneda.ConvertirAPesos(dinero, moneda);
            Double precioTotal = a.ObtenerPrecioTotal();
            return pesos >= precioTotal;
        }
    }
}