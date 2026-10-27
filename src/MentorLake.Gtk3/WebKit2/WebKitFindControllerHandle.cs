namespace MentorLake.WebKit2;

/// <summary>
/// <para>
/// Controls text search in a #WebKitWebView.
/// </para>
/// <para>
/// A #WebKitFindController is used to search text in a #WebKitWebView. You
/// can get a #WebKitWebView&amp;lt;!-- --&amp;gt;&apos;s #WebKitFindController with
/// webkit_web_view_get_find_controller(), and later use it to search
/// for text using webkit_find_controller_search(), or get the
/// number of matches using webkit_find_controller_count_matches(). The
/// operations are asynchronous and trigger signals when ready, such as
/// #WebKitFindController::found-text,
/// #WebKitFindController::failed-to-find-text or
/// #WebKitFindController::counted-matches&amp;lt;!-- --&amp;gt;.
/// </para>
/// </summary>

public class WebKitFindControllerHandle : GObjectHandle
{
}
public static class WebKitFindControllerHandleSignalExtensions
{
/// <summary>
/// <para>
/// This signal is emitted when the #WebKitFindController has
/// counted the number of matches for a given text after a call
/// to webkit_find_controller_count_matches().
/// </para>
/// </summary>

	public static IObservable<WebKitFindControllerHandleSignalStructs.CountedMatchesSignal> Signal_CountedMatches(this WebKitFindControllerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitFindControllerHandleSignalStructs.CountedMatchesSignal> obs) =>
		{
			WebKitFindControllerHandleSignalDelegates.counted_matches handler = ( MentorLake.WebKit2.WebKitFindControllerHandle self,  uint match_count,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitFindControllerHandleSignalStructs.CountedMatchesSignal()
				{
					Self = self, MatchCount = match_count, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "counted-matches", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when a search operation does not find
/// any result for the given text. It will be issued if the text
/// is not found asynchronously after a call to
/// webkit_find_controller_search(), webkit_find_controller_search_next()
/// or webkit_find_controller_search_previous().
/// </para>
/// </summary>

	public static IObservable<WebKitFindControllerHandleSignalStructs.FailedToFindTextSignal> Signal_FailedToFindText(this WebKitFindControllerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitFindControllerHandleSignalStructs.FailedToFindTextSignal> obs) =>
		{
			WebKitFindControllerHandleSignalDelegates.failed_to_find_text handler = ( MentorLake.WebKit2.WebKitFindControllerHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitFindControllerHandleSignalStructs.FailedToFindTextSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "failed-to-find-text", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// This signal is emitted when a given text is found in the web
/// page text. It will be issued if the text is found
/// asynchronously after a call to webkit_find_controller_search(),
/// webkit_find_controller_search_next() or
/// webkit_find_controller_search_previous().
/// </para>
/// </summary>

	public static IObservable<WebKitFindControllerHandleSignalStructs.FoundTextSignal> Signal_FoundText(this WebKitFindControllerHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<WebKitFindControllerHandleSignalStructs.FoundTextSignal> obs) =>
		{
			WebKitFindControllerHandleSignalDelegates.found_text handler = ( MentorLake.WebKit2.WebKitFindControllerHandle self,  uint match_count,  IntPtr user_data) =>
			{
				

				var signalStruct = new WebKitFindControllerHandleSignalStructs.FoundTextSignal()
				{
					Self = self, MatchCount = match_count, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "found-text", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class WebKitFindControllerHandleSignalStructs
{

public class CountedMatchesSignal
{

	public MentorLake.WebKit2.WebKitFindControllerHandle Self;
/// <summary>
/// <para>
/// the number of matches of the search text
/// </para>
/// </summary>

	public uint MatchCount;

	public IntPtr UserData;
}

public class FailedToFindTextSignal
{

	public MentorLake.WebKit2.WebKitFindControllerHandle Self;

	public IntPtr UserData;
}

public class FoundTextSignal
{

	public MentorLake.WebKit2.WebKitFindControllerHandle Self;
/// <summary>
/// <para>
/// the number of matches found of the search text
/// </para>
/// </summary>

	public uint MatchCount;

	public IntPtr UserData;
}
}

public static class WebKitFindControllerHandleSignalDelegates
{

/// <summary>
/// <para>
/// This signal is emitted when the #WebKitFindController has
/// counted the number of matches for a given text after a call
/// to webkit_find_controller_count_matches().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="match_count">
/// the number of matches of the search text
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void counted_matches([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFindControllerHandle>))] MentorLake.WebKit2.WebKitFindControllerHandle self, uint match_count, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when a search operation does not find
/// any result for the given text. It will be issued if the text
/// is not found asynchronously after a call to
/// webkit_find_controller_search(), webkit_find_controller_search_next()
/// or webkit_find_controller_search_previous().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void failed_to_find_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFindControllerHandle>))] MentorLake.WebKit2.WebKitFindControllerHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// This signal is emitted when a given text is found in the web
/// page text. It will be issued if the text is found
/// asynchronously after a call to webkit_find_controller_search(),
/// webkit_find_controller_search_next() or
/// webkit_find_controller_search_previous().
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="match_count">
/// the number of matches found of the search text
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void found_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFindControllerHandle>))] MentorLake.WebKit2.WebKitFindControllerHandle self, uint match_count, IntPtr user_data);

}


public static class WebKitFindControllerHandleExtensions
{
/// <summary>
/// <para>
/// Counts the number of matches for @search_text.
/// </para>
/// <para>
/// Counts the number of matches for @search_text found in the
/// #WebKitWebView with the provided @find_options. The number of
/// matches will be provided by the
/// #WebKitFindController::counted-matches signal.
/// </para>
/// </summary>

/// <param name="find_controller">
/// the #WebKitFindController
/// </param>
/// <param name="search_text">
/// the text to look for
/// </param>
/// <param name="find_options">
/// a bitmask with the #WebKitFindOptions used in the search
/// </param>
/// <param name="max_match_count">
/// the maximum number of matches allowed in the search
/// </param>

	public static T CountMatches<T>(this T find_controller, string search_text, uint find_options, uint max_match_count) where T : WebKitFindControllerHandle
	{
		if (find_controller.IsInvalid) throw new Exception("Invalid handle (WebKitFindControllerHandle)");
		WebKitFindControllerHandleExterns.webkit_find_controller_count_matches(find_controller, search_text, find_options, max_match_count);
		return find_controller;
	}

/// <summary>
/// <para>
/// Gets the maximum number of matches to report.
/// </para>
/// <para>
/// Gets the maximum number of matches to report during a text
/// lookup. This number is passed as the last argument of
/// webkit_find_controller_search() or
/// webkit_find_controller_count_matches().
/// </para>
/// </summary>

/// <param name="find_controller">
/// the #WebKitFindController
/// </param>
/// <return>
/// the maximum number of matches to report.
/// </return>

	public static uint GetMaxMatchCount(this MentorLake.WebKit2.WebKitFindControllerHandle find_controller)
	{
		if (find_controller.IsInvalid) throw new Exception("Invalid handle (WebKitFindControllerHandle)");
		return WebKitFindControllerHandleExterns.webkit_find_controller_get_max_match_count(find_controller);
	}

/// <summary>
/// <para>
/// Gets the #WebKitFindOptions for the current search.
/// </para>
/// <para>
/// Gets a bitmask containing the #WebKitFindOptions associated with
/// the current search.
/// </para>
/// </summary>

/// <param name="find_controller">
/// the #WebKitFindController
/// </param>
/// <return>
/// a bitmask containing the #WebKitFindOptions associated
/// with the current search.
/// </return>

	public static uint GetOptions(this MentorLake.WebKit2.WebKitFindControllerHandle find_controller)
	{
		if (find_controller.IsInvalid) throw new Exception("Invalid handle (WebKitFindControllerHandle)");
		return WebKitFindControllerHandleExterns.webkit_find_controller_get_options(find_controller);
	}

/// <summary>
/// <para>
/// Gets the text that @find_controller is searching for.
/// </para>
/// <para>
/// Gets the text that @find_controller is currently searching
/// for. This text is passed to either
/// webkit_find_controller_search() or
/// webkit_find_controller_count_matches().
/// </para>
/// </summary>

/// <param name="find_controller">
/// the #WebKitFindController
/// </param>
/// <return>
/// the text to look for in the #WebKitWebView.
/// </return>

	public static string GetSearchText(this MentorLake.WebKit2.WebKitFindControllerHandle find_controller)
	{
		if (find_controller.IsInvalid) throw new Exception("Invalid handle (WebKitFindControllerHandle)");
		return WebKitFindControllerHandleExterns.webkit_find_controller_get_search_text(find_controller);
	}

/// <summary>
/// <para>
/// Gets the #WebKitWebView this find controller is associated to.
/// </para>
/// <para>
/// Do
/// not dereference the returned instance as it belongs to the
/// #WebKitFindController.
/// </para>
/// </summary>

/// <param name="find_controller">
/// the #WebKitFindController
/// </param>
/// <return>
/// the #WebKitWebView.
/// </return>

	public static MentorLake.WebKit2.WebKitWebViewHandle GetWebView(this MentorLake.WebKit2.WebKitFindControllerHandle find_controller)
	{
		if (find_controller.IsInvalid) throw new Exception("Invalid handle (WebKitFindControllerHandle)");
		return WebKitFindControllerHandleExterns.webkit_find_controller_get_web_view(find_controller);
	}

/// <summary>
/// <para>
/// Looks for @search_text associated with @find_controller.
/// </para>
/// <para>
/// Looks for @search_text in the #WebKitWebView associated with
/// @find_controller since the beginning of the document highlighting
/// up to @max_match_count matches. The outcome of the search will be
/// asynchronously provided by the #WebKitFindController::found-text
/// and #WebKitFindController::failed-to-find-text signals.
/// </para>
/// <para>
/// To look for the next or previous occurrences of the same text
/// with the same find options use webkit_find_controller_search_next()
/// and/or webkit_find_controller_search_previous(). The
/// #WebKitFindController will use the same text and options for the
/// following searches unless they are modified by another call to this
/// method.
/// </para>
/// <para>
/// Note that if the number of matches is higher than @max_match_count
/// then #WebKitFindController::found-text will report %G_MAXUINT matches
/// instead of the actual number.
/// </para>
/// <para>
/// Callers should call webkit_find_controller_search_finish() to
/// finish the current search operation.
/// </para>
/// </summary>

/// <param name="find_controller">
/// the #WebKitFindController
/// </param>
/// <param name="search_text">
/// the text to look for
/// </param>
/// <param name="find_options">
/// a bitmask with the #WebKitFindOptions used in the search
/// </param>
/// <param name="max_match_count">
/// the maximum number of matches allowed in the search
/// </param>

	public static T Search<T>(this T find_controller, string search_text, uint find_options, uint max_match_count) where T : WebKitFindControllerHandle
	{
		if (find_controller.IsInvalid) throw new Exception("Invalid handle (WebKitFindControllerHandle)");
		WebKitFindControllerHandleExterns.webkit_find_controller_search(find_controller, search_text, find_options, max_match_count);
		return find_controller;
	}

/// <summary>
/// <para>
/// Finishes a find operation.
/// </para>
/// <para>
/// Finishes a find operation started by
/// webkit_find_controller_search(). It will basically unhighlight
/// every text match found.
/// </para>
/// <para>
/// This method will be typically called when the search UI is
/// closed/hidden by the client application.
/// </para>
/// </summary>

/// <param name="find_controller">
/// a #WebKitFindController
/// </param>

	public static T SearchFinish<T>(this T find_controller) where T : WebKitFindControllerHandle
	{
		if (find_controller.IsInvalid) throw new Exception("Invalid handle (WebKitFindControllerHandle)");
		WebKitFindControllerHandleExterns.webkit_find_controller_search_finish(find_controller);
		return find_controller;
	}

/// <summary>
/// <para>
/// Looks for the next occurrence of the search text.
/// </para>
/// <para>
/// Calling this method before webkit_find_controller_search() or
/// webkit_find_controller_count_matches() is a programming error.
/// </para>
/// </summary>

/// <param name="find_controller">
/// the #WebKitFindController
/// </param>

	public static T SearchNext<T>(this T find_controller) where T : WebKitFindControllerHandle
	{
		if (find_controller.IsInvalid) throw new Exception("Invalid handle (WebKitFindControllerHandle)");
		WebKitFindControllerHandleExterns.webkit_find_controller_search_next(find_controller);
		return find_controller;
	}

/// <summary>
/// <para>
/// Looks for the previous occurrence of the search text.
/// </para>
/// <para>
/// Calling this method before webkit_find_controller_search() or
/// webkit_find_controller_count_matches() is a programming error.
/// </para>
/// </summary>

/// <param name="find_controller">
/// the #WebKitFindController
/// </param>

	public static T SearchPrevious<T>(this T find_controller) where T : WebKitFindControllerHandle
	{
		if (find_controller.IsInvalid) throw new Exception("Invalid handle (WebKitFindControllerHandle)");
		WebKitFindControllerHandleExterns.webkit_find_controller_search_previous(find_controller);
		return find_controller;
	}

}

internal class WebKitFindControllerHandleExterns
{
	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_find_controller_count_matches([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFindControllerHandle>))] MentorLake.WebKit2.WebKitFindControllerHandle find_controller, string search_text, uint find_options, uint max_match_count);

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_find_controller_get_max_match_count([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFindControllerHandle>))] MentorLake.WebKit2.WebKitFindControllerHandle find_controller);

