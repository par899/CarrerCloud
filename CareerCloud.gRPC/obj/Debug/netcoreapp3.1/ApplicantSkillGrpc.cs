// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/ApplicantSkill.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CareerCloud.gRPC.Protos {
  public static partial class ApplicantSkill
  {
    static readonly string __ServiceName = "CareerCloud.gRPC.ApplicantSkill";

    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.IdRequestSkill> __Marshaller_CareerCloud_gRPC_IdRequestSkill = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CareerCloud.gRPC.Protos.IdRequestSkill.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.ApplicantSkillPayload> __Marshaller_CareerCloud_gRPC_ApplicantSkillPayload = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CareerCloud.gRPC.Protos.ApplicantSkillPayload.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.IdRequestSkill, global::CareerCloud.gRPC.Protos.ApplicantSkillPayload> __Method_ReadApplicantSkill = new grpc::Method<global::CareerCloud.gRPC.Protos.IdRequestSkill, global::CareerCloud.gRPC.Protos.ApplicantSkillPayload>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadApplicantSkill",
        __Marshaller_CareerCloud_gRPC_IdRequestSkill,
        __Marshaller_CareerCloud_gRPC_ApplicantSkillPayload);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.ApplicantSkillPayload, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CreateAplicantSkill = new grpc::Method<global::CareerCloud.gRPC.Protos.ApplicantSkillPayload, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateAplicantSkill",
        __Marshaller_CareerCloud_gRPC_ApplicantSkillPayload,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.ApplicantSkillPayload, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateApplicantSkill = new grpc::Method<global::CareerCloud.gRPC.Protos.ApplicantSkillPayload, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateApplicantSkill",
        __Marshaller_CareerCloud_gRPC_ApplicantSkillPayload,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.ApplicantSkillPayload, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteApplicantSkill = new grpc::Method<global::CareerCloud.gRPC.Protos.ApplicantSkillPayload, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteApplicantSkill",
        __Marshaller_CareerCloud_gRPC_ApplicantSkillPayload,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CareerCloud.gRPC.Protos.ApplicantSkillReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ApplicantSkill</summary>
    [grpc::BindServiceMethod(typeof(ApplicantSkill), "BindService")]
    public abstract partial class ApplicantSkillBase
    {
      public virtual global::System.Threading.Tasks.Task<global::CareerCloud.gRPC.Protos.ApplicantSkillPayload> ReadApplicantSkill(global::CareerCloud.gRPC.Protos.IdRequestSkill request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> CreateAplicantSkill(global::CareerCloud.gRPC.Protos.ApplicantSkillPayload request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateApplicantSkill(global::CareerCloud.gRPC.Protos.ApplicantSkillPayload request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteApplicantSkill(global::CareerCloud.gRPC.Protos.ApplicantSkillPayload request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(ApplicantSkillBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ReadApplicantSkill, serviceImpl.ReadApplicantSkill)
          .AddMethod(__Method_CreateAplicantSkill, serviceImpl.CreateAplicantSkill)
          .AddMethod(__Method_UpdateApplicantSkill, serviceImpl.UpdateApplicantSkill)
          .AddMethod(__Method_DeleteApplicantSkill, serviceImpl.DeleteApplicantSkill).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ApplicantSkillBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ReadApplicantSkill, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.IdRequestSkill, global::CareerCloud.gRPC.Protos.ApplicantSkillPayload>(serviceImpl.ReadApplicantSkill));
      serviceBinder.AddMethod(__Method_CreateAplicantSkill, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.ApplicantSkillPayload, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.CreateAplicantSkill));
      serviceBinder.AddMethod(__Method_UpdateApplicantSkill, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.ApplicantSkillPayload, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.UpdateApplicantSkill));
      serviceBinder.AddMethod(__Method_DeleteApplicantSkill, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.ApplicantSkillPayload, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteApplicantSkill));
    }

  }
}
#endregion