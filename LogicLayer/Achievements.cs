using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicLayer
{
    public class Achievements
    {
        private bool _cashFlow;
        private int _cashFlowDay;
        private bool _breakEven;
        private int _breakEvenDay;
        private bool _winBig;
        private int _winBigDay;

        SaveDataAccess saveData = new SaveDataAccess();

        public void EnableCashFlow(int day)
        {
            _cashFlow = true;
            _cashFlowDay = day;
        }
        public void EnableBreakEven(int day)
        {
            _breakEven = true;
            _breakEvenDay = day;
        }
        public void EnableWinBig(int day)
        {
            _winBig = true;
            _winBigDay = day;
        }
        public void DisableAchievements()
        {
            _cashFlow = false;
            _cashFlowDay = 0;
            _breakEven = false;
            _breakEvenDay = 0;
            _winBig = false;
            _winBigDay = 0;
        }

        public void SaveAchievementData(int saveSlot)
        {
            saveData.SaveAchievementData(_cashFlow, _cashFlowDay,
                                        _breakEven, _breakEvenDay,
                                        _winBig, _winBigDay, saveSlot);
        }
        public void RetrieveAchievementData(int saveSlot)
        {
            _cashFlow = bool.Parse(saveData.RetrieveAchievementData(1, saveSlot));
            _cashFlowDay = int.Parse(saveData.RetrieveAchievementData(2, saveSlot));
            _breakEven = bool.Parse(saveData.RetrieveAchievementData(3, saveSlot));
            _breakEvenDay = int.Parse(saveData.RetrieveAchievementData(4, saveSlot));
            _winBig = bool.Parse(saveData.RetrieveAchievementData(5, saveSlot));
            _winBigDay = int.Parse(saveData.RetrieveAchievementData(6, saveSlot));
        }
        public void RetrieveAchievements(bool cashFlow, int cashFlowDay,
                                    bool breakEven, int breakEvenDay,
                                    bool winBig, int winBigDay)
        {
            _cashFlow = cashFlow;
            _cashFlowDay = cashFlowDay;
            _breakEven = breakEven;
            _breakEvenDay = breakEvenDay;
            _winBig = winBig;
            _winBigDay = winBigDay;
        }
        public bool ReturnCashFlow()
        {
            return _cashFlow;
        }
        public int ReturnCashFlowDay()
        {
            return _cashFlowDay;
        }
        public bool ReturnBreakEven()
        {
            return _breakEven;
        }
        public int ReturnBreakEvenDay()
        {
            return _breakEvenDay;
        }
        public bool ReturnWinBig()
        {
            return _winBig;
        }
        public int ReturnWinBigDay()
        {
            return _winBigDay;
        }
    }
}
