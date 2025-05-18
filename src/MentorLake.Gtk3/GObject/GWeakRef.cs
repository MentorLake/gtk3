namespace MentorLake.GObject;

public class GWeakRefHandle : BaseSafeHandle
{
}


public static class GWeakRefExtensions
{
	public static void Clear(this MentorLake.GObject.GWeakRefHandle weak_ref)
	{
		if (weak_ref.IsInvalid) throw new Exception("Invalid handle (GWeakRef)");
		GWeakRefExterns.g_weak_ref_clear(weak_ref);
	}

	public static MentorLake.GObject.GObjectHandle Get(this MentorLake.GObject.GWeakRefHandle weak_ref)
	{
		if (weak_ref.IsInvalid) throw new Exception("Invalid handle (GWeakRef)");
		return GWeakRefExterns.g_weak_ref_get(weak_ref);
	}

	public static void Init(this MentorLake.GObject.GWeakRefHandle weak_ref, MentorLake.GObject.GObjectHandle @object)
	{
		if (weak_ref.IsInvalid) throw new Exception("Invalid handle (GWeakRef)");
		GWeakRefExterns.g_weak_ref_init(weak_ref, @object);
	}

	public static void Set(this MentorLake.GObject.GWeakRefHandle weak_ref, MentorLake.GObject.GObjectHandle @object)
	{
		if (weak_ref.IsInvalid) throw new Exception("Invalid handle (GWeakRef)");
		GWeakRefExterns.g_weak_ref_set(weak_ref, @object);
	}


	public static GWeakRef Dereference(this GWeakRefHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GWeakRef>(x.DangerousGetHandle());
}
internal class GWeakRefExterns
{
	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_weak_ref_clear([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GWeakRefHandle>))] MentorLake.GObject.GWeakRefHandle weak_ref);

	[DllImport(GObjectLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))]
	internal static extern MentorLake.GObject.GObjectHandle g_weak_ref_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GWeakRefHandle>))] MentorLake.GObject.GWeakRefHandle weak_ref);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_weak_ref_init([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GWeakRefHandle>))] MentorLake.GObject.GWeakRefHandle weak_ref, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_weak_ref_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GWeakRefHandle>))] MentorLake.GObject.GWeakRefHandle weak_ref, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle @object);

}

public struct GWeakRef
{
}
