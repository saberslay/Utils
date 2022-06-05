using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace Utils.Web_Socket {
    public class SocketClient {
        static Byte[] _receiveBytes;
        static IPEndPoint _RemoteIpEndPoint;

        private void Connect(string IP, int Port) {
            UdpClient receivingUdpClient = new UdpClient(Port);
            IPEndPoint EP = new IPEndPoint(IPAddress.Parse(IP), Port);
            Byte[] receiveBytes = receivingUdpClient.Receive(ref EP);
            _receiveBytes = receiveBytes;
            _RemoteIpEndPoint = EP;

        }

        public void StartListening(string IP, int Port) {
            Connect(IP,Port);
            while (true) {
                Byte[] receiveBytes = _receiveBytes;
                string returnData = Encoding.ASCII.GetString(receiveBytes);

                Logger.LogInfo(returnData);
            }
        }

        public void SendMessage(string IP, int Port, string PacketOfData) {
            Connect(IP, Port);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.Udp);
            Byte[] packetData = Encoding.ASCII.GetBytes(PacketOfData);
            socket.SendTo(packetData, _RemoteIpEndPoint);
        }
    }
}
