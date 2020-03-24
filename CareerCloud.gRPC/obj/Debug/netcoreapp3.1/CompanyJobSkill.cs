// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/CompanyJobSkill.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CareerCloud.gRPC.Protos {

  /// <summary>Holder for reflection information generated from Protos/CompanyJobSkill.proto</summary>
  public static partial class CompanyJobSkillReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/CompanyJobSkill.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static CompanyJobSkillReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChxQcm90b3MvQ29tcGFueUpvYlNraWxsLnByb3RvEhBDYXJlZXJDbG91ZC5n",
            "UlBDGhtnb29nbGUvcHJvdG9idWYvZW1wdHkucHJvdG8iHwoRSWRSZXF1ZXN0",
            "Sm9iU2tpbGwSCgoCSWQYASABKAkiaAoWQ29tcGFueUpvYlNraWxsUGF5bG9h",
            "ZBIKCgJJZBgBIAEoCRILCgNKb2IYAiABKAkSDQoFU2tpbGwYAyABKAkSEgoK",
            "U2tpbGxMZXZlbBgEIAEoCRISCgpJbXBvcnRhbmNlGAUgASgFMogDCg9Db21w",
            "YW55Sm9iU2tpbGwSZAoTUmVhZENvbXBhbnlKb2JTa2lsbBIjLkNhcmVlckNs",
            "b3VkLmdSUEMuSWRSZXF1ZXN0Sm9iU2tpbGwaKC5DYXJlZXJDbG91ZC5nUlBD",
            "LkNvbXBhbnlKb2JTa2lsbFBheWxvYWQSWQoVQ3JlYXRlQ29tcGFueUpvYlNr",
            "aWxsEiguQ2FyZWVyQ2xvdWQuZ1JQQy5Db21wYW55Sm9iU2tpbGxQYXlsb2Fk",
            "GhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5ElkKFVVwZGF0ZUNvbXBhbnlKb2JT",
            "a2lsbBIoLkNhcmVlckNsb3VkLmdSUEMuQ29tcGFueUpvYlNraWxsUGF5bG9h",
            "ZBoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eRJZChVEZWxldGVDb21wYW55Sm9i",
            "U2tpbGwSKC5DYXJlZXJDbG91ZC5nUlBDLkNvbXBhbnlKb2JTa2lsbFBheWxv",
            "YWQaFi5nb29nbGUucHJvdG9idWYuRW1wdHlCGqoCF0NhcmVlckNsb3VkLmdS",
            "UEMuUHJvdG9zYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.IdRequestJobSkill), global::CareerCloud.gRPC.Protos.IdRequestJobSkill.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.CompanyJobSkillPayload), global::CareerCloud.gRPC.Protos.CompanyJobSkillPayload.Parser, new[]{ "Id", "Job", "Skill", "SkillLevel", "Importance" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class IdRequestJobSkill : pb::IMessage<IdRequestJobSkill> {
    private static readonly pb::MessageParser<IdRequestJobSkill> _parser = new pb::MessageParser<IdRequestJobSkill>(() => new IdRequestJobSkill());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IdRequestJobSkill> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.CompanyJobSkillReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequestJobSkill() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequestJobSkill(IdRequestJobSkill other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequestJobSkill Clone() {
      return new IdRequestJobSkill(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as IdRequestJobSkill);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IdRequestJobSkill other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(IdRequestJobSkill other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
        }
      }
    }

  }

  public sealed partial class CompanyJobSkillPayload : pb::IMessage<CompanyJobSkillPayload> {
    private static readonly pb::MessageParser<CompanyJobSkillPayload> _parser = new pb::MessageParser<CompanyJobSkillPayload>(() => new CompanyJobSkillPayload());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<CompanyJobSkillPayload> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.CompanyJobSkillReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobSkillPayload() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobSkillPayload(CompanyJobSkillPayload other) : this() {
      id_ = other.id_;
      job_ = other.job_;
      skill_ = other.skill_;
      skillLevel_ = other.skillLevel_;
      importance_ = other.importance_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public CompanyJobSkillPayload Clone() {
      return new CompanyJobSkillPayload(this);
    }

    /// <summary>Field number for the "Id" field.</summary>
    public const int IdFieldNumber = 1;
    private string id_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Id {
      get { return id_; }
      set {
        id_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Job" field.</summary>
    public const int JobFieldNumber = 2;
    private string job_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Job {
      get { return job_; }
      set {
        job_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Skill" field.</summary>
    public const int SkillFieldNumber = 3;
    private string skill_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Skill {
      get { return skill_; }
      set {
        skill_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "SkillLevel" field.</summary>
    public const int SkillLevelFieldNumber = 4;
    private string skillLevel_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string SkillLevel {
      get { return skillLevel_; }
      set {
        skillLevel_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "Importance" field.</summary>
    public const int ImportanceFieldNumber = 5;
    private int importance_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int Importance {
      get { return importance_; }
      set {
        importance_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as CompanyJobSkillPayload);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(CompanyJobSkillPayload other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Job != other.Job) return false;
      if (Skill != other.Skill) return false;
      if (SkillLevel != other.SkillLevel) return false;
      if (Importance != other.Importance) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Job.Length != 0) hash ^= Job.GetHashCode();
      if (Skill.Length != 0) hash ^= Skill.GetHashCode();
      if (SkillLevel.Length != 0) hash ^= SkillLevel.GetHashCode();
      if (Importance != 0) hash ^= Importance.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (Id.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Id);
      }
      if (Job.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Job);
      }
      if (Skill.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Skill);
      }
      if (SkillLevel.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(SkillLevel);
      }
      if (Importance != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(Importance);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Id.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Id);
      }
      if (Job.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Job);
      }
      if (Skill.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Skill);
      }
      if (SkillLevel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SkillLevel);
      }
      if (Importance != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(Importance);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(CompanyJobSkillPayload other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Job.Length != 0) {
        Job = other.Job;
      }
      if (other.Skill.Length != 0) {
        Skill = other.Skill;
      }
      if (other.SkillLevel.Length != 0) {
        SkillLevel = other.SkillLevel;
      }
      if (other.Importance != 0) {
        Importance = other.Importance;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Id = input.ReadString();
            break;
          }
          case 18: {
            Job = input.ReadString();
            break;
          }
          case 26: {
            Skill = input.ReadString();
            break;
          }
          case 34: {
            SkillLevel = input.ReadString();
            break;
          }
          case 40: {
            Importance = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code