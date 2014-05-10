using System;

using ProtoBuf;

namespace TcpBulletinCommon
{
    [ProtoContract]
    public class BulletinMessage
    {
        [ProtoMember(1)]
        public string Content { get; set; }

        [ProtoMember(2)]
        public DateTime Timestamp { get; set; }


        public string ToString()
        {
            return "Message: '" + Content + "' || Timestamp: '" + Timestamp + "'";
        }
    }
}
