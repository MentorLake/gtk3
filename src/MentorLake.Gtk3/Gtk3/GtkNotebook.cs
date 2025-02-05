namespace MentorLake.Gtk3.Gtk3;

public class GtkNotebookHandle : GtkContainerHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkNotebookHandle New()
	{
		return GtkNotebookExterns.gtk_notebook_new();
	}

}

public static class GtkNotebookSignalExtensions
{

	public static IObservable<GtkNotebookSignalStructs.ChangeCurrentPageSignal> Signal_ChangeCurrentPage(this GtkNotebookHandle instance)
	{
		return Observable.Create((IObserver<GtkNotebookSignalStructs.ChangeCurrentPageSignal> obs) =>
		{
			GtkNotebookSignalDelegates.change_current_page handler = (GtkNotebookHandle self, int @object, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookSignalStructs.ChangeCurrentPageSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "change_current_page", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkNotebookSignalStructs.CreateWindowSignal> Signal_CreateWindow(this GtkNotebookHandle instance)
	{
		return Observable.Create((IObserver<GtkNotebookSignalStructs.CreateWindowSignal> obs) =>
		{
			GtkNotebookSignalDelegates.create_window handler = (GtkNotebookHandle self, GtkWidgetHandle page, int x, int y, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookSignalStructs.CreateWindowSignal()
				{
					Self = self, Page = page, X = x, Y = y, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "create_window", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkNotebookSignalStructs.FocusTabSignal> Signal_FocusTab(this GtkNotebookHandle instance)
	{
		return Observable.Create((IObserver<GtkNotebookSignalStructs.FocusTabSignal> obs) =>
		{
			GtkNotebookSignalDelegates.focus_tab handler = (GtkNotebookHandle self, GtkNotebookTab @object, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookSignalStructs.FocusTabSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "focus_tab", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkNotebookSignalStructs.MoveFocusOutSignal> Signal_MoveFocusOut(this GtkNotebookHandle instance)
	{
		return Observable.Create((IObserver<GtkNotebookSignalStructs.MoveFocusOutSignal> obs) =>
		{
			GtkNotebookSignalDelegates.move_focus_out handler = (GtkNotebookHandle self, GtkDirectionType @object, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookSignalStructs.MoveFocusOutSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "move_focus_out", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkNotebookSignalStructs.PageAddedSignal> Signal_PageAdded(this GtkNotebookHandle instance)
	{
		return Observable.Create((IObserver<GtkNotebookSignalStructs.PageAddedSignal> obs) =>
		{
			GtkNotebookSignalDelegates.page_added handler = (GtkNotebookHandle self, GtkWidgetHandle child, uint page_num, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookSignalStructs.PageAddedSignal()
				{
					Self = self, Child = child, PageNum = page_num, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "page_added", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkNotebookSignalStructs.PageRemovedSignal> Signal_PageRemoved(this GtkNotebookHandle instance)
	{
		return Observable.Create((IObserver<GtkNotebookSignalStructs.PageRemovedSignal> obs) =>
		{
			GtkNotebookSignalDelegates.page_removed handler = (GtkNotebookHandle self, GtkWidgetHandle child, uint page_num, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookSignalStructs.PageRemovedSignal()
				{
					Self = self, Child = child, PageNum = page_num, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "page_removed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkNotebookSignalStructs.PageReorderedSignal> Signal_PageReordered(this GtkNotebookHandle instance)
	{
		return Observable.Create((IObserver<GtkNotebookSignalStructs.PageReorderedSignal> obs) =>
		{
			GtkNotebookSignalDelegates.page_reordered handler = (GtkNotebookHandle self, GtkWidgetHandle child, uint page_num, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookSignalStructs.PageReorderedSignal()
				{
					Self = self, Child = child, PageNum = page_num, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "page_reordered", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkNotebookSignalStructs.ReorderTabSignal> Signal_ReorderTab(this GtkNotebookHandle instance)
	{
		return Observable.Create((IObserver<GtkNotebookSignalStructs.ReorderTabSignal> obs) =>
		{
			GtkNotebookSignalDelegates.reorder_tab handler = (GtkNotebookHandle self, GtkDirectionType @object, bool p0, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookSignalStructs.ReorderTabSignal()
				{
					Self = self, Object = @object, P0 = p0, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "reorder_tab", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkNotebookSignalStructs.SelectPageSignal> Signal_SelectPage(this GtkNotebookHandle instance)
	{
		return Observable.Create((IObserver<GtkNotebookSignalStructs.SelectPageSignal> obs) =>
		{
			GtkNotebookSignalDelegates.select_page handler = (GtkNotebookHandle self, bool @object, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookSignalStructs.SelectPageSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "select_page", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkNotebookSignalStructs.SwitchPageSignal> Signal_SwitchPage(this GtkNotebookHandle instance)
	{
		return Observable.Create((IObserver<GtkNotebookSignalStructs.SwitchPageSignal> obs) =>
		{
			GtkNotebookSignalDelegates.switch_page handler = (GtkNotebookHandle self, GtkWidgetHandle page, uint page_num, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkNotebookSignalStructs.SwitchPageSignal()
				{
					Self = self, Page = page, PageNum = page_num, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "switch_page", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkNotebookSignalStructs
{

public struct ChangeCurrentPageSignal
{
	public GtkNotebookHandle Self;
	public int Object;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct CreateWindowSignal
{
	public GtkNotebookHandle Self;
	public GtkWidgetHandle Page;
	public int X;
	public int Y;
	public IntPtr UserData;
	public GtkNotebookHandle ReturnValue;
}

public struct FocusTabSignal
{
	public GtkNotebookHandle Self;
	public GtkNotebookTab Object;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct MoveFocusOutSignal
{
	public GtkNotebookHandle Self;
	public GtkDirectionType Object;
	public IntPtr UserData;
}

public struct PageAddedSignal
{
	public GtkNotebookHandle Self;
	public GtkWidgetHandle Child;
	public uint PageNum;
	public IntPtr UserData;
}

public struct PageRemovedSignal
{
	public GtkNotebookHandle Self;
	public GtkWidgetHandle Child;
	public uint PageNum;
	public IntPtr UserData;
}

public struct PageReorderedSignal
{
	public GtkNotebookHandle Self;
	public GtkWidgetHandle Child;
	public uint PageNum;
	public IntPtr UserData;
}

public struct ReorderTabSignal
{
	public GtkNotebookHandle Self;
	public GtkDirectionType Object;
	public bool P0;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct SelectPageSignal
{
	public GtkNotebookHandle Self;
	public bool Object;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct SwitchPageSignal
{
	public GtkNotebookHandle Self;
	public GtkWidgetHandle Page;
	public uint PageNum;
	public IntPtr UserData;
}
}

public static class GtkNotebookSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool change_current_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkNotebookHandle>))] GtkNotebookHandle self, int @object, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate GtkNotebookHandle create_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkNotebookHandle>))] GtkNotebookHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle page, int x, int y, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool focus_tab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkNotebookHandle>))] GtkNotebookHandle self, GtkNotebookTab @object, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_focus_out([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkNotebookHandle>))] GtkNotebookHandle self, GtkDirectionType @object, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void page_added([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkNotebookHandle>))] GtkNotebookHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle child, uint page_num, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void page_removed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkNotebookHandle>))] GtkNotebookHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle child, uint page_num, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void page_reordered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkNotebookHandle>))] GtkNotebookHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle child, uint page_num, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool reorder_tab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkNotebookHandle>))] GtkNotebookHandle self, GtkDirectionType @object, bool p0, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool select_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkNotebookHandle>))] GtkNotebookHandle self, bool @object, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void switch_page([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkNotebookHandle>))] GtkNotebookHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle page, uint page_num, IntPtr user_data);

}


public static class GtkNotebookHandleExtensions
{
	public static int AppendPage(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label)
	{
		return GtkNotebookExterns.gtk_notebook_append_page(notebook, child, tab_label);
	}

	public static int AppendPageMenu(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, GtkWidgetHandle menu_label)
	{
		return GtkNotebookExterns.gtk_notebook_append_page_menu(notebook, child, tab_label, menu_label);
	}

	public static T DetachTab<T>(this T notebook, GtkWidgetHandle child) where T : GtkNotebookHandle
	{
		GtkNotebookExterns.gtk_notebook_detach_tab(notebook, child);
		return notebook;
	}

	public static GtkWidgetHandle GetActionWidget(this GtkNotebookHandle notebook, GtkPackType pack_type)
	{
		return GtkNotebookExterns.gtk_notebook_get_action_widget(notebook, pack_type);
	}

	public static int GetCurrentPage(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_current_page(notebook);
	}

	public static string GetGroupName(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_group_name(notebook);
	}

	public static GtkWidgetHandle GetMenuLabel(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_get_menu_label(notebook, child);
	}

	public static string GetMenuLabelText(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_get_menu_label_text(notebook, child);
	}

	public static int GetNPages(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_n_pages(notebook);
	}

	public static GtkWidgetHandle GetNthPage(this GtkNotebookHandle notebook, int page_num)
	{
		return GtkNotebookExterns.gtk_notebook_get_nth_page(notebook, page_num);
	}

	public static bool GetScrollable(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_scrollable(notebook);
	}

	public static bool GetShowBorder(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_show_border(notebook);
	}

	public static bool GetShowTabs(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_show_tabs(notebook);
	}

	public static bool GetTabDetachable(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_get_tab_detachable(notebook, child);
	}

	public static ushort GetTabHborder(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_tab_hborder(notebook);
	}

	public static GtkWidgetHandle GetTabLabel(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_get_tab_label(notebook, child);
	}

	public static string GetTabLabelText(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_get_tab_label_text(notebook, child);
	}

	public static GtkPositionType GetTabPos(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_tab_pos(notebook);
	}

	public static bool GetTabReorderable(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_get_tab_reorderable(notebook, child);
	}

	public static ushort GetTabVborder(this GtkNotebookHandle notebook)
	{
		return GtkNotebookExterns.gtk_notebook_get_tab_vborder(notebook);
	}

	public static int InsertPage(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, int position)
	{
		return GtkNotebookExterns.gtk_notebook_insert_page(notebook, child, tab_label, position);
	}

	public static int InsertPageMenu(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, GtkWidgetHandle menu_label, int position)
	{
		return GtkNotebookExterns.gtk_notebook_insert_page_menu(notebook, child, tab_label, menu_label, position);
	}

	public static T NextPage<T>(this T notebook) where T : GtkNotebookHandle
	{
		GtkNotebookExterns.gtk_notebook_next_page(notebook);
		return notebook;
	}

	public static int PageNum(this GtkNotebookHandle notebook, GtkWidgetHandle child)
	{
		return GtkNotebookExterns.gtk_notebook_page_num(notebook, child);
	}

	public static T PopupDisable<T>(this T notebook) where T : GtkNotebookHandle
	{
		GtkNotebookExterns.gtk_notebook_popup_disable(notebook);
		return notebook;
	}

	public static T PopupEnable<T>(this T notebook) where T : GtkNotebookHandle
	{
		GtkNotebookExterns.gtk_notebook_popup_enable(notebook);
		return notebook;
	}

	public static int PrependPage(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label)
	{
		return GtkNotebookExterns.gtk_notebook_prepend_page(notebook, child, tab_label);
	}

	public static int PrependPageMenu(this GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, GtkWidgetHandle menu_label)
	{
		return GtkNotebookExterns.gtk_notebook_prepend_page_menu(notebook, child, tab_label, menu_label);
	}

	public static T PrevPage<T>(this T notebook) where T : GtkNotebookHandle
	{
		GtkNotebookExterns.gtk_notebook_prev_page(notebook);
		return notebook;
	}

	public static T RemovePage<T>(this T notebook, int page_num) where T : GtkNotebookHandle
	{
		GtkNotebookExterns.gtk_notebook_remove_page(notebook, page_num);
		return notebook;
	}

	public static T ReorderChild<T>(this T notebook, GtkWidgetHandle child, int position) where T : GtkNotebookHandle
	{
		GtkNotebookExterns.gtk_notebook_reorder_child(notebook, child, position);
		return notebook;
	}

	public static T SetActionWidget<T>(this T notebook, GtkWidgetHandle widget, GtkPackType pack_type) where T : GtkNotebookHandle
	{
		GtkNotebookExterns.gtk_notebook_set_action_widget(notebook, widget, pack_type);
		return notebook;
	}

	public static T SetCurrentPage<T>(this T notebook, int page_num) where T : GtkNotebookHandle
	{
		GtkNotebookExterns.gtk_notebook_set_current_page(notebook, page_num);
		return notebook;
	}

	public static T SetGroupName<T>(this T notebook, string group_name) where T : GtkNotebookHandle
	{
		GtkNotebookExterns.gtk_notebook_set_group_name(notebook, group_name);
		return notebook;
	}

	public static T SetMenuLabel<T>(this T notebook, GtkWidgetHandle child, GtkWidgetHandle menu_label) where T : GtkNotebookHandle
	{
		GtkNotebookExterns.gtk_notebook_set_menu_label(notebook, child, menu_label);
		return notebook;
	}

	public static T SetMenuLabelText<T>(this T notebook, GtkWidgetHandle child, string menu_text) where T : GtkNotebookHandle
	{
		GtkNotebookExterns.gtk_notebook_set_menu_label_text(notebook, child, menu_text);
		return notebook;
	}

	public static T SetScrollable<T>(this T notebook, bool scrollable) where T : GtkNotebookHandle
	{
		GtkNotebookExterns.gtk_notebook_set_scrollable(notebook, scrollable);
		return notebook;
	}

	public static T SetShowBorder<T>(this T notebook, bool show_border) where T : GtkNotebookHandle
	{
		GtkNotebookExterns.gtk_notebook_set_show_border(notebook, show_border);
		return notebook;
	}

	public static T SetShowTabs<T>(this T notebook, bool show_tabs) where T : GtkNotebookHandle
	{
		GtkNotebookExterns.gtk_notebook_set_show_tabs(notebook, show_tabs);
		return notebook;
	}

	public static T SetTabDetachable<T>(this T notebook, GtkWidgetHandle child, bool detachable) where T : GtkNotebookHandle
	{
		GtkNotebookExterns.gtk_notebook_set_tab_detachable(notebook, child, detachable);
		return notebook;
	}

	public static T SetTabLabel<T>(this T notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label) where T : GtkNotebookHandle
	{
		GtkNotebookExterns.gtk_notebook_set_tab_label(notebook, child, tab_label);
		return notebook;
	}

	public static T SetTabLabelText<T>(this T notebook, GtkWidgetHandle child, string tab_text) where T : GtkNotebookHandle
	{
		GtkNotebookExterns.gtk_notebook_set_tab_label_text(notebook, child, tab_text);
		return notebook;
	}

	public static T SetTabPos<T>(this T notebook, GtkPositionType pos) where T : GtkNotebookHandle
	{
		GtkNotebookExterns.gtk_notebook_set_tab_pos(notebook, pos);
		return notebook;
	}

	public static T SetTabReorderable<T>(this T notebook, GtkWidgetHandle child, bool reorderable) where T : GtkNotebookHandle
	{
		GtkNotebookExterns.gtk_notebook_set_tab_reorderable(notebook, child, reorderable);
		return notebook;
	}

}

internal class GtkNotebookExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkNotebookHandle gtk_notebook_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_notebook_append_page(GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_notebook_append_page_menu(GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, GtkWidgetHandle menu_label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_notebook_detach_tab(GtkNotebookHandle notebook, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_notebook_get_action_widget(GtkNotebookHandle notebook, GtkPackType pack_type);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_notebook_get_current_page(GtkNotebookHandle notebook);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_notebook_get_group_name(GtkNotebookHandle notebook);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_notebook_get_menu_label(GtkNotebookHandle notebook, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_notebook_get_menu_label_text(GtkNotebookHandle notebook, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_notebook_get_n_pages(GtkNotebookHandle notebook);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_notebook_get_nth_page(GtkNotebookHandle notebook, int page_num);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_notebook_get_scrollable(GtkNotebookHandle notebook);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_notebook_get_show_border(GtkNotebookHandle notebook);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_notebook_get_show_tabs(GtkNotebookHandle notebook);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_notebook_get_tab_detachable(GtkNotebookHandle notebook, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern ushort gtk_notebook_get_tab_hborder(GtkNotebookHandle notebook);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_notebook_get_tab_label(GtkNotebookHandle notebook, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_notebook_get_tab_label_text(GtkNotebookHandle notebook, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkPositionType gtk_notebook_get_tab_pos(GtkNotebookHandle notebook);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_notebook_get_tab_reorderable(GtkNotebookHandle notebook, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern ushort gtk_notebook_get_tab_vborder(GtkNotebookHandle notebook);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_notebook_insert_page(GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, int position);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_notebook_insert_page_menu(GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, GtkWidgetHandle menu_label, int position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_notebook_next_page(GtkNotebookHandle notebook);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_notebook_page_num(GtkNotebookHandle notebook, GtkWidgetHandle child);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_notebook_popup_disable(GtkNotebookHandle notebook);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_notebook_popup_enable(GtkNotebookHandle notebook);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_notebook_prepend_page(GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_notebook_prepend_page_menu(GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label, GtkWidgetHandle menu_label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_notebook_prev_page(GtkNotebookHandle notebook);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_notebook_remove_page(GtkNotebookHandle notebook, int page_num);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_notebook_reorder_child(GtkNotebookHandle notebook, GtkWidgetHandle child, int position);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_notebook_set_action_widget(GtkNotebookHandle notebook, GtkWidgetHandle widget, GtkPackType pack_type);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_notebook_set_current_page(GtkNotebookHandle notebook, int page_num);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_notebook_set_group_name(GtkNotebookHandle notebook, string group_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_notebook_set_menu_label(GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle menu_label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_notebook_set_menu_label_text(GtkNotebookHandle notebook, GtkWidgetHandle child, string menu_text);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_notebook_set_scrollable(GtkNotebookHandle notebook, bool scrollable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_notebook_set_show_border(GtkNotebookHandle notebook, bool show_border);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_notebook_set_show_tabs(GtkNotebookHandle notebook, bool show_tabs);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_notebook_set_tab_detachable(GtkNotebookHandle notebook, GtkWidgetHandle child, bool detachable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_notebook_set_tab_label(GtkNotebookHandle notebook, GtkWidgetHandle child, GtkWidgetHandle tab_label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_notebook_set_tab_label_text(GtkNotebookHandle notebook, GtkWidgetHandle child, string tab_text);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_notebook_set_tab_pos(GtkNotebookHandle notebook, GtkPositionType pos);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_notebook_set_tab_reorderable(GtkNotebookHandle notebook, GtkWidgetHandle child, bool reorderable);

}
