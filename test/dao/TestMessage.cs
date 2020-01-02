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
namespace Com.Variflight.Dataservice.Test.dao
{
    ///<summary>
    /// 学生
    ///
    ///</summary>
    public class student : IDAO
    {
        #region 消息字段
        ///<summary>
        /// 学生ID
        ///
        ///</summary>

        private Int32 _id;
        public Int32 id { get { return _id; } set { _id = value; invokePropertyChanged("id"); } }
        ///<summary>
        /// 姓名
        ///
        ///</summary>

        private string _name;
        public string name { get { return _name; } set { _name = value; invokePropertyChanged("name"); } }
        ///<summary>
        ///
        ///
        ///</summary>

        private Int32 _age;
        public Int32 age { get { return _age; } set { _age = value; invokePropertyChanged("age"); } }
        ///<summary>
        ///
        ///
        ///</summary>

        private MapCollection<string, string, string> _tags = new MapCollection<string, string, string>();
        public MapCollection<string, string, string> tags { get { return _tags; } set { _tags = value; invokePropertyChanged("tags"); } }
        ///<summary>
        ///
        ///
        ///</summary>

        private string _comment;
        public string comment { get { return _comment; } set { _comment = value; invokePropertyChanged("comment"); } }
        ///<summary>
        ///
        ///
        ///</summary>

        private Int32? _ivx;
        public Int32? ivx { get { return _ivx; } set { _ivx = value; invokePropertyChanged("ivx"); } }
        ///<summary>
        ///
        ///
        ///</summary>

        private MapCollection<string, Int64?, Int64> _tags2 = new MapCollection<string, Int64?, Int64>();
        public MapCollection<string, Int64?, Int64> tags2 { get { return _tags2; } set { _tags2 = value; invokePropertyChanged("tags2"); } }
        ///<summary>
        ///
        ///
        ///</summary>

        private Com.Variflight.Dataservice.Test.dao.student _s;
        public Com.Variflight.Dataservice.Test.dao.student s { get { return _s; } set { _s = value; invokePropertyChanged("s"); } }
        ///<summary>
        ///
        ///
        ///</summary>

        private MapCollection<Int32, Com.Variflight.Dataservice.Test.dao.student, Com.Variflight.Dataservice.Test.student> _ms = new MapCollection<Int32, Com.Variflight.Dataservice.Test.dao.student, Com.Variflight.Dataservice.Test.student>();
        public MapCollection<Int32, Com.Variflight.Dataservice.Test.dao.student, Com.Variflight.Dataservice.Test.student> ms { get { return _ms; } set { _ms = value; invokePropertyChanged("ms"); } }
        ///<summary>
        ///
        ///
        ///</summary>

        private ListCollection<Com.Variflight.Dataservice.Test.dao.student, Com.Variflight.Dataservice.Test.student> _rs = new ListCollection<Com.Variflight.Dataservice.Test.dao.student, Com.Variflight.Dataservice.Test.student>();
        public ListCollection<Com.Variflight.Dataservice.Test.dao.student, Com.Variflight.Dataservice.Test.student> rs { get { return _rs; } set { _rs = value; invokePropertyChanged("rs"); } }
        ///<summary>
        ///
        ///
        ///</summary>

