namespace MentorLake.Atk;

public class AtkUtilClassHandle : BaseSafeHandle
{
}


public static class AtkUtilClassExtensions
{

	public static AtkUtilClass Dereference(this AtkUtilClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<AtkUtilClass>(x.DangerousGetHandle());
}
internal class AtkUtilClassExterns
{
}

public struct AtkUtilClass
{
	public GObjectClass parent;
	public IntPtr add_global_event_listener;
	public IntPtr remove_global_event_listener;
	public IntPtr add_key_event_listener;
	public IntPtr remove_key_event_listener;
	public IntPtr get_root;
	public IntPtr get_toolkit_name;
	public IntPtr get_toolkit_version;
}
