namespace MentorLake.Gio;

public class GSrvTargetHandle : BaseSafeHandle
{
	public static MentorLake.Gio.GSrvTargetHandle New(string hostname, ushort port, ushort priority, ushort weight)
	{
		return GSrvTargetExterns.g_srv_target_new(hostname, port, priority, weight);
	}

}


public static class GSrvTargetExtensions
{
	public static MentorLake.Gio.GSrvTargetHandle Copy(this MentorLake.Gio.GSrvTargetHandle target)
	{
		if (target.IsInvalid) throw new Exception("Invalid handle (GSrvTarget)");
		return GSrvTargetExterns.g_srv_target_copy(target);
	}

	public static void Free(this MentorLake.Gio.GSrvTargetHandle target)
	{
		if (target.IsInvalid) throw new Exception("Invalid handle (GSrvTarget)");
		GSrvTargetExterns.g_srv_target_free(target);
	}

	public static string GetHostname(this MentorLake.Gio.GSrvTargetHandle target)
	{
		if (target.IsInvalid) throw new Exception("Invalid handle (GSrvTarget)");
		return GSrvTargetExterns.g_srv_target_get_hostname(target);
	}

	public static ushort GetPort(this MentorLake.Gio.GSrvTargetHandle target)
	{
		if (target.IsInvalid) throw new Exception("Invalid handle (GSrvTarget)");
		return GSrvTargetExterns.g_srv_target_get_port(target);
	}

	public static ushort GetPriority(this MentorLake.Gio.GSrvTargetHandle target)
	{
		if (target.IsInvalid) throw new Exception("Invalid handle (GSrvTarget)");
		return GSrvTargetExterns.g_srv_target_get_priority(target);
	}

	public static ushort GetWeight(this MentorLake.Gio.GSrvTargetHandle target)
	{
		if (target.IsInvalid) throw new Exception("Invalid handle (GSrvTarget)");
		return GSrvTargetExterns.g_srv_target_get_weight(target);
	}


	public static GSrvTarget Dereference(this GSrvTargetHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSrvTarget>(x.DangerousGetHandle());
}
internal class GSrvTargetExterns
{
	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSrvTargetHandle>))]
	internal static extern MentorLake.Gio.GSrvTargetHandle g_srv_target_new(string hostname, ushort port, ushort priority, ushort weight);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSrvTargetHandle>))]
	internal static extern MentorLake.Gio.GSrvTargetHandle g_srv_target_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSrvTargetHandle>))] MentorLake.Gio.GSrvTargetHandle target);

	[DllImport(GioLibrary.Name)]
	internal static extern void g_srv_target_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSrvTargetHandle>))] MentorLake.Gio.GSrvTargetHandle target);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string g_srv_target_get_hostname([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSrvTargetHandle>))] MentorLake.Gio.GSrvTargetHandle target);

	[DllImport(GioLibrary.Name)]
	internal static extern ushort g_srv_target_get_port([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSrvTargetHandle>))] MentorLake.Gio.GSrvTargetHandle target);

	[DllImport(GioLibrary.Name)]
	internal static extern ushort g_srv_target_get_priority([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSrvTargetHandle>))] MentorLake.Gio.GSrvTargetHandle target);

	[DllImport(GioLibrary.Name)]
	internal static extern ushort g_srv_target_get_weight([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GSrvTargetHandle>))] MentorLake.Gio.GSrvTargetHandle target);

	[DllImport(GioLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))]
	internal static extern MentorLake.GLib.GListHandle g_srv_target_list_sort([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GListHandle>))] MentorLake.GLib.GListHandle targets);

}

public struct GSrvTarget
{
	public static MentorLake.GLib.GListHandle ListSort(MentorLake.GLib.GListHandle targets)
	{
		return GSrvTargetExterns.g_srv_target_list_sort(targets);
	}

}
