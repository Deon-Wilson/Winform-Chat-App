using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace ReferenceData.Utils
{
    public class ChatAppUtils
    {
        public static byte[] ConvertFileToByte(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            byte[] bytes = System.IO.File.ReadAllBytes(fileName);
            fs.Read(bytes, 0, System.Convert.ToInt32(fs.Length));
            fs.Close();
            return bytes;
        }
        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
        public static byte[] Serialize(object obj)
        {
            MemoryStream stream = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, obj);
            byte[] bytes = stream.ToArray();
            stream.Flush();
            return bytes;
        }

        public static object Deserialize(byte[] data)
        {
            object obj;
            MemoryStream stream = new MemoryStream(data);
            stream.Position = 0;
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                obj = formatter.Deserialize(stream);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                obj = null;
            }
            return obj;
        }
    }
}
