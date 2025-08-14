namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// GtkNumerableIcon is a subclass of #GEmblemedIcon that can
/// show a number or short string as an emblem. The number can
/// be overlayed on top of another emblem, if desired.
/// </para>
/// <para>
/// It supports theming by taking font and color information
/// from a provided #GtkStyleContext; see
/// gtk_numerable_icon_set_style_context().
/// </para>
/// <para>
/// Typical numerable icons:
/// ![](numerableicon.png)
/// ![](numerableicon2.png)
/// </para>
/// </summary>

public class GtkNumerableIconHandle : GEmblemedIconHandle, GIconHandle
{
/// <summary>
/// <para>
/// Creates a new unthemed #GtkNumerableIcon.
/// </para>
/// </summary>

/// <param name="base_icon">
/// a #GIcon to overlay on
/// </param>
/// <return>
/// a new #GIcon
/// </return>

	public static MentorLake.Gio.GIconHandle New(MentorLake.Gio.GIconHandle base_icon)
	{
		return GtkNumerableIconHandleExterns.gtk_numerable_icon_new(base_icon);
	}

/// <summary>
/// <para>
/// Creates a new #GtkNumerableIcon which will themed according
/// to the passed #GtkStyleContext. This is a convenience constructor
/// that calls gtk_numerable_icon_set_style_context() internally.
/// </para>
/// </summary>

/// <param name="base_icon">
/// a #GIcon to overlay on
/// </param>
/// <param name="context">
/// a #GtkStyleContext
/// </param>
/// <return>
/// a new #GIcon
/// </return>

	public static MentorLake.Gio.GIconHandle NewWithStyleContext(MentorLake.Gio.GIconHandle base_icon, MentorLake.Gtk.GtkStyleContextHandle context)
	{
		return GtkNumerableIconHandleExterns.gtk_numerable_icon_new_with_style_context(base_icon, context);
	}

}

public static class GtkNumerableIconHandleExtensions
{
/// <summary>
/// <para>
/// Returns the #GIcon that was set as the base background image, or
/// %NULL if there’s none. The caller of this function does not own
/// a reference to the returned #GIcon.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkNumerableIcon
/// </param>
/// <return>
/// a #GIcon, or %NULL
/// </return>

	public static MentorLake.Gio.GIconHandle GetBackgroundGicon(this MentorLake.Gtk.GtkNumerableIconHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkNumerableIconHandle)");
		return GtkNumerableIconHandleExterns.gtk_numerable_icon_get_background_gicon(self);
	}

/// <summary>
/// <para>
/// Returns the icon name used as the base background image,
/// or %NULL if there’s none.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkNumerableIcon
/// </param>
/// <return>
/// an icon name, or %NULL
/// </return>

	public static string GetBackgroundIconName(this MentorLake.Gtk.GtkNumerableIconHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkNumerableIconHandle)");
		return GtkNumerableIconHandleExterns.gtk_numerable_icon_get_background_icon_name(self);
	}

/// <summary>
/// <para>
/// Returns the value currently displayed by @self.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkNumerableIcon
/// </param>
/// <return>
/// the currently displayed value
/// </return>

	public static int GetCount(this MentorLake.Gtk.GtkNumerableIconHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkNumerableIconHandle)");
		return GtkNumerableIconHandleExterns.gtk_numerable_icon_get_count(self);
	}

/// <summary>
/// <para>
/// Returns the currently displayed label of the icon, or %NULL.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkNumerableIcon
/// </param>
/// <return>
/// the currently displayed label
/// </return>

	public static string GetLabel(this MentorLake.Gtk.GtkNumerableIconHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkNumerableIconHandle)");
		return GtkNumerableIconHandleExterns.gtk_numerable_icon_get_label(self);
	}

/// <summary>
/// <para>
/// Returns the #GtkStyleContext used by the icon for theming,
/// or %NULL if there’s none.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkNumerableIcon
/// </param>
/// <return>
/// a #GtkStyleContext, or %NULL.
///     This object is internal to GTK+ and should not be unreffed.
///     Use g_object_ref() if you want to keep it around
/// </return>

	public static MentorLake.Gtk.GtkStyleContextHandle GetStyleContext(this MentorLake.Gtk.GtkNumerableIconHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkNumerableIconHandle)");
		return GtkNumerableIconHandleExterns.gtk_numerable_icon_get_style_context(self);
	}

