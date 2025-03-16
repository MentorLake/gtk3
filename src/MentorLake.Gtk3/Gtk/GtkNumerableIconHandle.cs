namespace MentorLake.Gtk;

public class GtkNumerableIconHandle : GEmblemedIconHandle, GIconHandle
{
	public static MentorLake.Gio.GIconHandle New(MentorLake.Gio.GIconHandle base_icon)
	{
		return GtkNumerableIconHandleExterns.gtk_numerable_icon_new(base_icon);
	}

	public static MentorLake.Gio.GIconHandle NewWithStyleContext(MentorLake.Gio.GIconHandle base_icon, MentorLake.Gtk.GtkStyleContextHandle context)
	{
		return GtkNumerableIconHandleExterns.gtk_numerable_icon_new_with_style_context(base_icon, context);
	}

}

public static class GtkNumerableIconHandleExtensions
{
	public static MentorLake.Gio.GIconHandle GetBackgroundGicon(this MentorLake.Gtk.GtkNumerableIconHandle self)
	{
		return GtkNumerableIconHandleExterns.gtk_numerable_icon_get_background_gicon(self);
	}

	public static string GetBackgroundIconName(this MentorLake.Gtk.GtkNumerableIconHandle self)
	{
		return GtkNumerableIconHandleExterns.gtk_numerable_icon_get_background_icon_name(self);
	}

	public static int GetCount(this MentorLake.Gtk.GtkNumerableIconHandle self)
	{
		return GtkNumerableIconHandleExterns.gtk_numerable_icon_get_count(self);
	}

	public static string GetLabel(this MentorLake.Gtk.GtkNumerableIconHandle self)
	{
		return GtkNumerableIconHandleExterns.gtk_numerable_icon_get_label(self);
	}

	public static MentorLake.Gtk.GtkStyleContextHandle GetStyleContext(this MentorLake.Gtk.GtkNumerableIconHandle self)
	{
		return GtkNumerableIconHandleExterns.gtk_numerable_icon_get_style_context(self);
	}

	public static T SetBackgroundGicon<T>(this T self, MentorLake.Gio.GIconHandle icon) where T : GtkNumerableIconHandle
	{
		GtkNumerableIconHandleExterns.gtk_numerable_icon_set_background_gicon(self, icon);
		return self;
	}

	public static T SetBackgroundIconName<T>(this T self, string icon_name) where T : GtkNumerableIconHandle
	{
		GtkNumerableIconHandleExterns.gtk_numerable_icon_set_background_icon_name(self, icon_name);
		return self;
	}

	public static T SetCount<T>(this T self, int count) where T : GtkNumerableIconHandle
	{
		GtkNumerableIconHandleExterns.gtk_numerable_icon_set_count(self, count);
		return self;
	}

	public static T SetLabel<T>(this T self, string label) where T : GtkNumerableIconHandle
	{
		GtkNumerableIconHandleExterns.gtk_numerable_icon_set_label(self, label);
		return self;
	}

	public static T SetStyleContext<T>(this T self, MentorLake.Gtk.GtkStyleContextHandle style) where T : GtkNumerableIconHandle
	{
		GtkNumerableIconHandleExterns.gtk_numerable_icon_set_style_context(self, style);
		return self;
	}

}

internal class GtkNumerableIconHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle gtk_numerable_icon_get_background_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNumerableIconHandle>))] MentorLake.Gtk.GtkNumerableIconHandle self);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_numerable_icon_get_background_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNumerableIconHandle>))] MentorLake.Gtk.GtkNumerableIconHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_numerable_icon_get_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNumerableIconHandle>))] MentorLake.Gtk.GtkNumerableIconHandle self);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_numerable_icon_get_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNumerableIconHandle>))] MentorLake.Gtk.GtkNumerableIconHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStyleContextHandle gtk_numerable_icon_get_style_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNumerableIconHandle>))] MentorLake.Gtk.GtkNumerableIconHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_numerable_icon_set_background_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNumerableIconHandle>))] MentorLake.Gtk.GtkNumerableIconHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_numerable_icon_set_background_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNumerableIconHandle>))] MentorLake.Gtk.GtkNumerableIconHandle self, string icon_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_numerable_icon_set_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNumerableIconHandle>))] MentorLake.Gtk.GtkNumerableIconHandle self, int count);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_numerable_icon_set_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNumerableIconHandle>))] MentorLake.Gtk.GtkNumerableIconHandle self, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_numerable_icon_set_style_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNumerableIconHandle>))] MentorLake.Gtk.GtkNumerableIconHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle style);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle gtk_numerable_icon_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle base_icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gio.GIconHandle gtk_numerable_icon_new_with_style_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle base_icon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

}
