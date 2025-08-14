namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkShortcutLabel is a widget that represents a single keyboard shortcut or gesture
/// in the user interface.
/// </para>
/// </summary>

public class GtkShortcutLabelHandle : GtkBoxHandle, AtkImplementorIfaceHandle, GtkBuildableHandle, GtkOrientableHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkShortcutLabel with @accelerator set.
/// </para>
/// </summary>

/// <param name="accelerator">
/// the initial accelerator
/// </param>
/// <return>
/// a newly-allocated #GtkShortcutLabel
/// </return>

	public static MentorLake.Gtk.GtkShortcutLabelHandle New(string accelerator)
	{
		return GtkShortcutLabelHandleExterns.gtk_shortcut_label_new(accelerator);
	}

}

public static class GtkShortcutLabelHandleExtensions
{
/// <summary>
/// <para>
/// Retrieves the current accelerator of @self.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkShortcutLabel
/// </param>
/// <return>
/// the current accelerator.
/// </return>

	public static string GetAccelerator(this MentorLake.Gtk.GtkShortcutLabelHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkShortcutLabelHandle)");
		return GtkShortcutLabelHandleExterns.gtk_shortcut_label_get_accelerator(self);
	}

/// <summary>
/// <para>
/// Retrieves the text that is displayed when no accelerator is set.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkShortcutLabel
/// </param>
/// <return>
/// the current text displayed when no
/// accelerator is set.
/// </return>

	public static string GetDisabledText(this MentorLake.Gtk.GtkShortcutLabelHandle self)
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkShortcutLabelHandle)");
		return GtkShortcutLabelHandleExterns.gtk_shortcut_label_get_disabled_text(self);
	}

/// <summary>
/// <para>
/// Sets the accelerator to be displayed by @self.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkShortcutLabel
/// </param>
/// <param name="accelerator">
/// the new accelerator
/// </param>

	public static T SetAccelerator<T>(this T self, string accelerator) where T : GtkShortcutLabelHandle
	{
		if (self.IsInvalid) throw new Exception("Invalid handle (GtkShortcutLabelHandle)");
		GtkShortcutLabelHandleExterns.gtk_shortcut_label_set_accelerator(self, accelerator);
		return self;
	}

/// <summary>
/// <para>
/// Sets the text to be displayed by @self when no accelerator is set.
/// </para>
/// </summary>

/// <param name="self">
/// a #GtkShortcutLabel
/// </param>
/// <param name="disabled_text">
/// the text to be displayed when no accelerator is set
/// </param>

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
