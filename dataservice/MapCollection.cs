using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Threading;
using System.Windows.Data;
using System.Windows.Threading;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Serilog;
using Serilog.Core;
using System.Linq;

namespace com.variflight.dataservice.client
{
    public class MapCollection<K, V, T> : ObservableCollection<V>, IDictionary<K, V>, IEnumerable<V>
    {
        public override event NotifyCollectionChangedEventHandler CollectionChanged;
        Logger log = new LoggerConfiguration()
                .WriteTo.Console()
                .MinimumLevel.Debug()
                .CreateLogger();
        private readonly object locker = new object();
        private ConcurrentDictionary<K, V> _map = new ConcurrentDictionary<K, V>();

        public ICollection<K> Keys => this._map.Keys;

        public ICollection<V> Values => this._map.Values;

        public bool IsReadOnly => true;

        public V this[K key] { get => _map[key]; set => _map[key] = value; }

        public MapCollection()
        {
            BindingOperations.EnableCollectionSynchronization(this, locker);
        }

        protected override void OnCollectionChanged(NotifyCollectionChangedEventArgs e)
        {
            if(this.CollectionChanged == null)
            {
                return;
            }
            foreach(NotifyCollectionChangedEventHandler item in this.CollectionChanged.GetInvocationList())
            {
                var disObj = item.Target as DispatcherObject;
                if(disObj != null)
                {
                    if(disObj.Dispatcher != null)
                    {
                        if (!disObj.Dispatcher.CheckAccess())
                        {
                            disObj.Dispatcher.BeginInvoke((Action)(() => {
                                item.Invoke(this, e);
                            }), DispatcherPriority.DataBind);
                        }
                    }
                }
            }
        }


