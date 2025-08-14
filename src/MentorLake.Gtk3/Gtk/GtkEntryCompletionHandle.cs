namespace MentorLake.Gtk;

/// <summary>
/// <para>
/// #GtkEntryCompletion is an auxiliary object to be used in conjunction with
/// #GtkEntry to provide the completion functionality. It implements the
/// #GtkCellLayout interface, to allow the user to add extra cells to the
/// #GtkTreeView with completion matches.
/// </para>
/// <para>
/// “Completion functionality” means that when the user modifies the text
/// in the entry, #GtkEntryCompletion checks which rows in the model match
/// the current content of the entry, and displays a list of matches.
/// By default, the matching is done by comparing the entry text
/// case-insensitively against the text column of the model (see
/// gtk_entry_completion_set_text_column()), but this can be overridden
/// with a custom match function (see gtk_entry_completion_set_match_func()).
/// </para>
/// <para>
/// When the user selects a completion, the content of the entry is
/// updated. By default, the content of the entry is replaced by the
/// text column of the model, but this can be overridden by connecting
/// to the #GtkEntryCompletion::match-selected signal and updating the
/// entry in the signal handler. Note that you should return %TRUE from
/// the signal handler to suppress the default behaviour.
/// </para>
/// <para>
/// To add completion functionality to an entry, use gtk_entry_set_completion().
/// </para>
/// <para>
/// In addition to regular completion matches, which will be inserted into the
/// entry when they are selected, #GtkEntryCompletion also allows to display
/// “actions” in the popup window. Their appearance is similar to menuitems,
/// to differentiate them clearly from completion strings. When an action is
/// selected, the #GtkEntryCompletion::action-activated signal is emitted.
/// </para>
/// <para>
/// GtkEntryCompletion uses a #GtkTreeModelFilter model to represent the
/// subset of the entire model that is currently matching. While the
/// GtkEntryCompletion signals #GtkEntryCompletion::match-selected and
/// #GtkEntryCompletion::cursor-on-match take the original model and an
/// iter pointing to that model as arguments, other callbacks and signals
/// (such as #GtkCellLayoutDataFuncs or #GtkCellArea::apply-attributes)
/// will generally take the filter model as argument. As long as you are
/// only calling gtk_tree_model_get(), this will make no difference to
/// you. If for some reason, you need the original model, use
/// gtk_tree_model_filter_get_model(). Don’t forget to use
/// gtk_tree_model_filter_convert_iter_to_child_iter() to obtain a
/// matching iter.
/// </para>
/// </summary>

public class GtkEntryCompletionHandle : GObjectHandle, GtkBuildableHandle, GtkCellLayoutHandle
{
/// <summary>
/// <para>
/// Creates a new #GtkEntryCompletion object.
/// </para>
/// </summary>

/// <return>
/// A newly created #GtkEntryCompletion object
/// </return>

	public static MentorLake.Gtk.GtkEntryCompletionHandle New()
	{
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_new();
	}

/// <summary>
/// <para>
/// Creates a new #GtkEntryCompletion object using the
/// specified @area to layout cells in the underlying
/// #GtkTreeViewColumn for the drop-down menu.
/// </para>
/// </summary>

/// <param name="area">
/// the #GtkCellArea used to layout cells
/// </param>
/// <return>
/// A newly created #GtkEntryCompletion object
/// </return>

	public static MentorLake.Gtk.GtkEntryCompletionHandle NewWithArea(MentorLake.Gtk.GtkCellAreaHandle area)
	{
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_new_with_area(area);
	}

}
public static class GtkEntryCompletionHandleSignalExtensions
{
/// <summary>
/// <para>
/// Gets emitted when an action is activated.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Gets emitted when a match from the cursor is on a match
/// of the list. The default behaviour is to replace the contents
/// of the entry with the contents of the text column in the row
/// pointed to by @iter.
/// </para>
/// <para>
/// Note that @model is the model that was passed to
/// gtk_entry_completion_set_model().
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Gets emitted when the inline autocompletion is triggered.
/// The default behaviour is to make the entry display the
/// whole prefix and select the newly inserted part.
/// </para>
/// <para>
/// Applications may connect to this signal in order to insert only a
/// smaller part of the @prefix into the entry - e.g. the entry used in
/// the #GtkFileChooser inserts only the part of the prefix up to the
/// next '/'.
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Gets emitted when a match from the list is selected.
/// The default behaviour is to replace the contents of the
/// entry with the contents of the text column in the row
/// pointed to by @iter.
/// </para>
/// <para>
/// Note that @model is the model that was passed to
/// gtk_entry_completion_set_model().
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// Gets emitted when the filter model has zero
/// number of rows in completion_complete method.
/// (In other words when GtkEntryCompletion is out of
///  suggestions)
/// </para>
/// </summary>

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
/// <summary>
/// <para>
/// the index of the activated action
/// </para>
/// </summary>

