namespace MentorLake.JavaScriptCore;

/// <summary>
/// <para>
/// The type of get_property in #JSCClassVTable. This is only required when you need to handle
/// external properties not added to the prototype.
/// </para>
/// </summary>

/// <param name="jsc_class">
/// a #JSCClass
/// </param>
/// <param name="context">
/// a #JSCContext
/// </param>
/// <param name="instance">
/// the @jsc_class instance
/// </param>
/// <param name="name">
/// the property name
/// </param>
/// <return>
/// a #JSCValue or %NULL to forward the request to
///    the parent class or prototype chain
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.JavaScriptCore.JSCValueHandle JSCClassGetPropertyFunction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCClassHandle>))] MentorLake.JavaScriptCore.JSCClassHandle jsc_class, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, IntPtr instance, string name);
