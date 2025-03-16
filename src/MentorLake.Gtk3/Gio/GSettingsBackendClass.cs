namespace MentorLake.Gio;

public class GSettingsBackendClassHandle : BaseSafeHandle
{
}


public static class GSettingsBackendClassExtensions
{

	public static GSettingsBackendClass Dereference(this GSettingsBackendClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSettingsBackendClass>(x.DangerousGetHandle());
}
internal class GSettingsBackendClassExterns
{
}

public struct GSettingsBackendClass
{
	public GObjectClass parent_class;
	public IntPtr read;
	public IntPtr get_writable;
	public IntPtr write;
	public IntPtr write_tree;
	public IntPtr reset;
	public IntPtr subscribe;
	public IntPtr unsubscribe;
	public IntPtr sync;
	public IntPtr get_permission;
	public IntPtr read_user_value;
}
