namespace MentorLake.Gtk3.Gdk3;

public class GdkEventSettingHandle : BaseSafeHandle
{
}


public static class GdkEventSettingHandleExtensions
{
}
internal class GdkEventSettingExterns
{
}

public struct GdkEventSetting
{
	public GdkEventType type;
	public GdkWindowHandle window;
	public byte send_event;
	public GdkSettingAction action;
	public string name;
}
