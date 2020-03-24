// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/SecurityRole.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace CareerCloud.gRPC.Protos {
  public static partial class SecurityRole
  {
    static readonly string __ServiceName = "CareerCloud.gRPC.SecurityRole";

    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.IdRequestRole> __Marshaller_CareerCloud_gRPC_IdRequestRole = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CareerCloud.gRPC.Protos.IdRequestRole.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::CareerCloud.gRPC.Protos.SecurityRolePayload> __Marshaller_CareerCloud_gRPC_SecurityRolePayload = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::CareerCloud.gRPC.Protos.SecurityRolePayload.Parser.ParseFrom);
    static readonly grpc::Marshaller<global::Google.Protobuf.WellKnownTypes.Empty> __Marshaller_google_protobuf_Empty = grpc::Marshallers.Create((arg) => global::Google.Protobuf.MessageExtensions.ToByteArray(arg), global::Google.Protobuf.WellKnownTypes.Empty.Parser.ParseFrom);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.IdRequestRole, global::CareerCloud.gRPC.Protos.SecurityRolePayload> __Method_ReadSecurityRole = new grpc::Method<global::CareerCloud.gRPC.Protos.IdRequestRole, global::CareerCloud.gRPC.Protos.SecurityRolePayload>(
        grpc::MethodType.Unary,
        __ServiceName,
        "ReadSecurityRole",
        __Marshaller_CareerCloud_gRPC_IdRequestRole,
        __Marshaller_CareerCloud_gRPC_SecurityRolePayload);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.SecurityRolePayload, global::Google.Protobuf.WellKnownTypes.Empty> __Method_CreateSecurityRole = new grpc::Method<global::CareerCloud.gRPC.Protos.SecurityRolePayload, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateSecurityRole",
        __Marshaller_CareerCloud_gRPC_SecurityRolePayload,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.SecurityRolePayload, global::Google.Protobuf.WellKnownTypes.Empty> __Method_UpdateSecurityRole = new grpc::Method<global::CareerCloud.gRPC.Protos.SecurityRolePayload, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "UpdateSecurityRole",
        __Marshaller_CareerCloud_gRPC_SecurityRolePayload,
        __Marshaller_google_protobuf_Empty);

    static readonly grpc::Method<global::CareerCloud.gRPC.Protos.SecurityRolePayload, global::Google.Protobuf.WellKnownTypes.Empty> __Method_DeleteSecurityRole = new grpc::Method<global::CareerCloud.gRPC.Protos.SecurityRolePayload, global::Google.Protobuf.WellKnownTypes.Empty>(
        grpc::MethodType.Unary,
        __ServiceName,
        "DeleteSecurityRole",
        __Marshaller_CareerCloud_gRPC_SecurityRolePayload,
        __Marshaller_google_protobuf_Empty);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::CareerCloud.gRPC.Protos.SecurityRoleReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of SecurityRole</summary>
    [grpc::BindServiceMethod(typeof(SecurityRole), "BindService")]
    public abstract partial class SecurityRoleBase
    {
      public virtual global::System.Threading.Tasks.Task<global::CareerCloud.gRPC.Protos.SecurityRolePayload> ReadSecurityRole(global::CareerCloud.gRPC.Protos.IdRequestRole request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> CreateSecurityRole(global::CareerCloud.gRPC.Protos.SecurityRolePayload request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> UpdateSecurityRole(global::CareerCloud.gRPC.Protos.SecurityRolePayload request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      public virtual global::System.Threading.Tasks.Task<global::Google.Protobuf.WellKnownTypes.Empty> DeleteSecurityRole(global::CareerCloud.gRPC.Protos.SecurityRolePayload request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(SecurityRoleBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_ReadSecurityRole, serviceImpl.ReadSecurityRole)
          .AddMethod(__Method_CreateSecurityRole, serviceImpl.CreateSecurityRole)
          .AddMethod(__Method_UpdateSecurityRole, serviceImpl.UpdateSecurityRole)
          .AddMethod(__Method_DeleteSecurityRole, serviceImpl.DeleteSecurityRole).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, SecurityRoleBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_ReadSecurityRole, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.IdRequestRole, global::CareerCloud.gRPC.Protos.SecurityRolePayload>(serviceImpl.ReadSecurityRole));
      serviceBinder.AddMethod(__Method_CreateSecurityRole, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.SecurityRolePayload, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.CreateSecurityRole));
      serviceBinder.AddMethod(__Method_UpdateSecurityRole, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.SecurityRolePayload, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.UpdateSecurityRole));
      serviceBinder.AddMethod(__Method_DeleteSecurityRole, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::CareerCloud.gRPC.Protos.SecurityRolePayload, global::Google.Protobuf.WellKnownTypes.Empty>(serviceImpl.DeleteSecurityRole));
    }

  }
}
#endregion