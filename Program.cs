bool continuar = false;
int[]retiros = new int[10];
int cantidadRetiros=0;
while(true){
    Console.WriteLine("---------------BANCO CDIS----------------");
    Console.WriteLine("1.Ingresar la cantidad de retiros hechos por los usuarios.\n2.Revisar la cantidad entregada de billetes y monedas");

    int opcion=0;

    Console.Write("Ingresa la opcion: ");
    opcion = int.Parse(Console.ReadLine());
   
    if(opcion==1){
        continuar = true;
        do{
            Console.Write("¿Cuantos retiros se hicieron? (maximo 10)?: ");
            cantidadRetiros = int.Parse(Console.ReadLine());
        }while(cantidadRetiros < 1 || cantidadRetiros > 10);
        

        for(int i=0; i<cantidadRetiros; i++){
            do{
                Console.WriteLine($"Ingrese la cantidad del retiro #{i+1} (mayor a 0 y menor o igual a 50,000.): ");
                retiros[i] = int.Parse(Console.ReadLine());
            }while(retiros[i] < 1 || retiros[i] > 50000);
        }

        Console.WriteLine("Retiros realizados: ");
        //FOR PARA MOSTRAR LA INFORMACION QUE EL USUARIO INGRESO
        for (int i = 0 ; i<cantidadRetiros; i++)
        {
            Console.WriteLine($"Retiro #{i+1}: {retiros[i]}");
        }

    }else if(opcion==2){
        if(continuar){
            for (int i = 0; i < cantidadRetiros; i++){
                int c1 = 0;
                int c2 = retiros[i];
                double aux1;
                double aux2;
                List<int> billetes = new List<int>() {500, 200, 100, 50, 20};
                foreach(int element in billetes){
                    aux1 = c2/ element;
                    aux2 = Math.Floor(aux1);
                    c1 = c1 + Convert.ToInt32(aux2);
                    c2 = (c2 % element);
                }
                int bil = c1;
                c1 = 0;

                List<int> monedas = new List<int>() {10, 5, 1};
                foreach(int element in monedas){
                    aux1 = c2/ element;
                    aux2 = Math.Floor(aux1);
                    c1 = c1 + Convert.ToInt32(aux2);
                    c2 = (c2 % element);
                }
                int mon = c1;

                Console.WriteLine($"Retiro #{i+1}: ");
                Console.WriteLine($"Billetes entregados: {bil}");
                Console.WriteLine($"Monedas entregadas: {mon}");
                
            }
            Console.Write("Presiona 'enter' para continuar: ");
            string aux3 = Console.ReadLine();
        }else{
            Console.WriteLine("No se han ingresado retiros");
            Console.Write("Presiona 'enter' para continuar: ");
            string aux3 = Console.ReadLine();
        }
        
    }else{
        Console.WriteLine("Opcion invalida, ingrese otra opcion:");
    }
}
