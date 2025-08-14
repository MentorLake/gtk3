namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// #GdkFrameClockPhase is used to represent the different paint clock
/// phases that can be requested. The elements of the enumeration
/// correspond to the signals of #GdkFrameClock.
/// </para>
/// </summary>

[Flags]
public enum GdkFrameClockPhase : uint
{
/// <summary>
/// <para>
/// no phase
/// </para>
/// </summary>

	GDK_FRAME_CLOCK_PHASE_NONE = 0,
/// <summary>
/// <para>
/// corresponds to GdkFrameClock::flush-events. Should not be handled by applications.
/// </para>
/// </summary>

	GDK_FRAME_CLOCK_PHASE_FLUSH_EVENTS = 1,
/// <summary>
/// <para>
/// corresponds to GdkFrameClock::before-paint. Should not be handled by applications.
/// </para>
/// </summary>

	GDK_FRAME_CLOCK_PHASE_BEFORE_PAINT = 2,
/// <summary>
/// <para>
/// corresponds to GdkFrameClock::update.
/// </para>
/// </summary>

	GDK_FRAME_CLOCK_PHASE_UPDATE = 4,
/// <summary>
/// <para>
/// corresponds to GdkFrameClock::layout.
/// </para>
/// </summary>

	GDK_FRAME_CLOCK_PHASE_LAYOUT = 8,
/// <summary>
/// <para>
/// corresponds to GdkFrameClock::paint.
/// </para>
/// </summary>

	GDK_FRAME_CLOCK_PHASE_PAINT = 16,
/// <summary>
/// <para>
/// corresponds to GdkFrameClock::resume-events. Should not be handled by applications.
/// </para>
/// </summary>

	GDK_FRAME_CLOCK_PHASE_RESUME_EVENTS = 32,
/// <summary>
/// <para>
/// corresponds to GdkFrameClock::after-paint. Should not be handled by applications.
/// </para>
/// </summary>

	GDK_FRAME_CLOCK_PHASE_AFTER_PAINT = 64
}
