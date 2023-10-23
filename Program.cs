// See https://aka.ms/new-console-template for more information
using _8Piezas;
using _8Piezas.Interfaces;
using _8Piezas.Exceptions;
using _8Piezas.Piezas;
using System;



var torre = new Torre();
var alfil = new Alfil();
var peon = new Peon();
var rey = new Rey();
var reina = new Reina();
var caballo = new Caballo();
var piezasinsolucion = new PiezaSinSolucion();

var resolver = new Resolver();
//var e = new SinSolucionException();



        Console.WriteLine("ELIJA UN NUMERO PARA SELECCIONAR LA PIEZA A INSERTAR Y PRESIONE ENTER");
        Console.WriteLine("1. PEON");
        Console.WriteLine("2. ALFIL");
        Console.WriteLine("3. CABALLO");
        Console.WriteLine("4. TORRE");
        Console.WriteLine("5. REY");
        Console.WriteLine("6. REINA");
        Console.WriteLine("7. PIEZA_SIN_SOLUCION");

    try 
    {
         string opcion = Console.ReadLine();

        switch (opcion)
        {
        case "1":
            resolver.Resolver8Piezas(peon);
            break;
        case "2":
            resolver.Resolver8Piezas(alfil);
            break;
        case "3":
            resolver.Resolver8Piezas(caballo);
            break;
        case "4":
            resolver.Resolver8Piezas(torre);
            break;
        case "5":
            resolver.Resolver8Piezas(rey);
            break;
        case "6":
            resolver.Resolver8Piezas(reina);
            break;
        case "7":
            resolver.Resolver8Piezas(piezasinsolucion);
            break;


        default:
            Console.WriteLine("Opción no válida");
            break;
        }
    }
    catch (SinSolucionException e)
    {
        Console.WriteLine(e.Message);
        Console.WriteLine(e.StackTrace);
    }


     