using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileApps3_Project.Models;
using System.Collections.ObjectModel;

namespace MobileApps3_Project.ViewModels
{
    class DifficultyViewModel
    {
        Models.theLevels Difficulty;

        public DifficultyViewModel()
        {
            Models.theLevels test = new Models.theLevels();

            foreach (var level in test.Difficulty)
            {
                var np = new LevelViewModel(level);
                _level.Add(np);
            }
        }


        ObservableCollection<LevelViewModel> _level = new ObservableCollection<LevelViewModel>();

        public ObservableCollection<LevelViewModel> Level
        {
            get { return _level; }
            set { SetProperty(ref _level, value); }
        }

        //String _Name;
        //public String Name
        //{
        //    get { return Difficulty.BreedName; }
        //}

        int _SelectedIndex;
        public int SelectedIndex
        {
            get { return _SelectedIndex; }
            set
            {
                if (SetProperty(ref _SelectedIndex, value))
                { RaisePropertyChanged(nameof(SelectedLevel)); }
            }
        }

        public LevelViewModel SelectedLevel
        {
            get { return (_SelectedIndex >= 0) ? _level[_SelectedIndex] : null; }
        }
    }
}