	public int Index;

	public IntPtr UserData;
}

public class CursorOnMatchSignal
{

	public MentorLake.Gtk.GtkEntryCompletionHandle Self;
/// <summary>
/// <para>
/// the #GtkTreeModel containing the matches
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreeModelHandle Model;
/// <summary>
/// <para>
/// a #GtkTreeIter positioned at the selected match
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreeIterHandle Iter;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if the signal has been handled
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class InsertPrefixSignal
{

	public MentorLake.Gtk.GtkEntryCompletionHandle Self;
/// <summary>
/// <para>
/// the common prefix of all possible completions
/// </para>
/// </summary>

	public string Prefix;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if the signal has been handled
/// </para>
/// </summary>

	public bool ReturnValue;
}

public class MatchSelectedSignal
{

	public MentorLake.Gtk.GtkEntryCompletionHandle Self;
/// <summary>
/// <para>
/// the #GtkTreeModel containing the matches
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreeModelHandle Model;
/// <summary>
/// <para>
/// a #GtkTreeIter positioned at the selected match
/// </para>
/// </summary>

	public MentorLake.Gtk.GtkTreeIterHandle Iter;

	public IntPtr UserData;
/// <summary>
/// <para>
/// %TRUE if the signal has been handled
/// </para>
/// </summary>

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

/// <summary>
/// <para>
/// Gets emitted when an action is activated.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="index">
/// the index of the activated action
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void action_activated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle self, int index, IntPtr user_data);


/// <summary>
/// <para>
/// Gets emitted when a match from the cursor is on a match
/// of the list. The default behaviour is to replace the contents
/// of the entry with the contents of the text column in the row
/// pointed to by @iter.
/// </para>
/// <para>
/// Note that @model is the model that was passed to
/// gtk_entry_completion_set_model().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="model">
/// the #GtkTreeModel containing the matches
/// </param>
/// <param name="iter">
/// a #GtkTreeIter positioned at the selected match
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if the signal has been handled
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool cursor_on_match([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr user_data);


/// <summary>
/// <para>
/// Gets emitted when the inline autocompletion is triggered.
/// The default behaviour is to make the entry display the
/// whole prefix and select the newly inserted part.
/// </para>
/// <para>
/// Applications may connect to this signal in order to insert only a
/// smaller part of the @prefix into the entry - e.g. the entry used in
/// the #GtkFileChooser inserts only the part of the prefix up to the
/// next '/'.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="prefix">
/// the common prefix of all possible completions
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if the signal has been handled
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool insert_prefix([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle self, string prefix, IntPtr user_data);


/// <summary>
/// <para>
/// Gets emitted when a match from the list is selected.
/// The default behaviour is to replace the contents of the
/// entry with the contents of the text column in the row
/// pointed to by @iter.
/// </para>
/// <para>
/// Note that @model is the model that was passed to
/// gtk_entry_completion_set_model().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="model">
/// the #GtkTreeModel containing the matches
/// </param>
/// <param name="iter">
/// a #GtkTreeIter positioned at the selected match
/// </param>
/// <param name="user_data">
/// </param>
/// <return>
/// %TRUE if the signal has been handled
/// </return>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool match_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeModelHandleImpl>))] MentorLake.Gtk.GtkTreeModelHandle model, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTreeIterHandle>))] MentorLake.Gtk.GtkTreeIterHandle iter, IntPtr user_data);


/// <summary>
/// <para>
/// Gets emitted when the filter model has zero
/// number of rows in completion_complete method.
/// (In other words when GtkEntryCompletion is out of
///  suggestions)
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void no_matches([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkEntryCompletionHandle>))] MentorLake.Gtk.GtkEntryCompletionHandle self, IntPtr user_data);

}


public static class GtkEntryCompletionHandleExtensions
{
/// <summary>
/// <para>
/// Requests a completion operation, or in other words a refiltering of the
/// current list with completions, using the current key. The completion list
/// view will be updated accordingly.
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>

	public static T Complete<T>(this T completion) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_complete(completion);
		return completion;
	}

/// <summary>
/// <para>
/// Computes the common prefix that is shared by all rows in @completion
/// that start with @key. If no row matches @key, %NULL will be returned.
/// Note that a text column must have been set for this function to work,
/// see gtk_entry_completion_set_text_column() for details.
/// </para>
/// </summary>

/// <param name="completion">
/// the entry completion
/// </param>
/// <param name="key">
/// The text to complete for
/// </param>
/// <return>
/// The common prefix all rows starting with
///   @key or %NULL if no row matches @key.
/// </return>

	public static string ComputePrefix(this MentorLake.Gtk.GtkEntryCompletionHandle completion, string key)
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_compute_prefix(completion, key);
	}

