namespace MentorLake.Atk;

public class AtkNoOpObjectHandle : AtkObjectHandle, AtkActionHandle, AtkComponentHandle, AtkDocumentHandle, AtkEditableTextHandle, AtkHypertextHandle, AtkImageHandle, AtkSelectionHandle, AtkTableHandle, AtkTableCellHandle, AtkTextHandle, AtkValueHandle, AtkWindowHandle
{
	public static MentorLake.Atk.AtkNoOpObjectHandle New(MentorLake.GObject.GObjectHandle obj)
	{
		return AtkNoOpObjectHandleExterns.atk_no_op_object_new(obj);
	}

}
public static class AtkNoOpObjectHandleSignalExtensions
{

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
	public MentorLake.Atk.AtkRectangleHandle Arg1;
	public IntPtr UserData;
}

public class DocumentAttributeChangedSignal
{
	public MentorLake.Atk.AtkDocumentHandle Self;
	public string Arg1;
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
	public int Arg1;
	public int Arg2;
	public IntPtr UserData;
}

public class ColumnInsertedSignal
{
	public MentorLake.Atk.AtkTableHandle Self;
	public int Arg1;
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
	public int Arg1;
	public int Arg2;
	public IntPtr UserData;
}

public class RowInsertedSignal
{
	public MentorLake.Atk.AtkTableHandle Self;
	public int Arg1;
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
	public int Arg1;
	public IntPtr UserData;
}

public class TextChangedSignal
{
	public MentorLake.Atk.AtkTextHandle Self;
	public int Arg1;
	public int Arg2;
	public IntPtr UserData;
}

public class TextInsertSignal
{
	public MentorLake.Atk.AtkTextHandle Self;
	public int Arg1;
	public int Arg2;
	public string Arg3;
	public IntPtr UserData;
}

public class TextRemoveSignal
{
	public MentorLake.Atk.AtkTextHandle Self;
	public int Arg1;
	public int Arg2;
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
	public double Value;
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

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void bounds_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkComponentHandleImpl>))] MentorLake.Atk.AtkComponentHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkRectangleHandle>))] MentorLake.Atk.AtkRectangleHandle arg1, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void document_attribute_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle self, string arg1, string arg2, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void load_complete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void load_stopped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void page_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle self, int page_number, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void reload([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkDocumentHandleImpl>))] MentorLake.Atk.AtkDocumentHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void link_selected([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkHypertextHandleImpl>))] MentorLake.Atk.AtkHypertextHandle self, int arg1, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkSelectionHandleImpl>))] MentorLake.Atk.AtkSelectionHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void column_deleted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle self, int arg1, int arg2, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void column_inserted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle self, int arg1, int arg2, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void column_reordered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void model_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_deleted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle self, int arg1, int arg2, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_inserted([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle self, int arg1, int arg2, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void row_reordered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTableHandleImpl>))] MentorLake.Atk.AtkTableHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_attributes_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_caret_moved([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, int arg1, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, int arg1, int arg2, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_insert([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, int arg1, int arg2, string arg3, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, int arg1, int arg2, string arg3, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void text_selection_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkTextHandleImpl>))] MentorLake.Atk.AtkTextHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void value_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkValueHandleImpl>))] MentorLake.Atk.AtkValueHandle self, double value, string text, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void create([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void deactivate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void maximize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void minimize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Atk.AtkWindowHandleImpl>))] MentorLake.Atk.AtkWindowHandle self, IntPtr user_data);


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
