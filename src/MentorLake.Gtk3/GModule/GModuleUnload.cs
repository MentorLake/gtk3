namespace MentorLake.GModule;

/// <summary>
/// <para>
/// Specifies the type of the module function called when it is unloaded.
/// If a module contains a function named g_module_unload() it is called
/// automatically when the module is unloaded.
/// It is passed the #GModule structure.
/// </para>
/// </summary>

/// <param name="module">
/// the #GModule about to be unloaded
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GModuleUnload([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GModule.GModuleHandle>))] MentorLake.GModule.GModuleHandle module);
