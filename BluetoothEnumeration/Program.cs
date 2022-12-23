using InTheHand.Net.Sockets;

namespace BluetoothEnumeration
{
    class Program
    {
        static void Main(string[] args)
        {
            // Enumerate the paired Bluetooth devices
            var client = new BluetoothClient();

            var devices = client.DiscoverDevices();

            var items = new List<BluetoothDeviceInfo>();

            // Display the device information
            foreach (var device in devices)
            {
                if (device.Connected)
                {
                    items.Add(device);
                    //Console.WriteLine("Device Name: " + device.DeviceName);
                    //Console.WriteLine("Device Address: " + device.DeviceAddress);
                    //Console.WriteLine("Device Class: " + device.ClassOfDevice);
                    //Console.WriteLine("Connected: " + device.Connected);
                    //Console.WriteLine();
                }
            }

            if (items.Count > 0)
            {
                foreach (var device in items)
                {
                    Console.WriteLine("Device Name: " + device.DeviceName);
                    Console.WriteLine("Device Address: " + device.DeviceAddress);
                    Console.WriteLine("Device Class: " + device.ClassOfDevice);
                    Console.WriteLine("Connected: " + device.Connected);
                    Console.WriteLine();
                }
            }
            else
            {
                Console.WriteLine("No Devices Connected");
            }

            Console.ReadKey();
        }
    }
}