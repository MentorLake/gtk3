namespace MentorLake.Gtk;

public class GtkFrameHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkFrameHandle New(string label)
	{
		return GtkFrameHandleExterns.gtk_frame_new(label);
	}

}

public static class GtkFrameHandleExtensions
{
	public static string GetLabel(this MentorLake.Gtk.GtkFrameHandle frame)
	{
		return GtkFrameHandleExterns.gtk_frame_get_label(frame);
	}

	public static T GetLabelAlign<T>(this T frame, out float xalign, out float yalign) where T : GtkFrameHandle
	{
		GtkFrameHandleExterns.gtk_frame_get_label_align(frame, out xalign, out yalign);
		return frame;
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetLabelWidget(this MentorLake.Gtk.GtkFrameHandle frame)
	{
		return GtkFrameHandleExterns.gtk_frame_get_label_widget(frame);
	}

	public static MentorLake.Gtk.GtkShadowType GetShadowType(this MentorLake.Gtk.GtkFrameHandle frame)
	{
		return GtkFrameHandleExterns.gtk_frame_get_shadow_type(frame);
	}

	public static T SetLabel<T>(this T frame, string label) where T : GtkFrameHandle
	{
		GtkFrameHandleExterns.gtk_frame_set_label(frame, label);
		return frame;
	}

	public static T SetLabelAlign<T>(this T frame, float xalign, float yalign) where T : GtkFrameHandle
	{
		GtkFrameHandleExterns.gtk_frame_set_label_align(frame, xalign, yalign);
		return frame;
	}

	public static T SetLabelWidget<T>(this T frame, MentorLake.Gtk.GtkWidgetHandle label_widget) where T : GtkFrameHandle
	{
		GtkFrameHandleExterns.gtk_frame_set_label_widget(frame, label_widget);
		return frame;
	}

	public static T SetShadowType<T>(this T frame, MentorLake.Gtk.GtkShadowType type) where T : GtkFrameHandle
	{
		GtkFrameHandleExterns.gtk_frame_set_shadow_type(frame, type);
		return frame;
	}

}

internal class GtkFrameHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkFrameHandle gtk_frame_new(string label);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_frame_get_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFrameHandle>))] MentorLake.Gtk.GtkFrameHandle frame);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_frame_get_label_align([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFrameHandle>))] MentorLake.Gtk.GtkFrameHandle frame, out float xalign, out float yalign);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_frame_get_label_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFrameHandle>))] MentorLake.Gtk.GtkFrameHandle frame);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkShadowType gtk_frame_get_shadow_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFrameHandle>))] MentorLake.Gtk.GtkFrameHandle frame);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_frame_set_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFrameHandle>))] MentorLake.Gtk.GtkFrameHandle frame, string label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_frame_set_label_align([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFrameHandle>))] MentorLake.Gtk.GtkFrameHandle frame, float xalign, float yalign);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_frame_set_label_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFrameHandle>))] MentorLake.Gtk.GtkFrameHandle frame, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle label_widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_frame_set_shadow_type([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkFrameHandle>))] MentorLake.Gtk.GtkFrameHandle frame, MentorLake.Gtk.GtkShadowType type);

}
