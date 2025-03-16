namespace MentorLake.Gio;

public class GMountOperationClassHandle : BaseSafeHandle
{
}


public static class GMountOperationClassExtensions
{

	public static GMountOperationClass Dereference(this GMountOperationClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GMountOperationClass>(x.DangerousGetHandle());
}
internal class GMountOperationClassExterns
{
}

public struct GMountOperationClass
{
	public GObjectClass parent_class;
	public IntPtr ask_password;
	public IntPtr ask_question;
	public IntPtr reply;
	public IntPtr aborted;
	public IntPtr show_processes;
	public IntPtr show_unmount_progress;
	public IntPtr _g_reserved1;
	public IntPtr _g_reserved2;
	public IntPtr _g_reserved3;
	public IntPtr _g_reserved4;
	public IntPtr _g_reserved5;
	public IntPtr _g_reserved6;
	public IntPtr _g_reserved7;
	public IntPtr _g_reserved8;
	public IntPtr _g_reserved9;
}
