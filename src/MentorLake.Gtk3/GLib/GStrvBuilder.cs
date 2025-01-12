namespace MentorLake.Gtk3.GLib;

public class GStrvBuilderHandle : BaseSafeHandle
{
	public static GStrvBuilderHandle New()
	{
		return GStrvBuilderExterns.g_strv_builder_new();
	}

}


public static class GStrvBuilderHandleExtensions
{
	public static T Add<T>(this T builder, string value) where T : GStrvBuilderHandle
	{
		GStrvBuilderExterns.g_strv_builder_add(builder, value);
		return builder;
	}

	public static T AddMany<T>(this T builder, IntPtr @__arglist) where T : GStrvBuilderHandle
	{
		GStrvBuilderExterns.g_strv_builder_add_many(builder, @__arglist);
		return builder;
	}

	public static T Addv<T>(this T builder, string[] value) where T : GStrvBuilderHandle
	{
		GStrvBuilderExterns.g_strv_builder_addv(builder, value);
		return builder;
	}

	public static IntPtr End(this GStrvBuilderHandle builder)
	{
		return GStrvBuilderExterns.g_strv_builder_end(builder);
	}

	public static GStrvBuilderHandle Ref(this GStrvBuilderHandle builder)
	{
		return GStrvBuilderExterns.g_strv_builder_ref(builder);
	}

	public static T Take<T>(this T builder, string value) where T : GStrvBuilderHandle
	{
		GStrvBuilderExterns.g_strv_builder_take(builder, value);
		return builder;
	}

	public static T Unref<T>(this T builder) where T : GStrvBuilderHandle
	{
		GStrvBuilderExterns.g_strv_builder_unref(builder);
		return builder;
	}

}
internal class GStrvBuilderExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GStrvBuilderHandle g_strv_builder_new();

	[DllImport(Libraries.GLib)]
	internal static extern void g_strv_builder_add(GStrvBuilderHandle builder, string value);

	[DllImport(Libraries.GLib)]
	internal static extern void g_strv_builder_add_many(GStrvBuilderHandle builder, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern void g_strv_builder_addv(GStrvBuilderHandle builder, string[] value);

	[DllImport(Libraries.GLib)]
	internal static extern IntPtr g_strv_builder_end(GStrvBuilderHandle builder);

	[DllImport(Libraries.GLib)]
	internal static extern GStrvBuilderHandle g_strv_builder_ref(GStrvBuilderHandle builder);

	[DllImport(Libraries.GLib)]
	internal static extern void g_strv_builder_take(GStrvBuilderHandle builder, string value);

	[DllImport(Libraries.GLib)]
	internal static extern void g_strv_builder_unref(GStrvBuilderHandle builder);

}

public struct GStrvBuilder
{
}
