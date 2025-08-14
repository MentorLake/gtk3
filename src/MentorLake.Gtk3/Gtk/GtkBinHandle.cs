namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// The #GtkBin widget is a container with just one child.
/// It is not very useful itself, but it is useful for deriving subclasses,
/// since it provides common code needed for handling a single child widget.
/// </para>
/// <para>
/// Many GTK+ widgets are subclasses of #GtkBin, including #GtkWindow,
/// #GtkButton, #GtkFrame, #GtkHandleBox or #GtkScrolledWindow.
/// </para>
/// </summary>

public class GtkBinHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
}

public static class GtkBinHandleExtensions
{
/// <summary>
/// <para>
/// Gets the child of the #GtkBin, or %NULL if the bin contains
/// no child widget. The returned widget does not have a reference
/// added, so you do not need to unref it.
/// </para>
/// </summary>

/// <param name="bin">
/// a #GtkBin
/// </param>
/// <return>
/// the child of @bin, or %NULL if it does
/// not have a child.
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetChild(this MentorLake.Gtk.GtkBinHandle bin)
	{
		if (bin.IsInvalid) throw new Exception("Invalid handle (GtkBinHandle)");
		return GtkBinHandleExterns.gtk_bin_get_child(bin);
	}

}

internal class GtkBinHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_bin_get_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkBinHandle>))] MentorLake.Gtk.GtkBinHandle bin);

}
