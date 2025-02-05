namespace MentorLake.Gtk3.Gtk3;

public class GtkEntryCompletionHandle : GObjectHandle, GtkBuildableHandle, GtkCellLayoutHandle
{
	public static GtkEntryCompletionHandle New()
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_new();
	}

	public static GtkEntryCompletionHandle NewWithArea(GtkCellAreaHandle area)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_new_with_area(area);
	}

}

public static class GtkEntryCompletionSignalExtensions
{

	public static IObservable<GtkEntryCompletionSignalStructs.ActionActivatedSignal> Signal_ActionActivated(this GtkEntryCompletionHandle instance)
	{
		return Observable.Create((IObserver<GtkEntryCompletionSignalStructs.ActionActivatedSignal> obs) =>
		{
			GtkEntryCompletionSignalDelegates.action_activated handler = (GtkEntryCompletionHandle self, int index, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryCompletionSignalStructs.ActionActivatedSignal()
				{
					Self = self, Index = index, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "action_activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEntryCompletionSignalStructs.CursorOnMatchSignal> Signal_CursorOnMatch(this GtkEntryCompletionHandle instance)
	{
		return Observable.Create((IObserver<GtkEntryCompletionSignalStructs.CursorOnMatchSignal> obs) =>
		{
			GtkEntryCompletionSignalDelegates.cursor_on_match handler = (GtkEntryCompletionHandle self, GtkTreeModelHandle model, GtkTreeIterHandle iter, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryCompletionSignalStructs.CursorOnMatchSignal()
				{
					Self = self, Model = model, Iter = iter, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "cursor_on_match", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEntryCompletionSignalStructs.InsertPrefixSignal> Signal_InsertPrefix(this GtkEntryCompletionHandle instance)
	{
		return Observable.Create((IObserver<GtkEntryCompletionSignalStructs.InsertPrefixSignal> obs) =>
		{
			GtkEntryCompletionSignalDelegates.insert_prefix handler = (GtkEntryCompletionHandle self, string prefix, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryCompletionSignalStructs.InsertPrefixSignal()
				{
					Self = self, Prefix = prefix, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "insert_prefix", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEntryCompletionSignalStructs.MatchSelectedSignal> Signal_MatchSelected(this GtkEntryCompletionHandle instance)
	{
		return Observable.Create((IObserver<GtkEntryCompletionSignalStructs.MatchSelectedSignal> obs) =>
		{
			GtkEntryCompletionSignalDelegates.match_selected handler = (GtkEntryCompletionHandle self, GtkTreeModelHandle model, GtkTreeIterHandle iter, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryCompletionSignalStructs.MatchSelectedSignal()
				{
					Self = self, Model = model, Iter = iter, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "match_selected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkEntryCompletionSignalStructs.NoMatchesSignal> Signal_NoMatches(this GtkEntryCompletionHandle instance)
	{
		return Observable.Create((IObserver<GtkEntryCompletionSignalStructs.NoMatchesSignal> obs) =>
		{
			GtkEntryCompletionSignalDelegates.no_matches handler = (GtkEntryCompletionHandle self, IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryCompletionSignalStructs.NoMatchesSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "no_matches", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkEntryCompletionSignalStructs
{

public struct ActionActivatedSignal
{
	public GtkEntryCompletionHandle Self;
	public int Index;
	public IntPtr UserData;
}

public struct CursorOnMatchSignal
{
	public GtkEntryCompletionHandle Self;
	public GtkTreeModelHandle Model;
	public GtkTreeIterHandle Iter;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct InsertPrefixSignal
{
	public GtkEntryCompletionHandle Self;
	public string Prefix;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct MatchSelectedSignal
{
	public GtkEntryCompletionHandle Self;
	public GtkTreeModelHandle Model;
	public GtkTreeIterHandle Iter;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct NoMatchesSignal
{
	public GtkEntryCompletionHandle Self;
	public IntPtr UserData;
}
}

public static class GtkEntryCompletionSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryCompletionHandle>))] GtkEntryCompletionHandle self, int index, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool cursor_on_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryCompletionHandle>))] GtkEntryCompletionHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeModelHandleImpl>))] GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeIterHandle>))] GtkTreeIterHandle iter, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool insert_prefix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryCompletionHandle>))] GtkEntryCompletionHandle self, string prefix, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool match_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryCompletionHandle>))] GtkEntryCompletionHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeModelHandleImpl>))] GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTreeIterHandle>))] GtkTreeIterHandle iter, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void no_matches([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkEntryCompletionHandle>))] GtkEntryCompletionHandle self, IntPtr user_data);

}


public static class GtkEntryCompletionHandleExtensions
{
	public static T Complete<T>(this T completion) where T : GtkEntryCompletionHandle
	{
		GtkEntryCompletionExterns.gtk_entry_completion_complete(completion);
		return completion;
	}

	public static string ComputePrefix(this GtkEntryCompletionHandle completion, string key)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_compute_prefix(completion, key);
	}

	public static T DeleteAction<T>(this T completion, int index_) where T : GtkEntryCompletionHandle
	{
		GtkEntryCompletionExterns.gtk_entry_completion_delete_action(completion, index_);
		return completion;
	}

	public static string GetCompletionPrefix(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_completion_prefix(completion);
	}

