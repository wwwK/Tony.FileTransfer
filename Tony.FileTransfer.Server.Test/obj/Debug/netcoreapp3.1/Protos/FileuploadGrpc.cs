// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/fileupload.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Tony.FileTransfer.Server {
  public static partial class IFileUpload
  {
    static readonly string __ServiceName = "fileupload.IFileUpload";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::Tony.FileTransfer.Server.CheckFileExistRequest> __Marshaller_fileupload_CheckFileExistRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Tony.FileTransfer.Server.CheckFileExistRequest.Parser));
    static readonly grpc::Marshaller<global::Tony.FileTransfer.Server.CommonResponse> __Marshaller_common_CommonResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Tony.FileTransfer.Server.CommonResponse.Parser));
    static readonly grpc::Marshaller<global::Tony.FileTransfer.Server.UploadWithStreamRequest> __Marshaller_fileupload_UploadWithStreamRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Tony.FileTransfer.Server.UploadWithStreamRequest.Parser));

    static readonly grpc::Method<global::Tony.FileTransfer.Server.CheckFileExistRequest, global::Tony.FileTransfer.Server.CommonResponse> __Method_CheckFileExist = new grpc::Method<global::Tony.FileTransfer.Server.CheckFileExistRequest, global::Tony.FileTransfer.Server.CommonResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CheckFileExist",
        __Marshaller_fileupload_CheckFileExistRequest,
        __Marshaller_common_CommonResponse);

    static readonly grpc::Method<global::Tony.FileTransfer.Server.UploadWithStreamRequest, global::Tony.FileTransfer.Server.CommonResponse> __Method_UploadWithStream = new grpc::Method<global::Tony.FileTransfer.Server.UploadWithStreamRequest, global::Tony.FileTransfer.Server.CommonResponse>(
        grpc::MethodType.ClientStreaming,
        __ServiceName,
        "UploadWithStream",
        __Marshaller_fileupload_UploadWithStreamRequest,
        __Marshaller_common_CommonResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Tony.FileTransfer.Server.FileuploadReflection.Descriptor.Services[0]; }
    }

    /// <summary>Client for IFileUpload</summary>
    public partial class IFileUploadClient : grpc::ClientBase<IFileUploadClient>
    {
      /// <summary>Creates a new client for IFileUpload</summary>
      /// <param name="channel">The channel to use to make remote calls.</param>
      public IFileUploadClient(grpc::ChannelBase channel) : base(channel)
      {
      }
      /// <summary>Creates a new client for IFileUpload that uses a custom <c>CallInvoker</c>.</summary>
      /// <param name="callInvoker">The callInvoker to use to make remote calls.</param>
      public IFileUploadClient(grpc::CallInvoker callInvoker) : base(callInvoker)
      {
      }
      /// <summary>Protected parameterless constructor to allow creation of test doubles.</summary>
      protected IFileUploadClient() : base()
      {
      }
      /// <summary>Protected constructor to allow creation of configured clients.</summary>
      /// <param name="configuration">The client configuration.</param>
      protected IFileUploadClient(ClientBaseConfiguration configuration) : base(configuration)
      {
      }

      /// <summary>
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tony.FileTransfer.Server.CommonResponse CheckFileExist(global::Tony.FileTransfer.Server.CheckFileExistRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckFileExist(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The response received from the server.</returns>
      public virtual global::Tony.FileTransfer.Server.CommonResponse CheckFileExist(global::Tony.FileTransfer.Server.CheckFileExistRequest request, grpc::CallOptions options)
      {
        return CallInvoker.BlockingUnaryCall(__Method_CheckFileExist, null, options, request);
      }
      /// <summary>
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="headers">The initial metadata to send with the call. This parameter is optional.</param>
      /// <param name="deadline">An optional deadline for the call. The call will be cancelled if deadline is hit.</param>
      /// <param name="cancellationToken">An optional token for canceling the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tony.FileTransfer.Server.CommonResponse> CheckFileExistAsync(global::Tony.FileTransfer.Server.CheckFileExistRequest request, grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return CheckFileExistAsync(request, new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      /// <summary>
      /// </summary>
      /// <param name="request">The request to send to the server.</param>
      /// <param name="options">The options for the call.</param>
      /// <returns>The call object.</returns>
      public virtual grpc::AsyncUnaryCall<global::Tony.FileTransfer.Server.CommonResponse> CheckFileExistAsync(global::Tony.FileTransfer.Server.CheckFileExistRequest request, grpc::CallOptions options)
      {
        return CallInvoker.AsyncUnaryCall(__Method_CheckFileExist, null, options, request);
      }
      public virtual grpc::AsyncClientStreamingCall<global::Tony.FileTransfer.Server.UploadWithStreamRequest, global::Tony.FileTransfer.Server.CommonResponse> UploadWithStream(grpc::Metadata headers = null, global::System.DateTime? deadline = null, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
      {
        return UploadWithStream(new grpc::CallOptions(headers, deadline, cancellationToken));
      }
      public virtual grpc::AsyncClientStreamingCall<global::Tony.FileTransfer.Server.UploadWithStreamRequest, global::Tony.FileTransfer.Server.CommonResponse> UploadWithStream(grpc::CallOptions options)
      {
        return CallInvoker.AsyncClientStreamingCall(__Method_UploadWithStream, null, options);
      }
      /// <summary>Creates a new instance of client from given <c>ClientBaseConfiguration</c>.</summary>
      protected override IFileUploadClient NewInstance(ClientBaseConfiguration configuration)
      {
        return new IFileUploadClient(configuration);
      }
    }

  }
}
#endregion
