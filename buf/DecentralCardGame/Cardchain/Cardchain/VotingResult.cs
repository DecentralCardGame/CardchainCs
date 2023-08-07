// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: DecentralCardGame/cardchain/cardchain/voting_result.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace DecentralCardGame.Cardchain.Cardchain {

  /// <summary>Holder for reflection information generated from DecentralCardGame/cardchain/cardchain/voting_result.proto</summary>
  public static partial class VotingResultReflection {

    #region Descriptor
    /// <summary>File descriptor for DecentralCardGame/cardchain/cardchain/voting_result.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VotingResultReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CjlEZWNlbnRyYWxDYXJkR2FtZS9jYXJkY2hhaW4vY2FyZGNoYWluL3ZvdGlu",
            "Z19yZXN1bHQucHJvdG8SJURlY2VudHJhbENhcmRHYW1lLmNhcmRjaGFpbi5j",
            "YXJkY2hhaW4i8gEKDFZvdGluZ1Jlc3VsdBIWCgZjYXJkSWQYASABKARSBmNh",
            "cmRJZBIoCg9mYWlyRW5vdWdoVm90ZXMYAiABKARSD2ZhaXJFbm91Z2hWb3Rl",
            "cxIqChBvdmVycG93ZXJlZFZvdGVzGAMgASgEUhBvdmVycG93ZXJlZFZvdGVz",
            "EiwKEXVuZGVycG93ZXJlZFZvdGVzGAQgASgEUhF1bmRlcnBvd2VyZWRWb3Rl",
            "cxIuChJpbmFwcHJvcHJpYXRlVm90ZXMYBSABKARSEmluYXBwcm9wcmlhdGVW",
            "b3RlcxIWCgZyZXN1bHQYBiABKAlSBnJlc3VsdEKuAgopY29tLkRlY2VudHJh",
            "bENhcmRHYW1lLmNhcmRjaGFpbi5jYXJkY2hhaW5CEVZvdGluZ1Jlc3VsdFBy",
            "b3RvUAFaOGdpdGh1Yi5jb20vRGVjZW50cmFsQ2FyZEdhbWUvQ2FyZGNoYWlu",
            "L3gvY2FyZGNoYWluL3R5cGVzogIDRENDqgIlRGVjZW50cmFsQ2FyZEdhbWUu",
            "Q2FyZGNoYWluLkNhcmRjaGFpbsoCJURlY2VudHJhbENhcmRHYW1lXENhcmRj",
            "aGFpblxDYXJkY2hhaW7iAjFEZWNlbnRyYWxDYXJkR2FtZVxDYXJkY2hhaW5c",
            "Q2FyZGNoYWluXEdQQk1ldGFkYXRh6gInRGVjZW50cmFsQ2FyZEdhbWU6OkNh",
            "cmRjaGFpbjo6Q2FyZGNoYWluYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::DecentralCardGame.Cardchain.Cardchain.VotingResult), global::DecentralCardGame.Cardchain.Cardchain.VotingResult.Parser, new[]{ "CardId", "FairEnoughVotes", "OverpoweredVotes", "UnderpoweredVotes", "InappropriateVotes", "Result" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class VotingResult : pb::IMessage<VotingResult>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<VotingResult> _parser = new pb::MessageParser<VotingResult>(() => new VotingResult());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<VotingResult> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DecentralCardGame.Cardchain.Cardchain.VotingResultReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VotingResult() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VotingResult(VotingResult other) : this() {
      cardId_ = other.cardId_;
      fairEnoughVotes_ = other.fairEnoughVotes_;
      overpoweredVotes_ = other.overpoweredVotes_;
      underpoweredVotes_ = other.underpoweredVotes_;
      inappropriateVotes_ = other.inappropriateVotes_;
      result_ = other.result_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public VotingResult Clone() {
      return new VotingResult(this);
    }

    /// <summary>Field number for the "cardId" field.</summary>
    public const int CardIdFieldNumber = 1;
    private ulong cardId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong CardId {
      get { return cardId_; }
      set {
        cardId_ = value;
      }
    }

    /// <summary>Field number for the "fairEnoughVotes" field.</summary>
    public const int FairEnoughVotesFieldNumber = 2;
    private ulong fairEnoughVotes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong FairEnoughVotes {
      get { return fairEnoughVotes_; }
      set {
        fairEnoughVotes_ = value;
      }
    }

    /// <summary>Field number for the "overpoweredVotes" field.</summary>
    public const int OverpoweredVotesFieldNumber = 3;
    private ulong overpoweredVotes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong OverpoweredVotes {
      get { return overpoweredVotes_; }
      set {
        overpoweredVotes_ = value;
      }
    }

    /// <summary>Field number for the "underpoweredVotes" field.</summary>
    public const int UnderpoweredVotesFieldNumber = 4;
    private ulong underpoweredVotes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong UnderpoweredVotes {
      get { return underpoweredVotes_; }
      set {
        underpoweredVotes_ = value;
      }
    }

    /// <summary>Field number for the "inappropriateVotes" field.</summary>
    public const int InappropriateVotesFieldNumber = 5;
    private ulong inappropriateVotes_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong InappropriateVotes {
      get { return inappropriateVotes_; }
      set {
        inappropriateVotes_ = value;
      }
    }

    /// <summary>Field number for the "result" field.</summary>
    public const int ResultFieldNumber = 6;
    private string result_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Result {
      get { return result_; }
      set {
        result_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as VotingResult);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(VotingResult other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CardId != other.CardId) return false;
      if (FairEnoughVotes != other.FairEnoughVotes) return false;
      if (OverpoweredVotes != other.OverpoweredVotes) return false;
      if (UnderpoweredVotes != other.UnderpoweredVotes) return false;
      if (InappropriateVotes != other.InappropriateVotes) return false;
      if (Result != other.Result) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CardId != 0UL) hash ^= CardId.GetHashCode();
      if (FairEnoughVotes != 0UL) hash ^= FairEnoughVotes.GetHashCode();
      if (OverpoweredVotes != 0UL) hash ^= OverpoweredVotes.GetHashCode();
      if (UnderpoweredVotes != 0UL) hash ^= UnderpoweredVotes.GetHashCode();
      if (InappropriateVotes != 0UL) hash ^= InappropriateVotes.GetHashCode();
      if (Result.Length != 0) hash ^= Result.GetHashCode();
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
      if (CardId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(CardId);
      }
      if (FairEnoughVotes != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(FairEnoughVotes);
      }
      if (OverpoweredVotes != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(OverpoweredVotes);
      }
      if (UnderpoweredVotes != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(UnderpoweredVotes);
      }
      if (InappropriateVotes != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(InappropriateVotes);
      }
      if (Result.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Result);
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
      if (CardId != 0UL) {
        output.WriteRawTag(8);
        output.WriteUInt64(CardId);
      }
      if (FairEnoughVotes != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(FairEnoughVotes);
      }
      if (OverpoweredVotes != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(OverpoweredVotes);
      }
      if (UnderpoweredVotes != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(UnderpoweredVotes);
      }
      if (InappropriateVotes != 0UL) {
        output.WriteRawTag(40);
        output.WriteUInt64(InappropriateVotes);
      }
      if (Result.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(Result);
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
      if (CardId != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(CardId);
      }
      if (FairEnoughVotes != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(FairEnoughVotes);
      }
      if (OverpoweredVotes != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(OverpoweredVotes);
      }
      if (UnderpoweredVotes != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(UnderpoweredVotes);
      }
      if (InappropriateVotes != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(InappropriateVotes);
      }
      if (Result.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Result);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(VotingResult other) {
      if (other == null) {
        return;
      }
      if (other.CardId != 0UL) {
        CardId = other.CardId;
      }
      if (other.FairEnoughVotes != 0UL) {
        FairEnoughVotes = other.FairEnoughVotes;
      }
      if (other.OverpoweredVotes != 0UL) {
        OverpoweredVotes = other.OverpoweredVotes;
      }
      if (other.UnderpoweredVotes != 0UL) {
        UnderpoweredVotes = other.UnderpoweredVotes;
      }
      if (other.InappropriateVotes != 0UL) {
        InappropriateVotes = other.InappropriateVotes;
      }
      if (other.Result.Length != 0) {
        Result = other.Result;
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
          case 8: {
            CardId = input.ReadUInt64();
            break;
          }
          case 16: {
            FairEnoughVotes = input.ReadUInt64();
            break;
          }
          case 24: {
            OverpoweredVotes = input.ReadUInt64();
            break;
          }
          case 32: {
            UnderpoweredVotes = input.ReadUInt64();
            break;
          }
          case 40: {
            InappropriateVotes = input.ReadUInt64();
            break;
          }
          case 50: {
            Result = input.ReadString();
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
          case 8: {
            CardId = input.ReadUInt64();
            break;
          }
          case 16: {
            FairEnoughVotes = input.ReadUInt64();
            break;
          }
          case 24: {
            OverpoweredVotes = input.ReadUInt64();
            break;
          }
          case 32: {
            UnderpoweredVotes = input.ReadUInt64();
            break;
          }
          case 40: {
            InappropriateVotes = input.ReadUInt64();
            break;
          }
          case 50: {
            Result = input.ReadString();
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
