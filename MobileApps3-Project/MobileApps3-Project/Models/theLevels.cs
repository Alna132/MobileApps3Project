using MobileApps3_Project.Data;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Windows.ApplicationModel;
using Windows.Data.Json;
using Windows.Storage;

namespace MobileApps3_Project.Models
{
    class theLevels
    {
        public List<Levels> Difficulty { get; set; }
        public static List<Levels> gLevelList = new List<Levels>();
        public String DifficultyName { get; set; }

        public theLevels()
        {
            LoadData();
            Difficulty = gLevelList;
        }//- End of theLevels()

        public static async Task LoadData()
        {
            await LoadLocalData();
        }//- End of LoadData

        public static async Task LoadLocalData()
        {
            var file = await Package.Current.InstalledLocation.GetFileAsync("Data\\Levels.txt");
            var result = await FileIO.ReadTextAsync(file);

            var jLevelList = JsonArray.Parse(result);
            CreateLevelList(jLevelList);
        }//- End of LoadLocalData

        private static void CreateLevelList(JsonArray jLevelList)
        {
            foreach (var item in jLevelList)
            {
                var oneLevel = item.GetObject();
                Levels nLevel = new Levels();

                foreach (var key in oneLevel.Keys)
                {
                    IJsonValue value;
                    if (!oneLevel.TryGetValue(key, out value))
                        continue;

                    switch (key)
                    {
                        case "level":
                            nLevel.level = value.GetString();
                            break;
                        case "items":
                            nLevel.items = (int)value.GetNumber();
                            break;
                        case "description":
                            nLevel.description = value.GetString();
                            break;
                        case "image":
                            nLevel.image = value.GetString();
                            break;
                    } // End of switch
                } // End of foreach(var key in oneLevel.Keys )
                gLevelList.Add(nLevel);
            } // End of foreach (var item in jLevelList)
        }//- End of CreateLevelList
    }//- End of theLevels
}//- End of MobileApps3_Project.Models
