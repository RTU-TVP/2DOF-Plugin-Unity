#region

using System.IO.MemoryMappedFiles;
using System.Threading;

#endregion

namespace _2DOF.Core
{
    /// <summary>
    ///     Этот класс используется для отправки данных в файл, отображаемый в памяти.
    /// </summary>
    public sealed class SendingData
    {
        /// <summary>
        ///     Статический экземпляр класса.
        /// </summary>
        public static SendingData Instance;

        /// <summary>
        ///     Конструктор.
        /// </summary>
        /// <param name="objectTelemetryData">Данные, которые будут отправляться.</param>
        public SendingData(ObjectTelemetryData objectTelemetryData)
        {
            _objectTelemetryData = objectTelemetryData;

            Instance?.SendingStop();
            Instance = this;
        }

        /// <summary>
        ///     Имя ячейки памяти, которая будет создана.
        /// </summary>
        public const string MAP_NAME = "2DOFMemoryDataGrabber";

        /// <summary>
        ///     Время ожидания между отправками данных.
        ///     В миллисекундах.
        /// </summary>
        public const int WAIT_TIME = 20;

        private readonly ObjectTelemetryData _objectTelemetryData;
        private Thread _thread;

        /// <summary>
        ///     Запуск отправки данных.
        /// </summary>
        public void SendingStart()
        {
            SendingStop();

            _thread = new Thread(HandlerData);
            _thread.Start();
        }

        /// <summary>
        ///     Остановка отправки данных.
        /// </summary>
        public void SendingStop()
        {
            _thread?.Abort();
        }

        /// <summary>
        ///     Обработчик данных.
        /// </summary>
        private void HandlerData()
        {
            using var memoryMappedFile = MemoryMappedFile.CreateOrOpen(MAP_NAME, _objectTelemetryData.DataArray.Length);

            while (true)
            {
                using var accessor = memoryMappedFile.CreateViewAccessor();

                accessor.WriteArray(0, _objectTelemetryData.DataArray, 0, 6);

                Thread.Sleep(WAIT_TIME);
            }
        }
    }
}