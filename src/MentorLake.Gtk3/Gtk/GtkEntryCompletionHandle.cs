namespace MentorLake.Gtk;

public class GtkEntryCompletionHandle : GObjectHandle, GtkBuildableHandle, GtkCellLayoutHandle
{
	public static MentorLake.Gtk.GtkEntryCompletionHandle New()
	{
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_new();
	}

	public static MentorLake.Gtk.GtkEntryCompletionHandle NewWithArea(MentorLake.Gtk.GtkCellAreaHandle area)
	{
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_new_with_area(area);
	}

}
public static class GtkEntryCompletionHandleSignalExtensions
{

	public static IObservable<GtkEntryCompletionHandleSignalStructs.ActionActivatedSignal> Signal_ActionActivated(this GtkEntryCompletionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryCompletionHandleSignalStructs.ActionActivatedSignal> obs) =>
		{
			GtkEntryCompletionHandleSignalDelegates.action_activated handler = ( MentorLake.Gtk.GtkEntryCompletionHandle self,  int index,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryCompletionHandleSignalStructs.ActionActivatedSignal()
				{
					Self = self, Index = index, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "action-activated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkEntryCompletionHandleSignalStructs.CursorOnMatchSignal> Signal_CursorOnMatch(this GtkEntryCompletionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryCompletionHandleSignalStructs.CursorOnMatchSignal> obs) =>
		{
			GtkEntryCompletionHandleSignalDelegates.cursor_on_match handler = ( MentorLake.Gtk.GtkEntryCompletionHandle self,  MentorLake.Gtk.GtkTreeModelHandle model,  MentorLake.Gtk.GtkTreeIterHandle iter,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryCompletionHandleSignalStructs.CursorOnMatchSignal()
				{
					Self = self, Model = model, Iter = iter, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "cursor-on-match", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkEntryCompletionHandleSignalStructs.InsertPrefixSignal> Signal_InsertPrefix(this GtkEntryCompletionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryCompletionHandleSignalStructs.InsertPrefixSignal> obs) =>
		{
			GtkEntryCompletionHandleSignalDelegates.insert_prefix handler = ( MentorLake.Gtk.GtkEntryCompletionHandle self,  string prefix,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryCompletionHandleSignalStructs.InsertPrefixSignal()
				{
					Self = self, Prefix = prefix, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "insert-prefix", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkEntryCompletionHandleSignalStructs.MatchSelectedSignal> Signal_MatchSelected(this GtkEntryCompletionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryCompletionHandleSignalStructs.MatchSelectedSignal> obs) =>
		{
			GtkEntryCompletionHandleSignalDelegates.match_selected handler = ( MentorLake.Gtk.GtkEntryCompletionHandle self,  MentorLake.Gtk.GtkTreeModelHandle model,  MentorLake.Gtk.GtkTreeIterHandle iter,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryCompletionHandleSignalStructs.MatchSelectedSignal()
				{
					Self = self, Model = model, Iter = iter, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "match-selected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkEntryCompletionHandleSignalStructs.NoMatchesSignal> Signal_NoMatches(this GtkEntryCompletionHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkEntryCompletionHandleSignalStructs.NoMatchesSignal> obs) =>
		{
			GtkEntryCompletionHandleSignalDelegates.no_matches handler = ( MentorLake.Gtk.GtkEntryCompletionHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkEntryCompletionHandleSignalStructs.NoMatchesSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "no-matches", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkEntryCompletionHandleSignalStructs
{

public class ActionActivatedSignal
{
	public MentorLake.Gtk.GtkEntryCompletionHandle Self;
	public int Index;
	public IntPtr UserData;
}

public class CursorOnMatchSignal
{
	public MentorLake.Gtk.GtkEntryCompletionHandle Self;
	public MentorLake.Gtk.GtkTreeModelHandle Model;
	public MentorLake.Gtk.GtkTreeIterHandle Iter;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class InsertPrefixSignal
{
	public MentorLake.Gtk.GtkEntryCompletionHandle Self;
	public string Prefix;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class MatchSelectedSignal
{
	public MentorLake.Gtk.GtkEntryCompletionHandle Self;
	public MentorLake.Gtk.GtkTreeModelHandle Model;
	public MentorLake.Gtk.GtkTreeIterHandle Iter;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class NoMatchesSignal
{
	public MentorLake.Gtk.GtkEntryCompletionHandle Self;
	public IntPtr UserData;
}
}

public static class GtkEntryCompletionHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle self, int index, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool cursor_on_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool insert_prefix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle self, string prefix, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool match_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void no_matches([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle self, IntPtr user_data);

}


public static class GtkEntryCompletionHandleExtensions
{
	public static T Complete<T>(this T completion) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_complete(completion);
		return completion;
	}

	public static string ComputePrefix(this MentorLake.Gtk.GtkEntryCompletionHandle completion, string key)
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_compute_prefix(completion, key);
	}

	public static T DeleteAction<T>(this T completion, int index_) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_delete_action(completion, index_);
		return completion;
	}

	public static string GetCompletionPrefix(this MentorLake.Gtk.GtkEntryCompletionHandle completion)
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_get_completion_prefix(completion);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetEntry(this MentorLake.Gtk.GtkEntryCompletionHandle completion)
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_get_entry(completion);
	}

	public static bool GetInlineCompletion(this MentorLake.Gtk.GtkEntryCompletionHandle completion)
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_get_inline_completion(completion);
	}

	public static bool GetInlineSelection(this MentorLake.Gtk.GtkEntryCompletionHandle completion)
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_get_inline_selection(completion);
	}

	public static int GetMinimumKeyLength(this MentorLake.Gtk.GtkEntryCompletionHandle completion)
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_get_minimum_key_length(completion);
	}

	public static MentorLake.Gtk.GtkTreeModelHandle GetModel(this MentorLake.Gtk.GtkEntryCompletionHandle completion)
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_get_model(completion);
	}

	public static bool GetPopupCompletion(this MentorLake.Gtk.GtkEntryCompletionHandle completion)
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_get_popup_completion(completion);
	}

	public static bool GetPopupSetWidth(this MentorLake.Gtk.GtkEntryCompletionHandle completion)
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_get_popup_set_width(completion);
	}

	public static bool GetPopupSingleMatch(this MentorLake.Gtk.GtkEntryCompletionHandle completion)
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_get_popup_single_match(completion);
	}

	public static int GetTextColumn(this MentorLake.Gtk.GtkEntryCompletionHandle completion)
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_get_text_column(completion);
	}

	public static T InsertActionMarkup<T>(this T completion, int index_, string markup) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_insert_action_markup(completion, index_, markup);
		return completion;
	}

	public static T InsertActionText<T>(this T completion, int index_, string text) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_insert_action_text(completion, index_, text);
		return completion;
	}

	public static T InsertPrefix<T>(this T completion) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_insert_prefix(completion);
		return completion;
	}

	public static T SetInlineCompletion<T>(this T completion, bool inline_completion) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_set_inline_completion(completion, inline_completion);
		return completion;
	}

	public static T SetInlineSelection<T>(this T completion, bool inline_selection) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_set_inline_selection(completion, inline_selection);
		return completion;
	}

	public static T SetMatchFunc<T>(this T completion, MentorLake.Gtk.GtkEntryCompletionMatchFunc func, IntPtr func_data, MentorLake.GLib.GDestroyNotify func_notify) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_set_match_func(completion, func, func_data, func_notify);
		return completion;
	}

