using GCHandle = System.Runtime.InteropServices.GCHandle;

namespace MentorLake.Gtk3;

public class GObjectMarshallingHelper
{
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
	private static extern void g_object_weak_ref(MentorLake.GObject.GObjectHandle @object, GWeakNotify notify, IntPtr data);

	[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
	private delegate void GWeakNotify(IntPtr data, IntPtr where_the_object_was);

	public static bool EnableLogging { get; set; } = false;

	private class GObjectState
	{
		public GObjectHandle Handle { get; set; }
		public string Name { get; set; }
	}

	public static void HandleGObjectHandle(GObjectHandle gObjectHandle, bool refObject)
	{
		if (gObjectHandle.IsInvalid || gObjectHandle.IsClosed) return;

		var state = new GObjectState()
		{
			Handle = gObjectHandle,
			Name = EnableLogging ? GObjectGlobalFunctions.TypeNameFromInstance(gObjectHandle) : null,
		};

		if (gObjectHandle.IsFloating()) g_object_ref_sink(gObjectHandle.DangerousGetHandle());
		else if (refObject) g_object_ref(gObjectHandle.DangerousGetHandle());

		g_object_weak_ref(gObjectHandle, static (data, _) =>
		{
			var gcHandleInner = GCHandle.FromIntPtr(data);
			var s = (GObjectState)gcHandleInner.Target;
			s.Handle.SetHandleAsInvalid();
			gcHandleInner.Free();
		}, GCHandle.ToIntPtr(GCHandle.Alloc(state)));

		gObjectHandle.AddReleaseAction(static data =>
		{
			var s = (GObjectState) data;

			if (!s.Handle.IsInvalid)
			{
				g_main_context_invoke_full(g_main_context_default(), 0, Unref, s.Handle.DangerousGetHandle(), null);
			}
		}, state);
	}

	private static bool Unref(IntPtr data)
	{
		g_object_unref(data);
		return false;
	}
}
