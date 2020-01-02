using System;
using System.ComponentModel;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace com.variflight.dataservice.client
{
    public interface IDAO: INotifyPropertyChanged
    {
        void MergeFromMessage(IMessage message, bool full, ChangeDesc cm);
    }
}
