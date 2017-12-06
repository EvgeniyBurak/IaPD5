using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace lab5
{
    class Device
    {

       /// <summary>
       /// Название устройства
       /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// GUID
        /// </summary>
        public string ClassGuid { get; set; }
        /// <summary>
        /// HardwareID
        /// </summary>
        public string HardwareId { get; set; }
        /// <summary>
        /// Производитель
        /// </summary>
        public string Manufacturer { get; set; }
        /// <summary>
        /// Описание 
        /// </summary>
        public string Description { get; set; }
        /// <summary>
        /// Провайдер
        /// </summary>
        public string Provider { get; set; }
        /// <summary>
        /// Системный путь
        /// </summary>
        public string SysPath { get; set; }
        /// <summary>
        ///Значение Device Path
        /// </summary>
        public string DevicePath { get; set; }
        /// <summary>
        ///Статус устройства вкл/вкл
        /// </summary>
        public bool Status { get; set; }

        public void ChangeConnection(string method)
        {
            var device = new ManagementObjectSearcher("SELECT * FROM Win32_PNPEntity").Get().OfType<ManagementObject>()
                .FirstOrDefault(x => x["DeviceID"].ToString().Equals(DevicePath));
            device?.InvokeMethod(method, new object[] { false });
        }
    }
}
