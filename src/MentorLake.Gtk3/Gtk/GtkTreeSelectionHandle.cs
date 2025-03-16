namespace MentorLake.Gtk;

public class GtkTreeSelectionHandle : GObjectHandle
{
}
public static class GtkTreeSelectionHandleSignalExtensions
{

	public static IObservable<GtkTreeSelectionHandleSignalStructs.ChangedSignal> Signal_Changed(this GtkTreeSelectionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkTreeSelectionHandleSignalStructs.ChangedSignal> obs) =>
		{
			GtkTreeSelectionHandleSignalDelegates.changed handler = ( MentorLake.Gtk.GtkTreeSelectionHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkTreeSelectionHandleSignalStructs.ChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkTreeSelectionHandleSignalStructs
{

public struct ChangedSignal
{
	public MentorLake.Gtk.GtkTreeSelectionHandle Self;
	public IntPtr UserData;
}
}

public static class GtkTreeSelectionHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle self, IntPtr user_data);

}


public static class GtkTreeSelectionHandleExtensions
{
	public static int CountSelectedRows(this MentorLake.Gtk.GtkTreeSelectionHandle selection)
	{
		return GtkTreeSelectionHandleExterns.gtk_tree_selection_count_selected_rows(selection);
	}

	public static MentorLake.Gtk.GtkSelectionMode GetMode(this MentorLake.Gtk.GtkTreeSelectionHandle selection)
	{
		return GtkTreeSelectionHandleExterns.gtk_tree_selection_get_mode(selection);
	}

	public static MentorLake.Gtk.GtkTreeSelectionFunc GetSelectFunction(this MentorLake.Gtk.GtkTreeSelectionHandle selection)
	{
		return GtkTreeSelectionHandleExterns.gtk_tree_selection_get_select_function(selection);
	}

	public static bool GetSelected(this MentorLake.Gtk.GtkTreeSelectionHandle selection, out MentorLake.Gtk.GtkTreeModelHandle model, out MentorLake.Gtk.GtkTreeIter iter)
	{
		return GtkTreeSelectionHandleExterns.gtk_tree_selection_get_selected(selection, out model, out iter);
	}

	public static MentorLake.GLib.GListHandle GetSelectedRows(this MentorLake.Gtk.GtkTreeSelectionHandle selection, out MentorLake.Gtk.GtkTreeModelHandle model)
	{
		return GtkTreeSelectionHandleExterns.gtk_tree_selection_get_selected_rows(selection, out model);
	}

	public static MentorLake.Gtk.GtkTreeViewHandle GetTreeView(this MentorLake.Gtk.GtkTreeSelectionHandle selection)
	{
		return GtkTreeSelectionHandleExterns.gtk_tree_selection_get_tree_view(selection);
	}

	public static IntPtr GetUserData(this MentorLake.Gtk.GtkTreeSelectionHandle selection)
	{
		return GtkTreeSelectionHandleExterns.gtk_tree_selection_get_user_data(selection);
	}

	public static bool IterIsSelected(this MentorLake.Gtk.GtkTreeSelectionHandle selection, MentorLake.Gtk.GtkTreeIterHandle iter)
	{
		return GtkTreeSelectionHandleExterns.gtk_tree_selection_iter_is_selected(selection, iter);
	}

	public static bool PathIsSelected(this MentorLake.Gtk.GtkTreeSelectionHandle selection, MentorLake.Gtk.GtkTreePathHandle path)
	{
		return GtkTreeSelectionHandleExterns.gtk_tree_selection_path_is_selected(selection, path);
	}

	public static T SelectAll<T>(this T selection) where T : GtkTreeSelectionHandle
	{
		GtkTreeSelectionHandleExterns.gtk_tree_selection_select_all(selection);
		return selection;
	}

	public static T SelectIter<T>(this T selection, MentorLake.Gtk.GtkTreeIterHandle iter) where T : GtkTreeSelectionHandle
	{
		GtkTreeSelectionHandleExterns.gtk_tree_selection_select_iter(selection, iter);
		return selection;
	}

