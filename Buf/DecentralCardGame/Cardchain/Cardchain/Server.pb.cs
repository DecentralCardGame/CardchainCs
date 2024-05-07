// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cardchain/cardchain/server.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace DecentralCardGame.Cardchain.Cardchain {

  /// <summary>Holder for reflection information generated from cardchain/cardchain/server.proto</summary>
  public static partial class ServerReflection {

    #region Descriptor
    /// <summary>File descriptor for cardchain/cardchain/server.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ServerReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBjYXJkY2hhaW4vY2FyZGNoYWluL3NlcnZlci5wcm90bxIlRGVjZW50cmFs",
            "Q2FyZEdhbWUuY2FyZGNoYWluLmNhcmRjaGFpbiJwCgZTZXJ2ZXISGgoIcmVw",
            "b3J0ZXIYASABKAlSCHJlcG9ydGVyEiYKDmludmFsaWRSZXBvcnRzGAIgASgE",
            "Ug5pbnZhbGlkUmVwb3J0cxIiCgx2YWxpZFJlcG9ydHMYAyABKARSDHZhbGlk",
            "UmVwb3J0c0KqAgopY29tLkRlY2VudHJhbENhcmRHYW1lLmNhcmRjaGFpbi5j",
            "YXJkY2hhaW5CC1NlcnZlclByb3RvUAFaOmdpdGh1Yi5jb20vRGVjZW50cmFs",
            "Q2FyZGdhbWUvQ2FyZGNoYWluL2NhcmRjaGFpbi9jYXJkY2hhaW6iAgNEQ0Oq",
            "AiVEZWNlbnRyYWxDYXJkR2FtZS5DYXJkY2hhaW4uQ2FyZGNoYWluygIlRGVj",
            "ZW50cmFsQ2FyZEdhbWVcQ2FyZGNoYWluXENhcmRjaGFpbuICMURlY2VudHJh",
            "bENhcmRHYW1lXENhcmRjaGFpblxDYXJkY2hhaW5cR1BCTWV0YWRhdGHqAidE",
            "ZWNlbnRyYWxDYXJkR2FtZTo6Q2FyZGNoYWluOjpDYXJkY2hhaW5iBnByb3Rv",
            "Mw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::DecentralCardGame.Cardchain.Cardchain.Server), global::DecentralCardGame.Cardchain.Cardchain.Server.Parser, new[]{ "Reporter", "InvalidReports", "ValidReports" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class Server : pb::IMessage<Server>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Server> _parser = new pb::MessageParser<Server>(() => new Server());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Server> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DecentralCardGame.Cardchain.Cardchain.ServerReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Server() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Server(Server other) : this() {
      reporter_ = other.reporter_;
      invalidReports_ = other.invalidReports_;
      validReports_ = other.validReports_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Server Clone() {
      return new Server(this);
    }

    /// <summary>Field number for the "reporter" field.</summary>
    public const int ReporterFieldNumber = 1;
    private string reporter_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Reporter {
      get { return reporter_; }
      set {
        reporter_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "invalidReports" field.</summary>
    public const int InvalidReportsFieldNumber = 2;
    private ulong invalidReports_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong InvalidReports {
      get { return invalidReports_; }
      set {
        invalidReports_ = value;
      }
    }

    /// <summary>Field number for the "validReports" field.</summary>
    public const int ValidReportsFieldNumber = 3;
    private ulong validReports_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ValidReports {
      get { return validReports_; }
      set {
        validReports_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Server);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Server other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Reporter != other.Reporter) return false;
      if (InvalidReports != other.InvalidReports) return false;
      if (ValidReports != other.ValidReports) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Reporter.Length != 0) hash ^= Reporter.GetHashCode();
      if (InvalidReports != 0UL) hash ^= InvalidReports.GetHashCode();
      if (ValidReports != 0UL) hash ^= ValidReports.GetHashCode();
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
      if (Reporter.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Reporter);
      }
      if (InvalidReports != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(InvalidReports);
      }
      if (ValidReports != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(ValidReports);
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
      if (Reporter.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Reporter);
      }
      if (InvalidReports != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(InvalidReports);
      }
      if (ValidReports != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(ValidReports);
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
      if (Reporter.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Reporter);
      }
      if (InvalidReports != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(InvalidReports);
      }
      if (ValidReports != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ValidReports);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Server other) {
      if (other == null) {
        return;
      }
      if (other.Reporter.Length != 0) {
        Reporter = other.Reporter;
      }
      if (other.InvalidReports != 0UL) {
        InvalidReports = other.InvalidReports;
      }
      if (other.ValidReports != 0UL) {
        ValidReports = other.ValidReports;
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
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Reporter = input.ReadString();
            break;
          }
          case 16: {
            InvalidReports = input.ReadUInt64();
            break;
          }
          case 24: {
            ValidReports = input.ReadUInt64();
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
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Reporter = input.ReadString();
            break;
          }
          case 16: {
            InvalidReports = input.ReadUInt64();
            break;
          }
          case 24: {
            ValidReports = input.ReadUInt64();
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