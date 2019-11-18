using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace EjectDevresi.Sample
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            //SerialPort serialPort = new SerialPort();
            //string portName =  serialPort.PortName = "COM10";
            //FTD2XX_NET.FTDI fTDI = new FTD2XX_NET.FTDI();
            //fTDI.SetBaudRate(9600);
            //FTD2XX_NET.FTDI.FT_DEVICE_INFO_NODE[] test = new FTD2XX_NET.FTDI.FT_DEVICE_INFO_NODE[10];
            //fTDI.GetDeviceList(test);
            ////FTD2XX_NET.FTDI.FT_DEVICE.FT_DEVICE_232R  fT_DEVIC;
            //fTDI.GetCOMPort(out portName);
            //fTDI.OpenByIndex(0);
            //fTDI.Rescan();
            //FTD2XX.Device fTD2XX = new FTD2XX.Device(5);
            //FTD2XX.DeviceNotOpenedException deviceNotOpenedException = new FTD2XX.DeviceNotOpenedException(FTD2XX.DeviceOpenPurpose.None);
            //FTD2XX.DeviceNotFoundException deviceNotFoundException = new FTD2XX.DeviceNotFoundException();


            ////fTD2XX.Reset();
            ////fTD2XX.SetDataCharacteristics(FTD2XX.BitsPerWord.Seven, FTD2XX.StopBits.One, FTD2XX.Parity.None);
            ////var x =  FTD2XX.Device.GetDevices();
            ////var y =  FTD2XX.DeviceOperation.Read;
            ////var z = FTD2XX.DeviceOpenPurpose.Write;
            //byte[] arr = new byte[10];
            //fTD2XX.Open();
            //fTD2XX.Flush();

            //FTD2XX_NET.FTDI eject = new FTD2XX_NET.FTDI();
            //eject.SetBaudRate(9600);
            //eject.SetBreak(true);
            //eject.SetDataCharacteristics(7, 0, 1);
            //eject.SetDeadmanTimeout(1);
            //eject.SetBitMode(1, 1);
            //eject.SetRTS(true);
            //eject.OpenByIndex(0);
            //eject.RestartInTask();
            //eject.ResetDevice();
            //eject.Purge(0);
            //eject.Reload(0, 0);
            //eject.SetTimeouts(1, 1);
            //FTD2XX_NET.FTDI.FT232B_EEPROM_STRUCTURE eeX = new FTD2XX_NET.FTDI.FT232B_EEPROM_STRUCTURE(); //bizim device bu
            //eeX.Description = "1";
            //eeX.Manufacturer = "1";
            //eeX.ManufacturerID = "1";
            //eeX.MaxPower = 1;
            //eeX.ProductID = 0;
            //eeX.PullDownEnable = true;
            //eeX.RemoteWakeup = true;
            //eeX.SelfPowered = true;
            //eeX.SerialNumber = "1";
            //eeX.SerNumEnable = false;
            //eeX.USBVersion = 0x0200;
            //eeX.USBVersionEnable = true;
            //eeX.VendorID = 1;
            //eject.ReadFT232BEEPROM(eeX);

            //eject.WriteFT232BEEPROM(eeX);

            FTD2XX_NET.FTDI eject = new FTD2XX_NET.FTDI();
            //eject.SetBaudRate(9600);
            //eject.SetDeadmanTimeout(5000);
            //eject.InTransferSize(0x1000);
            //eject.SetLatency(16);
            //FTD2XX_NET.FTDI.FT_DEVICE_INFO_NODE[] deviceList = new FTD2XX_NET.FTDI.FT_DEVICE_INFO_NODE[5];
            //eject.GetDeviceList(deviceList);
            //FTD2XX_NET.FTDI.FT_EXCEPTION exeption = new FTD2XX_NET.FTDI.FT_EXCEPTION();
            //FTD2XX_NET.FTDI.FT_EVENTS events = new FTD2XX_NET.FTDI.FT_EVENTS();
            //FTD2XX_NET.FTDI.FT_DRIVE_CURRENT ftDrive = new FTD2XX_NET.FTDI.FT_DRIVE_CURRENT();
            //FTD2XX_NET.FTDI.FT_EEPROM_DATA epromData = new FTD2XX_NET.FTDI.FT_EEPROM_DATA();
            //FTD2XX_NET.FTDI.FT_FLOW_CONTROL control = new FTD2XX_NET.FTDI.FT_FLOW_CONTROL();
            //FTD2XX_NET.FTDI.FT_XSERIES_CBUS_OPTIONS options = new FTD2XX_NET.FTDI.FT_XSERIES_CBUS_OPTIONS();
            //FTD2XX_NET.FTDI.FT_FLAGS flags = new FTD2XX_NET.FTDI.FT_FLAGS();
            //FTD2XX_NET.FTDI.FT232B_EEPROM_STRUCTURE deviceStructure = new FTD2XX_NET.FTDI.FT232B_EEPROM_STRUCTURE();
            //FTD2XX_NET.FTDI.FT_PURGE purge = new FTD2XX_NET.FTDI.FT_PURGE();
            var ftDeger =  eject.OpenByIndex(0);
            if (ftDeger == FTD2XX_NET.FTDI.FT_STATUS.FT_OK)
            {
                eject.CyclePort();
            }


        }
    }
}
