namespace MentorLake.Atk;

/// <summary>
/// <para>
/// An AtkObject which purports to implement all ATK interfaces.
/// </para>
/// <para>
/// An AtkNoOpObject is an AtkObject which purports to implement all
/// ATK interfaces. It is the type of AtkObject which is created if an
/// accessible object is requested for an object type for which no
/// factory type is specified.
/// </para>
/// </summary>

public class AtkNoOpObjectHandle : AtkObjectHandle, AtkActionHandle, AtkComponentHandle, AtkDocumentHandle, AtkEditableTextHandle, AtkHypertextHandle, AtkImageHandle, AtkSelectionHandle, AtkTableHandle, AtkTableCellHandle, AtkTextHandle, AtkValueHandle, AtkWindowHandle
{
/// <summary>
/// <para>
/// Provides a default (non-functioning stub) #AtkObject.
/// Application maintainers should not use this method.
/// </para>
/// </summary>

/// <param name="obj">
/// a #GObject
/// </param>
/// <return>
/// a default (non-functioning stub) #AtkObject
/// </return>

	public static MentorLake.Atk.AtkNoOpObjectHandle New(MentorLake.GObject.GObjectHandle obj)
	{
		return AtkNoOpObjectHandleExterns.atk_no_op_object_new(obj);
	}

}
public static class AtkNoOpObjectHandleSignalExtensions
{
/// <summary>
/// <para>
/// The &apos;bounds-changed&quot; signal is emitted when the position or
/// size of the component changes.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.BoundsChangedSignal> Signal_BoundsChanged(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.BoundsChangedSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.bounds_changed handler = ( MentorLake.Atk.AtkComponentHandle self,  MentorLake.Atk.AtkRectangleHandle arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.BoundsChangedSignal()
				{
					Self = self, Arg1 = arg1, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "bounds-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The &quot;document-attribute-changed&quot; signal should be emitted when there is a
/// change to one of the document attributes returned by
/// atk_document_get_attributes.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.DocumentAttributeChangedSignal> Signal_DocumentAttributeChanged(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.DocumentAttributeChangedSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.document_attribute_changed handler = ( MentorLake.Atk.AtkDocumentHandle self,  string arg1,  string arg2,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.DocumentAttributeChangedSignal()
				{
					Self = self, Arg1 = arg1, Arg2 = arg2, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "document-attribute-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The &apos;load-complete&apos; signal is emitted when a pending load of
/// a static document has completed.  This signal is to be
/// expected by ATK clients if and when AtkDocument implementors
/// expose ATK_STATE_BUSY.  If the state of an AtkObject which
/// implements AtkDocument does not include ATK_STATE_BUSY, it
/// should be safe for clients to assume that the AtkDocument&apos;s
/// static contents are fully loaded into the container.
/// (Dynamic document contents should be exposed via other
/// signals.)
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.LoadCompleteSignal> Signal_LoadComplete(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.LoadCompleteSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.load_complete handler = ( MentorLake.Atk.AtkDocumentHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.LoadCompleteSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "load-complete", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The &apos;load-stopped&apos; signal is emitted when a pending load of
/// document contents is cancelled, paused, or otherwise
/// interrupted by the user or application logic.  It should not
/// however be emitted while waiting for a resource (for instance
/// while blocking on a file or network read) unless a
/// user-significant timeout has occurred.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.LoadStoppedSignal> Signal_LoadStopped(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.LoadStoppedSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.load_stopped handler = ( MentorLake.Atk.AtkDocumentHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.LoadStoppedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "load-stopped", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The &apos;page-changed&apos; signal is emitted when the current page of
/// a document changes, e.g. pressing page up/down in a document
/// viewer.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.PageChangedSignal> Signal_PageChanged(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.PageChangedSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.page_changed handler = ( MentorLake.Atk.AtkDocumentHandle self,  int page_number,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.PageChangedSignal()
				{
					Self = self, PageNumber = page_number, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "page-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The &apos;reload&apos; signal is emitted when the contents of a
/// document is refreshed from its source.  Once &apos;reload&apos; has
/// been emitted, a matching &apos;load-complete&apos; or &apos;load-stopped&apos;
/// signal should follow, which clients may await before
/// interrogating ATK for the latest document content.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.ReloadSignal> Signal_Reload(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.ReloadSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.reload handler = ( MentorLake.Atk.AtkDocumentHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.ReloadSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "reload", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The &quot;link-selected&quot; signal is emitted by an AtkHyperText
/// object when one of the hyperlinks associated with the object
/// is selected.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.LinkSelectedSignal> Signal_LinkSelected(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.LinkSelectedSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.link_selected handler = ( MentorLake.Atk.AtkHypertextHandle self,  int arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.LinkSelectedSignal()
				{
					Self = self, Arg1 = arg1, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "link-selected", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The &quot;selection-changed&quot; signal is emitted by an object which
/// implements AtkSelection interface when the selection changes.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.SelectionChangedSignal> Signal_SelectionChanged(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.SelectionChangedSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.selection_changed handler = ( MentorLake.Atk.AtkSelectionHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.SelectionChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selection-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The &quot;column-deleted&quot; signal is emitted by an object which
/// implements the AtkTable interface when a column is deleted.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.ColumnDeletedSignal> Signal_ColumnDeleted(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.ColumnDeletedSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.column_deleted handler = ( MentorLake.Atk.AtkTableHandle self,  int arg1,  int arg2,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.ColumnDeletedSignal()
				{
					Self = self, Arg1 = arg1, Arg2 = arg2, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "column-deleted", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The &quot;column-inserted&quot; signal is emitted by an object which
/// implements the AtkTable interface when a column is inserted.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.ColumnInsertedSignal> Signal_ColumnInserted(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.ColumnInsertedSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.column_inserted handler = ( MentorLake.Atk.AtkTableHandle self,  int arg1,  int arg2,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.ColumnInsertedSignal()
				{
					Self = self, Arg1 = arg1, Arg2 = arg2, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "column-inserted", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The &quot;column-reordered&quot; signal is emitted by an object which
/// implements the AtkTable interface when the columns are
/// reordered.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.ColumnReorderedSignal> Signal_ColumnReordered(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.ColumnReorderedSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.column_reordered handler = ( MentorLake.Atk.AtkTableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.ColumnReorderedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "column-reordered", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The &quot;model-changed&quot; signal is emitted by an object which
/// implements the AtkTable interface when the model displayed by
/// the table changes.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.ModelChangedSignal> Signal_ModelChanged(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.ModelChangedSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.model_changed handler = ( MentorLake.Atk.AtkTableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.ModelChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "model-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The &quot;row-deleted&quot; signal is emitted by an object which
/// implements the AtkTable interface when a row is deleted.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.RowDeletedSignal> Signal_RowDeleted(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.RowDeletedSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.row_deleted handler = ( MentorLake.Atk.AtkTableHandle self,  int arg1,  int arg2,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.RowDeletedSignal()
				{
					Self = self, Arg1 = arg1, Arg2 = arg2, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "row-deleted", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The &quot;row-inserted&quot; signal is emitted by an object which
/// implements the AtkTable interface when a row is inserted.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.RowInsertedSignal> Signal_RowInserted(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.RowInsertedSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.row_inserted handler = ( MentorLake.Atk.AtkTableHandle self,  int arg1,  int arg2,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.RowInsertedSignal()
				{
					Self = self, Arg1 = arg1, Arg2 = arg2, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "row-inserted", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The &quot;row-reordered&quot; signal is emitted by an object which
/// implements the AtkTable interface when the rows are
/// reordered.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.RowReorderedSignal> Signal_RowReordered(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.RowReorderedSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.row_reordered handler = ( MentorLake.Atk.AtkTableHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.RowReorderedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "row-reordered", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The &quot;text-attributes-changed&quot; signal is emitted when the text
/// attributes of the text of an object which implements AtkText
/// changes.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.TextAttributesChangedSignal> Signal_TextAttributesChanged(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.TextAttributesChangedSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.text_attributes_changed handler = ( MentorLake.Atk.AtkTextHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.TextAttributesChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "text-attributes-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The &quot;text-caret-moved&quot; signal is emitted when the caret
/// position of the text of an object which implements AtkText
/// changes.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.TextCaretMovedSignal> Signal_TextCaretMoved(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.TextCaretMovedSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.text_caret_moved handler = ( MentorLake.Atk.AtkTextHandle self,  int arg1,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.TextCaretMovedSignal()
				{
					Self = self, Arg1 = arg1, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "text-caret-moved", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The &quot;text-changed&quot; signal is emitted when the text of the
/// object which implements the AtkText interface changes, This
/// signal will have a detail which is either &quot;insert&quot; or
/// &quot;delete&quot; which identifies whether the text change was an
/// insertion or a deletion.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.TextChangedSignal> Signal_TextChanged(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.TextChangedSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.text_changed handler = ( MentorLake.Atk.AtkTextHandle self,  int arg1,  int arg2,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.TextChangedSignal()
				{
					Self = self, Arg1 = arg1, Arg2 = arg2, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "text-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The &quot;text-insert&quot; signal is emitted when a new text is
/// inserted. If the signal was not triggered by the user
/// (e.g. typing or pasting text), the &quot;system&quot; detail should be
/// included.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.TextInsertSignal> Signal_TextInsert(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.TextInsertSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.text_insert handler = ( MentorLake.Atk.AtkTextHandle self,  int arg1,  int arg2,  string arg3,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.TextInsertSignal()
				{
					Self = self, Arg1 = arg1, Arg2 = arg2, Arg3 = arg3, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "text-insert", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The &quot;text-remove&quot; signal is emitted when a new text is
/// removed. If the signal was not triggered by the user
/// (e.g. typing or pasting text), the &quot;system&quot; detail should be
/// included.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.TextRemoveSignal> Signal_TextRemove(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.TextRemoveSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.text_remove handler = ( MentorLake.Atk.AtkTextHandle self,  int arg1,  int arg2,  string arg3,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.TextRemoveSignal()
				{
					Self = self, Arg1 = arg1, Arg2 = arg2, Arg3 = arg3, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "text-remove", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The &quot;text-selection-changed&quot; signal is emitted when the
/// selected text of an object which implements AtkText changes.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.TextSelectionChangedSignal> Signal_TextSelectionChanged(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.TextSelectionChangedSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.text_selection_changed handler = ( MentorLake.Atk.AtkTextHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.TextSelectionChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "text-selection-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The &apos;value-changed&apos; signal is emitted when the current value
/// that represent the object changes. @value is the numerical
/// representation of this new value.  @text is the human
/// readable text alternative of @value, and can be NULL if it is
/// not available. Note that if there is a textual description
/// associated with the new numeric value, that description
/// should be included regardless of whether or not it has also
/// changed.
/// </para>
/// <para>
/// Example: a password meter whose value changes as the user
/// types their new password. Appropiate value text would be
/// &quot;weak&quot;, &quot;acceptable&quot; and &quot;strong&quot;.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.ValueChangedSignal> Signal_ValueChanged(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.ValueChangedSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.value_changed handler = ( MentorLake.Atk.AtkValueHandle self,  double value,  string text,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.ValueChangedSignal()
				{
					Self = self, Value = value, Text = text, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "value-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The signal #AtkWindow::activate is emitted when a window
/// becomes the active window of the application or session.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.ActivateSignal> Signal_Activate(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.ActivateSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.activate handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.ActivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The signal #AtkWindow::create is emitted when a new window
/// is created.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.CreateSignal> Signal_Create(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.CreateSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.create handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.CreateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "create", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The signal #AtkWindow::deactivate is emitted when a window is
/// no longer the active window of the application or session.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.DeactivateSignal> Signal_Deactivate(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.DeactivateSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.deactivate handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.DeactivateSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "deactivate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The signal #AtkWindow::destroy is emitted when a window is
/// destroyed.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.DestroySignal> Signal_Destroy(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.DestroySignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.destroy handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.DestroySignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "destroy", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The signal #AtkWindow::maximize is emitted when a window
/// is maximized.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.MaximizeSignal> Signal_Maximize(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.MaximizeSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.maximize handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.MaximizeSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "maximize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The signal #AtkWindow::minimize is emitted when a window
/// is minimized.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.MinimizeSignal> Signal_Minimize(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.MinimizeSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.minimize handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.MinimizeSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "minimize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The signal #AtkWindow::move is emitted when a window
/// is moved.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.MoveSignal> Signal_Move(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.MoveSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.move handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.MoveSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The signal #AtkWindow::resize is emitted when a window
/// is resized.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.ResizeSignal> Signal_Resize(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.ResizeSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.resize handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.ResizeSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "resize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

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
/// The signal #AtkWindow::restore is emitted when a window
/// is restored.
/// </para>
/// </summary>

	public static IObservable<AtkNoOpObjectHandleSignalStructs.RestoreSignal> Signal_Restore(this AtkNoOpObjectHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<AtkNoOpObjectHandleSignalStructs.RestoreSignal> obs) =>
		{
			AtkNoOpObjectHandleSignalDelegates.restore handler = ( MentorLake.Atk.AtkWindowHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new AtkNoOpObjectHandleSignalStructs.RestoreSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "restore", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class AtkNoOpObjectHandleSignalStructs
{

public class BoundsChangedSignal
{

	public MentorLake.Atk.AtkComponentHandle Self;
/// <summary>
/// <para>
/// The AtkRectangle giving the new position and size.
/// </para>
/// </summary>

	public MentorLake.Atk.AtkRectangleHandle Arg1;

	public IntPtr UserData;
}

public class DocumentAttributeChangedSignal
{

	public MentorLake.Atk.AtkDocumentHandle Self;
/// <summary>
/// <para>
/// the name of the attribute being modified, or %NULL if not
///          available.
/// </para>
/// </summary>

	public string Arg1;
/// <summary>
/// <para>
/// the attribute&apos;s new value, or %null if not available.
/// </para>
/// </summary>

	public string Arg2;

	public IntPtr UserData;
}

public class LoadCompleteSignal
{

	public MentorLake.Atk.AtkDocumentHandle Self;

	public IntPtr UserData;
}

public class LoadStoppedSignal
{

	public MentorLake.Atk.AtkDocumentHandle Self;

	public IntPtr UserData;
}

public class PageChangedSignal
{

	public MentorLake.Atk.AtkDocumentHandle Self;
/// <summary>
/// <para>
/// the new page number. If this value is unknown
/// or not applicable, -1 should be provided.
/// </para>
/// </summary>

	public int PageNumber;

	public IntPtr UserData;
}

public class ReloadSignal
{

	public MentorLake.Atk.AtkDocumentHandle Self;

	public IntPtr UserData;
}

public class LinkSelectedSignal
{

	public MentorLake.Atk.AtkHypertextHandle Self;
/// <summary>
/// <para>
/// the index of the hyperlink which is selected
/// </para>
/// </summary>

	public int Arg1;

	public IntPtr UserData;
}

public class SelectionChangedSignal
{

	public MentorLake.Atk.AtkSelectionHandle Self;

	public IntPtr UserData;
}

public class ColumnDeletedSignal
{

	public MentorLake.Atk.AtkTableHandle Self;
/// <summary>
/// <para>
/// The index of the first column deleted.
/// </para>
/// </summary>

	public int Arg1;
/// <summary>
/// <para>
/// The number of columns deleted.
/// </para>
/// </summary>

	public int Arg2;

	public IntPtr UserData;
}

public class ColumnInsertedSignal
{

	public MentorLake.Atk.AtkTableHandle Self;
/// <summary>
/// <para>
/// The index of the column inserted.
/// </para>
/// </summary>

	public int Arg1;
/// <summary>
/// <para>
/// The number of colums inserted.
/// </para>
/// </summary>

	public int Arg2;

	public IntPtr UserData;
}

public class ColumnReorderedSignal
{

	public MentorLake.Atk.AtkTableHandle Self;

	public IntPtr UserData;
}

public class ModelChangedSignal
{

	public MentorLake.Atk.AtkTableHandle Self;

	public IntPtr UserData;
}

public class RowDeletedSignal
{

	public MentorLake.Atk.AtkTableHandle Self;
/// <summary>
/// <para>
/// The index of the first row deleted.
/// </para>
/// </summary>

	public int Arg1;
/// <summary>
/// <para>
/// The number of rows deleted.
/// </para>
/// </summary>

	public int Arg2;

	public IntPtr UserData;
}

public class RowInsertedSignal
{

	public MentorLake.Atk.AtkTableHandle Self;
/// <summary>
/// <para>
/// The index of the first row inserted.
/// </para>
/// </summary>

	public int Arg1;
/// <summary>
/// <para>
/// The number of rows inserted.
/// </para>
/// </summary>

	public int Arg2;

	public IntPtr UserData;
}

public class RowReorderedSignal
{

	public MentorLake.Atk.AtkTableHandle Self;

	public IntPtr UserData;
}

public class TextAttributesChangedSignal
{

	public MentorLake.Atk.AtkTextHandle Self;

	public IntPtr UserData;
}

public class TextCaretMovedSignal
{

	public MentorLake.Atk.AtkTextHandle Self;
/// <summary>
/// <para>
/// The new position of the text caret.
/// </para>
/// </summary>

	public int Arg1;

	public IntPtr UserData;
}

public class TextChangedSignal
{

	public MentorLake.Atk.AtkTextHandle Self;
/// <summary>
/// <para>
/// The position (character offset) of the insertion or deletion.
/// </para>
/// </summary>

	public int Arg1;
/// <summary>
/// <para>
/// The length (in characters) of text inserted or deleted.
/// </para>
/// </summary>

	public int Arg2;

	public IntPtr UserData;
}

public class TextInsertSignal
{

	public MentorLake.Atk.AtkTextHandle Self;
/// <summary>
/// <para>
/// The position (character offset) of the insertion.
/// </para>
/// </summary>

	public int Arg1;
/// <summary>
/// <para>
/// The length (in characters) of text inserted.
/// </para>
/// </summary>

	public int Arg2;
/// <summary>
/// <para>
/// The new text inserted
/// </para>
/// </summary>

	public string Arg3;

	public IntPtr UserData;
}

public class TextRemoveSignal
{

	public MentorLake.Atk.AtkTextHandle Self;
/// <summary>
/// <para>
/// The position (character offset) of the removal.
/// </para>
/// </summary>

	public int Arg1;
/// <summary>
/// <para>
/// The length (in characters) of text removed.
/// </para>
/// </summary>

	public int Arg2;
/// <summary>
/// <para>
/// The old text removed
/// </para>
/// </summary>

	public string Arg3;

	public IntPtr UserData;
}

public class TextSelectionChangedSignal
{

	public MentorLake.Atk.AtkTextHandle Self;

	public IntPtr UserData;
}

public class ValueChangedSignal
{

	public MentorLake.Atk.AtkValueHandle Self;
/// <summary>
/// <para>
/// the new value in a numerical form.
/// </para>
/// </summary>

	public double Value;
/// <summary>
/// <para>
/// human readable text alternative (also called
/// description) of this object. NULL if not available.
/// </para>
/// </summary>

	public string Text;

	public IntPtr UserData;
}

public class ActivateSignal
{

	public MentorLake.Atk.AtkWindowHandle Self;

	public IntPtr UserData;
}

public class CreateSignal
{

	public MentorLake.Atk.AtkWindowHandle Self;

	public IntPtr UserData;
}

public class DeactivateSignal
{

	public MentorLake.Atk.AtkWindowHandle Self;

	public IntPtr UserData;
}

public class DestroySignal
{

	public MentorLake.Atk.AtkWindowHandle Self;

	public IntPtr UserData;
}

public class MaximizeSignal
{

	public MentorLake.Atk.AtkWindowHandle Self;

	public IntPtr UserData;
}

public class MinimizeSignal
{

	public MentorLake.Atk.AtkWindowHandle Self;

	public IntPtr UserData;
}

public class MoveSignal
{

	public MentorLake.Atk.AtkWindowHandle Self;

	public IntPtr UserData;
}

public class ResizeSignal
{

	public MentorLake.Atk.AtkWindowHandle Self;

	public IntPtr UserData;
}

public class RestoreSignal
{

	public MentorLake.Atk.AtkWindowHandle Self;

	public IntPtr UserData;
}
}

public static class AtkNoOpObjectHandleSignalDelegates
{

/// <summary>
/// <para>
/// The &apos;bounds-changed&quot; signal is emitted when the position or
/// size of the component changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// The AtkRectangle giving the new position and size.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void bounds_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRectangleHandle>))] MentorLake.Atk.AtkRectangleHandle arg1, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;document-attribute-changed&quot; signal should be emitted when there is a
/// change to one of the document attributes returned by
/// atk_document_get_attributes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// the name of the attribute being modified, or %NULL if not
///          available.
/// </param>
/// <param name="arg2">
/// the attribute&apos;s new value, or %null if not available.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void document_attribute_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle self, string arg1, string arg2, IntPtr user_data);


/// <summary>
/// <para>
/// The &apos;load-complete&apos; signal is emitted when a pending load of
/// a static document has completed.  This signal is to be
/// expected by ATK clients if and when AtkDocument implementors
/// expose ATK_STATE_BUSY.  If the state of an AtkObject which
/// implements AtkDocument does not include ATK_STATE_BUSY, it
/// should be safe for clients to assume that the AtkDocument&apos;s
/// static contents are fully loaded into the container.
/// (Dynamic document contents should be exposed via other
/// signals.)
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void load_complete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The &apos;load-stopped&apos; signal is emitted when a pending load of
/// document contents is cancelled, paused, or otherwise
/// interrupted by the user or application logic.  It should not
/// however be emitted while waiting for a resource (for instance
/// while blocking on a file or network read) unless a
/// user-significant timeout has occurred.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void load_stopped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The &apos;page-changed&apos; signal is emitted when the current page of
/// a document changes, e.g. pressing page up/down in a document
/// viewer.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="page_number">
/// the new page number. If this value is unknown
/// or not applicable, -1 should be provided.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void page_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle self, int page_number, IntPtr user_data);


/// <summary>
/// <para>
/// The &apos;reload&apos; signal is emitted when the contents of a
/// document is refreshed from its source.  Once &apos;reload&apos; has
/// been emitted, a matching &apos;load-complete&apos; or &apos;load-stopped&apos;
/// signal should follow, which clients may await before
/// interrogating ATK for the latest document content.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void reload([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;link-selected&quot; signal is emitted by an AtkHyperText
/// object when one of the hyperlinks associated with the object
/// is selected.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// the index of the hyperlink which is selected
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void link_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHypertextHandleImpl>))] MentorLake.Atk.AtkHypertextHandle self, int arg1, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;selection-changed&quot; signal is emitted by an object which
/// implements AtkSelection interface when the selection changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkSelectionHandleImpl>))] MentorLake.Atk.AtkSelectionHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;column-deleted&quot; signal is emitted by an object which
/// implements the AtkTable interface when a column is deleted.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// The index of the first column deleted.
/// </param>
/// <param name="arg2">
/// The number of columns deleted.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void column_deleted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle self, int arg1, int arg2, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;column-inserted&quot; signal is emitted by an object which
/// implements the AtkTable interface when a column is inserted.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// The index of the column inserted.
/// </param>
/// <param name="arg2">
/// The number of colums inserted.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void column_inserted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle self, int arg1, int arg2, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;column-reordered&quot; signal is emitted by an object which
/// implements the AtkTable interface when the columns are
/// reordered.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void column_reordered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;model-changed&quot; signal is emitted by an object which
/// implements the AtkTable interface when the model displayed by
/// the table changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void model_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;row-deleted&quot; signal is emitted by an object which
/// implements the AtkTable interface when a row is deleted.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// The index of the first row deleted.
/// </param>
/// <param name="arg2">
/// The number of rows deleted.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_deleted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle self, int arg1, int arg2, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;row-inserted&quot; signal is emitted by an object which
/// implements the AtkTable interface when a row is inserted.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// The index of the first row inserted.
/// </param>
/// <param name="arg2">
/// The number of rows inserted.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_inserted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle self, int arg1, int arg2, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;row-reordered&quot; signal is emitted by an object which
/// implements the AtkTable interface when the rows are
/// reordered.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_reordered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;text-attributes-changed&quot; signal is emitted when the text
/// attributes of the text of an object which implements AtkText
/// changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_attributes_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;text-caret-moved&quot; signal is emitted when the caret
/// position of the text of an object which implements AtkText
/// changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// The new position of the text caret.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_caret_moved([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, int arg1, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;text-changed&quot; signal is emitted when the text of the
/// object which implements the AtkText interface changes, This
/// signal will have a detail which is either &quot;insert&quot; or
/// &quot;delete&quot; which identifies whether the text change was an
/// insertion or a deletion.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// The position (character offset) of the insertion or deletion.
/// </param>
/// <param name="arg2">
/// The length (in characters) of text inserted or deleted.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, int arg1, int arg2, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;text-insert&quot; signal is emitted when a new text is
/// inserted. If the signal was not triggered by the user
/// (e.g. typing or pasting text), the &quot;system&quot; detail should be
/// included.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// The position (character offset) of the insertion.
/// </param>
/// <param name="arg2">
/// The length (in characters) of text inserted.
/// </param>
/// <param name="arg3">
/// The new text inserted
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, int arg1, int arg2, string arg3, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;text-remove&quot; signal is emitted when a new text is
/// removed. If the signal was not triggered by the user
/// (e.g. typing or pasting text), the &quot;system&quot; detail should be
/// included.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="arg1">
/// The position (character offset) of the removal.
/// </param>
/// <param name="arg2">
/// The length (in characters) of text removed.
/// </param>
/// <param name="arg3">
/// The old text removed
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, int arg1, int arg2, string arg3, IntPtr user_data);


/// <summary>
/// <para>
/// The &quot;text-selection-changed&quot; signal is emitted when the
/// selected text of an object which implements AtkText changes.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_selection_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The &apos;value-changed&apos; signal is emitted when the current value
/// that represent the object changes. @value is the numerical
/// representation of this new value.  @text is the human
/// readable text alternative of @value, and can be NULL if it is
/// not available. Note that if there is a textual description
/// associated with the new numeric value, that description
/// should be included regardless of whether or not it has also
/// changed.
/// </para>
/// <para>
/// Example: a password meter whose value changes as the user
/// types their new password. Appropiate value text would be
/// &quot;weak&quot;, &quot;acceptable&quot; and &quot;strong&quot;.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="value">
/// the new value in a numerical form.
/// </param>
/// <param name="text">
/// human readable text alternative (also called
/// description) of this object. NULL if not available.
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void value_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle self, double value, string text, IntPtr user_data);


/// <summary>
/// <para>
/// The signal #AtkWindow::activate is emitted when a window
/// becomes the active window of the application or session.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The signal #AtkWindow::create is emitted when a new window
/// is created.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void create([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The signal #AtkWindow::deactivate is emitted when a window is
/// no longer the active window of the application or session.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void deactivate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The signal #AtkWindow::destroy is emitted when a window is
/// destroyed.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The signal #AtkWindow::maximize is emitted when a window
/// is maximized.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void maximize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The signal #AtkWindow::minimize is emitted when a window
/// is minimized.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void minimize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The signal #AtkWindow::move is emitted when a window
/// is moved.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The signal #AtkWindow::resize is emitted when a window
/// is resized.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


/// <summary>
/// <para>
/// The signal #AtkWindow::restore is emitted when a window
/// is restored.
/// </para>
/// </summary>

/// <param name="self">
/// </param>
/// <param name="user_data">
/// </param>

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void restore([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);

}


public static class AtkNoOpObjectHandleExtensions
{
}

internal class AtkNoOpObjectHandleExterns
{
	[DllImport(AtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ConstructorSafeHandleMarshaller<MentorLake.Atk.AtkNoOpObjectHandle>))]
	internal static extern MentorLake.Atk.AtkNoOpObjectHandle atk_no_op_object_new([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GObjectHandle>))] MentorLake.GObject.GObjectHandle obj);

}
