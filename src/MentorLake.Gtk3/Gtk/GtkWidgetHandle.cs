namespace MentorLake.Gtk;

public class GtkWidgetHandle : GInitiallyUnownedHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static MentorLake.Gtk.GtkWidgetHandle New(MentorLake.GObject.GType type, string first_property_name, IntPtr @__arglist)
	{
		return GtkWidgetHandleExterns.gtk_widget_new(type, first_property_name, @__arglist);
	}

	public static MentorLake.Gtk.GtkTextDirection GetDefaultDirection()
	{
		return GtkWidgetHandleExterns.gtk_widget_get_default_direction();
	}

	public static MentorLake.Gtk.GtkStyleHandle GetDefaultStyle()
	{
		return GtkWidgetHandleExterns.gtk_widget_get_default_style();
	}

	public static void PopCompositeChild()
	{
		GtkWidgetHandleExterns.gtk_widget_pop_composite_child();
	}

	public static void PushCompositeChild()
	{
		GtkWidgetHandleExterns.gtk_widget_push_composite_child();
	}

	public static void SetDefaultDirection(MentorLake.Gtk.GtkTextDirection dir)
	{
		GtkWidgetHandleExterns.gtk_widget_set_default_direction(dir);
	}

}
public static class GtkWidgetHandleSignalExtensions
{

