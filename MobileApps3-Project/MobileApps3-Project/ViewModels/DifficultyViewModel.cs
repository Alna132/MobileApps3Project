using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileApps3_Project.Models;
using System.Collections.ObjectModel;
using MobileApps3_Project.Data;

namespace MobileApps3_Project.ViewModels
{
    public class DifficultyViewModel : NotificationBase
    {
        Models.theLevels Difficulty;
        public List<Levels> mylist;
        
        public DifficultyViewModel()
        {
            //Models.theLevels test = new Models.theLevels();
            LoadData();

            //foreach (var level in test.Difficulty)
            //{
            //    var np = new LevelViewModel(level);
            //    _level.Add(np);
            //}//- End of Foreach
        }//- End of DifficultyViewModel

        public async void LoadData()
        {
            //Models.theLevels test
            //  = new Models.theLevels();

            mylist = await theLevels.LoadData();

            foreach (var level in theLevels.gLevelList)
            {
                var np = new LevelViewModel(level);
                _level.Add(np);
            }//- End of Foreach
        }//- End of LoadData

        ObservableCollection<LevelViewModel> _level = new ObservableCollection<LevelViewModel>();

        public ObservableCollection<LevelViewModel> Level
        {
            get { return _level; }//- End of get
            set { SetProperty(ref _level, value); }//- End of set
        }//- End of Level

        int _SelectedIndex;
        public int SelectedIndex
        {
            get { return _SelectedIndex; }//- End of get
            set
            {
                if (SetProperty(ref _SelectedIndex, value))
                { RaisePropertyChanged(nameof(SelectedLevel)); }//- End of if
            }//- End of set
        }//- End of SelectedIndex

        public LevelViewModel SelectedLevel
        {
            get { return (_SelectedIndex >= 0) ? _level[_SelectedIndex] : null; }//- End of get
        }//- End of SelectedLevel
    }//- End of DifficultyViewModel
}//- End of MobileApps3_Project.ViewModels
