namespace MentorLake.Gdk;

/// <summary>
/// <para>
/// Generated when a setting is modified.
/// </para>
/// </summary>

public class GdkEventSettingHandle : BaseSafeHandle
{
}


public static class GdkEventSettingExtensions
{

	public static GdkEventSetting Dereference(this GdkEventSettingHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GdkEventSetting>(x.DangerousGetHandle());
}
internal class GdkEventSettingExterns
{
}

/// <summary>
/// <para>
/// Generated when a setting is modified.
/// </para>
/// </summary>

public struct GdkEventSetting
{
	/// <summary>
/// <para>
/// the type of the event (%GDK_SETTING).
/// </para>
/// </summary>

public GdkEventType type;
	/// <summary>
/// <para>
/// the window which received the event.
/// </para>
/// </summary>

public IntPtr window;
	/// <summary>
/// <para>
/// %TRUE if the event was sent explicitly.
/// </para>
/// </summary>

public byte send_event;
	/// <summary>
/// <para>
/// what happened to the setting (%GDK_SETTING_ACTION_NEW,
///   %GDK_SETTING_ACTION_CHANGED or %GDK_SETTING_ACTION_DELETED).
/// </para>
/// </summary>

public GdkSettingAction action;
	/// <summary>
/// <para>
/// the name of the setting.
/// </para>
/// </summary>

public string name;
}