	public static IObservable<GtkWidgetHandleSignalStructs.AccelClosuresChangedSignal> Signal_AccelClosuresChanged(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.AccelClosuresChangedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.accel_closures_changed handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.AccelClosuresChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "accel-closures-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.ButtonPressEventSignal> Signal_ButtonPressEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.ButtonPressEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.button_press_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventButtonHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.ButtonPressEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "button-press-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.ButtonReleaseEventSignal> Signal_ButtonReleaseEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.ButtonReleaseEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.button_release_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventButtonHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.ButtonReleaseEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "button-release-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.CanActivateAccelSignal> Signal_CanActivateAccel(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.CanActivateAccelSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.can_activate_accel handler = ( MentorLake.Gtk.GtkWidgetHandle self,  uint signal_id,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.CanActivateAccelSignal()
				{
					Self = self, SignalId = signal_id, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "can-activate-accel", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.ChildNotifySignal> Signal_ChildNotify(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.ChildNotifySignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.child_notify handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.GObject.GParamSpecHandle child_property,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.ChildNotifySignal()
				{
					Self = self, ChildProperty = child_property, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "child-notify", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.CompositedChangedSignal> Signal_CompositedChanged(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.CompositedChangedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.composited_changed handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.CompositedChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "composited-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.ConfigureEventSignal> Signal_ConfigureEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.ConfigureEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.configure_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventConfigureHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.ConfigureEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "configure-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.DamageEventSignal> Signal_DamageEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DamageEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.damage_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventExposeHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DamageEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "damage-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.DeleteEventSignal> Signal_DeleteEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DeleteEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.delete_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DeleteEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "delete-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.DestroySignal> Signal_Destroy(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DestroySignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.destroy handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DestroySignal()
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

	public static IObservable<GtkWidgetHandleSignalStructs.DestroyEventSignal> Signal_DestroyEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DestroyEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.destroy_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DestroyEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "destroy-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.DirectionChangedSignal> Signal_DirectionChanged(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DirectionChangedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.direction_changed handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkTextDirection previous_direction,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DirectionChangedSignal()
				{
					Self = self, PreviousDirection = previous_direction, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "direction-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.DragBeginSignal> Signal_DragBegin(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DragBeginSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.drag_begin handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkDragContextHandle context,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DragBeginSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-begin", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.DragDataDeleteSignal> Signal_DragDataDelete(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DragDataDeleteSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.drag_data_delete handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkDragContextHandle context,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DragDataDeleteSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-data-delete", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.DragDataGetSignal> Signal_DragDataGet(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DragDataGetSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.drag_data_get handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkDragContextHandle context,  MentorLake.Gtk.GtkSelectionDataHandle data,  uint info,  uint time,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DragDataGetSignal()
				{
					Self = self, Context = context, Data = data, Info = info, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-data-get", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.DragDataReceivedSignal> Signal_DragDataReceived(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DragDataReceivedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.drag_data_received handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkDragContextHandle context,  int x,  int y,  MentorLake.Gtk.GtkSelectionDataHandle data,  uint info,  uint time,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DragDataReceivedSignal()
				{
					Self = self, Context = context, X = x, Y = y, Data = data, Info = info, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-data-received", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.DragDropSignal> Signal_DragDrop(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DragDropSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.drag_drop handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkDragContextHandle context,  int x,  int y,  uint time,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DragDropSignal()
				{
					Self = self, Context = context, X = x, Y = y, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-drop", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.DragEndSignal> Signal_DragEnd(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DragEndSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.drag_end handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkDragContextHandle context,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DragEndSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.DragFailedSignal> Signal_DragFailed(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DragFailedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.drag_failed handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkDragContextHandle context,  MentorLake.Gtk.GtkDragResult result,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DragFailedSignal()
				{
					Self = self, Context = context, Result = result, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-failed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.DragLeaveSignal> Signal_DragLeave(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DragLeaveSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.drag_leave handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkDragContextHandle context,  uint time,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DragLeaveSignal()
				{
					Self = self, Context = context, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-leave", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.DragMotionSignal> Signal_DragMotion(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DragMotionSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.drag_motion handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkDragContextHandle context,  int x,  int y,  uint time,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DragMotionSignal()
				{
					Self = self, Context = context, X = x, Y = y, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "drag-motion", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.DrawSignal> Signal_Draw(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.DrawSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.draw handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.cairo.cairo_tHandle cr,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.DrawSignal()
				{
					Self = self, Cr = cr, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "draw", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.EnterNotifyEventSignal> Signal_EnterNotifyEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.EnterNotifyEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.enter_notify_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventCrossingHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.EnterNotifyEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "enter-notify-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.EventSignal> Signal_Event(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.EventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.@event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.EventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.EventAfterSignal> Signal_EventAfter(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.EventAfterSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.event_after handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.EventAfterSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "event-after", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.FocusSignal> Signal_Focus(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.FocusSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.focus handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkDirectionType direction,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.FocusSignal()
				{
					Self = self, Direction = direction, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.FocusInEventSignal> Signal_FocusInEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.FocusInEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.focus_in_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventFocusHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.FocusInEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "focus-in-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.FocusOutEventSignal> Signal_FocusOutEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.FocusOutEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.focus_out_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventFocusHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.FocusOutEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "focus-out-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.GrabBrokenEventSignal> Signal_GrabBrokenEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.GrabBrokenEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.grab_broken_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventGrabBrokenHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.GrabBrokenEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "grab-broken-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.GrabFocusSignal> Signal_GrabFocus(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.GrabFocusSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.grab_focus handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.GrabFocusSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "grab-focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.GrabNotifySignal> Signal_GrabNotify(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.GrabNotifySignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.grab_notify handler = ( MentorLake.Gtk.GtkWidgetHandle self,  bool was_grabbed,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.GrabNotifySignal()
				{
					Self = self, WasGrabbed = was_grabbed, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "grab-notify", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.HideSignal> Signal_Hide(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.HideSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.hide handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.HideSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "hide", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.HierarchyChangedSignal> Signal_HierarchyChanged(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.HierarchyChangedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.hierarchy_changed handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkWidgetHandle previous_toplevel,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.HierarchyChangedSignal()
				{
					Self = self, PreviousToplevel = previous_toplevel, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "hierarchy-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.KeyPressEventSignal> Signal_KeyPressEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.KeyPressEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.key_press_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventKeyHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.KeyPressEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "key-press-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.KeyReleaseEventSignal> Signal_KeyReleaseEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.KeyReleaseEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.key_release_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventKeyHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.KeyReleaseEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "key-release-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.KeynavFailedSignal> Signal_KeynavFailed(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.KeynavFailedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.keynav_failed handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkDirectionType direction,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.KeynavFailedSignal()
				{
					Self = self, Direction = direction, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "keynav-failed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.LeaveNotifyEventSignal> Signal_LeaveNotifyEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.LeaveNotifyEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.leave_notify_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventCrossingHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.LeaveNotifyEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "leave-notify-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.MapSignal> Signal_Map(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.MapSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.map handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.MapSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "map", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.MapEventSignal> Signal_MapEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.MapEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.map_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventAnyHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.MapEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "map-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.MnemonicActivateSignal> Signal_MnemonicActivate(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.MnemonicActivateSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.mnemonic_activate handler = ( MentorLake.Gtk.GtkWidgetHandle self,  bool group_cycling,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.MnemonicActivateSignal()
				{
					Self = self, GroupCycling = group_cycling, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "mnemonic-activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.MotionNotifyEventSignal> Signal_MotionNotifyEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.MotionNotifyEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.motion_notify_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventMotionHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.MotionNotifyEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "motion-notify-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.MoveFocusSignal> Signal_MoveFocus(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.MoveFocusSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.move_focus handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkDirectionType direction,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.MoveFocusSignal()
				{
					Self = self, Direction = direction, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "move-focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.ParentSetSignal> Signal_ParentSet(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.ParentSetSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.parent_set handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkWidgetHandle old_parent,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.ParentSetSignal()
				{
					Self = self, OldParent = old_parent, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "parent-set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.PopupMenuSignal> Signal_PopupMenu(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.PopupMenuSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.popup_menu handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.PopupMenuSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "popup-menu", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.PropertyNotifyEventSignal> Signal_PropertyNotifyEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.PropertyNotifyEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.property_notify_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventPropertyHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.PropertyNotifyEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "property-notify-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.ProximityInEventSignal> Signal_ProximityInEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.ProximityInEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.proximity_in_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventProximityHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.ProximityInEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "proximity-in-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.ProximityOutEventSignal> Signal_ProximityOutEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.ProximityOutEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.proximity_out_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventProximityHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.ProximityOutEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "proximity-out-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.QueryTooltipSignal> Signal_QueryTooltip(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.QueryTooltipSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.query_tooltip handler = ( MentorLake.Gtk.GtkWidgetHandle self,  int x,  int y,  bool keyboard_mode,  MentorLake.Gtk.GtkTooltipHandle tooltip,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.QueryTooltipSignal()
				{
					Self = self, X = x, Y = y, KeyboardMode = keyboard_mode, Tooltip = tooltip, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "query-tooltip", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.RealizeSignal> Signal_Realize(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.RealizeSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.realize handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.RealizeSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "realize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.ScreenChangedSignal> Signal_ScreenChanged(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.ScreenChangedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.screen_changed handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkScreenHandle previous_screen,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.ScreenChangedSignal()
				{
					Self = self, PreviousScreen = previous_screen, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "screen-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.ScrollEventSignal> Signal_ScrollEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.ScrollEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.scroll_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventScrollHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.ScrollEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "scroll-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.SelectionClearEventSignal> Signal_SelectionClearEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.SelectionClearEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.selection_clear_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventSelectionHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.SelectionClearEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selection-clear-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.SelectionGetSignal> Signal_SelectionGet(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.SelectionGetSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.selection_get handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkSelectionDataHandle data,  uint info,  uint time,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.SelectionGetSignal()
				{
					Self = self, Data = data, Info = info, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selection-get", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.SelectionNotifyEventSignal> Signal_SelectionNotifyEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.SelectionNotifyEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.selection_notify_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventSelectionHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.SelectionNotifyEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selection-notify-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.SelectionReceivedSignal> Signal_SelectionReceived(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.SelectionReceivedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.selection_received handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkSelectionDataHandle data,  uint time,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.SelectionReceivedSignal()
				{
					Self = self, Data = data, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selection-received", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.SelectionRequestEventSignal> Signal_SelectionRequestEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.SelectionRequestEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.selection_request_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventSelectionHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.SelectionRequestEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "selection-request-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.ShowSignal> Signal_Show(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.ShowSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.show handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.ShowSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "show", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.ShowHelpSignal> Signal_ShowHelp(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.ShowHelpSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.show_help handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkWidgetHelpType help_type,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.ShowHelpSignal()
				{
					Self = self, HelpType = help_type, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "show-help", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.SizeAllocateSignal> Signal_SizeAllocate(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.SizeAllocateSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.size_allocate handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkAllocationHandle allocation,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.SizeAllocateSignal()
				{
					Self = self, Allocation = allocation, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "size-allocate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.StateChangedSignal> Signal_StateChanged(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.StateChangedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.state_changed handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkStateType state,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.StateChangedSignal()
				{
					Self = self, State = state, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "state-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.StateFlagsChangedSignal> Signal_StateFlagsChanged(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.StateFlagsChangedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.state_flags_changed handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkStateFlags flags,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.StateFlagsChangedSignal()
				{
					Self = self, Flags = flags, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "state-flags-changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.StyleSetSignal> Signal_StyleSet(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.StyleSetSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.style_set handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gtk.GtkStyleHandle previous_style,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.StyleSetSignal()
				{
					Self = self, PreviousStyle = previous_style, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "style-set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.StyleUpdatedSignal> Signal_StyleUpdated(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.StyleUpdatedSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.style_updated handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.StyleUpdatedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "style-updated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.TouchEventSignal> Signal_TouchEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.TouchEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.touch_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventHandle @object,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.TouchEventSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "touch-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.UnmapSignal> Signal_Unmap(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.UnmapSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.unmap handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.UnmapSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "unmap", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.UnmapEventSignal> Signal_UnmapEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.UnmapEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.unmap_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventAnyHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.UnmapEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "unmap-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.UnrealizeSignal> Signal_Unrealize(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.UnrealizeSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.unrealize handler = ( MentorLake.Gtk.GtkWidgetHandle self,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.UnrealizeSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "unrealize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.VisibilityNotifyEventSignal> Signal_VisibilityNotifyEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.VisibilityNotifyEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.visibility_notify_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventVisibilityHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.VisibilityNotifyEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "visibility-notify-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}

	public static IObservable<GtkWidgetHandleSignalStructs.WindowStateEventSignal> Signal_WindowStateEvent(this GtkWidgetHandle instance, GConnectFlags connectFlags = GConnectFlags.G_CONNECT_AFTER)
	{
		return Observable.Create((IObserver<GtkWidgetHandleSignalStructs.WindowStateEventSignal> obs) =>
		{
			GtkWidgetHandleSignalDelegates.window_state_event handler = ( MentorLake.Gtk.GtkWidgetHandle self,  MentorLake.Gdk.GdkEventWindowStateHandle @event,  IntPtr user_data) =>
			{
				

				var signalStruct = new GtkWidgetHandleSignalStructs.WindowStateEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var gcHandle = System.Runtime.InteropServices.GCHandle.Alloc(handler);
			var handlerId = GObjectGlobalFunctions.SignalConnectData(instance, "window-state-event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, connectFlags);

			return Disposable.Create(() =>
			{
				GObjectGlobalFunctions.SignalHandlerDisconnect(instance, handlerId);
				obs.OnCompleted();
				gcHandle.Free();
			});
		});
	}
}

public static class GtkWidgetHandleSignalStructs
{

public class AccelClosuresChangedSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public IntPtr UserData;
}

public class ButtonPressEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventButtonHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class ButtonReleaseEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventButtonHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class CanActivateAccelSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public uint SignalId;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class ChildNotifySignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.GObject.GParamSpecHandle ChildProperty;
	public IntPtr UserData;
}

public class CompositedChangedSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public IntPtr UserData;
}

public class ConfigureEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventConfigureHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class DamageEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventExposeHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class DeleteEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class DestroySignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public IntPtr UserData;
}

public class DestroyEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class DirectionChangedSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gtk.GtkTextDirection PreviousDirection;
	public IntPtr UserData;
}

public class DragBeginSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkDragContextHandle Context;
	public IntPtr UserData;
}

public class DragDataDeleteSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkDragContextHandle Context;
	public IntPtr UserData;
}

public class DragDataGetSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkDragContextHandle Context;
	public MentorLake.Gtk.GtkSelectionDataHandle Data;
	public uint Info;
	public uint Time;
	public IntPtr UserData;
}

public class DragDataReceivedSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkDragContextHandle Context;
	public int X;
	public int Y;
	public MentorLake.Gtk.GtkSelectionDataHandle Data;
	public uint Info;
	public uint Time;
	public IntPtr UserData;
}

public class DragDropSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkDragContextHandle Context;
	public int X;
	public int Y;
	public uint Time;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class DragEndSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkDragContextHandle Context;
	public IntPtr UserData;
}

public class DragFailedSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkDragContextHandle Context;
	public MentorLake.Gtk.GtkDragResult Result;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class DragLeaveSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkDragContextHandle Context;
	public uint Time;
	public IntPtr UserData;
}

public class DragMotionSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkDragContextHandle Context;
	public int X;
	public int Y;
	public uint Time;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class DrawSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.cairo.cairo_tHandle Cr;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class EnterNotifyEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventCrossingHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class EventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class EventAfterSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventHandle Event;
	public IntPtr UserData;
}

public class FocusSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gtk.GtkDirectionType Direction;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class FocusInEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventFocusHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class FocusOutEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventFocusHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class GrabBrokenEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventGrabBrokenHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class GrabFocusSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public IntPtr UserData;
}

public class GrabNotifySignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public bool WasGrabbed;
	public IntPtr UserData;
}

public class HideSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public IntPtr UserData;
}

public class HierarchyChangedSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gtk.GtkWidgetHandle PreviousToplevel;
	public IntPtr UserData;
}

public class KeyPressEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventKeyHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class KeyReleaseEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventKeyHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class KeynavFailedSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gtk.GtkDirectionType Direction;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class LeaveNotifyEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventCrossingHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class MapSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public IntPtr UserData;
}

public class MapEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventAnyHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class MnemonicActivateSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public bool GroupCycling;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class MotionNotifyEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventMotionHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class MoveFocusSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gtk.GtkDirectionType Direction;
	public IntPtr UserData;
}

public class ParentSetSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gtk.GtkWidgetHandle OldParent;
	public IntPtr UserData;
}

public class PopupMenuSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class PropertyNotifyEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventPropertyHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class ProximityInEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventProximityHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class ProximityOutEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventProximityHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class QueryTooltipSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public int X;
	public int Y;
	public bool KeyboardMode;
	public MentorLake.Gtk.GtkTooltipHandle Tooltip;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class RealizeSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public IntPtr UserData;
}

public class ScreenChangedSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkScreenHandle PreviousScreen;
	public IntPtr UserData;
}

public class ScrollEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventScrollHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class SelectionClearEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventSelectionHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class SelectionGetSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gtk.GtkSelectionDataHandle Data;
	public uint Info;
	public uint Time;
	public IntPtr UserData;
}

public class SelectionNotifyEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventSelectionHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class SelectionReceivedSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gtk.GtkSelectionDataHandle Data;
	public uint Time;
	public IntPtr UserData;
}

public class SelectionRequestEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventSelectionHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class ShowSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public IntPtr UserData;
}

public class ShowHelpSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gtk.GtkWidgetHelpType HelpType;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class SizeAllocateSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gtk.GtkAllocationHandle Allocation;
	public IntPtr UserData;
}

public class StateChangedSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gtk.GtkStateType State;
	public IntPtr UserData;
}

public class StateFlagsChangedSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gtk.GtkStateFlags Flags;
	public IntPtr UserData;
}

public class StyleSetSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gtk.GtkStyleHandle PreviousStyle;
	public IntPtr UserData;
}

public class StyleUpdatedSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public IntPtr UserData;
}

public class TouchEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventHandle Object;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class UnmapSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public IntPtr UserData;
}

public class UnmapEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventAnyHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class UnrealizeSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public IntPtr UserData;
}

public class VisibilityNotifyEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventVisibilityHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public class WindowStateEventSignal
{
	public MentorLake.Gtk.GtkWidgetHandle Self;
	public MentorLake.Gdk.GdkEventWindowStateHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkWidgetHandleSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void accel_closures_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool button_press_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventButtonHandle>))] MentorLake.Gdk.GdkEventButtonHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool button_release_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventButtonHandle>))] MentorLake.Gdk.GdkEventButtonHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool can_activate_accel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, uint signal_id, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void child_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GObject.GParamSpecHandle>))] MentorLake.GObject.GParamSpecHandle child_property, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void composited_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool configure_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventConfigureHandle>))] MentorLake.Gdk.GdkEventConfigureHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool damage_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventExposeHandle>))] MentorLake.Gdk.GdkEventExposeHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool delete_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool destroy_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void direction_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, MentorLake.Gtk.GtkTextDirection previous_direction, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_begin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_data_delete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_data_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle data, uint info, uint time, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_data_received([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, int x, int y, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle data, uint info, uint time, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool drag_drop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, int x, int y, uint time, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool drag_failed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, MentorLake.Gtk.GtkDragResult result, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_leave([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, uint time, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool drag_motion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, int x, int y, uint time, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool draw([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool enter_notify_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventCrossingHandle>))] MentorLake.Gdk.GdkEventCrossingHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool @event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void event_after([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, MentorLake.Gtk.GtkDirectionType direction, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool focus_in_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventFocusHandle>))] MentorLake.Gdk.GdkEventFocusHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool focus_out_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventFocusHandle>))] MentorLake.Gdk.GdkEventFocusHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool grab_broken_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventGrabBrokenHandle>))] MentorLake.Gdk.GdkEventGrabBrokenHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void grab_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void grab_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, bool was_grabbed, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void hide([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void hierarchy_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle previous_toplevel, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool key_press_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventKeyHandle>))] MentorLake.Gdk.GdkEventKeyHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool key_release_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventKeyHandle>))] MentorLake.Gdk.GdkEventKeyHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool keynav_failed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, MentorLake.Gtk.GtkDirectionType direction, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool leave_notify_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventCrossingHandle>))] MentorLake.Gdk.GdkEventCrossingHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void map([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool map_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventAnyHandle>))] MentorLake.Gdk.GdkEventAnyHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool mnemonic_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, bool group_cycling, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool motion_notify_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventMotionHandle>))] MentorLake.Gdk.GdkEventMotionHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, MentorLake.Gtk.GtkDirectionType direction, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void parent_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle old_parent, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool popup_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool property_notify_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventPropertyHandle>))] MentorLake.Gdk.GdkEventPropertyHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool proximity_in_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventProximityHandle>))] MentorLake.Gdk.GdkEventProximityHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool proximity_out_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventProximityHandle>))] MentorLake.Gdk.GdkEventProximityHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool query_tooltip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, int x, int y, bool keyboard_mode, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTooltipHandle>))] MentorLake.Gtk.GtkTooltipHandle tooltip, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void realize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void screen_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkScreenHandle>))] MentorLake.Gdk.GdkScreenHandle previous_screen, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool scroll_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventScrollHandle>))] MentorLake.Gdk.GdkEventScrollHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool selection_clear_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSelectionHandle>))] MentorLake.Gdk.GdkEventSelectionHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle data, uint info, uint time, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool selection_notify_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSelectionHandle>))] MentorLake.Gdk.GdkEventSelectionHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_received([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkSelectionDataHandle>))] MentorLake.Gtk.GtkSelectionDataHandle data, uint time, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool selection_request_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventSelectionHandle>))] MentorLake.Gdk.GdkEventSelectionHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool show_help([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, MentorLake.Gtk.GtkWidgetHelpType help_type, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void size_allocate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAllocationHandle>))] MentorLake.Gtk.GtkAllocationHandle allocation, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void state_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, MentorLake.Gtk.GtkStateType state, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void state_flags_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, MentorLake.Gtk.GtkStateFlags flags, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void style_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle previous_style, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void style_updated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool touch_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @object, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unmap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool unmap_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventAnyHandle>))] MentorLake.Gdk.GdkEventAnyHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unrealize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool visibility_notify_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventVisibilityHandle>))] MentorLake.Gdk.GdkEventVisibilityHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool window_state_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventWindowStateHandle>))] MentorLake.Gdk.GdkEventWindowStateHandle @event, IntPtr user_data);

}


