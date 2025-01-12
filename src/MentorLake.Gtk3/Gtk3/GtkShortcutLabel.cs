namespace MentorLake.Gtk3.Gtk3;

public class GtkShortcutLabelHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
	public static GtkShortcutLabelHandle New(string accelerator)
	{
		return GtkShortcutLabelExterns.gtk_shortcut_label_new(accelerator);
	}

}

public static class GtkShortcutLabelHandleExtensions
{
	public static string GetAccelerator(this GtkShortcutLabelHandle self)
	{
		return GtkShortcutLabelExterns.gtk_shortcut_label_get_accelerator(self);
	}

	public static string GetDisabledText(this GtkShortcutLabelHandle self)
	{
		return GtkShortcutLabelExterns.gtk_shortcut_label_get_disabled_text(self);
	}

	public static T SetAccelerator<T>(this T self, string accelerator) where T : GtkShortcutLabelHandle
	{
		GtkShortcutLabelExterns.gtk_shortcut_label_set_accelerator(self, accelerator);
		return self;
	}

	public static T SetDisabledText<T>(this T self, string disabled_text) where T : GtkShortcutLabelHandle
	{
		GtkShortcutLabelExterns.gtk_shortcut_label_set_disabled_text(self, disabled_text);
		return self;
	}

}

internal class GtkShortcutLabelExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkShortcutLabelHandle gtk_shortcut_label_new(string accelerator);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_shortcut_label_get_accelerator(GtkShortcutLabelHandle self);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_shortcut_label_get_disabled_text(GtkShortcutLabelHandle self);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_shortcut_label_set_accelerator(GtkShortcutLabelHandle self, string accelerator);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_shortcut_label_set_disabled_text(GtkShortcutLabelHandle self, string disabled_text);

}
