// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: cardchain/cardchain/sell_offer.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021, 8981
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace Cardchain.Cardchain {

  /// <summary>Holder for reflection information generated from cardchain/cardchain/sell_offer.proto</summary>
  public static partial class SellOfferReflection {

    #region Descriptor
    /// <summary>File descriptor for cardchain/cardchain/sell_offer.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static SellOfferReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiRjYXJkY2hhaW4vY2FyZGNoYWluL3NlbGxfb2ZmZXIucHJvdG8SE2NhcmRj",
            "aGFpbi5jYXJkY2hhaW4aFGdvZ29wcm90by9nb2dvLnByb3RvGh5jb3Ntb3Mv",
            "YmFzZS92MWJldGExL2NvaW4ucHJvdG8iwgEKCVNlbGxPZmZlchIWCgZzZWxs",
            "ZXIYASABKAlSBnNlbGxlchIUCgVidXllchgCIAEoCVIFYnV5ZXISEgoEY2Fy",
            "ZBgDIAEoBFIEY2FyZBI1CgVwcmljZRgEIAEoCzIZLmNvc21vcy5iYXNlLnYx",
            "YmV0YTEuQ29pbkIEyN4fAFIFcHJpY2USPAoGc3RhdHVzGAUgASgOMiQuY2Fy",
            "ZGNoYWluLmNhcmRjaGFpbi5TZWxsT2ZmZXJTdGF0dXNSBnN0YXR1cyo9Cg9T",
            "ZWxsT2ZmZXJTdGF0dXMSCQoFZW1wdHkQABIICgRvcGVuEAESCAoEc29sZBAC",
            "EgsKB3JlbW92ZWQQA0LSAQoXY29tLmNhcmRjaGFpbi5jYXJkY2hhaW5CDlNl",
            "bGxPZmZlclByb3RvUAFaOmdpdGh1Yi5jb20vRGVjZW50cmFsQ2FyZGdhbWUv",
            "Y2FyZGNoYWluL2NhcmRjaGFpbi9jYXJkY2hhaW6iAgNDQ1iqAhNDYXJkY2hh",
            "aW4uQ2FyZGNoYWluygITQ2FyZGNoYWluXENhcmRjaGFpbuICH0NhcmRjaGFp",
            "blxDYXJkY2hhaW5cR1BCTWV0YWRhdGHqAhRDYXJkY2hhaW46OkNhcmRjaGFp",
            "bmIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::Gogoproto.GogoReflection.Descriptor, global::Cosmos.Base.V1beta1.CoinReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::Cardchain.Cardchain.SellOfferStatus), }, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::Cardchain.Cardchain.SellOffer), global::Cardchain.Cardchain.SellOffer.Parser, new[]{ "Seller", "Buyer", "Card", "Price", "Status" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Enums
  public enum SellOfferStatus {
    [pbr::OriginalName("empty")] Empty = 0,
    [pbr::OriginalName("open")] Open = 1,
    [pbr::OriginalName("sold")] Sold = 2,
    [pbr::OriginalName("removed")] Removed = 3,
  }

  #endregion

  #region Messages
  [global::System.Diagnostics.DebuggerDisplayAttribute("{ToString(),nq}")]
  public sealed partial class SellOffer : pb::IMessage<SellOffer>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<SellOffer> _parser = new pb::MessageParser<SellOffer>(() => new SellOffer());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pb::MessageParser<SellOffer> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::Cardchain.Cardchain.SellOfferReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SellOffer() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SellOffer(SellOffer other) : this() {
      seller_ = other.seller_;
      buyer_ = other.buyer_;
      card_ = other.card_;
      price_ = other.price_ != null ? other.price_.Clone() : null;
      status_ = other.status_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public SellOffer Clone() {
      return new SellOffer(this);
    }

    /// <summary>Field number for the "seller" field.</summary>
    public const int SellerFieldNumber = 1;
    private string seller_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Seller {
      get { return seller_; }
      set {
        seller_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "buyer" field.</summary>
    public const int BuyerFieldNumber = 2;
    private string buyer_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public string Buyer {
      get { return buyer_; }
      set {
        buyer_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "card" field.</summary>
    public const int CardFieldNumber = 3;
    private ulong card_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public ulong Card {
      get { return card_; }
      set {
        card_ = value;
      }
    }

    /// <summary>Field number for the "price" field.</summary>
    public const int PriceFieldNumber = 4;
    private global::Cosmos.Base.V1beta1.Coin price_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Cosmos.Base.V1beta1.Coin Price {
      get { return price_; }
      set {
        price_ = value;
      }
    }

    /// <summary>Field number for the "status" field.</summary>
    public const int StatusFieldNumber = 5;
    private global::Cardchain.Cardchain.SellOfferStatus status_ = global::Cardchain.Cardchain.SellOfferStatus.Empty;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public global::Cardchain.Cardchain.SellOfferStatus Status {
      get { return status_; }
      set {
        status_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override bool Equals(object other) {
      return Equals(other as SellOffer);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public bool Equals(SellOffer other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Seller != other.Seller) return false;
      if (Buyer != other.Buyer) return false;
      if (Card != other.Card) return false;
      if (!object.Equals(Price, other.Price)) return false;
      if (Status != other.Status) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public override int GetHashCode() {
      int hash = 1;
      if (Seller.Length != 0) hash ^= Seller.GetHashCode();
      if (Buyer.Length != 0) hash ^= Buyer.GetHashCode();
      if (Card != 0UL) hash ^= Card.GetHashCode();
      if (price_ != null) hash ^= Price.GetHashCode();
      if (Status != global::Cardchain.Cardchain.SellOfferStatus.Empty) hash ^= Status.GetHashCode();
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
      if (Seller.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Seller);
      }
      if (Buyer.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Buyer);
      }
      if (Card != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Card);
      }
      if (price_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Price);
      }
      if (Status != global::Cardchain.Cardchain.SellOfferStatus.Empty) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
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
      if (Seller.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Seller);
      }
      if (Buyer.Length != 0) {
        output.WriteRawTag(18);
        output.WriteString(Buyer);
      }
      if (Card != 0UL) {
        output.WriteRawTag(24);
        output.WriteUInt64(Card);
      }
      if (price_ != null) {
        output.WriteRawTag(34);
        output.WriteMessage(Price);
      }
      if (Status != global::Cardchain.Cardchain.SellOfferStatus.Empty) {
        output.WriteRawTag(40);
        output.WriteEnum((int) Status);
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
      if (Seller.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Seller);
      }
      if (Buyer.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Buyer);
      }
      if (Card != 0UL) {
        size += 1 + pb::CodedOutputStream.ComputeUInt64Size(Card);
      }
      if (price_ != null) {
        size += 1 + pb::CodedOutputStream.ComputeMessageSize(Price);
      }
      if (Status != global::Cardchain.Cardchain.SellOfferStatus.Empty) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) Status);
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    [global::System.CodeDom.Compiler.GeneratedCode("protoc", null)]
    public void MergeFrom(SellOffer other) {
      if (other == null) {
        return;
      }
      if (other.Seller.Length != 0) {
        Seller = other.Seller;
      }
      if (other.Buyer.Length != 0) {
        Buyer = other.Buyer;
      }
      if (other.Card != 0UL) {
        Card = other.Card;
      }
      if (other.price_ != null) {
        if (price_ == null) {
          Price = new global::Cosmos.Base.V1beta1.Coin();
        }
        Price.MergeFrom(other.Price);
      }
      if (other.Status != global::Cardchain.Cardchain.SellOfferStatus.Empty) {
        Status = other.Status;
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
            Seller = input.ReadString();
            break;
          }
          case 18: {
            Buyer = input.ReadString();
            break;
          }
          case 24: {
            Card = input.ReadUInt64();
            break;
          }
          case 34: {
            if (price_ == null) {
              Price = new global::Cosmos.Base.V1beta1.Coin();
            }
            input.ReadMessage(Price);
            break;
          }
          case 40: {
            Status = (global::Cardchain.Cardchain.SellOfferStatus) input.ReadEnum();
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
            Seller = input.ReadString();
            break;
          }
          case 18: {
            Buyer = input.ReadString();
            break;
          }
          case 24: {
            Card = input.ReadUInt64();
            break;
          }
          case 34: {
            if (price_ == null) {
              Price = new global::Cosmos.Base.V1beta1.Coin();
            }
            input.ReadMessage(Price);
            break;
          }
          case 40: {
            Status = (global::Cardchain.Cardchain.SellOfferStatus) input.ReadEnum();
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
