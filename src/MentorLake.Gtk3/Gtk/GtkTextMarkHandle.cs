namespace MentorLake.Gtk;

public class GtkTextMarkHandle : GObjectHandle
{
	public static MentorLake.Gtk.GtkTextMarkHandle New(string name, bool left_gravity)
	{
		return GtkTextMarkHandleExterns.gtk_text_mark_new(name, left_gravity);
	}

}

public static class GtkTextMarkHandleExtensions
{
	public static MentorLake.Gtk.GtkTextBufferHandle GetBuffer(this MentorLake.Gtk.GtkTextMarkHandle mark)
	{
		if (mark.IsInvalid) throw new Exception("Invalid handle (GtkTextMarkHandle)");
		return GtkTextMarkHandleExterns.gtk_text_mark_get_buffer(mark);
	}

	public static bool GetDeleted(this MentorLake.Gtk.GtkTextMarkHandle mark)
	{
		if (mark.IsInvalid) throw new Exception("Invalid handle (GtkTextMarkHandle)");
		return GtkTextMarkHandleExterns.gtk_text_mark_get_deleted(mark);
	}

	public static bool GetLeftGravity(this MentorLake.Gtk.GtkTextMarkHandle mark)
	{
		if (mark.IsInvalid) throw new Exception("Invalid handle (GtkTextMarkHandle)");
		return GtkTextMarkHandleExterns.gtk_text_mark_get_left_gravity(mark);
	}

	public static string GetName(this MentorLake.Gtk.GtkTextMarkHandle mark)
	{
		if (mark.IsInvalid) throw new Exception("Invalid handle (GtkTextMarkHandle)");
		return GtkTextMarkHandleExterns.gtk_text_mark_get_name(mark);
	}

	public static bool GetVisible(this MentorLake.Gtk.GtkTextMarkHandle mark)
	{
		if (mark.IsInvalid) throw new Exception("Invalid handle (GtkTextMarkHandle)");
		return GtkTextMarkHandleExterns.gtk_text_mark_get_visible(mark);
	}

	public static T SetVisible<T>(this T mark, bool setting) where T : GtkTextMarkHandle
	{
		if (mark.IsInvalid) throw new Exception("Invalid handle (GtkTextMarkHandle)");
		GtkTextMarkHandleExterns.gtk_text_mark_set_visible(mark, setting);
		return mark;
	}

}

internal class GtkTextMarkHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))]
	internal static extern MentorLake.Gtk.GtkTextMarkHandle gtk_text_mark_new(string name, bool left_gravity);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextBufferHandle>))]
	internal static extern MentorLake.Gtk.GtkTextBufferHandle gtk_text_mark_get_buffer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_mark_get_deleted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_mark_get_left_gravity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_text_mark_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_text_mark_get_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_text_mark_set_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTextMarkHandle>))] MentorLake.Gtk.GtkTextMarkHandle mark, bool setting);

}
