// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cardchain/cardchain/match_reporter_proposal.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace DecentralCardGame.Cardchain.Cardchain {

  /// <summary>Holder for reflection information generated from cardchain/cardchain/match_reporter_proposal.proto</summary>
  public static partial class MatchReporterProposalReflection {

    #region Descriptor
    /// <summary>File descriptor for cardchain/cardchain/match_reporter_proposal.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static MatchReporterProposalReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjFjYXJkY2hhaW4vY2FyZGNoYWluL21hdGNoX3JlcG9ydGVyX3Byb3Bvc2Fs",
            "LnByb3RvEiVEZWNlbnRyYWxDYXJkR2FtZS5jYXJkY2hhaW4uY2FyZGNoYWlu",
            "ImsKFU1hdGNoUmVwb3J0ZXJQcm9wb3NhbBIUCgV0aXRsZRgBIAEoCVIFdGl0",
            "bGUSIAoLZGVzY3JpcHRpb24YAiABKAlSC2Rlc2NyaXB0aW9uEhoKCHJlcG9y",
            "dGVyGAMgASgJUghyZXBvcnRlckK5AgopY29tLkRlY2VudHJhbENhcmRHYW1l",
            "LmNhcmRjaGFpbi5jYXJkY2hhaW5CGk1hdGNoUmVwb3J0ZXJQcm9wb3NhbFBy",
            "b3RvUAFaOmdpdGh1Yi5jb20vRGVjZW50cmFsQ2FyZGdhbWUvQ2FyZGNoYWlu",
            "L2NhcmRjaGFpbi9jYXJkY2hhaW6iAgNEQ0OqAiVEZWNlbnRyYWxDYXJkR2Ft",
            "ZS5DYXJkY2hhaW4uQ2FyZGNoYWluygIlRGVjZW50cmFsQ2FyZEdhbWVcQ2Fy",
            "ZGNoYWluXENhcmRjaGFpbuICMURlY2VudHJhbENhcmRHYW1lXENhcmRjaGFp",
            "blxDYXJkY2hhaW5cR1BCTWV0YWRhdGHqAidEZWNlbnRyYWxDYXJkR2FtZTo6",
            "Q2FyZGNoYWluOjpDYXJkY2hhaW5iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::DecentralCardGame.Cardchain.Cardchain.MatchReporterProposal), global::DecentralCardGame.Cardchain.Cardchain.MatchReporterProposal.Parser, new[]{ "Title", "Description", "Reporter" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class MatchReporterProposal : pb::IMessage<MatchReporterProposal>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<MatchReporterProposal> _parser = new pb::MessageParser<MatchReporterProposal>(() => new MatchReporterProposal());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<MatchReporterProposal> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DecentralCardGame.Cardchain.Cardchain.MatchReporterProposalReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MatchReporterProposal() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MatchReporterProposal(MatchReporterProposal other) : this() {
      title_ = other.title_;
      description_ = other.description_;
      reporter_ = other.reporter_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public MatchReporterProposal Clone() {
      return new MatchReporterProposal(this);
    }

    /// <summary>Field number for the "title" field.</summary>
    public const int TitleFieldNumber = 1;
    private string title_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Title {
      get { return title_; }
      set {
        title_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "description" field.</summary>
    public const int DescriptionFieldNumber = 2;
    private string description_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Description {
      get { return description_; }
      set {
        description_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "reporter" field.</summary>
    public const int ReporterFieldNumber = 3;
    private string reporter_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Reporter {
      get { return reporter_; }
      set {
        reporter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as MatchReporterProposal);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(MatchReporterProposal other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Title != other.Title) return false;
      if (Description != other.Description) return false;
      if (Reporter != other.Reporter) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Title.Length != 0) hash ^= Title.GetHashCode();
      if (Description.Length != 0) hash ^= Description.GetHashCode();
      if (Reporter.Length != 0) hash ^= Reporter.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Title.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Title);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (Reporter.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Reporter);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Title.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Title);
      }
      if (Description.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Description);
      }
      if (Reporter.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(Reporter);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public int CalculateSize() {
      int size = 0;
      if (Title.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Title);
      }
      if (Description.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Description);
      }
      if (Reporter.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Reporter);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(MatchReporterProposal other) {
      if (other == null) {
        return;
      }
      if (other.Title.Length != 0) {
        Title = other.Title;
      }
      if (other.Description.Length != 0) {
        Description = other.Description;
      }
      if (other.Reporter.Length != 0) {
        Reporter = other.Reporter;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Title = input.ReadString();
            break;
          }
          case 18: {
            Description = input.ReadString();
            break;
          }
          case 26: {
            Reporter = input.ReadString();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
      switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Title = input.ReadString();
            break;
          }
          case 18: {
            Description = input.ReadString();
            break;
          }
          case 26: {
            Reporter = input.ReadString();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
