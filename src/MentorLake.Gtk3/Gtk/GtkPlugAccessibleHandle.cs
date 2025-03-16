namespace MentorLake.Gtk;

public class GtkPlugAccessibleHandle : GtkWindowAccessibleHandle, AtkComponentHandle, AtkWindowHandle
{
}

public static class GtkPlugAccessibleHandleExtensions
{
	public static string GetId(this MentorLake.Gtk.GtkPlugAccessibleHandle plug)
	{
		return GtkPlugAccessibleHandleExterns.gtk_plug_accessible_get_id(plug);
	}

}

internal class GtkPlugAccessibleHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_plug_accessible_get_id([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkPlugAccessibleHandle>))] MentorLake.Gtk.GtkPlugAccessibleHandle plug);

}
