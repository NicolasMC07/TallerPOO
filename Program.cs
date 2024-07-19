
using WorkShopPOO.Models;

class MainClass {
    
    public static void Main(string[] args) {
        List<Book> books = new List<Book>();


        var newBook = new Book("George Orwell", "978-0451524935", "Dystopian", 70.99, "1984", new DateTime(1949, 6, 8));

        var newBook2 = new Book("J.K. Rowling", "978-0747532743", "Fantasy", 80.99, "Harry Potter and the Philosopher's Stone", new DateTime(1997, 6, 26));

        books.Add(newBook);
        books.Add(newBook2);
        
        void ShowBooks(){
            Console.WriteLine(@$"#######################################################################
#                               BOOKS                                 #
#######################################################################
Autor           |  Genero      |   Precio  |    ISBN        | Fecha
-----------------------------------------------------------------------");
newBook.ShowInfo();
newBook2.ShowInfo();
Console.WriteLine(@$"#######################################################################");
        }

        void ShowDiscount()
        {
            Console.WriteLine(@$"#######################################################################
#                               BOOKS                                 #
#######################################################################
Autor           |  Genero      |   Precio  |    ISBN        | Fecha
-----------------------------------------------------------------------");
newBook.Discount(5);
newBook2.Discount(5);
Console.WriteLine(@$"#######################################################################");
        }

        void FilterByGenre()
        {   
            Console.WriteLine("Ingrese el genero del libro: ");
            var bookByGenre = Console.ReadLine();

             var filteredBooks = books.Where(book => book.Genre.Equals(bookByGenre, StringComparison.OrdinalIgnoreCase)).ToList();

            Console.WriteLine(@$"#######################################################################
#                               BOOK                                 #
#######################################################################
Autor           |  Genero      |   Precio  |    ISBN        | Fecha
-----------------------------------------------------------------------");
foreach (var book in filteredBooks)
{
    book.ShowInfo();
}
Console.WriteLine(@$"#######################################################################");
        }

        void FilterByAutor()
        {
            Console.WriteLine("Ingrese el nombre del autor del libro: ");
            var autorBook = Console.ReadLine();
            var autorFiltered = books.Where(book => book.Autor.Equals(autorBook, StringComparison.OrdinalIgnoreCase)).ToList();

            Console.WriteLine(@$"#######################################################################
#                               BOOK                                 #
#######################################################################
Autor           |  Genero      |   Precio  |    ISBN        | Fecha
-----------------------------------------------------------------------");
foreach (var book in autorFiltered)
{
    book.ShowInfo();
}
Console.WriteLine(@$"#######################################################################");

        }

        void FilterByDate()
        {
            Console.WriteLine("Ingrese la fecha minima");
            DateTime minDate = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("Ingrese la fecha maxima");
            DateTime maxDate = Convert.ToDateTime(Console.ReadLine());
        }

        void addNewBook()
        {
            Console.WriteLine("Ingrese el autor: ");
            string autor = Console.ReadLine();

            Console.WriteLine("Ingrese el ISBN: ");
            string ISBN = Console.ReadLine();

            Console.WriteLine("Ingrese el genero: ");
            string genre = Console.ReadLine();

            Console.WriteLine("Ingrese el precio: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Ingrese el título: ");
            string title = Console.ReadLine();

            Console.WriteLine("Ingrese la fecha de publicación (YYYY-MM-DD): ");
            DateTime publicationYear = Convert.ToDateTime(Console.ReadLine());

            var newBook = new Book(autor, ISBN, genre, price, title, publicationYear);
            books.Add(newBook);
        }

        void deleteBook()
        {
            Console.WriteLine("Ingrese el ISBN del libro que desea eliminar: ");
            string ISBN = Console.ReadLine();

            var bookToDelete = books.FirstOrDefault(book => book.ISBN.Equals(ISBN, StringComparison.OrdinalIgnoreCase));
            if (bookToDelete!= null)
            {
                books.Remove(bookToDelete);
            }
            else
            {
                Console.WriteLine("El libro no fue encontrado.");
            }
        }




string op = "0";
do
{
    Console.WriteLine(
$@"###############################################################################################
#                             SISTEMA DE ANALISIS DE VENTAS                                   #
###############################################################################################
1. Mostrar libros 
2. Aplicar un descuento al precio del libro
3. Consultar promedio de ventas diarias
4. Ver empleado y cliente del mes
5. Filtrar ventas por fecha
6. Consultar vendedores por encima de un valor
7. Consultar total de ventas mensuales
8. Encontrar el mejor vendedor por periodo
9. Mostrar Top N Ventas por Valor Descendente
10. Mostrar productos mas vendidos por año
11. Consultar ventas por valor especifico
12. Consultar ventas por cliente
13. Mostrar total de ventas y promedio por vendedor
14. Ver mes con mayor numero de ventas y detalles
15. Salir
-----------------------------------------------------------------------------------------------
Selecciona una opcion --> ");

op = Console.ReadLine();
                switch (op)
                {
                    case "1":
                        ShowBooks();
                        break;
                    case "2":
                        ShowDiscount();
                        break;
                    case "3":
                        FilterByGenre();
                        break;
                    case "4":
                        FilterByAutor();
                        break;
                    case "5":
                        FilterByDate();
                        break;
                    case "6":
                        addNewBook();
                        break;
                    case "7":
                        deleteBook();
                        break;
                    case "8":
                        Console.WriteLine("Saliendo del programa...");
                        Console.WriteLine("Gracias por usar la biblioteca.");
                        break;
                }
                Console.WriteLine("Presiona cualquier tecla para continuar...");
                Console.ReadKey();
                Console.Clear();

} while (op != "8");


}}


