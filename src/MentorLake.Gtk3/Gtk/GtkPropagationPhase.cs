namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// Describes the stage at which events are fed into a #GtkEventController.
/// </para>
/// </summary>

[Flags]
public enum GtkPropagationPhase
{
/// <summary>
/// <para>
/// Events are not delivered automatically. Those can be
///   manually fed through gtk_event_controller_handle_event(). This should
///   only be used when full control about when, or whether the controller
///   handles the event is needed.
/// </para>
/// </summary>

	GTK_PHASE_NONE = 0,
/// <summary>
/// <para>
/// Events are delivered in the capture phase. The
///   capture phase happens before the bubble phase, runs from the toplevel down
///   to the event widget. This option should only be used on containers that
///   might possibly handle events before their children do.
/// </para>
/// </summary>

	GTK_PHASE_CAPTURE = 1,
/// <summary>
/// <para>
/// Events are delivered in the bubble phase. The bubble
///   phase happens after the capture phase, and before the default handlers
///   are run. This phase runs from the event widget, up to the toplevel.
/// </para>
/// </summary>

	GTK_PHASE_BUBBLE = 2,
/// <summary>
/// <para>
/// Events are delivered in the default widget event handlers,
///   note that widget implementations must chain up on button, motion, touch and
///   grab broken handlers for controllers in this phase to be run.
/// </para>
/// </summary>

	GTK_PHASE_TARGET = 3
}
