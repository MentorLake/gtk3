namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A callback function used by the type system to finalize those portions
/// of a derived types class structure that were setup from the corresponding
/// GBaseInitFunc() function.
/// </para>
/// <para>
/// Class finalization basically works the inverse way in which class
/// initialization is performed.
/// </para>
/// <para>
/// See GClassInitFunc() for a discussion of the class initialization process.
/// </para>
/// </summary>

/// <param name="g_class">
/// The #GTypeClass structure to finalize
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GBaseFinalizeFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle g_class);
