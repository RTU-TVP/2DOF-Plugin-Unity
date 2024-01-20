#region

using System;

#endregion

namespace _2DOF.Core
{
    /// <summary>
    ///     Класс ObjectTelemetryData используется для хранения и обработки данных телеметрии объекта.
    /// </summary>
    [Serializable]
    public class ObjectTelemetryData
    {
        /// <summary>
        ///     Угол поворота объекта по оси X.
        /// </summary>
        public double AnglesX { get; set; }

        /// <summary>
        ///     Угол поворота объекта по оси Z.
        /// </summary>
        public double AnglesZ { get; set; }

        /// <summary>
        ///     Угол поворота объекта по оси Y.
        /// </summary>
        public double AnglesY { get; set; }

        /// <summary>
        ///     Скорость объекта по оси Z.
        /// </summary>
        public double VelocityZ { get; set; }

        /// <summary>
        ///     Скорость объекта по оси X.
        /// </summary>
        public double VelocityX { get; set; }

        /// <summary>
        ///     Скорость объекта по оси Y.
        /// </summary>
        public double VelocityY { get; set; }

        /// <summary>
        ///     Массив, содержащий все данные телеметрии объекта.
        /// </summary>
        public double[] DataArray => new[] { AnglesX, AnglesZ, AnglesY, VelocityZ, VelocityX, VelocityY };

        /// <summary>
        ///     Метод для сброса всех данных телеметрии объекта до нуля.
        /// </summary>
        public void Reset()
        {
            AnglesX = 0.0;
            AnglesZ = 0.0;
            AnglesY = 0.0;
            VelocityZ = 0.0;
            VelocityX = 0.0;
            VelocityY = 0.0;
        }

        /// <summary>
        ///     Переопределенный метод ToString для преобразования данных телеметрии объекта в строку.
        /// </summary>
        public override string ToString()
        {
            return $"AnglesX: {AnglesX}, AnglesZ: {AnglesZ}, AnglesY: {AnglesY}, " +
                   $"VelocityZ: {VelocityZ}, VelocityX: {VelocityX}, VelocityY: {VelocityY}";
        }
    }
}