/// <summary>
/// <para>
/// Deletes the action at @index_ from @completion’s action list.
/// </para>
/// <para>
/// Note that @index_ is a relative position and the position of an
/// action may have changed since it was inserted.
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>
/// <param name="index_">
/// the index of the item to delete
/// </param>

	public static T DeleteAction<T>(this T completion, int index_) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_delete_action(completion, index_);
		return completion;
	}

/// <summary>
/// <para>
/// Get the original text entered by the user that triggered
/// the completion or %NULL if there’s no completion ongoing.
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>
/// <return>
/// the prefix for the current completion
/// </return>

	public static string GetCompletionPrefix(this MentorLake.Gtk.GtkEntryCompletionHandle completion)
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_get_completion_prefix(completion);
	}

/// <summary>
/// <para>
/// Gets the entry @completion has been attached to.
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>
/// <return>
/// The entry @completion has been attached to
/// </return>

	public static MentorLake.Gtk.GtkWidgetHandle GetEntry(this MentorLake.Gtk.GtkEntryCompletionHandle completion)
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_get_entry(completion);
	}

/// <summary>
/// <para>
/// Returns whether the common prefix of the possible completions should
/// be automatically inserted in the entry.
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>
/// <return>
/// %TRUE if inline completion is turned on
/// </return>

	public static bool GetInlineCompletion(this MentorLake.Gtk.GtkEntryCompletionHandle completion)
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_get_inline_completion(completion);
	}

/// <summary>
/// <para>
/// Returns %TRUE if inline-selection mode is turned on.
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>
/// <return>
/// %TRUE if inline-selection mode is on
/// </return>

	public static bool GetInlineSelection(this MentorLake.Gtk.GtkEntryCompletionHandle completion)
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_get_inline_selection(completion);
	}

/// <summary>
/// <para>
/// Returns the minimum key length as set for @completion.
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>
/// <return>
/// The currently used minimum key length
/// </return>

	public static int GetMinimumKeyLength(this MentorLake.Gtk.GtkEntryCompletionHandle completion)
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_get_minimum_key_length(completion);
	}

/// <summary>
/// <para>
/// Returns the model the #GtkEntryCompletion is using as data source.
/// Returns %NULL if the model is unset.
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>
/// <return>
/// A #GtkTreeModel, or %NULL if none
///     is currently being used
/// </return>

	public static MentorLake.Gtk.GtkTreeModelHandle GetModel(this MentorLake.Gtk.GtkEntryCompletionHandle completion)
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_get_model(completion);
	}

/// <summary>
/// <para>
/// Returns whether the completions should be presented in a popup window.
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>
/// <return>
/// %TRUE if popup completion is turned on
/// </return>

	public static bool GetPopupCompletion(this MentorLake.Gtk.GtkEntryCompletionHandle completion)
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_get_popup_completion(completion);
	}

/// <summary>
/// <para>
/// Returns whether the  completion popup window will be resized to the
/// width of the entry.
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>
/// <return>
/// %TRUE if the popup window will be resized to the width of
///   the entry
/// </return>

	public static bool GetPopupSetWidth(this MentorLake.Gtk.GtkEntryCompletionHandle completion)
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_get_popup_set_width(completion);
	}

/// <summary>
/// <para>
/// Returns whether the completion popup window will appear even if there is
/// only a single match.
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>
/// <return>
/// %TRUE if the popup window will appear regardless of the
///    number of matches
/// </return>

	public static bool GetPopupSingleMatch(this MentorLake.Gtk.GtkEntryCompletionHandle completion)
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_get_popup_single_match(completion);
	}

/// <summary>
/// <para>
/// Returns the column in the model of @completion to get strings from.
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>
/// <return>
/// the column containing the strings
/// </return>

	public static int GetTextColumn(this MentorLake.Gtk.GtkEntryCompletionHandle completion)
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		return GtkEntryCompletionHandleExterns.gtk_entry_completion_get_text_column(completion);
	}

/// <summary>
/// <para>
/// Inserts an action in @completion’s action item list at position @index_
/// with markup @markup.
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>
/// <param name="index_">
/// the index of the item to insert
/// </param>
/// <param name="markup">
/// markup of the item to insert
/// </param>

	public static T InsertActionMarkup<T>(this T completion, int index_, string markup) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_insert_action_markup(completion, index_, markup);
		return completion;
	}

/// <summary>
/// <para>
/// Inserts an action in @completion’s action item list at position @index_
/// with text @text. If you want the action item to have markup, use
/// gtk_entry_completion_insert_action_markup().
/// </para>
/// <para>
/// Note that @index_ is a relative position in the list of actions and
/// the position of an action can change when deleting a different action.
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>
/// <param name="index_">
/// the index of the item to insert
/// </param>
/// <param name="text">
/// text of the item to insert
/// </param>

	public static T InsertActionText<T>(this T completion, int index_, string text) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_insert_action_text(completion, index_, text);
		return completion;
	}

