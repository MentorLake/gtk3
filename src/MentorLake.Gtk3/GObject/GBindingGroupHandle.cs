namespace MentorLake.GObject;

/// <summary>
/// <para>
/// `GBindingGroup` can be used to bind multiple properties
/// from an object collectively.
/// </para>
/// <para>
/// Use the various methods to bind properties from a single source
/// object to multiple destination objects. Properties can be bound
/// bidirectionally and are connected when the source object is set
/// with [method@GObject.BindingGroup.set_source].
/// </para>
/// </summary>

public class GBindingGroupHandle : GObjectHandle
{
/// <summary>
/// <para>
/// Creates a new #GBindingGroup.
/// </para>
/// </summary>

/// <return>
/// a new #GBindingGroup
/// </return>

	public static MentorLake.GObject.GBindingGroupHandle New()
	{
		return GBindingGroupHandleExterns.g_binding_group_new();
	}

}

public static class GBindingGroupHandleExtensions
{
/// <summary>
/// <para>
/// Creates a binding between @source_property on the source object
/// and @target_property on @target. Whenever the @source_property
/// is changed the @target_property is updated using the same value.
/// The binding flag %G_BINDING_SYNC_CREATE is automatically specified.
/// </para>
/// <para>
/// See g_object_bind_property() for more information.
/// </para>
/// </summary>

/// <param name="self">
/// the #GBindingGroup
/// </param>
/// <param name="source_property">
/// the property on the source to bind
/// </param>
/// <param name="target">
/// the target #GObject
/// </param>
/// <param name="target_property">
/// the property on @target to bind
/// </param>
/// <param name="flags">
/// the flags used to create the #GBinding
/// </param>

	public static T Bind<T>(this T self, string source_property, MentorLake.GObject.GObjectHandle target, string target_property, MentorLake.GObject.GBindingFlags flags) where T : GBindingGroupHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GBindingGroupHandle)");
		GBindingGroupHandleExterns.g_binding_group_bind(self, source_property, target, target_property, flags);
		return self;
	}

/// <summary>
/// <para>
/// Creates a binding between @source_property on the source object and
/// @target_property on @target, allowing you to set the transformation
/// functions to be used by the binding. The binding flag
/// %G_BINDING_SYNC_CREATE is automatically specified.
/// </para>
/// <para>
/// See g_object_bind_property_full() for more information.
/// </para>
/// </summary>

/// <param name="self">
/// the #GBindingGroup
/// </param>
/// <param name="source_property">
/// the property on the source to bind
/// </param>
/// <param name="target">
/// the target #GObject
/// </param>
/// <param name="target_property">
/// the property on @target to bind
/// </param>
/// <param name="flags">
/// the flags used to create the #GBinding
/// </param>
/// <param name="transform_to">
/// the transformation function
///     from the source object to the @target, or %NULL to use the default
/// </param>
/// <param name="transform_from">
/// the transformation function
///     from the @target to the source object, or %NULL to use the default
/// </param>
/// <param name="user_data">
/// custom data to be passed to the transformation
///             functions, or %NULL
/// </param>
/// <param name="user_data_destroy">
/// function to be called when disposing the binding,
///     to free the resources used by the transformation functions
/// </param>

	public static T BindFull<T>(this T self, string source_property, MentorLake.GObject.GObjectHandle target, string target_property, MentorLake.GObject.GBindingFlags flags, MentorLake.GObject.GBindingTransformFunc transform_to, MentorLake.GObject.GBindingTransformFunc transform_from, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_destroy) where T : GBindingGroupHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GBindingGroupHandle)");
		GBindingGroupHandleExterns.g_binding_group_bind_full(self, source_property, target, target_property, flags, transform_to, transform_from, user_data, user_data_destroy);
		return self;
	}

