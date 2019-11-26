using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TCPClient_Async
{
    class Message
    {

        public static byte[] GetBytes(string data)
        {
            byte[] dataBytes = Encoding.UTF8.GetBytes(data);

            int dataLength = dataBytes.Length;

            //組合成新的數組，組成[數組長度+資料]
            byte[] lengthBytes = BitConverter.GetBytes(dataLength);
            byte[] newBytes = lengthBytes.Concat(dataBytes).ToArray();
            return newBytes;
        }

    }
}
