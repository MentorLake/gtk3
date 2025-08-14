namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A callback function used for notification when the state
/// of a toggle reference changes.
/// </para>
/// <para>
/// See also: g_object_add_toggle_ref()
/// </para>
/// </summary>

/// <param name="data">
/// Callback data passed to g_object_add_toggle_ref()
/// </param>
/// <param name="@object">
/// The object on which g_object_add_toggle_ref() was called.
/// </param>
/// <param name="is_last_ref">
/// %TRUE if the toggle reference is now the
///  last reference to the object. %FALSE if the toggle
///  reference was the last reference and there are now other
///  references.
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GToggleNotify(IntPtr data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object, bool is_last_ref);