	public static T SelectPath<T>(this T selection, MentorLake.Gtk.GtkTreePathHandle path) where T : GtkTreeSelectionHandle
	{
		GtkTreeSelectionHandleExterns.gtk_tree_selection_select_path(selection, path);
		return selection;
	}

	public static T SelectRange<T>(this T selection, MentorLake.Gtk.GtkTreePathHandle start_path, MentorLake.Gtk.GtkTreePathHandle end_path) where T : GtkTreeSelectionHandle
	{
		GtkTreeSelectionHandleExterns.gtk_tree_selection_select_range(selection, start_path, end_path);
		return selection;
	}

	public static T SelectedForeach<T>(this T selection, MentorLake.Gtk.GtkTreeSelectionForeachFunc func, IntPtr data) where T : GtkTreeSelectionHandle
	{
		GtkTreeSelectionHandleExterns.gtk_tree_selection_selected_foreach(selection, func, data);
		return selection;
	}

	public static T SetMode<T>(this T selection, MentorLake.Gtk.GtkSelectionMode type) where T : GtkTreeSelectionHandle
	{
		GtkTreeSelectionHandleExterns.gtk_tree_selection_set_mode(selection, type);
		return selection;
	}

	public static T SetSelectFunction<T>(this T selection, MentorLake.Gtk.GtkTreeSelectionFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy) where T : GtkTreeSelectionHandle
	{
		GtkTreeSelectionHandleExterns.gtk_tree_selection_set_select_function(selection, func, data, destroy);
		return selection;
	}

	public static T UnselectAll<T>(this T selection) where T : GtkTreeSelectionHandle
	{
		GtkTreeSelectionHandleExterns.gtk_tree_selection_unselect_all(selection);
		return selection;
	}

	public static T UnselectIter<T>(this T selection, MentorLake.Gtk.GtkTreeIterHandle iter) where T : GtkTreeSelectionHandle
	{
		GtkTreeSelectionHandleExterns.gtk_tree_selection_unselect_iter(selection, iter);
		return selection;
	}

	public static T UnselectPath<T>(this T selection, MentorLake.Gtk.GtkTreePathHandle path) where T : GtkTreeSelectionHandle
	{
		GtkTreeSelectionHandleExterns.gtk_tree_selection_unselect_path(selection, path);
		return selection;
	}

	public static T UnselectRange<T>(this T selection, MentorLake.Gtk.GtkTreePathHandle start_path, MentorLake.Gtk.GtkTreePathHandle end_path) where T : GtkTreeSelectionHandle
	{
		GtkTreeSelectionHandleExterns.gtk_tree_selection_unselect_range(selection, start_path, end_path);
		return selection;
	}

}

internal class GtkTreeSelectionHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_tree_selection_count_selected_rows([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSelectionMode gtk_tree_selection_get_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeSelectionFunc gtk_tree_selection_get_select_function([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_selection_get_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] out MentorLake.Gtk.GtkTreeModelHandle model, out MentorLake.Gtk.GtkTreeIter iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle gtk_tree_selection_get_selected_rows([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] out MentorLake.Gtk.GtkTreeModelHandle model);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTreeViewHandle gtk_tree_selection_get_tree_view([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection);

	[DllImport(GtkLibrary.Name)]
	internal static extern IntPtr gtk_tree_selection_get_user_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_selection_iter_is_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_tree_selection_path_is_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_selection_select_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_selection_select_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_selection_select_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_selection_select_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle start_path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle end_path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_selection_selected_foreach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, MentorLake.Gtk.GtkTreeSelectionForeachFunc func, IntPtr data);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_selection_set_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, MentorLake.Gtk.GtkSelectionMode type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_selection_set_select_function([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, MentorLake.Gtk.GtkTreeSelectionFunc func, IntPtr data, MentorLake.GLib.GDestroyNotify destroy);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_selection_unselect_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_selection_unselect_iter([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_selection_unselect_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle path);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_tree_selection_unselect_range([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeSelectionHandle>))] MentorLake.Gtk.GtkTreeSelectionHandle selection, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle start_path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreePathHandle>))] MentorLake.Gtk.GtkTreePathHandle end_path);

}
