// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/ApplicantSkill.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace CareerCloud.gRPC.Protos {

  /// <summary>Holder for reflection information generated from Protos/ApplicantSkill.proto</summary>
  public static partial class ApplicantSkillReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/ApplicantSkill.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ApplicantSkillReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChtQcm90b3MvQXBwbGljYW50U2tpbGwucHJvdG8SEENhcmVlckNsb3VkLmdS",
            "UEMaG2dvb2dsZS9wcm90b2J1Zi9lbXB0eS5wcm90byIcCg5JZFJlcXVlc3RT",
            "a2lsbBIKCgJJZBgBIAEoCSKjAQoVQXBwbGljYW50U2tpbGxQYXlsb2FkEgoK",
            "AklkGAEgASgJEhEKCUFwcGxpY2FudBgCIAEoCRINCgVTa2lsbBgDIAEoCRIS",
            "CgpTa2lsbExldmVsGAQgASgJEhIKClN0YXJ0TW9udGgYBSABKAUSEQoJU3Rh",
            "cnRZZWFyGAYgASgFEhAKCEVuZE1vbnRoGAcgASgFEg8KB0VuZFllYXIYCCAB",
            "KAUy+wIKDkFwcGxpY2FudFNraWxsEl8KElJlYWRBcHBsaWNhbnRTa2lsbBIg",
            "LkNhcmVlckNsb3VkLmdSUEMuSWRSZXF1ZXN0U2tpbGwaJy5DYXJlZXJDbG91",
            "ZC5nUlBDLkFwcGxpY2FudFNraWxsUGF5bG9hZBJWChNDcmVhdGVBcGxpY2Fu",
            "dFNraWxsEicuQ2FyZWVyQ2xvdWQuZ1JQQy5BcHBsaWNhbnRTa2lsbFBheWxv",
            "YWQaFi5nb29nbGUucHJvdG9idWYuRW1wdHkSVwoUVXBkYXRlQXBwbGljYW50",
            "U2tpbGwSJy5DYXJlZXJDbG91ZC5nUlBDLkFwcGxpY2FudFNraWxsUGF5bG9h",
            "ZBoWLmdvb2dsZS5wcm90b2J1Zi5FbXB0eRJXChREZWxldGVBcHBsaWNhbnRT",
            "a2lsbBInLkNhcmVlckNsb3VkLmdSUEMuQXBwbGljYW50U2tpbGxQYXlsb2Fk",
            "GhYuZ29vZ2xlLnByb3RvYnVmLkVtcHR5QhqqAhdDYXJlZXJDbG91ZC5nUlBD",
            "LlByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Google.Protobuf.WellKnownTypes.EmptyReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.IdRequestSkill), global::CareerCloud.gRPC.Protos.IdRequestSkill.Parser, new[]{ "Id" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::CareerCloud.gRPC.Protos.ApplicantSkillPayload), global::CareerCloud.gRPC.Protos.ApplicantSkillPayload.Parser, new[]{ "Id", "Applicant", "Skill", "SkillLevel", "StartMonth", "StartYear", "EndMonth", "EndYear" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class IdRequestSkill : pb::IMessage<IdRequestSkill> {
    private static readonly pb::MessageParser<IdRequestSkill> _parser = new pb::MessageParser<IdRequestSkill>(() => new IdRequestSkill());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<IdRequestSkill> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.ApplicantSkillReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequestSkill() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequestSkill(IdRequestSkill other) : this() {
      id_ = other.id_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public IdRequestSkill Clone() {
      return new IdRequestSkill(this);
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
      return Equals(other as IdRequestSkill);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(IdRequestSkill other) {
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
    public void MergeFrom(IdRequestSkill other) {
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

  public sealed partial class ApplicantSkillPayload : pb::IMessage<ApplicantSkillPayload> {
    private static readonly pb::MessageParser<ApplicantSkillPayload> _parser = new pb::MessageParser<ApplicantSkillPayload>(() => new ApplicantSkillPayload());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ApplicantSkillPayload> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::CareerCloud.gRPC.Protos.ApplicantSkillReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantSkillPayload() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantSkillPayload(ApplicantSkillPayload other) : this() {
      id_ = other.id_;
      applicant_ = other.applicant_;
      skill_ = other.skill_;
      skillLevel_ = other.skillLevel_;
      startMonth_ = other.startMonth_;
      startYear_ = other.startYear_;
      endMonth_ = other.endMonth_;
      endYear_ = other.endYear_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ApplicantSkillPayload Clone() {
      return new ApplicantSkillPayload(this);
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

    /// <summary>Field number for the "Applicant" field.</summary>
    public const int ApplicantFieldNumber = 2;
    private string applicant_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Applicant {
      get { return applicant_; }
      set {
        applicant_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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

    /// <summary>Field number for the "StartMonth" field.</summary>
    public const int StartMonthFieldNumber = 5;
    private int startMonth_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int StartMonth {
      get { return startMonth_; }
      set {
        startMonth_ = value;
      }
    }

    /// <summary>Field number for the "StartYear" field.</summary>
    public const int StartYearFieldNumber = 6;
    private int startYear_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int StartYear {
      get { return startYear_; }
      set {
        startYear_ = value;
      }
    }

    /// <summary>Field number for the "EndMonth" field.</summary>
    public const int EndMonthFieldNumber = 7;
    private int endMonth_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int EndMonth {
      get { return endMonth_; }
      set {
        endMonth_ = value;
      }
    }

    /// <summary>Field number for the "EndYear" field.</summary>
    public const int EndYearFieldNumber = 8;
    private int endYear_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int EndYear {
      get { return endYear_; }
      set {
        endYear_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ApplicantSkillPayload);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ApplicantSkillPayload other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Id != other.Id) return false;
      if (Applicant != other.Applicant) return false;
      if (Skill != other.Skill) return false;
      if (SkillLevel != other.SkillLevel) return false;
      if (StartMonth != other.StartMonth) return false;
      if (StartYear != other.StartYear) return false;
      if (EndMonth != other.EndMonth) return false;
      if (EndYear != other.EndYear) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Id.Length != 0) hash ^= Id.GetHashCode();
      if (Applicant.Length != 0) hash ^= Applicant.GetHashCode();
      if (Skill.Length != 0) hash ^= Skill.GetHashCode();
      if (SkillLevel.Length != 0) hash ^= SkillLevel.GetHashCode();
      if (StartMonth != 0) hash ^= StartMonth.GetHashCode();
      if (StartYear != 0) hash ^= StartYear.GetHashCode();
      if (EndMonth != 0) hash ^= EndMonth.GetHashCode();
      if (EndYear != 0) hash ^= EndYear.GetHashCode();
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
      if (Applicant.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Applicant);
      }
      if (Skill.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Skill);
      }
      if (SkillLevel.Length != 0) {
        output.WriteRawTag(34);
        output.WriteString(SkillLevel);
      }
      if (StartMonth != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(StartMonth);
      }
      if (StartYear != 0) {
        output.WriteRawTag(48);
        output.WriteInt32(StartYear);
      }
      if (EndMonth != 0) {
        output.WriteRawTag(56);
        output.WriteInt32(EndMonth);
      }
      if (EndYear != 0) {
        output.WriteRawTag(64);
        output.WriteInt32(EndYear);
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
      if (Applicant.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Applicant);
      }
      if (Skill.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Skill);
      }
      if (SkillLevel.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SkillLevel);
      }
      if (StartMonth != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StartMonth);
      }
      if (StartYear != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(StartYear);
      }
      if (EndMonth != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EndMonth);
      }
      if (EndYear != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EndYear);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ApplicantSkillPayload other) {
      if (other == null) {
        return;
      }
      if (other.Id.Length != 0) {
        Id = other.Id;
      }
      if (other.Applicant.Length != 0) {
        Applicant = other.Applicant;
      }
      if (other.Skill.Length != 0) {
        Skill = other.Skill;
      }
      if (other.SkillLevel.Length != 0) {
        SkillLevel = other.SkillLevel;
      }
      if (other.StartMonth != 0) {
        StartMonth = other.StartMonth;
      }
      if (other.StartYear != 0) {
        StartYear = other.StartYear;
      }
      if (other.EndMonth != 0) {
        EndMonth = other.EndMonth;
      }
      if (other.EndYear != 0) {
        EndYear = other.EndYear;
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
            Applicant = input.ReadString();
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
            StartMonth = input.ReadInt32();
            break;
          }
          case 48: {
            StartYear = input.ReadInt32();
            break;
          }
          case 56: {
            EndMonth = input.ReadInt32();
            break;
          }
          case 64: {
            EndYear = input.ReadInt32();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
