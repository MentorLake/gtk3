namespace MentorLake.GObject;

public class GTypeClassHandle : BaseSafeHandle
{
}


public static class GTypeClassExtensions
{
	public static void AddPrivate(this MentorLake.GObject.GTypeClassHandle g_class, UIntPtr private_size)
	{
		if (g_class.IsInvalid || g_class.IsClosed) throw new Exception("Invalid or closed handle (GTypeClass)");
		GTypeClassExterns.g_type_class_add_private(g_class, private_size);
	}

	public static int GetInstancePrivateOffset(this MentorLake.GObject.GTypeClassHandle g_class)
	{
		if (g_class.IsInvalid || g_class.IsClosed) throw new Exception("Invalid or closed handle (GTypeClass)");
		return GTypeClassExterns.g_type_class_get_instance_private_offset(g_class);
	}

	public static IntPtr GetPrivate(this MentorLake.GObject.GTypeClassHandle klass, MentorLake.GObject.GType private_type)
	{
		if (klass.IsInvalid || klass.IsClosed) throw new Exception("Invalid or closed handle (GTypeClass)");
		return GTypeClassExterns.g_type_class_get_private(klass, private_type);
	}

	public static MentorLake.GObject.GTypeClassHandle PeekParent(this MentorLake.GObject.GTypeClassHandle g_class)
	{
		if (g_class.IsInvalid || g_class.IsClosed) throw new Exception("Invalid or closed handle (GTypeClass)");
		return GTypeClassExterns.g_type_class_peek_parent(g_class);
	}

	public static void Unref(this MentorLake.GObject.GTypeClassHandle g_class)
	{
		if (g_class.IsInvalid || g_class.IsClosed) throw new Exception("Invalid or closed handle (GTypeClass)");
		GTypeClassExterns.g_type_class_unref(g_class);
	}

	public static void UnrefUncached(this MentorLake.GObject.GTypeClassHandle g_class)
	{
		if (g_class.IsInvalid || g_class.IsClosed) throw new Exception("Invalid or closed handle (GTypeClass)");
		GTypeClassExterns.g_type_class_unref_uncached(g_class);
	}


	public static GTypeClass Dereference(this GTypeClassHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<GTypeClass>(x.DangerousGetHandle());
}
internal class GTypeClassExterns
{
	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_class_add_private([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle g_class, UIntPtr private_size);

	[DllImport(GObjectLibrary.Name)]
	internal static extern int g_type_class_get_instance_private_offset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle g_class);

	[DllImport(GObjectLibrary.Name)]
	internal static extern IntPtr g_type_class_get_private([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle klass, MentorLake.GObject.GType private_type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GTypeClassHandle g_type_class_peek_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle g_class);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_class_unref([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle g_class);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_class_unref_uncached([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GTypeClassHandle>))] MentorLake.GObject.GTypeClassHandle g_class);

	[DllImport(GObjectLibrary.Name)]
	internal static extern void g_type_class_adjust_private_offset(IntPtr g_class, int private_size_or_offset);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GTypeClassHandle g_type_class_peek(MentorLake.GObject.GType type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GTypeClassHandle g_type_class_peek_static(MentorLake.GObject.GType type);

	[DllImport(GObjectLibrary.Name)]
	internal static extern MentorLake.GObject.GTypeClassHandle g_type_class_ref(MentorLake.GObject.GType type);

}

public struct GTypeClass
{
	public static void AdjustPrivateOffset(IntPtr g_class, int private_size_or_offset)
	{
		GTypeClassExterns.g_type_class_adjust_private_offset(g_class, private_size_or_offset);
	}

	public static MentorLake.GObject.GTypeClassHandle Peek(MentorLake.GObject.GType type)
	{
		return GTypeClassExterns.g_type_class_peek(type);
	}

	public static MentorLake.GObject.GTypeClassHandle PeekStatic(MentorLake.GObject.GType type)
	{
		return GTypeClassExterns.g_type_class_peek_static(type);
	}

	public static MentorLake.GObject.GTypeClassHandle Ref(MentorLake.GObject.GType type)
	{
		return GTypeClassExterns.g_type_class_ref(type);
	}

}
