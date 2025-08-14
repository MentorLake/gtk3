namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkEventController is a base, low-level implementation for event
/// controllers. Those react to a series of #GdkEvents, and possibly trigger
/// actions as a consequence of those.
/// </para>
/// </summary>

public class GtkEventControllerHandle : GObjectHandle
{
}

public static class GtkEventControllerHandleExtensions
{
/// <summary>
/// <para>
/// Gets the propagation phase at which @controller handles events.
/// </para>
/// </summary>

/// <param name="controller">
/// a #GtkEventController
/// </param>
/// <return>
/// the propagation phase
/// </return>

	public static MentorLake.Gtk.GtkPropagationPhase GetPropagationPhase(this MentorLake.Gtk.GtkEventControllerHandle controller)
	{
		if (controller.IsInvalid) throw new Exception("Invalid handle (GtkEventControllerHandle)");
		return GtkEventControllerHandleExterns.gtk_event_controller_get_propagation_phase(controller);
	}

/// <summary>
/// <para>
/// Returns the #GtkWidget this controller relates to.
/// </para>
/// </summary>

/// <param name="controller">
/// a #GtkEventController
/// </param>
/// <return>
/// a #GtkWidget
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetWidget(this MentorLake.Gtk.GtkEventControllerHandle controller)
	{
		if (controller.IsInvalid) throw new Exception("Invalid handle (GtkEventControllerHandle)");
		return GtkEventControllerHandleExterns.gtk_event_controller_get_widget(controller);
	}

/// <summary>
/// <para>
/// Feeds an events into @controller, so it can be interpreted
/// and the controller actions triggered.
/// </para>
/// </summary>

/// <param name="controller">
/// a #GtkEventController
/// </param>
/// <param name="@event">
/// a #GdkEvent
/// </param>
/// <return>
/// %TRUE if the event was potentially useful to trigger the
///          controller action
/// </return>

	public static bool HandleEvent(this MentorLake.Gtk.GtkEventControllerHandle controller, MentorLake.Gdk.GdkEventHandle @event)
	{
		if (controller.IsInvalid) throw new Exception("Invalid handle (GtkEventControllerHandle)");
		return GtkEventControllerHandleExterns.gtk_event_controller_handle_event(controller, @event);
	}

/// <summary>
/// <para>
/// Resets the @controller to a clean state. Every interaction
/// the controller did through #GtkEventController::handle-event
/// will be dropped at this point.
/// </para>
/// </summary>

/// <param name="controller">
/// a #GtkEventController
/// </param>

	public static T Reset<T>(this T controller) where T : GtkEventControllerHandle
	{
		if (controller.IsInvalid) throw new Exception("Invalid handle (GtkEventControllerHandle)");
		GtkEventControllerHandleExterns.gtk_event_controller_reset(controller);
		return controller;
	}

/// <summary>
/// <para>
/// Sets the propagation phase at which a controller handles events.
/// </para>
/// <para>
/// If @phase is %GTK_PHASE_NONE, no automatic event handling will be
/// performed, but other additional gesture maintenance will. In that phase,
/// the events can be managed by calling gtk_event_controller_handle_event().
/// </para>
/// </summary>

/// <param name="controller">
/// a #GtkEventController
/// </param>
/// <param name="phase">
/// a propagation phase
/// </param>

	public static T SetPropagationPhase<T>(this T controller, MentorLake.Gtk.GtkPropagationPhase phase) where T : GtkEventControllerHandle
	{
		if (controller.IsInvalid) throw new Exception("Invalid handle (GtkEventControllerHandle)");
		GtkEventControllerHandleExterns.gtk_event_controller_set_propagation_phase(controller, phase);
		return controller;
	}

}

internal class GtkEventControllerHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPropagationPhase gtk_event_controller_get_propagation_phase([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerHandle>))] MentorLake.Gtk.GtkEventControllerHandle controller);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_event_controller_get_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerHandle>))] MentorLake.Gtk.GtkEventControllerHandle controller);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_event_controller_handle_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerHandle>))] MentorLake.Gtk.GtkEventControllerHandle controller, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_event_controller_reset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerHandle>))] MentorLake.Gtk.GtkEventControllerHandle controller);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_event_controller_set_propagation_phase([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEventControllerHandle>))] MentorLake.Gtk.GtkEventControllerHandle controller, MentorLake.Gtk.GtkPropagationPhase phase);

}
