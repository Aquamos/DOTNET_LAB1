using ConsoleApp.Commands.EnumCommands;

namespace ConsoleApp
{
    public class CommandsDictionary
    {
        private Dictionary<MenuCommands, Func<MenuSeeder, (int, MenuCommands)>> _menuCommands;
        private Dictionary<InfoCommands, Action> _InfoCommands;
        private Dictionary<SortCommands, Action> _sortCommands;
        private Dictionary<GroupCommands, Action> _groupCommands;
        private Dictionary<SearchCommands, Action> _searchCommands;
        private Dictionary<ACCommands, Action> _aCCommands;

        private Printer _printer;
        private MenuMethods _menuMethods;
        public CommandsDictionary() {
            _printer = new Printer();

            _menuMethods = new MenuMethods();

            _menuCommands = new Dictionary<MenuCommands, Func<MenuSeeder, (int, MenuCommands)>>()
            {
                {MenuCommands.MainMenu, _menuMethods.ShowMainMenu },
                {MenuCommands.FullInfoMenu, _menuMethods.ShowFullInfoMenu },
                {MenuCommands.SortedMenu, _menuMethods.ShowSortedMenu },
                {MenuCommands.SearchMenu, _menuMethods.ShowSearchMenu },
                {MenuCommands.GroupMenu, _menuMethods.ShowGroupMenu },
                {MenuCommands.AggregateAndCollectionsMenu, _menuMethods.ShowAggregateAndCollectionsMenu }
            };

            _InfoCommands = new Dictionary<InfoCommands, Action>() 
            {
                {InfoCommands.PrintStudentsFullInfo, _printer.PrintStudentsFullInfo },
                {InfoCommands.PrintTeacherFullInfo, _printer.PrintTeachersFullInfo },
                {InfoCommands.PrintResourcesFullInfo, _printer.PrintResourcesFullInfo },
                {InfoCommands.PrintTeachersAndStudentsInfo, _printer.PrintTeachersAndStudentsInfo},
                {InfoCommands.PrintStudentsAndTeachersInfo, _printer.PrintStudentsAndTeachersInfo},
                {InfoCommands.PrintStudentsAndResourcesInfo,  _printer.PrintStudentsAndResourcesInfo},
                {InfoCommands.PrintStudentsDiplomaDefense, _printer.PrintStudentsDiplomaDefense },
                {InfoCommands.PrintTeachersWithCountStudents, _printer.PrintTeachersWithCountStudents },
                {InfoCommands.PrintTopGPAStudents, _printer.PrintTopGPAStudents },
                {InfoCommands.PrintAllTeachersWithStudentsDateOfDefense, _printer.PrintAllTeachersWithStudentsDateOfDefense },
            };

            _sortCommands = new Dictionary<SortCommands, Action>()
            {
                {SortCommands.PrintStudentsSortedByNameThenByBirthDate, _printer.PrintStudentsSortedByNameThenByBirthDate},
                {SortCommands.PrintStudentsSortedByDefenceDateThenByName, _printer.PrintStudentsSortedByDefenceDateThenByName }
            };

            _searchCommands = new Dictionary<SearchCommands, Action>()
            {
                {SearchCommands.PrintStudentsFromDateOfDefense, _printer.PrintStudentsFromDateOfDefense },
                {SearchCommands.PrintStudentsTopicsByFaculty, _printer.PrintStudentsTopicsByFaculty},
            };

            _groupCommands = new Dictionary<GroupCommands, Action>()
            {
                {GroupCommands.PrintGroupOfStudentsByDateOfDefense, _printer.PrintGroupOfStudentsByDateOfDefense }
            };

            _aCCommands = new Dictionary<ACCommands, Action>()
            {
                {ACCommands.PrintMaxAverageGPAByDepartments, _printer.PrintMaxAverageGPAByDepartments },
                {ACCommands.PrintDistinctStudentsResources, _printer.PrintDistinctStudentsResources },
            };
        }
        public Func<MenuSeeder, (int, MenuCommands)> this[MenuCommands index] => _menuCommands[index];
        public Action this[InfoCommands index] => _InfoCommands[index];
        public Action this[SortCommands index] => _sortCommands[index];
        public Action this[SearchCommands index] => _searchCommands[index];
        public Action this[GroupCommands index] => _groupCommands[index];
        public Action this[ACCommands index] => _aCCommands[index];

    }
}
