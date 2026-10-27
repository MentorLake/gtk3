namespace MentorLake.JavaScriptCore;

/// <summary>
/// <para>
/// Function used to handle JavaScript exceptions in a #JSCContext.
/// </para>
/// </summary>

/// <param name="context">
/// a #JSCContext
/// </param>
/// <param name="exception">
/// a #JSCException
/// </param>
/// <param name="user_data">
/// user data
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void JSCExceptionHandler([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCExceptionHandle>))] MentorLake.JavaScriptCore.JSCExceptionHandle exception, IntPtr user_data);
