namespace MentorLake.Gtk3.GObject;

public class GTypeClassHandle : BaseSafeHandle
{
}


public static class GTypeClassHandleExtensions
{
	public static T AddPrivate<T>(this T g_class, UIntPtr private_size) where T : GTypeClassHandle
	{
		GTypeClassExterns.g_type_class_add_private(g_class, private_size);
		return g_class;
	}

	public static int GetInstancePrivateOffset(this GTypeClassHandle g_class)
	{
		return GTypeClassExterns.g_type_class_get_instance_private_offset(g_class);
	}

	public static IntPtr GetPrivate(this GTypeClassHandle klass, GType private_type)
	{
		return GTypeClassExterns.g_type_class_get_private(klass, private_type);
	}

	public static GTypeClassHandle PeekParent(this GTypeClassHandle g_class)
	{
		return GTypeClassExterns.g_type_class_peek_parent(g_class);
	}

	public static T Unref<T>(this T g_class) where T : GTypeClassHandle
	{
		GTypeClassExterns.g_type_class_unref(g_class);
		return g_class;
	}

	public static T UnrefUncached<T>(this T g_class) where T : GTypeClassHandle
	{
		GTypeClassExterns.g_type_class_unref_uncached(g_class);
		return g_class;
	}

	public static void AdjustPrivateOffset(IntPtr g_class, ref int private_size_or_offset)
	{
		GTypeClassExterns.g_type_class_adjust_private_offset(g_class, ref private_size_or_offset);
	}

	public static GTypeClassHandle Peek(GType type)
	{
		return GTypeClassExterns.g_type_class_peek(type);
	}

	public static GTypeClassHandle PeekStatic(GType type)
	{
		return GTypeClassExterns.g_type_class_peek_static(type);
	}

	public static GTypeClassHandle Ref(GType type)
	{
		return GTypeClassExterns.g_type_class_ref(type);
	}

}
internal class GTypeClassExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern void g_type_class_add_private(GTypeClassHandle g_class, UIntPtr private_size);

	[DllImport(Libraries.GObject)]
	internal static extern int g_type_class_get_instance_private_offset(GTypeClassHandle g_class);

	[DllImport(Libraries.GObject)]
	internal static extern IntPtr g_type_class_get_private(GTypeClassHandle klass, GType private_type);

	[DllImport(Libraries.GObject)]
	internal static extern GTypeClassHandle g_type_class_peek_parent(GTypeClassHandle g_class);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_class_unref(GTypeClassHandle g_class);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_class_unref_uncached(GTypeClassHandle g_class);

	[DllImport(Libraries.GObject)]
	internal static extern void g_type_class_adjust_private_offset(IntPtr g_class, ref int private_size_or_offset);

	[DllImport(Libraries.GObject)]
	internal static extern GTypeClassHandle g_type_class_peek(GType type);

	[DllImport(Libraries.GObject)]
	internal static extern GTypeClassHandle g_type_class_peek_static(GType type);

	[DllImport(Libraries.GObject)]
	internal static extern GTypeClassHandle g_type_class_ref(GType type);

}

public struct GTypeClass
{
}
