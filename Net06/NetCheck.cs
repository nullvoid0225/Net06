using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net.NetworkInformation;
using System.IO;
using System.Threading;

namespace Net06
{
    public class NetCheck
    {
        Ping PingSender = new Ping();
        PingOptions PingOption = new PingOptions();
        string PingData = "aaaaaaaaaaaaaaaaaaaaaaaaaaaaaaaa"; //32바이트
        const int PingTimeOut = 120; //네트워크 체크를 위한 타임아웃

        Byte[] PingBuffer = new byte[100];
        PingReply reply;

        public NetCheck()
        {
            PingBuffer = Encoding.ASCII.GetBytes(PingData);
            PingOption.DontFragment = true;
        }

        public PingReply PingReply(string ip)
        {
            //PingBuffer = Encoding.ASCII.GetBytes(PingData);

 
            if ("" != ip)
            {
                reply = PingSender.Send(ip, PingTimeOut, PingBuffer, PingOption);

                return reply;
            }
            else
            {
                return reply;
            }
        }

    }
}
