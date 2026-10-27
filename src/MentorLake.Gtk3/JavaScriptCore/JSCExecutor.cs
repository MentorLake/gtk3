namespace MentorLake.JavaScriptCore;

/// <summary>
/// <para>
/// A function passed to @jsc_value_new_promise called during initialization
/// </para>
/// <para>
/// It is called like a JavaScript function, so exceptions raised will not be propagated
/// to the context, but handled by the promise causing a rejection.
/// @resolve and @reject can be reffed for later use to handle async task completion.
/// </para>
/// </summary>

/// <param name="resolve">
/// #JSCValue function to call to resolve the promise
/// </param>
/// <param name="reject">
/// #JSCValue function to call to reject the promise
/// </param>
/// <param name="user_data">
/// user data
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void JSCExecutor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle resolve, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCValueHandle>))] MentorLake.JavaScriptCore.JSCValueHandle reject, IntPtr user_data);