        private ListCollection<Int64, Int64> _ri = new ListCollection<Int64, Int64>();
        public ListCollection<Int64, Int64> ri { get { return _ri; } set { _ri = value; invokePropertyChanged("ri"); } }
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
            for (var idx = 0; idx < Com.Variflight.Dataservice.Test.student.Descriptor.Fields.InFieldNumberOrder().Count; idx++)
            {
                var field = Com.Variflight.Dataservice.Test.student.Descriptor.Fields.InFieldNumberOrder()[idx];

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
                        this.id = default(Int32);
                    }
                    if (field.FieldNumber == 2)
                    {
                        this.name = default(string);
                    }
                    if (field.FieldNumber == 3)
                    {
                        this.age = default(Int32);
                    }
                    if (field.FieldNumber == 4)
                    {
                        this.tags.Clear();
                    }
                    if (field.FieldNumber == 5)
                    {
                        this.comment = default(string);
                    }
                    if (field.FieldNumber == 6)
                    {
                        this.ivx = default(Int32?);
                    }
                    if (field.FieldNumber == 7)
                    {
                        this.tags2.Clear();
                    }
                    if (field.FieldNumber == 100)
                    {
                        this.s = null;
                    }
                    if (field.FieldNumber == 1001)
                    {
                        this.ms.Clear();
                    }
                    if (field.FieldNumber == 10009)
                    {
                        this.rs.Clear();
                    }
                    if (field.FieldNumber == 10)
                    {
                        this.ri.Clear();
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
                        this.id = (Int32)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 2)
                    {
                        this.name = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 3)
                    {
                        this.age = (Int32)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 4)
                    {
                        this.tags.Clear();
                        this.tags.MergeFromMessage(message, field, true, null);
                    }
                    if (field.FieldNumber == 5)
                    {
                        this.comment = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 6)
                    {
                        this.ivx = (Int32?)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 7)
                    {
                        this.tags2.Clear();
                        this.tags2.MergeFromMessage(message, field, true, null);
                    }
                    if (field.FieldNumber == 100)
                    {
                        var temp = new Com.Variflight.Dataservice.Test.dao.student();
                        temp.MergeFromMessage(field.Accessor.GetValue(message) as Com.Variflight.Dataservice.Test.student, true, null);
                        this.s = temp;
                    }
                    if (field.FieldNumber == 1001)
                    {
                        this.ms.Clear();
                        this.ms.MergeFromMessage(message, field, true, null);
                    }
                    if (field.FieldNumber == 10009)
                    {
                        this.rs.Clear();
                        this.rs.MergeFromMessage(message, field, true, null);
                    }
                    if (field.FieldNumber == 10)
                    {
                        this.ri.Clear();
                        this.ri.MergeFromMessage(message, field, true, null);
                    }
                    continue;
                }
                if (isUpdate)
                {
                    ChangeDesc change = null;
                    if (cm != null && cm.ChangeTags != null)
                    {
                        if ((cm.ChangeTags.ToByteArray()[(int)Math.Floor(idx / 8.0)] >> (7 - (idx % 8)) & 0b00000001) == 0b1)
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
                        this.id = (Int32)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 2)
                    {
                        this.name = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 3)
                    {
                        this.age = (Int32)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 4)
                    {
                        this.tags.MergeFromMessage(message, field, full, change);
                    }
                    if (field.FieldNumber == 5)
                    {
                        this.comment = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 6)
                    {
                        this.ivx = (Int32?)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 7)
                    {
                        this.tags2.MergeFromMessage(message, field, full, change);
                    }
                    if (field.FieldNumber == 100)
                    {
                        var temp = this.s;
                        if (temp == null)
                        {
                            temp = new Com.Variflight.Dataservice.Test.dao.student();
                        }
                        if (message == null || (field.Accessor.GetValue(message) != null && !(field.Accessor.GetValue(message) is Com.Variflight.Dataservice.Test.student)))
                        {
                            temp.MergeFromMessage(null, full, change);
                        }
                        else
                        {
                            temp.MergeFromMessage(field.Accessor.GetValue(message) as Com.Variflight.Dataservice.Test.student, full, change);
                        }
                        if (this.s != temp)
                        {
                            this.s = temp;
                        }
                    }
                    if (field.FieldNumber == 1001)
                    {
                        this.ms.MergeFromMessage(message, field, full, change);
                    }
                    if (field.FieldNumber == 10009)
                    {
                        this.rs.Clear();
                        this.rs.MergeFromMessage(message, field, true, null);
                    }
                    if (field.FieldNumber == 10)
                    {
                        this.ri.Clear();
                        this.ri.MergeFromMessage(message, field, true, null);
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
    public class exam : IDAO
    {
        #region 消息字段
        ///<summary>
        ///
        ///
        ///</summary>

        private Int32 _id;
        public Int32 id { get { return _id; } set { _id = value; invokePropertyChanged("id"); } }
        ///<summary>
        ///
        ///
        ///</summary>

        private string _cls;
        public string cls { get { return _cls; } set { _cls = value; invokePropertyChanged("cls"); } }
        ///<summary>
        ///
        ///
        ///</summary>

        private Int32 _studentid;
        public Int32 studentid { get { return _studentid; } set { _studentid = value; invokePropertyChanged("studentid"); } }
        ///<summary>
        ///
        ///
        ///</summary>

        private Int32 _score;
        public Int32 score { get { return _score; } set { _score = value; invokePropertyChanged("score"); } }
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
            for (var idx = 0; idx < Com.Variflight.Dataservice.Test.exam.Descriptor.Fields.InFieldNumberOrder().Count; idx++)
            {
                var field = Com.Variflight.Dataservice.Test.exam.Descriptor.Fields.InFieldNumberOrder()[idx];

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
                        this.id = default(Int32);
                    }
                    if (field.FieldNumber == 2)
                    {
                        this.cls = default(string);
                    }
                    if (field.FieldNumber == 3)
                    {
                        this.studentid = default(Int32);
                    }
                    if (field.FieldNumber == 4)
                    {
                        this.score = default(Int32);
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
                        this.id = (Int32)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 2)
                    {
                        this.cls = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 3)
                    {
                        this.studentid = (Int32)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 4)
                    {
                        this.score = (Int32)field.Accessor.GetValue(message);
                    }
                    continue;
                }
                if (isUpdate)
                {
                    ChangeDesc change = null;
                    if (cm != null && cm.ChangeTags != null)
                    {
                        if ((cm.ChangeTags.ToByteArray()[(int)Math.Floor(idx / 8.0)] >> (7 - (idx % 8)) & 0b00000001) == 0b1)
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
                        this.id = (Int32)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 2)
                    {
                        this.cls = (string)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 3)
                    {
                        this.studentid = (Int32)field.Accessor.GetValue(message);
                    }
                    if (field.FieldNumber == 4)
                    {
                        this.score = (Int32)field.Accessor.GetValue(message);
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
    public class StudentScore : IDAO
    {
        #region 消息字段
        ///<summary>
        ///
        ///
        ///</summary>

        private Com.Variflight.Dataservice.Test.dao.student _s;
        public Com.Variflight.Dataservice.Test.dao.student s { get { return _s; } set { _s = value; invokePropertyChanged("s"); } }
        ///<summary>
        ///
        ///
        ///</summary>

        private MapCollection<string, Com.Variflight.Dataservice.Test.dao.exam, Com.Variflight.Dataservice.Test.exam> _exams = new MapCollection<string, Com.Variflight.Dataservice.Test.dao.exam, Com.Variflight.Dataservice.Test.exam>();
        public MapCollection<string, Com.Variflight.Dataservice.Test.dao.exam, Com.Variflight.Dataservice.Test.exam> exams { get { return _exams; } set { _exams = value; invokePropertyChanged("exams"); } }
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
            for (var idx = 0; idx < Com.Variflight.Dataservice.Test.StudentScore.Descriptor.Fields.InFieldNumberOrder().Count; idx++)
            {
                var field = Com.Variflight.Dataservice.Test.StudentScore.Descriptor.Fields.InFieldNumberOrder()[idx];

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
                        this.s = null;
                    }
                    if (field.FieldNumber == 2)
                    {
                        this.exams.Clear();
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
                        var temp = new Com.Variflight.Dataservice.Test.dao.student();
                        temp.MergeFromMessage(field.Accessor.GetValue(message) as Com.Variflight.Dataservice.Test.student, true, null);
                        this.s = temp;
                    }
                    if (field.FieldNumber == 2)
                    {
                        this.exams.Clear();
                        this.exams.MergeFromMessage(message, field, true, null);
                    }
                    continue;
                }
                if (isUpdate)
                {
                    ChangeDesc change = null;
                    if (cm != null && cm.ChangeTags != null)
                    {
                        if ((cm.ChangeTags.ToByteArray()[(int)Math.Floor(idx / 8.0)] >> (7 - (idx % 8)) & 0b00000001) == 0b1)
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
                        var temp = this.s;
                        if (temp == null)
                        {
                            temp = new Com.Variflight.Dataservice.Test.dao.student();
                        }
                        if (message == null || (field.Accessor.GetValue(message) != null && !(field.Accessor.GetValue(message) is Com.Variflight.Dataservice.Test.student)))
                        {
                            temp.MergeFromMessage(null, full, change);
                        }
                        else
                        {
                            temp.MergeFromMessage(field.Accessor.GetValue(message) as Com.Variflight.Dataservice.Test.student, full, change);
                        }
                        if (this.s != temp)
                        {
                            this.s = temp;
                        }
                    }
                    if (field.FieldNumber == 2)
                    {
                        this.exams.MergeFromMessage(message, field, full, change);
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
    public class StudentScoresMap : IDAO
    {
        #region 消息字段
        ///<summary>
        ///
        ///
        ///</summary>

        private MapCollection<Int32, Com.Variflight.Dataservice.Test.dao.StudentScore, Com.Variflight.Dataservice.Test.StudentScore> _results = new MapCollection<Int32, Com.Variflight.Dataservice.Test.dao.StudentScore, Com.Variflight.Dataservice.Test.StudentScore>();
        public MapCollection<Int32, Com.Variflight.Dataservice.Test.dao.StudentScore, Com.Variflight.Dataservice.Test.StudentScore> results { get { return _results; } set { _results = value; invokePropertyChanged("results"); } }
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
            for (var idx = 0; idx < Com.Variflight.Dataservice.Test.StudentScoresMap.Descriptor.Fields.InFieldNumberOrder().Count; idx++)
            {
                var field = Com.Variflight.Dataservice.Test.StudentScoresMap.Descriptor.Fields.InFieldNumberOrder()[idx];

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
                        this.results.Clear();
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
                        this.results.Clear();
                        this.results.MergeFromMessage(message, field, true, null);
                    }
                    continue;
                }
                if (isUpdate)
                {
                    ChangeDesc change = null;
                    if (cm != null && cm.ChangeTags != null)
                    {
                        if ((cm.ChangeTags.ToByteArray()[(int)Math.Floor(idx / 8.0)] >> (7 - (idx % 8)) & 0b00000001) == 0b1)
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
                        this.results.MergeFromMessage(message, field, full, change);
                    }
                    continue;
                }
            }
        }
        #endregion
    }
}