public static class GtkWidgetHandleExtensions
{
	public static bool Activate(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_activate(widget);
	}

	public static T AddAccelerator<T>(this T widget, string accel_signal, MentorLake.Gtk.GtkAccelGroupHandle accel_group, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods, MentorLake.Gtk.GtkAccelFlags accel_flags) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_add_accelerator(widget, accel_signal, accel_group, accel_key, accel_mods, accel_flags);
		return widget;
	}

	public static T AddDeviceEvents<T>(this T widget, MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gdk.GdkEventMask events) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_add_device_events(widget, device, events);
		return widget;
	}

	public static T AddEvents<T>(this T widget, int events) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_add_events(widget, events);
		return widget;
	}

	public static T AddMnemonicLabel<T>(this T widget, MentorLake.Gtk.GtkWidgetHandle label) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_add_mnemonic_label(widget, label);
		return widget;
	}

	public static uint AddTickCallback(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkTickCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_add_tick_callback(widget, callback, user_data, notify);
	}

	public static bool CanActivateAccel(this MentorLake.Gtk.GtkWidgetHandle widget, uint signal_id)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_can_activate_accel(widget, signal_id);
	}

	public static bool ChildFocus(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkDirectionType direction)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_child_focus(widget, direction);
	}

	public static T ChildNotify<T>(this T widget, string child_property) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_child_notify(widget, child_property);
		return widget;
	}

	public static T ClassPath<T>(this T widget, out uint path_length, out string path, out string path_reversed) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_class_path(widget, out path_length, out path, out path_reversed);
		return widget;
	}

	public static bool ComputeExpand(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkOrientation orientation)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_compute_expand(widget, orientation);
	}

	public static MentorLake.Pango.PangoContextHandle CreatePangoContext(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_create_pango_context(widget);
	}

	public static MentorLake.Pango.PangoLayoutHandle CreatePangoLayout(this MentorLake.Gtk.GtkWidgetHandle widget, string text)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_create_pango_layout(widget, text);
	}

	public static T Destroy<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_destroy(widget);
		return widget;
	}

	public static T Destroyed<T>(this T widget, ref MentorLake.Gtk.GtkWidgetHandle widget_pointer) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_destroyed(widget, ref widget_pointer);
		return widget;
	}

	public static bool DeviceIsShadowed(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_device_is_shadowed(widget, device);
	}

	public static MentorLake.Gdk.GdkDragContextHandle DragBegin(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkTargetListHandle targets, MentorLake.Gdk.GdkDragAction actions, int button, MentorLake.Gdk.GdkEventHandle @event)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_drag_begin(widget, targets, actions, button, @event);
	}

	public static MentorLake.Gdk.GdkDragContextHandle DragBeginWithCoordinates(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkTargetListHandle targets, MentorLake.Gdk.GdkDragAction actions, int button, MentorLake.Gdk.GdkEventHandle @event, int x, int y)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_drag_begin_with_coordinates(widget, targets, actions, button, @event, x, y);
	}

	public static bool DragCheckThreshold(this MentorLake.Gtk.GtkWidgetHandle widget, int start_x, int start_y, int current_x, int current_y)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_drag_check_threshold(widget, start_x, start_y, current_x, current_y);
	}

	public static T DragDestAddImageTargets<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_dest_add_image_targets(widget);
		return widget;
	}

	public static T DragDestAddTextTargets<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_dest_add_text_targets(widget);
		return widget;
	}

	public static T DragDestAddUriTargets<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_dest_add_uri_targets(widget);
		return widget;
	}

	public static MentorLake.Gdk.GdkAtom DragDestFindTarget(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkDragContextHandle context, MentorLake.Gtk.GtkTargetListHandle target_list)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_drag_dest_find_target(widget, context, target_list);
	}

	public static MentorLake.Gtk.GtkTargetListHandle DragDestGetTargetList(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_drag_dest_get_target_list(widget);
	}

	public static bool DragDestGetTrackMotion(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_drag_dest_get_track_motion(widget);
	}

	public static T DragDestSet<T>(this T widget, MentorLake.Gtk.GtkDestDefaults flags, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets, MentorLake.Gdk.GdkDragAction actions) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_dest_set(widget, flags, targets, n_targets, actions);
		return widget;
	}

	public static T DragDestSetProxy<T>(this T widget, MentorLake.Gdk.GdkWindowHandle proxy_window, MentorLake.Gdk.GdkDragProtocol protocol, bool use_coordinates) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_dest_set_proxy(widget, proxy_window, protocol, use_coordinates);
		return widget;
	}

	public static T DragDestSetTargetList<T>(this T widget, MentorLake.Gtk.GtkTargetListHandle target_list) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_dest_set_target_list(widget, target_list);
		return widget;
	}

	public static T DragDestSetTrackMotion<T>(this T widget, bool track_motion) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_dest_set_track_motion(widget, track_motion);
		return widget;
	}

	public static T DragDestUnset<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_dest_unset(widget);
		return widget;
	}

	public static T DragGetData<T>(this T widget, MentorLake.Gdk.GdkDragContextHandle context, MentorLake.Gdk.GdkAtom target, uint time_) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_get_data(widget, context, target, time_);
		return widget;
	}

	public static T DragHighlight<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_highlight(widget);
		return widget;
	}

	public static T DragSourceAddImageTargets<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_source_add_image_targets(widget);
		return widget;
	}

	public static T DragSourceAddTextTargets<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_source_add_text_targets(widget);
		return widget;
	}

	public static T DragSourceAddUriTargets<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_source_add_uri_targets(widget);
		return widget;
	}

	public static MentorLake.Gtk.GtkTargetListHandle DragSourceGetTargetList(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_drag_source_get_target_list(widget);
	}

	public static T DragSourceSet<T>(this T widget, MentorLake.Gdk.GdkModifierType start_button_mask, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets, MentorLake.Gdk.GdkDragAction actions) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_source_set(widget, start_button_mask, targets, n_targets, actions);
		return widget;
	}

	public static T DragSourceSetIconGicon<T>(this T widget, MentorLake.Gio.GIconHandle icon) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_source_set_icon_gicon(widget, icon);
		return widget;
	}

	public static T DragSourceSetIconName<T>(this T widget, string icon_name) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_source_set_icon_name(widget, icon_name);
		return widget;
	}

	public static T DragSourceSetIconPixbuf<T>(this T widget, MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_source_set_icon_pixbuf(widget, pixbuf);
		return widget;
	}

	public static T DragSourceSetIconStock<T>(this T widget, string stock_id) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_source_set_icon_stock(widget, stock_id);
		return widget;
	}

	public static T DragSourceSetTargetList<T>(this T widget, MentorLake.Gtk.GtkTargetListHandle target_list) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_source_set_target_list(widget, target_list);
		return widget;
	}

	public static T DragSourceUnset<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_source_unset(widget);
		return widget;
	}

	public static T DragUnhighlight<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_drag_unhighlight(widget);
		return widget;
	}

	public static T Draw<T>(this T widget, MentorLake.cairo.cairo_tHandle cr) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_draw(widget, cr);
		return widget;
	}

	public static T EnsureStyle<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_ensure_style(widget);
		return widget;
	}

	public static T ErrorBell<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_error_bell(widget);
		return widget;
	}

	public static bool Event(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkEventHandle @event)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_event(widget, @event);
	}

	public static T FreezeChildNotify<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_freeze_child_notify(widget);
		return widget;
	}

	public static MentorLake.Atk.AtkObjectHandle GetAccessible(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_accessible(widget);
	}

	public static MentorLake.Gio.GActionGroupHandle GetActionGroup(this MentorLake.Gtk.GtkWidgetHandle widget, string prefix)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_action_group(widget, prefix);
	}

	public static int GetAllocatedBaseline(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_allocated_baseline(widget);
	}

	public static int GetAllocatedHeight(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_allocated_height(widget);
	}

	public static T GetAllocatedSize<T>(this T widget, out MentorLake.Gtk.GtkAllocation allocation, out int baseline) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_allocated_size(widget, out allocation, out baseline);
		return widget;
	}

	public static int GetAllocatedWidth(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_allocated_width(widget);
	}

	public static T GetAllocation<T>(this T widget, out MentorLake.Gtk.GtkAllocation allocation) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_allocation(widget, out allocation);
		return widget;
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetAncestor(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.GObject.GType widget_type)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_ancestor(widget, widget_type);
	}

	public static bool GetAppPaintable(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_app_paintable(widget);
	}

	public static bool GetCanDefault(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_can_default(widget);
	}

	public static bool GetCanFocus(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_can_focus(widget);
	}

	public static T GetChildRequisition<T>(this T widget, out MentorLake.Gtk.GtkRequisition requisition) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_child_requisition(widget, out requisition);
		return widget;
	}

	public static bool GetChildVisible(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_child_visible(widget);
	}

	public static T GetClip<T>(this T widget, out MentorLake.Gtk.GtkAllocation clip) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_clip(widget, out clip);
		return widget;
	}

	public static MentorLake.Gtk.GtkClipboardHandle GetClipboard(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkAtom selection)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_clipboard(widget, selection);
	}

	public static string GetCompositeName(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_composite_name(widget);
	}

	public static bool GetDeviceEnabled(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_device_enabled(widget, device);
	}

	public static MentorLake.Gdk.GdkEventMask GetDeviceEvents(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkDeviceHandle device)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_device_events(widget, device);
	}

	public static MentorLake.Gtk.GtkTextDirection GetDirection(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_direction(widget);
	}

	public static MentorLake.Gdk.GdkDisplayHandle GetDisplay(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_display(widget);
	}

	public static bool GetDoubleBuffered(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_double_buffered(widget);
	}

	public static int GetEvents(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_events(widget);
	}

	public static bool GetFocusOnClick(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_focus_on_click(widget);
	}

	public static MentorLake.Pango.PangoFontMapHandle GetFontMap(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_font_map(widget);
	}

	public static MentorLake.cairo.cairo_font_options_tHandle GetFontOptions(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_font_options(widget);
	}

	public static MentorLake.Gdk.GdkFrameClockHandle GetFrameClock(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_frame_clock(widget);
	}

	public static MentorLake.Gtk.GtkAlign GetHalign(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_halign(widget);
	}

	public static bool GetHasTooltip(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_has_tooltip(widget);
	}

	public static bool GetHasWindow(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_has_window(widget);
	}

	public static bool GetHexpand(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_hexpand(widget);
	}

	public static bool GetHexpandSet(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_hexpand_set(widget);
	}

	public static bool GetMapped(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_mapped(widget);
	}

	public static int GetMarginBottom(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_margin_bottom(widget);
	}

	public static int GetMarginEnd(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_margin_end(widget);
	}

	public static int GetMarginLeft(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_margin_left(widget);
	}

	public static int GetMarginRight(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_margin_right(widget);
	}

	public static int GetMarginStart(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_margin_start(widget);
	}

	public static int GetMarginTop(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_margin_top(widget);
	}

	public static MentorLake.Gdk.GdkModifierType GetModifierMask(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkModifierIntent intent)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_modifier_mask(widget, intent);
	}

	public static MentorLake.Gtk.GtkRcStyleHandle GetModifierStyle(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_modifier_style(widget);
	}

	public static string GetName(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_name(widget);
	}

	public static bool GetNoShowAll(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_no_show_all(widget);
	}

	public static double GetOpacity(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_opacity(widget);
	}

	public static MentorLake.Pango.PangoContextHandle GetPangoContext(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_pango_context(widget);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetParent(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_parent(widget);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetParentWindow(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_parent_window(widget);
	}

	public static MentorLake.Gtk.GtkWidgetPathHandle GetPath(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_path(widget);
	}

	public static T GetPointer<T>(this T widget, out int x, out int y) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_pointer(widget, out x, out y);
		return widget;
	}

	public static T GetPreferredHeight<T>(this T widget, out int minimum_height, out int natural_height) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_preferred_height(widget, out minimum_height, out natural_height);
		return widget;
	}

	public static T GetPreferredHeightAndBaselineForWidth<T>(this T widget, int width, out int minimum_height, out int natural_height, out int minimum_baseline, out int natural_baseline) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_preferred_height_and_baseline_for_width(widget, width, out minimum_height, out natural_height, out minimum_baseline, out natural_baseline);
		return widget;
	}

	public static T GetPreferredHeightForWidth<T>(this T widget, int width, out int minimum_height, out int natural_height) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_preferred_height_for_width(widget, width, out minimum_height, out natural_height);
		return widget;
	}

	public static T GetPreferredSize<T>(this T widget, out MentorLake.Gtk.GtkRequisition minimum_size, out MentorLake.Gtk.GtkRequisition natural_size) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_preferred_size(widget, out minimum_size, out natural_size);
		return widget;
	}

	public static T GetPreferredWidth<T>(this T widget, out int minimum_width, out int natural_width) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_preferred_width(widget, out minimum_width, out natural_width);
		return widget;
	}

	public static T GetPreferredWidthForHeight<T>(this T widget, int height, out int minimum_width, out int natural_width) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_preferred_width_for_height(widget, height, out minimum_width, out natural_width);
		return widget;
	}

	public static bool GetRealized(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_realized(widget);
	}

	public static bool GetReceivesDefault(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_receives_default(widget);
	}

	public static MentorLake.Gtk.GtkSizeRequestMode GetRequestMode(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_request_mode(widget);
	}

	public static T GetRequisition<T>(this T widget, out MentorLake.Gtk.GtkRequisition requisition) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_requisition(widget, out requisition);
		return widget;
	}

	public static MentorLake.Gdk.GdkWindowHandle GetRootWindow(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_root_window(widget);
	}

	public static int GetScaleFactor(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_scale_factor(widget);
	}

	public static MentorLake.Gdk.GdkScreenHandle GetScreen(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_screen(widget);
	}

	public static bool GetSensitive(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_sensitive(widget);
	}

	public static MentorLake.Gtk.GtkSettingsHandle GetSettings(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_settings(widget);
	}

	public static T GetSizeRequest<T>(this T widget, out int width, out int height) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_get_size_request(widget, out width, out height);
		return widget;
	}

	public static MentorLake.Gtk.GtkStateType GetState(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_state(widget);
	}

	public static MentorLake.Gtk.GtkStateFlags GetStateFlags(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_state_flags(widget);
	}

	public static MentorLake.Gtk.GtkStyleHandle GetStyle(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_style(widget);
	}

	public static MentorLake.Gtk.GtkStyleContextHandle GetStyleContext(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_style_context(widget);
	}

	public static bool GetSupportMultidevice(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_support_multidevice(widget);
	}

	public static MentorLake.GObject.GObjectHandle GetTemplateChild(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.GObject.GType widget_type, string name)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_template_child(widget, widget_type, name);
	}

	public static string GetTooltipMarkup(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_tooltip_markup(widget);
	}

	public static string GetTooltipText(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_tooltip_text(widget);
	}

	public static MentorLake.Gtk.GtkWindowHandle GetTooltipWindow(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_tooltip_window(widget);
	}

	public static MentorLake.Gtk.GtkWidgetHandle GetToplevel(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_toplevel(widget);
	}

	public static MentorLake.Gtk.GtkAlign GetValign(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_valign(widget);
	}

	public static MentorLake.Gtk.GtkAlign GetValignWithBaseline(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_valign_with_baseline(widget);
	}

	public static bool GetVexpand(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_vexpand(widget);
	}

	public static bool GetVexpandSet(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_vexpand_set(widget);
	}

	public static bool GetVisible(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_visible(widget);
	}

	public static MentorLake.Gdk.GdkVisualHandle GetVisual(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_visual(widget);
	}

	public static MentorLake.Gdk.GdkWindowHandle GetWindow(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_get_window(widget);
	}

	public static T GrabAdd<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_grab_add(widget);
		return widget;
	}

	public static T GrabDefault<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_grab_default(widget);
		return widget;
	}

	public static T GrabFocus<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_grab_focus(widget);
		return widget;
	}

	public static T GrabRemove<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_grab_remove(widget);
		return widget;
	}

	public static bool HasDefault(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_has_default(widget);
	}

	public static bool HasFocus(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_has_focus(widget);
	}

	public static bool HasGrab(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_has_grab(widget);
	}

	public static bool HasRcStyle(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_has_rc_style(widget);
	}

	public static bool HasScreen(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_has_screen(widget);
	}

	public static bool HasVisibleFocus(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_has_visible_focus(widget);
	}

	public static T Hide<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_hide(widget);
		return widget;
	}

	public static bool HideOnDelete(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_hide_on_delete(widget);
	}

	public static bool InDestruction(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_in_destruction(widget);
	}

	public static T InitTemplate<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_init_template(widget);
		return widget;
	}

	public static T InputShapeCombineRegion<T>(this T widget, MentorLake.cairo.cairo_region_tHandle region) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_input_shape_combine_region(widget, region);
		return widget;
	}

	public static T InsertActionGroup<T>(this T widget, string name, MentorLake.Gio.GActionGroupHandle group) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_insert_action_group(widget, name, group);
		return widget;
	}

	public static bool Intersect(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkRectangleHandle area, out MentorLake.Gdk.GdkRectangle intersection)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_intersect(widget, area, out intersection);
	}

	public static bool IsAncestor(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkWidgetHandle ancestor)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_is_ancestor(widget, ancestor);
	}

	public static bool IsComposited(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_is_composited(widget);
	}

	public static bool IsDrawable(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_is_drawable(widget);
	}

	public static bool IsFocus(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_is_focus(widget);
	}

	public static bool IsSensitive(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_is_sensitive(widget);
	}

	public static bool IsToplevel(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_is_toplevel(widget);
	}

	public static bool IsVisible(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_is_visible(widget);
	}

	public static bool KeynavFailed(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkDirectionType direction)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_keynav_failed(widget, direction);
	}

	public static MentorLake.GLib.GListHandle ListAccelClosures(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_list_accel_closures(widget);
	}

	public static string[] ListActionPrefixes(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_list_action_prefixes(widget);
	}

	public static MentorLake.GLib.GListHandle ListMnemonicLabels(this MentorLake.Gtk.GtkWidgetHandle widget)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_list_mnemonic_labels(widget);
	}

	public static T Map<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_map(widget);
		return widget;
	}

	public static bool MnemonicActivate(this MentorLake.Gtk.GtkWidgetHandle widget, bool group_cycling)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_mnemonic_activate(widget, group_cycling);
	}

	public static T ModifyBase<T>(this T widget, MentorLake.Gtk.GtkStateType state, MentorLake.Gdk.GdkColorHandle color) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_modify_base(widget, state, color);
		return widget;
	}

	public static T ModifyBg<T>(this T widget, MentorLake.Gtk.GtkStateType state, MentorLake.Gdk.GdkColorHandle color) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_modify_bg(widget, state, color);
		return widget;
	}

	public static T ModifyCursor<T>(this T widget, MentorLake.Gdk.GdkColorHandle primary, MentorLake.Gdk.GdkColorHandle secondary) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_modify_cursor(widget, primary, secondary);
		return widget;
	}

	public static T ModifyFg<T>(this T widget, MentorLake.Gtk.GtkStateType state, MentorLake.Gdk.GdkColorHandle color) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_modify_fg(widget, state, color);
		return widget;
	}

	public static T ModifyFont<T>(this T widget, MentorLake.Pango.PangoFontDescriptionHandle font_desc) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_modify_font(widget, font_desc);
		return widget;
	}

	public static T ModifyStyle<T>(this T widget, MentorLake.Gtk.GtkRcStyleHandle style) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_modify_style(widget, style);
		return widget;
	}

	public static T ModifyText<T>(this T widget, MentorLake.Gtk.GtkStateType state, MentorLake.Gdk.GdkColorHandle color) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_modify_text(widget, state, color);
		return widget;
	}

	public static T OverrideBackgroundColor<T>(this T widget, MentorLake.Gtk.GtkStateFlags state, MentorLake.Gdk.GdkRGBAHandle color) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_override_background_color(widget, state, color);
		return widget;
	}

	public static T OverrideColor<T>(this T widget, MentorLake.Gtk.GtkStateFlags state, MentorLake.Gdk.GdkRGBAHandle color) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_override_color(widget, state, color);
		return widget;
	}

	public static T OverrideCursor<T>(this T widget, MentorLake.Gdk.GdkRGBAHandle cursor, MentorLake.Gdk.GdkRGBAHandle secondary_cursor) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_override_cursor(widget, cursor, secondary_cursor);
		return widget;
	}

	public static T OverrideFont<T>(this T widget, MentorLake.Pango.PangoFontDescriptionHandle font_desc) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_override_font(widget, font_desc);
		return widget;
	}

	public static T OverrideSymbolicColor<T>(this T widget, string name, MentorLake.Gdk.GdkRGBAHandle color) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_override_symbolic_color(widget, name, color);
		return widget;
	}

	public static T Path<T>(this T widget, out uint path_length, out string path, out string path_reversed) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_path(widget, out path_length, out path, out path_reversed);
		return widget;
	}

	public static T QueueAllocate<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_queue_allocate(widget);
		return widget;
	}

	public static T QueueComputeExpand<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_queue_compute_expand(widget);
		return widget;
	}

	public static T QueueDraw<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_queue_draw(widget);
		return widget;
	}

	public static T QueueDrawArea<T>(this T widget, int x, int y, int width, int height) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_queue_draw_area(widget, x, y, width, height);
		return widget;
	}

	public static T QueueDrawRegion<T>(this T widget, MentorLake.cairo.cairo_region_tHandle region) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_queue_draw_region(widget, region);
		return widget;
	}

	public static T QueueResize<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_queue_resize(widget);
		return widget;
	}

	public static T QueueResizeNoRedraw<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_queue_resize_no_redraw(widget);
		return widget;
	}

	public static T Realize<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_realize(widget);
		return widget;
	}

	public static MentorLake.cairo.cairo_region_tHandle RegionIntersect(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.cairo.cairo_region_tHandle region)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_region_intersect(widget, region);
	}

	public static T RegisterWindow<T>(this T widget, MentorLake.Gdk.GdkWindowHandle window) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_register_window(widget, window);
		return widget;
	}

	public static bool RemoveAccelerator(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkAccelGroupHandle accel_group, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_remove_accelerator(widget, accel_group, accel_key, accel_mods);
	}

	public static T RemoveMnemonicLabel<T>(this T widget, MentorLake.Gtk.GtkWidgetHandle label) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_remove_mnemonic_label(widget, label);
		return widget;
	}

	public static T RemoveTickCallback<T>(this T widget, uint id) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_remove_tick_callback(widget, id);
		return widget;
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle RenderIcon(this MentorLake.Gtk.GtkWidgetHandle widget, string stock_id, MentorLake.Gtk.GtkIconSize size, string detail)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_render_icon(widget, stock_id, size, detail);
	}

	public static MentorLake.GdkPixbuf.GdkPixbufHandle RenderIconPixbuf(this MentorLake.Gtk.GtkWidgetHandle widget, string stock_id, MentorLake.Gtk.GtkIconSize size)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_render_icon_pixbuf(widget, stock_id, size);
	}

	public static T Reparent<T>(this T widget, MentorLake.Gtk.GtkWidgetHandle new_parent) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_reparent(widget, new_parent);
		return widget;
	}

	public static T ResetRcStyles<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_reset_rc_styles(widget);
		return widget;
	}

	public static T ResetStyle<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_reset_style(widget);
		return widget;
	}

	public static int SendExpose(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkEventHandle @event)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_send_expose(widget, @event);
	}

	public static bool SendFocusChange(this MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkEventHandle @event)
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_send_focus_change(widget, @event);
	}

	public static T SetAccelPath<T>(this T widget, string accel_path, MentorLake.Gtk.GtkAccelGroupHandle accel_group) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_accel_path(widget, accel_path, accel_group);
		return widget;
	}

	public static T SetAllocation<T>(this T widget, MentorLake.Gtk.GtkAllocationHandle allocation) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_allocation(widget, allocation);
		return widget;
	}

	public static T SetAppPaintable<T>(this T widget, bool app_paintable) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_app_paintable(widget, app_paintable);
		return widget;
	}

	public static T SetCanDefault<T>(this T widget, bool can_default) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_can_default(widget, can_default);
		return widget;
	}

	public static T SetCanFocus<T>(this T widget, bool can_focus) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_can_focus(widget, can_focus);
		return widget;
	}

	public static T SetChildVisible<T>(this T widget, bool is_visible) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_child_visible(widget, is_visible);
		return widget;
	}

	public static T SetClip<T>(this T widget, MentorLake.Gtk.GtkAllocationHandle clip) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_clip(widget, clip);
		return widget;
	}

	public static T SetCompositeName<T>(this T widget, string name) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_composite_name(widget, name);
		return widget;
	}

	public static T SetDeviceEnabled<T>(this T widget, MentorLake.Gdk.GdkDeviceHandle device, bool enabled) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_device_enabled(widget, device, enabled);
		return widget;
	}

	public static T SetDeviceEvents<T>(this T widget, MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gdk.GdkEventMask events) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_device_events(widget, device, events);
		return widget;
	}

	public static T SetDirection<T>(this T widget, MentorLake.Gtk.GtkTextDirection dir) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_direction(widget, dir);
		return widget;
	}

	public static T SetDoubleBuffered<T>(this T widget, bool double_buffered) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_double_buffered(widget, double_buffered);
		return widget;
	}

	public static T SetEvents<T>(this T widget, int events) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_events(widget, events);
		return widget;
	}

	public static T SetFocusOnClick<T>(this T widget, bool focus_on_click) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_focus_on_click(widget, focus_on_click);
		return widget;
	}

	public static T SetFontMap<T>(this T widget, MentorLake.Pango.PangoFontMapHandle font_map) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_font_map(widget, font_map);
		return widget;
	}

	public static T SetFontOptions<T>(this T widget, MentorLake.cairo.cairo_font_options_tHandle options) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_font_options(widget, options);
		return widget;
	}

	public static T SetHalign<T>(this T widget, MentorLake.Gtk.GtkAlign align) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_halign(widget, align);
		return widget;
	}

	public static T SetHasTooltip<T>(this T widget, bool has_tooltip) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_has_tooltip(widget, has_tooltip);
		return widget;
	}

	public static T SetHasWindow<T>(this T widget, bool has_window) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_has_window(widget, has_window);
		return widget;
	}

	public static T SetHexpand<T>(this T widget, bool expand) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_hexpand(widget, expand);
		return widget;
	}

	public static T SetHexpandSet<T>(this T widget, bool set) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_hexpand_set(widget, set);
		return widget;
	}

	public static T SetMapped<T>(this T widget, bool mapped) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_mapped(widget, mapped);
		return widget;
	}

	public static T SetMarginBottom<T>(this T widget, int margin) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_margin_bottom(widget, margin);
		return widget;
	}

	public static T SetMarginEnd<T>(this T widget, int margin) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_margin_end(widget, margin);
		return widget;
	}

	public static T SetMarginLeft<T>(this T widget, int margin) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_margin_left(widget, margin);
		return widget;
	}

	public static T SetMarginRight<T>(this T widget, int margin) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_margin_right(widget, margin);
		return widget;
	}

	public static T SetMarginStart<T>(this T widget, int margin) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_margin_start(widget, margin);
		return widget;
	}

	public static T SetMarginTop<T>(this T widget, int margin) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_margin_top(widget, margin);
		return widget;
	}

	public static T SetName<T>(this T widget, string name) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_name(widget, name);
		return widget;
	}

	public static T SetNoShowAll<T>(this T widget, bool no_show_all) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_no_show_all(widget, no_show_all);
		return widget;
	}

	public static T SetOpacity<T>(this T widget, double opacity) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_opacity(widget, opacity);
		return widget;
	}

	public static T SetParent<T>(this T widget, MentorLake.Gtk.GtkWidgetHandle parent) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_parent(widget, parent);
		return widget;
	}

	public static T SetParentWindow<T>(this T widget, MentorLake.Gdk.GdkWindowHandle parent_window) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_parent_window(widget, parent_window);
		return widget;
	}

	public static T SetRealized<T>(this T widget, bool realized) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_realized(widget, realized);
		return widget;
	}

	public static T SetReceivesDefault<T>(this T widget, bool receives_default) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_receives_default(widget, receives_default);
		return widget;
	}

	public static T SetRedrawOnAllocate<T>(this T widget, bool redraw_on_allocate) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_redraw_on_allocate(widget, redraw_on_allocate);
		return widget;
	}

	public static T SetSensitive<T>(this T widget, bool sensitive) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_sensitive(widget, sensitive);
		return widget;
	}

	public static T SetSizeRequest<T>(this T widget, int width, int height) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_size_request(widget, width, height);
		return widget;
	}

	public static T SetState<T>(this T widget, MentorLake.Gtk.GtkStateType state) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_state(widget, state);
		return widget;
	}

	public static T SetStateFlags<T>(this T widget, MentorLake.Gtk.GtkStateFlags flags, bool clear) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_state_flags(widget, flags, clear);
		return widget;
	}

	public static T SetStyle<T>(this T widget, MentorLake.Gtk.GtkStyleHandle style) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_style(widget, style);
		return widget;
	}

	public static T SetSupportMultidevice<T>(this T widget, bool support_multidevice) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_support_multidevice(widget, support_multidevice);
		return widget;
	}

	public static T SetTooltipMarkup<T>(this T widget, string markup) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_tooltip_markup(widget, markup);
		return widget;
	}

	public static T SetTooltipText<T>(this T widget, string text) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_tooltip_text(widget, text);
		return widget;
	}

	public static T SetTooltipWindow<T>(this T widget, MentorLake.Gtk.GtkWindowHandle custom_window) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_tooltip_window(widget, custom_window);
		return widget;
	}

	public static T SetValign<T>(this T widget, MentorLake.Gtk.GtkAlign align) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_valign(widget, align);
		return widget;
	}

	public static T SetVexpand<T>(this T widget, bool expand) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_vexpand(widget, expand);
		return widget;
	}

	public static T SetVexpandSet<T>(this T widget, bool set) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_vexpand_set(widget, set);
		return widget;
	}

	public static T SetVisible<T>(this T widget, bool visible) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_visible(widget, visible);
		return widget;
	}

	public static T SetVisual<T>(this T widget, MentorLake.Gdk.GdkVisualHandle visual) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_visual(widget, visual);
		return widget;
	}

	public static T SetWindow<T>(this T widget, MentorLake.Gdk.GdkWindowHandle window) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_set_window(widget, window);
		return widget;
	}

	public static T ShapeCombineRegion<T>(this T widget, MentorLake.cairo.cairo_region_tHandle region) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_shape_combine_region(widget, region);
		return widget;
	}

	public static T Show<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_show(widget);
		return widget;
	}

	public static T ShowAll<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_show_all(widget);
		return widget;
	}

	public static T ShowNow<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_show_now(widget);
		return widget;
	}

	public static T SizeAllocate<T>(this T widget, MentorLake.Gtk.GtkAllocationHandle allocation) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_size_allocate(widget, allocation);
		return widget;
	}

	public static T SizeAllocateWithBaseline<T>(this T widget, MentorLake.Gtk.GtkAllocationHandle allocation, int baseline) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_size_allocate_with_baseline(widget, allocation, baseline);
		return widget;
	}

	public static T SizeRequest<T>(this T widget, out MentorLake.Gtk.GtkRequisition requisition) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_size_request(widget, out requisition);
		return widget;
	}

	public static T StyleAttach<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_style_attach(widget);
		return widget;
	}

	public static T StyleGet<T>(this T widget, string first_property_name, IntPtr @__arglist) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_style_get(widget, first_property_name, @__arglist);
		return widget;
	}

	public static T StyleGetProperty<T>(this T widget, string property_name, out MentorLake.GObject.GValue value) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_style_get_property(widget, property_name, out value);
		return widget;
	}

	public static T StyleGetValist<T>(this T widget, string first_property_name, IntPtr var_args) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_style_get_valist(widget, first_property_name, var_args);
		return widget;
	}

	public static T ThawChildNotify<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_thaw_child_notify(widget);
		return widget;
	}

	public static bool TranslateCoordinates(this MentorLake.Gtk.GtkWidgetHandle src_widget, MentorLake.Gtk.GtkWidgetHandle dest_widget, int src_x, int src_y, out int dest_x, out int dest_y)
	{
		if (src_widget.IsInvalid || src_widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		return GtkWidgetHandleExterns.gtk_widget_translate_coordinates(src_widget, dest_widget, src_x, src_y, out dest_x, out dest_y);
	}

	public static T TriggerTooltipQuery<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_trigger_tooltip_query(widget);
		return widget;
	}

	public static T Unmap<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_unmap(widget);
		return widget;
	}

	public static T Unparent<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_unparent(widget);
		return widget;
	}

	public static T Unrealize<T>(this T widget) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_unrealize(widget);
		return widget;
	}

	public static T UnregisterWindow<T>(this T widget, MentorLake.Gdk.GdkWindowHandle window) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_unregister_window(widget, window);
		return widget;
	}

	public static T UnsetStateFlags<T>(this T widget, MentorLake.Gtk.GtkStateFlags flags) where T : GtkWidgetHandle
	{
		if (widget.IsInvalid || widget.IsClosed) throw new Exception("Invalid or closed handle (GtkWidgetHandle)");
		GtkWidgetHandleExterns.gtk_widget_unset_state_flags(widget, flags);
		return widget;
	}

}

