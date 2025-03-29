namespace MentorLake.Gtk;

public class GtkTextChildAnchorHandle : GObjectHandle
{
	public static MentorLake.Gtk.GtkTextChildAnchorHandle New()
	{
		return GtkTextChildAnchorHandleExterns.gtk_text_child_anchor_new();
	}

}

public static class GtkTextChildAnchorHandleExtensions
{
	public static bool GetDeleted(this MentorLake.Gtk.GtkTextChildAnchorHandle anchor)
	{
		if (anchor.IsInvalid || anchor.IsClosed) throw new Exception("Invalid or closed handle (GtkTextChildAnchorHandle)");
		return GtkTextChildAnchorHandleExterns.gtk_text_child_anchor_get_deleted(anchor);
	}

	public static MentorLake.GLib.GListHandle GetWidgets(this MentorLake.Gtk.GtkTextChildAnchorHandle anchor)
	{
		if (anchor.IsInvalid || anchor.IsClosed) throw new Exception("Invalid or closed handle (GtkTextChildAnchorHandle)");
		return GtkTextChildAnchorHandleExterns.gtk_text_child_anchor_get_widgets(anchor);
	}

}

internal class GtkTextChildAnchorHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTextChildAnchorHandle gtk_text_child_anchor_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_child_anchor_get_deleted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextChildAnchorHandle>))] MentorLake.Gtk.GtkTextChildAnchorHandle anchor);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle gtk_text_child_anchor_get_widgets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextChildAnchorHandle>))] MentorLake.Gtk.GtkTextChildAnchorHandle anchor);

}
