using System;
using System.IO.MemoryMappedFiles;
using UnityEngine;

namespace _2DOF.Core
{
    public class HandlerDataDebug : MonoBehaviour
    {
        private void Update()
        {
            using var memoryMappedFile = MemoryMappedFile.OpenExisting("2DOFMemoryDataGrabber");
            using var accessor = memoryMappedFile.CreateViewAccessor();
            
            var bytes = new byte[accessor.Capacity];
            
            accessor.ReadArray(0, bytes, 0, bytes.Length);
            
            Console.WriteLine($"AnglesX: {bytes[0]}");
            Console.WriteLine($"AnglesZ: {bytes[1]}");
            Console.WriteLine($"AnglesY: {bytes[2]}");
            Console.WriteLine($"VelocityZ: {bytes[3]}");
            Console.WriteLine($"VelocityX: {bytes[4]}");
            Console.WriteLine($"VelocityY: {bytes[5]}");
        }
    }
}