internal class GtkWidgetHandleExterns
{
	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_widget_new(MentorLake.GObject.GType type, string first_property_name, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_add_accelerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string accel_signal, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods, MentorLake.Gtk.GtkAccelFlags accel_flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_add_device_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gdk.GdkEventMask events);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_add_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int events);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_add_mnemonic_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern uint gtk_widget_add_tick_callback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkTickCallback callback, IntPtr user_data, MentorLake.GLib.GDestroyNotify notify);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_can_activate_accel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, uint signal_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_child_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkDirectionType direction);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_child_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string child_property);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_class_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out uint path_length, out string path, out string path_reversed);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_compute_expand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkOrientation orientation);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoContextHandle gtk_widget_create_pango_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoLayoutHandle gtk_widget_create_pango_layout([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_destroyed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] ref MentorLake.Gtk.GtkWidgetHandle widget_pointer);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_device_is_shadowed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDragContextHandle gtk_drag_begin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle targets, MentorLake.Gdk.GdkDragAction actions, int button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDragContextHandle gtk_drag_begin_with_coordinates([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle targets, MentorLake.Gdk.GdkDragAction actions, int button, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event, int x, int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_drag_check_threshold([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int start_x, int start_y, int current_x, int current_y);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_dest_add_image_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_dest_add_text_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_dest_add_uri_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkAtom gtk_drag_dest_find_target([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle target_list);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTargetListHandle gtk_drag_dest_get_target_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_drag_dest_get_track_motion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_dest_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkDestDefaults flags, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets, MentorLake.Gdk.GdkDragAction actions);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_dest_set_proxy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle proxy_window, MentorLake.Gdk.GdkDragProtocol protocol, bool use_coordinates);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_dest_set_target_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle target_list);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_dest_set_track_motion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool track_motion);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_dest_unset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_get_data([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDragContextHandle>))] MentorLake.Gdk.GdkDragContextHandle context, MentorLake.Gdk.GdkAtom target, uint time_);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_highlight([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_source_add_image_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_source_add_text_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_source_add_uri_targets([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTargetListHandle gtk_drag_source_get_target_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_source_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkModifierType start_button_mask, MentorLake.Gtk.GtkTargetEntry[] targets, int n_targets, MentorLake.Gdk.GdkDragAction actions);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_source_set_icon_gicon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GIconHandleImpl>))] MentorLake.Gio.GIconHandle icon);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_source_set_icon_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string icon_name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_source_set_icon_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.GdkPixbuf.GdkPixbufHandle>))] MentorLake.GdkPixbuf.GdkPixbufHandle pixbuf);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_source_set_icon_stock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string stock_id);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_source_set_target_list([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkTargetListHandle>))] MentorLake.Gtk.GtkTargetListHandle target_list);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_source_unset([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_drag_unhighlight([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_draw([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_tHandle>))] MentorLake.cairo.cairo_tHandle cr);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_ensure_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_error_bell([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_freeze_child_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Atk.AtkObjectHandle gtk_widget_get_accessible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gio.GActionGroupHandle gtk_widget_get_action_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string prefix);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_get_allocated_baseline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_get_allocated_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_allocated_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out MentorLake.Gtk.GtkAllocation allocation, out int baseline);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_get_allocated_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_allocation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out MentorLake.Gtk.GtkAllocation allocation);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_widget_get_ancestor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.GObject.GType widget_type);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_app_paintable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_can_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_can_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_child_requisition([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out MentorLake.Gtk.GtkRequisition requisition);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_child_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_clip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out MentorLake.Gtk.GtkAllocation clip);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkClipboardHandle gtk_widget_get_clipboard([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkAtom selection);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_widget_get_composite_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_device_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkEventMask gtk_widget_get_device_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTextDirection gtk_widget_get_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkDisplayHandle gtk_widget_get_display([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_double_buffered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_get_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_focus_on_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoFontMapHandle gtk_widget_get_font_map([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_font_options_tHandle gtk_widget_get_font_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkFrameClockHandle gtk_widget_get_frame_clock([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAlign gtk_widget_get_halign([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_has_tooltip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_has_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_hexpand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_hexpand_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_mapped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_get_margin_bottom([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_get_margin_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_get_margin_left([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_get_margin_right([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_get_margin_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_get_margin_top([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkModifierType gtk_widget_get_modifier_mask([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gdk.GdkModifierIntent intent);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkRcStyleHandle gtk_widget_get_modifier_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_widget_get_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_no_show_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern double gtk_widget_get_opacity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Pango.PangoContextHandle gtk_widget_get_pango_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_widget_get_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkWindowHandle gtk_widget_get_parent_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetPathHandle gtk_widget_get_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_pointer([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out int x, out int y);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_preferred_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out int minimum_height, out int natural_height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_preferred_height_and_baseline_for_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height, out int minimum_baseline, out int natural_baseline);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_preferred_height_for_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_preferred_size([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out MentorLake.Gtk.GtkRequisition minimum_size, out MentorLake.Gtk.GtkRequisition natural_size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_preferred_width([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out int minimum_width, out int natural_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_preferred_width_for_height([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int height, out int minimum_width, out int natural_width);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_realized([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_receives_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSizeRequestMode gtk_widget_get_request_mode([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_requisition([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out MentorLake.Gtk.GtkRequisition requisition);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkWindowHandle gtk_widget_get_root_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_get_scale_factor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkScreenHandle gtk_widget_get_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkSettingsHandle gtk_widget_get_settings([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_get_size_request([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out int width, out int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStateType gtk_widget_get_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStateFlags gtk_widget_get_state_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStyleHandle gtk_widget_get_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStyleContextHandle gtk_widget_get_style_context([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_support_multidevice([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GObject.GObjectHandle gtk_widget_get_template_child([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.GObject.GType widget_type, string name);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_widget_get_tooltip_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_widget_get_tooltip_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWindowHandle gtk_widget_get_tooltip_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkWidgetHandle gtk_widget_get_toplevel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAlign gtk_widget_get_valign([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkAlign gtk_widget_get_valign_with_baseline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_vexpand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_vexpand_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_get_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkVisualHandle gtk_widget_get_visual([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gdk.GdkWindowHandle gtk_widget_get_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_grab_add([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_grab_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_grab_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_grab_remove([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_has_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_has_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_has_grab([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_has_rc_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_has_screen([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_has_visible_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_hide([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_hide_on_delete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_in_destruction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_init_template([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_input_shape_combine_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_insert_action_group([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gio.GActionGroupHandleImpl>))] MentorLake.Gio.GActionGroupHandle group);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_intersect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRectangleHandle>))] MentorLake.Gdk.GdkRectangleHandle area, out MentorLake.Gdk.GdkRectangle intersection);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_is_ancestor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle ancestor);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_is_composited([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_is_drawable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_is_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_is_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_is_toplevel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_is_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_keynav_failed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkDirectionType direction);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle gtk_widget_list_accel_closures([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(ReadNullTerminatedArrayMarshaller<NoNativeFreeStringMarshaller, string>))]
	internal static extern string[] gtk_widget_list_action_prefixes([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GLib.GListHandle gtk_widget_list_mnemonic_labels([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_map([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_mnemonic_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool group_cycling);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_modify_base([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkStateType state, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_modify_bg([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkStateType state, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_modify_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle primary, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle secondary);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_modify_fg([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkStateType state, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_modify_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle font_desc);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_modify_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkRcStyleHandle>))] MentorLake.Gtk.GtkRcStyleHandle style);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_modify_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkStateType state, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkColorHandle>))] MentorLake.Gdk.GdkColorHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_override_background_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkStateFlags state, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_override_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkStateFlags state, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_override_cursor([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle cursor, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle secondary_cursor);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_override_font([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontDescriptionHandle>))] MentorLake.Pango.PangoFontDescriptionHandle font_desc);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_override_symbolic_color([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string name, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkRGBAHandle>))] MentorLake.Gdk.GdkRGBAHandle color);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out uint path_length, out string path, out string path_reversed);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_queue_allocate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_queue_compute_expand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_queue_draw([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_queue_draw_area([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int x, int y, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_queue_draw_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_queue_resize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_queue_resize_no_redraw([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_realize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.cairo.cairo_region_tHandle gtk_widget_region_intersect([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_register_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_remove_accelerator([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group, uint accel_key, MentorLake.Gdk.GdkModifierType accel_mods);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_remove_mnemonic_label([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle label);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_remove_tick_callback([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, uint id);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_widget_render_icon([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string stock_id, MentorLake.Gtk.GtkIconSize size, string detail);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.GdkPixbuf.GdkPixbufHandle gtk_widget_render_icon_pixbuf([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string stock_id, MentorLake.Gtk.GtkIconSize size);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_reparent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle new_parent);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_reset_rc_styles([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_reset_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern int gtk_widget_send_expose([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_send_focus_change([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkEventHandle>))] MentorLake.Gdk.GdkEventHandle @event);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_accel_path([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string accel_path, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAccelGroupHandle>))] MentorLake.Gtk.GtkAccelGroupHandle accel_group);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_allocation([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAllocationHandle>))] MentorLake.Gtk.GtkAllocationHandle allocation);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_app_paintable([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool app_paintable);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_can_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool can_default);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_can_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool can_focus);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_child_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool is_visible);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_clip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAllocationHandle>))] MentorLake.Gtk.GtkAllocationHandle clip);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_composite_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_device_enabled([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, bool enabled);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_device_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkDeviceHandle>))] MentorLake.Gdk.GdkDeviceHandle device, MentorLake.Gdk.GdkEventMask events);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_direction([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkTextDirection dir);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_double_buffered([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool double_buffered);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_events([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int events);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_focus_on_click([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool focus_on_click);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_font_map([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Pango.PangoFontMapHandle>))] MentorLake.Pango.PangoFontMapHandle font_map);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_font_options([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_font_options_tHandle>))] MentorLake.cairo.cairo_font_options_tHandle options);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_halign([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkAlign align);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_has_tooltip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool has_tooltip);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_has_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool has_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_hexpand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool expand);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_hexpand_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool set);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_mapped([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool mapped);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_margin_bottom([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int margin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_margin_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int margin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_margin_left([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int margin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_margin_right([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int margin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_margin_start([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int margin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_margin_top([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int margin);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_name([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string name);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_no_show_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool no_show_all);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_opacity([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, double opacity);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_parent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle parent);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_parent_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle parent_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_realized([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool realized);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_receives_default([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool receives_default);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_redraw_on_allocate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool redraw_on_allocate);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_sensitive([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool sensitive);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_size_request([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, int width, int height);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_state([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkStateType state);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_state_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkStateFlags flags, bool clear);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_style([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkStyleHandle>))] MentorLake.Gtk.GtkStyleHandle style);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_support_multidevice([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool support_multidevice);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_tooltip_markup([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string markup);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_tooltip_text([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string text);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_tooltip_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWindowHandle>))] MentorLake.Gtk.GtkWindowHandle custom_window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_valign([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkAlign align);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_vexpand([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool expand);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_vexpand_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool set);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_visible([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, bool visible);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_visual([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkVisualHandle>))] MentorLake.Gdk.GdkVisualHandle visual);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_shape_combine_region([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.cairo.cairo_region_tHandle>))] MentorLake.cairo.cairo_region_tHandle region);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_show([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_show_all([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_show_now([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_size_allocate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAllocationHandle>))] MentorLake.Gtk.GtkAllocationHandle allocation);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_size_allocate_with_baseline([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkAllocationHandle>))] MentorLake.Gtk.GtkAllocationHandle allocation, int baseline);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_size_request([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, out MentorLake.Gtk.GtkRequisition requisition);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_style_attach([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_style_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string first_property_name, IntPtr @__arglist);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_style_get_property([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string property_name, out MentorLake.GObject.GValue value);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_style_get_valist([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, string first_property_name, IntPtr var_args);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_thaw_child_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern bool gtk_widget_translate_coordinates([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle src_widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle dest_widget, int src_x, int src_y, out int dest_x, out int dest_y);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_trigger_tooltip_query([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_unmap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_unparent([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_unrealize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_unregister_window([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gdk.GdkWindowHandle>))] MentorLake.Gdk.GdkWindowHandle window);

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_unset_state_flags([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<MentorLake.Gtk.GtkWidgetHandle>))] MentorLake.Gtk.GtkWidgetHandle widget, MentorLake.Gtk.GtkStateFlags flags);

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkTextDirection gtk_widget_get_default_direction();

	[DllImport(GtkLibrary.Name)]
	internal static extern MentorLake.Gtk.GtkStyleHandle gtk_widget_get_default_style();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_pop_composite_child();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_push_composite_child();

	[DllImport(GtkLibrary.Name)]
	internal static extern void gtk_widget_set_default_direction(MentorLake.Gtk.GtkTextDirection dir);

}
