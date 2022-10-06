

Module Program
    Sub Main(args As String())


        Dim Dic As New Dictionary(Of Integer, String) From {{1, "Pepe"}, {2, "Pepe"}, {3, "Pepe"}, {4, "Pepe"}}
        For Each d In Dic
            Console.WriteLine($" Dictionary -> {d.Key} - {d.Value}")
        Next



        Dim List As New List(Of String) From {"Pepe", "Jose"}
        For Each item In List
            Console.WriteLine($" ListOf -> {item}")
        Next

        Dim hash As New Hashtable From {{1, "Perdo"}, {2, "Lopez"}}
        For Each item In List
            Console.WriteLine($" Hashtable -> {item}")
        Next



        Dim cola As New Queue(5)
        For index = 1 To 4
            cola.Enqueue(index.ToString())
        Next
        Console.WriteLine($" Nro cola  -> {cola.Count()}")
        For index = 1 To cola.Count()
            Console.WriteLine($" cola  -> {cola.Dequeue}")
        Next

        Dim pila As New Stack(10)
        For index = 1 To 10
            pila.Push(index.ToString())
        Next

        For index = 1 To 10
            Console.WriteLine($" pila - {pila.Pop}")
        Next

        Dim array() As Integer = Nothing

        'For index = 1 To 10
        '    array(index)[index]  
        'Next

        'For index = 1 To array.Length()
        '    Console.WriteLine($" array - {array(index)}")
        'Next

        '' Dim array2D(,) As Integer = {{1, 2, 3}, {4, 5, 6}}

        '' Dim array3D(,,) As Integer = {{{1, 2, 3}, {4, 5, 6}}, {{7, 8, 9}, {10, 11, 12}}}






    End Sub


    ' Sub Main(args As String())
    ''  Dim Employees As Employee = New Employee("1", "2", "3")
    '' Employees.Show() 
    ''----------------------------------------------------------------------------------------------
    ''Dim studient = New Studient(Guid.NewGuid(),
    ''                                         "Picaso",
    ''                                         New List(Of String) From {"1", "2"})
    ''
    ''Dim person = New MyLibraryInC.School.Person("Pepe", "Olmos", 21, IPerson.TypeSex.Male)
    ''
    ''Dim studientsServices = New StudientServices(studient, person)
    ''
    ''studientsServices.GetStudientWithCource()
    ''studientsServices.AddCource("PEPEPEPEPEP")
    ''studientsServices.GetStudientWithCource()
    ''----------------------------------------------------------------------------------------------
    '' Dim subject = New Subject()
    '' Dim A = New ActorOne
    '' Dim B = New ActorTwo
    '' subject.Attach(A)
    '' subject.Attach(B)
    '' subject.Notify()
    '' Console.WriteLine("-------------------------------------")
    '' subject.Detach(B)
    '' subject.Notify()
    '' Console.WriteLine("-------------------------------------")
    ''----------------------------------------------------------------------------------------------
    ''  Dim Tax = New Tax("impuestazo",
    ''                    " debedio a la inflacion",
    ''                    Taxes.Common.TypeTax.percent,
    ''                    21,
    ''                    Taxes.Common.TaxDefination.internet)
    ''
    ''  Dim ApplayTax = New TaxService(Tax, 500)
    ''  ApplayTax.ApplayTax()
    ''----------------------------------------------------------------------------------------------

    ''  Dim a = New delegateShow()
    ''  Dim d As ShowResults = ShowResults("FFF")
    ''  Console.WriteLine(d)

    ''----------------------------------------------------------------------------------------------
    '' Dim gestionDeHilos = New ThreadsObj()

    'Dim listaValores = New HashSet(Of String)
    'gestionDeHilos.loadHilos(New Thread(
    '                         Sub()
    '                             gestionDeHilos.Devolver(listaValores, 99999)
    '                         End Sub))

    'Dim primer = gestionDeHilos.hilos.FirstOrDefault()
    'primer.Start()
    'Dim c = 0
    'Dim hasta = primer.IsAlive
    'While (hasta)


    '    Console.ForegroundColor = If(primer.IsAlive, ConsoleColor.Green, ConsoleColor.Gray)
    '    Console.WriteLine($"Estado del hilo {primer.ManagedThreadId} 
    '         ThreadState {primer.ThreadState}  
    '         y esta vivo {primer.IsAlive} estamos en {c.ToString()} ")

    '    hasta = primer.IsAlive
    '    c += 1

    'End While

    'Console.ForegroundColor = ConsoleColor.Yellow
    'Console.WriteLine($"Se termino {listaValores.Count()}")

    'gestionDeHilos.loadHilos(New Thread(AddressOf gestionDeHilos.Consola))
    '' gestionDeHilos.loadHilos(New Thread(AddressOf gestionDeHilos.Consola2))


    'For Each hilo In gestionDeHilos.hilos
    '    hilo.Start(hilo.ManagedThreadId)
    'Next

    'Dim cronos = New Cronos.Cronos("Los hilos")
    'Dim a As Thread

    'cronos.Start()
    'For i = 0 To 10


    '    a = New Thread(AddressOf gestionDeHilos.Consola)
    '    a.Start(i)
    '    '' Console.WriteLine($"Estado del hilo actual {a.ThreadState <> 0}")

    'Next


    'Thread.Sleep(80000)
    'Console.WriteLine("$Arrancamos el hilo nuevamente")
    'gestionDeHilos.signal.Set()
    'gestionDeHilos.signal.Dispose()

    'cronos.Stop()
    'cronos.Show()
    ''----------------------------------------------------------------------------------------------

    '' redondeo.LosRedondeso()

    ''----------------------------------------------------------------------------------------------
    ''//// ADAPTER

    'Dim MySql As Acciones = New MySql()
    'MySql.Agregar()
    'MySql.Actualizar()
    'MySql.Eliminar()
    'Dim MongoDb As Acciones = New MongoDBAdapter()
    'MongoDb.Agregar()
    'MongoDb.Actualizar()
    'MongoDb.Eliminar() 

    ''----------------------------------------------------------------------------------------------

    ''ChainResponsability Responsability

    ' Dim customer As Approver = New Customer()
    ' Dim manager As Approver = New Manager()
    ' customer.AddNext(manager)
    ' Dim purchase As Purchase = New Purchase()
    ' purchase.amount = 1000
    ' customer.Procces(purchase)

    ''----------------------------------------------------------------------------------------------
    ''Decorator
    ''Dim Coffe As DrinkComponent = New OnlyCoffe()
    ''Coffe = New Cream(Coffe)

    ''Console.WriteLine($"The product {Coffe.description} has a cost of {Coffe.amount} ")
    ''----------------------------------------------------------------------------------------------

    ''Abstract Factory

    '' Dim Restaurant As Restaurant
    ''
    '' Restaurant = New RestaurantEspaniol()
    ''
    '' Console.ForegroundColor = ConsoleColor.Red
    '' Console.WriteLine($"{Restaurant.GetType().Name}")
    '' Console.WriteLine($"{Restaurant.CreateEmpanda().Description}")
    '' Console.WriteLine($"{Restaurant.CreatePizza().Description}")
    '' Console.WriteLine($"--------------------------------------------")
    '' Restaurant = New RestaurantJapones()
    '' Console.ForegroundColor = ConsoleColor.Gray
    '' Console.WriteLine($"{Restaurant.GetType().Name}")
    '' Console.WriteLine($"{Restaurant.CreateEmpanda().Description}")
    '' Console.WriteLine($"{Restaurant.CreatePizza().Description}")
    '' Console.WriteLine($"--------------------------------------------")
    '' Restaurant = New RestaurantAmericano()
    '' Console.ForegroundColor = ConsoleColor.Cyan
    '' Console.WriteLine($"{Restaurant.GetType().Name}")
    '' Console.WriteLine($"{Restaurant.CreateEmpanda().Description}")
    '' Console.WriteLine($"{Restaurant.CreatePizza().Description}")
    ''
    ''----------------------------------------------------------------------------------------------

    ''FactoryMethod

    '' Dim Restaurant As FactoryMethod.Restaurant
    '' Dim menu As Menu
    '' 
    '' Restaurant = New FactoryMethod.RastaurantEspaniol()
    '' menu = Restaurant.CreateMenu(MenuType.Hamburgesa)
    '' Menu.Show()
    '' 
    '' 
    '' Restaurant = New FactoryMethod.RastaurantAmericano()
    '' menu = Restaurant.CreateMenu(MenuType.Paella)
    '' menu.Show()

    'Builder Methid
    ''----------------------------------------------------------------------------------------------
    '' Liskov Substitution Principle
    ''Dim restaurant As RestaurantBuilder
    ''    restaurant = New RestaurantBrazilBuilder()
    ''
    ''    Dim combinado As Combinados
    ''    combinado = restaurant.CrearCombinados(Drinks.Caipirinha)
    ''    combinado.Deliver()
    ''
    ''    Dim menu As Builder.Menu
    ''    menu = restaurant.CrearMenu(Dishes.Paella)
    ''    menu.Deliver()
    ''





    ''  End Sub 


End Module
