using System;

namespace ThinkPadACPIController
{
    class Program
    {
        private static void Main(string[] args)
        {

            var driverOpened = TVicPort.OpenTVicPort() != 0 && TVicPort.IsDriverOpened() != 0;

            if (!driverOpened)
            Console.WriteLine("Unable to open driver");
            try
            {
                Console.WriteLine("1 = Bluetooth On");
                Console.WriteLine("2 = Bluetooth Off");
                Console.WriteLine("3 = ThinkLight On");
                Console.WriteLine("4 = ThinkLight Off");
                Console.WriteLine("Other = Quit");

                var selection = Console.ReadKey();
                if (selection.Key == ConsoleKey.D1) BluetoothOn();
                if (selection.Key == ConsoleKey.D2) BluetoothOff();
                if (selection.Key == ConsoleKey.D3) ThinkLightOn();
                if (selection.Key == ConsoleKey.D4) ThinkLightOff();
            }
            finally
            {
                TVicPort.CloseTVicPort();
            }
        }

        private static void ThinkLightOff()
        {
            TVicPort.WritePort(0x1604, 0x81);
            TVicPort.WritePort(0x1600, 0x3b);
            TVicPort.WritePort(0x1600, 0x10);
        }

        private static void ThinkLightOn()
        {
            TVicPort.WritePort(0x1604, 0x81);
            TVicPort.WritePort(0x1600, 0x3b);
            TVicPort.WritePort(0x1600, 0x12);
        }

        private static void BluetoothOff()
        {
            TVicPort.WritePort(0x1604, 0x81);
            TVicPort.WritePort(0x1600, 0x3a);
            TVicPort.WritePort(0x1600, 0x20);
        }
        private static void BluetoothOn()
        {
            TVicPort.WritePort(0x1604, 0x81);
            TVicPort.WritePort(0x1600, 0x3a);
            TVicPort.WritePort(0x1600, 0x30);
        }
    }
}
