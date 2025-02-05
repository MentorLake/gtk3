namespace MentorLake.Gtk3.GObject;

public class GBindingGroupHandle : GObjectHandle
{
	public static GBindingGroupHandle New()
	{
		return GBindingGroupExterns.g_binding_group_new();
	}

}

public static class GBindingGroupHandleExtensions
{
	public static T Bind<T>(this T self, string source_property, GObjectHandle target, string target_property, GBindingFlags flags) where T : GBindingGroupHandle
	{
		GBindingGroupExterns.g_binding_group_bind(self, source_property, target, target_property, flags);
		return self;
	}

	public static T BindFull<T>(this T self, string source_property, GObjectHandle target, string target_property, GBindingFlags flags, GBindingTransformFunc transform_to, GBindingTransformFunc transform_from, IntPtr user_data, GDestroyNotify user_data_destroy) where T : GBindingGroupHandle
	{
		GBindingGroupExterns.g_binding_group_bind_full(self, source_property, target, target_property, flags, transform_to, transform_from, user_data, user_data_destroy);
		return self;
	}

	public static T BindWithClosures<T>(this T self, string source_property, GObjectHandle target, string target_property, GBindingFlags flags, GClosureHandle transform_to, GClosureHandle transform_from) where T : GBindingGroupHandle
	{
		GBindingGroupExterns.g_binding_group_bind_with_closures(self, source_property, target, target_property, flags, transform_to, transform_from);
		return self;
	}

	public static GObjectHandle DupSource(this GBindingGroupHandle self)
	{
		return GBindingGroupExterns.g_binding_group_dup_source(self);
	}

	public static T SetSource<T>(this T self, GObjectHandle source) where T : GBindingGroupHandle
	{
		GBindingGroupExterns.g_binding_group_set_source(self, source);
		return self;
	}

}

internal class GBindingGroupExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern GBindingGroupHandle g_binding_group_new();

	[DllImport(Libraries.GObject)]
	internal static extern void g_binding_group_bind(GBindingGroupHandle self, string source_property, GObjectHandle target, string target_property, GBindingFlags flags);

	[DllImport(Libraries.GObject)]
	internal static extern void g_binding_group_bind_full(GBindingGroupHandle self, string source_property, GObjectHandle target, string target_property, GBindingFlags flags, GBindingTransformFunc transform_to, GBindingTransformFunc transform_from, IntPtr user_data, GDestroyNotify user_data_destroy);

	[DllImport(Libraries.GObject)]
	internal static extern void g_binding_group_bind_with_closures(GBindingGroupHandle self, string source_property, GObjectHandle target, string target_property, GBindingFlags flags, GClosureHandle transform_to, GClosureHandle transform_from);

	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_binding_group_dup_source(GBindingGroupHandle self);

	[DllImport(Libraries.GObject)]
	internal static extern void g_binding_group_set_source(GBindingGroupHandle self, GObjectHandle source);

}
