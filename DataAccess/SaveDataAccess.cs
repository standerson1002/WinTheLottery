using GameObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DataAccessLayer
{
    public class SaveDataAccess
    {
        public int RetrieveData(int x, int saveSlot)
        {
            char[] separator = { ',' };

            int _day = 0;
            int _balance = 0;
            int _returnValue = 0;

            using (StreamReader reader = new StreamReader(AppData.DataPath + "savedata" + saveSlot + ".txt"))
            {
                string line = reader.ReadLine();
                string[] parts;
               
                parts = line.Split(separator);

                if (parts.Count() == 2) // check that it has the right number of parts
                {
                    _day = int.Parse(parts[0]);
                    _balance = int.Parse(parts[1]);
                }
                if (x == 1) // option 1 is returning day
                {
                    _returnValue = _day;
                }
                if(x == 2) // option 2 is returning balance
                {
                    _returnValue = _balance;
                }
            }
            return _returnValue;
        } // end RetrieveData()

        public bool SaveData(int day, int balance, int saveSlot)
        {
            bool result = false;

            FileStream saveFile = null;
            StreamWriter saveWriter = null;

            try
            {
                saveFile = new FileStream(AppData.DataPath + "savedata" + saveSlot + ".txt",
                    FileMode.Create, FileAccess.Write);
                saveWriter = new StreamWriter(saveFile);
                string line = day + "," + balance;
                saveWriter.WriteLine(line);
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                saveWriter.Close();
            }

            return result;
        } // end SaveData()

        public bool SaveAchievementData(bool cashFlow, int cashFlowDay,
                                     bool breakEven, int breakEvenDay,
                                     bool winBig, int winBigDay, int saveSlot)
        {
            bool result = false;

            FileStream saveFile = null;
            StreamWriter saveWriter = null;

            try
            {
                saveFile = new FileStream(AppData.DataPath + "achievements" + saveSlot + ".txt",
                    FileMode.Create, FileAccess.Write);
                saveWriter = new StreamWriter(saveFile);
                string line = cashFlow + "," + cashFlowDay + "," +
                              breakEven + "," + breakEvenDay + "," +
                              winBig + "," + winBigDay;
                saveWriter.WriteLine(line);
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                saveWriter.Close();
            }

            return result;
        } // end SaveAchievementData()

        public string RetrieveAchievementData(int x, int saveSlot)
        {
            char[] separator = { ',' };
            string _returnValue = "";

            string _cashFlow = "";
            string _cashFlowDay = "";
            string _breakEven = "";
            string _breakEvenDay = "";
            string _winBig = "";
            string _winBigDay = "";

            using (StreamReader reader = new StreamReader(AppData.DataPath + "achievements" + saveSlot + ".txt"))
            {
                string line = reader.ReadLine();
                string[] parts;

                parts = line.Split(separator);

                if (parts.Count() == 6)
                {
                    _cashFlow = parts[0];
                    _cashFlowDay = parts[1];
                    _breakEven = parts[2];
                    _breakEvenDay = parts[3];
                    _winBig = parts[4];
                    _winBigDay = parts[5];
                }
                if (x == 1) // option 1 is returning Cash Flow status
                {
                    _returnValue = _cashFlow.ToString();
                }
                if (x == 2) // option 2 is returning when Cash Flow was achieved
                {
                    _returnValue = _cashFlowDay.ToString();
                }
                if (x == 3) // option 3 is returning Break Even status
                {
                    _returnValue = _breakEven.ToString();
                }
                if (x == 4) // option 4 is returning when Break Even was achieved
                {
                    _returnValue = _breakEvenDay.ToString();
                }
                if (x == 5) // option 5 is returning Win Big status
                {
                    _returnValue = _winBig.ToString();
                }
                if (x == 6) // option 6 is returning when Win Big was achieved
                {
                    _returnValue = _winBigDay.ToString();
                }
            }
            return _returnValue;
        } // end RetrieveAchievementData()


        // Save Settings //
        public bool SaveSettingsData(int price, int multiplier, string color, string number, int saveSlot)
        {
            bool result = false;

            FileStream saveFile = null;
            StreamWriter saveWriter = null;

            try
            {
                saveFile = new FileStream(AppData.DataPath + "settings" + saveSlot + ".txt",
                    FileMode.Create, FileAccess.Write);
                saveWriter = new StreamWriter(saveFile);
                string line = price + "," + multiplier + "," +
                              color + "," + number;
                saveWriter.WriteLine(line);
                result = true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                saveWriter.Close();
            }

            return result;
        }

        public string RetrieveSettingsData(int x, int saveSlot)
        {
            char[] separator = { ',' };

            string _price = "";
            string _multiplier = "";
            string _color = "";
            string _number = "";

            string _returnValue = "";

            using (StreamReader reader = new StreamReader(AppData.DataPath + "settings" + saveSlot + ".txt"))
            {
                string line = reader.ReadLine();
                string[] parts;

                parts = line.Split(separator);

                if (parts.Count() == 4) // check that it has the right number of parts
                {
                    _price = parts[0];
                    _multiplier = parts[1];
                    _color = parts[2];
                    _number = parts[3];
                }
                if (x == 1) // option 1 is returning price
                {
                    _returnValue = _price;
                }
                if (x == 2) // option 2 is returning multiplier
                {
                    _returnValue = _multiplier;
                }
                if (x == 3) // option 3 is returning color
                {
                    _returnValue = _color;
                }
                if (x == 4) // option 4 is returning number
                {
                    _returnValue = _number;
                }
            }
            return _returnValue;
        }


    }
}
