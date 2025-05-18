namespace MentorLake.GObject;

public class GBindingGroupHandle : GObjectHandle
{
	public static MentorLake.GObject.GBindingGroupHandle New()
	{
		return GBindingGroupHandleExterns.g_binding_group_new();
	}

}

public static class GBindingGroupHandleExtensions
{
	public static T Bind<T>(this T self, string source_property, MentorLake.GObject.GObjectHandle target, string target_property, MentorLake.GObject.GBindingFlags flags) where T : GBindingGroupHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GBindingGroupHandle)");
		GBindingGroupHandleExterns.g_binding_group_bind(self, source_property, target, target_property, flags);
		return self;
	}

	public static T BindFull<T>(this T self, string source_property, MentorLake.GObject.GObjectHandle target, string target_property, MentorLake.GObject.GBindingFlags flags, MentorLake.GObject.GBindingTransformFunc transform_to, MentorLake.GObject.GBindingTransformFunc transform_from, IntPtr user_data, MentorLake.GLib.GDestroyNotify user_data_destroy) where T : GBindingGroupHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GBindingGroupHandle)");
		GBindingGroupHandleExterns.g_binding_group_bind_full(self, source_property, target, target_property, flags, transform_to, transform_from, user_data, user_data_destroy);
		return self;
	}

	public static T BindWithClosures<T>(this T self, string source_property, MentorLake.GObject.GObjectHandle target, string target_property, MentorLake.GObject.GBindingFlags flags, MentorLake.GObject.GClosureHandle transform_to, MentorLake.GObject.GClosureHandle transform_from) where T : GBindingGroupHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GBindingGroupHandle)");
		GBindingGroupHandleExterns.g_binding_group_bind_with_closures(self, source_property, target, target_property, flags, transform_to, transform_from);
		return self;
	}

	public static MentorLake.GObject.GObjectHandle DupSource(this MentorLake.GObject.GBindingGroupHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GBindingGroupHandle)");
		return GBindingGroupHandleExterns.g_binding_group_dup_source(self);
	}

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
