namespace MentorLake.Gtk;

public class GtkNotebookHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkNotebookHandle New()
	{
		return GtkNotebookHandleExterns.gtk_notebook_new();
	}

}
public static class GtkNotebookHandleSignalExtensions
{

	public static IObservable<GtkNotebookHandleSignalStructs.ChangeCurrentPageSignal> Signal_ChangeCurrentPage(this GtkNotebookHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNotebookHandleSignalStructs.ChangeCurrentPageSignal> obs) =>
		{
			GtkNotebookHandleSignalDelegates.change_current_page handler = ( MentorLake.Gtk.GtkNotebookHandle self,  int @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookHandleSignalStructs.ChangeCurrentPageSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "change-current-page", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkNotebookHandleSignalStructs.CreateWindowSignal> Signal_CreateWindow(this GtkNotebookHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNotebookHandleSignalStructs.CreateWindowSignal> obs) =>
		{
			GtkNotebookHandleSignalDelegates.create_window handler = ( MentorLake.Gtk.GtkNotebookHandle self,  MentorLake.Gtk.GtkWidgetHandle page,  int x,  int y,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookHandleSignalStructs.CreateWindowSignal()
				{
					Self = self, Page = page, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "create-window", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkNotebookHandleSignalStructs.FocusTabSignal> Signal_FocusTab(this GtkNotebookHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNotebookHandleSignalStructs.FocusTabSignal> obs) =>
		{
			GtkNotebookHandleSignalDelegates.focus_tab handler = ( MentorLake.Gtk.GtkNotebookHandle self,  MentorLake.Gtk.GtkNotebookTab @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookHandleSignalStructs.FocusTabSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "focus-tab", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkNotebookHandleSignalStructs.MoveFocusOutSignal> Signal_MoveFocusOut(this GtkNotebookHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNotebookHandleSignalStructs.MoveFocusOutSignal> obs) =>
		{
			GtkNotebookHandleSignalDelegates.move_focus_out handler = ( MentorLake.Gtk.GtkNotebookHandle self,  MentorLake.Gtk.GtkDirectionType @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookHandleSignalStructs.MoveFocusOutSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move-focus-out", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkNotebookHandleSignalStructs.PageAddedSignal> Signal_PageAdded(this GtkNotebookHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNotebookHandleSignalStructs.PageAddedSignal> obs) =>
		{
			GtkNotebookHandleSignalDelegates.page_added handler = ( MentorLake.Gtk.GtkNotebookHandle self,  MentorLake.Gtk.GtkWidgetHandle child,  uint page_num,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookHandleSignalStructs.PageAddedSignal()
				{
					Self = self, Child = child, PageNum = page_num, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "page-added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkNotebookHandleSignalStructs.PageRemovedSignal> Signal_PageRemoved(this GtkNotebookHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNotebookHandleSignalStructs.PageRemovedSignal> obs) =>
		{
			GtkNotebookHandleSignalDelegates.page_removed handler = ( MentorLake.Gtk.GtkNotebookHandle self,  MentorLake.Gtk.GtkWidgetHandle child,  uint page_num,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookHandleSignalStructs.PageRemovedSignal()
				{
					Self = self, Child = child, PageNum = page_num, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "page-removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkNotebookHandleSignalStructs.PageReorderedSignal> Signal_PageReordered(this GtkNotebookHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNotebookHandleSignalStructs.PageReorderedSignal> obs) =>
		{
			GtkNotebookHandleSignalDelegates.page_reordered handler = ( MentorLake.Gtk.GtkNotebookHandle self,  MentorLake.Gtk.GtkWidgetHandle child,  uint page_num,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookHandleSignalStructs.PageReorderedSignal()
				{
					Self = self, Child = child, PageNum = page_num, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "page-reordered", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkNotebookHandleSignalStructs.ReorderTabSignal> Signal_ReorderTab(this GtkNotebookHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNotebookHandleSignalStructs.ReorderTabSignal> obs) =>
		{
			GtkNotebookHandleSignalDelegates.reorder_tab handler = ( MentorLake.Gtk.GtkNotebookHandle self,  MentorLake.Gtk.GtkDirectionType @object,  bool p0,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookHandleSignalStructs.ReorderTabSignal()
				{
					Self = self, Object = @object, P0 = p0, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "reorder-tab", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkNotebookHandleSignalStructs.SelectPageSignal> Signal_SelectPage(this GtkNotebookHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNotebookHandleSignalStructs.SelectPageSignal> obs) =>
		{
			GtkNotebookHandleSignalDelegates.select_page handler = ( MentorLake.Gtk.GtkNotebookHandle self,  bool @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookHandleSignalStructs.SelectPageSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "select-page", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkNotebookHandleSignalStructs.SwitchPageSignal> Signal_SwitchPage(this GtkNotebookHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkNotebookHandleSignalStructs.SwitchPageSignal> obs) =>
		{
			GtkNotebookHandleSignalDelegates.switch_page handler = ( MentorLake.Gtk.GtkNotebookHandle self,  MentorLake.Gtk.GtkWidgetHandle page,  uint page_num,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookHandleSignalStructs.SwitchPageSignal()
				{
					Self = self, Page = page, PageNum = page_num, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "switch-page", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkNotebookHandleSignalStructs
{

public struct ChangeCurrentPageSignal
{
	public MentorLake.Gtk.GtkNotebookHandle Self;
	public int Object;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct CreateWindowSignal
{
	public MentorLake.Gtk.GtkNotebookHandle Self;
	public MentorLake.Gtk.GtkWidgetHandle Page;
	public int X;
	public int Y;
	public IntPtr UserData;
	public MentorLake.Gtk.GtkNotebookHandle ReturnValue;
}

public struct FocusTabSignal
{
	public MentorLake.Gtk.GtkNotebookHandle Self;
	public MentorLake.Gtk.GtkNotebookTab Object;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct MoveFocusOutSignal
{
	public MentorLake.Gtk.GtkNotebookHandle Self;
	public MentorLake.Gtk.GtkDirectionType Object;
	public IntPtr UserData;
}

public struct PageAddedSignal
{
	public MentorLake.Gtk.GtkNotebookHandle Self;
	public MentorLake.Gtk.GtkWidgetHandle Child;
	public uint PageNum;
	public IntPtr UserData;
}

public struct PageRemovedSignal
{
	public MentorLake.Gtk.GtkNotebookHandle Self;
	public MentorLake.Gtk.GtkWidgetHandle Child;
	public uint PageNum;
	public IntPtr UserData;
}

public struct PageReorderedSignal
{
	public MentorLake.Gtk.GtkNotebookHandle Self;
	public MentorLake.Gtk.GtkWidgetHandle Child;
	public uint PageNum;
	public IntPtr UserData;
}

public struct ReorderTabSignal
{
	public MentorLake.Gtk.GtkNotebookHandle Self;
	public MentorLake.Gtk.GtkDirectionType Object;
	public bool P0;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct SelectPageSignal
{
	public MentorLake.Gtk.GtkNotebookHandle Self;
	public bool Object;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct SwitchPageSignal
{
	public MentorLake.Gtk.GtkNotebookHandle Self;
	public MentorLake.Gtk.GtkWidgetHandle Page;
	public uint PageNum;
	public IntPtr UserData;
}
}

public static class GtkNotebookHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool change_current_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle self, int @object, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate MentorLake.Gtk.GtkNotebookHandle create_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page, int x, int y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool focus_tab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle self, MentorLake.Gtk.GtkNotebookTab @object, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_focus_out([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle self, MentorLake.Gtk.GtkDirectionType @object, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void page_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, uint page_num, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void page_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, uint page_num, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void page_reordered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, uint page_num, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool reorder_tab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle self, MentorLake.Gtk.GtkDirectionType @object, bool p0, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool select_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle self, bool @object, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void switch_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle page, uint page_num, IntPtr user_data);

}


public static class GtkNotebookHandleExtensions
{
	public static int AppendPage(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkWidgetHandle tab_label)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_append_page(notebook, child, tab_label);
	}

	public static int AppendPageMenu(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkWidgetHandle tab_label, MentorLake.Gtk.GtkWidgetHandle menu_label)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_append_page_menu(notebook, child, tab_label, menu_label);
	}

	public static T DetachTab<T>(this T notebook, MentorLake.Gtk.GtkWidgetHandle child) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_detach_tab(notebook, child);
		return notebook;
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetActionWidget(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkPackType pack_type)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_action_widget(notebook, pack_type);
	}

	public static int GetCurrentPage(this MentorLake.Gtk.GtkNotebookHandle notebook)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_current_page(notebook);
	}

	public static string GetGroupName(this MentorLake.Gtk.GtkNotebookHandle notebook)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_group_name(notebook);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetMenuLabel(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_menu_label(notebook, child);
	}

	public static string GetMenuLabelText(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_menu_label_text(notebook, child);
	}

	public static int GetNPages(this MentorLake.Gtk.GtkNotebookHandle notebook)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_n_pages(notebook);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetNthPage(this MentorLake.Gtk.GtkNotebookHandle notebook, int page_num)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_nth_page(notebook, page_num);
	}

	public static bool GetScrollable(this MentorLake.Gtk.GtkNotebookHandle notebook)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_scrollable(notebook);
	}

	public static bool GetShowBorder(this MentorLake.Gtk.GtkNotebookHandle notebook)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_show_border(notebook);
	}

	public static bool GetShowTabs(this MentorLake.Gtk.GtkNotebookHandle notebook)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_show_tabs(notebook);
	}

	public static bool GetTabDetachable(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_tab_detachable(notebook, child);
	}

	public static ushort GetTabHborder(this MentorLake.Gtk.GtkNotebookHandle notebook)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_tab_hborder(notebook);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetTabLabel(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_tab_label(notebook, child);
	}

	public static string GetTabLabelText(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_tab_label_text(notebook, child);
	}

	public static MentorLake.Gtk.GtkPositionType GetTabPos(this MentorLake.Gtk.GtkNotebookHandle notebook)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_tab_pos(notebook);
	}

	public static bool GetTabReorderable(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_tab_reorderable(notebook, child);
	}

	public static ushort GetTabVborder(this MentorLake.Gtk.GtkNotebookHandle notebook)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_get_tab_vborder(notebook);
	}

	public static int InsertPage(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkWidgetHandle tab_label, int position)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_insert_page(notebook, child, tab_label, position);
	}

	public static int InsertPageMenu(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkWidgetHandle tab_label, MentorLake.Gtk.GtkWidgetHandle menu_label, int position)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_insert_page_menu(notebook, child, tab_label, menu_label, position);
	}

	public static T NextPage<T>(this T notebook) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_next_page(notebook);
		return notebook;
	}

	public static int PageNum(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_page_num(notebook, child);
	}

	public static T PopupDisable<T>(this T notebook) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_popup_disable(notebook);
		return notebook;
	}

	public static T PopupEnable<T>(this T notebook) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_popup_enable(notebook);
		return notebook;
	}

	public static int PrependPage(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkWidgetHandle tab_label)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_prepend_page(notebook, child, tab_label);
	}

	public static int PrependPageMenu(this MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkWidgetHandle tab_label, MentorLake.Gtk.GtkWidgetHandle menu_label)
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		return GtkNotebookHandleExterns.gtk_notebook_prepend_page_menu(notebook, child, tab_label, menu_label);
	}

	public static T PrevPage<T>(this T notebook) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_prev_page(notebook);
		return notebook;
	}

	public static T RemovePage<T>(this T notebook, int page_num) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_remove_page(notebook, page_num);
		return notebook;
	}

	public static T ReorderChild<T>(this T notebook, MentorLake.Gtk.GtkWidgetHandle child, int position) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_reorder_child(notebook, child, position);
		return notebook;
	}

	public static T SetActionWidget<T>(this T notebook, MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkPackType pack_type) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_action_widget(notebook, widget, pack_type);
		return notebook;
	}

	public static T SetCurrentPage<T>(this T notebook, int page_num) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_current_page(notebook, page_num);
		return notebook;
	}

	public static T SetGroupName<T>(this T notebook, string group_name) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_group_name(notebook, group_name);
		return notebook;
	}

	public static T SetMenuLabel<T>(this T notebook, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkWidgetHandle menu_label) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_menu_label(notebook, child, menu_label);
		return notebook;
	}

	public static T SetMenuLabelText<T>(this T notebook, MentorLake.Gtk.GtkWidgetHandle child, string menu_text) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_menu_label_text(notebook, child, menu_text);
		return notebook;
	}

	public static T SetScrollable<T>(this T notebook, bool scrollable) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_scrollable(notebook, scrollable);
		return notebook;
	}

	public static T SetShowBorder<T>(this T notebook, bool show_border) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_show_border(notebook, show_border);
		return notebook;
	}

	public static T SetShowTabs<T>(this T notebook, bool show_tabs) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_show_tabs(notebook, show_tabs);
		return notebook;
	}

	public static T SetTabDetachable<T>(this T notebook, MentorLake.Gtk.GtkWidgetHandle child, bool detachable) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_tab_detachable(notebook, child, detachable);
		return notebook;
	}

	public static T SetTabLabel<T>(this T notebook, MentorLake.Gtk.GtkWidgetHandle child, MentorLake.Gtk.GtkWidgetHandle tab_label) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_tab_label(notebook, child, tab_label);
		return notebook;
	}

	public static T SetTabLabelText<T>(this T notebook, MentorLake.Gtk.GtkWidgetHandle child, string tab_text) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_tab_label_text(notebook, child, tab_text);
		return notebook;
	}

