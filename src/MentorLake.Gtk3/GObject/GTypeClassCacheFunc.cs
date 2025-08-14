namespace MentorLake.GObject;

/// <summary>
/// <para>
/// A callback function which is called when the reference count of a class
/// drops to zero.
/// </para>
/// <para>
/// It may use g_type_class_ref() to prevent the class from being freed. You
/// should not call g_type_class_unref() from a #GTypeClassCacheFunc function
/// to prevent infinite recursion, use g_type_class_unref_uncached() instead.
/// </para>
/// <para>
/// The functions have to check the class id passed in to figure
/// whether they actually want to cache the class of this type, since all
/// classes are routed through the same #GTypeClassCacheFunc chain.
/// </para>
/// </summary>

/// <param name="cache_data">
/// data that was given to the g_type_add_class_cache_func() call
/// </param>
/// <param name="g_class">
/// The #GTypeClass structure which is
///    unreferenced
/// </param>
/// <return>
/// %TRUE to stop further #GTypeClassCacheFuncs from being
///  called, %FALSE to continue
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool GTypeClassCacheFunc(IntPtr cache_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle g_class);
