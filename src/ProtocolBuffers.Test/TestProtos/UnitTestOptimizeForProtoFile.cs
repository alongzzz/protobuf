// Generated by the protocol buffer compiler.  DO NOT EDIT!

using pb = global::Google.ProtocolBuffers;
using pbc = global::Google.ProtocolBuffers.Collections;
using pbd = global::Google.ProtocolBuffers.Descriptors;
using scg = global::System.Collections.Generic;
namespace Google.ProtocolBuffers.TestProtos {
  
  public static partial class UnitTestOptimizeForProtoFile {
  
    #region Descriptor
    public static pbd::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static readonly pbd::FileDescriptor descriptor = pbd::FileDescriptor.InternalBuildGeneratedFileFrom(
        global::System.Convert.FromBase64String(
        "Citnb29nbGUvcHJvdG9idWYvdW5pdHRlc3Rfb3B0aW1pemVfZm9yLnByb3Rv" + 
        "EhFwcm90b2J1Zl91bml0dGVzdBokZ29vZ2xlL3Byb3RvYnVmL2NzaGFycF9v" + 
        "cHRpb25zLnByb3RvGiBnb29nbGUvcHJvdG9idWYvZGVzY3JpcHRvci5wcm90" + 
        "bxoeZ29vZ2xlL3Byb3RvYnVmL3VuaXR0ZXN0LnByb3RvIp4BChRUZXN0T3B0" + 
        "aW1pemVkRm9yU2l6ZRIJCgFpGAEgASgFEi4KA21zZxgTIAEoCzIhLnByb3Rv" + 
        "YnVmX3VuaXR0ZXN0LkZvcmVpZ25NZXNzYWdlKgkI6AcQgICAgAIyQAoOdGVz" + 
        "dF9leHRlbnNpb24SJy5wcm90b2J1Zl91bml0dGVzdC5UZXN0T3B0aW1pemVk" + 
        "Rm9yU2l6ZRjSCSABKAUiKQocVGVzdFJlcXVpcmVkT3B0aW1pemVkRm9yU2l6" + 
        "ZRIJCgF4GAEgAigFIloKHFRlc3RPcHRpb25hbE9wdGltaXplZEZvclNpemUS" + 
        "OgoBbxgBIAEoCzIvLnByb3RvYnVmX3VuaXR0ZXN0LlRlc3RSZXF1aXJlZE9w" + 
        "dGltaXplZEZvclNpemVCR0gCguIJIUdvb2dsZS5Qcm90b2NvbEJ1ZmZlcnMu" + 
        "VGVzdFByb3Rvc4riCRxVbml0VGVzdE9wdGltaXplRm9yUHJvdG9GaWxl"),
        new pbd::FileDescriptor[] {
          global::Google.ProtocolBuffers.DescriptorProtos.CSharpOptions.Descriptor, 
          global::Google.ProtocolBuffers.DescriptorProtos.DescriptorProtoFile.Descriptor, 
          global::Google.ProtocolBuffers.TestProtos.UnitTestProtoFile.Descriptor, 
        });
    #endregion
    
