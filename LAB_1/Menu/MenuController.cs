using static System.Console;
using ConsoleApp.Commands.EnumCommands;


namespace ConsoleApp
{
    public class MenuController
    {
        private CommandsDictionary _commandsDictionary;
        private MenuSeeder _menuSeeder;
        private MenuCommands _menuCommands;
        private int _selectedIndex;
        public MenuController()
        {
            _commandsDictionary = new CommandsDictionary();
            _menuSeeder = new MenuSeeder();
        }
        public void Run()
        {
            _selectedIndex = _menuSeeder.Menus[MenuCommands.MainMenu].Run();
            while (true)
            {
                (_selectedIndex, _menuCommands) = _commandsDictionary[(MenuCommands)_selectedIndex].Invoke(_menuSeeder);
                if (_menuCommands != MenuCommands.MainMenu && _selectedIndex != -1)
                {
                    InvokeMenuCommand();
                }
            }
        }
        private void InvokeMenuCommand()
        {
            Clear();
            if (_menuCommands == MenuCommands.FullInfoMenu)
            {
                _commandsDictionary[(InfoCommands)_selectedIndex].Invoke();
                _selectedIndex = (int)MenuCommands.FullInfoMenu;
            }
            else if (_menuCommands == MenuCommands.SortedMenu)
            {
                _commandsDictionary[(SortCommands)_selectedIndex].Invoke();
                _selectedIndex = (int)MenuCommands.SortedMenu;
            }
            else if (_menuCommands == MenuCommands.SearchMenu)
            {
                _commandsDictionary[(SearchCommands)_selectedIndex].Invoke();
                _selectedIndex = (int)MenuCommands.SearchMenu;
            }
            else if (_menuCommands == MenuCommands.GroupMenu)
            {
                _commandsDictionary[(GroupCommands)_selectedIndex].Invoke();
                _selectedIndex = (int)MenuCommands.GroupMenu;
            }
            else if (_menuCommands == MenuCommands.AggregateAndCollectionsMenu)
            {
                _commandsDictionary[(ACCommands)_selectedIndex].Invoke();
                _selectedIndex = (int)MenuCommands.AggregateAndCollectionsMenu;
            }
            WriteLine("Press any key to return to the menu.");
            ReadKey(true);
        }
    }
}