	public static GtkWidgetHandle GetEntry(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_entry(completion);
	}

	public static bool GetInlineCompletion(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_inline_completion(completion);
	}

	public static bool GetInlineSelection(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_inline_selection(completion);
	}

	public static int GetMinimumKeyLength(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_minimum_key_length(completion);
	}

	public static GtkTreeModelHandle GetModel(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_model(completion);
	}

	public static bool GetPopupCompletion(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_popup_completion(completion);
	}

	public static bool GetPopupSetWidth(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_popup_set_width(completion);
	}

	public static bool GetPopupSingleMatch(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_popup_single_match(completion);
	}

	public static int GetTextColumn(this GtkEntryCompletionHandle completion)
	{
		return GtkEntryCompletionExterns.gtk_entry_completion_get_text_column(completion);
	}

	public static T InsertActionMarkup<T>(this T completion, int index_, string markup) where T : GtkEntryCompletionHandle
	{
		GtkEntryCompletionExterns.gtk_entry_completion_insert_action_markup(completion, index_, markup);
		return completion;
	}

	public static T InsertActionText<T>(this T completion, int index_, string text) where T : GtkEntryCompletionHandle
	{
		GtkEntryCompletionExterns.gtk_entry_completion_insert_action_text(completion, index_, text);
		return completion;
	}

	public static T InsertPrefix<T>(this T completion) where T : GtkEntryCompletionHandle
	{
		GtkEntryCompletionExterns.gtk_entry_completion_insert_prefix(completion);
		return completion;
	}

	public static T SetInlineCompletion<T>(this T completion, bool inline_completion) where T : GtkEntryCompletionHandle
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_inline_completion(completion, inline_completion);
		return completion;
	}

	public static T SetInlineSelection<T>(this T completion, bool inline_selection) where T : GtkEntryCompletionHandle
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_inline_selection(completion, inline_selection);
		return completion;
	}

	public static T SetMatchFunc<T>(this T completion, GtkEntryCompletionMatchFunc func, IntPtr func_data, GDestroyNotify func_notify) where T : GtkEntryCompletionHandle
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_match_func(completion, func, func_data, func_notify);
		return completion;
	}

	public static T SetMinimumKeyLength<T>(this T completion, int length) where T : GtkEntryCompletionHandle
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_minimum_key_length(completion, length);
		return completion;
	}

	public static T SetModel<T>(this T completion, GtkTreeModelHandle model) where T : GtkEntryCompletionHandle
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_model(completion, model);
		return completion;
	}

	public static T SetPopupCompletion<T>(this T completion, bool popup_completion) where T : GtkEntryCompletionHandle
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_popup_completion(completion, popup_completion);
		return completion;
	}

	public static T SetPopupSetWidth<T>(this T completion, bool popup_set_width) where T : GtkEntryCompletionHandle
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_popup_set_width(completion, popup_set_width);
		return completion;
	}

	public static T SetPopupSingleMatch<T>(this T completion, bool popup_single_match) where T : GtkEntryCompletionHandle
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_popup_single_match(completion, popup_single_match);
		return completion;
	}

	public static T SetTextColumn<T>(this T completion, int column) where T : GtkEntryCompletionHandle
	{
		GtkEntryCompletionExterns.gtk_entry_completion_set_text_column(completion, column);
		return completion;
	}

}

internal class GtkEntryCompletionExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkEntryCompletionHandle gtk_entry_completion_new();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkEntryCompletionHandle gtk_entry_completion_new_with_area(GtkCellAreaHandle area);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_completion_complete(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_entry_completion_compute_prefix(GtkEntryCompletionHandle completion, string key);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_completion_delete_action(GtkEntryCompletionHandle completion, int index_);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_entry_completion_get_completion_prefix(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_entry_completion_get_entry(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_entry_completion_get_inline_completion(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_entry_completion_get_inline_selection(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_entry_completion_get_minimum_key_length(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTreeModelHandle gtk_entry_completion_get_model(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_entry_completion_get_popup_completion(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_entry_completion_get_popup_set_width(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_entry_completion_get_popup_single_match(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_entry_completion_get_text_column(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_completion_insert_action_markup(GtkEntryCompletionHandle completion, int index_, string markup);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_completion_insert_action_text(GtkEntryCompletionHandle completion, int index_, string text);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_completion_insert_prefix(GtkEntryCompletionHandle completion);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_completion_set_inline_completion(GtkEntryCompletionHandle completion, bool inline_completion);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_completion_set_inline_selection(GtkEntryCompletionHandle completion, bool inline_selection);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_completion_set_match_func(GtkEntryCompletionHandle completion, GtkEntryCompletionMatchFunc func, IntPtr func_data, GDestroyNotify func_notify);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_completion_set_minimum_key_length(GtkEntryCompletionHandle completion, int length);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_completion_set_model(GtkEntryCompletionHandle completion, GtkTreeModelHandle model);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_completion_set_popup_completion(GtkEntryCompletionHandle completion, bool popup_completion);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_completion_set_popup_set_width(GtkEntryCompletionHandle completion, bool popup_set_width);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_completion_set_popup_single_match(GtkEntryCompletionHandle completion, bool popup_single_match);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_entry_completion_set_text_column(GtkEntryCompletionHandle completion, int column);

}