    #region Static variables
    internal static readonly pbd::MessageDescriptor internal__static_protobuf_unittest_TestOptimizedForSize__Descriptor
        = Descriptor.MessageTypes[0];
    internal static pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize, global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.Builder> internal__static_protobuf_unittest_TestOptimizedForSize__FieldAccessorTable
        = new pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize, global::Google.ProtocolBuffers.TestProtos.TestOptimizedForSize.Builder>(internal__static_protobuf_unittest_TestOptimizedForSize__Descriptor,
            new string[] { "I", "Msg", });
    internal static readonly pbd::MessageDescriptor internal__static_protobuf_unittest_TestRequiredOptimizedForSize__Descriptor
        = Descriptor.MessageTypes[1];
    internal static pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.TestProtos.TestRequiredOptimizedForSize, global::Google.ProtocolBuffers.TestProtos.TestRequiredOptimizedForSize.Builder> internal__static_protobuf_unittest_TestRequiredOptimizedForSize__FieldAccessorTable
        = new pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.TestProtos.TestRequiredOptimizedForSize, global::Google.ProtocolBuffers.TestProtos.TestRequiredOptimizedForSize.Builder>(internal__static_protobuf_unittest_TestRequiredOptimizedForSize__Descriptor,
            new string[] { "X", });
    internal static readonly pbd::MessageDescriptor internal__static_protobuf_unittest_TestOptionalOptimizedForSize__Descriptor
        = Descriptor.MessageTypes[2];
    internal static pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.TestProtos.TestOptionalOptimizedForSize, global::Google.ProtocolBuffers.TestProtos.TestOptionalOptimizedForSize.Builder> internal__static_protobuf_unittest_TestOptionalOptimizedForSize__FieldAccessorTable
        = new pb::FieldAccess.FieldAccessorTable<global::Google.ProtocolBuffers.TestProtos.TestOptionalOptimizedForSize, global::Google.ProtocolBuffers.TestProtos.TestOptionalOptimizedForSize.Builder>(internal__static_protobuf_unittest_TestOptionalOptimizedForSize__Descriptor,
            new string[] { "O", });
    #endregion
  }
  #region Messages
  public sealed partial class TestOptimizedForSize : pb::ExtendableMessage<TestOptimizedForSize, TestOptimizedForSize.Builder> {
    private static readonly TestOptimizedForSize defaultInstance = new Builder().BuildPartial();
    public static TestOptimizedForSize DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override TestOptimizedForSize DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override TestOptimizedForSize ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::Google.ProtocolBuffers.TestProtos.UnitTestOptimizeForProtoFile.internal__static_protobuf_unittest_TestOptimizedForSize__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<TestOptimizedForSize, TestOptimizedForSize.Builder> InternalFieldAccessors {
      get { return global::Google.ProtocolBuffers.TestProtos.UnitTestOptimizeForProtoFile.internal__static_protobuf_unittest_TestOptimizedForSize__FieldAccessorTable; }
    }
    
    public static readonly pb::GeneratedExtensionBase<int> TestExtension =
        pb::GeneratedSingleExtension<int>.CreateInstance(Descriptor.Extensions[0]);
    private bool hasI;
    private int i_ = 0;
    public bool HasI {
      get { return hasI; }
    }
    public int I {
      get { return i_; }
    }
    
    private bool hasMsg;
    private global::Google.ProtocolBuffers.TestProtos.ForeignMessage msg_ = global::Google.ProtocolBuffers.TestProtos.ForeignMessage.DefaultInstance;
    public bool HasMsg {
      get { return hasMsg; }
    }
    public global::Google.ProtocolBuffers.TestProtos.ForeignMessage Msg {
      get { return msg_; }
    }
    
    public static TestOptimizedForSize ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static TestOptimizedForSize ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static TestOptimizedForSize ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static TestOptimizedForSize ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static TestOptimizedForSize ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static TestOptimizedForSize ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static TestOptimizedForSize ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static TestOptimizedForSize ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(TestOptimizedForSize prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::ExtendableBuilder<TestOptimizedForSize, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      TestOptimizedForSize result = new TestOptimizedForSize();
      
      protected override TestOptimizedForSize MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new TestOptimizedForSize();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return TestOptimizedForSize.Descriptor; }
      }
      
      public override TestOptimizedForSize DefaultInstanceForType {
        get { return TestOptimizedForSize.DefaultInstance; }
      }
      
      public override TestOptimizedForSize BuildPartial() {
        TestOptimizedForSize returnMe = result;
        result = null;
        return returnMe;
      }
      
      
      public bool HasI {
        get { return result.HasI; }
      }
      public int I {
        get { return result.I; }
        set { SetI(value); }
      }
      public Builder SetI(int value) {
        result.hasI = true;
        result.i_ = value;
        return this;
      }
      public Builder ClearI() {
        result.hasI = false;
        result.i_ = 0;
        return this;
      }
      
