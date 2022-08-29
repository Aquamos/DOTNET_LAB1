using ConsoleApp.Commands.EnumCommands;

namespace ConsoleApp
{
    public class MenuMethods
    {
        public (int, MenuCommands) ShowMainMenu(MenuSeeder menuSeeder)
        {
            return (menuSeeder.Menus[MenuCommands.MainMenu].Run(), MenuCommands.MainMenu);
        }
        public (int, MenuCommands) ShowFullInfoMenu(MenuSeeder menuSeeder)
        {
            return (menuSeeder.Menus[MenuCommands.FullInfoMenu].Run(), MenuCommands.FullInfoMenu);
        }
        public (int, MenuCommands) ShowSortedMenu(MenuSeeder menuSeeder)
        {
            return (menuSeeder.Menus[MenuCommands.SortedMenu].Run(), MenuCommands.SortedMenu);
        }
        public (int, MenuCommands) ShowSearchMenu(MenuSeeder menuSeeder)
        {
            return (menuSeeder.Menus[MenuCommands.SearchMenu].Run(), MenuCommands.SearchMenu);
        }
        public (int, MenuCommands) ShowGroupMenu(MenuSeeder menuSeeder)
        {
            return (menuSeeder.Menus[MenuCommands.GroupMenu].Run(), MenuCommands.GroupMenu);
        }
        public (int, MenuCommands) ShowAggregateAndCollectionsMenu(MenuSeeder menuSeeder)
        {
            return (menuSeeder.Menus[MenuCommands.AggregateAndCollectionsMenu].Run(), 
                MenuCommands.AggregateAndCollectionsMenu);
        }

    }
}
