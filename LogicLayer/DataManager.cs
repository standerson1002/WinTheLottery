using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayer;
using GameObjects;

namespace LogicLayer
{
    public class DataManager
    {

        SaveDataAccess saveDataAccess = new SaveDataAccess();
        public int GetDay(int saveSlot)
        {
            int day = saveDataAccess.RetrieveData(1, saveSlot);
            return day;
        }

        public int GetBalance(int saveSlot)
        {
            int balance = saveDataAccess.RetrieveData(2, saveSlot);
            return balance;
        }

        public bool SaveGame(int day, int balance, int saveSlot)
        {
            bool result = false;
            try
            {
                SaveDataAccess saveData = new SaveDataAccess();
                result = saveData.SaveData(day, balance, saveSlot);
                
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Can't Save Game\n", ex);
            }
            return result;
        }


        public int GetPrice(int saveSlot)
        {
            int price = int.Parse(saveDataAccess.RetrieveSettingsData(1, saveSlot));
            return price;
        }
        public int GetMultiplier(int saveSlot)
        {
            int multiplier = int.Parse(saveDataAccess.RetrieveSettingsData(2, saveSlot));
            return multiplier;
        }

        public string GetColor(int saveSlot)
        {
            string color = saveDataAccess.RetrieveSettingsData(3, saveSlot);
            return color;
        }
        public string GetNumber(int saveSlot)
        {
            string number = saveDataAccess.RetrieveSettingsData(4, saveSlot);
            return number;
        }

        public bool SaveSettings(int price, int multiplier, string color, string number, int saveSlot)
        {
            bool result = false;
            try
            {
                SaveDataAccess saveData = new SaveDataAccess();
                result = saveData.SaveSettingsData(price, multiplier, color, number, saveSlot);

            }
            catch (Exception ex)
            {
                throw new ApplicationException("Can't Save Game\n", ex);
            }
            return result;
        }


        
    }
}
