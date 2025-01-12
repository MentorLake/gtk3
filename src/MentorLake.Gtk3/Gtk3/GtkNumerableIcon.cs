namespace MentorLake.Gtk3.Gtk3;

public class GtkNumerableIconHandle : GEmblemedIconHandle, GIconHandle
{
	public static GIconHandle New(GIconHandle base_icon)
	{
		return GtkNumerableIconExterns.gtk_numerable_icon_new(base_icon);
	}

	public static GIconHandle NewWithStyleContext(GIconHandle base_icon, GtkStyleContextHandle context)
	{
		return GtkNumerableIconExterns.gtk_numerable_icon_new_with_style_context(base_icon, context);
	}

}

public static class GtkNumerableIconHandleExtensions
{
	public static GIconHandle GetBackgroundGicon(this GtkNumerableIconHandle self)
	{
		return GtkNumerableIconExterns.gtk_numerable_icon_get_background_gicon(self);
	}

	public static string GetBackgroundIconName(this GtkNumerableIconHandle self)
	{
		return GtkNumerableIconExterns.gtk_numerable_icon_get_background_icon_name(self);
	}

	public static int GetCount(this GtkNumerableIconHandle self)
	{
		return GtkNumerableIconExterns.gtk_numerable_icon_get_count(self);
	}

	public static string GetLabel(this GtkNumerableIconHandle self)
	{
		return GtkNumerableIconExterns.gtk_numerable_icon_get_label(self);
	}

	public static GtkStyleContextHandle GetStyleContext(this GtkNumerableIconHandle self)
	{
		return GtkNumerableIconExterns.gtk_numerable_icon_get_style_context(self);
	}

	public static T SetBackgroundGicon<T>(this T self, GIconHandle icon) where T : GtkNumerableIconHandle
	{
		GtkNumerableIconExterns.gtk_numerable_icon_set_background_gicon(self, icon);
		return self;
	}

	public static T SetBackgroundIconName<T>(this T self, string icon_name) where T : GtkNumerableIconHandle
	{
		GtkNumerableIconExterns.gtk_numerable_icon_set_background_icon_name(self, icon_name);
		return self;
	}

	public static T SetCount<T>(this T self, int count) where T : GtkNumerableIconHandle
	{
		GtkNumerableIconExterns.gtk_numerable_icon_set_count(self, count);
		return self;
	}

	public static T SetLabel<T>(this T self, string label) where T : GtkNumerableIconHandle
	{
		GtkNumerableIconExterns.gtk_numerable_icon_set_label(self, label);
		return self;
	}

	public static T SetStyleContext<T>(this T self, GtkStyleContextHandle style) where T : GtkNumerableIconHandle
	{
		GtkNumerableIconExterns.gtk_numerable_icon_set_style_context(self, style);
		return self;
	}

}

internal class GtkNumerableIconExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GIconHandle gtk_numerable_icon_get_background_gicon(GtkNumerableIconHandle self);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_numerable_icon_get_background_icon_name(GtkNumerableIconHandle self);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_numerable_icon_get_count(GtkNumerableIconHandle self);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_numerable_icon_get_label(GtkNumerableIconHandle self);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStyleContextHandle gtk_numerable_icon_get_style_context(GtkNumerableIconHandle self);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_numerable_icon_set_background_gicon(GtkNumerableIconHandle self, GIconHandle icon);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_numerable_icon_set_background_icon_name(GtkNumerableIconHandle self, string icon_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_numerable_icon_set_count(GtkNumerableIconHandle self, int count);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_numerable_icon_set_label(GtkNumerableIconHandle self, string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_numerable_icon_set_style_context(GtkNumerableIconHandle self, GtkStyleContextHandle style);

	[DllImport(Libraries.Gtk3)]
	internal static extern GIconHandle gtk_numerable_icon_new(GIconHandle base_icon);

	[DllImport(Libraries.Gtk3)]
	internal static extern GIconHandle gtk_numerable_icon_new_with_style_context(GIconHandle base_icon, GtkStyleContextHandle context);

}
