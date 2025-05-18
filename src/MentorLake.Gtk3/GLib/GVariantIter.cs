namespace MentorLake.GLib;

public class GVariantIterHandle : BaseSafeHandle
{
}


public static class GVariantIterExtensions
{
	public static MentorLake.GLib.GVariantIterHandle Copy(this MentorLake.GLib.GVariantIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GVariantIter)");
		return GVariantIterExterns.g_variant_iter_copy(iter);
	}

	public static void Free(this MentorLake.GLib.GVariantIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GVariantIter)");
		GVariantIterExterns.g_variant_iter_free(iter);
	}

	public static UIntPtr Init(this MentorLake.GLib.GVariantIterHandle iter, MentorLake.GLib.GVariantHandle value)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GVariantIter)");
		return GVariantIterExterns.g_variant_iter_init(iter, value);
	}

	public static bool Loop(this MentorLake.GLib.GVariantIterHandle iter, string format_string, IntPtr @__arglist)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GVariantIter)");
		return GVariantIterExterns.g_variant_iter_loop(iter, format_string, @__arglist);
	}

	public static UIntPtr NChildren(this MentorLake.GLib.GVariantIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GVariantIter)");
		return GVariantIterExterns.g_variant_iter_n_children(iter);
	}

	public static bool Next(this MentorLake.GLib.GVariantIterHandle iter, string format_string, IntPtr @__arglist)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GVariantIter)");
		return GVariantIterExterns.g_variant_iter_next(iter, format_string, @__arglist);
	}

	public static MentorLake.GLib.GVariantHandle NextValue(this MentorLake.GLib.GVariantIterHandle iter)
	{
		if (iter.IsInvalid) throw new Exception("Invalid handle (GVariantIter)");
		return GVariantIterExterns.g_variant_iter_next_value(iter);
	}


	public static GVariantIter Dereference(this GVariantIterHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GVariantIter>(x.DangerousGetHandle());
}
internal class GVariantIterExterns
{
	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantIterHandle>))]
	internal static extern MentorLake.GLib.GVariantIterHandle g_variant_iter_copy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantIterHandle>))] MentorLake.GLib.GVariantIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	internal static extern void g_variant_iter_free([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantIterHandle>))] MentorLake.GLib.GVariantIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_variant_iter_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantIterHandle>))] MentorLake.GLib.GVariantIterHandle iter, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))] MentorLake.GLib.GVariantHandle value);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_iter_loop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantIterHandle>))] MentorLake.GLib.GVariantIterHandle iter, string format_string, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	internal static extern UIntPtr g_variant_iter_n_children([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantIterHandle>))] MentorLake.GLib.GVariantIterHandle iter);

	[DllImport(GLibLibrary.Name)]
	internal static extern bool g_variant_iter_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantIterHandle>))] MentorLake.GLib.GVariantIterHandle iter, string format_string, IntPtr @__arglist);

	[DllImport(GLibLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantHandle>))]
	internal static extern MentorLake.GLib.GVariantHandle g_variant_iter_next_value([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GLib.GVariantIterHandle>))] MentorLake.GLib.GVariantIterHandle iter);

}

public struct GVariantIter
{
}
