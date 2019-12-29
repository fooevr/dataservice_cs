using System;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace com.variflight.dataservice.cs
{
    public interface DAO
    {
        void MergeFromMessage(IMessage message, bool full, ChangeDesc cm);
    }
}
