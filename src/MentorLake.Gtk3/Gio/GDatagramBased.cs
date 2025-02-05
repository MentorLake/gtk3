namespace MentorLake.Gtk3.Gio;

public interface GDatagramBasedHandle
{
}

internal class GDatagramBasedHandleImpl : BaseSafeHandle, GDatagramBasedHandle
{
}

public static class GDatagramBasedHandleExtensions
{
	public static GIOCondition ConditionCheck(this GDatagramBasedHandle datagram_based, GIOCondition condition)
	{
		return GDatagramBasedExterns.g_datagram_based_condition_check(datagram_based, condition);
	}

	public static bool ConditionWait(this GDatagramBasedHandle datagram_based, GIOCondition condition, long timeout, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDatagramBasedExterns.g_datagram_based_condition_wait(datagram_based, condition, timeout, cancellable, out error);
	}

	public static GSourceHandle CreateSource(this GDatagramBasedHandle datagram_based, GIOCondition condition, GCancellableHandle cancellable)
	{
		return GDatagramBasedExterns.g_datagram_based_create_source(datagram_based, condition, cancellable);
	}

	public static int ReceiveMessages(this GDatagramBasedHandle datagram_based, GInputMessage[] messages, uint num_messages, int flags, long timeout, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDatagramBasedExterns.g_datagram_based_receive_messages(datagram_based, messages, num_messages, flags, timeout, cancellable, out error);
	}

	public static int SendMessages(this GDatagramBasedHandle datagram_based, GOutputMessage[] messages, uint num_messages, int flags, long timeout, GCancellableHandle cancellable, out GErrorHandle error)
	{
		return GDatagramBasedExterns.g_datagram_based_send_messages(datagram_based, messages, num_messages, flags, timeout, cancellable, out error);
	}

}

internal class GDatagramBasedExterns
{
	[DllImport(Libraries.Gio)]
	internal static extern GIOCondition g_datagram_based_condition_check(GDatagramBasedHandle datagram_based, GIOCondition condition);

	[DllImport(Libraries.Gio)]
	internal static extern bool g_datagram_based_condition_wait(GDatagramBasedHandle datagram_based, GIOCondition condition, long timeout, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern GSourceHandle g_datagram_based_create_source(GDatagramBasedHandle datagram_based, GIOCondition condition, GCancellableHandle cancellable);

	[DllImport(Libraries.Gio)]
	internal static extern int g_datagram_based_receive_messages(GDatagramBasedHandle datagram_based, GInputMessage[] messages, uint num_messages, int flags, long timeout, GCancellableHandle cancellable, out GErrorHandle error);

	[DllImport(Libraries.Gio)]
	internal static extern int g_datagram_based_send_messages(GDatagramBasedHandle datagram_based, GOutputMessage[] messages, uint num_messages, int flags, long timeout, GCancellableHandle cancellable, out GErrorHandle error);

}