        public void MergeFromMessage(IMessage message, FieldDescriptor field, bool full, ChangeDesc p)
        {
            if (full)
            {
                log.Debug("Create Map " + typeof(V).FullName + ":");
                IDictionary dic = (IDictionary)field.Accessor.GetValue(message);
                foreach (var key in dic.Keys)
                {
                    log.Debug("\tAdd key " + key);
                    if (typeof(IMessage).IsAssignableFrom(typeof(T)))
                    {
                        var v = Activator.CreateInstance<V>();
                        ((IDAO)v).MergeFromMessage(dic[key] as IMessage, true, null);
                        this._map.TryAdd((K)key, v);
                        this.InsertItem(this.Count, v);
                    }
                    else
                    {
                        this._map.TryAdd((K)key, (V)dic[key]);
                        this.InsertItem(this.Count, (V)dic[key]);
                    }
                }
            }
            else
            {
                log.Debug("Update Map " + typeof(V).Name);
                IDictionary dic = (IDictionary)field.Accessor.GetValue(message);
                if (typeof(K) == typeof(string))
                {
                    // 删除
                    foreach(var item in p.MapStringRemoved)
                    {
                        log.Debug("\tDelete key " + item.Key);
                        V oldV;
                        this._map.TryRemove((K)(object)item.Key, out oldV);
                        this.RemoveItem(this.IndexOf(oldV));
                    }

                    foreach (var item in p.MapString)
                    {
                        if (item.Value.FieldTags == null || item.Value.ToByteArray().Length == 0)
                        {
                            log.Debug("\tAdd key " + item.Key);
                            var v = Activator.CreateInstance<V>();
                            ((IDAO)v).MergeFromMessage(dic[item.Key] as IMessage, true, null);
                            this._map[(K)(object)item.Key] = v;
                            this.InsertItem(this.Count, v);
                        }
                        else
                        {
                            log.Debug("\tUpdate key " + item.Key);
                            V currentItem;
                            this.TryGetValue((K)(object)item.Key, out currentItem);
                            ((IDAO)currentItem).MergeFromMessage(dic[item.Key] as IMessage, false, item.Value);
                        }
                    }
                }
                else if (typeof(K) == typeof(Int32))
                {
                    // 删除
                    foreach (var item in p.MapInt32Removed)
                    {
                        log.Debug("\tDelete key " + item.Key);
                        V oldV;
                        this._map.TryRemove((K)(object)item.Key, out oldV);
                        this.RemoveItem(this.IndexOf(oldV));
                    }

                    foreach (var item in p.MapInt32)
                    {
                        if (item.Value.FieldTags == null || item.Value.ToByteArray().Length == 0)
                        {
                            log.Debug("\tAdd key " + item.Key);
                            var v = Activator.CreateInstance<V>();
                            ((IDAO)v).MergeFromMessage(dic[item.Key] as IMessage, true, null);
                            this._map[(K)(object)item.Key] = v;
                            this.InsertItem(this.Count, v);
                        }
                        else
                        {
                            log.Debug("\tUpdate key " + item.Key);
                            V currentItem;
                            this.TryGetValue((K)(object)item.Key, out currentItem);
                            ((IDAO)currentItem).MergeFromMessage(dic[item.Key] as IMessage, false, item.Value);
                        }
                    }
                }
                else if (typeof(K) == typeof(Int64))
                {
                    // 删除
                    foreach (var item in p.MapInt64Removed)
                    {
                        log.Debug("\tDelete key " + item.Key);
                        V oldV;
                        this._map.TryRemove((K)(object)item.Key, out oldV);
                        this.RemoveItem(this.IndexOf(oldV));
                    }

                    foreach (var item in p.MapInt64)
                    {
                        if (item.Value.FieldTags == null || item.Value.ToByteArray().Length == 0)
                        {
                            log.Debug("\tAdd key " + item.Key);
                            var v = Activator.CreateInstance<V>();
                            ((IDAO)v).MergeFromMessage(dic[item.Key] as IMessage, true, null);
                            this._map[(K)(object)item.Key] = v;
                            this.InsertItem(this.Count, v);
                        }
                        else
                        {
                            log.Debug("\tUpdate key " + item.Key);
                            V currentItem;
                            this.TryGetValue((K)(object)item.Key, out currentItem);
                            ((IDAO)currentItem).MergeFromMessage(dic[item.Key] as IMessage, false, item.Value);
                        }
                    }
                }
                else if (typeof(K) == typeof(bool))
                {
                    // 删除
                    foreach (var item in p.MapBoolRemoved)
                    {
                        log.Debug("\tDelete key " + item.Key);
                        V oldV;
                        this._map.TryRemove((K)(object)item.Key, out oldV);
                        this.RemoveItem(this.IndexOf(oldV));
                    }
                    foreach (var item in p.MapBool)
                    {
                        if (item.Value.FieldTags == null || item.Value.ToByteArray().Length == 0)
                        {
                            log.Debug("\tAdd key " + item.Key);
                            var v = Activator.CreateInstance<V>();
                            ((IDAO)v).MergeFromMessage(dic[item.Key] as IMessage, true, null);
                            this._map[(K)(object)item.Key] = v;
                            this.InsertItem(this.Count, v);
                        }
                        else
                        {
                            log.Debug("\tUpdate key " + item.Key);
                            V currentItem;
                            this.TryGetValue((K)(object)item.Key, out currentItem);
                            ((IDAO)currentItem).MergeFromMessage(dic[item.Key] as IMessage, false, item.Value);
                        }
                    }
                }
            }
        }

        public bool ContainsKey(K key)
        {
            return this._map.ContainsKey(key);
        }

        public void Add(K key, V value)
        {
            throw new NotSupportedException();
        }

        public bool Remove(K key)
        {
            throw new NotSupportedException();
        }

        public bool TryGetValue(K key, out V value)
        {
            return this._map.TryGetValue(key, out value);
        }

        public void Add(KeyValuePair<K, V> item)
        {
            throw new NotSupportedException();
        }

        public bool Contains(KeyValuePair<K, V> item)
        {
            return this._map.ContainsKey(item.Key);
        }

        public void CopyTo(KeyValuePair<K, V>[] array, int arrayIndex)
        {
            throw new NotSupportedException();
        }

        public bool Remove(KeyValuePair<K, V> item)
        {
            throw new NotSupportedException();
        }

        IEnumerator<KeyValuePair<K, V>> IEnumerable<KeyValuePair<K, V>>.GetEnumerator()
        {
            return _map.GetEnumerator();
        }
    }
}
