using static System.Console;

namespace ConsoleApp
{
    public class Menu
    {
        private int _selectedIndex;
        public string[] Options { get; set; }
        public string Header { get; set; }

        public Menu()
        {
            _selectedIndex = 0;
        }

        private void DisplayOptions()
        {
            WriteLine(Header);
            for(int i = 0; i < Options.Length; i++)
            {
                string currentOption = Options[i];
                string prefix;
                if (i == _selectedIndex)
                {
                    prefix = "*";
                    ForegroundColor = ConsoleColor.Black;
                    BackgroundColor = ConsoleColor.White;
                }
                else {
                    prefix = " ";
                    ForegroundColor = ConsoleColor.White;
                    BackgroundColor = ConsoleColor.Black;
                }
                WriteLine($"<< {currentOption} >>");
            }
            ResetColor();
        }

        public int Run() {
            ConsoleKey keyPressed;
            do 
            {
                if (_selectedIndex == -1)
                {
                    _selectedIndex = 0;
                }
                Clear();
                DisplayOptions();

                ConsoleKeyInfo keyInfo = ReadKey(true);
                keyPressed = keyInfo.Key;

                if (keyPressed == ConsoleKey.UpArrow)
                {
                    _selectedIndex--;
                    if (_selectedIndex == -1)
                    { 
                        _selectedIndex = Options.Length - 1;
                    }
                }
                else if (keyPressed == ConsoleKey.DownArrow) {
                    _selectedIndex++;
                    if (_selectedIndex == Options.Length)
                    {
                        _selectedIndex = 0;
                    }
                }
            }while ((keyPressed != ConsoleKey.Enter) && (keyPressed != ConsoleKey.Escape));
            if (keyPressed == ConsoleKey.Escape)
                _selectedIndex = -1;
            return _selectedIndex;
        }
    }
}
