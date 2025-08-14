namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// @GDK_INPUT_OUTPUT windows are the standard kind of window you might expect.
/// Such windows receive events and are also displayed on screen.
/// @GDK_INPUT_ONLY windows are invisible; they are usually placed above other
/// windows in order to trap or filter the events. You can’t draw on
/// @GDK_INPUT_ONLY windows.
/// </para>
/// </summary>

[Flags]
public enum GdkWindowWindowClass
{
/// <summary>
/// <para>
/// window for graphics and events
/// </para>
/// </summary>

	GDK_INPUT_OUTPUT = 0,
/// <summary>
/// <para>
/// window for events only
/// </para>
/// </summary>

	GDK_INPUT_ONLY = 1
}