	public static T SetMinimumKeyLength<T>(this T completion, int length) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_set_minimum_key_length(completion, length);
		return completion;
	}

	public static T SetModel<T>(this T completion, MentorLake.Gtk.GtkTreeModelHandle model) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_set_model(completion, model);
		return completion;
	}

	public static T SetPopupCompletion<T>(this T completion, bool popup_completion) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_set_popup_completion(completion, popup_completion);
		return completion;
	}

	public static T SetPopupSetWidth<T>(this T completion, bool popup_set_width) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_set_popup_set_width(completion, popup_set_width);
		return completion;
	}

	public static T SetPopupSingleMatch<T>(this T completion, bool popup_single_match) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_set_popup_single_match(completion, popup_single_match);
		return completion;
	}

	public static T SetTextColumn<T>(this T completion, int column) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_set_text_column(completion, column);
		return completion;
	}

}

internal class GtkEntryCompletionHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))]
	internal static extern MentorLake.Gtk.GtkEntryCompletionHandle gtk_entry_completion_new();

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))]
	internal static extern MentorLake.Gtk.GtkEntryCompletionHandle gtk_entry_completion_new_with_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkCellAreaHandle>))] MentorLake.Gtk.GtkCellAreaHandle area);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_completion_complete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_entry_completion_compute_prefix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion, string key);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_completion_delete_action([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion, int index_);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_entry_completion_get_completion_prefix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_entry_completion_get_entry([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_entry_completion_get_inline_completion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_entry_completion_get_inline_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_entry_completion_get_minimum_key_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))]
	internal static extern MentorLake.Gtk.GtkTreeModelHandle gtk_entry_completion_get_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_entry_completion_get_popup_completion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_entry_completion_get_popup_set_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_entry_completion_get_popup_single_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_entry_completion_get_text_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_completion_insert_action_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion, int index_, string markup);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_completion_insert_action_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion, int index_, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_completion_insert_prefix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_completion_set_inline_completion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion, bool inline_completion);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_completion_set_inline_selection([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion, bool inline_selection);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_completion_set_match_func([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion, MentorLake.Gtk.GtkEntryCompletionMatchFunc func, IntPtr func_data, MentorLake.GLib.GDestroyNotify func_notify);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_completion_set_minimum_key_length([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion, int length);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_completion_set_model([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_completion_set_popup_completion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion, bool popup_completion);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_completion_set_popup_set_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion, bool popup_set_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_completion_set_popup_single_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion, bool popup_single_match);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_entry_completion_set_text_column([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle completion, int column);

}
