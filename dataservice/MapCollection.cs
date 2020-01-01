using System;
using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading;
using Google.Protobuf;
using Google.Protobuf.Reflection;
using Serilog;
using Serilog.Core;

namespace com.variflight.dataservice.client
{
    public class MapCollection<K, V, T> : ObservableCollection<V>, IDictionary<K, V>
    {
        Logger log = new LoggerConfiguration()
                .WriteTo.Console()
                .MinimumLevel.Debug()
                .CreateLogger();
        private ConcurrentDictionary<K, V> _map = new ConcurrentDictionary<K, V>();
        public MapCollection()
        {
        }

        public V this[K key]
        {
            get => _map[key];
            set => _map[key] = value;
        }

        public ICollection<K> Keys => _map.Keys;

        public ICollection<V> Values => _map.Values;

        public bool IsReadOnly => false;

        public void Add(K key, V value)
        {
            V v;
            if (this._map.TryGetValue(key, out v))
            {
                this._map.TryUpdate(key, value, v);
                this.Remove(v);
                this.Add(value);
            }
            else
            {
                this._map.TryAdd(key, value);
                this.Add(value);
            }
        }

        public void Add(KeyValuePair<K, V> item)
        {
            this.Add(item.Key, item.Value);
        }

        public bool Contains(KeyValuePair<K, V> item)
        {
            return _map.ContainsKey(item.Key);
        }

        public bool ContainsKey(K key)
        {
            return _map.ContainsKey(key);
        }

        public void CopyTo(KeyValuePair<K, V>[] array, int arrayIndex)
        {
            throw new NotImplementedException();
        }

        public bool Remove(K key)
        {
            V v;
            return _map.TryRemove(key, out v);
        }

        public bool Remove(KeyValuePair<K, V> item)
        {
            V v;
            return _map.TryRemove(item.Key, out v);
        }

        public bool TryGetValue(K key, out V value)
        {
            return _map.TryGetValue(key, out value);
        }

        public new void Clear()
        {
            this.ClearItems();
            this._map.Clear();
        }

        IEnumerator<KeyValuePair<K, V>> IEnumerable<KeyValuePair<K, V>>.GetEnumerator()
        {
            return _map.GetEnumerator();
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
                        ((DAO)v).MergeFromMessage(dic[key] as IMessage, true, null);
                        this.Add((K)key, v);
                    }
                    else
                    {
                        this.Add((K)key, (V)dic[key]);
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
                        this.Remove((K)(object)item.Key);
                    }

                    foreach (var item in p.MapString)
                    {
                        if (item.Value.FieldTags == null || item.Value.ToByteArray().Length == 0)
                        {
                            var x = item.Value.ToByteString();
                            log.Debug("\tAdd key " + item.Key);
                            var v = Activator.CreateInstance<V>();
                            ((DAO)v).MergeFromMessage(dic[item.Key] as IMessage, true, null);
                            this.Add((K)(object)item.Key, v);
                        }
                        else
                        {
                            log.Debug("\tUpdate key " + item.Key);
                            V currentItem;
                            this.TryGetValue((K)(object)item.Key, out currentItem);
                            ((DAO)currentItem).MergeFromMessage(dic[item.Key] as IMessage, false, item.Value);
                        }
                    }
                }
                else if (typeof(K) == typeof(Int32))
                {
                    // 删除
                    foreach (var item in p.MapInt32Removed)
                    {
                        log.Debug("\tDelete key " + item.Key);
                        this.Remove((K)(object)item.Key);
                    }

                    foreach (var item in p.MapInt32)
                    {
                        if (item.Value.FieldTags == null || item.Value.ToByteArray().Length == 0)
                        {
                            log.Debug("\tAdd key " + item.Key);
                            var v = Activator.CreateInstance<V>();
                            ((DAO)v).MergeFromMessage(dic[item.Key] as IMessage, true, null);
                            this.Add((K)(object)item.Key, v);
                        }
                        else
                        {
                            log.Debug("\tUpdate key " + item.Key);
                            V currentItem;
                            this.TryGetValue((K)(object)item.Key, out currentItem);
                            ((DAO)currentItem).MergeFromMessage(dic[item.Key] as IMessage, false, item.Value);
                        }
                    }
                }
                else if (typeof(K) == typeof(Int64))
                {
                    // 删除
                    foreach (var item in p.MapInt64Removed)
                    {
                        log.Debug("\tDelete key " + item.Key);
                        this.Remove((K)(object)item.Key);
                    }

                    foreach (var item in p.MapInt64)
                    {
                        if (item.Value.FieldTags == null || item.Value.ToByteArray().Length == 0)
                        {
                            log.Debug("\tAdd key " + item.Key);
                            var v = Activator.CreateInstance<V>();
                            ((DAO)v).MergeFromMessage(dic[item.Key] as IMessage, true, null);
                            this.Add((K)(object)item.Key, v);
                        }
                        else
                        {
                            log.Debug("\tUpdate key " + item.Key);
                            V currentItem;
                            this.TryGetValue((K)(object)item.Key, out currentItem);
                            ((DAO)currentItem).MergeFromMessage(dic[item.Key] as IMessage, false, item.Value);
                        }
                    }
                }
                else if (typeof(K) == typeof(bool))
                {
                    // 删除
                    foreach (var item in p.MapBoolRemoved)
                    {
                        log.Debug("\tDelete key " + item.Key);
                        this.Remove((K)(object)item.Key);
                    }
                    foreach (var item in p.MapBool)
                    {
                        if (item.Value.FieldTags == null || item.Value.ToByteArray().Length == 0)
                        {
                            log.Debug("\tAdd key " + item.Key);
                            var v = Activator.CreateInstance<V>();
                            ((DAO)v).MergeFromMessage(dic[item.Key] as IMessage, true, null);
                            this.Add((K)(object)item.Key, v);
                        }
                        else
                        {
                            log.Debug("\tUpdate key " + item.Key);
                            V currentItem;
                            this.TryGetValue((K)(object)item.Key, out currentItem);
                            ((DAO)currentItem).MergeFromMessage(dic[item.Key] as IMessage, false, item.Value);
                        }
                    }
                }
            }
        }
    }
}
