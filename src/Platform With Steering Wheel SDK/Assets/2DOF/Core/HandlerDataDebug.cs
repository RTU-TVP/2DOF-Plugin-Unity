#region

using System;
using System.IO.MemoryMappedFiles;
using System.Threading;
using UnityEngine;

#endregion

namespace _2DOF.Core
{
    /// <summary>
    ///     Этот класс используется для отладки данных, отправляемых в файл, отображаемый в памяти.
    /// </summary>
    public static class HandlerDataDebug
    {
        private static Thread _thread;

        /// <summary>
        ///     Запуск вывода данных в консоль.
        /// </summary>
        public static void PrintStart()
        {
            PrintStop();

            _thread = new Thread(() =>
            {
                while (true)
                {
                    using var memoryMappedFile = MemoryMappedFile.OpenExisting(SendingData.MAP_NAME);
                    PrintData(memoryMappedFile);

                    Thread.Sleep(SendingData.WAIT_TIME);
                }
            });
            _thread.Start();
        }

        /// <summary>
        ///     Остановка вывода данных в консоль.
        /// </summary>
        public static void PrintStop()
        {
            _thread?.Abort();
        }

        /// <summary>
        ///     Вывод данных в консоль.
        /// </summary>
        private static void PrintData(MemoryMappedFile memoryMappedFile)
        {
            try
            {
                using var accessor = memoryMappedFile.CreateViewAccessor();

                var bytes = new byte[accessor.Capacity];

                accessor.ReadArray(0, bytes, 0, bytes.Length);

                var str = $"AnglesX: {bytes[0]}, "
                          + $"AnglesZ: {bytes[1]}, "
                          + $"AnglesY: {bytes[2]}, "
                          + $"VelocityZ: {bytes[3]}, "
                          + $"VelocityX: {bytes[4]}, "
                          + $"VelocityY: {bytes[5]}";

                Debug.Log(str);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}