      public bool HasMsg {
       get { return result.HasMsg; }
      }
      public global::Google.ProtocolBuffers.TestProtos.ForeignMessage Msg {
        get { return result.Msg; }
        set { SetMsg(value); }
      }
      public Builder SetMsg(global::Google.ProtocolBuffers.TestProtos.ForeignMessage value) {
        result.hasMsg = true;
        result.msg_ = value;
        return this;
      }
      public Builder SetMsg(global::Google.ProtocolBuffers.TestProtos.ForeignMessage.Builder builderForValue) {
        result.hasMsg = true;
        result.msg_ = builderForValue.Build();
        return this;
      }
      public Builder MergeMsg(global::Google.ProtocolBuffers.TestProtos.ForeignMessage value) {
        if (result.HasMsg &&
            result.msg_ != global::Google.ProtocolBuffers.TestProtos.ForeignMessage.DefaultInstance) {
            result.msg_ = global::Google.ProtocolBuffers.TestProtos.ForeignMessage.CreateBuilder(result.msg_).MergeFrom(value).BuildPartial();
        } else {
          result.msg_ = value;
        }
        result.hasMsg = true;
        return this;
      }
      public Builder ClearMsg() {
        result.hasMsg = false;
        result.msg_ = global::Google.ProtocolBuffers.TestProtos.ForeignMessage.DefaultInstance;
        return this;
      }
    }
  }
  
  public sealed partial class TestRequiredOptimizedForSize : pb::GeneratedMessage<TestRequiredOptimizedForSize, TestRequiredOptimizedForSize.Builder> {
    private static readonly TestRequiredOptimizedForSize defaultInstance = new Builder().BuildPartial();
    public static TestRequiredOptimizedForSize DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override TestRequiredOptimizedForSize DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override TestRequiredOptimizedForSize ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::Google.ProtocolBuffers.TestProtos.UnitTestOptimizeForProtoFile.internal__static_protobuf_unittest_TestRequiredOptimizedForSize__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<TestRequiredOptimizedForSize, TestRequiredOptimizedForSize.Builder> InternalFieldAccessors {
      get { return global::Google.ProtocolBuffers.TestProtos.UnitTestOptimizeForProtoFile.internal__static_protobuf_unittest_TestRequiredOptimizedForSize__FieldAccessorTable; }
    }
    
    private bool hasX;
    private int x_ = 0;
    public bool HasX {
      get { return hasX; }
    }
    public int X {
      get { return x_; }
    }
    
    public static TestRequiredOptimizedForSize ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static TestRequiredOptimizedForSize ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static TestRequiredOptimizedForSize ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static TestRequiredOptimizedForSize ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static TestRequiredOptimizedForSize ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static TestRequiredOptimizedForSize ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static TestRequiredOptimizedForSize ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static TestRequiredOptimizedForSize ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(TestRequiredOptimizedForSize prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<TestRequiredOptimizedForSize, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      TestRequiredOptimizedForSize result = new TestRequiredOptimizedForSize();
      
      protected override TestRequiredOptimizedForSize MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new TestRequiredOptimizedForSize();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return TestRequiredOptimizedForSize.Descriptor; }
      }
      
      public override TestRequiredOptimizedForSize DefaultInstanceForType {
        get { return TestRequiredOptimizedForSize.DefaultInstance; }
      }
      
      public override TestRequiredOptimizedForSize BuildPartial() {
        TestRequiredOptimizedForSize returnMe = result;
        result = null;
        return returnMe;
      }
      
      
      public bool HasX {
        get { return result.HasX; }
      }
      public int X {
        get { return result.X; }
        set { SetX(value); }
      }
      public Builder SetX(int value) {
        result.hasX = true;
        result.x_ = value;
        return this;
      }
      public Builder ClearX() {
        result.hasX = false;
        result.x_ = 0;
        return this;
      }
    }
  }
  
  public sealed partial class TestOptionalOptimizedForSize : pb::GeneratedMessage<TestOptionalOptimizedForSize, TestOptionalOptimizedForSize.Builder> {
    private static readonly TestOptionalOptimizedForSize defaultInstance = new Builder().BuildPartial();
    public static TestOptionalOptimizedForSize DefaultInstance {
      get { return defaultInstance; }
    }
    
    public override TestOptionalOptimizedForSize DefaultInstanceForType {
      get { return defaultInstance; }
    }
    
    protected override TestOptionalOptimizedForSize ThisMessage {
      get { return this; }
    }
    
    public static pbd::MessageDescriptor Descriptor {
      get { return global::Google.ProtocolBuffers.TestProtos.UnitTestOptimizeForProtoFile.internal__static_protobuf_unittest_TestOptionalOptimizedForSize__Descriptor; }
    }
    
    protected override pb::FieldAccess.FieldAccessorTable<TestOptionalOptimizedForSize, TestOptionalOptimizedForSize.Builder> InternalFieldAccessors {
      get { return global::Google.ProtocolBuffers.TestProtos.UnitTestOptimizeForProtoFile.internal__static_protobuf_unittest_TestOptionalOptimizedForSize__FieldAccessorTable; }
    }
    
    private bool hasO;
    private global::Google.ProtocolBuffers.TestProtos.TestRequiredOptimizedForSize o_ = global::Google.ProtocolBuffers.TestProtos.TestRequiredOptimizedForSize.DefaultInstance;
    public bool HasO {
      get { return hasO; }
    }
    public global::Google.ProtocolBuffers.TestProtos.TestRequiredOptimizedForSize O {
      get { return o_; }
    }
    
    public static TestOptionalOptimizedForSize ParseFrom(pb::ByteString data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static TestOptionalOptimizedForSize ParseFrom(pb::ByteString data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static TestOptionalOptimizedForSize ParseFrom(byte[] data) {
      return ((Builder) CreateBuilder().MergeFrom(data)).BuildParsed();
    }
    public static TestOptionalOptimizedForSize ParseFrom(byte[] data, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(data, extensionRegistry)).BuildParsed();
    }
    public static TestOptionalOptimizedForSize ParseFrom(global::System.IO.Stream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static TestOptionalOptimizedForSize ParseFrom(global::System.IO.Stream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static TestOptionalOptimizedForSize ParseFrom(pb::CodedInputStream input) {
      return ((Builder) CreateBuilder().MergeFrom(input)).BuildParsed();
    }
    public static TestOptionalOptimizedForSize ParseFrom(pb::CodedInputStream input, pb::ExtensionRegistry extensionRegistry) {
      return ((Builder) CreateBuilder().MergeFrom(input, extensionRegistry)).BuildParsed();
    }
    public static Builder CreateBuilder() { return new Builder(); }
    public override Builder CreateBuilderForType() { return new Builder(); }
    public static Builder CreateBuilder(TestOptionalOptimizedForSize prototype) {
      return (Builder) new Builder().MergeFrom(prototype);
    }
    
    public sealed partial class Builder : pb::GeneratedBuilder<TestOptionalOptimizedForSize, Builder> {
      protected override Builder ThisBuilder {
        get { return this; }
      }
      public Builder() {}
      
      TestOptionalOptimizedForSize result = new TestOptionalOptimizedForSize();
      
      protected override TestOptionalOptimizedForSize MessageBeingBuilt {
        get { return result; }
      }
      
      public override Builder Clear() {
        result = new TestOptionalOptimizedForSize();
        return this;
      }
      
      public override Builder Clone() {
        return new Builder().MergeFrom(result);
      }
      
      public override pbd::MessageDescriptor DescriptorForType {
        get { return TestOptionalOptimizedForSize.Descriptor; }
      }
      
      public override TestOptionalOptimizedForSize DefaultInstanceForType {
        get { return TestOptionalOptimizedForSize.DefaultInstance; }
      }
      
      public override TestOptionalOptimizedForSize BuildPartial() {
        TestOptionalOptimizedForSize returnMe = result;
        result = null;
        return returnMe;
      }
      
      
      public bool HasO {
       get { return result.HasO; }
      }
      public global::Google.ProtocolBuffers.TestProtos.TestRequiredOptimizedForSize O {
        get { return result.O; }
        set { SetO(value); }
      }
      public Builder SetO(global::Google.ProtocolBuffers.TestProtos.TestRequiredOptimizedForSize value) {
        result.hasO = true;
        result.o_ = value;
        return this;
      }
      public Builder SetO(global::Google.ProtocolBuffers.TestProtos.TestRequiredOptimizedForSize.Builder builderForValue) {
        result.hasO = true;
        result.o_ = builderForValue.Build();
        return this;
      }
      public Builder MergeO(global::Google.ProtocolBuffers.TestProtos.TestRequiredOptimizedForSize value) {
        if (result.HasO &&
            result.o_ != global::Google.ProtocolBuffers.TestProtos.TestRequiredOptimizedForSize.DefaultInstance) {
            result.o_ = global::Google.ProtocolBuffers.TestProtos.TestRequiredOptimizedForSize.CreateBuilder(result.o_).MergeFrom(value).BuildPartial();
        } else {
          result.o_ = value;
        }
        result.hasO = true;
        return this;
      }
      public Builder ClearO() {
        result.hasO = false;
        result.o_ = global::Google.ProtocolBuffers.TestProtos.TestRequiredOptimizedForSize.DefaultInstance;
        return this;
      }
    }
  }
  
  #endregion
  
}
