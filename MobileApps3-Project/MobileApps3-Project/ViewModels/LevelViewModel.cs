using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MobileApps3_Project.Data;

namespace MobileApps3_Project.ViewModels
{
    public class LevelViewModel : NotificationBase<Data.Levels>
    {
        public LevelViewModel(Data.Levels difficulty = null) : base(difficulty) { }
        public String level
        {
            get { return This.level; }
            set { SetProperty(This.level, value, () => This.level = value); }
        }// End of Level

        public int items
        {
            get { return This.items; }
            set { SetProperty(This.items, value, () => This.items = value); }
        }// End of Items

        public String description
        {
            get { return This.description; }
            set { SetProperty(This.description, value, () => This.description = value); }
        }// End of Description

        public String image
        {
            get { return This.image; }
            set { SetProperty(This.image, value, () => This.image = value); }
        }// End of Image

        public String navString
        {
            get { return This.navString; }
            set { SetProperty(This.navString, value, () => This.navString = value); }
        }// End of Level

    }//- End of LevelViewModel
}//- End of MobileApps3_Project.ViewModels
