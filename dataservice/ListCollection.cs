using System;
using System.Collections;
using System.Collections.ObjectModel;
using Google.Protobuf;
using Google.Protobuf.Reflection;

namespace com.variflight.dataservice.client
{
    public class ListCollection<V, T> : ObservableCollection<V>
    {
        public ListCollection()
        {
        }

        public void MergeFromMessage(IMessage message, FieldDescriptor field, bool full, ChangeDesc p)
        {
            IList list = field.Accessor.GetValue(message) as IList;
            if (full)
            {
                foreach (var item in list)
                {
                    if (typeof(IMessage).IsAssignableFrom(typeof(T)))
                    {
                        var dao = Activator.CreateInstance<V>() as DAO;
                        dao.MergeFromMessage(item as IMessage, full, null);
                        this.Add((V)dao);
                    }
                    else
                    {
                        this.Add((V)item);
                    }
                }
            }
        }
    }
}
