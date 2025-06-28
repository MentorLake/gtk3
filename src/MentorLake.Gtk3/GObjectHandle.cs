using GCHandle = System.Runtime.InteropServices.GCHandle;

namespace MentorLake.GObject;

public partial class GObjectHandle
{
	protected override void Dispose(bool disposing)
	{
		if (!IsInvalid)
		{
			static bool Unref(IntPtr data)
			{
				g_object_unref(data);
				return false;
			}

			g_main_context_invoke_full(g_main_context_default(), 0, Unref, handle, null);
		}

		base.Dispose(disposing);
	}

	public void Init(bool addRef)
	{
		if (IsInvalid || IsClosed) return;

		if (this.IsFloating()) g_object_ref_sink(handle);
		else if (addRef) g_object_ref(handle);

		var gc = GCHandle.Alloc(this, GCHandleType.WeakTrackResurrection);

		g_object_weak_ref(handle, static (ptr, _) =>
		{
			var gc = GCHandle.FromIntPtr(ptr);
			var h = gc.Target as GObjectHandle;
			h?.SetHandleAsInvalid();
			gc.Free();
		}, GCHandle.ToIntPtr(gc));
	}

	[DllImport(GObjectLibrary.Name)]
	private static extern IntPtr g_object_ref(IntPtr @object);

	[DllImport(GObjectLibrary.Name)]
	private static extern void g_object_unref(IntPtr @object);

	[DllImport(GObjectLibrary.Name)]
	private static extern IntPtr g_object_ref_sink(IntPtr @object);

	[DllImport(GLibLibrary.Name)]
	private static extern IntPtr g_main_context_default();

	[DllImport(GLibLibrary.Name)]
	private static extern void g_main_context_invoke_full(IntPtr context, int priority, MentorLake.GLib.GSourceFunc function, IntPtr data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GObjectLibrary.Name)]
	private static extern void g_object_weak_ref(nint @object, GWeakNotify notify, IntPtr data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void GWeakNotify(IntPtr data, IntPtr where_the_object_was);
}
