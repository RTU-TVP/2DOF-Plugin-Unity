namespace _2DOF.Core
{
    /// <summary>
    /// Данные телеметрии объекта.
    /// </summary>
    public class ObjectTelemetryData
    {
        /// <summary>
        /// Угл поворота по оси X.
        /// </summary>
        public double AnglesX { get; set; }

        /// <summary>
        /// Угл поворота по оси Z.
        /// </summary>
        public double AnglesZ { get; set; }

        /// <summary>
        /// Угл поворота по оси Y.
        /// </summary>
        public double AnglesY { get; set; }

        /// <summary>
        /// Скорость по оси Z.
        /// </summary>
        public double VelocityZ { get; set; }

        /// <summary>
        /// Скорость по оси X.
        /// </summary>
        public double VelocityX { get; set; }

        /// <summary>
        /// Скорость по оси Y.
        /// </summary>
        public double VelocityY { get; set; }

        /// <summary>
        /// Массив данных.
        /// </summary>
        public double[] DataArray => new[] { AnglesX, AnglesZ, AnglesY, VelocityZ, VelocityX, VelocityY };

        /// <summary>
        /// Сброс данных.
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
        /// Преобразование в строку.
        /// </summary>
        public override string ToString()
        {
            return $"AnglesX: {AnglesX}, AnglesZ: {AnglesZ}, AnglesY: {AnglesY}, " +
                   $"VelocityZ: {VelocityZ}, VelocityX: {VelocityX}, VelocityY: {VelocityY}";
        }
    }
}