// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: ChangeDesc.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace com.variflight.dataservice
{

    /// <summary>Holder for reflection information generated from ChangeDesc.proto</summary>
    public static partial class ChangeDescReflection
    {

        #region Descriptor
        /// <summary>File descriptor for ChangeDesc.proto</summary>
        public static pbr::FileDescriptor Descriptor
        {
            get { return descriptor; }
        }
        private static pbr::FileDescriptor descriptor;

        static ChangeDescReflection()
        {
            byte[] descriptorData = global::System.Convert.FromBase64String(
                string.Concat(
                  "ChBDaGFuZ2VEZXNjLnByb3RvEhpjb20udmFyaWZsaWdodC5kYXRhc2Vydmlj",
                  "ZSLeCwoKQ2hhbmdlRGVzYxIRCglmaWVsZFRhZ3MYASABKAwSEgoKY2hhbmdl",
                  "VGFncxgCIAEoDBJBChFmaWVsZHNDaGFuZ2VEZXNjcxgDIAMoCzImLmNvbS52",
                  "YXJpZmxpZ2h0LmRhdGFzZXJ2aWNlLkNoYW5nZURlc2MSRwoJbWFwX2ludDMy",
                  "GAQgAygLMjQuY29tLnZhcmlmbGlnaHQuZGF0YXNlcnZpY2UuQ2hhbmdlRGVz",
                  "Yy5NYXBJbnQzMkVudHJ5EkcKCW1hcF9pbnQ2NBgFIAMoCzI0LmNvbS52YXJp",
                  "ZmxpZ2h0LmRhdGFzZXJ2aWNlLkNoYW5nZURlc2MuTWFwSW50NjRFbnRyeRJF",
                  "CghtYXBfYm9vbBgGIAMoCzIzLmNvbS52YXJpZmxpZ2h0LmRhdGFzZXJ2aWNl",
                  "LkNoYW5nZURlc2MuTWFwQm9vbEVudHJ5EkkKCm1hcF9zdHJpbmcYByADKAsy",
                  "NS5jb20udmFyaWZsaWdodC5kYXRhc2VydmljZS5DaGFuZ2VEZXNjLk1hcFN0",
                  "cmluZ0VudHJ5ElYKEW1hcF9pbnQzMl9yZW1vdmVkGAggAygLMjsuY29tLnZh",
                  "cmlmbGlnaHQuZGF0YXNlcnZpY2UuQ2hhbmdlRGVzYy5NYXBJbnQzMlJlbW92",
                  "ZWRFbnRyeRJWChFtYXBfaW50NjRfcmVtb3ZlZBgJIAMoCzI7LmNvbS52YXJp",
                  "ZmxpZ2h0LmRhdGFzZXJ2aWNlLkNoYW5nZURlc2MuTWFwSW50NjRSZW1vdmVk",
                  "RW50cnkSVAoQbWFwX2Jvb2xfcmVtb3ZlZBgKIAMoCzI6LmNvbS52YXJpZmxp",
                  "Z2h0LmRhdGFzZXJ2aWNlLkNoYW5nZURlc2MuTWFwQm9vbFJlbW92ZWRFbnRy",
                  "eRJYChJtYXBfc3RyaW5nX3JlbW92ZWQYCyADKAsyPC5jb20udmFyaWZsaWdo",
                  "dC5kYXRhc2VydmljZS5DaGFuZ2VEZXNjLk1hcFN0cmluZ1JlbW92ZWRFbnRy",
                  "eRpXCg1NYXBJbnQzMkVudHJ5EgsKA2tleRgBIAEoBRI1CgV2YWx1ZRgCIAEo",
                  "CzImLmNvbS52YXJpZmxpZ2h0LmRhdGFzZXJ2aWNlLkNoYW5nZURlc2M6AjgB",
                  "GlcKDU1hcEludDY0RW50cnkSCwoDa2V5GAEgASgDEjUKBXZhbHVlGAIgASgL",
                  "MiYuY29tLnZhcmlmbGlnaHQuZGF0YXNlcnZpY2UuQ2hhbmdlRGVzYzoCOAEa",
                  "VgoMTWFwQm9vbEVudHJ5EgsKA2tleRgBIAEoCBI1CgV2YWx1ZRgCIAEoCzIm",
                  "LmNvbS52YXJpZmxpZ2h0LmRhdGFzZXJ2aWNlLkNoYW5nZURlc2M6AjgBGlgK",
                  "Dk1hcFN0cmluZ0VudHJ5EgsKA2tleRgBIAEoCRI1CgV2YWx1ZRgCIAEoCzIm",
                  "LmNvbS52YXJpZmxpZ2h0LmRhdGFzZXJ2aWNlLkNoYW5nZURlc2M6AjgBGl4K",
                  "FE1hcEludDMyUmVtb3ZlZEVudHJ5EgsKA2tleRgBIAEoBRI1CgV2YWx1ZRgC",
                  "IAEoCzImLmNvbS52YXJpZmxpZ2h0LmRhdGFzZXJ2aWNlLkNoYW5nZURlc2M6",
                  "AjgBGl4KFE1hcEludDY0UmVtb3ZlZEVudHJ5EgsKA2tleRgBIAEoAxI1CgV2",
                  "YWx1ZRgCIAEoCzImLmNvbS52YXJpZmxpZ2h0LmRhdGFzZXJ2aWNlLkNoYW5n",
                  "ZURlc2M6AjgBGl0KE01hcEJvb2xSZW1vdmVkRW50cnkSCwoDa2V5GAEgASgI",
                  "EjUKBXZhbHVlGAIgASgLMiYuY29tLnZhcmlmbGlnaHQuZGF0YXNlcnZpY2Uu",
                  "Q2hhbmdlRGVzYzoCOAEaXwoVTWFwU3RyaW5nUmVtb3ZlZEVudHJ5EgsKA2tl",
                  "eRgBIAEoCRI1CgV2YWx1ZRgCIAEoCzImLmNvbS52YXJpZmxpZ2h0LmRhdGFz",
                  "ZXJ2aWNlLkNoYW5nZURlc2M6AjgBQl8KGmNvbS52YXJpZmxpZ2h0LmRhdGFz",
                  "ZXJ2aWNlUABaGnZhcmlmbGlnaHQuY29tL2RhdGFzZXJ2aWNl+AEBogICRFOq",
                  "Ahpjb20udmFyaWZsaWdodC5kYXRhc2VydmljZWIGcHJvdG8z"));
            descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
                new pbr::FileDescriptor[] { },
                new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::com.variflight.dataservice.ChangeDesc), global::com.variflight.dataservice.ChangeDesc.Parser, new[]{ "FieldTags", "ChangeTags", "FieldsChangeDescs", "MapInt32", "MapInt64", "MapBool", "MapString", "MapInt32Removed", "MapInt64Removed", "MapBoolRemoved", "MapStringRemoved" }, null, null, null, new pbr::GeneratedClrTypeInfo[] { null, null, null, null, null, null, null, null, })
                }));
        }
        #endregion

    }
    #region Messages
    /// <summary>
    /// 变更描述，可以表示一个Message或Message中一个Map的变更元数据
    /// 如果是用于描述Message,则使用fieldTags, changeTags, fieldChangeMetas来描述这个Message中每个field的是否变化和变化内容，具体见相应的字段描述
    /// </summary>
    public sealed partial class ChangeDesc : pb::IMessage<ChangeDesc>
    {
        private static readonly pb::MessageParser<ChangeDesc> _parser = new pb::MessageParser<ChangeDesc>(() => new ChangeDesc());
        private pb::UnknownFieldSet _unknownFields;
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pb::MessageParser<ChangeDesc> Parser { get { return _parser; } }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public static pbr::MessageDescriptor Descriptor
        {
            get { return global::com.variflight.dataservice.ChangeDescReflection.Descriptor.MessageTypes[0]; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        pbr::MessageDescriptor pb::IMessage.Descriptor
        {
            get { return Descriptor; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ChangeDesc()
        {
            OnConstruction();
        }

        partial void OnConstruction();

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ChangeDesc(ChangeDesc other) : this()
        {
            fieldTags_ = other.fieldTags_;
            changeTags_ = other.changeTags_;
            fieldsChangeDescs_ = other.fieldsChangeDescs_.Clone();
            mapInt32_ = other.mapInt32_.Clone();
            mapInt64_ = other.mapInt64_.Clone();
            mapBool_ = other.mapBool_.Clone();
            mapString_ = other.mapString_.Clone();
            mapInt32Removed_ = other.mapInt32Removed_.Clone();
            mapInt64Removed_ = other.mapInt64Removed_.Clone();
            mapBoolRemoved_ = other.mapBoolRemoved_.Clone();
            mapStringRemoved_ = other.mapStringRemoved_.Clone();
            _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public ChangeDesc Clone()
        {
            return new ChangeDesc(this);
        }

        /// <summary>Field number for the "fieldTags" field.</summary>
        public const int FieldTagsFieldNumber = 1;
        private pb::ByteString fieldTags_ = pb::ByteString.Empty;
        /// <summary>
        /// Message中字段变更类型标记，每两位表示一个字段，按字段number值排序，0b00无变更,0b01新建,0b10更新,0b11删除
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pb::ByteString FieldTags
        {
            get { return fieldTags_; }
            set
            {
                fieldTags_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "changeTags" field.</summary>
        public const int ChangeTagsFieldNumber = 2;
        private pb::ByteString changeTags_ = pb::ByteString.Empty;
        /// <summary>
        /// Message中字段变更描述索引，对应到fields中的值，每一位表示一个字段，按字段number值排序，0b0表示该字段无变更描述, 0b1表示该字段有变更
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pb::ByteString ChangeTags
        {
            get { return changeTags_; }
            set
            {
                changeTags_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
            }
        }

        /// <summary>Field number for the "fieldsChangeDescs" field.</summary>
        public const int FieldsChangeDescsFieldNumber = 3;
        private static readonly pb::FieldCodec<global::com.variflight.dataservice.ChangeDesc> _repeated_fieldsChangeDescs_codec
            = pb::FieldCodec.ForMessage(26, global::com.variflight.dataservice.ChangeDesc.Parser);
        private readonly pbc::RepeatedField<global::com.variflight.dataservice.ChangeDesc> fieldsChangeDescs_ = new pbc::RepeatedField<global::com.variflight.dataservice.ChangeDesc>();
        /// <summary>
        /// Message中内嵌的Message字段或Map字段的变更描述
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::RepeatedField<global::com.variflight.dataservice.ChangeDesc> FieldsChangeDescs
        {
            get { return fieldsChangeDescs_; }
        }

        /// <summary>Field number for the "map_int32" field.</summary>
        public const int MapInt32FieldNumber = 4;
        private static readonly pbc::MapField<int, global::com.variflight.dataservice.ChangeDesc>.Codec _map_mapInt32_codec
            = new pbc::MapField<int, global::com.variflight.dataservice.ChangeDesc>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForMessage(18, global::com.variflight.dataservice.ChangeDesc.Parser), 34);
        private readonly pbc::MapField<int, global::com.variflight.dataservice.ChangeDesc> mapInt32_ = new pbc::MapField<int, global::com.variflight.dataservice.ChangeDesc>();
        /// <summary>
        /// Map字段的变更描述，key为map中的key，value.fieldTags长度为0或空，则表示该key为新增或值已变更(值类型)
        /// 不为空，且fieldTags长度不为0，则表示该key对应的value为message类型的变更描述
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::MapField<int, global::com.variflight.dataservice.ChangeDesc> MapInt32
        {
            get { return mapInt32_; }
        }

        /// <summary>Field number for the "map_int64" field.</summary>
        public const int MapInt64FieldNumber = 5;
        private static readonly pbc::MapField<long, global::com.variflight.dataservice.ChangeDesc>.Codec _map_mapInt64_codec
            = new pbc::MapField<long, global::com.variflight.dataservice.ChangeDesc>.Codec(pb::FieldCodec.ForInt64(8, 0L), pb::FieldCodec.ForMessage(18, global::com.variflight.dataservice.ChangeDesc.Parser), 42);
        private readonly pbc::MapField<long, global::com.variflight.dataservice.ChangeDesc> mapInt64_ = new pbc::MapField<long, global::com.variflight.dataservice.ChangeDesc>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::MapField<long, global::com.variflight.dataservice.ChangeDesc> MapInt64
        {
            get { return mapInt64_; }
        }

        /// <summary>Field number for the "map_bool" field.</summary>
        public const int MapBoolFieldNumber = 6;
        private static readonly pbc::MapField<bool, global::com.variflight.dataservice.ChangeDesc>.Codec _map_mapBool_codec
            = new pbc::MapField<bool, global::com.variflight.dataservice.ChangeDesc>.Codec(pb::FieldCodec.ForBool(8, false), pb::FieldCodec.ForMessage(18, global::com.variflight.dataservice.ChangeDesc.Parser), 50);
        private readonly pbc::MapField<bool, global::com.variflight.dataservice.ChangeDesc> mapBool_ = new pbc::MapField<bool, global::com.variflight.dataservice.ChangeDesc>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::MapField<bool, global::com.variflight.dataservice.ChangeDesc> MapBool
        {
            get { return mapBool_; }
        }

        /// <summary>Field number for the "map_string" field.</summary>
        public const int MapStringFieldNumber = 7;
        private static readonly pbc::MapField<string, global::com.variflight.dataservice.ChangeDesc>.Codec _map_mapString_codec
            = new pbc::MapField<string, global::com.variflight.dataservice.ChangeDesc>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::com.variflight.dataservice.ChangeDesc.Parser), 58);
        private readonly pbc::MapField<string, global::com.variflight.dataservice.ChangeDesc> mapString_ = new pbc::MapField<string, global::com.variflight.dataservice.ChangeDesc>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::MapField<string, global::com.variflight.dataservice.ChangeDesc> MapString
        {
            get { return mapString_; }
        }

        /// <summary>Field number for the "map_int32_removed" field.</summary>
        public const int MapInt32RemovedFieldNumber = 8;
        private static readonly pbc::MapField<int, global::com.variflight.dataservice.ChangeDesc>.Codec _map_mapInt32Removed_codec
            = new pbc::MapField<int, global::com.variflight.dataservice.ChangeDesc>.Codec(pb::FieldCodec.ForInt32(8, 0), pb::FieldCodec.ForMessage(18, global::com.variflight.dataservice.ChangeDesc.Parser), 66);
        private readonly pbc::MapField<int, global::com.variflight.dataservice.ChangeDesc> mapInt32Removed_ = new pbc::MapField<int, global::com.variflight.dataservice.ChangeDesc>();
        /// <summary>
        /// Map字段删除描述
        /// </summary>
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::MapField<int, global::com.variflight.dataservice.ChangeDesc> MapInt32Removed
        {
            get { return mapInt32Removed_; }
        }

        /// <summary>Field number for the "map_int64_removed" field.</summary>
        public const int MapInt64RemovedFieldNumber = 9;
        private static readonly pbc::MapField<long, global::com.variflight.dataservice.ChangeDesc>.Codec _map_mapInt64Removed_codec
            = new pbc::MapField<long, global::com.variflight.dataservice.ChangeDesc>.Codec(pb::FieldCodec.ForInt64(8, 0L), pb::FieldCodec.ForMessage(18, global::com.variflight.dataservice.ChangeDesc.Parser), 74);
        private readonly pbc::MapField<long, global::com.variflight.dataservice.ChangeDesc> mapInt64Removed_ = new pbc::MapField<long, global::com.variflight.dataservice.ChangeDesc>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::MapField<long, global::com.variflight.dataservice.ChangeDesc> MapInt64Removed
        {
            get { return mapInt64Removed_; }
        }

        /// <summary>Field number for the "map_bool_removed" field.</summary>
        public const int MapBoolRemovedFieldNumber = 10;
        private static readonly pbc::MapField<bool, global::com.variflight.dataservice.ChangeDesc>.Codec _map_mapBoolRemoved_codec
            = new pbc::MapField<bool, global::com.variflight.dataservice.ChangeDesc>.Codec(pb::FieldCodec.ForBool(8, false), pb::FieldCodec.ForMessage(18, global::com.variflight.dataservice.ChangeDesc.Parser), 82);
        private readonly pbc::MapField<bool, global::com.variflight.dataservice.ChangeDesc> mapBoolRemoved_ = new pbc::MapField<bool, global::com.variflight.dataservice.ChangeDesc>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::MapField<bool, global::com.variflight.dataservice.ChangeDesc> MapBoolRemoved
        {
            get { return mapBoolRemoved_; }
        }

        /// <summary>Field number for the "map_string_removed" field.</summary>
        public const int MapStringRemovedFieldNumber = 11;
        private static readonly pbc::MapField<string, global::com.variflight.dataservice.ChangeDesc>.Codec _map_mapStringRemoved_codec
            = new pbc::MapField<string, global::com.variflight.dataservice.ChangeDesc>.Codec(pb::FieldCodec.ForString(10, ""), pb::FieldCodec.ForMessage(18, global::com.variflight.dataservice.ChangeDesc.Parser), 90);
        private readonly pbc::MapField<string, global::com.variflight.dataservice.ChangeDesc> mapStringRemoved_ = new pbc::MapField<string, global::com.variflight.dataservice.ChangeDesc>();
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public pbc::MapField<string, global::com.variflight.dataservice.ChangeDesc> MapStringRemoved
        {
            get { return mapStringRemoved_; }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override bool Equals(object other)
        {
            return Equals(other as ChangeDesc);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public bool Equals(ChangeDesc other)
        {
            if (ReferenceEquals(other, null))
            {
                return false;
            }
            if (ReferenceEquals(other, this))
            {
                return true;
            }
            if (FieldTags != other.FieldTags) return false;
            if (ChangeTags != other.ChangeTags) return false;
            if (!fieldsChangeDescs_.Equals(other.fieldsChangeDescs_)) return false;
            if (!MapInt32.Equals(other.MapInt32)) return false;
            if (!MapInt64.Equals(other.MapInt64)) return false;
            if (!MapBool.Equals(other.MapBool)) return false;
            if (!MapString.Equals(other.MapString)) return false;
            if (!MapInt32Removed.Equals(other.MapInt32Removed)) return false;
            if (!MapInt64Removed.Equals(other.MapInt64Removed)) return false;
            if (!MapBoolRemoved.Equals(other.MapBoolRemoved)) return false;
            if (!MapStringRemoved.Equals(other.MapStringRemoved)) return false;
            return Equals(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override int GetHashCode()
        {
            int hash = 1;
            if (FieldTags.Length != 0) hash ^= FieldTags.GetHashCode();
            if (ChangeTags.Length != 0) hash ^= ChangeTags.GetHashCode();
            hash ^= fieldsChangeDescs_.GetHashCode();
            hash ^= MapInt32.GetHashCode();
            hash ^= MapInt64.GetHashCode();
            hash ^= MapBool.GetHashCode();
            hash ^= MapString.GetHashCode();
            hash ^= MapInt32Removed.GetHashCode();
            hash ^= MapInt64Removed.GetHashCode();
            hash ^= MapBoolRemoved.GetHashCode();
            hash ^= MapStringRemoved.GetHashCode();
            if (_unknownFields != null)
            {
                hash ^= _unknownFields.GetHashCode();
            }
            return hash;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public override string ToString()
        {
            return pb::JsonFormatter.ToDiagnosticString(this);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void WriteTo(pb::CodedOutputStream output)
        {
            if (FieldTags.Length != 0)
            {
                output.WriteRawTag(10);
                output.WriteBytes(FieldTags);
            }
            if (ChangeTags.Length != 0)
            {
                output.WriteRawTag(18);
                output.WriteBytes(ChangeTags);
            }
            fieldsChangeDescs_.WriteTo(output, _repeated_fieldsChangeDescs_codec);
            mapInt32_.WriteTo(output, _map_mapInt32_codec);
            mapInt64_.WriteTo(output, _map_mapInt64_codec);
            mapBool_.WriteTo(output, _map_mapBool_codec);
            mapString_.WriteTo(output, _map_mapString_codec);
            mapInt32Removed_.WriteTo(output, _map_mapInt32Removed_codec);
            mapInt64Removed_.WriteTo(output, _map_mapInt64Removed_codec);
            mapBoolRemoved_.WriteTo(output, _map_mapBoolRemoved_codec);
            mapStringRemoved_.WriteTo(output, _map_mapStringRemoved_codec);
            if (_unknownFields != null)
            {
                _unknownFields.WriteTo(output);
            }
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public int CalculateSize()
        {
            int size = 0;
            if (FieldTags.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeBytesSize(FieldTags);
            }
            if (ChangeTags.Length != 0)
            {
                size += 1 + pb::CodedOutputStream.ComputeBytesSize(ChangeTags);
            }
            size += fieldsChangeDescs_.CalculateSize(_repeated_fieldsChangeDescs_codec);
            size += mapInt32_.CalculateSize(_map_mapInt32_codec);
            size += mapInt64_.CalculateSize(_map_mapInt64_codec);
            size += mapBool_.CalculateSize(_map_mapBool_codec);
            size += mapString_.CalculateSize(_map_mapString_codec);
            size += mapInt32Removed_.CalculateSize(_map_mapInt32Removed_codec);
            size += mapInt64Removed_.CalculateSize(_map_mapInt64Removed_codec);
            size += mapBoolRemoved_.CalculateSize(_map_mapBoolRemoved_codec);
            size += mapStringRemoved_.CalculateSize(_map_mapStringRemoved_codec);
            if (_unknownFields != null)
            {
                size += _unknownFields.CalculateSize();
            }
            return size;
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(ChangeDesc other)
        {
            if (other == null)
            {
                return;
            }
            if (other.FieldTags.Length != 0)
            {
                FieldTags = other.FieldTags;
            }
            if (other.ChangeTags.Length != 0)
            {
                ChangeTags = other.ChangeTags;
            }
            fieldsChangeDescs_.Add(other.fieldsChangeDescs_);
            mapInt32_.Add(other.mapInt32_);
            mapInt64_.Add(other.mapInt64_);
            mapBool_.Add(other.mapBool_);
            mapString_.Add(other.mapString_);
            mapInt32Removed_.Add(other.mapInt32Removed_);
            mapInt64Removed_.Add(other.mapInt64Removed_);
            mapBoolRemoved_.Add(other.mapBoolRemoved_);
            mapStringRemoved_.Add(other.mapStringRemoved_);
            _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
        }

        [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
        public void MergeFrom(pb::CodedInputStream input)
        {
            uint tag;
            while ((tag = input.ReadTag()) != 0)
            {
                switch (tag)
                {
                    default:
                        _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
                        break;
                    case 10:
                        {
                            FieldTags = input.ReadBytes();
                            break;
                        }
                    case 18:
                        {
                            ChangeTags = input.ReadBytes();
                            break;
                        }
                    case 26:
                        {
                            fieldsChangeDescs_.AddEntriesFrom(input, _repeated_fieldsChangeDescs_codec);
                            break;
                        }
                    case 34:
                        {
                            mapInt32_.AddEntriesFrom(input, _map_mapInt32_codec);
                            break;
                        }
                    case 42:
                        {
                            mapInt64_.AddEntriesFrom(input, _map_mapInt64_codec);
                            break;
                        }
                    case 50:
                        {
                            mapBool_.AddEntriesFrom(input, _map_mapBool_codec);
                            break;
                        }
                    case 58:
                        {
                            mapString_.AddEntriesFrom(input, _map_mapString_codec);
                            break;
                        }
                    case 66:
                        {
                            mapInt32Removed_.AddEntriesFrom(input, _map_mapInt32Removed_codec);
                            break;
                        }
                    case 74:
                        {
                            mapInt64Removed_.AddEntriesFrom(input, _map_mapInt64Removed_codec);
                            break;
                        }
                    case 82:
                        {
                            mapBoolRemoved_.AddEntriesFrom(input, _map_mapBoolRemoved_codec);
                            break;
                        }
                    case 90:
                        {
                            mapStringRemoved_.AddEntriesFrom(input, _map_mapStringRemoved_codec);
                            break;
                        }
                }
            }
        }

    }

    #endregion

}

#endregion Designer generated code
