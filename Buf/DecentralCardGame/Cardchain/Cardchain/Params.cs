// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cardchain/cardchain/params.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace DecentralCardGame.Cardchain.Cardchain {

  /// <summary>Holder for reflection information generated from cardchain/cardchain/params.proto</summary>
  public static partial class ParamsReflection {

    #region Descriptor
    /// <summary>File descriptor for cardchain/cardchain/params.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ParamsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiBjYXJkY2hhaW4vY2FyZGNoYWluL3BhcmFtcy5wcm90bxIlRGVjZW50cmFs",
            "Q2FyZEdhbWUuY2FyZGNoYWluLmNhcmRjaGFpbhoUZ29nb3Byb3RvL2dvZ28u",
            "cHJvdG8iqgkKBlBhcmFtcxI+Chp2b3RpbmdSaWdodHNFeHBpcmF0aW9uVGlt",
            "ZRgBIAEoA1Iadm90aW5nUmlnaHRzRXhwaXJhdGlvblRpbWUSGAoHc2V0U2l6",
            "ZRgCIAEoBFIHc2V0U2l6ZRJLCghzZXRQcmljZRgDIAEoCUIvyN4fANreHydn",
            "aXRodWIuY29tL2Nvc21vcy9jb3Ntb3Mtc2RrL3R5cGVzLkNvaW5SCHNldFBy",
            "aWNlEioKEGFjdGl2ZVNldHNBbW91bnQYBCABKARSEGFjdGl2ZVNldHNBbW91",
            "bnQSVwoOc2V0Q3JlYXRpb25GZWUYBSABKAlCL8jeHwDa3h8nZ2l0aHViLmNv",
            "bS9jb3Ntb3MvY29zbW9zLXNkay90eXBlcy5Db2luUg5zZXRDcmVhdGlvbkZl",
            "ZRJdChFjb2xsYXRlcmFsRGVwb3NpdBgGIAEoCUIvyN4fANreHydnaXRodWIu",
            "Y29tL2Nvc21vcy9jb3Ntb3Mtc2RrL3R5cGVzLkNvaW5SEWNvbGxhdGVyYWxE",
            "ZXBvc2l0EiIKDHdpbm5lclJld2FyZBgHIAEoA1IMd2lubmVyUmV3YXJkElMK",
            "DGhvdXJseUZhdWNldBgJIAEoCUIvyN4fANreHydnaXRodWIuY29tL2Nvc21v",
            "cy9jb3Ntb3Mtc2RrL3R5cGVzLkNvaW5SDGhvdXJseUZhdWNldBIkCg1pbmZs",
            "YXRpb25SYXRlGAogASgJUg1pbmZsYXRpb25SYXRlEiIKDHJhcmVzUGVyUGFj",
            "axgLIAEoBFIMcmFyZXNQZXJQYWNrEiYKDmNvbW1vbnNQZXJQYWNrGAwgASgE",
            "Ug5jb21tb25zUGVyUGFjaxIqChB1bkNvbW1vbnNQZXJQYWNrGA0gASgEUhB1",
            "bkNvbW1vbnNQZXJQYWNrEiAKC3RyaWFsUGVyaW9kGA4gASgEUgt0cmlhbFBl",
            "cmlvZBIkCg1nYW1lVm90ZVJhdGlvGA8gASgDUg1nYW1lVm90ZVJhdGlvEkgK",
            "H2NhcmRBdWN0aW9uUHJpY2VSZWR1Y3Rpb25QZXJpb2QYECABKANSH2NhcmRB",
            "dWN0aW9uUHJpY2VSZWR1Y3Rpb25QZXJpb2QSUwoMYWlyRHJvcFZhbHVlGBEg",
            "ASgJQi/I3h8A2t4fJ2dpdGh1Yi5jb20vY29zbW9zL2Nvc21vcy1zZGsvdHlw",
            "ZXMuQ29pblIMYWlyRHJvcFZhbHVlEjQKFWFpckRyb3BNYXhCbG9ja0hlaWdo",
            "dBgSIAEoA1IVYWlyRHJvcE1heEJsb2NrSGVpZ2h0ElkKD3RyaWFsVm90ZVJl",
            "d2FyZBgTIAEoCUIvyN4fANreHydnaXRodWIuY29tL2Nvc21vcy9jb3Ntb3Mt",
            "c2RrL3R5cGVzLkNvaW5SD3RyaWFsVm90ZVJld2FyZBIqChB2b3RlUG9vbEZy",
            "YWN0aW9uGBQgASgDUhB2b3RlUG9vbEZyYWN0aW9uEigKD3ZvdGluZ1Jld2Fy",
            "ZENhcBgIIAEoA1IPdm90aW5nUmV3YXJkQ2FwEioKEG1hdGNoV29ya2VyRGVs",
            "YXkYFSABKARSEG1hdGNoV29ya2VyRGVsYXk6BJigHwBCqAIKKWNvbS5EZWNl",
            "bnRyYWxDYXJkR2FtZS5jYXJkY2hhaW4uY2FyZGNoYWluQgtQYXJhbXNQcm90",
            "b1ABWjhnaXRodWIuY29tL0RlY2VudHJhbENhcmRHYW1lL0NhcmRjaGFpbi94",
            "L2NhcmRjaGFpbi90eXBlc6ICA0RDQ6oCJURlY2VudHJhbENhcmRHYW1lLkNh",
            "cmRjaGFpbi5DYXJkY2hhaW7KAiVEZWNlbnRyYWxDYXJkR2FtZVxDYXJkY2hh",
            "aW5cQ2FyZGNoYWlu4gIxRGVjZW50cmFsQ2FyZEdhbWVcQ2FyZGNoYWluXENh",
            "cmRjaGFpblxHUEJNZXRhZGF0YeoCJ0RlY2VudHJhbENhcmRHYW1lOjpDYXJk",
            "Y2hhaW46OkNhcmRjaGFpbmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Gogoproto.GogoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::DecentralCardGame.Cardchain.Cardchain.Params), global::DecentralCardGame.Cardchain.Cardchain.Params.Parser, new[]{ "VotingRightsExpirationTime", "SetSize", "SetPrice", "ActiveSetsAmount", "SetCreationFee", "CollateralDeposit", "WinnerReward", "HourlyFaucet", "InflationRate", "RaresPerPack", "CommonsPerPack", "UnCommonsPerPack", "TrialPeriod", "GameVoteRatio", "CardAuctionPriceReductionPeriod", "AirDropValue", "AirDropMaxBlockHeight", "TrialVoteReward", "VotePoolFraction", "VotingRewardCap", "MatchWorkerDelay" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  /// <summary>
  /// Params defines the parameters for the module.
  /// </summary>
  public sealed partial class Params : pb::IMessage<Params>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Params> _parser = new pb::MessageParser<Params>(() => new Params());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<Params> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::DecentralCardGame.Cardchain.Cardchain.ParamsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Params() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Params(Params other) : this() {
      votingRightsExpirationTime_ = other.votingRightsExpirationTime_;
      setSize_ = other.setSize_;
      setPrice_ = other.setPrice_;
      activeSetsAmount_ = other.activeSetsAmount_;
      setCreationFee_ = other.setCreationFee_;
      collateralDeposit_ = other.collateralDeposit_;
      winnerReward_ = other.winnerReward_;
      hourlyFaucet_ = other.hourlyFaucet_;
      inflationRate_ = other.inflationRate_;
      raresPerPack_ = other.raresPerPack_;
      commonsPerPack_ = other.commonsPerPack_;
      unCommonsPerPack_ = other.unCommonsPerPack_;
      trialPeriod_ = other.trialPeriod_;
      gameVoteRatio_ = other.gameVoteRatio_;
      cardAuctionPriceReductionPeriod_ = other.cardAuctionPriceReductionPeriod_;
      airDropValue_ = other.airDropValue_;
      airDropMaxBlockHeight_ = other.airDropMaxBlockHeight_;
      trialVoteReward_ = other.trialVoteReward_;
      votePoolFraction_ = other.votePoolFraction_;
      votingRewardCap_ = other.votingRewardCap_;
      matchWorkerDelay_ = other.matchWorkerDelay_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public Params Clone() {
      return new Params(this);
    }

    /// <summary>Field number for the "votingRightsExpirationTime" field.</summary>
    public const int VotingRightsExpirationTimeFieldNumber = 1;
    private long votingRightsExpirationTime_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long VotingRightsExpirationTime {
      get { return votingRightsExpirationTime_; }
      set {
        votingRightsExpirationTime_ = value;
      }
    }

    /// <summary>Field number for the "setSize" field.</summary>
    public const int SetSizeFieldNumber = 2;
    private ulong setSize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong SetSize {
      get { return setSize_; }
      set {
        setSize_ = value;
      }
    }

    /// <summary>Field number for the "setPrice" field.</summary>
    public const int SetPriceFieldNumber = 3;
    private string setPrice_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SetPrice {
      get { return setPrice_; }
      set {
        setPrice_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "activeSetsAmount" field.</summary>
    public const int ActiveSetsAmountFieldNumber = 4;
    private ulong activeSetsAmount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ActiveSetsAmount {
      get { return activeSetsAmount_; }
      set {
        activeSetsAmount_ = value;
      }
    }

    /// <summary>Field number for the "setCreationFee" field.</summary>
    public const int SetCreationFeeFieldNumber = 5;
    private string setCreationFee_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string SetCreationFee {
      get { return setCreationFee_; }
      set {
        setCreationFee_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "collateralDeposit" field.</summary>
    public const int CollateralDepositFieldNumber = 6;
    private string collateralDeposit_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CollateralDeposit {
      get { return collateralDeposit_; }
      set {
        collateralDeposit_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "winnerReward" field.</summary>
    public const int WinnerRewardFieldNumber = 7;
    private long winnerReward_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long WinnerReward {
      get { return winnerReward_; }
      set {
        winnerReward_ = value;
      }
    }

    /// <summary>Field number for the "hourlyFaucet" field.</summary>
    public const int HourlyFaucetFieldNumber = 9;
    private string hourlyFaucet_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string HourlyFaucet {
      get { return hourlyFaucet_; }
      set {
        hourlyFaucet_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "inflationRate" field.</summary>
    public const int InflationRateFieldNumber = 10;
    private string inflationRate_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string InflationRate {
      get { return inflationRate_; }
      set {
        inflationRate_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "raresPerPack" field.</summary>
    public const int RaresPerPackFieldNumber = 11;
    private ulong raresPerPack_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong RaresPerPack {
      get { return raresPerPack_; }
      set {
        raresPerPack_ = value;
      }
    }

    /// <summary>Field number for the "commonsPerPack" field.</summary>
    public const int CommonsPerPackFieldNumber = 12;
    private ulong commonsPerPack_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong CommonsPerPack {
      get { return commonsPerPack_; }
      set {
        commonsPerPack_ = value;
      }
    }

    /// <summary>Field number for the "unCommonsPerPack" field.</summary>
    public const int UnCommonsPerPackFieldNumber = 13;
    private ulong unCommonsPerPack_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong UnCommonsPerPack {
      get { return unCommonsPerPack_; }
      set {
        unCommonsPerPack_ = value;
      }
    }

    /// <summary>Field number for the "trialPeriod" field.</summary>
    public const int TrialPeriodFieldNumber = 14;
    private ulong trialPeriod_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong TrialPeriod {
      get { return trialPeriod_; }
      set {
        trialPeriod_ = value;
      }
    }

    /// <summary>Field number for the "gameVoteRatio" field.</summary>
    public const int GameVoteRatioFieldNumber = 15;
    private long gameVoteRatio_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long GameVoteRatio {
      get { return gameVoteRatio_; }
      set {
        gameVoteRatio_ = value;
      }
    }

    /// <summary>Field number for the "cardAuctionPriceReductionPeriod" field.</summary>
    public const int CardAuctionPriceReductionPeriodFieldNumber = 16;
    private long cardAuctionPriceReductionPeriod_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long CardAuctionPriceReductionPeriod {
      get { return cardAuctionPriceReductionPeriod_; }
      set {
        cardAuctionPriceReductionPeriod_ = value;
      }
    }

    /// <summary>Field number for the "airDropValue" field.</summary>
    public const int AirDropValueFieldNumber = 17;
    private string airDropValue_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string AirDropValue {
      get { return airDropValue_; }
      set {
        airDropValue_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "airDropMaxBlockHeight" field.</summary>
    public const int AirDropMaxBlockHeightFieldNumber = 18;
    private long airDropMaxBlockHeight_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long AirDropMaxBlockHeight {
      get { return airDropMaxBlockHeight_; }
      set {
        airDropMaxBlockHeight_ = value;
      }
    }

    /// <summary>Field number for the "trialVoteReward" field.</summary>
    public const int TrialVoteRewardFieldNumber = 19;
    private string trialVoteReward_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string TrialVoteReward {
      get { return trialVoteReward_; }
      set {
        trialVoteReward_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "votePoolFraction" field.</summary>
    public const int VotePoolFractionFieldNumber = 20;
    private long votePoolFraction_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long VotePoolFraction {
      get { return votePoolFraction_; }
      set {
        votePoolFraction_ = value;
      }
    }

    /// <summary>Field number for the "votingRewardCap" field.</summary>
    public const int VotingRewardCapFieldNumber = 8;
    private long votingRewardCap_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public long VotingRewardCap {
      get { return votingRewardCap_; }
      set {
        votingRewardCap_ = value;
      }
    }

    /// <summary>Field number for the "matchWorkerDelay" field.</summary>
    public const int MatchWorkerDelayFieldNumber = 21;
    private ulong matchWorkerDelay_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong MatchWorkerDelay {
      get { return matchWorkerDelay_; }
      set {
        matchWorkerDelay_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as Params);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(Params other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (VotingRightsExpirationTime != other.VotingRightsExpirationTime) return false;
      if (SetSize != other.SetSize) return false;
      if (SetPrice != other.SetPrice) return false;
      if (ActiveSetsAmount != other.ActiveSetsAmount) return false;
      if (SetCreationFee != other.SetCreationFee) return false;
      if (CollateralDeposit != other.CollateralDeposit) return false;
      if (WinnerReward != other.WinnerReward) return false;
      if (HourlyFaucet != other.HourlyFaucet) return false;
      if (InflationRate != other.InflationRate) return false;
      if (RaresPerPack != other.RaresPerPack) return false;
      if (CommonsPerPack != other.CommonsPerPack) return false;
      if (UnCommonsPerPack != other.UnCommonsPerPack) return false;
      if (TrialPeriod != other.TrialPeriod) return false;
      if (GameVoteRatio != other.GameVoteRatio) return false;
      if (CardAuctionPriceReductionPeriod != other.CardAuctionPriceReductionPeriod) return false;
      if (AirDropValue != other.AirDropValue) return false;
      if (AirDropMaxBlockHeight != other.AirDropMaxBlockHeight) return false;
      if (TrialVoteReward != other.TrialVoteReward) return false;
      if (VotePoolFraction != other.VotePoolFraction) return false;
      if (VotingRewardCap != other.VotingRewardCap) return false;
      if (MatchWorkerDelay != other.MatchWorkerDelay) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (VotingRightsExpirationTime != 0L) hash ^= VotingRightsExpirationTime.GetHashCode();
      if (SetSize != 0UL) hash ^= SetSize.GetHashCode();
      if (SetPrice.Length != 0) hash ^= SetPrice.GetHashCode();
      if (ActiveSetsAmount != 0UL) hash ^= ActiveSetsAmount.GetHashCode();
      if (SetCreationFee.Length != 0) hash ^= SetCreationFee.GetHashCode();
      if (CollateralDeposit.Length != 0) hash ^= CollateralDeposit.GetHashCode();
      if (WinnerReward != 0L) hash ^= WinnerReward.GetHashCode();
      if (HourlyFaucet.Length != 0) hash ^= HourlyFaucet.GetHashCode();
      if (InflationRate.Length != 0) hash ^= InflationRate.GetHashCode();
      if (RaresPerPack != 0UL) hash ^= RaresPerPack.GetHashCode();
      if (CommonsPerPack != 0UL) hash ^= CommonsPerPack.GetHashCode();
      if (UnCommonsPerPack != 0UL) hash ^= UnCommonsPerPack.GetHashCode();
      if (TrialPeriod != 0UL) hash ^= TrialPeriod.GetHashCode();
      if (GameVoteRatio != 0L) hash ^= GameVoteRatio.GetHashCode();
      if (CardAuctionPriceReductionPeriod != 0L) hash ^= CardAuctionPriceReductionPeriod.GetHashCode();
      if (AirDropValue.Length != 0) hash ^= AirDropValue.GetHashCode();
      if (AirDropMaxBlockHeight != 0L) hash ^= AirDropMaxBlockHeight.GetHashCode();
      if (TrialVoteReward.Length != 0) hash ^= TrialVoteReward.GetHashCode();
      if (VotePoolFraction != 0L) hash ^= VotePoolFraction.GetHashCode();
      if (VotingRewardCap != 0L) hash ^= VotingRewardCap.GetHashCode();
      if (MatchWorkerDelay != 0UL) hash ^= MatchWorkerDelay.GetHashCode();
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
      if (VotingRightsExpirationTime != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(VotingRightsExpirationTime);
      }
      if (SetSize != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(SetSize);
      }
      if (SetPrice.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SetPrice);
      }
      if (ActiveSetsAmount != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(ActiveSetsAmount);
      }
      if (SetCreationFee.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(SetCreationFee);
      }
      if (CollateralDeposit.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(CollateralDeposit);
      }
      if (WinnerReward != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(WinnerReward);
      }
      if (VotingRewardCap != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(VotingRewardCap);
      }
      if (HourlyFaucet.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(HourlyFaucet);
      }
      if (InflationRate.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(InflationRate);
      }
      if (RaresPerPack != 0UL) {
        output.WriteRawTag(88);
        output.WriteUInt64(RaresPerPack);
      }
      if (CommonsPerPack != 0UL) {
        output.WriteRawTag(96);
        output.WriteUInt64(CommonsPerPack);
      }
      if (UnCommonsPerPack != 0UL) {
        output.WriteRawTag(104);
        output.WriteUInt64(UnCommonsPerPack);
      }
      if (TrialPeriod != 0UL) {
        output.WriteRawTag(112);
        output.WriteUInt64(TrialPeriod);
      }
      if (GameVoteRatio != 0L) {
        output.WriteRawTag(120);
        output.WriteInt64(GameVoteRatio);
      }
      if (CardAuctionPriceReductionPeriod != 0L) {
        output.WriteRawTag(128, 1);
        output.WriteInt64(CardAuctionPriceReductionPeriod);
      }
      if (AirDropValue.Length != 0) {
        output.WriteRawTag(138, 1);
        output.WriteString(AirDropValue);
      }
      if (AirDropMaxBlockHeight != 0L) {
        output.WriteRawTag(144, 1);
        output.WriteInt64(AirDropMaxBlockHeight);
      }
      if (TrialVoteReward.Length != 0) {
        output.WriteRawTag(154, 1);
        output.WriteString(TrialVoteReward);
      }
      if (VotePoolFraction != 0L) {
        output.WriteRawTag(160, 1);
        output.WriteInt64(VotePoolFraction);
      }
      if (MatchWorkerDelay != 0UL) {
        output.WriteRawTag(168, 1);
        output.WriteUInt64(MatchWorkerDelay);
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
      if (VotingRightsExpirationTime != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(VotingRightsExpirationTime);
      }
      if (SetSize != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(SetSize);
      }
      if (SetPrice.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(SetPrice);
      }
      if (ActiveSetsAmount != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(ActiveSetsAmount);
      }
      if (SetCreationFee.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(SetCreationFee);
      }
      if (CollateralDeposit.Length != 0) {
        output.WriteRawTag(50);
        output.WriteString(CollateralDeposit);
      }
      if (WinnerReward != 0L) {
        output.WriteRawTag(56);
        output.WriteInt64(WinnerReward);
      }
      if (VotingRewardCap != 0L) {
        output.WriteRawTag(64);
        output.WriteInt64(VotingRewardCap);
      }
      if (HourlyFaucet.Length != 0) {
        output.WriteRawTag(74);
        output.WriteString(HourlyFaucet);
      }
      if (InflationRate.Length != 0) {
        output.WriteRawTag(82);
        output.WriteString(InflationRate);
      }
      if (RaresPerPack != 0UL) {
        output.WriteRawTag(88);
        output.WriteUInt64(RaresPerPack);
      }
      if (CommonsPerPack != 0UL) {
        output.WriteRawTag(96);
        output.WriteUInt64(CommonsPerPack);
      }
      if (UnCommonsPerPack != 0UL) {
        output.WriteRawTag(104);
        output.WriteUInt64(UnCommonsPerPack);
      }
      if (TrialPeriod != 0UL) {
        output.WriteRawTag(112);
        output.WriteUInt64(TrialPeriod);
      }
      if (GameVoteRatio != 0L) {
        output.WriteRawTag(120);
        output.WriteInt64(GameVoteRatio);
      }
      if (CardAuctionPriceReductionPeriod != 0L) {
        output.WriteRawTag(128, 1);
        output.WriteInt64(CardAuctionPriceReductionPeriod);
      }
      if (AirDropValue.Length != 0) {
        output.WriteRawTag(138, 1);
        output.WriteString(AirDropValue);
      }
      if (AirDropMaxBlockHeight != 0L) {
        output.WriteRawTag(144, 1);
        output.WriteInt64(AirDropMaxBlockHeight);
      }
      if (TrialVoteReward.Length != 0) {
        output.WriteRawTag(154, 1);
        output.WriteString(TrialVoteReward);
      }
      if (VotePoolFraction != 0L) {
        output.WriteRawTag(160, 1);
        output.WriteInt64(VotePoolFraction);
      }
      if (MatchWorkerDelay != 0UL) {
        output.WriteRawTag(168, 1);
        output.WriteUInt64(MatchWorkerDelay);
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
      if (VotingRightsExpirationTime != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(VotingRightsExpirationTime);
      }
      if (SetSize != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(SetSize);
      }
      if (SetPrice.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SetPrice);
      }
      if (ActiveSetsAmount != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ActiveSetsAmount);
      }
      if (SetCreationFee.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(SetCreationFee);
      }
      if (CollateralDeposit.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CollateralDeposit);
      }
      if (WinnerReward != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(WinnerReward);
      }
      if (HourlyFaucet.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(HourlyFaucet);
      }
      if (InflationRate.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(InflationRate);
      }
      if (RaresPerPack != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(RaresPerPack);
      }
      if (CommonsPerPack != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(CommonsPerPack);
      }
      if (UnCommonsPerPack != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(UnCommonsPerPack);
      }
      if (TrialPeriod != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(TrialPeriod);
      }
      if (GameVoteRatio != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(GameVoteRatio);
      }
      if (CardAuctionPriceReductionPeriod != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(CardAuctionPriceReductionPeriod);
      }
      if (AirDropValue.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(AirDropValue);
      }
      if (AirDropMaxBlockHeight != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(AirDropMaxBlockHeight);
      }
      if (TrialVoteReward.Length != 0) {
        size += 2 + pb::CodedOutputStream.ComputeStringSize(TrialVoteReward);
      }
      if (VotePoolFraction != 0L) {
        size += 2 + pb::CodedOutputStream.ComputeInt64Size(VotePoolFraction);
      }
      if (VotingRewardCap != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(VotingRewardCap);
      }
      if (MatchWorkerDelay != 0UL) {
        size += 2 + pb::CodedOutputStream.ComputeUInt64Size(MatchWorkerDelay);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(Params other) {
      if (other == null) {
        return;
      }
      if (other.VotingRightsExpirationTime != 0L) {
        VotingRightsExpirationTime = other.VotingRightsExpirationTime;
      }
      if (other.SetSize != 0UL) {
        SetSize = other.SetSize;
      }
      if (other.SetPrice.Length != 0) {
        SetPrice = other.SetPrice;
      }
      if (other.ActiveSetsAmount != 0UL) {
        ActiveSetsAmount = other.ActiveSetsAmount;
      }
      if (other.SetCreationFee.Length != 0) {
        SetCreationFee = other.SetCreationFee;
      }
      if (other.CollateralDeposit.Length != 0) {
        CollateralDeposit = other.CollateralDeposit;
      }
      if (other.WinnerReward != 0L) {
        WinnerReward = other.WinnerReward;
      }
      if (other.HourlyFaucet.Length != 0) {
        HourlyFaucet = other.HourlyFaucet;
      }
      if (other.InflationRate.Length != 0) {
        InflationRate = other.InflationRate;
      }
      if (other.RaresPerPack != 0UL) {
        RaresPerPack = other.RaresPerPack;
      }
      if (other.CommonsPerPack != 0UL) {
        CommonsPerPack = other.CommonsPerPack;
      }
      if (other.UnCommonsPerPack != 0UL) {
        UnCommonsPerPack = other.UnCommonsPerPack;
      }
      if (other.TrialPeriod != 0UL) {
        TrialPeriod = other.TrialPeriod;
      }
      if (other.GameVoteRatio != 0L) {
        GameVoteRatio = other.GameVoteRatio;
      }
      if (other.CardAuctionPriceReductionPeriod != 0L) {
        CardAuctionPriceReductionPeriod = other.CardAuctionPriceReductionPeriod;
      }
      if (other.AirDropValue.Length != 0) {
        AirDropValue = other.AirDropValue;
      }
      if (other.AirDropMaxBlockHeight != 0L) {
        AirDropMaxBlockHeight = other.AirDropMaxBlockHeight;
      }
      if (other.TrialVoteReward.Length != 0) {
        TrialVoteReward = other.TrialVoteReward;
      }
      if (other.VotePoolFraction != 0L) {
        VotePoolFraction = other.VotePoolFraction;
      }
      if (other.VotingRewardCap != 0L) {
        VotingRewardCap = other.VotingRewardCap;
      }
      if (other.MatchWorkerDelay != 0UL) {
        MatchWorkerDelay = other.MatchWorkerDelay;
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
            VotingRightsExpirationTime = input.ReadInt64();
            break;
          }
          case 16: {
            SetSize = input.ReadUInt64();
            break;
          }
          case 26: {
            SetPrice = input.ReadString();
            break;
          }
          case 32: {
            ActiveSetsAmount = input.ReadUInt64();
            break;
          }
          case 42: {
            SetCreationFee = input.ReadString();
            break;
          }
          case 50: {
            CollateralDeposit = input.ReadString();
            break;
          }
          case 56: {
            WinnerReward = input.ReadInt64();
            break;
          }
          case 64: {
            VotingRewardCap = input.ReadInt64();
            break;
          }
          case 74: {
            HourlyFaucet = input.ReadString();
            break;
          }
          case 82: {
            InflationRate = input.ReadString();
            break;
          }
          case 88: {
            RaresPerPack = input.ReadUInt64();
            break;
          }
          case 96: {
            CommonsPerPack = input.ReadUInt64();
            break;
          }
          case 104: {
            UnCommonsPerPack = input.ReadUInt64();
            break;
          }
          case 112: {
            TrialPeriod = input.ReadUInt64();
            break;
          }
          case 120: {
            GameVoteRatio = input.ReadInt64();
            break;
          }
          case 128: {
            CardAuctionPriceReductionPeriod = input.ReadInt64();
            break;
          }
          case 138: {
            AirDropValue = input.ReadString();
            break;
          }
          case 144: {
            AirDropMaxBlockHeight = input.ReadInt64();
            break;
          }
          case 154: {
            TrialVoteReward = input.ReadString();
            break;
          }
          case 160: {
            VotePoolFraction = input.ReadInt64();
            break;
          }
          case 168: {
            MatchWorkerDelay = input.ReadUInt64();
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
            VotingRightsExpirationTime = input.ReadInt64();
            break;
          }
          case 16: {
            SetSize = input.ReadUInt64();
            break;
          }
          case 26: {
            SetPrice = input.ReadString();
            break;
          }
          case 32: {
            ActiveSetsAmount = input.ReadUInt64();
            break;
          }
          case 42: {
            SetCreationFee = input.ReadString();
            break;
          }
          case 50: {
            CollateralDeposit = input.ReadString();
            break;
          }
          case 56: {
            WinnerReward = input.ReadInt64();
            break;
          }
          case 64: {
            VotingRewardCap = input.ReadInt64();
            break;
          }
          case 74: {
            HourlyFaucet = input.ReadString();
            break;
          }
          case 82: {
            InflationRate = input.ReadString();
            break;
          }
          case 88: {
            RaresPerPack = input.ReadUInt64();
            break;
          }
          case 96: {
            CommonsPerPack = input.ReadUInt64();
            break;
          }
          case 104: {
            UnCommonsPerPack = input.ReadUInt64();
            break;
          }
          case 112: {
            TrialPeriod = input.ReadUInt64();
            break;
          }
          case 120: {
            GameVoteRatio = input.ReadInt64();
            break;
          }
          case 128: {
            CardAuctionPriceReductionPeriod = input.ReadInt64();
            break;
          }
          case 138: {
            AirDropValue = input.ReadString();
            break;
          }
          case 144: {
            AirDropMaxBlockHeight = input.ReadInt64();
            break;
          }
          case 154: {
            TrialVoteReward = input.ReadString();
            break;
          }
          case 160: {
            VotePoolFraction = input.ReadInt64();
            break;
          }
          case 168: {
            MatchWorkerDelay = input.ReadUInt64();
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