	[DllImport(WebKit2Library.Name)]
	internal static extern uint webkit_find_controller_get_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFindControllerHandle>))] MentorLake.WebKit2.WebKitFindControllerHandle find_controller);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string webkit_find_controller_get_search_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFindControllerHandle>))] MentorLake.WebKit2.WebKitFindControllerHandle find_controller);

	[DllImport(WebKit2Library.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitWebViewHandle>))]
	internal static extern MentorLake.WebKit2.WebKitWebViewHandle webkit_find_controller_get_web_view([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFindControllerHandle>))] MentorLake.WebKit2.WebKitFindControllerHandle find_controller);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_find_controller_search([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFindControllerHandle>))] MentorLake.WebKit2.WebKitFindControllerHandle find_controller, string search_text, uint find_options, uint max_match_count);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_find_controller_search_finish([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFindControllerHandle>))] MentorLake.WebKit2.WebKitFindControllerHandle find_controller);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_find_controller_search_next([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFindControllerHandle>))] MentorLake.WebKit2.WebKitFindControllerHandle find_controller);

	[DllImport(WebKit2Library.Name)]
	internal static extern void webkit_find_controller_search_previous([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.WebKit2.WebKitFindControllerHandle>))] MentorLake.WebKit2.WebKitFindControllerHandle find_controller);

}
