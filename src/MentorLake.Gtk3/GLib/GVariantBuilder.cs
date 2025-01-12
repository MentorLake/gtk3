namespace MentorLake.Gtk3.GLib;

public class GVariantBuilderHandle : BaseSafeHandle
{
	public static GVariantBuilderHandle New(GVariantTypeHandle type)
	{
		return GVariantBuilderExterns.g_variant_builder_new(type);
	}

}


public static class GVariantBuilderHandleExtensions
{
	public static T Add<T>(this T builder, string format_string, IntPtr @__arglist) where T : GVariantBuilderHandle
	{
		GVariantBuilderExterns.g_variant_builder_add(builder, format_string, @__arglist);
		return builder;
	}

	public static T AddParsed<T>(this T builder, string format, IntPtr @__arglist) where T : GVariantBuilderHandle
	{
		GVariantBuilderExterns.g_variant_builder_add_parsed(builder, format, @__arglist);
		return builder;
	}

	public static T AddValue<T>(this T builder, GVariantHandle value) where T : GVariantBuilderHandle
	{
		GVariantBuilderExterns.g_variant_builder_add_value(builder, value);
		return builder;
	}

	public static T Clear<T>(this T builder) where T : GVariantBuilderHandle
	{
		GVariantBuilderExterns.g_variant_builder_clear(builder);
		return builder;
	}

	public static T Close<T>(this T builder) where T : GVariantBuilderHandle
	{
		GVariantBuilderExterns.g_variant_builder_close(builder);
		return builder;
	}

	public static GVariantHandle End(this GVariantBuilderHandle builder)
	{
		return GVariantBuilderExterns.g_variant_builder_end(builder);
	}

	public static T Init<T>(this T builder, GVariantTypeHandle type) where T : GVariantBuilderHandle
	{
		GVariantBuilderExterns.g_variant_builder_init(builder, type);
		return builder;
	}

	public static T Open<T>(this T builder, GVariantTypeHandle type) where T : GVariantBuilderHandle
	{
		GVariantBuilderExterns.g_variant_builder_open(builder, type);
		return builder;
	}

	public static GVariantBuilderHandle Ref(this GVariantBuilderHandle builder)
	{
		return GVariantBuilderExterns.g_variant_builder_ref(builder);
	}

	public static T Unref<T>(this T builder) where T : GVariantBuilderHandle
	{
		GVariantBuilderExterns.g_variant_builder_unref(builder);
		return builder;
	}

}
internal class GVariantBuilderExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern GVariantBuilderHandle g_variant_builder_new(GVariantTypeHandle type);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_builder_add(GVariantBuilderHandle builder, string format_string, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_builder_add_parsed(GVariantBuilderHandle builder, string format, IntPtr @__arglist);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_builder_add_value(GVariantBuilderHandle builder, GVariantHandle value);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_builder_clear(GVariantBuilderHandle builder);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_builder_close(GVariantBuilderHandle builder);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantHandle g_variant_builder_end(GVariantBuilderHandle builder);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_builder_init(GVariantBuilderHandle builder, GVariantTypeHandle type);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_builder_open(GVariantBuilderHandle builder, GVariantTypeHandle type);

	[DllImport(Libraries.GLib)]
	internal static extern GVariantBuilderHandle g_variant_builder_ref(GVariantBuilderHandle builder);

	[DllImport(Libraries.GLib)]
	internal static extern void g_variant_builder_unref(GVariantBuilderHandle builder);

}

public struct GVariantBuilder
{
}
