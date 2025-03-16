namespace MentorLake.Gio;

public class GSettingsClassHandle : BaseSafeHandle
{
}


public static class GSettingsClassExtensions
{

	public static GSettingsClass Dereference(this GSettingsClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSettingsClass>(x.DangerousGetHandle());
}
internal class GSettingsClassExterns
{
}

public struct GSettingsClass
{
	public GObjectClass parent_class;
	public IntPtr writable_changed;
	public IntPtr changed;
	public IntPtr writable_change_event;
	public IntPtr change_event;
	public IntPtr padding;
}
