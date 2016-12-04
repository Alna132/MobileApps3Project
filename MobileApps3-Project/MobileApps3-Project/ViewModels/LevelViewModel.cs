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
            get { return this.level; }
            set { SetProperty(this.level, value, () => this.level = value); }
        }// End of Level

        public int items
        {
            get { return this.items; }
            set { SetProperty(this.items, value, () => this.items = value); }
        }// End of Items

        public String description
        {
            get { return this.description; }
            set { SetProperty(this.description, value, () => this.description = value); }
        }// End of Description

        public String image
        {
            get { return this.image; }
            set { SetProperty(this.image, value, () => this.image = value); }
        }// End of Image

        public String navString
        {
            get { return this.navString; }
            set { SetProperty(this.navString, value, () => this.navString = value); }
        }// End of Level

    }//- End of LevelViewModel
}//- End of MobileApps3_Project.ViewModels
