// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cardchain/cardchain/voting.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cardchain.Cardchain {

  /// <summary>Holder for reflection information generated from cardchain/cardchain/voting.proto</summary>
  public static partial class VotingReflection {

    #region Descriptor
    /// <summary>File descriptor for cardchain/cardchain/voting.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static VotingReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBjYXJkY2hhaW4vY2FyZGNoYWluL3ZvdGluZy5wcm90bxITY2FyZGNoYWlu",
            "LmNhcmRjaGFpbiLyAQoMVm90aW5nUmVzdWx0EhYKBmNhcmRJZBgBIAEoBFIG",
            "Y2FyZElkEigKD2ZhaXJFbm91Z2hWb3RlcxgCIAEoBFIPZmFpckVub3VnaFZv",
            "dGVzEioKEG92ZXJwb3dlcmVkVm90ZXMYAyABKARSEG92ZXJwb3dlcmVkVm90",
            "ZXMSLAoRdW5kZXJwb3dlcmVkVm90ZXMYBCABKARSEXVuZGVycG93ZXJlZFZv",
            "dGVzEi4KEmluYXBwcm9wcmlhdGVWb3RlcxgFIAEoBFISaW5hcHByb3ByaWF0",
            "ZVZvdGVzEhYKBnJlc3VsdBgGIAEoCVIGcmVzdWx0Il8KClNpbmdsZVZvdGUS",
            "FgoGY2FyZElkGAEgASgEUgZjYXJkSWQSOQoIdm90ZVR5cGUYAiABKA4yHS5j",
            "YXJkY2hhaW4uY2FyZGNoYWluLlZvdGVUeXBlUgh2b3RlVHlwZSpQCghWb3Rl",
            "VHlwZRIOCgpmYWlyRW5vdWdoEAASEQoNaW5hcHByb3ByaWF0ZRABEg8KC292",
            "ZXJwb3dlcmVkEAISEAoMdW5kZXJwb3dlcmVkEANCzwEKF2NvbS5jYXJkY2hh",
            "aW4uY2FyZGNoYWluQgtWb3RpbmdQcm90b1ABWjpnaXRodWIuY29tL0RlY2Vu",
            "dHJhbENhcmRnYW1lL2NhcmRjaGFpbi9jYXJkY2hhaW4vY2FyZGNoYWluogID",
            "Q0NYqgITQ2FyZGNoYWluLkNhcmRjaGFpbsoCE0NhcmRjaGFpblxDYXJkY2hh",
            "aW7iAh9DYXJkY2hhaW5cQ2FyZGNoYWluXEdQQk1ldGFkYXRh6gIUQ2FyZGNo",
            "YWluOjpDYXJkY2hhaW5iBnByb3RvMw=="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Cardchain.Cardchain.VoteType), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cardchain.Cardchain.VotingResult), global::Cardchain.Cardchain.VotingResult.Parser, new[]{ "CardId", "FairEnoughVotes", "OverpoweredVotes", "UnderpoweredVotes", "InappropriateVotes", "Result" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::Cardchain.Cardchain.SingleVote), global::Cardchain.Cardchain.SingleVote.Parser, new[]{ "CardId", "VoteType" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum VoteType {
    [pbr::OriginalName("fairEnough")] FairEnough = 0,
    [pbr::OriginalName("inappropriate")] Inappropriate = 1,
    [pbr::OriginalName("overpowered")] Overpowered = 2,
    [pbr::OriginalName("underpowered")] Underpowered = 3,
  }

  #endregion

  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
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
      get { return global::Cardchain.Cardchain.VotingReflection.Descriptor.MessageTypes[0]; }
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
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
      if ((tag & 7) == 4) {
        // Abort on any end group tag.
        return;
      }
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

  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SingleVote : pb::IMessage<SingleVote>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SingleVote> _parser = new pb::MessageParser<SingleVote>(() => new SingleVote());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SingleVote> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cardchain.Cardchain.VotingReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SingleVote() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SingleVote(SingleVote other) : this() {
      cardId_ = other.cardId_;
      voteType_ = other.voteType_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SingleVote Clone() {
      return new SingleVote(this);
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

    /// <summary>Field number for the "voteType" field.</summary>
    public const int VoteTypeFieldNumber = 2;
    private global::Cardchain.Cardchain.VoteType voteType_ = global::Cardchain.Cardchain.VoteType.FairEnough;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Cardchain.Cardchain.VoteType VoteType {
      get { return voteType_; }
      set {
        voteType_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SingleVote);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SingleVote other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CardId != other.CardId) return false;
      if (VoteType != other.VoteType) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (CardId != 0UL) hash ^= CardId.GetHashCode();
      if (VoteType != global::Cardchain.Cardchain.VoteType.FairEnough) hash ^= VoteType.GetHashCode();
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
      if (VoteType != global::Cardchain.Cardchain.VoteType.FairEnough) {
        output.WriteRawTag(16);
        output.WriteEnum((int) VoteType);
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
      if (VoteType != global::Cardchain.Cardchain.VoteType.FairEnough) {
        output.WriteRawTag(16);
        output.WriteEnum((int) VoteType);
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
      if (VoteType != global::Cardchain.Cardchain.VoteType.FairEnough) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) VoteType);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SingleVote other) {
      if (other == null) {
        return;
      }
      if (other.CardId != 0UL) {
        CardId = other.CardId;
      }
      if (other.VoteType != global::Cardchain.Cardchain.VoteType.FairEnough) {
        VoteType = other.VoteType;
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
          case 8: {
            CardId = input.ReadUInt64();
            break;
          }
          case 16: {
            VoteType = (global::Cardchain.Cardchain.VoteType) input.ReadEnum();
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
          case 8: {
            CardId = input.ReadUInt64();
            break;
          }
          case 16: {
            VoteType = (global::Cardchain.Cardchain.VoteType) input.ReadEnum();
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