/// <summary>
/// <para>
/// Requests a prefix insertion.
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>

	public static T InsertPrefix<T>(this T completion) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_insert_prefix(completion);
		return completion;
	}

/// <summary>
/// <para>
/// Sets whether the common prefix of the possible completions should
/// be automatically inserted in the entry.
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>
/// <param name="inline_completion">
/// %TRUE to do inline completion
/// </param>

	public static T SetInlineCompletion<T>(this T completion, bool inline_completion) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_set_inline_completion(completion, inline_completion);
		return completion;
	}

/// <summary>
/// <para>
/// Sets whether it is possible to cycle through the possible completions
/// inside the entry.
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>
/// <param name="inline_selection">
/// %TRUE to do inline selection
/// </param>

	public static T SetInlineSelection<T>(this T completion, bool inline_selection) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_set_inline_selection(completion, inline_selection);
		return completion;
	}

/// <summary>
/// <para>
/// Sets the match function for @completion to be @func. The match function
/// is used to determine if a row should or should not be in the completion
/// list.
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>
/// <param name="func">
/// the #GtkEntryCompletionMatchFunc to use
/// </param>
/// <param name="func_data">
/// user data for @func
/// </param>
/// <param name="func_notify">
/// destroy notify for @func_data.
/// </param>

	public static T SetMatchFunc<T>(this T completion, MentorLake.Gtk.GtkEntryCompletionMatchFunc func, IntPtr func_data, MentorLake.GLib.GDestroyNotify func_notify) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_set_match_func(completion, func, func_data, func_notify);
		return completion;
	}

/// <summary>
/// <para>
/// Requires the length of the search key for @completion to be at least
/// @length. This is useful for long lists, where completing using a small
/// key takes a lot of time and will come up with meaningless results anyway
/// (ie, a too large dataset).
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>
/// <param name="length">
/// the minimum length of the key in order to start completing
/// </param>

	public static T SetMinimumKeyLength<T>(this T completion, int length) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_set_minimum_key_length(completion, length);
		return completion;
	}

/// <summary>
/// <para>
/// Sets the model for a #GtkEntryCompletion. If @completion already has
/// a model set, it will remove it before setting the new model.
/// If model is %NULL, then it will unset the model.
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>
/// <param name="model">
/// the #GtkTreeModel
/// </param>

	public static T SetModel<T>(this T completion, MentorLake.Gtk.GtkTreeModelHandle model) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_set_model(completion, model);
		return completion;
	}

/// <summary>
/// <para>
/// Sets whether the completions should be presented in a popup window.
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>
/// <param name="popup_completion">
/// %TRUE to do popup completion
/// </param>

	public static T SetPopupCompletion<T>(this T completion, bool popup_completion) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_set_popup_completion(completion, popup_completion);
		return completion;
	}

/// <summary>
/// <para>
/// Sets whether the completion popup window will be resized to be the same
/// width as the entry.
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>
/// <param name="popup_set_width">
/// %TRUE to make the width of the popup the same as the entry
/// </param>

	public static T SetPopupSetWidth<T>(this T completion, bool popup_set_width) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_set_popup_set_width(completion, popup_set_width);
		return completion;
	}

/// <summary>
/// <para>
/// Sets whether the completion popup window will appear even if there is
/// only a single match. You may want to set this to %FALSE if you
/// are using [inline completion][GtkEntryCompletion--inline-completion].
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>
/// <param name="popup_single_match">
/// %TRUE if the popup should appear even for a single
///     match
/// </param>

	public static T SetPopupSingleMatch<T>(this T completion, bool popup_single_match) where T : GtkEntryCompletionHandle
	{
		if (completion.IsInvalid) throw new Exception("Invalid handle (GtkEntryCompletionHandle)");
		GtkEntryCompletionHandleExterns.gtk_entry_completion_set_popup_single_match(completion, popup_single_match);
		return completion;
	}

/// <summary>
/// <para>
/// Convenience function for setting up the most used case of this code: a
/// completion list with just strings. This function will set up @completion
/// to have a list displaying all (and just) strings in the completion list,
/// and to get those strings from @column in the model of @completion.
/// </para>
/// <para>
/// This functions creates and adds a #GtkCellRendererText for the selected
/// column. If you need to set the text column, but don't want the cell
/// renderer, use g_object_set() to set the #GtkEntryCompletion:text-column
/// property directly.
/// </para>
/// </summary>

/// <param name="completion">
/// a #GtkEntryCompletion
/// </param>
/// <param name="column">
/// the column in the model of @completion to get strings from
/// </param>

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
