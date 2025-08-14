namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkFixed widget is a container which can place child widgets
/// at fixed positions and with fixed sizes, given in pixels. #GtkFixed
/// performs no automatic layout management.
/// </para>
/// <para>
/// For most applications, you should not use this container! It keeps
/// you from having to learn about the other GTK+ containers, but it
/// results in broken applications.  With #GtkFixed, the following
/// things will result in truncated text, overlapping widgets, and
/// other display bugs:
/// </para>
/// <para>
/// - Themes, which may change widget sizes.
/// </para>
/// <para>
/// - Fonts other than the one you used to write the app will of course
///   change the size of widgets containing text; keep in mind that
///   users may use a larger font because of difficulty reading the
///   default, or they may be using a different OS that provides different fonts.
/// </para>
/// <para>
/// - Translation of text into other languages changes its size. Also,
///   display of non-English text will use a different font in many
///   cases.
/// </para>
/// <para>
/// In addition, #GtkFixed does not pay attention to text direction and thus may
/// produce unwanted results if your app is run under right-to-left languages
/// such as Hebrew or Arabic. That is: normally GTK+ will order containers
/// appropriately for the text direction, e.g. to put labels to the right of the
/// thing they label when using an RTL language, but it can’t do that with
/// #GtkFixed. So if you need to reorder widgets depending on the text direction,
/// you would need to manually detect it and adjust child positions accordingly.
/// </para>
/// <para>
/// Finally, fixed positioning makes it kind of annoying to add/remove
/// GUI elements, since you have to reposition all the other
/// elements. This is a long-term maintenance problem for your
/// application.
/// </para>
/// <para>
/// If you know none of these things are an issue for your application,
/// and prefer the simplicity of #GtkFixed, by all means use the
/// widget. But you should be aware of the tradeoffs.
/// </para>
/// <para>
/// See also #GtkLayout, which shares the ability to perform fixed positioning
/// of child widgets and additionally adds custom drawing and scrollability.
/// </para>
/// </summary>

public class GtkFixedHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkFixed.
/// </para>
/// </summary>

/// <return>
/// a new #GtkFixed.
/// </return>

	public static MentorLake.Gtk.GtkFixedHandle New()
	{
		return GtkFixedHandleExterns.gtk_fixed_new();
	}

}

public static class GtkFixedHandleExtensions
{
/// <summary>
/// <para>
/// Moves a child of a #GtkFixed container to the given position.
/// </para>
/// </summary>

/// <param name="@fixed">
/// a #GtkFixed.
/// </param>
/// <param name="widget">
/// the child widget.
/// </param>
/// <param name="x">
/// the horizontal position to move the widget to.
/// </param>
/// <param name="y">
/// the vertical position to move the widget to.
/// </param>

	public static T Move<T>(this T @fixed, MentorLake.Gtk.GtkWidgetHandle widget, int x, int y) where T : GtkFixedHandle
	{
		if (@fixed.IsInvalid) throw new Exception("Invalid handle (GtkFixedHandle)");
		GtkFixedHandleExterns.gtk_fixed_move(@fixed, widget, x, y);
		return @fixed;
	}

/// <summary>
/// <para>
/// Adds a widget to a #GtkFixed container at the given position.
/// </para>
/// </summary>

/// <param name="@fixed">
/// a #GtkFixed.
/// </param>
/// <param name="widget">
/// the widget to add.
/// </param>
/// <param name="x">
/// the horizontal position to place the widget at.
/// </param>
/// <param name="y">
/// the vertical position to place the widget at.
/// </param>

	public static T Put<T>(this T @fixed, MentorLake.Gtk.GtkWidgetHandle widget, int x, int y) where T : GtkFixedHandle
	{
		if (@fixed.IsInvalid) throw new Exception("Invalid handle (GtkFixedHandle)");
		GtkFixedHandleExterns.gtk_fixed_put(@fixed, widget, x, y);
		return @fixed;
	}

}

internal class GtkFixedHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkFixedHandle>))]
	internal static extern MentorLake.Gtk.GtkFixedHandle gtk_fixed_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_fixed_move([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFixedHandle>))] MentorLake.Gtk.GtkFixedHandle @fixed, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int x, int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_fixed_put([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFixedHandle>))] MentorLake.Gtk.GtkFixedHandle @fixed, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int x, int y);

}
