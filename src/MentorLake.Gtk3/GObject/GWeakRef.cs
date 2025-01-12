namespace MentorLake.Gtk3.GObject;

public class GWeakRefHandle : BaseSafeHandle
{
}


public static class GWeakRefHandleExtensions
{
	public static T Clear<T>(this T weak_ref) where T : GWeakRefHandle
	{
		GWeakRefExterns.g_weak_ref_clear(weak_ref);
		return weak_ref;
	}

	public static GObjectHandle Get(this GWeakRefHandle weak_ref)
	{
		return GWeakRefExterns.g_weak_ref_get(weak_ref);
	}

	public static T Init<T>(this T weak_ref, GObjectHandle @object) where T : GWeakRefHandle
	{
		GWeakRefExterns.g_weak_ref_init(weak_ref, @object);
		return weak_ref;
	}

	public static T Set<T>(this T weak_ref, GObjectHandle @object) where T : GWeakRefHandle
	{
		GWeakRefExterns.g_weak_ref_set(weak_ref, @object);
		return weak_ref;
	}

}
internal class GWeakRefExterns
{
	[DllImport(Libraries.GObject)]
	internal static extern void g_weak_ref_clear(GWeakRefHandle weak_ref);

	[DllImport(Libraries.GObject)]
	internal static extern GObjectHandle g_weak_ref_get(GWeakRefHandle weak_ref);

	[DllImport(Libraries.GObject)]
	internal static extern void g_weak_ref_init(GWeakRefHandle weak_ref, GObjectHandle @object);

	[DllImport(Libraries.GObject)]
	internal static extern void g_weak_ref_set(GWeakRefHandle weak_ref, GObjectHandle @object);

}

public struct GWeakRef
{
}