/// <summary>
/// <para>
/// Updates the icon to use @icon as the base background image.
/// If @icon is %NULL, @self will go back using style information
/// or default theming for its background image.
/// </para>
/// <para>
/// If this method is called and an icon name was already set as
/// background for the icon, @icon will be used, i.e. the last method
/// called between gtk_numerable_icon_set_background_gicon() and
/// gtk_numerable_icon_set_background_icon_name() has always priority.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkNumerableIcon
/// </param>
/// <param name="icon">
/// a #GIcon, or %NULL
/// </param>

	public static T SetBackgroundGicon<T>(this T self, MentorLake.Gio.GIconHandle icon) where T : GtkNumerableIconHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkNumerableIconHandle)");
		GtkNumerableIconHandleExterns.gtk_numerable_icon_set_background_gicon(self, icon);
		return self;
	}

/// <summary>
/// <para>
/// Updates the icon to use the icon named @icon_name from the
/// current icon theme as the base background image. If @icon_name
/// is %NULL, @self will go back using style information or default
/// theming for its background image.
/// </para>
/// <para>
/// If this method is called and a #GIcon was already set as
/// background for the icon, @icon_name will be used, i.e. the
/// last method called between gtk_numerable_icon_set_background_icon_name()
/// and gtk_numerable_icon_set_background_gicon() has always priority.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkNumerableIcon
/// </param>
/// <param name="icon_name">
/// an icon name, or %NULL
/// </param>

	public static T SetBackgroundIconName<T>(this T self, string icon_name) where T : GtkNumerableIconHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkNumerableIconHandle)");
		GtkNumerableIconHandleExterns.gtk_numerable_icon_set_background_icon_name(self, icon_name);
		return self;
	}

/// <summary>
/// <para>
/// Sets the currently displayed value of @self to @count.
/// </para>
/// <para>
/// The numeric value is always clamped to make it two digits, i.e.
/// between -99 and 99. Setting a count of zero removes the emblem.
/// If this method is called, and a label was already set on the icon,
/// it will automatically be reset to %NULL before rendering the number,
/// i.e. the last method called between gtk_numerable_icon_set_count()
/// and gtk_numerable_icon_set_label() has always priority.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkNumerableIcon
/// </param>
/// <param name="count">
/// a number between -99 and 99
/// </param>

	public static T SetCount<T>(this T self, int count) where T : GtkNumerableIconHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkNumerableIconHandle)");
		GtkNumerableIconHandleExterns.gtk_numerable_icon_set_count(self, count);
		return self;
	}

/// <summary>
/// <para>
/// Sets the currently displayed value of @self to the string
/// in @label. Setting an empty label removes the emblem.
/// </para>
/// <para>
/// Note that this is meant for displaying short labels, such as
/// roman numbers, or single letters. For roman numbers, consider
/// using the Unicode characters U+2160 - U+217F. Strings longer
/// than two characters will likely not be rendered very well.
/// </para>
/// <para>
/// If this method is called, and a number was already set on the
/// icon, it will automatically be reset to zero before rendering
/// the label, i.e. the last method called between
/// gtk_numerable_icon_set_label() and gtk_numerable_icon_set_count()
/// has always priority.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkNumerableIcon
/// </param>
/// <param name="label">
/// a short label, or %NULL
/// </param>

	public static T SetLabel<T>(this T self, string label) where T : GtkNumerableIconHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkNumerableIconHandle)");
		GtkNumerableIconHandleExterns.gtk_numerable_icon_set_label(self, label);
		return self;
	}

/// <summary>
/// <para>
/// Updates the icon to fetch theme information from the
/// given #GtkStyleContext.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkNumerableIcon
/// </param>
/// <param name="style">
/// a #GtkStyleContext
/// </param>

	public static T SetStyleContext<T>(this T self, MentorLake.Gtk.GtkStyleContextHandle style) where T : GtkNumerableIconHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkNumerableIconHandle)");
		GtkNumerableIconHandleExterns.gtk_numerable_icon_set_style_context(self, style);
		return self;
	}

}

internal class GtkNumerableIconHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))]
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
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle gtk_numerable_icon_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle base_icon);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))]
	internal static extern MentorLake.Gio.GIconHandle gtk_numerable_icon_new_with_style_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle base_icon, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleContextHandle>))] MentorLake.Gtk.GtkStyleContextHandle context);

}
