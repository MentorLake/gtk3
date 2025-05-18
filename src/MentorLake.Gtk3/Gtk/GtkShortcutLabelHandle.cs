namespace MentorLake.Gtk;

public class GtkShortcutLabelHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static MentorLake.Gtk.GtkShortcutLabelHandle New(string accelerator)
	{
		return GtkShortcutLabelHandleExterns.gtk_shortcut_label_new(accelerator);
	}

}

public static class GtkShortcutLabelHandleExtensions
{
	public static string GetAccelerator(this MentorLake.Gtk.GtkShortcutLabelHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkShortcutLabelHandle)");
		return GtkShortcutLabelHandleExterns.gtk_shortcut_label_get_accelerator(self);
	}

	public static string GetDisabledText(this MentorLake.Gtk.GtkShortcutLabelHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkShortcutLabelHandle)");
		return GtkShortcutLabelHandleExterns.gtk_shortcut_label_get_disabled_text(self);
	}

	public static T SetAccelerator<T>(this T self, string accelerator) where T : GtkShortcutLabelHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkShortcutLabelHandle)");
		GtkShortcutLabelHandleExterns.gtk_shortcut_label_set_accelerator(self, accelerator);
		return self;
	}

	public static T SetDisabledText<T>(this T self, string disabled_text) where T : GtkShortcutLabelHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkShortcutLabelHandle)");
		GtkShortcutLabelHandleExterns.gtk_shortcut_label_set_disabled_text(self, disabled_text);
		return self;
	}

}

internal class GtkShortcutLabelHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkShortcutLabelHandle>))]
	internal static extern MentorLake.Gtk.GtkShortcutLabelHandle gtk_shortcut_label_new(string accelerator);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_shortcut_label_get_accelerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkShortcutLabelHandle>))] MentorLake.Gtk.GtkShortcutLabelHandle self);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_shortcut_label_get_disabled_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkShortcutLabelHandle>))] MentorLake.Gtk.GtkShortcutLabelHandle self);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_shortcut_label_set_accelerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkShortcutLabelHandle>))] MentorLake.Gtk.GtkShortcutLabelHandle self, string accelerator);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_shortcut_label_set_disabled_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkShortcutLabelHandle>))] MentorLake.Gtk.GtkShortcutLabelHandle self, string disabled_text);

}
