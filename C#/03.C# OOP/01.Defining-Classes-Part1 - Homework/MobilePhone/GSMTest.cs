namespace MobilePhone
{
    class GSMTest
    {
        private GSM[] gsms =
        {
            new GSM("Galaxy S6", "Samsung", 900, "Ivo", new Battery(BatteryType.LiIon, 72, 48), new Display(6.5, 160000000)),
            new GSM("Galaxy S4", "Samsung", 600, "Gosho", new Battery(BatteryType.NiCd, 72, 60), new Display(5.5, 118982952)),
            new GSM("iPhone 5S", "Apple", 700, "Pesho", new Battery(BatteryType.NiMH, 60, 36), new Display(5, 16058450)),
        };

        public void DisplayGsmInformation()
        {
            foreach (var gsm in gsms)
            {
                gsm.DisplayInfo();
            }

            GSM.IPhone4S.DisplayInfo();
        }
    }
}
