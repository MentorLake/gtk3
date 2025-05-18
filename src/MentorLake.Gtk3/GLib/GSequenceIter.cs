namespace MentorLake.GLib;

public class GSequenceIterHandle : BaseSafeHandle
{
}


public static class GSequenceIterExtensions
{
	public static int Compare(this MentorLake.GLib.GSequenceIterHandle a, MentorLake.GLib.GSequenceIterHandle b)
	{
		if (a.IsInvalid) throw new Exception("Invalid handle (GSequenceIter)");
		return GSequenceIterExterns.g_sequence_iter_compare(a, b);
	}

	public static int GetPosition(this MentorLake.GLib.GSequenceIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GSequenceIter)");
		return GSequenceIterExterns.g_sequence_iter_get_position(iter);
	}

	public static MentorLake.GLib.GSequenceHandle GetSequence(this MentorLake.GLib.GSequenceIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GSequenceIter)");
		return GSequenceIterExterns.g_sequence_iter_get_sequence(iter);
	}

	public static bool IsBegin(this MentorLake.GLib.GSequenceIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GSequenceIter)");
		return GSequenceIterExterns.g_sequence_iter_is_begin(iter);
	}

	public static bool IsEnd(this MentorLake.GLib.GSequenceIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GSequenceIter)");
		return GSequenceIterExterns.g_sequence_iter_is_end(iter);
	}

	public static MentorLake.GLib.GSequenceIterHandle Move(this MentorLake.GLib.GSequenceIterHandle iter, int delta)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GSequenceIter)");
		return GSequenceIterExterns.g_sequence_iter_move(iter, delta);
	}

	public static MentorLake.GLib.GSequenceIterHandle Next(this MentorLake.GLib.GSequenceIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GSequenceIter)");
		return GSequenceIterExterns.g_sequence_iter_next(iter);
	}

	public static MentorLake.GLib.GSequenceIterHandle Prev(this MentorLake.GLib.GSequenceIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GSequenceIter)");
		return GSequenceIterExterns.g_sequence_iter_prev(iter);
	}


	public static GSequenceIter Dereference(this GSequenceIterHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GSequenceIter>(x.DangerousGetHandle());
}
internal class GSequenceIterExterns
{
	[DllImport(GLibLibrary.Name)]
	internal static extern int g_sequence_iter_compare([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle a, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle b);

	[DllImport(GLibLibrary.Name)]
	internal static extern int g_sequence_iter_get_position([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceHandle>))]
	internal static extern MentorLake.GLib.GSequenceHandle g_sequence_iter_get_sequence([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_sequence_iter_is_begin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_sequence_iter_is_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_iter_move([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter, int delta);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_iter_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))]
	internal static extern MentorLake.GLib.GSequenceIterHandle g_sequence_iter_prev([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GSequenceIterHandle>))] MentorLake.GLib.GSequenceIterHandle iter);

}

public struct GSequenceIter
{
}
