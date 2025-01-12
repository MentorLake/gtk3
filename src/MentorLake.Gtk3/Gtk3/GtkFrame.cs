namespace MentorLake.Gtk3.Gtk3;

public class GtkFrameHandle : GtkBinHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkFrameHandle New(string label)
	{
		return GtkFrameExterns.gtk_frame_new(label);
	}

}

public static class GtkFrameHandleExtensions
{
	public static string GetLabel(this GtkFrameHandle frame)
	{
		return GtkFrameExterns.gtk_frame_get_label(frame);
	}

	public static GtkFrameHandle GetLabelAlign(this GtkFrameHandle frame, out float xalign, out float yalign)
	{
		GtkFrameExterns.gtk_frame_get_label_align(frame, out xalign, out yalign);
		return frame;
	}

	public static GtkWidgetHandle GetLabelWidget(this GtkFrameHandle frame)
	{
		return GtkFrameExterns.gtk_frame_get_label_widget(frame);
	}

	public static GtkShadowType GetShadowType(this GtkFrameHandle frame)
	{
		return GtkFrameExterns.gtk_frame_get_shadow_type(frame);
	}

	public static GtkFrameHandle SetLabel(this GtkFrameHandle frame, string label)
	{
		GtkFrameExterns.gtk_frame_set_label(frame, label);
		return frame;
	}

	public static GtkFrameHandle SetLabelAlign(this GtkFrameHandle frame, float xalign, float yalign)
	{
		GtkFrameExterns.gtk_frame_set_label_align(frame, xalign, yalign);
		return frame;
	}

	public static GtkFrameHandle SetLabelWidget(this GtkFrameHandle frame, GtkWidgetHandle label_widget)
	{
		GtkFrameExterns.gtk_frame_set_label_widget(frame, label_widget);
		return frame;
	}

	public static GtkFrameHandle SetShadowType(this GtkFrameHandle frame, GtkShadowType type)
	{
		GtkFrameExterns.gtk_frame_set_shadow_type(frame, type);
		return frame;
	}

}

internal class GtkFrameExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkFrameHandle gtk_frame_new(string label);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_frame_get_label(GtkFrameHandle frame);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_frame_get_label_align(GtkFrameHandle frame, out float xalign, out float yalign);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_frame_get_label_widget(GtkFrameHandle frame);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkShadowType gtk_frame_get_shadow_type(GtkFrameHandle frame);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_frame_set_label(GtkFrameHandle frame, string label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_frame_set_label_align(GtkFrameHandle frame, float xalign, float yalign);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_frame_set_label_widget(GtkFrameHandle frame, GtkWidgetHandle label_widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_frame_set_shadow_type(GtkFrameHandle frame, GtkShadowType type);

}
