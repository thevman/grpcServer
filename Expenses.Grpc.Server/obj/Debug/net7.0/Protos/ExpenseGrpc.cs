// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/expense.proto
// </auto-generated>
#pragma warning disable 0414, 1591, 8981
#region Designer generated code

using grpc = global::Grpc.Core;

namespace Expenses.Grpc.Server {
  public static partial class ExpenseSvc
  {
    static readonly string __ServiceName = "ExpenseSvc";

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
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

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Expenses.Grpc.Server.GetExpensesRequest> __Marshaller_GetExpensesRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Expenses.Grpc.Server.GetExpensesRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Expenses.Grpc.Server.GetExpensesResponse> __Marshaller_GetExpensesResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Expenses.Grpc.Server.GetExpensesResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Expenses.Grpc.Server.GetExpenseByIdRequest> __Marshaller_GetExpenseByIdRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Expenses.Grpc.Server.GetExpenseByIdRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Expenses.Grpc.Server.GetExpenseByIdResponse> __Marshaller_GetExpenseByIdResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Expenses.Grpc.Server.GetExpenseByIdResponse.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Expenses.Grpc.Server.AddExpenseRequest> __Marshaller_AddExpenseRequest = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Expenses.Grpc.Server.AddExpenseRequest.Parser));
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Marshaller<global::Expenses.Grpc.Server.AddExpenseResponse> __Marshaller_AddExpenseResponse = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::Expenses.Grpc.Server.AddExpenseResponse.Parser));

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Expenses.Grpc.Server.GetExpensesRequest, global::Expenses.Grpc.Server.GetExpensesResponse> __Method_GetExpenses = new grpc::Method<global::Expenses.Grpc.Server.GetExpensesRequest, global::Expenses.Grpc.Server.GetExpensesResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetExpenses",
        __Marshaller_GetExpensesRequest,
        __Marshaller_GetExpensesResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Expenses.Grpc.Server.GetExpenseByIdRequest, global::Expenses.Grpc.Server.GetExpenseByIdResponse> __Method_GetExpenseById = new grpc::Method<global::Expenses.Grpc.Server.GetExpenseByIdRequest, global::Expenses.Grpc.Server.GetExpenseByIdResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "GetExpenseById",
        __Marshaller_GetExpenseByIdRequest,
        __Marshaller_GetExpenseByIdResponse);

    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    static readonly grpc::Method<global::Expenses.Grpc.Server.AddExpenseRequest, global::Expenses.Grpc.Server.AddExpenseResponse> __Method_AddExpense = new grpc::Method<global::Expenses.Grpc.Server.AddExpenseRequest, global::Expenses.Grpc.Server.AddExpenseResponse>(
        grpc::MethodType.Unary,
        __ServiceName,
        "AddExpense",
        __Marshaller_AddExpenseRequest,
        __Marshaller_AddExpenseResponse);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::Expenses.Grpc.Server.ExpenseReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of ExpenseSvc</summary>
    [grpc::BindServiceMethod(typeof(ExpenseSvc), "BindService")]
    public abstract partial class ExpenseSvcBase
    {
      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Expenses.Grpc.Server.GetExpensesResponse> GetExpenses(global::Expenses.Grpc.Server.GetExpensesRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Expenses.Grpc.Server.GetExpenseByIdResponse> GetExpenseById(global::Expenses.Grpc.Server.GetExpenseByIdRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

      [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
      public virtual global::System.Threading.Tasks.Task<global::Expenses.Grpc.Server.AddExpenseResponse> AddExpense(global::Expenses.Grpc.Server.AddExpenseRequest request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static grpc::ServerServiceDefinition BindService(ExpenseSvcBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_GetExpenses, serviceImpl.GetExpenses)
          .AddMethod(__Method_GetExpenseById, serviceImpl.GetExpenseById)
          .AddMethod(__Method_AddExpense, serviceImpl.AddExpense).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    [global::System.CodeDom.Compiler.GeneratedCode("grpc_csharp_plugin", null)]
    public static void BindService(grpc::ServiceBinderBase serviceBinder, ExpenseSvcBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_GetExpenses, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Expenses.Grpc.Server.GetExpensesRequest, global::Expenses.Grpc.Server.GetExpensesResponse>(serviceImpl.GetExpenses));
      serviceBinder.AddMethod(__Method_GetExpenseById, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Expenses.Grpc.Server.GetExpenseByIdRequest, global::Expenses.Grpc.Server.GetExpenseByIdResponse>(serviceImpl.GetExpenseById));
      serviceBinder.AddMethod(__Method_AddExpense, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::Expenses.Grpc.Server.AddExpenseRequest, global::Expenses.Grpc.Server.AddExpenseResponse>(serviceImpl.AddExpense));
    }

  }
}
#endregion
