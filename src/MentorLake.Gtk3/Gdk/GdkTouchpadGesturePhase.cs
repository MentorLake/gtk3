namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Specifies the current state of a touchpad gesture. All gestures are
/// guaranteed to begin with an event with phase %GDK_TOUCHPAD_GESTURE_PHASE_BEGIN,
/// followed by 0 or several events with phase %GDK_TOUCHPAD_GESTURE_PHASE_UPDATE.
/// </para>
/// <para>
/// A finished gesture may have 2 possible outcomes, an event with phase
/// %GDK_TOUCHPAD_GESTURE_PHASE_END will be emitted when the gesture is
/// considered successful, this should be used as the hint to perform any
/// permanent changes.
/// </para>
/// <para>
/// Cancelled gestures may be so for a variety of reasons, due to hardware
/// or the compositor, or due to the gesture recognition layers hinting the
/// gesture did not finish resolutely (eg. a 3rd finger being added during
/// a pinch gesture). In these cases, the last event will report the phase
/// %GDK_TOUCHPAD_GESTURE_PHASE_CANCEL, this should be used as a hint
/// to undo any visible/permanent changes that were done throughout the
/// progress of the gesture.
/// </para>
/// <para>
/// See also #GdkEventTouchpadSwipe and #GdkEventTouchpadPinch.
/// </para>
/// </summary>

[Flags]
public enum GdkTouchpadGesturePhase
{
/// <summary>
/// <para>
/// The gesture has begun.
/// </para>
/// </summary>

	GDK_TOUCHPAD_GESTURE_PHASE_BEGIN = 0,
/// <summary>
/// <para>
/// The gesture has been updated.
/// </para>
/// </summary>

	GDK_TOUCHPAD_GESTURE_PHASE_UPDATE = 1,
/// <summary>
/// <para>
/// The gesture was finished, changes
///   should be permanently applied.
/// </para>
/// </summary>

	GDK_TOUCHPAD_GESTURE_PHASE_END = 2,
/// <summary>
/// <para>
/// The gesture was cancelled, all
///   changes should be undone.
/// </para>
/// </summary>

	GDK_TOUCHPAD_GESTURE_PHASE_CANCEL = 3
}
