namespace MentorLake.Gtk;

public class GtkEventControllerHandle : GObjectHandle
{
}

public static class GtkEventControllerHandleExtensions
{
	public static MentorLake.Gtk.GtkPropagationPhase GetPropagationPhase(this MentorLake.Gtk.GtkEventControllerHandle controller)
	{
		if (controller.IsInvalid || controller.IsClosed) throw new Exception("Invalid or closed handle (GtkEventControllerHandle)");
		return GtkEventControllerHandleExterns.gtk_event_controller_get_propagation_phase(controller);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetWidget(this MentorLake.Gtk.GtkEventControllerHandle controller)
	{
		if (controller.IsInvalid || controller.IsClosed) throw new Exception("Invalid or closed handle (GtkEventControllerHandle)");
		return GtkEventControllerHandleExterns.gtk_event_controller_get_widget(controller);
	}

	public static bool HandleEvent(this MentorLake.Gtk.GtkEventControllerHandle controller, MentorLake.Gdk.GdkEventHandle @event)
	{
		if (controller.IsInvalid || controller.IsClosed) throw new Exception("Invalid or closed handle (GtkEventControllerHandle)");
		return GtkEventControllerHandleExterns.gtk_event_controller_handle_event(controller, @event);
	}

	public static T Reset<T>(this T controller) where T : GtkEventControllerHandle
	{
		if (controller.IsInvalid || controller.IsClosed) throw new Exception("Invalid or closed handle (GtkEventControllerHandle)");
		GtkEventControllerHandleExterns.gtk_event_controller_reset(controller);
		return controller;
	}

	public static T SetPropagationPhase<T>(this T controller, MentorLake.Gtk.GtkPropagationPhase phase) where T : GtkEventControllerHandle
	{
		if (controller.IsInvalid || controller.IsClosed) throw new Exception("Invalid or closed handle (GtkEventControllerHandle)");
		GtkEventControllerHandleExterns.gtk_event_controller_set_propagation_phase(controller, phase);
		return controller;
	}

}

internal class GtkEventControllerHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPropagationPhase gtk_event_controller_get_propagation_phase([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerHandle>))] MentorLake.Gtk.GtkEventControllerHandle controller);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_event_controller_get_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerHandle>))] MentorLake.Gtk.GtkEventControllerHandle controller);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_event_controller_handle_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerHandle>))] MentorLake.Gtk.GtkEventControllerHandle controller, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_event_controller_reset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerHandle>))] MentorLake.Gtk.GtkEventControllerHandle controller);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_event_controller_set_propagation_phase([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerHandle>))] MentorLake.Gtk.GtkEventControllerHandle controller, MentorLake.Gtk.GtkPropagationPhase phase);

}
