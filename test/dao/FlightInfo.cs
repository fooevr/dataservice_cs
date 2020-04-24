using System;
using System.ComponentModel;
using System.Collections.ObjectModel;
using com.variflight.dataservice.client;
using com.variflight.dataservice;
using Google.Protobuf.WellKnownTypes;
using Google.Protobuf;

/*
 *
 *
 */
namespace Com.Variflight.Fidstest.Flight.dao
{
    ///<summary>
    ///
    ///
    ///</summary>
    public class FlightInfo : IDAO
    {
        #region 消息字段
        ///<summary>
        ///
        ///
        ///</summary>


        private string _fid;
        public string fid { get { return _fid; } set { _fid = value; invokePropertyChanged("fid"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private bool _isArrive;
        public bool isArrive { get { return _isArrive; } set { _isArrive = value; invokePropertyChanged("isArrive"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private string _f_no;
        public string f_no { get { return _f_no; } set { _f_no = value; invokePropertyChanged("f_no"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private Int64 _f_date;
        public Int64 f_date { get { return _f_date; } set { _f_date = value; invokePropertyChanged("f_date"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private string _a_no;
        public string a_no { get { return _a_no; } set { _a_no = value; invokePropertyChanged("a_no"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private string _dep;
        public string dep { get { return _dep; } set { _dep = value; invokePropertyChanged("dep"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private string _arr;
        public string arr { get { return _arr; } set { _arr = value; invokePropertyChanged("arr"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private Int64 _std;
        public Int64 std { get { return _std; } set { _std = value; invokePropertyChanged("std"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private Int64 _sta;
        public Int64 sta { get { return _sta; } set { _sta = value; invokePropertyChanged("sta"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private Int64? _etd;
        public Int64? etd { get { return _etd; } set { _etd = value; invokePropertyChanged("etd"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private Int64? _eta;
        public Int64? eta { get { return _eta; } set { _eta = value; invokePropertyChanged("eta"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private Int64? _atd;
        public Int64? atd { get { return _atd; } set { _atd = value; invokePropertyChanged("atd"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private Int64? _ata;
        public Int64? ata { get { return _ata; } set { _ata = value; invokePropertyChanged("ata"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private string _f_mode;
        public string f_mode { get { return _f_mode; } set { _f_mode = value; invokePropertyChanged("f_mode"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private string _al_iata;
        public string al_iata { get { return _al_iata; } set { _al_iata = value; invokePropertyChanged("al_iata"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private string _al_icao;
        public string al_icao { get { return _al_icao; } set { _al_icao = value; invokePropertyChanged("al_icao"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private string _cla;
        public string cla { get { return _cla; } set { _cla = value; invokePropertyChanged("cla"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private string _f_status;
        public string f_status { get { return _f_status; } set { _f_status = value; invokePropertyChanged("f_status"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private string _delay_code;
        public string delay_code { get { return _delay_code; } set { _delay_code = value; invokePropertyChanged("delay_code"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private string _delay_cn;
        public string delay_cn { get { return _delay_cn; } set { _delay_cn = value; invokePropertyChanged("delay_cn"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private string _sflight;
        public string sflight { get { return _sflight; } set { _sflight = value; invokePropertyChanged("sflight"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private string _stand;
        public string stand { get { return _stand; } set { _stand = value; invokePropertyChanged("stand"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private string _gate;
        public string gate { get { return _gate; } set { _gate = value; invokePropertyChanged("gate"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private string _car;
        public string car { get { return _car; } set { _car = value; invokePropertyChanged("car"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private string _mp1;
        public string mp1 { get { return _mp1; } set { _mp1 = value; invokePropertyChanged("mp1"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private string _cid;
        public string cid { get { return _cid; } set { _cid = value; invokePropertyChanged("cid"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private string _cld;
        public string cld { get { return _cld; } set { _cld = value; invokePropertyChanged("cld"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private string _cea;
        public string cea { get { return _cea; } set { _cea = value; invokePropertyChanged("cea"); }}
        ///<summary>
        ///
        ///
        ///</summary>


        private string _vl;
        public string vl { get { return _vl; } set { _vl = value; invokePropertyChanged("vl"); }}
        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void invokePropertyChanged(String proName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(proName));
        }
        #endregion

        #region Proto Parse
        public void MergeFromMessage(IMessage message, bool full, ChangeDesc cm)
        {
            for (var idx = 0; idx < Com.Variflight.Fidstest.Flight.FlightInfo.Descriptor.Fields.InFieldNumberOrder().Count; idx++)
            {
                var field = Com.Variflight.Fidstest.Flight.FlightInfo.Descriptor.Fields.InFieldNumberOrder()[idx];

                var isCreate = cm != null && (cm.FieldTags.ToByteArray()[(int)Math.Floor(idx / 4.0)] << ((idx % 4) * 2) & 0b11000000) == (int)ChangeType.Created;
                var isDelete = cm != null && (cm.FieldTags.ToByteArray()[(int)Math.Floor(idx / 4.0)] << ((idx % 4) * 2) & 0b11000000) == (int)ChangeType.Deleted;
                var isUpdate = cm != null && (cm.FieldTags.ToByteArray()[(int)Math.Floor(idx / 4.0)] << ((idx % 4) * 2) & 0b11000000) == (int)ChangeType.Updated;

                if (full)
                {
                    isCreate = true;
                    isDelete = false;
                    isUpdate = false;
                }
                var isUnchanged = !isCreate && !isDelete && !isUpdate;
                if (isUnchanged)
                {
                    continue;
                }
                if (isDelete)
                {
                    if (field.FieldNumber == 1)
                    {
                        this.fid = default(string);
                    }
                    if (field.FieldNumber == 2)
                    {
                        this.isArrive = default(bool);
                    }
                    if (field.FieldNumber == 3)
                    {
                        this.f_no = default(string);
                    }
                    if (field.FieldNumber == 4)
                    {
                        this.f_date = default(Int64);
                    }
                    if (field.FieldNumber == 5)
                    {
                        this.a_no = default(string);
                    }
                    if (field.FieldNumber == 6)
                    {
                        this.dep = default(string);
                    }
                    if (field.FieldNumber == 7)
                    {
                        this.arr = default(string);
                    }
                    if (field.FieldNumber == 8)
                    {
                        this.std = default(Int64);
                    }
                    if (field.FieldNumber == 9)
                    {
                        this.sta = default(Int64);
                    }
                    if (field.FieldNumber == 10)
                    {
                        this.etd = default(Int64?);
                    }
                    if (field.FieldNumber == 11)
                    {
                        this.eta = default(Int64?);
                    }
                    if (field.FieldNumber == 12)
                    {
                        this.atd = default(Int64?);
                    }
                    if (field.FieldNumber == 13)
                    {
                        this.ata = default(Int64?);
                    }
                    if (field.FieldNumber == 14)
                    {
                        this.f_mode = default(string);
                    }
                    if (field.FieldNumber == 15)
                    {
                        this.al_iata = default(string);
                    }
                    if (field.FieldNumber == 16)
                    {
                        this.al_icao = default(string);
                    }
                    if (field.FieldNumber == 17)
                    {
                        this.cla = default(string);
                    }
                    if (field.FieldNumber == 18)
                    {
                        this.f_status = default(string);
                    }
                    if (field.FieldNumber == 19)
                    {
                        this.delay_code = default(string);
                    }
                    if (field.FieldNumber == 20)
                    {
                        this.delay_cn = default(string);
                    }
                    if (field.FieldNumber == 21)
                    {
                        this.sflight = default(string);
                    }
                    if (field.FieldNumber == 22)
                    {
                        this.stand = default(string);
                    }
                    if (field.FieldNumber == 23)
                    {
                        this.gate = default(string);
                    }
                    if (field.FieldNumber == 24)
                    {
                        this.car = default(string);
                    }
                    if (field.FieldNumber == 25)
                    {
                        this.mp1 = default(string);
                    }
                    if (field.FieldNumber == 26)
                    {
                        this.cid = default(string);
                    }
                    if (field.FieldNumber == 27)
                    {
                        this.cld = default(string);
                    }
                    if (field.FieldNumber == 28)
                    {
                        this.cea = default(string);
                    }
                    if (field.FieldNumber == 29)
                    {
                        this.vl = default(string);
                    }
                    continue;
                }
                if (isCreate)
                {
                    if (field.Accessor.GetValue(message) == null)
                    {
                        continue;
                    }
                    if (field.FieldNumber == 1)
                    {
                        this.fid = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 2)
                    {
                        this.isArrive = (bool)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 3)
                    {
                        this.f_no = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 4)
                    {
                        this.f_date = (Int64)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 5)
                    {
                        this.a_no = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 6)
                    {
                        this.dep = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 7)
                    {
                        this.arr = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 8)
                    {
                        this.std = (Int64)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 9)
                    {
                        this.sta = (Int64)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 10)
                    {
                        this.etd = (Int64?)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 11)
                    {
                        this.eta = (Int64?)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 12)
                    {
                        this.atd = (Int64?)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 13)
                    {
                        this.ata = (Int64?)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 14)
                    {
                        this.f_mode = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 15)
                    {
                        this.al_iata = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 16)
                    {
                        this.al_icao = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 17)
                    {
                        this.cla = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 18)
                    {
                        this.f_status = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 19)
                    {
                        this.delay_code = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 20)
                    {
                        this.delay_cn = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 21)
                    {
                        this.sflight = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 22)
                    {
                        this.stand = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 23)
                    {
                        this.gate = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 24)
                    {
                        this.car = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 25)
                    {
                        this.mp1 = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 26)
                    {
                        this.cid = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 27)
                    {
                        this.cld = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 28)
                    {
                        this.cea = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 29)
                    {
                        this.vl = (string)field.Accessor.GetValue(message);
                    }
                    continue;
                }
                if (isUpdate)
                {
                    ChangeDesc change = null;
                    if (cm != null && cm.ChangeTags != null)
                    {
                        if ((cm.ChangeTags.ToByteArray()[(int)Math.Floor(idx/8.0)] >> (7 - (idx % 8)) & 0b00000001) == 0b1)
                        {
                            var fieldIndex = 0;
                            for (var i = 0; i < idx; i++)
                            {
                                if ((cm.ChangeTags.ToByteArray()[(int)Math.Floor(i / 8.0)] >> (7 - (i % 8)) & 0b00000001) == 0b1)
                                {
                                    fieldIndex++;
                                }
                            }
                            change = cm.FieldsChangeDescs[fieldIndex];
                        }
                    }
                    if (field.FieldNumber == 1)
                    {
                        this.fid = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 2)
                    {
                        this.isArrive = (bool)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 3)
                    {
                        this.f_no = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 4)
                    {
                        this.f_date = (Int64)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 5)
                    {
                        this.a_no = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 6)
                    {
                        this.dep = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 7)
                    {
                        this.arr = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 8)
                    {
                        this.std = (Int64)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 9)
                    {
                        this.sta = (Int64)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 10)
                    {
                        this.etd = (Int64?)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 11)
                    {
                        this.eta = (Int64?)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 12)
                    {
                        this.atd = (Int64?)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 13)
                    {
                        this.ata = (Int64?)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 14)
                    {
                        this.f_mode = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 15)
                    {
                        this.al_iata = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 16)
                    {
                        this.al_icao = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 17)
                    {
                        this.cla = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 18)
                    {
                        this.f_status = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 19)
                    {
                        this.delay_code = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 20)
                    {
                        this.delay_cn = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 21)
                    {
                        this.sflight = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 22)
                    {
                        this.stand = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 23)
                    {
                        this.gate = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 24)
                    {
                        this.car = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 25)
                    {
                        this.mp1 = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 26)
                    {
                        this.cid = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 27)
                    {
                        this.cld = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 28)
                    {
                        this.cea = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 29)
                    {
                        this.vl = (string)field.Accessor.GetValue(message);
                    }
                    continue;
                }
            }
        }
        #endregion
    }
    ///<summary>
    ///
    ///
    ///</summary>
    public class Nothing : IDAO
    {
        #region 消息字段
        ///<summary>
        ///
        ///
        ///</summary>


        private string _test;
        public string test { get { return _test; } set { _test = value; invokePropertyChanged("test"); }}
        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void invokePropertyChanged(String proName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(proName));
        }
        #endregion

        #region Proto Parse
        public void MergeFromMessage(IMessage message, bool full, ChangeDesc cm)
        {
            for (var idx = 0; idx < Com.Variflight.Fidstest.Flight.Nothing.Descriptor.Fields.InFieldNumberOrder().Count; idx++)
            {
                var field = Com.Variflight.Fidstest.Flight.Nothing.Descriptor.Fields.InFieldNumberOrder()[idx];

                var isCreate = cm != null && (cm.FieldTags.ToByteArray()[(int)Math.Floor(idx / 4.0)] << ((idx % 4) * 2) & 0b11000000) == (int)ChangeType.Created;
                var isDelete = cm != null && (cm.FieldTags.ToByteArray()[(int)Math.Floor(idx / 4.0)] << ((idx % 4) * 2) & 0b11000000) == (int)ChangeType.Deleted;
                var isUpdate = cm != null && (cm.FieldTags.ToByteArray()[(int)Math.Floor(idx / 4.0)] << ((idx % 4) * 2) & 0b11000000) == (int)ChangeType.Updated;

                if (full)
                {
                    isCreate = true;
                    isDelete = false;
                    isUpdate = false;
                }
                var isUnchanged = !isCreate && !isDelete && !isUpdate;
                if (isUnchanged)
                {
                    continue;
                }
                if (isDelete)
                {
                    if (field.FieldNumber == 1)
                    {
                        this.test = default(string);
                    }
                    continue;
                }
                if (isCreate)
                {
                    if (field.Accessor.GetValue(message) == null)
                    {
                        continue;
                    }
                    if (field.FieldNumber == 1)
                    {
                        this.test = (string)field.Accessor.GetValue(message);
                    }
                    continue;
                }
                if (isUpdate)
                {
                    ChangeDesc change = null;
                    if (cm != null && cm.ChangeTags != null)
                    {
                        if ((cm.ChangeTags.ToByteArray()[(int)Math.Floor(idx/8.0)] >> (7 - (idx % 8)) & 0b00000001) == 0b1)
                        {
                            var fieldIndex = 0;
                            for (var i = 0; i < idx; i++)
                            {
                                if ((cm.ChangeTags.ToByteArray()[(int)Math.Floor(i / 8.0)] >> (7 - (i % 8)) & 0b00000001) == 0b1)
                                {
                                    fieldIndex++;
                                }
                            }
                            change = cm.FieldsChangeDescs[fieldIndex];
                        }
                    }
                    if (field.FieldNumber == 1)
                    {
                        this.test = (string)field.Accessor.GetValue(message);
                    }
                    continue;
                }
            }
        }
        #endregion
    }
    ///<summary>
    ///
    ///
    ///</summary>
    public class FlightList : IDAO
    {
        #region 消息字段
        ///<summary>
        ///
        ///
        ///</summary>


        private MapCollection<string, Com.Variflight.Fidstest.Flight.dao.FlightInfo, Com.Variflight.Fidstest.Flight.FlightInfo> _value = new MapCollection<string, Com.Variflight.Fidstest.Flight.dao.FlightInfo, Com.Variflight.Fidstest.Flight.FlightInfo>();
        public MapCollection<string, Com.Variflight.Fidstest.Flight.dao.FlightInfo, Com.Variflight.Fidstest.Flight.FlightInfo> value { get { return _value; } set { _value = value; invokePropertyChanged("value"); }}
        #endregion

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        private void invokePropertyChanged(String proName)
        {
            this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(proName));
        }
        #endregion

        #region Proto Parse
        public void MergeFromMessage(IMessage message, bool full, ChangeDesc cm)
        {
            for (var idx = 0; idx < Com.Variflight.Fidstest.Flight.FlightList.Descriptor.Fields.InFieldNumberOrder().Count; idx++)
            {
                var field = Com.Variflight.Fidstest.Flight.FlightList.Descriptor.Fields.InFieldNumberOrder()[idx];

                var isCreate = cm != null && (cm.FieldTags.ToByteArray()[(int)Math.Floor(idx / 4.0)] << ((idx % 4) * 2) & 0b11000000) == (int)ChangeType.Created;
                var isDelete = cm != null && (cm.FieldTags.ToByteArray()[(int)Math.Floor(idx / 4.0)] << ((idx % 4) * 2) & 0b11000000) == (int)ChangeType.Deleted;
                var isUpdate = cm != null && (cm.FieldTags.ToByteArray()[(int)Math.Floor(idx / 4.0)] << ((idx % 4) * 2) & 0b11000000) == (int)ChangeType.Updated;

                if (full)
                {
                    isCreate = true;
                    isDelete = false;
                    isUpdate = false;
                }
                var isUnchanged = !isCreate && !isDelete && !isUpdate;
                if (isUnchanged)
                {
                    continue;
                }
                if (isDelete)
                {
                    if (field.FieldNumber == 1)
                    {
                        this.value.Clear();
                    }
                    continue;
                }
                if (isCreate)
                {
                    if (field.Accessor.GetValue(message) == null)
                    {
                        continue;
                    }
                    if (field.FieldNumber == 1)
                    {
                        this.value.Clear();
                        this.value.MergeFromMessage(message, field, true, null);
                    }
                    continue;
                }
                if (isUpdate)
                {
                    ChangeDesc change = null;
                    if (cm != null && cm.ChangeTags != null)
                    {
                        if ((cm.ChangeTags.ToByteArray()[(int)Math.Floor(idx/8.0)] >> (7 - (idx % 8)) & 0b00000001) == 0b1)
                        {
                            var fieldIndex = 0;
                            for (var i = 0; i < idx; i++)
                            {
                                if ((cm.ChangeTags.ToByteArray()[(int)Math.Floor(i / 8.0)] >> (7 - (i % 8)) & 0b00000001) == 0b1)
                                {
                                    fieldIndex++;
                                }
                            }
                            change = cm.FieldsChangeDescs[fieldIndex];
                        }
                    }
                    if (field.FieldNumber == 1)
                    {
                        this.value.MergeFromMessage(message, field, full, change);
                    }
                    continue;
                }
            }
        }
        #endregion
    }
}