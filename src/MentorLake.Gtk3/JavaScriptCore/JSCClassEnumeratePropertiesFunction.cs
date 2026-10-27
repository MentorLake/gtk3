namespace MentorLake.JavaScriptCore;

/// <summary>
/// <para>
/// The type of enumerate_properties in #JSCClassVTable. This is only required when you need to handle
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
/// <return>
/// a %NULL-terminated array of strings
///    containing the property names, or %NULL if @instance doesn&apos;t have enumerable properties.
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string[] JSCClassEnumeratePropertiesFunction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCClassHandle>))] MentorLake.JavaScriptCore.JSCClassHandle jsc_class, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.JavaScriptCore.JSCContextHandle>))] MentorLake.JavaScriptCore.JSCContextHandle context, IntPtr instance);
