int vida = 0; // variable que almacena la vida actual del jugador
int vidaMax = 0; // variable que se encargara de almacenar la vida maxima del jugador cuando suba de nivel o diferente personaje
int daño = 20; // variable que almacena el daño que hace el jugador
int dinero = 0; //moneda del juego
int pociones = 0;
string? clase = ""; // variable que almacena la clase del jugador
int estamina = 0;
int nivel = 0;
int vidaEnemigo = 0;
int dañoEnemigo = 0;
int reconpensa = 0;
int entrarJuego = 0;

while (true)
{
    Console.WriteLine("Bienvenido a mi arcade");
    Console.WriteLine("Elige una opción:");
    Console.WriteLine("1. RPG por texto");
    Console.WriteLine("2. Proximamente");
    Console.WriteLine("3. Salir");
    string? opcion = Console.ReadLine();
    switch (opcion)
    {
        case "1":
            entrarJuego = 1;
            break;
        case "2":
            Console.WriteLine("Proximamente...");
            break;
        default:
            if (opcion == "3" || opcion == "")
            {
                Console.WriteLine("Saliendo del programa...");
                return;
            }
            Console.WriteLine("Opción inválida. Por favor, elige una opción válida.");
            break;
    }
    if (entrarJuego == 1)
    {
        Console.WriteLine("Empezar");
        Console.ReadLine();
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Elige tu personaje:");
        Console.WriteLine("1. Guerrero");
        Console.WriteLine("2. Mago");
        Console.WriteLine("3. Arquero");
        switch(clase = Console.ReadLine()) // se asigna la clase del jugador a la variable clase
        {
            case "1":
                vida = 100;
                vidaMax = 100;
                pociones = 3;
                estamina = 2;
                nivel = 1;
                break;
            case "2":
                vida = 80;
                vidaMax = 80;
                pociones = 5;
                estamina = 1;
                nivel = 1;
                break;
            case "3":
                vida = 90;
                vidaMax = 90;
                pociones = 4;
                estamina = 3;
                nivel = 1;
                break;
            default:
                Console.WriteLine("Opción inválida. Por favor, elige una opción válida.");
                continue;
        }
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("Comenzando la aventura...");
        Console.WriteLine("---ZONA 1---");
        Console.WriteLine("Elige una acción:");
        Console.WriteLine("ir a la pradera(1)");
        Console.WriteLine("ir al bosque(2)");
        Console.WriteLine("ir a la cueva(3)");
        switch (Console.ReadLine()) // aqui se elige la zona a la que se quiere ir y se asigna la vida del enemigo, el daño del enemigo y la recompensa que se obtiene al derrotarlo
        {
            case "1":
                Console.WriteLine("Te aventuras en la pradera y encuentras un slime.");
                vidaEnemigo = 50;
                dañoEnemigo = 10;
                reconpensa = 20;
                break;
            case "2":
                Console.WriteLine("Te adentras en el bosque y encuentras un lobo.");
                vidaEnemigo = 70;
                dañoEnemigo = 15;
                reconpensa = 30;
                break;

            case "3":
                Console.WriteLine("Te adentras en la cueva y encuentras un goblin.");
                vidaEnemigo = 100;
                dañoEnemigo = 20;
                reconpensa = 40;
                break;
            default:
                Console.WriteLine("Opción inválida. Por favor, elige una opción válida.");
                continue;
        }
        Console.WriteLine("Comienza el combate!");
        while (vida > 0 && vidaEnemigo > 0) // el while que se encarga de que el conbate continue hasta que la vida del jugador o del enemigo sea 0 o menor
        {
            Console.WriteLine("Tu vida: " + vida);
            Console.WriteLine("Vida del enemigo: " + vidaEnemigo);
            Console.WriteLine("Elige una acción:");
            Console.WriteLine("Atacar(1)");
            Console.WriteLine("Ataque especial(2)");
            Console.WriteLine("Usar poción(3)");
            Console.WriteLine("protegerse(4)");
            switch (Console.ReadLine())
            {
                case "1":
                    
                    vidaEnemigo -= daño;
                    Console.WriteLine("Has atacado al enemigo y le has hecho " + daño + " de daño.");
                    vida -= dañoEnemigo;
                    Console.WriteLine("El enemigo te ha atacado y te ha hecho " + dañoEnemigo + " de daño.");
                    break;
                case "2":
                    switch (clase)
                    {
                        case "1":
                            Console.WriteLine("Has usado tu ataque especial y le has hecho " + (daño * 2.5) + " de daño al enemigo.");
                            vidaEnemigo -= (int)(daño * 2.5); // al usar 2.5 para aumentar el daño parte de ese daño se convierte en decimal, por lo que uso int para que los decimales se eliminen y no afecten al daño total 
                            estamina--;
                            vida -= dañoEnemigo;
                            Console.WriteLine("El enemigo te ha atacado y te ha hecho " + dañoEnemigo + " de daño.");
                            break;
                        case "2":
                            Console.WriteLine("Has usado tu ataque especial y le has hecho " + (daño * 3) + " de daño al enemigo.");
                            vidaEnemigo -= daño * 3;
                            estamina--;
                            vida -= dañoEnemigo * 2;
                            Console.WriteLine("El enemigo te ha atacado y te ha hecho " + dañoEnemigo + " de daño.");
                            break;
                        case "3":
                            Console.WriteLine("Has usado tu ataque especial y le has hecho " + (daño * 1.5) + " de daño al enemigo.");
                            vidaEnemigo -= (int)(daño * 1.5); // al usar 1.5 para aumentar el daño parte de ese daño se convierte en decimal, por lo que uso int para que los decimales se eliminen y no afecten al daño total 
                            estamina--;
                            break;
                    }
                    break;
                case "3":
                    if (pociones > 0)
                    {
                        vida += 20;
                        if (vida > vidaMax)
                        {
                            vida = vidaMax;
                        }
                        pociones--;
                        Console.WriteLine("Has usado una poción y has recuperado 20 de vida.");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("No tienes pociones disponibles.");
                        continue;
                    }
                case "4":
                    Console.WriteLine("Te proteges del ataque del enemigo.");
                    estamina++;
                    continue;
                default:
                    Console.WriteLine("Opción inválida. Por favor, elige una opción válida.");
                    continue;
            }
        }
        if (vida <= 0)
        {
            Console.WriteLine("Has sido derrotado por el enemigo.");
            break;
        }
        else
        {
            Console.WriteLine("Has derrotado al enemigo y has ganado " + reconpensa + " monedas.");
            dinero += reconpensa;
            Console.WriteLine("Tu dinero actual es: " + dinero);

            
            switch (clase)
            {
                case "1":
                    nivel++;
                    vidaMax += (int)(vidaMax * 0.4);
                    vida = vidaMax;
                    daño += 5;
                    break;
                case "2":
                    nivel++;
                    vidaMax += (int)(vidaMax * 0.15);
                    vida = vidaMax;
                    daño += 8;
                    break;
                case "3":
                    nivel++;
                    vidaMax += (int)(vidaMax * 0.2);
                    vida = vidaMax;
                    daño += 6;
                    break;
            }
        }
    
            Console.WriteLine("---ZONA 2---");
            Console.WriteLine("Elige una acción:");
            Console.WriteLine("ir a la tienda(1)");
            Console.WriteLine("ir al rebuscar(2)");
            Console.WriteLine("ir al entrenar(3)");
            Console.WriteLine("status(4)");
            Console.WriteLine("continuar(5)");
            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Te adentras en la tienda y encuentras un vendedor.");
                    switch(Console.ReadLine())
                    {
                        case "1":
                            if (dinero >= 5)
                            {
                                dinero -= 5;
                                pociones++;
                                Console.WriteLine("Has comprado una poción por 5 monedas.");
                            }
                            else
                            {
                                Console.WriteLine("No tienes suficiente dinero para comprar una poción.");
                            }
                            break;
                        case "2":
                            if (dinero >= 20)
                            {
                                dinero -= 20;
                                daño += 5;
                                Console.WriteLine("Has comprado un arma por 20 monedas. Tu daño ha aumentado en 5.");
                            }
                            else
                            {
                                Console.WriteLine("No tienes suficiente dinero para comprar un arma.");
                            }
                            break;
                        default:
                            Console.WriteLine("Opción inválida. Por favor, elige una opción válida.");
                            break;
                    }
                    continue;
                case "2":
                if (estamina <= 0)
                {
                    Console.WriteLine("Te pones a rebuscar y encuentras un algo de valor.");
                    dinero += 10;
                    estamina--;
                    continue;
                }
                else
                {
                    Console.WriteLine("No tienes estamina suficiente para rebuscar.");
                    continue;
                }

                case "3":
                if (estamina <= 0)
                {
                    Console.WriteLine("Te pones a entrenar.");
                    daño += 2;
                    estamina--;
                    continue;
                }
                else
                {
                    Console.WriteLine("No tienes estamina suficiente para entrenar.");
                    continue;
                }
                case "4":
                    Console.WriteLine($"Dinero: {dinero}");
                    Console.WriteLine($"Pociones: {pociones}");
                    Console.WriteLine($"Daño: {daño}");
                    Console.WriteLine($"Estamina: {estamina}");
                    Console.WriteLine($"Nivel: {nivel}");
                    continue;
                case "5":
                    Console.WriteLine("Continuando la aventura...");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor, elige una opción válida.");
                    continue;
            }
            Console.WriteLine("---ZONA 3---");
            Console.WriteLine("Se acerca un mini jefe, un orco.");
            vidaEnemigo = 180;
            dañoEnemigo = 25;
            reconpensa = 20;
            while (vida > 0 && vidaEnemigo > 0) // de este punto para abajo es el mismo codigo del combate anterior, asi que se puede repetir el mismo codigo para los siguientes combates.
        {
            Console.WriteLine("Tu vida: " + vida);
            Console.WriteLine("Vida del enemigo: " + vidaEnemigo);
            Console.WriteLine("Elige una acción:");
            Console.WriteLine("Atacar(1)");
            Console.WriteLine("Ataque especial(2)");
            Console.WriteLine("Usar poción(3)");
            Console.WriteLine("protegerse(4)");
            switch (Console.ReadLine())
            {
                case "1":
                    
                    vidaEnemigo -= daño;
                    Console.WriteLine("Has atacado al enemigo y le has hecho " + daño + " de daño.");
                    vida -= dañoEnemigo;
                    Console.WriteLine("El enemigo te ha atacado y te ha hecho " + dañoEnemigo + " de daño.");
                    break;
                case "2":
                    switch (clase)
                    {
                        case "1":
                            Console.WriteLine("Has usado tu ataque especial y le has hecho " + (daño * 2.5) + " de daño al enemigo.");
                            vidaEnemigo -= (int)(daño * 2.5); // al usar 2.5 para aumentar el daño parte de ese daño se convierte en decimal, por lo que uso int para que los decimales se eliminen y no afecten al daño total 
                            estamina--;
                            vida -= dañoEnemigo;
                            Console.WriteLine("El enemigo te ha atacado y te ha hecho " + dañoEnemigo + " de daño.");
                            break;
                        case "2":
                            Console.WriteLine("Has usado tu ataque especial y le has hecho " + (daño * 3) + " de daño al enemigo.");
                            vidaEnemigo -= daño * 3;
                            estamina--;
                            vida -= dañoEnemigo * 2;
                            Console.WriteLine("El enemigo te ha atacado y te ha hecho " + dañoEnemigo + " de daño.");
                            break;
                        case "3":
                            Console.WriteLine("Has usado tu ataque especial y le has hecho " + (daño * 1.5) + " de daño al enemigo.");
                            vidaEnemigo -= (int)(daño * 1.5); // al usar 1.5 para aumentar el daño parte de ese daño se convierte en decimal, por lo que uso int para que los decimales se eliminen y no afecten al daño total 
                            estamina--;
                            break;
                    }
                    break;
                case "3":
                    if (pociones > 0)
                    {
                        vida += 20;
                        if (vida > vidaMax)
                        {
                            vida = vidaMax;
                        }
                        pociones--;
                        Console.WriteLine("Has usado una poción y has recuperado 20 de vida.");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("No tienes pociones disponibles.");
                        continue;
                    }
                case "4":
                    Console.WriteLine("Te proteges del ataque del enemigo.");
                    estamina++;
                    continue;
                default:
                    Console.WriteLine("Opción inválida. Por favor, elige una opción válida.");
                    continue;
            }
        }
        if (vida <= 0)
        {
            Console.WriteLine("Has sido derrotado por el enemigo.");
            break;
        }
        else
        {
            Console.WriteLine("Has derrotado al enemigo y has ganado " + reconpensa + " monedas.");
            dinero += reconpensa;
            Console.WriteLine("Tu dinero actual es: " + dinero);

            
            switch (clase)
            {
                case "1":
                    nivel++;
                    vidaMax += (int)(vidaMax * 0.4);
                    vida = vidaMax;
                    daño += 5;
                    break;
                case "2":
                    nivel++;
                    vidaMax += (int)(vidaMax * 0.15);
                    vida = vidaMax;
                    daño += 8;
                    break;
                case "3":
                    nivel++;
                    vidaMax += (int)(vidaMax * 0.2);
                    vida = vidaMax;
                    daño += 6;
                    break;
            }
        }
        Console.WriteLine("Felicidades, has completado el juego!");
        Console.WriteLine("...");
        Console.WriteLine("por ahora...");
        break;
    }
    break;
}