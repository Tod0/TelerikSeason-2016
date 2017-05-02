namespace MobilePhone
{
    using System;

    class GSMCallHistoryTest
    {
        private GSM gsm = new GSM("Galaxy S4", "Samsung", 600, "Tosho", new Battery(BatteryType.NiCd, 72, 60), new Display(5.5, 118982952));

        public void Test()
        {
            gsm.AddCall(new Call(new DateTime(2016, 05, 15, 18, 30, 22), "0885 654 213", 100));
            gsm.AddCall(new Call(new DateTime(2015, 11, 22, 13, 45, 23), "0888 352 351", 100));
            gsm.AddCall(new Call(new DateTime(2016, 09, 19, 15, 30, 44), "0887 424 212", 100));

            Console.WriteLine(gsm.CallHistoryInfo());

            Console.WriteLine("Total price: {0:F2} BGN", gsm.CallPrice(0.37m));

            gsm.RemoveLongestCall();
            Console.WriteLine("Now the total price is {0:F2} BGN", gsm.CallPrice(0.37m));

            gsm.ClearCallHistory();
            Console.WriteLine(gsm.CallHistoryInfo());
        }
    }
}
