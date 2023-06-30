using ManejoJson;
using persistencia_csharp;

internal class Program
{
    private static void Main(string[] args)
    {
        Controlador controller = new Controlador();
        bool isActive = false;
        int opc = 0;

        do{
            Console.WriteLine("1.Crear Registro Equipo\n2.Ingresar Plantel\n3.Editar datos\n4.Salir");
            opc = Convert.ToInt16(Console.ReadLine());
            switch (opc){
                case 1:
                    controller.AddInfo();
                    break;
                case 2:



                case 4:
                    isActive = false;
                    break;
                default:
                    break;
        }

        }while (isActive);
    }
}