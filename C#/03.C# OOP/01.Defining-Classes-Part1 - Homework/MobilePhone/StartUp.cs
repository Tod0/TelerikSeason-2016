namespace MobilePhone
{
    using System;

    class StartUp
    {
        static void Main()
        {
            var gsmTest = new GSMTest();
            gsmTest.DisplayGsmInformation();

            var callTest = new GSMCallHistoryTest();
            callTest.Test();
        }
    }
}
