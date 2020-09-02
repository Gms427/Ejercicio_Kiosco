using System;
using System.Text;

namespace Library
{

    /*  
        - Si quiero agregar más datos del cliente, debo modificar la firma del método CreateAppointment y añadirle
        más parametros, por lo tanto lo correcto sería tener una clase Cliente con sus datos encapsulados,
        entonces si quiero agregar más datos los agrego allí. El método CreateAppointment recibiría una
        instancia de la clase Cliente en lugar de sus datos individualmente.

        - Lo mismo que lo anterior pasa con los datos del doctor, deberían estar encapsulados en una clase.
            
        - Los datos de las consultas no se guardan en ningun lugar, debería existir alguna clase que conozca al menos 
        los identificadores de las consultas (o las consultas enteras) existentes para poder generar identificadores únicos. 

        - Por otro lado, creo que la consulta en sí tendría que ser una clase
    */
    public class AppointmentService
    {
        
        /*
            Este método no tendría por qué validar los datos que pertenecen a los clientes o doctores.
        */
        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;

            /*
                Este tipo de validaciones irían en el setter del atributo de su clase correspondiente,
                por ejemplo, la validación de abajo iría en el setter del atributo name de la clase Pacient.
            */
            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, Name is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, id is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, Phone number is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, Appoinment place is required\n");
                isValid = false;
            }

            
            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, Doctor name is required\n");
                isValid = false;
            }

            if (isValid)
            {
                stringBuilder.Append("Appoinment Scheduled");
            }

            return stringBuilder.ToString();
        }

    }
}