	public static T SetTabPos<T>(this T notebook, MentorLake.Gtk.GtkPositionType pos) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_tab_pos(notebook, pos);
		return notebook;
	}

	public static T SetTabReorderable<T>(this T notebook, MentorLake.Gtk.GtkWidgetHandle child, bool reorderable) where T : GtkNotebookHandle
	{
		if (notebook.IsInvalid || notebook.IsClosed) throw new Exception("Invalid or closed handle (GtkNotebookHandle)");
		GtkNotebookHandleExterns.gtk_notebook_set_tab_reorderable(notebook, child, reorderable);
		return notebook;
	}

}

internal class GtkNotebookHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkNotebookHandle gtk_notebook_new();

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_notebook_append_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle tab_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_notebook_append_page_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle tab_label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle menu_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_detach_tab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_notebook_get_action_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkPackType pack_type);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_notebook_get_current_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_notebook_get_group_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_notebook_get_menu_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_notebook_get_menu_label_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_notebook_get_n_pages([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_notebook_get_nth_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, int page_num);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_notebook_get_scrollable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_notebook_get_show_border([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_notebook_get_show_tabs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_notebook_get_tab_detachable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern ushort gtk_notebook_get_tab_hborder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_notebook_get_tab_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_notebook_get_tab_label_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkPositionType gtk_notebook_get_tab_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_notebook_get_tab_reorderable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern ushort gtk_notebook_get_tab_vborder([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_notebook_insert_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle tab_label, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_notebook_insert_page_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle tab_label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle menu_label, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_next_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_notebook_page_num([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_popup_disable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_popup_enable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_notebook_prepend_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle tab_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_notebook_prepend_page_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle tab_label, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle menu_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_prev_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_remove_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, int page_num);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_reorder_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, int position);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_action_widget([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkPackType pack_type);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_current_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, int page_num);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_group_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, string group_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_menu_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle menu_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_menu_label_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, string menu_text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_scrollable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, bool scrollable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_show_border([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, bool show_border);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_show_tabs([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, bool show_tabs);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_tab_detachable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, bool detachable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_tab_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle tab_label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_tab_label_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, string tab_text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_tab_pos([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, MentorLake.Gtk.GtkPositionType pos);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_notebook_set_tab_reorderable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkNotebookHandle>))] MentorLake.Gtk.GtkNotebookHandle notebook, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle child, bool reorderable);

}
