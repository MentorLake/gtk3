namespace MentorLake.Gio;

public interface GDatagramBasedHandle
{
}

internal class GDatagramBasedHandleImpl : BaseSafeHandle, GDatagramBasedHandle
{
}

public static class GDatagramBasedHandleExtensions
{
	public static MentorLake.GLib.GIOCondition ConditionCheck(this MentorLake.Gio.GDatagramBasedHandle datagram_based, MentorLake.GLib.GIOCondition condition)
	{
		return GDatagramBasedHandleExterns.g_datagram_based_condition_check(datagram_based, condition);
	}

	public static bool ConditionWait(this MentorLake.Gio.GDatagramBasedHandle datagram_based, MentorLake.GLib.GIOCondition condition, long timeout, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDatagramBasedHandleExterns.g_datagram_based_condition_wait(datagram_based, condition, timeout, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static MentorLake.GLib.GSourceHandle CreateSource(this MentorLake.Gio.GDatagramBasedHandle datagram_based, MentorLake.GLib.GIOCondition condition, MentorLake.Gio.GCancellableHandle cancellable)
	{
		return GDatagramBasedHandleExterns.g_datagram_based_create_source(datagram_based, condition, cancellable);
	}

	public static int ReceiveMessages(this MentorLake.Gio.GDatagramBasedHandle datagram_based, MentorLake.Gio.GInputMessage[] messages, uint num_messages, int flags, long timeout, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDatagramBasedHandleExterns.g_datagram_based_receive_messages(datagram_based, messages, num_messages, flags, timeout, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

	public static int SendMessages(this MentorLake.Gio.GDatagramBasedHandle datagram_based, MentorLake.Gio.GOutputMessage[] messages, uint num_messages, int flags, long timeout, MentorLake.Gio.GCancellableHandle cancellable)
	{
		var externCallResult = GDatagramBasedHandleExterns.g_datagram_based_send_messages(datagram_based, messages, num_messages, flags, timeout, cancellable, out var error);
		if (!error.IsInvalid) throw new Exception(error.Dereference().message);
		return externCallResult;
	}

}

internal class GDatagramBasedHandleExterns
{
	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GIOCondition g_datagram_based_condition_check([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDatagramBasedHandleImpl>))] MentorLake.Gio.GDatagramBasedHandle datagram_based, MentorLake.GLib.GIOCondition condition);

	[DllImport(GioLibrary.Name)]
	internal static extern bool g_datagram_based_condition_wait([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDatagramBasedHandleImpl>))] MentorLake.Gio.GDatagramBasedHandle datagram_based, MentorLake.GLib.GIOCondition condition, long timeout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern MentorLake.GLib.GSourceHandle g_datagram_based_create_source([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDatagramBasedHandleImpl>))] MentorLake.Gio.GDatagramBasedHandle datagram_based, MentorLake.GLib.GIOCondition condition, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_datagram_based_receive_messages([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDatagramBasedHandleImpl>))] MentorLake.Gio.GDatagramBasedHandle datagram_based, MentorLake.Gio.GInputMessage[] messages, uint num_messages, int flags, long timeout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

	[DllImport(GioLibrary.Name)]
	internal static extern int g_datagram_based_send_messages([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GDatagramBasedHandleImpl>))] MentorLake.Gio.GDatagramBasedHandle datagram_based, MentorLake.Gio.GOutputMessage[] messages, uint num_messages, int flags, long timeout, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GCancellableHandle>))] MentorLake.Gio.GCancellableHandle cancellable, out MentorLake.GLib.GErrorHandle error);

}
