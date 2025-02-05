namespace MentorLake.Gtk3.GLib;

public class GTestLogMsgHandle : BaseSafeHandle
{
}


public static class GTestLogMsgHandleExtensions
{
	public static T Free<T>(this T tmsg) where T : GTestLogMsgHandle
	{
		GTestLogMsgExterns.g_test_log_msg_free(tmsg);
		return tmsg;
	}

}
internal class GTestLogMsgExterns
{
	[DllImport(Libraries.GLib)]
	internal static extern void g_test_log_msg_free(GTestLogMsgHandle tmsg);

}

public struct GTestLogMsg
{
	public GTestLogType log_type;
	public uint n_strings;
	public string[] strings;
	public uint n_nums;
	public decimal[] nums;
}
