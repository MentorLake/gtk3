namespace MentorLake.GLib;

public class GTestLogMsgHandle : BaseSafeHandle
{
}


public static class GTestLogMsgExtensions
{
	public static void Free(this MentorLake.GLib.GTestLogMsgHandle tmsg)
	{
		if (tmsg.IsInvalid) throw new Exception("Invalid handle (GTestLogMsg)");
		GTestLogMsgExterns.g_test_log_msg_free(tmsg);
	}


	public static GTestLogMsg Dereference(this GTestLogMsgHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTestLogMsg>(x.DangerousGetHandle());
}
internal class GTestLogMsgExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern void g_test_log_msg_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GTestLogMsgHandle>))] MentorLake.GLib.GTestLogMsgHandle tmsg);

}

public struct GTestLogMsg
{
	public GTestLogType log_type;
	public uint n_strings;
	public string strings;
	public uint n_nums;
	public IntPtr nums;
}
