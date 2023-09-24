using _0_3TränaTester.InterFaces;
using _0_3TränaTester.Models;
using _0_3TränaTester.Services;

namespace _0_3TränaTester
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IMenuService menuService = new MenuService();
            menuService.MainMenu();

            
            Console.ReadKey();
        }
    }
}