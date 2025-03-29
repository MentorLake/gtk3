namespace MentorLake.Gtk;

public class GtkArrowHandle : GtkMiscHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkArrowHandle New(MentorLake.Gtk.GtkArrowType arrow_type, MentorLake.Gtk.GtkShadowType shadow_type)
	{
		return GtkArrowHandleExterns.gtk_arrow_new(arrow_type, shadow_type);
	}

}

public static class GtkArrowHandleExtensions
{
	public static T Set<T>(this T arrow, MentorLake.Gtk.GtkArrowType arrow_type, MentorLake.Gtk.GtkShadowType shadow_type) where T : GtkArrowHandle
	{
		if (arrow.IsInvalid || arrow.IsClosed) throw new Exception("Invalid or closed handle (GtkArrowHandle)");
		GtkArrowHandleExterns.gtk_arrow_set(arrow, arrow_type, shadow_type);
		return arrow;
	}

}

internal class GtkArrowHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkArrowHandle gtk_arrow_new(MentorLake.Gtk.GtkArrowType arrow_type, MentorLake.Gtk.GtkShadowType shadow_type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_arrow_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkArrowHandle>))] MentorLake.Gtk.GtkArrowHandle arrow, MentorLake.Gtk.GtkArrowType arrow_type, MentorLake.Gtk.GtkShadowType shadow_type);

}
