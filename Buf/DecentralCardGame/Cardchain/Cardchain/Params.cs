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
            "cHJvdG8i4gkKBlBhcmFtcxI+Chp2b3RpbmdSaWdodHNFeHBpcmF0aW9uVGlt",
            "ZRgBIAEoA1Iadm90aW5nUmlnaHRzRXhwaXJhdGlvblRpbWUSJgoOY29sbGVj",
            "dGlvblNpemUYAiABKARSDmNvbGxlY3Rpb25TaXplElkKD2NvbGxlY3Rpb25Q",
            "cmljZRgDIAEoCUIvyN4fANreHydnaXRodWIuY29tL2Nvc21vcy9jb3Ntb3Mt",
            "c2RrL3R5cGVzLkNvaW5SD2NvbGxlY3Rpb25QcmljZRI4ChdhY3RpdmVDb2xs",
            "ZWN0aW9uc0Ftb3VudBgEIAEoBFIXYWN0aXZlQ29sbGVjdGlvbnNBbW91bnQS",
            "ZQoVY29sbGVjdGlvbkNyZWF0aW9uRmVlGAUgASgJQi/I3h8A2t4fJ2dpdGh1",
            "Yi5jb20vY29zbW9zL2Nvc21vcy1zZGsvdHlwZXMuQ29pblIVY29sbGVjdGlv",
            "bkNyZWF0aW9uRmVlEl0KEWNvbGxhdGVyYWxEZXBvc2l0GAYgASgJQi/I3h8A",
            "2t4fJ2dpdGh1Yi5jb20vY29zbW9zL2Nvc21vcy1zZGsvdHlwZXMuQ29pblIR",
            "Y29sbGF0ZXJhbERlcG9zaXQSIgoMd2lubmVyUmV3YXJkGAcgASgDUgx3aW5u",
            "ZXJSZXdhcmQSUwoMaG91cmx5RmF1Y2V0GAkgASgJQi/I3h8A2t4fJ2dpdGh1",
            "Yi5jb20vY29zbW9zL2Nvc21vcy1zZGsvdHlwZXMuQ29pblIMaG91cmx5RmF1",
            "Y2V0EiQKDWluZmxhdGlvblJhdGUYCiABKAlSDWluZmxhdGlvblJhdGUSIgoM",
            "cmFyZXNQZXJQYWNrGAsgASgEUgxyYXJlc1BlclBhY2sSJgoOY29tbW9uc1Bl",
            "clBhY2sYDCABKARSDmNvbW1vbnNQZXJQYWNrEioKEHVuQ29tbW9uc1BlclBh",
            "Y2sYDSABKARSEHVuQ29tbW9uc1BlclBhY2sSIAoLdHJpYWxQZXJpb2QYDiAB",
            "KARSC3RyaWFsUGVyaW9kEiQKDWdhbWVWb3RlUmF0aW8YDyABKANSDWdhbWVW",
            "b3RlUmF0aW8SSAofY2FyZEF1Y3Rpb25QcmljZVJlZHVjdGlvblBlcmlvZBgQ",
            "IAEoA1IfY2FyZEF1Y3Rpb25QcmljZVJlZHVjdGlvblBlcmlvZBJTCgxhaXJE",
            "cm9wVmFsdWUYESABKAlCL8jeHwDa3h8nZ2l0aHViLmNvbS9jb3Ntb3MvY29z",
            "bW9zLXNkay90eXBlcy5Db2luUgxhaXJEcm9wVmFsdWUSNAoVYWlyRHJvcE1h",
            "eEJsb2NrSGVpZ2h0GBIgASgDUhVhaXJEcm9wTWF4QmxvY2tIZWlnaHQSWQoP",
            "dHJpYWxWb3RlUmV3YXJkGBMgASgJQi/I3h8A2t4fJ2dpdGh1Yi5jb20vY29z",
            "bW9zL2Nvc21vcy1zZGsvdHlwZXMuQ29pblIPdHJpYWxWb3RlUmV3YXJkEioK",
            "EHZvdGVQb29sRnJhY3Rpb24YFCABKANSEHZvdGVQb29sRnJhY3Rpb24SKAoP",
            "dm90aW5nUmV3YXJkQ2FwGAggASgDUg92b3RpbmdSZXdhcmRDYXASKgoQbWF0",
            "Y2hXb3JrZXJEZWxheRgVIAEoBFIQbWF0Y2hXb3JrZXJEZWxheToEmKAfAEKo",
            "AgopY29tLkRlY2VudHJhbENhcmRHYW1lLmNhcmRjaGFpbi5jYXJkY2hhaW5C",
            "C1BhcmFtc1Byb3RvUAFaOGdpdGh1Yi5jb20vRGVjZW50cmFsQ2FyZEdhbWUv",
            "Q2FyZGNoYWluL3gvY2FyZGNoYWluL3R5cGVzogIDRENDqgIlRGVjZW50cmFs",
            "Q2FyZEdhbWUuQ2FyZGNoYWluLkNhcmRjaGFpbsoCJURlY2VudHJhbENhcmRH",
            "YW1lXENhcmRjaGFpblxDYXJkY2hhaW7iAjFEZWNlbnRyYWxDYXJkR2FtZVxD",
            "YXJkY2hhaW5cQ2FyZGNoYWluXEdQQk1ldGFkYXRh6gInRGVjZW50cmFsQ2Fy",
            "ZEdhbWU6OkNhcmRjaGFpbjo6Q2FyZGNoYWluYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Gogoproto.GogoReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::DecentralCardGame.Cardchain.Cardchain.Params), global::DecentralCardGame.Cardchain.Cardchain.Params.Parser, new[]{ "VotingRightsExpirationTime", "CollectionSize", "CollectionPrice", "ActiveCollectionsAmount", "CollectionCreationFee", "CollateralDeposit", "WinnerReward", "HourlyFaucet", "InflationRate", "RaresPerPack", "CommonsPerPack", "UnCommonsPerPack", "TrialPeriod", "GameVoteRatio", "CardAuctionPriceReductionPeriod", "AirDropValue", "AirDropMaxBlockHeight", "TrialVoteReward", "VotePoolFraction", "VotingRewardCap", "MatchWorkerDelay" }, null, null, null, null)
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
      collectionSize_ = other.collectionSize_;
      collectionPrice_ = other.collectionPrice_;
      activeCollectionsAmount_ = other.activeCollectionsAmount_;
      collectionCreationFee_ = other.collectionCreationFee_;
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

    /// <summary>Field number for the "collectionSize" field.</summary>
    public const int CollectionSizeFieldNumber = 2;
    private ulong collectionSize_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong CollectionSize {
      get { return collectionSize_; }
      set {
        collectionSize_ = value;
      }
    }

    /// <summary>Field number for the "collectionPrice" field.</summary>
    public const int CollectionPriceFieldNumber = 3;
    private string collectionPrice_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CollectionPrice {
      get { return collectionPrice_; }
      set {
        collectionPrice_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "activeCollectionsAmount" field.</summary>
    public const int ActiveCollectionsAmountFieldNumber = 4;
    private ulong activeCollectionsAmount_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong ActiveCollectionsAmount {
      get { return activeCollectionsAmount_; }
      set {
        activeCollectionsAmount_ = value;
      }
    }

    /// <summary>Field number for the "collectionCreationFee" field.</summary>
    public const int CollectionCreationFeeFieldNumber = 5;
    private string collectionCreationFee_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string CollectionCreationFee {
      get { return collectionCreationFee_; }
      set {
        collectionCreationFee_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
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
      if (CollectionSize != other.CollectionSize) return false;
      if (CollectionPrice != other.CollectionPrice) return false;
      if (ActiveCollectionsAmount != other.ActiveCollectionsAmount) return false;
      if (CollectionCreationFee != other.CollectionCreationFee) return false;
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
      if (CollectionSize != 0UL) hash ^= CollectionSize.GetHashCode();
      if (CollectionPrice.Length != 0) hash ^= CollectionPrice.GetHashCode();
      if (ActiveCollectionsAmount != 0UL) hash ^= ActiveCollectionsAmount.GetHashCode();
      if (CollectionCreationFee.Length != 0) hash ^= CollectionCreationFee.GetHashCode();
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
      if (CollectionSize != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(CollectionSize);
      }
      if (CollectionPrice.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CollectionPrice);
      }
      if (ActiveCollectionsAmount != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(ActiveCollectionsAmount);
      }
      if (CollectionCreationFee.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(CollectionCreationFee);
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
      if (CollectionSize != 0UL) {
        output.WriteRawTag(16);
        output.WriteUInt64(CollectionSize);
      }
      if (CollectionPrice.Length != 0) {
        output.WriteRawTag(26);
        output.WriteString(CollectionPrice);
      }
      if (ActiveCollectionsAmount != 0UL) {
        output.WriteRawTag(32);
        output.WriteUInt64(ActiveCollectionsAmount);
      }
      if (CollectionCreationFee.Length != 0) {
        output.WriteRawTag(42);
        output.WriteString(CollectionCreationFee);
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
      if (CollectionSize != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(CollectionSize);
      }
      if (CollectionPrice.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CollectionPrice);
      }
      if (ActiveCollectionsAmount != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(ActiveCollectionsAmount);
      }
      if (CollectionCreationFee.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(CollectionCreationFee);
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
      if (other.CollectionSize != 0UL) {
        CollectionSize = other.CollectionSize;
      }
      if (other.CollectionPrice.Length != 0) {
        CollectionPrice = other.CollectionPrice;
      }
      if (other.ActiveCollectionsAmount != 0UL) {
        ActiveCollectionsAmount = other.ActiveCollectionsAmount;
      }
      if (other.CollectionCreationFee.Length != 0) {
        CollectionCreationFee = other.CollectionCreationFee;
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
            CollectionSize = input.ReadUInt64();
            break;
          }
          case 26: {
            CollectionPrice = input.ReadString();
            break;
          }
          case 32: {
            ActiveCollectionsAmount = input.ReadUInt64();
            break;
          }
          case 42: {
            CollectionCreationFee = input.ReadString();
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
            CollectionSize = input.ReadUInt64();
            break;
          }
          case 26: {
            CollectionPrice = input.ReadString();
            break;
          }
          case 32: {
            ActiveCollectionsAmount = input.ReadUInt64();
            break;
          }
          case 42: {
            CollectionCreationFee = input.ReadString();
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