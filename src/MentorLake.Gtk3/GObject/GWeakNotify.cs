namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A #GWeakNotify function can be added to an object as a callback that gets
/// triggered when the object is finalized.
/// </para>
/// <para>
/// Since the object is already being disposed when the #GWeakNotify is called,
/// there&apos;s not much you could do with the object, apart from e.g. using its
/// address as hash-index or the like.
/// </para>
/// <para>
/// In particular, this means it’s invalid to call g_object_ref(),
/// g_weak_ref_init(), g_weak_ref_set(), g_object_add_toggle_ref(),
/// g_object_weak_ref(), g_object_add_weak_pointer() or any function which calls
/// them on the object from this callback.
/// </para>
/// </summary>

/// <param name="data">
/// data that was provided when the weak reference was established
/// </param>
/// <param name="where_the_object_was">
/// the object being disposed
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void GWeakNotify(IntPtr data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle where_the_object_was);