/// <summary>
/// <para>
/// Creates a binding between @source_property on the source object and
/// @target_property on @target, allowing you to set the transformation
/// functions to be used by the binding. The binding flag
/// %G_BINDING_SYNC_CREATE is automatically specified.
/// </para>
/// <para>
/// This function is the language bindings friendly version of
/// g_binding_group_bind_property_full(), using #GClosures
/// instead of function pointers.
/// </para>
/// <para>
/// See g_object_bind_property_with_closures() for more information.
/// </para>
/// </summary>

/// <param name="self">
/// the #GBindingGroup
/// </param>
/// <param name="source_property">
/// the property on the source to bind
/// </param>
/// <param name="target">
/// the target #GObject
/// </param>
/// <param name="target_property">
/// the property on @target to bind
/// </param>
/// <param name="flags">
/// the flags used to create the #GBinding
/// </param>
/// <param name="transform_to">
/// a #GClosure wrapping the
///     transformation function from the source object to the @target,
///     or %NULL to use the default
/// </param>
/// <param name="transform_from">
/// a #GClosure wrapping the
///     transformation function from the @target to the source object,
///     or %NULL to use the default
/// </param>

	public static T BindWithClosures<T>(this T self, string source_property, MentorLake.GObject.GObjectHandle target, string target_property, MentorLake.GObject.GBindingFlags flags, MentorLake.GObject.GClosureHandle transform_to, MentorLake.GObject.GClosureHandle transform_from) where T : GBindingGroupHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GBindingGroupHandle)");
		GBindingGroupHandleExterns.g_binding_group_bind_with_closures(self, source_property, target, target_property, flags, transform_to, transform_from);
		return self;
	}

/// <summary>
/// <para>
/// Gets the source object used for binding properties.
/// </para>
/// </summary>

/// <param name="self">
/// the #GBindingGroup
/// </param>
/// <return>
/// a #GObject or %NULL.
/// </return>

	public static MentorLake.GObject.GObjectHandle DupSource(this MentorLake.GObject.GBindingGroupHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GBindingGroupHandle)");
		return GBindingGroupHandleExterns.g_binding_group_dup_source(self);
	}

/// <summary>
/// <para>
/// Sets @source as the source object used for creating property
/// bindings. If there is already a source object all bindings from it
/// will be removed.
/// </para>
/// <para>
/// Note that all properties that have been bound must exist on @source.
/// </para>
/// </summary>

/// <param name="self">
/// the #GBindingGroup
/// </param>
/// <param name="source">
/// the source #GObject,
///   or %NULL to clear it
/// </param>

	public static T SetSource<T>(this T self, MentorLake.GObject.GObjectHandle source) where T : GBindingGroupHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GBindingGroupHandle)");
		GBindingGroupHandleExterns.g_binding_group_set_source(self, source);
		return self;
	}

}

internal class GBindingGroupHandleExterns
{
	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.GObject.GBindingGroupHandle>))]
	internal static extern MentorLake.GObject.GBindingGroupHandle g_binding_group_new();

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_binding_group_bind([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingGroupHandle>))] MentorLake.GObject.GBindingGroupHandle self, string source_property, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle target, string target_property, MentorLake.GObject.GBindingFlags flags);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_binding_group_bind_full([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingGroupHandle>))] MentorLake.GObject.GBindingGroupHandle self, string source_property, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle target, string target_property, MentorLake.GObject.GBindingFlags flags, MentorLake.GObject.GBindingTransformFunc transform_to, MentorLake.GObject.GBindingTransformFunc transform_from, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_destroy);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_binding_group_bind_with_closures([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingGroupHandle>))] MentorLake.GObject.GBindingGroupHandle self, string source_property, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle target, string target_property, MentorLake.GObject.GBindingFlags flags, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle transform_to, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle transform_from);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_binding_group_dup_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingGroupHandle>))] MentorLake.GObject.GBindingGroupHandle self);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_binding_group_set_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GBindingGroupHandle>))] MentorLake.GObject.GBindingGroupHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle source);

}
