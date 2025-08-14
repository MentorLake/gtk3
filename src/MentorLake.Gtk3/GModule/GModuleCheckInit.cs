namespace MentorLake.GModule;

/// <summary>
/// <para>
/// Specifies the type of the module initialization function.
/// If a module contains a function named g_module_check_init() it is called
/// automatically when the module is loaded. It is passed the #GModule structure
/// and should return %NULL on success or a string describing the initialization
/// error.
/// </para>
/// </summary>

/// <param name="module">
/// the #GModule corresponding to the module which has just been loaded
/// </param>
/// <return>
/// %NULL on success, or a string describing the initialization error
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate string GModuleCheckInit([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GModule.GModuleHandle>))] MentorLake.GModule.GModuleHandle module);
