namespace MentorLake.Gtk3.Gtk3;

public class GtkEventControllerHandle : GObjectHandle
{
}

public static class GtkEventControllerHandleExtensions
{
	public static GtkPropagationPhase GetPropagationPhase(this GtkEventControllerHandle controller)
	{
		return GtkEventControllerExterns.gtk_event_controller_get_propagation_phase(controller);
	}

	public static GtkWidgetHandle GetWidget(this GtkEventControllerHandle controller)
	{
		return GtkEventControllerExterns.gtk_event_controller_get_widget(controller);
	}

	public static bool HandleEvent(this GtkEventControllerHandle controller, GdkEventHandle @event)
	{
		return GtkEventControllerExterns.gtk_event_controller_handle_event(controller, @event);
	}

	public static GtkEventControllerHandle Reset(this GtkEventControllerHandle controller)
	{
		GtkEventControllerExterns.gtk_event_controller_reset(controller);
		return controller;
	}

	public static GtkEventControllerHandle SetPropagationPhase(this GtkEventControllerHandle controller, GtkPropagationPhase phase)
	{
		GtkEventControllerExterns.gtk_event_controller_set_propagation_phase(controller, phase);
		return controller;
	}

}

internal class GtkEventControllerExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPropagationPhase gtk_event_controller_get_propagation_phase(GtkEventControllerHandle controller);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_event_controller_get_widget(GtkEventControllerHandle controller);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_event_controller_handle_event(GtkEventControllerHandle controller, GdkEventHandle @event);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_event_controller_reset(GtkEventControllerHandle controller);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_event_controller_set_propagation_phase(GtkEventControllerHandle controller, GtkPropagationPhase phase);

}
