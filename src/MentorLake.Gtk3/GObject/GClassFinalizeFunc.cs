namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A callback function used by the type system to finalize a class.
/// </para>
/// <para>
/// This function is rarely needed, as dynamically allocated class resources
/// should be handled by GBaseInitFunc() and GBaseFinalizeFunc().
/// </para>
/// <para>
/// Also, specification of a GClassFinalizeFunc() in the #GTypeInfo
/// structure of a static type is invalid, because classes of static types
/// will never be finalized (they are artificially kept alive when their
/// reference count drops to zero).
/// </para>
/// </summary>

/// <param name="g_class">
/// The #GTypeClass structure to finalize
/// </param>
/// <param name="class_data">
/// The @class_data member supplied via the #GTypeInfo structure
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GClassFinalizeFunc([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle g_class, IntPtr class_data);
