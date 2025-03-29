namespace MentorLake.Gtk;

public class GtkMiscHandle : GtkWidgetHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
}

public static class GtkMiscHandleExtensions
{
	public static T GetAlignment<T>(this T misc, out float xalign, out float yalign) where T : GtkMiscHandle
	{
		if (misc.IsInvalid || misc.IsClosed) throw new Exception("Invalid or closed handle (GtkMiscHandle)");
		GtkMiscHandleExterns.gtk_misc_get_alignment(misc, out xalign, out yalign);
		return misc;
	}

	public static T GetPadding<T>(this T misc, out int xpad, out int ypad) where T : GtkMiscHandle
	{
		if (misc.IsInvalid || misc.IsClosed) throw new Exception("Invalid or closed handle (GtkMiscHandle)");
		GtkMiscHandleExterns.gtk_misc_get_padding(misc, out xpad, out ypad);
		return misc;
	}

	public static T SetAlignment<T>(this T misc, float xalign, float yalign) where T : GtkMiscHandle
	{
		if (misc.IsInvalid || misc.IsClosed) throw new Exception("Invalid or closed handle (GtkMiscHandle)");
		GtkMiscHandleExterns.gtk_misc_set_alignment(misc, xalign, yalign);
		return misc;
	}

	public static T SetPadding<T>(this T misc, int xpad, int ypad) where T : GtkMiscHandle
	{
		if (misc.IsInvalid || misc.IsClosed) throw new Exception("Invalid or closed handle (GtkMiscHandle)");
		GtkMiscHandleExterns.gtk_misc_set_padding(misc, xpad, ypad);
		return misc;
	}

}

internal class GtkMiscHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_misc_get_alignment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMiscHandle>))] MentorLake.Gtk.GtkMiscHandle misc, out float xalign, out float yalign);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_misc_get_padding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMiscHandle>))] MentorLake.Gtk.GtkMiscHandle misc, out int xpad, out int ypad);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_misc_set_alignment([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMiscHandle>))] MentorLake.Gtk.GtkMiscHandle misc, float xalign, float yalign);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_misc_set_padding([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkMiscHandle>))] MentorLake.Gtk.GtkMiscHandle misc, int xpad, int ypad);

}
