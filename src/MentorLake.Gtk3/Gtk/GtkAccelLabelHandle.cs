namespace MentorLake.Gtk;

public class GtkAccelLabelHandle : GtkLabelHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkAccelLabelHandle New(string @string)
	{
		return GtkAccelLabelHandleExterns.gtk_accel_label_new(@string);
	}

}

public static class GtkAccelLabelHandleExtensions
{
	public static T GetAccel<T>(this T accel_label, out uint accelerator_key, out MentorLake.Gdk.GdkModifierType accelerator_mods) where T : GtkAccelLabelHandle
	{
		if (accel_label.IsInvalid || accel_label.IsClosed) throw new Exception("Invalid or closed handle (GtkAccelLabelHandle)");
		GtkAccelLabelHandleExterns.gtk_accel_label_get_accel(accel_label, out accelerator_key, out accelerator_mods);
		return accel_label;
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetAccelWidget(this MentorLake.Gtk.GtkAccelLabelHandle accel_label)
	{
		if (accel_label.IsInvalid || accel_label.IsClosed) throw new Exception("Invalid or closed handle (GtkAccelLabelHandle)");
		return GtkAccelLabelHandleExterns.gtk_accel_label_get_accel_widget(accel_label);
	}

	public static uint GetAccelWidth(this MentorLake.Gtk.GtkAccelLabelHandle accel_label)
	{
		if (accel_label.IsInvalid || accel_label.IsClosed) throw new Exception("Invalid or closed handle (GtkAccelLabelHandle)");
		return GtkAccelLabelHandleExterns.gtk_accel_label_get_accel_width(accel_label);
	}

	public static bool Refetch(this MentorLake.Gtk.GtkAccelLabelHandle accel_label)
	{
		if (accel_label.IsInvalid || accel_label.IsClosed) throw new Exception("Invalid or closed handle (GtkAccelLabelHandle)");
		return GtkAccelLabelHandleExterns.gtk_accel_label_refetch(accel_label);
	}

	public static T SetAccel<T>(this T accel_label, uint accelerator_key, MentorLake.Gdk.GdkModifierType accelerator_mods) where T : GtkAccelLabelHandle
	{
		if (accel_label.IsInvalid || accel_label.IsClosed) throw new Exception("Invalid or closed handle (GtkAccelLabelHandle)");
		GtkAccelLabelHandleExterns.gtk_accel_label_set_accel(accel_label, accelerator_key, accelerator_mods);
		return accel_label;
	}

	public static T SetAccelClosure<T>(this T accel_label, MentorLake.GObject.GClosureHandle accel_closure) where T : GtkAccelLabelHandle
	{
		if (accel_label.IsInvalid || accel_label.IsClosed) throw new Exception("Invalid or closed handle (GtkAccelLabelHandle)");
		GtkAccelLabelHandleExterns.gtk_accel_label_set_accel_closure(accel_label, accel_closure);
		return accel_label;
	}

	public static T SetAccelWidget<T>(this T accel_label, MentorLake.Gtk.GtkWidgetHandle accel_widget) where T : GtkAccelLabelHandle
	{
		if (accel_label.IsInvalid || accel_label.IsClosed) throw new Exception("Invalid or closed handle (GtkAccelLabelHandle)");
		GtkAccelLabelHandleExterns.gtk_accel_label_set_accel_widget(accel_label, accel_widget);
		return accel_label;
	}

}

internal class GtkAccelLabelHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAccelLabelHandle gtk_accel_label_new(string @string);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_label_get_accel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelLabelHandle>))] MentorLake.Gtk.GtkAccelLabelHandle accel_label, out uint accelerator_key, out MentorLake.Gdk.GdkModifierType accelerator_mods);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_accel_label_get_accel_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelLabelHandle>))] MentorLake.Gtk.GtkAccelLabelHandle accel_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_accel_label_get_accel_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelLabelHandle>))] MentorLake.Gtk.GtkAccelLabelHandle accel_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_accel_label_refetch([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelLabelHandle>))] MentorLake.Gtk.GtkAccelLabelHandle accel_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_label_set_accel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelLabelHandle>))] MentorLake.Gtk.GtkAccelLabelHandle accel_label, uint accelerator_key, MentorLake.Gdk.GdkModifierType accelerator_mods);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_label_set_accel_closure([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelLabelHandle>))] MentorLake.Gtk.GtkAccelLabelHandle accel_label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GClosureHandle>))] MentorLake.GObject.GClosureHandle accel_closure);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_accel_label_set_accel_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelLabelHandle>))] MentorLake.Gtk.GtkAccelLabelHandle accel_label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle accel_widget);

}
