namespace MentorLake.Gdk;

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

public struct GdkEventSetting
{
	public GdkEventType type;
	public IntPtr window;
	public byte send_event;
	public GdkSettingAction action;
	public string name;
}
