namespace MentorLake.Gtk3.Gtk3;

public class GtkWidgetHandle : GInitiallyUnownedHandle, AtkImplementorIfaceHandle, GtkBuildableHandle
{
	public static GtkWidgetHandle New(GType type, string first_property_name, IntPtr @__arglist)
	{
		return GtkWidgetExterns.gtk_widget_new(type, first_property_name, @__arglist);
	}

	public static GtkTextDirection GetDefaultDirection()
	{
		return GtkWidgetExterns.gtk_widget_get_default_direction();
	}

	public static GtkStyleHandle GetDefaultStyle()
	{
		return GtkWidgetExterns.gtk_widget_get_default_style();
	}

	public static void PopCompositeChild()
	{
		GtkWidgetExterns.gtk_widget_pop_composite_child();
	}

	public static void PushCompositeChild()
	{
		GtkWidgetExterns.gtk_widget_push_composite_child();
	}

	public static void SetDefaultDirection(GtkTextDirection dir)
	{
		GtkWidgetExterns.gtk_widget_set_default_direction(dir);
	}

}

public static class GtkWidgetSignalExtensions
{

	public static IObservable<GtkWidgetSignalStructs.AccelClosuresChangedSignal> Signal_AccelClosuresChanged(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.AccelClosuresChangedSignal> obs) =>
		{
			GtkWidgetSignalDelegates.accel_closures_changed handler = (GtkWidgetHandle self, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.AccelClosuresChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "accel_closures_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.ButtonPressEventSignal> Signal_ButtonPressEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.ButtonPressEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.button_press_event handler = (GtkWidgetHandle self, GdkEventButton @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.ButtonPressEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "button_press_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.ButtonReleaseEventSignal> Signal_ButtonReleaseEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.ButtonReleaseEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.button_release_event handler = (GtkWidgetHandle self, GdkEventButton @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.ButtonReleaseEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "button_release_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.CanActivateAccelSignal> Signal_CanActivateAccel(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.CanActivateAccelSignal> obs) =>
		{
			GtkWidgetSignalDelegates.can_activate_accel handler = (GtkWidgetHandle self, uint signal_id, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.CanActivateAccelSignal()
				{
					Self = self, SignalId = signal_id, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "can_activate_accel", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.ChildNotifySignal> Signal_ChildNotify(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.ChildNotifySignal> obs) =>
		{
			GtkWidgetSignalDelegates.child_notify handler = (GtkWidgetHandle self, GParamSpecHandle child_property, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.ChildNotifySignal()
				{
					Self = self, ChildProperty = child_property, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "child_notify", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.CompositedChangedSignal> Signal_CompositedChanged(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.CompositedChangedSignal> obs) =>
		{
			GtkWidgetSignalDelegates.composited_changed handler = (GtkWidgetHandle self, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.CompositedChangedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "composited_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.ConfigureEventSignal> Signal_ConfigureEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.ConfigureEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.configure_event handler = (GtkWidgetHandle self, GdkEventConfigure @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.ConfigureEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "configure_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.DamageEventSignal> Signal_DamageEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.DamageEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.damage_event handler = (GtkWidgetHandle self, GdkEventExpose @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.DamageEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "damage_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.DeleteEventSignal> Signal_DeleteEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.DeleteEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.delete_event handler = (GtkWidgetHandle self, GdkEventHandle @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.DeleteEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "delete_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.DestroySignal> Signal_Destroy(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.DestroySignal> obs) =>
		{
			GtkWidgetSignalDelegates.destroy handler = (GtkWidgetHandle self, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.DestroySignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "destroy", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.DestroyEventSignal> Signal_DestroyEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.DestroyEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.destroy_event handler = (GtkWidgetHandle self, GdkEventHandle @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.DestroyEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "destroy_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.DirectionChangedSignal> Signal_DirectionChanged(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.DirectionChangedSignal> obs) =>
		{
			GtkWidgetSignalDelegates.direction_changed handler = (GtkWidgetHandle self, GtkTextDirection previous_direction, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.DirectionChangedSignal()
				{
					Self = self, PreviousDirection = previous_direction, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "direction_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.DragBeginSignal> Signal_DragBegin(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.DragBeginSignal> obs) =>
		{
			GtkWidgetSignalDelegates.drag_begin handler = (GtkWidgetHandle self, GdkDragContextHandle context, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.DragBeginSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drag_begin", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.DragDataDeleteSignal> Signal_DragDataDelete(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.DragDataDeleteSignal> obs) =>
		{
			GtkWidgetSignalDelegates.drag_data_delete handler = (GtkWidgetHandle self, GdkDragContextHandle context, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.DragDataDeleteSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drag_data_delete", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.DragDataGetSignal> Signal_DragDataGet(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.DragDataGetSignal> obs) =>
		{
			GtkWidgetSignalDelegates.drag_data_get handler = (GtkWidgetHandle self, GdkDragContextHandle context, GtkSelectionDataHandle data, uint info, uint time, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.DragDataGetSignal()
				{
					Self = self, Context = context, Data = data, Info = info, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drag_data_get", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.DragDataReceivedSignal> Signal_DragDataReceived(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.DragDataReceivedSignal> obs) =>
		{
			GtkWidgetSignalDelegates.drag_data_received handler = (GtkWidgetHandle self, GdkDragContextHandle context, int x, int y, GtkSelectionDataHandle data, uint info, uint time, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.DragDataReceivedSignal()
				{
					Self = self, Context = context, X = x, Y = y, Data = data, Info = info, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drag_data_received", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.DragDropSignal> Signal_DragDrop(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.DragDropSignal> obs) =>
		{
			GtkWidgetSignalDelegates.drag_drop handler = (GtkWidgetHandle self, GdkDragContextHandle context, int x, int y, uint time, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.DragDropSignal()
				{
					Self = self, Context = context, X = x, Y = y, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drag_drop", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.DragEndSignal> Signal_DragEnd(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.DragEndSignal> obs) =>
		{
			GtkWidgetSignalDelegates.drag_end handler = (GtkWidgetHandle self, GdkDragContextHandle context, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.DragEndSignal()
				{
					Self = self, Context = context, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drag_end", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.DragFailedSignal> Signal_DragFailed(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.DragFailedSignal> obs) =>
		{
			GtkWidgetSignalDelegates.drag_failed handler = (GtkWidgetHandle self, GdkDragContextHandle context, GtkDragResult result, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.DragFailedSignal()
				{
					Self = self, Context = context, Result = result, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drag_failed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.DragLeaveSignal> Signal_DragLeave(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.DragLeaveSignal> obs) =>
		{
			GtkWidgetSignalDelegates.drag_leave handler = (GtkWidgetHandle self, GdkDragContextHandle context, uint time, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.DragLeaveSignal()
				{
					Self = self, Context = context, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drag_leave", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.DragMotionSignal> Signal_DragMotion(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.DragMotionSignal> obs) =>
		{
			GtkWidgetSignalDelegates.drag_motion handler = (GtkWidgetHandle self, GdkDragContextHandle context, int x, int y, uint time, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.DragMotionSignal()
				{
					Self = self, Context = context, X = x, Y = y, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "drag_motion", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.DrawSignal> Signal_Draw(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.DrawSignal> obs) =>
		{
			GtkWidgetSignalDelegates.draw handler = (GtkWidgetHandle self, cairo_tHandle cr, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.DrawSignal()
				{
					Self = self, Cr = cr, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "draw", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.EnterNotifyEventSignal> Signal_EnterNotifyEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.EnterNotifyEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.enter_notify_event handler = (GtkWidgetHandle self, GdkEventCrossing @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.EnterNotifyEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "enter_notify_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.EventSignal> Signal_Event(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.EventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.@event handler = (GtkWidgetHandle self, GdkEventHandle @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.EventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.EventAfterSignal> Signal_EventAfter(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.EventAfterSignal> obs) =>
		{
			GtkWidgetSignalDelegates.event_after handler = (GtkWidgetHandle self, GdkEventHandle @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.EventAfterSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "event_after", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.FocusSignal> Signal_Focus(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.FocusSignal> obs) =>
		{
			GtkWidgetSignalDelegates.focus handler = (GtkWidgetHandle self, GtkDirectionType direction, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.FocusSignal()
				{
					Self = self, Direction = direction, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.FocusInEventSignal> Signal_FocusInEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.FocusInEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.focus_in_event handler = (GtkWidgetHandle self, GdkEventFocus @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.FocusInEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "focus_in_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.FocusOutEventSignal> Signal_FocusOutEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.FocusOutEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.focus_out_event handler = (GtkWidgetHandle self, GdkEventFocus @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.FocusOutEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "focus_out_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.GrabBrokenEventSignal> Signal_GrabBrokenEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.GrabBrokenEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.grab_broken_event handler = (GtkWidgetHandle self, GdkEventGrabBroken @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.GrabBrokenEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "grab_broken_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.GrabFocusSignal> Signal_GrabFocus(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.GrabFocusSignal> obs) =>
		{
			GtkWidgetSignalDelegates.grab_focus handler = (GtkWidgetHandle self, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.GrabFocusSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "grab_focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.GrabNotifySignal> Signal_GrabNotify(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.GrabNotifySignal> obs) =>
		{
			GtkWidgetSignalDelegates.grab_notify handler = (GtkWidgetHandle self, bool was_grabbed, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.GrabNotifySignal()
				{
					Self = self, WasGrabbed = was_grabbed, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "grab_notify", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.HideSignal> Signal_Hide(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.HideSignal> obs) =>
		{
			GtkWidgetSignalDelegates.hide handler = (GtkWidgetHandle self, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.HideSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "hide", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.HierarchyChangedSignal> Signal_HierarchyChanged(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.HierarchyChangedSignal> obs) =>
		{
			GtkWidgetSignalDelegates.hierarchy_changed handler = (GtkWidgetHandle self, GtkWidgetHandle previous_toplevel, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.HierarchyChangedSignal()
				{
					Self = self, PreviousToplevel = previous_toplevel, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "hierarchy_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.KeyPressEventSignal> Signal_KeyPressEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.KeyPressEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.key_press_event handler = (GtkWidgetHandle self, GdkEventKey @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.KeyPressEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "key_press_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.KeyReleaseEventSignal> Signal_KeyReleaseEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.KeyReleaseEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.key_release_event handler = (GtkWidgetHandle self, GdkEventKey @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.KeyReleaseEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "key_release_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.KeynavFailedSignal> Signal_KeynavFailed(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.KeynavFailedSignal> obs) =>
		{
			GtkWidgetSignalDelegates.keynav_failed handler = (GtkWidgetHandle self, GtkDirectionType direction, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.KeynavFailedSignal()
				{
					Self = self, Direction = direction, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "keynav_failed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.LeaveNotifyEventSignal> Signal_LeaveNotifyEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.LeaveNotifyEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.leave_notify_event handler = (GtkWidgetHandle self, GdkEventCrossing @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.LeaveNotifyEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "leave_notify_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.MapSignal> Signal_Map(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.MapSignal> obs) =>
		{
			GtkWidgetSignalDelegates.map handler = (GtkWidgetHandle self, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.MapSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "map", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.MapEventSignal> Signal_MapEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.MapEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.map_event handler = (GtkWidgetHandle self, GdkEventAny @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.MapEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "map_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.MnemonicActivateSignal> Signal_MnemonicActivate(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.MnemonicActivateSignal> obs) =>
		{
			GtkWidgetSignalDelegates.mnemonic_activate handler = (GtkWidgetHandle self, bool group_cycling, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.MnemonicActivateSignal()
				{
					Self = self, GroupCycling = group_cycling, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "mnemonic_activate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.MotionNotifyEventSignal> Signal_MotionNotifyEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.MotionNotifyEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.motion_notify_event handler = (GtkWidgetHandle self, GdkEventMotion @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.MotionNotifyEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "motion_notify_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.MoveFocusSignal> Signal_MoveFocus(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.MoveFocusSignal> obs) =>
		{
			GtkWidgetSignalDelegates.move_focus handler = (GtkWidgetHandle self, GtkDirectionType direction, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.MoveFocusSignal()
				{
					Self = self, Direction = direction, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "move_focus", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.ParentSetSignal> Signal_ParentSet(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.ParentSetSignal> obs) =>
		{
			GtkWidgetSignalDelegates.parent_set handler = (GtkWidgetHandle self, GtkWidgetHandle old_parent, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.ParentSetSignal()
				{
					Self = self, OldParent = old_parent, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "parent_set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.PopupMenuSignal> Signal_PopupMenu(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.PopupMenuSignal> obs) =>
		{
			GtkWidgetSignalDelegates.popup_menu handler = (GtkWidgetHandle self, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.PopupMenuSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "popup_menu", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.PropertyNotifyEventSignal> Signal_PropertyNotifyEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.PropertyNotifyEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.property_notify_event handler = (GtkWidgetHandle self, GdkEventProperty @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.PropertyNotifyEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "property_notify_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.ProximityInEventSignal> Signal_ProximityInEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.ProximityInEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.proximity_in_event handler = (GtkWidgetHandle self, GdkEventProximity @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.ProximityInEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "proximity_in_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.ProximityOutEventSignal> Signal_ProximityOutEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.ProximityOutEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.proximity_out_event handler = (GtkWidgetHandle self, GdkEventProximity @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.ProximityOutEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "proximity_out_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.QueryTooltipSignal> Signal_QueryTooltip(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.QueryTooltipSignal> obs) =>
		{
			GtkWidgetSignalDelegates.query_tooltip handler = (GtkWidgetHandle self, int x, int y, bool keyboard_mode, GtkTooltipHandle tooltip, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.QueryTooltipSignal()
				{
					Self = self, X = x, Y = y, KeyboardMode = keyboard_mode, Tooltip = tooltip, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "query_tooltip", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.RealizeSignal> Signal_Realize(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.RealizeSignal> obs) =>
		{
			GtkWidgetSignalDelegates.realize handler = (GtkWidgetHandle self, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.RealizeSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "realize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.ScreenChangedSignal> Signal_ScreenChanged(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.ScreenChangedSignal> obs) =>
		{
			GtkWidgetSignalDelegates.screen_changed handler = (GtkWidgetHandle self, GdkScreenHandle previous_screen, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.ScreenChangedSignal()
				{
					Self = self, PreviousScreen = previous_screen, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "screen_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.ScrollEventSignal> Signal_ScrollEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.ScrollEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.scroll_event handler = (GtkWidgetHandle self, GdkEventScroll @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.ScrollEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "scroll_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.SelectionClearEventSignal> Signal_SelectionClearEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.SelectionClearEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.selection_clear_event handler = (GtkWidgetHandle self, GdkEventSelection @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.SelectionClearEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "selection_clear_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.SelectionGetSignal> Signal_SelectionGet(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.SelectionGetSignal> obs) =>
		{
			GtkWidgetSignalDelegates.selection_get handler = (GtkWidgetHandle self, GtkSelectionDataHandle data, uint info, uint time, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.SelectionGetSignal()
				{
					Self = self, Data = data, Info = info, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "selection_get", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.SelectionNotifyEventSignal> Signal_SelectionNotifyEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.SelectionNotifyEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.selection_notify_event handler = (GtkWidgetHandle self, GdkEventSelection @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.SelectionNotifyEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "selection_notify_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.SelectionReceivedSignal> Signal_SelectionReceived(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.SelectionReceivedSignal> obs) =>
		{
			GtkWidgetSignalDelegates.selection_received handler = (GtkWidgetHandle self, GtkSelectionDataHandle data, uint time, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.SelectionReceivedSignal()
				{
					Self = self, Data = data, Time = time, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "selection_received", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.SelectionRequestEventSignal> Signal_SelectionRequestEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.SelectionRequestEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.selection_request_event handler = (GtkWidgetHandle self, GdkEventSelection @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.SelectionRequestEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "selection_request_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.ShowSignal> Signal_Show(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.ShowSignal> obs) =>
		{
			GtkWidgetSignalDelegates.show handler = (GtkWidgetHandle self, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.ShowSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "show", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.ShowHelpSignal> Signal_ShowHelp(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.ShowHelpSignal> obs) =>
		{
			GtkWidgetSignalDelegates.show_help handler = (GtkWidgetHandle self, GtkWidgetHelpType help_type, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.ShowHelpSignal()
				{
					Self = self, HelpType = help_type, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "show_help", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.SizeAllocateSignal> Signal_SizeAllocate(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.SizeAllocateSignal> obs) =>
		{
			GtkWidgetSignalDelegates.size_allocate handler = (GtkWidgetHandle self, GtkAllocationHandle allocation, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.SizeAllocateSignal()
				{
					Self = self, Allocation = allocation, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "size_allocate", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.StateChangedSignal> Signal_StateChanged(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.StateChangedSignal> obs) =>
		{
			GtkWidgetSignalDelegates.state_changed handler = (GtkWidgetHandle self, GtkStateType state, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.StateChangedSignal()
				{
					Self = self, State = state, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "state_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.StateFlagsChangedSignal> Signal_StateFlagsChanged(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.StateFlagsChangedSignal> obs) =>
		{
			GtkWidgetSignalDelegates.state_flags_changed handler = (GtkWidgetHandle self, GtkStateFlags flags, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.StateFlagsChangedSignal()
				{
					Self = self, Flags = flags, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "state_flags_changed", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.StyleSetSignal> Signal_StyleSet(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.StyleSetSignal> obs) =>
		{
			GtkWidgetSignalDelegates.style_set handler = (GtkWidgetHandle self, GtkStyleHandle previous_style, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.StyleSetSignal()
				{
					Self = self, PreviousStyle = previous_style, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "style_set", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.StyleUpdatedSignal> Signal_StyleUpdated(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.StyleUpdatedSignal> obs) =>
		{
			GtkWidgetSignalDelegates.style_updated handler = (GtkWidgetHandle self, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.StyleUpdatedSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "style_updated", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.TouchEventSignal> Signal_TouchEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.TouchEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.touch_event handler = (GtkWidgetHandle self, GdkEventHandle @object, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.TouchEventSignal()
				{
					Self = self, Object = @object, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "touch_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.UnmapSignal> Signal_Unmap(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.UnmapSignal> obs) =>
		{
			GtkWidgetSignalDelegates.unmap handler = (GtkWidgetHandle self, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.UnmapSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "unmap", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.UnmapEventSignal> Signal_UnmapEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.UnmapEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.unmap_event handler = (GtkWidgetHandle self, GdkEventAny @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.UnmapEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "unmap_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.UnrealizeSignal> Signal_Unrealize(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.UnrealizeSignal> obs) =>
		{
			GtkWidgetSignalDelegates.unrealize handler = (GtkWidgetHandle self, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.UnrealizeSignal()
				{
					Self = self, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return ;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "unrealize", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.VisibilityNotifyEventSignal> Signal_VisibilityNotifyEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.VisibilityNotifyEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.visibility_notify_event handler = (GtkWidgetHandle self, GdkEventVisibility @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.VisibilityNotifyEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "visibility_notify_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}

	public static IObservable<GtkWidgetSignalStructs.WindowStateEventSignal> Signal_WindowStateEvent(this GtkWidgetHandle instance)
	{
		return Observable.Create((IObserver<GtkWidgetSignalStructs.WindowStateEventSignal> obs) =>
		{
			GtkWidgetSignalDelegates.window_state_event handler = (GtkWidgetHandle self, GdkEventWindowState @event, IntPtr user_data) =>
			{


				var signalStruct = new GtkWidgetSignalStructs.WindowStateEventSignal()
				{
					Self = self, Event = @event, UserData = user_data
				};

				obs.OnNext(signalStruct);
				return signalStruct.ReturnValue;
			};

			var handlerId = GObjectExterns.g_signal_connect_data(instance, "window_state_event", Marshal.GetFunctionPointerForDelegate(handler), IntPtr.Zero, null, GConnectFlags.G_CONNECT_AFTER);

			return Disposable.Create(() =>
			{
				instance.GSignalHandlerDisconnect(handlerId);
				obs.OnCompleted();
			});
		});
	}
}

public static class GtkWidgetSignalStructs
{

public struct AccelClosuresChangedSignal
{
	public GtkWidgetHandle Self;
	public IntPtr UserData;
}

public struct ButtonPressEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventButton Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct ButtonReleaseEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventButton Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct CanActivateAccelSignal
{
	public GtkWidgetHandle Self;
	public uint SignalId;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct ChildNotifySignal
{
	public GtkWidgetHandle Self;
	public GParamSpecHandle ChildProperty;
	public IntPtr UserData;
}

public struct CompositedChangedSignal
{
	public GtkWidgetHandle Self;
	public IntPtr UserData;
}

public struct ConfigureEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventConfigure Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct DamageEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventExpose Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct DeleteEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct DestroySignal
{
	public GtkWidgetHandle Self;
	public IntPtr UserData;
}

public struct DestroyEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct DirectionChangedSignal
{
	public GtkWidgetHandle Self;
	public GtkTextDirection PreviousDirection;
	public IntPtr UserData;
}

public struct DragBeginSignal
{
	public GtkWidgetHandle Self;
	public GdkDragContextHandle Context;
	public IntPtr UserData;
}

public struct DragDataDeleteSignal
{
	public GtkWidgetHandle Self;
	public GdkDragContextHandle Context;
	public IntPtr UserData;
}

public struct DragDataGetSignal
{
	public GtkWidgetHandle Self;
	public GdkDragContextHandle Context;
	public GtkSelectionDataHandle Data;
	public uint Info;
	public uint Time;
	public IntPtr UserData;
}

public struct DragDataReceivedSignal
{
	public GtkWidgetHandle Self;
	public GdkDragContextHandle Context;
	public int X;
	public int Y;
	public GtkSelectionDataHandle Data;
	public uint Info;
	public uint Time;
	public IntPtr UserData;
}

public struct DragDropSignal
{
	public GtkWidgetHandle Self;
	public GdkDragContextHandle Context;
	public int X;
	public int Y;
	public uint Time;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct DragEndSignal
{
	public GtkWidgetHandle Self;
	public GdkDragContextHandle Context;
	public IntPtr UserData;
}

public struct DragFailedSignal
{
	public GtkWidgetHandle Self;
	public GdkDragContextHandle Context;
	public GtkDragResult Result;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct DragLeaveSignal
{
	public GtkWidgetHandle Self;
	public GdkDragContextHandle Context;
	public uint Time;
	public IntPtr UserData;
}

public struct DragMotionSignal
{
	public GtkWidgetHandle Self;
	public GdkDragContextHandle Context;
	public int X;
	public int Y;
	public uint Time;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct DrawSignal
{
	public GtkWidgetHandle Self;
	public cairo_tHandle Cr;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct EnterNotifyEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventCrossing Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct EventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventHandle Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct EventAfterSignal
{
	public GtkWidgetHandle Self;
	public GdkEventHandle Event;
	public IntPtr UserData;
}

public struct FocusSignal
{
	public GtkWidgetHandle Self;
	public GtkDirectionType Direction;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct FocusInEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventFocus Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct FocusOutEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventFocus Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct GrabBrokenEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventGrabBroken Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct GrabFocusSignal
{
	public GtkWidgetHandle Self;
	public IntPtr UserData;
}

public struct GrabNotifySignal
{
	public GtkWidgetHandle Self;
	public bool WasGrabbed;
	public IntPtr UserData;
}

public struct HideSignal
{
	public GtkWidgetHandle Self;
	public IntPtr UserData;
}

public struct HierarchyChangedSignal
{
	public GtkWidgetHandle Self;
	public GtkWidgetHandle PreviousToplevel;
	public IntPtr UserData;
}

public struct KeyPressEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventKey Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct KeyReleaseEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventKey Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct KeynavFailedSignal
{
	public GtkWidgetHandle Self;
	public GtkDirectionType Direction;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct LeaveNotifyEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventCrossing Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct MapSignal
{
	public GtkWidgetHandle Self;
	public IntPtr UserData;
}

public struct MapEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventAny Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct MnemonicActivateSignal
{
	public GtkWidgetHandle Self;
	public bool GroupCycling;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct MotionNotifyEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventMotion Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct MoveFocusSignal
{
	public GtkWidgetHandle Self;
	public GtkDirectionType Direction;
	public IntPtr UserData;
}

public struct ParentSetSignal
{
	public GtkWidgetHandle Self;
	public GtkWidgetHandle OldParent;
	public IntPtr UserData;
}

public struct PopupMenuSignal
{
	public GtkWidgetHandle Self;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct PropertyNotifyEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventProperty Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct ProximityInEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventProximity Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct ProximityOutEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventProximity Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct QueryTooltipSignal
{
	public GtkWidgetHandle Self;
	public int X;
	public int Y;
	public bool KeyboardMode;
	public GtkTooltipHandle Tooltip;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct RealizeSignal
{
	public GtkWidgetHandle Self;
	public IntPtr UserData;
}

public struct ScreenChangedSignal
{
	public GtkWidgetHandle Self;
	public GdkScreenHandle PreviousScreen;
	public IntPtr UserData;
}

public struct ScrollEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventScroll Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct SelectionClearEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventSelection Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct SelectionGetSignal
{
	public GtkWidgetHandle Self;
	public GtkSelectionDataHandle Data;
	public uint Info;
	public uint Time;
	public IntPtr UserData;
}

public struct SelectionNotifyEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventSelection Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct SelectionReceivedSignal
{
	public GtkWidgetHandle Self;
	public GtkSelectionDataHandle Data;
	public uint Time;
	public IntPtr UserData;
}

public struct SelectionRequestEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventSelection Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct ShowSignal
{
	public GtkWidgetHandle Self;
	public IntPtr UserData;
}

public struct ShowHelpSignal
{
	public GtkWidgetHandle Self;
	public GtkWidgetHelpType HelpType;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct SizeAllocateSignal
{
	public GtkWidgetHandle Self;
	public GtkAllocationHandle Allocation;
	public IntPtr UserData;
}

public struct StateChangedSignal
{
	public GtkWidgetHandle Self;
	public GtkStateType State;
	public IntPtr UserData;
}

public struct StateFlagsChangedSignal
{
	public GtkWidgetHandle Self;
	public GtkStateFlags Flags;
	public IntPtr UserData;
}

public struct StyleSetSignal
{
	public GtkWidgetHandle Self;
	public GtkStyleHandle PreviousStyle;
	public IntPtr UserData;
}

public struct StyleUpdatedSignal
{
	public GtkWidgetHandle Self;
	public IntPtr UserData;
}

public struct TouchEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventHandle Object;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct UnmapSignal
{
	public GtkWidgetHandle Self;
	public IntPtr UserData;
}

public struct UnmapEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventAny Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct UnrealizeSignal
{
	public GtkWidgetHandle Self;
	public IntPtr UserData;
}

public struct VisibilityNotifyEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventVisibility Event;
	public IntPtr UserData;
	public bool ReturnValue;
}

public struct WindowStateEventSignal
{
	public GtkWidgetHandle Self;
	public GdkEventWindowState Event;
	public IntPtr UserData;
	public bool ReturnValue;
}
}

public static class GtkWidgetSignalDelegates
{

[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void accel_closures_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool button_press_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventButton @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool button_release_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventButton @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool can_activate_accel([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, uint signal_id, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void child_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GParamSpecHandle>))] GParamSpecHandle child_property, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void composited_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool configure_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventConfigure @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool damage_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventExpose @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool delete_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkEventHandle>))] GdkEventHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void destroy([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool destroy_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkEventHandle>))] GdkEventHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void direction_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GtkTextDirection previous_direction, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_begin([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDragContextHandle>))] GdkDragContextHandle context, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_data_delete([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDragContextHandle>))] GdkDragContextHandle context, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_data_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDragContextHandle>))] GdkDragContextHandle context, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSelectionDataHandle>))] GtkSelectionDataHandle data, uint info, uint time, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_data_received([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDragContextHandle>))] GdkDragContextHandle context, int x, int y, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSelectionDataHandle>))] GtkSelectionDataHandle data, uint info, uint time, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool drag_drop([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDragContextHandle>))] GdkDragContextHandle context, int x, int y, uint time, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_end([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDragContextHandle>))] GdkDragContextHandle context, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool drag_failed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDragContextHandle>))] GdkDragContextHandle context, GtkDragResult result, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void drag_leave([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDragContextHandle>))] GdkDragContextHandle context, uint time, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool drag_motion([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkDragContextHandle>))] GdkDragContextHandle context, int x, int y, uint time, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool draw([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<cairo_tHandle>))] cairo_tHandle cr, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool enter_notify_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventCrossing @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool @event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkEventHandle>))] GdkEventHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void event_after([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkEventHandle>))] GdkEventHandle @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GtkDirectionType direction, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool focus_in_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventFocus @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool focus_out_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventFocus @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool grab_broken_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventGrabBroken @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void grab_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void grab_notify([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, bool was_grabbed, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void hide([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void hierarchy_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle previous_toplevel, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool key_press_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventKey @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool key_release_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventKey @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool keynav_failed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GtkDirectionType direction, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool leave_notify_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventCrossing @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void map([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool map_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventAny @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool mnemonic_activate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, bool group_cycling, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool motion_notify_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventMotion @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void move_focus([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GtkDirectionType direction, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void parent_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle old_parent, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool popup_menu([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool property_notify_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventProperty @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool proximity_in_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventProximity @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool proximity_out_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventProximity @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool query_tooltip([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, int x, int y, bool keyboard_mode, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkTooltipHandle>))] GtkTooltipHandle tooltip, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void realize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void screen_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkScreenHandle>))] GdkScreenHandle previous_screen, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool scroll_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventScroll @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool selection_clear_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventSelection @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_get([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSelectionDataHandle>))] GtkSelectionDataHandle data, uint info, uint time, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool selection_notify_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventSelection @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void selection_received([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkSelectionDataHandle>))] GtkSelectionDataHandle data, uint time, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool selection_request_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventSelection @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void show([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool show_help([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GtkWidgetHelpType help_type, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void size_allocate([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkAllocationHandle>))] GtkAllocationHandle allocation, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void state_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GtkStateType state, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void state_flags_changed([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GtkStateFlags flags, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void style_set([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkStyleHandle>))] GtkStyleHandle previous_style, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void style_updated([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool touch_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GdkEventHandle>))] GdkEventHandle @object, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unmap([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool unmap_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventAny @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate void unrealize([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool visibility_notify_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventVisibility @event, IntPtr user_data);


[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
public delegate bool window_state_event([MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(DelegateSafeHandleMarshaller<GtkWidgetHandle>))] GtkWidgetHandle self, GdkEventWindowState @event, IntPtr user_data);

}


public static class GtkWidgetHandleExtensions
{
	public static bool Activate(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_activate(widget);
	}

	public static GtkWidgetHandle AddAccelerator(this GtkWidgetHandle widget, string accel_signal, GtkAccelGroupHandle accel_group, uint accel_key, GdkModifierType accel_mods, GtkAccelFlags accel_flags)
	{
		GtkWidgetExterns.gtk_widget_add_accelerator(widget, accel_signal, accel_group, accel_key, accel_mods, accel_flags);
		return widget;
	}

	public static GtkWidgetHandle AddDeviceEvents(this GtkWidgetHandle widget, GdkDeviceHandle device, GdkEventMask events)
	{
		GtkWidgetExterns.gtk_widget_add_device_events(widget, device, events);
		return widget;
	}

	public static GtkWidgetHandle AddEvents(this GtkWidgetHandle widget, int events)
	{
		GtkWidgetExterns.gtk_widget_add_events(widget, events);
		return widget;
	}

	public static GtkWidgetHandle AddMnemonicLabel(this GtkWidgetHandle widget, GtkWidgetHandle label)
	{
		GtkWidgetExterns.gtk_widget_add_mnemonic_label(widget, label);
		return widget;
	}

	public static uint AddTickCallback(this GtkWidgetHandle widget, GtkTickCallback callback, IntPtr user_data, GDestroyNotify notify)
	{
		return GtkWidgetExterns.gtk_widget_add_tick_callback(widget, callback, user_data, notify);
	}

	public static bool CanActivateAccel(this GtkWidgetHandle widget, uint signal_id)
	{
		return GtkWidgetExterns.gtk_widget_can_activate_accel(widget, signal_id);
	}

	public static bool ChildFocus(this GtkWidgetHandle widget, GtkDirectionType direction)
	{
		return GtkWidgetExterns.gtk_widget_child_focus(widget, direction);
	}

	public static GtkWidgetHandle ChildNotify(this GtkWidgetHandle widget, string child_property)
	{
		GtkWidgetExterns.gtk_widget_child_notify(widget, child_property);
		return widget;
	}

	public static GtkWidgetHandle ClassPath(this GtkWidgetHandle widget, out uint path_length, out string path, out string path_reversed)
	{
		GtkWidgetExterns.gtk_widget_class_path(widget, out path_length, out path, out path_reversed);
		return widget;
	}

	public static bool ComputeExpand(this GtkWidgetHandle widget, GtkOrientation orientation)
	{
		return GtkWidgetExterns.gtk_widget_compute_expand(widget, orientation);
	}

	public static PangoContextHandle CreatePangoContext(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_create_pango_context(widget);
	}

	public static PangoLayoutHandle CreatePangoLayout(this GtkWidgetHandle widget, string text)
	{
		return GtkWidgetExterns.gtk_widget_create_pango_layout(widget, text);
	}

	public static GtkWidgetHandle Destroy(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_destroy(widget);
		return widget;
	}

	public static GtkWidgetHandle Destroyed(this GtkWidgetHandle widget, ref GtkWidgetHandle widget_pointer)
	{
		GtkWidgetExterns.gtk_widget_destroyed(widget, ref widget_pointer);
		return widget;
	}

	public static bool DeviceIsShadowed(this GtkWidgetHandle widget, GdkDeviceHandle device)
	{
		return GtkWidgetExterns.gtk_widget_device_is_shadowed(widget, device);
	}

	public static GdkDragContextHandle GtkDragBegin(this GtkWidgetHandle widget, GtkTargetListHandle targets, GdkDragAction actions, int button, GdkEventHandle @event)
	{
		return GtkWidgetExterns.gtk_drag_begin(widget, targets, actions, button, @event);
	}

	public static GdkDragContextHandle GtkDragBeginWithCoordinates(this GtkWidgetHandle widget, GtkTargetListHandle targets, GdkDragAction actions, int button, GdkEventHandle @event, int x, int y)
	{
		return GtkWidgetExterns.gtk_drag_begin_with_coordinates(widget, targets, actions, button, @event, x, y);
	}

	public static bool GtkDragCheckThreshold(this GtkWidgetHandle widget, int start_x, int start_y, int current_x, int current_y)
	{
		return GtkWidgetExterns.gtk_drag_check_threshold(widget, start_x, start_y, current_x, current_y);
	}

	public static GtkWidgetHandle GtkDragDestAddImageTargets(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_drag_dest_add_image_targets(widget);
		return widget;
	}

	public static GtkWidgetHandle GtkDragDestAddTextTargets(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_drag_dest_add_text_targets(widget);
		return widget;
	}

	public static GtkWidgetHandle GtkDragDestAddUriTargets(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_drag_dest_add_uri_targets(widget);
		return widget;
	}

	public static GdkAtom GtkDragDestFindTarget(this GtkWidgetHandle widget, GdkDragContextHandle context, GtkTargetListHandle target_list)
	{
		return GtkWidgetExterns.gtk_drag_dest_find_target(widget, context, target_list);
	}

	public static GtkTargetListHandle GtkDragDestGetTargetList(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_drag_dest_get_target_list(widget);
	}

	public static bool GtkDragDestGetTrackMotion(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_drag_dest_get_track_motion(widget);
	}

	public static GtkWidgetHandle GtkDragDestSet(this GtkWidgetHandle widget, GtkDestDefaults flags, GtkTargetEntry[] targets, int n_targets, GdkDragAction actions)
	{
		GtkWidgetExterns.gtk_drag_dest_set(widget, flags, targets, n_targets, actions);
		return widget;
	}

	public static GtkWidgetHandle GtkDragDestSetProxy(this GtkWidgetHandle widget, GdkWindowHandle proxy_window, GdkDragProtocol protocol, bool use_coordinates)
	{
		GtkWidgetExterns.gtk_drag_dest_set_proxy(widget, proxy_window, protocol, use_coordinates);
		return widget;
	}

	public static GtkWidgetHandle GtkDragDestSetTargetList(this GtkWidgetHandle widget, GtkTargetListHandle target_list)
	{
		GtkWidgetExterns.gtk_drag_dest_set_target_list(widget, target_list);
		return widget;
	}

	public static GtkWidgetHandle GtkDragDestSetTrackMotion(this GtkWidgetHandle widget, bool track_motion)
	{
		GtkWidgetExterns.gtk_drag_dest_set_track_motion(widget, track_motion);
		return widget;
	}

	public static GtkWidgetHandle GtkDragDestUnset(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_drag_dest_unset(widget);
		return widget;
	}

	public static GtkWidgetHandle GtkDragGetData(this GtkWidgetHandle widget, GdkDragContextHandle context, GdkAtom target, uint time_)
	{
		GtkWidgetExterns.gtk_drag_get_data(widget, context, target, time_);
		return widget;
	}

	public static GtkWidgetHandle GtkDragHighlight(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_drag_highlight(widget);
		return widget;
	}

	public static GtkWidgetHandle GtkDragSourceAddImageTargets(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_drag_source_add_image_targets(widget);
		return widget;
	}

	public static GtkWidgetHandle GtkDragSourceAddTextTargets(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_drag_source_add_text_targets(widget);
		return widget;
	}

	public static GtkWidgetHandle GtkDragSourceAddUriTargets(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_drag_source_add_uri_targets(widget);
		return widget;
	}

	public static GtkTargetListHandle GtkDragSourceGetTargetList(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_drag_source_get_target_list(widget);
	}

	public static GtkWidgetHandle GtkDragSourceSet(this GtkWidgetHandle widget, GdkModifierType start_button_mask, GtkTargetEntry[] targets, int n_targets, GdkDragAction actions)
	{
		GtkWidgetExterns.gtk_drag_source_set(widget, start_button_mask, targets, n_targets, actions);
		return widget;
	}

	public static GtkWidgetHandle GtkDragSourceSetIconGicon(this GtkWidgetHandle widget, GIconHandle icon)
	{
		GtkWidgetExterns.gtk_drag_source_set_icon_gicon(widget, icon);
		return widget;
	}

	public static GtkWidgetHandle GtkDragSourceSetIconName(this GtkWidgetHandle widget, string icon_name)
	{
		GtkWidgetExterns.gtk_drag_source_set_icon_name(widget, icon_name);
		return widget;
	}

	public static GtkWidgetHandle GtkDragSourceSetIconPixbuf(this GtkWidgetHandle widget, GdkPixbufHandle pixbuf)
	{
		GtkWidgetExterns.gtk_drag_source_set_icon_pixbuf(widget, pixbuf);
		return widget;
	}

	public static GtkWidgetHandle GtkDragSourceSetIconStock(this GtkWidgetHandle widget, string stock_id)
	{
		GtkWidgetExterns.gtk_drag_source_set_icon_stock(widget, stock_id);
		return widget;
	}

	public static GtkWidgetHandle GtkDragSourceSetTargetList(this GtkWidgetHandle widget, GtkTargetListHandle target_list)
	{
		GtkWidgetExterns.gtk_drag_source_set_target_list(widget, target_list);
		return widget;
	}

	public static GtkWidgetHandle GtkDragSourceUnset(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_drag_source_unset(widget);
		return widget;
	}

	public static GtkWidgetHandle GtkDragUnhighlight(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_drag_unhighlight(widget);
		return widget;
	}

	public static GtkWidgetHandle Draw(this GtkWidgetHandle widget, cairo_tHandle cr)
	{
		GtkWidgetExterns.gtk_widget_draw(widget, cr);
		return widget;
	}

	public static GtkWidgetHandle EnsureStyle(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_ensure_style(widget);
		return widget;
	}

	public static GtkWidgetHandle ErrorBell(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_error_bell(widget);
		return widget;
	}

	public static bool Event(this GtkWidgetHandle widget, GdkEventHandle @event)
	{
		return GtkWidgetExterns.gtk_widget_event(widget, @event);
	}

	public static GtkWidgetHandle FreezeChildNotify(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_freeze_child_notify(widget);
		return widget;
	}

	public static AtkObjectHandle GetAccessible(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_accessible(widget);
	}

	public static GActionGroupHandle GetActionGroup(this GtkWidgetHandle widget, string prefix)
	{
		return GtkWidgetExterns.gtk_widget_get_action_group(widget, prefix);
	}

	public static int GetAllocatedBaseline(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_allocated_baseline(widget);
	}

	public static int GetAllocatedHeight(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_allocated_height(widget);
	}

	public static GtkWidgetHandle GetAllocatedSize(this GtkWidgetHandle widget, out GtkAllocation allocation, out int baseline)
	{
		GtkWidgetExterns.gtk_widget_get_allocated_size(widget, out allocation, out baseline);
		return widget;
	}

	public static int GetAllocatedWidth(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_allocated_width(widget);
	}

	public static GtkWidgetHandle GetAllocation(this GtkWidgetHandle widget, out GtkAllocation allocation)
	{
		GtkWidgetExterns.gtk_widget_get_allocation(widget, out allocation);
		return widget;
	}

	public static GtkWidgetHandle GetAncestor(this GtkWidgetHandle widget, GType widget_type)
	{
		return GtkWidgetExterns.gtk_widget_get_ancestor(widget, widget_type);
	}

	public static bool GetAppPaintable(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_app_paintable(widget);
	}

	public static bool GetCanDefault(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_can_default(widget);
	}

	public static bool GetCanFocus(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_can_focus(widget);
	}

	public static GtkWidgetHandle GetChildRequisition(this GtkWidgetHandle widget, out GtkRequisition requisition)
	{
		GtkWidgetExterns.gtk_widget_get_child_requisition(widget, out requisition);
		return widget;
	}

	public static bool GetChildVisible(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_child_visible(widget);
	}

	public static GtkWidgetHandle GetClip(this GtkWidgetHandle widget, out GtkAllocation clip)
	{
		GtkWidgetExterns.gtk_widget_get_clip(widget, out clip);
		return widget;
	}

	public static GtkClipboardHandle GetClipboard(this GtkWidgetHandle widget, GdkAtom selection)
	{
		return GtkWidgetExterns.gtk_widget_get_clipboard(widget, selection);
	}

	public static string GetCompositeName(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_composite_name(widget);
	}

	public static bool GetDeviceEnabled(this GtkWidgetHandle widget, GdkDeviceHandle device)
	{
		return GtkWidgetExterns.gtk_widget_get_device_enabled(widget, device);
	}

	public static GdkEventMask GetDeviceEvents(this GtkWidgetHandle widget, GdkDeviceHandle device)
	{
		return GtkWidgetExterns.gtk_widget_get_device_events(widget, device);
	}

	public static GtkTextDirection GetDirection(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_direction(widget);
	}

	public static GdkDisplayHandle GetDisplay(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_display(widget);
	}

	public static bool GetDoubleBuffered(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_double_buffered(widget);
	}

	public static int GetEvents(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_events(widget);
	}

	public static bool GetFocusOnClick(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_focus_on_click(widget);
	}

	public static PangoFontMapHandle GetFontMap(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_font_map(widget);
	}

	public static cairo_font_options_tHandle GetFontOptions(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_font_options(widget);
	}

	public static GdkFrameClockHandle GetFrameClock(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_frame_clock(widget);
	}

	public static GtkAlign GetHalign(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_halign(widget);
	}

	public static bool GetHasTooltip(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_has_tooltip(widget);
	}

	public static bool GetHasWindow(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_has_window(widget);
	}

	public static bool GetHexpand(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_hexpand(widget);
	}

	public static bool GetHexpandSet(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_hexpand_set(widget);
	}

	public static bool GetMapped(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_mapped(widget);
	}

	public static int GetMarginBottom(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_margin_bottom(widget);
	}

	public static int GetMarginEnd(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_margin_end(widget);
	}

	public static int GetMarginLeft(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_margin_left(widget);
	}

	public static int GetMarginRight(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_margin_right(widget);
	}

	public static int GetMarginStart(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_margin_start(widget);
	}

	public static int GetMarginTop(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_margin_top(widget);
	}

	public static GdkModifierType GetModifierMask(this GtkWidgetHandle widget, GdkModifierIntent intent)
	{
		return GtkWidgetExterns.gtk_widget_get_modifier_mask(widget, intent);
	}

	public static GtkRcStyleHandle GetModifierStyle(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_modifier_style(widget);
	}

	public static string GetName(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_name(widget);
	}

	public static bool GetNoShowAll(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_no_show_all(widget);
	}

	public static double GetOpacity(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_opacity(widget);
	}

	public static PangoContextHandle GetPangoContext(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_pango_context(widget);
	}

	public static GtkWidgetHandle GetParent(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_parent(widget);
	}

	public static GdkWindowHandle GetParentWindow(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_parent_window(widget);
	}

	public static GtkWidgetPathHandle GetPath(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_path(widget);
	}

	public static GtkWidgetHandle GetPointer(this GtkWidgetHandle widget, out int x, out int y)
	{
		GtkWidgetExterns.gtk_widget_get_pointer(widget, out x, out y);
		return widget;
	}

	public static GtkWidgetHandle GetPreferredHeight(this GtkWidgetHandle widget, out int minimum_height, out int natural_height)
	{
		GtkWidgetExterns.gtk_widget_get_preferred_height(widget, out minimum_height, out natural_height);
		return widget;
	}

	public static GtkWidgetHandle GetPreferredHeightAndBaselineForWidth(this GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height, out int minimum_baseline, out int natural_baseline)
	{
		GtkWidgetExterns.gtk_widget_get_preferred_height_and_baseline_for_width(widget, width, out minimum_height, out natural_height, out minimum_baseline, out natural_baseline);
		return widget;
	}

	public static GtkWidgetHandle GetPreferredHeightForWidth(this GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height)
	{
		GtkWidgetExterns.gtk_widget_get_preferred_height_for_width(widget, width, out minimum_height, out natural_height);
		return widget;
	}

	public static GtkWidgetHandle GetPreferredSize(this GtkWidgetHandle widget, out GtkRequisition minimum_size, out GtkRequisition natural_size)
	{
		GtkWidgetExterns.gtk_widget_get_preferred_size(widget, out minimum_size, out natural_size);
		return widget;
	}

	public static GtkWidgetHandle GetPreferredWidth(this GtkWidgetHandle widget, out int minimum_width, out int natural_width)
	{
		GtkWidgetExterns.gtk_widget_get_preferred_width(widget, out minimum_width, out natural_width);
		return widget;
	}

	public static GtkWidgetHandle GetPreferredWidthForHeight(this GtkWidgetHandle widget, int height, out int minimum_width, out int natural_width)
	{
		GtkWidgetExterns.gtk_widget_get_preferred_width_for_height(widget, height, out minimum_width, out natural_width);
		return widget;
	}

	public static bool GetRealized(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_realized(widget);
	}

	public static bool GetReceivesDefault(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_receives_default(widget);
	}

	public static GtkSizeRequestMode GetRequestMode(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_request_mode(widget);
	}

	public static GtkWidgetHandle GetRequisition(this GtkWidgetHandle widget, out GtkRequisition requisition)
	{
		GtkWidgetExterns.gtk_widget_get_requisition(widget, out requisition);
		return widget;
	}

	public static GdkWindowHandle GetRootWindow(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_root_window(widget);
	}

	public static int GetScaleFactor(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_scale_factor(widget);
	}

	public static GdkScreenHandle GetScreen(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_screen(widget);
	}

	public static bool GetSensitive(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_sensitive(widget);
	}

	public static GtkSettingsHandle GetSettings(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_settings(widget);
	}

	public static GtkWidgetHandle GetSizeRequest(this GtkWidgetHandle widget, out int width, out int height)
	{
		GtkWidgetExterns.gtk_widget_get_size_request(widget, out width, out height);
		return widget;
	}

	public static GtkStateType GetState(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_state(widget);
	}

	public static GtkStateFlags GetStateFlags(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_state_flags(widget);
	}

	public static GtkStyleHandle GetStyle(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_style(widget);
	}

	public static GtkStyleContextHandle GetStyleContext(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_style_context(widget);
	}

	public static bool GetSupportMultidevice(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_support_multidevice(widget);
	}

	public static GObjectHandle GetTemplateChild(this GtkWidgetHandle widget, GType widget_type, string name)
	{
		return GtkWidgetExterns.gtk_widget_get_template_child(widget, widget_type, name);
	}

	public static string GetTooltipMarkup(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_tooltip_markup(widget);
	}

	public static string GetTooltipText(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_tooltip_text(widget);
	}

	public static GtkWindowHandle GetTooltipWindow(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_tooltip_window(widget);
	}

	public static GtkWidgetHandle GetToplevel(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_toplevel(widget);
	}

	public static GtkAlign GetValign(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_valign(widget);
	}

	public static GtkAlign GetValignWithBaseline(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_valign_with_baseline(widget);
	}

	public static bool GetVexpand(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_vexpand(widget);
	}

	public static bool GetVexpandSet(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_vexpand_set(widget);
	}

	public static bool GetVisible(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_visible(widget);
	}

	public static GdkVisualHandle GetVisual(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_visual(widget);
	}

	public static GdkWindowHandle GetWindow(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_get_window(widget);
	}

	public static GtkWidgetHandle GtkGrabAdd(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_grab_add(widget);
		return widget;
	}

	public static GtkWidgetHandle GrabDefault(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_grab_default(widget);
		return widget;
	}

	public static GtkWidgetHandle GrabFocus(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_grab_focus(widget);
		return widget;
	}

	public static GtkWidgetHandle GtkGrabRemove(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_grab_remove(widget);
		return widget;
	}

	public static bool HasDefault(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_has_default(widget);
	}

	public static bool HasFocus(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_has_focus(widget);
	}

	public static bool HasGrab(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_has_grab(widget);
	}

	public static bool HasRcStyle(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_has_rc_style(widget);
	}

	public static bool HasScreen(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_has_screen(widget);
	}

	public static bool HasVisibleFocus(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_has_visible_focus(widget);
	}

	public static GtkWidgetHandle Hide(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_hide(widget);
		return widget;
	}

	public static bool HideOnDelete(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_hide_on_delete(widget);
	}

	public static bool InDestruction(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_in_destruction(widget);
	}

	public static GtkWidgetHandle InitTemplate(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_init_template(widget);
		return widget;
	}

	public static GtkWidgetHandle InputShapeCombineRegion(this GtkWidgetHandle widget, cairo_region_tHandle region)
	{
		GtkWidgetExterns.gtk_widget_input_shape_combine_region(widget, region);
		return widget;
	}

	public static GtkWidgetHandle InsertActionGroup(this GtkWidgetHandle widget, string name, GActionGroupHandle group)
	{
		GtkWidgetExterns.gtk_widget_insert_action_group(widget, name, group);
		return widget;
	}

	public static bool Intersect(this GtkWidgetHandle widget, GdkRectangleHandle area, out GdkRectangle intersection)
	{
		return GtkWidgetExterns.gtk_widget_intersect(widget, area, out intersection);
	}

	public static bool IsAncestor(this GtkWidgetHandle widget, GtkWidgetHandle ancestor)
	{
		return GtkWidgetExterns.gtk_widget_is_ancestor(widget, ancestor);
	}

	public static bool IsComposited(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_is_composited(widget);
	}

	public static bool IsDrawable(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_is_drawable(widget);
	}

	public static bool IsFocus(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_is_focus(widget);
	}

	public static bool IsSensitive(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_is_sensitive(widget);
	}

	public static bool IsToplevel(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_is_toplevel(widget);
	}

	public static bool IsVisible(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_is_visible(widget);
	}

	public static bool KeynavFailed(this GtkWidgetHandle widget, GtkDirectionType direction)
	{
		return GtkWidgetExterns.gtk_widget_keynav_failed(widget, direction);
	}

	public static GListHandle ListAccelClosures(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_list_accel_closures(widget);
	}

	public static IntPtr ListActionPrefixes(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_list_action_prefixes(widget);
	}

	public static GListHandle ListMnemonicLabels(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_widget_list_mnemonic_labels(widget);
	}

	public static GtkWidgetHandle Map(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_map(widget);
		return widget;
	}

	public static bool MnemonicActivate(this GtkWidgetHandle widget, bool group_cycling)
	{
		return GtkWidgetExterns.gtk_widget_mnemonic_activate(widget, group_cycling);
	}

	public static GtkWidgetHandle ModifyBase(this GtkWidgetHandle widget, GtkStateType state, GdkColorHandle color)
	{
		GtkWidgetExterns.gtk_widget_modify_base(widget, state, color);
		return widget;
	}

	public static GtkWidgetHandle ModifyBg(this GtkWidgetHandle widget, GtkStateType state, GdkColorHandle color)
	{
		GtkWidgetExterns.gtk_widget_modify_bg(widget, state, color);
		return widget;
	}

	public static GtkWidgetHandle ModifyCursor(this GtkWidgetHandle widget, GdkColorHandle primary, GdkColorHandle secondary)
	{
		GtkWidgetExterns.gtk_widget_modify_cursor(widget, primary, secondary);
		return widget;
	}

	public static GtkWidgetHandle ModifyFg(this GtkWidgetHandle widget, GtkStateType state, GdkColorHandle color)
	{
		GtkWidgetExterns.gtk_widget_modify_fg(widget, state, color);
		return widget;
	}

	public static GtkWidgetHandle ModifyFont(this GtkWidgetHandle widget, PangoFontDescriptionHandle font_desc)
	{
		GtkWidgetExterns.gtk_widget_modify_font(widget, font_desc);
		return widget;
	}

	public static GtkWidgetHandle ModifyStyle(this GtkWidgetHandle widget, GtkRcStyleHandle style)
	{
		GtkWidgetExterns.gtk_widget_modify_style(widget, style);
		return widget;
	}

	public static GtkWidgetHandle ModifyText(this GtkWidgetHandle widget, GtkStateType state, GdkColorHandle color)
	{
		GtkWidgetExterns.gtk_widget_modify_text(widget, state, color);
		return widget;
	}

	public static GtkWidgetHandle OverrideBackgroundColor(this GtkWidgetHandle widget, GtkStateFlags state, GdkRGBAHandle color)
	{
		GtkWidgetExterns.gtk_widget_override_background_color(widget, state, color);
		return widget;
	}

	public static GtkWidgetHandle OverrideColor(this GtkWidgetHandle widget, GtkStateFlags state, GdkRGBAHandle color)
	{
		GtkWidgetExterns.gtk_widget_override_color(widget, state, color);
		return widget;
	}

	public static GtkWidgetHandle OverrideCursor(this GtkWidgetHandle widget, GdkRGBAHandle cursor, GdkRGBAHandle secondary_cursor)
	{
		GtkWidgetExterns.gtk_widget_override_cursor(widget, cursor, secondary_cursor);
		return widget;
	}

	public static GtkWidgetHandle OverrideFont(this GtkWidgetHandle widget, PangoFontDescriptionHandle font_desc)
	{
		GtkWidgetExterns.gtk_widget_override_font(widget, font_desc);
		return widget;
	}

	public static GtkWidgetHandle OverrideSymbolicColor(this GtkWidgetHandle widget, string name, GdkRGBAHandle color)
	{
		GtkWidgetExterns.gtk_widget_override_symbolic_color(widget, name, color);
		return widget;
	}

	public static GtkWidgetHandle Path(this GtkWidgetHandle widget, out uint path_length, out string path, out string path_reversed)
	{
		GtkWidgetExterns.gtk_widget_path(widget, out path_length, out path, out path_reversed);
		return widget;
	}

	public static GtkWidgetHandle QueueAllocate(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_queue_allocate(widget);
		return widget;
	}

	public static GtkWidgetHandle QueueComputeExpand(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_queue_compute_expand(widget);
		return widget;
	}

	public static GtkWidgetHandle QueueDraw(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_queue_draw(widget);
		return widget;
	}

	public static GtkWidgetHandle QueueDrawArea(this GtkWidgetHandle widget, int x, int y, int width, int height)
	{
		GtkWidgetExterns.gtk_widget_queue_draw_area(widget, x, y, width, height);
		return widget;
	}

	public static GtkWidgetHandle QueueDrawRegion(this GtkWidgetHandle widget, cairo_region_tHandle region)
	{
		GtkWidgetExterns.gtk_widget_queue_draw_region(widget, region);
		return widget;
	}

	public static GtkWidgetHandle QueueResize(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_queue_resize(widget);
		return widget;
	}

	public static GtkWidgetHandle QueueResizeNoRedraw(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_queue_resize_no_redraw(widget);
		return widget;
	}

	public static GtkWidgetHandle Realize(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_realize(widget);
		return widget;
	}

	public static cairo_region_tHandle RegionIntersect(this GtkWidgetHandle widget, cairo_region_tHandle region)
	{
		return GtkWidgetExterns.gtk_widget_region_intersect(widget, region);
	}

	public static GtkWidgetHandle RegisterWindow(this GtkWidgetHandle widget, GdkWindowHandle window)
	{
		GtkWidgetExterns.gtk_widget_register_window(widget, window);
		return widget;
	}

	public static bool RemoveAccelerator(this GtkWidgetHandle widget, GtkAccelGroupHandle accel_group, uint accel_key, GdkModifierType accel_mods)
	{
		return GtkWidgetExterns.gtk_widget_remove_accelerator(widget, accel_group, accel_key, accel_mods);
	}

	public static GtkWidgetHandle RemoveMnemonicLabel(this GtkWidgetHandle widget, GtkWidgetHandle label)
	{
		GtkWidgetExterns.gtk_widget_remove_mnemonic_label(widget, label);
		return widget;
	}

	public static GtkWidgetHandle RemoveTickCallback(this GtkWidgetHandle widget, uint id)
	{
		GtkWidgetExterns.gtk_widget_remove_tick_callback(widget, id);
		return widget;
	}

	public static GdkPixbufHandle RenderIcon(this GtkWidgetHandle widget, string stock_id, GtkIconSize size, string detail)
	{
		return GtkWidgetExterns.gtk_widget_render_icon(widget, stock_id, size, detail);
	}

	public static GdkPixbufHandle RenderIconPixbuf(this GtkWidgetHandle widget, string stock_id, GtkIconSize size)
	{
		return GtkWidgetExterns.gtk_widget_render_icon_pixbuf(widget, stock_id, size);
	}

	public static GtkWidgetHandle Reparent(this GtkWidgetHandle widget, GtkWidgetHandle new_parent)
	{
		GtkWidgetExterns.gtk_widget_reparent(widget, new_parent);
		return widget;
	}

	public static GtkWidgetHandle ResetRcStyles(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_reset_rc_styles(widget);
		return widget;
	}

	public static GtkWidgetHandle ResetStyle(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_reset_style(widget);
		return widget;
	}

	public static int SendExpose(this GtkWidgetHandle widget, GdkEventHandle @event)
	{
		return GtkWidgetExterns.gtk_widget_send_expose(widget, @event);
	}

	public static bool SendFocusChange(this GtkWidgetHandle widget, GdkEventHandle @event)
	{
		return GtkWidgetExterns.gtk_widget_send_focus_change(widget, @event);
	}

	public static GtkWidgetHandle SetAccelPath(this GtkWidgetHandle widget, string accel_path, GtkAccelGroupHandle accel_group)
	{
		GtkWidgetExterns.gtk_widget_set_accel_path(widget, accel_path, accel_group);
		return widget;
	}

	public static GtkWidgetHandle SetAllocation(this GtkWidgetHandle widget, GtkAllocation[] allocation)
	{
		GtkWidgetExterns.gtk_widget_set_allocation(widget, allocation);
		return widget;
	}

	public static GtkWidgetHandle SetAppPaintable(this GtkWidgetHandle widget, bool app_paintable)
	{
		GtkWidgetExterns.gtk_widget_set_app_paintable(widget, app_paintable);
		return widget;
	}

	public static GtkWidgetHandle SetCanDefault(this GtkWidgetHandle widget, bool can_default)
	{
		GtkWidgetExterns.gtk_widget_set_can_default(widget, can_default);
		return widget;
	}

	public static GtkWidgetHandle SetCanFocus(this GtkWidgetHandle widget, bool can_focus)
	{
		GtkWidgetExterns.gtk_widget_set_can_focus(widget, can_focus);
		return widget;
	}

	public static GtkWidgetHandle SetChildVisible(this GtkWidgetHandle widget, bool is_visible)
	{
		GtkWidgetExterns.gtk_widget_set_child_visible(widget, is_visible);
		return widget;
	}

	public static GtkWidgetHandle SetClip(this GtkWidgetHandle widget, GtkAllocation[] clip)
	{
		GtkWidgetExterns.gtk_widget_set_clip(widget, clip);
		return widget;
	}

	public static GtkWidgetHandle SetCompositeName(this GtkWidgetHandle widget, string name)
	{
		GtkWidgetExterns.gtk_widget_set_composite_name(widget, name);
		return widget;
	}

	public static GtkWidgetHandle SetDeviceEnabled(this GtkWidgetHandle widget, GdkDeviceHandle device, bool enabled)
	{
		GtkWidgetExterns.gtk_widget_set_device_enabled(widget, device, enabled);
		return widget;
	}

	public static GtkWidgetHandle SetDeviceEvents(this GtkWidgetHandle widget, GdkDeviceHandle device, GdkEventMask events)
	{
		GtkWidgetExterns.gtk_widget_set_device_events(widget, device, events);
		return widget;
	}

	public static GtkWidgetHandle SetDirection(this GtkWidgetHandle widget, GtkTextDirection dir)
	{
		GtkWidgetExterns.gtk_widget_set_direction(widget, dir);
		return widget;
	}

	public static GtkWidgetHandle SetDoubleBuffered(this GtkWidgetHandle widget, bool double_buffered)
	{
		GtkWidgetExterns.gtk_widget_set_double_buffered(widget, double_buffered);
		return widget;
	}

	public static GtkWidgetHandle SetEvents(this GtkWidgetHandle widget, int events)
	{
		GtkWidgetExterns.gtk_widget_set_events(widget, events);
		return widget;
	}

	public static GtkWidgetHandle SetFocusOnClick(this GtkWidgetHandle widget, bool focus_on_click)
	{
		GtkWidgetExterns.gtk_widget_set_focus_on_click(widget, focus_on_click);
		return widget;
	}

	public static GtkWidgetHandle SetFontMap(this GtkWidgetHandle widget, PangoFontMapHandle font_map)
	{
		GtkWidgetExterns.gtk_widget_set_font_map(widget, font_map);
		return widget;
	}

	public static GtkWidgetHandle SetFontOptions(this GtkWidgetHandle widget, cairo_font_options_tHandle options)
	{
		GtkWidgetExterns.gtk_widget_set_font_options(widget, options);
		return widget;
	}

	public static GtkWidgetHandle SetHalign(this GtkWidgetHandle widget, GtkAlign align)
	{
		GtkWidgetExterns.gtk_widget_set_halign(widget, align);
		return widget;
	}

	public static GtkWidgetHandle SetHasTooltip(this GtkWidgetHandle widget, bool has_tooltip)
	{
		GtkWidgetExterns.gtk_widget_set_has_tooltip(widget, has_tooltip);
		return widget;
	}

	public static GtkWidgetHandle SetHasWindow(this GtkWidgetHandle widget, bool has_window)
	{
		GtkWidgetExterns.gtk_widget_set_has_window(widget, has_window);
		return widget;
	}

	public static GtkWidgetHandle SetHexpand(this GtkWidgetHandle widget, bool expand)
	{
		GtkWidgetExterns.gtk_widget_set_hexpand(widget, expand);
		return widget;
	}

	public static GtkWidgetHandle SetHexpandSet(this GtkWidgetHandle widget, bool set)
	{
		GtkWidgetExterns.gtk_widget_set_hexpand_set(widget, set);
		return widget;
	}

	public static GtkWidgetHandle SetMapped(this GtkWidgetHandle widget, bool mapped)
	{
		GtkWidgetExterns.gtk_widget_set_mapped(widget, mapped);
		return widget;
	}

	public static GtkWidgetHandle SetMarginBottom(this GtkWidgetHandle widget, int margin)
	{
		GtkWidgetExterns.gtk_widget_set_margin_bottom(widget, margin);
		return widget;
	}

	public static GtkWidgetHandle SetMarginEnd(this GtkWidgetHandle widget, int margin)
	{
		GtkWidgetExterns.gtk_widget_set_margin_end(widget, margin);
		return widget;
	}

	public static GtkWidgetHandle SetMarginLeft(this GtkWidgetHandle widget, int margin)
	{
		GtkWidgetExterns.gtk_widget_set_margin_left(widget, margin);
		return widget;
	}

	public static GtkWidgetHandle SetMarginRight(this GtkWidgetHandle widget, int margin)
	{
		GtkWidgetExterns.gtk_widget_set_margin_right(widget, margin);
		return widget;
	}

	public static GtkWidgetHandle SetMarginStart(this GtkWidgetHandle widget, int margin)
	{
		GtkWidgetExterns.gtk_widget_set_margin_start(widget, margin);
		return widget;
	}

	public static GtkWidgetHandle SetMarginTop(this GtkWidgetHandle widget, int margin)
	{
		GtkWidgetExterns.gtk_widget_set_margin_top(widget, margin);
		return widget;
	}

	public static GtkWidgetHandle SetName(this GtkWidgetHandle widget, string name)
	{
		GtkWidgetExterns.gtk_widget_set_name(widget, name);
		return widget;
	}

	public static GtkWidgetHandle SetNoShowAll(this GtkWidgetHandle widget, bool no_show_all)
	{
		GtkWidgetExterns.gtk_widget_set_no_show_all(widget, no_show_all);
		return widget;
	}

	public static GtkWidgetHandle SetOpacity(this GtkWidgetHandle widget, double opacity)
	{
		GtkWidgetExterns.gtk_widget_set_opacity(widget, opacity);
		return widget;
	}

	public static GtkWidgetHandle SetParent(this GtkWidgetHandle widget, GtkWidgetHandle parent)
	{
		GtkWidgetExterns.gtk_widget_set_parent(widget, parent);
		return widget;
	}

	public static GtkWidgetHandle SetParentWindow(this GtkWidgetHandle widget, GdkWindowHandle parent_window)
	{
		GtkWidgetExterns.gtk_widget_set_parent_window(widget, parent_window);
		return widget;
	}

	public static GtkWidgetHandle SetRealized(this GtkWidgetHandle widget, bool realized)
	{
		GtkWidgetExterns.gtk_widget_set_realized(widget, realized);
		return widget;
	}

	public static GtkWidgetHandle SetReceivesDefault(this GtkWidgetHandle widget, bool receives_default)
	{
		GtkWidgetExterns.gtk_widget_set_receives_default(widget, receives_default);
		return widget;
	}

	public static GtkWidgetHandle SetRedrawOnAllocate(this GtkWidgetHandle widget, bool redraw_on_allocate)
	{
		GtkWidgetExterns.gtk_widget_set_redraw_on_allocate(widget, redraw_on_allocate);
		return widget;
	}

	public static GtkWidgetHandle SetSensitive(this GtkWidgetHandle widget, bool sensitive)
	{
		GtkWidgetExterns.gtk_widget_set_sensitive(widget, sensitive);
		return widget;
	}

	public static GtkWidgetHandle SetSizeRequest(this GtkWidgetHandle widget, int width, int height)
	{
		GtkWidgetExterns.gtk_widget_set_size_request(widget, width, height);
		return widget;
	}

	public static GtkWidgetHandle SetState(this GtkWidgetHandle widget, GtkStateType state)
	{
		GtkWidgetExterns.gtk_widget_set_state(widget, state);
		return widget;
	}

	public static GtkWidgetHandle SetStateFlags(this GtkWidgetHandle widget, GtkStateFlags flags, bool clear)
	{
		GtkWidgetExterns.gtk_widget_set_state_flags(widget, flags, clear);
		return widget;
	}

	public static GtkWidgetHandle SetStyle(this GtkWidgetHandle widget, GtkStyleHandle style)
	{
		GtkWidgetExterns.gtk_widget_set_style(widget, style);
		return widget;
	}

	public static GtkWidgetHandle SetSupportMultidevice(this GtkWidgetHandle widget, bool support_multidevice)
	{
		GtkWidgetExterns.gtk_widget_set_support_multidevice(widget, support_multidevice);
		return widget;
	}

	public static GtkWidgetHandle SetTooltipMarkup(this GtkWidgetHandle widget, string markup)
	{
		GtkWidgetExterns.gtk_widget_set_tooltip_markup(widget, markup);
		return widget;
	}

	public static GtkWidgetHandle SetTooltipText(this GtkWidgetHandle widget, string text)
	{
		GtkWidgetExterns.gtk_widget_set_tooltip_text(widget, text);
		return widget;
	}

	public static GtkWidgetHandle SetTooltipWindow(this GtkWidgetHandle widget, GtkWindowHandle custom_window)
	{
		GtkWidgetExterns.gtk_widget_set_tooltip_window(widget, custom_window);
		return widget;
	}

	public static GtkWidgetHandle SetValign(this GtkWidgetHandle widget, GtkAlign align)
	{
		GtkWidgetExterns.gtk_widget_set_valign(widget, align);
		return widget;
	}

	public static GtkWidgetHandle SetVexpand(this GtkWidgetHandle widget, bool expand)
	{
		GtkWidgetExterns.gtk_widget_set_vexpand(widget, expand);
		return widget;
	}

	public static GtkWidgetHandle SetVexpandSet(this GtkWidgetHandle widget, bool set)
	{
		GtkWidgetExterns.gtk_widget_set_vexpand_set(widget, set);
		return widget;
	}

	public static GtkWidgetHandle SetVisible(this GtkWidgetHandle widget, bool visible)
	{
		GtkWidgetExterns.gtk_widget_set_visible(widget, visible);
		return widget;
	}

	public static GtkWidgetHandle SetVisual(this GtkWidgetHandle widget, GdkVisualHandle visual)
	{
		GtkWidgetExterns.gtk_widget_set_visual(widget, visual);
		return widget;
	}

	public static GtkWidgetHandle SetWindow(this GtkWidgetHandle widget, GdkWindowHandle window)
	{
		GtkWidgetExterns.gtk_widget_set_window(widget, window);
		return widget;
	}

	public static GtkWidgetHandle ShapeCombineRegion(this GtkWidgetHandle widget, cairo_region_tHandle region)
	{
		GtkWidgetExterns.gtk_widget_shape_combine_region(widget, region);
		return widget;
	}

	public static GtkWidgetHandle Show(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_show(widget);
		return widget;
	}

	public static GtkWidgetHandle ShowAll(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_show_all(widget);
		return widget;
	}

	public static GtkWidgetHandle ShowNow(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_show_now(widget);
		return widget;
	}

	public static GtkWidgetHandle SizeAllocate(this GtkWidgetHandle widget, GtkAllocationHandle allocation)
	{
		GtkWidgetExterns.gtk_widget_size_allocate(widget, allocation);
		return widget;
	}

	public static GtkWidgetHandle SizeAllocateWithBaseline(this GtkWidgetHandle widget, GtkAllocationHandle allocation, int baseline)
	{
		GtkWidgetExterns.gtk_widget_size_allocate_with_baseline(widget, allocation, baseline);
		return widget;
	}

	public static GtkWidgetHandle SizeRequest(this GtkWidgetHandle widget, out GtkRequisition requisition)
	{
		GtkWidgetExterns.gtk_widget_size_request(widget, out requisition);
		return widget;
	}

	public static GtkWidgetHandle StyleAttach(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_style_attach(widget);
		return widget;
	}

	public static GtkWidgetHandle StyleGet(this GtkWidgetHandle widget, string first_property_name, IntPtr @__arglist)
	{
		GtkWidgetExterns.gtk_widget_style_get(widget, first_property_name, @__arglist);
		return widget;
	}

	public static GtkWidgetHandle StyleGetProperty(this GtkWidgetHandle widget, string property_name, GValueHandle value)
	{
		GtkWidgetExterns.gtk_widget_style_get_property(widget, property_name, value);
		return widget;
	}

	public static GtkWidgetHandle StyleGetValist(this GtkWidgetHandle widget, string first_property_name, IntPtr var_args)
	{
		GtkWidgetExterns.gtk_widget_style_get_valist(widget, first_property_name, var_args);
		return widget;
	}

	public static GtkWidgetHandle ThawChildNotify(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_thaw_child_notify(widget);
		return widget;
	}

	public static bool TranslateCoordinates(this GtkWidgetHandle src_widget, GtkWidgetHandle dest_widget, int src_x, int src_y, out int dest_x, out int dest_y)
	{
		return GtkWidgetExterns.gtk_widget_translate_coordinates(src_widget, dest_widget, src_x, src_y, out dest_x, out dest_y);
	}

	public static GtkWidgetHandle TriggerTooltipQuery(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_trigger_tooltip_query(widget);
		return widget;
	}

	public static GtkWidgetHandle Unmap(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_unmap(widget);
		return widget;
	}

	public static GtkWidgetHandle Unparent(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_unparent(widget);
		return widget;
	}

	public static GtkWidgetHandle Unrealize(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_widget_unrealize(widget);
		return widget;
	}

	public static GtkWidgetHandle UnregisterWindow(this GtkWidgetHandle widget, GdkWindowHandle window)
	{
		GtkWidgetExterns.gtk_widget_unregister_window(widget, window);
		return widget;
	}

	public static GtkWidgetHandle UnsetStateFlags(this GtkWidgetHandle widget, GtkStateFlags flags)
	{
		GtkWidgetExterns.gtk_widget_unset_state_flags(widget, flags);
		return widget;
	}

	public static bool GtkTestWidgetSendKey(this GtkWidgetHandle widget, uint keyval, GdkModifierType modifiers)
	{
		return GtkWidgetExterns.gtk_test_widget_send_key(widget, keyval, modifiers);
	}

	public static GtkWidgetHandle GtkTestSliderSetPerc(this GtkWidgetHandle widget, double percentage)
	{
		GtkWidgetExterns.gtk_test_slider_set_perc(widget, percentage);
		return widget;
	}

	public static bool GtkTestWidgetClick(this GtkWidgetHandle widget, uint button, GdkModifierType modifiers)
	{
		return GtkWidgetExterns.gtk_test_widget_click(widget, button, modifiers);
	}

	public static GtkWidgetHandle GtkSelectionAddTargets(this GtkWidgetHandle widget, GdkAtom selection, GtkTargetEntry[] targets, uint ntargets)
	{
		GtkWidgetExterns.gtk_selection_add_targets(widget, selection, targets, ntargets);
		return widget;
	}

	public static double GtkTestSliderGetValue(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_test_slider_get_value(widget);
	}

	public static string GtkTestTextGet(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_test_text_get(widget);
	}

	public static GtkWidgetHandle GtkPropagateEvent(this GtkWidgetHandle widget, GdkEventHandle @event)
	{
		GtkWidgetExterns.gtk_propagate_event(widget, @event);
		return widget;
	}

	public static GtkWidgetHandle GtkTestWidgetWaitForDraw(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_test_widget_wait_for_draw(widget);
		return widget;
	}

	public static GtkWidgetHandle GtkTestFindWidget(this GtkWidgetHandle widget, string label_pattern, GType widget_type)
	{
		return GtkWidgetExterns.gtk_test_find_widget(widget, label_pattern, widget_type);
	}

	public static bool GtkSelectionConvert(this GtkWidgetHandle widget, GdkAtom selection, GdkAtom target, uint time_)
	{
		return GtkWidgetExterns.gtk_selection_convert(widget, selection, target, time_);
	}

	public static GtkWidgetHandle GtkSelectionAddTarget(this GtkWidgetHandle widget, GdkAtom selection, GdkAtom target, uint info)
	{
		GtkWidgetExterns.gtk_selection_add_target(widget, selection, target, info);
		return widget;
	}

	public static GtkStyleHandle GtkRcGetStyle(this GtkWidgetHandle widget)
	{
		return GtkWidgetExterns.gtk_rc_get_style(widget);
	}

	public static GtkWidgetHandle GtkSelectionClearTargets(this GtkWidgetHandle widget, GdkAtom selection)
	{
		GtkWidgetExterns.gtk_selection_clear_targets(widget, selection);
		return widget;
	}

	public static GtkWidgetHandle GtkTestFindSibling(this GtkWidgetHandle base_widget, GType widget_type)
	{
		return GtkWidgetExterns.gtk_test_find_sibling(base_widget, widget_type);
	}

	public static GtkWidgetHandle GtkSelectionRemoveAll(this GtkWidgetHandle widget)
	{
		GtkWidgetExterns.gtk_selection_remove_all(widget);
		return widget;
	}

	public static GtkWidgetHandle GtkDrawInsertionCursor(this GtkWidgetHandle widget, cairo_tHandle cr, GdkRectangleHandle location, bool is_primary, GtkTextDirection direction, bool draw_arrow)
	{
		GtkWidgetExterns.gtk_draw_insertion_cursor(widget, cr, location, is_primary, direction, draw_arrow);
		return widget;
	}

	public static GtkWidgetHandle GtkTestTextSet(this GtkWidgetHandle widget, string @string)
	{
		GtkWidgetExterns.gtk_test_text_set(widget, @string);
		return widget;
	}

	public static GtkWidgetHandle GtkDeviceGrabRemove(this GtkWidgetHandle widget, GdkDeviceHandle device)
	{
		GtkWidgetExterns.gtk_device_grab_remove(widget, device);
		return widget;
	}

	public static GtkWidgetHandle GtkTestFindLabel(this GtkWidgetHandle widget, string label_pattern)
	{
		return GtkWidgetExterns.gtk_test_find_label(widget, label_pattern);
	}

	public static GtkWidgetHandle GtkDeviceGrabAdd(this GtkWidgetHandle widget, GdkDeviceHandle device, bool block_others)
	{
		GtkWidgetExterns.gtk_device_grab_add(widget, device, block_others);
		return widget;
	}

	public static bool GtkSelectionOwnerSet(this GtkWidgetHandle widget, GdkAtom selection, uint time_)
	{
		return GtkWidgetExterns.gtk_selection_owner_set(widget, selection, time_);
	}

}

internal class GtkWidgetExterns
{
	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_widget_new(GType type, string first_property_name, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_activate(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_add_accelerator(GtkWidgetHandle widget, string accel_signal, GtkAccelGroupHandle accel_group, uint accel_key, GdkModifierType accel_mods, GtkAccelFlags accel_flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_add_device_events(GtkWidgetHandle widget, GdkDeviceHandle device, GdkEventMask events);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_add_events(GtkWidgetHandle widget, int events);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_add_mnemonic_label(GtkWidgetHandle widget, GtkWidgetHandle label);

	[DllImport(Libraries.Gtk3)]
	internal static extern uint gtk_widget_add_tick_callback(GtkWidgetHandle widget, GtkTickCallback callback, IntPtr user_data, GDestroyNotify notify);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_can_activate_accel(GtkWidgetHandle widget, uint signal_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_child_focus(GtkWidgetHandle widget, GtkDirectionType direction);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_child_notify(GtkWidgetHandle widget, string child_property);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_class_path(GtkWidgetHandle widget, out uint path_length, out string path, out string path_reversed);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_compute_expand(GtkWidgetHandle widget, GtkOrientation orientation);

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoContextHandle gtk_widget_create_pango_context(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoLayoutHandle gtk_widget_create_pango_layout(GtkWidgetHandle widget, string text);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_destroy(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_destroyed(GtkWidgetHandle widget, ref GtkWidgetHandle widget_pointer);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_device_is_shadowed(GtkWidgetHandle widget, GdkDeviceHandle device);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkDragContextHandle gtk_drag_begin(GtkWidgetHandle widget, GtkTargetListHandle targets, GdkDragAction actions, int button, GdkEventHandle @event);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkDragContextHandle gtk_drag_begin_with_coordinates(GtkWidgetHandle widget, GtkTargetListHandle targets, GdkDragAction actions, int button, GdkEventHandle @event, int x, int y);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_drag_check_threshold(GtkWidgetHandle widget, int start_x, int start_y, int current_x, int current_y);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_dest_add_image_targets(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_dest_add_text_targets(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_dest_add_uri_targets(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkAtom gtk_drag_dest_find_target(GtkWidgetHandle widget, GdkDragContextHandle context, GtkTargetListHandle target_list);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTargetListHandle gtk_drag_dest_get_target_list(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_drag_dest_get_track_motion(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_dest_set(GtkWidgetHandle widget, GtkDestDefaults flags, GtkTargetEntry[] targets, int n_targets, GdkDragAction actions);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_dest_set_proxy(GtkWidgetHandle widget, GdkWindowHandle proxy_window, GdkDragProtocol protocol, bool use_coordinates);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_dest_set_target_list(GtkWidgetHandle widget, GtkTargetListHandle target_list);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_dest_set_track_motion(GtkWidgetHandle widget, bool track_motion);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_dest_unset(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_get_data(GtkWidgetHandle widget, GdkDragContextHandle context, GdkAtom target, uint time_);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_highlight(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_source_add_image_targets(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_source_add_text_targets(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_source_add_uri_targets(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTargetListHandle gtk_drag_source_get_target_list(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_source_set(GtkWidgetHandle widget, GdkModifierType start_button_mask, GtkTargetEntry[] targets, int n_targets, GdkDragAction actions);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_source_set_icon_gicon(GtkWidgetHandle widget, GIconHandle icon);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_source_set_icon_name(GtkWidgetHandle widget, string icon_name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_source_set_icon_pixbuf(GtkWidgetHandle widget, GdkPixbufHandle pixbuf);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_source_set_icon_stock(GtkWidgetHandle widget, string stock_id);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_source_set_target_list(GtkWidgetHandle widget, GtkTargetListHandle target_list);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_source_unset(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_drag_unhighlight(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_draw(GtkWidgetHandle widget, cairo_tHandle cr);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_ensure_style(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_error_bell(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_event(GtkWidgetHandle widget, GdkEventHandle @event);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_freeze_child_notify(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern AtkObjectHandle gtk_widget_get_accessible(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GActionGroupHandle gtk_widget_get_action_group(GtkWidgetHandle widget, string prefix);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_widget_get_allocated_baseline(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_widget_get_allocated_height(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_get_allocated_size(GtkWidgetHandle widget, out GtkAllocation allocation, out int baseline);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_widget_get_allocated_width(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_get_allocation(GtkWidgetHandle widget, out GtkAllocation allocation);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_widget_get_ancestor(GtkWidgetHandle widget, GType widget_type);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_get_app_paintable(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_get_can_default(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_get_can_focus(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_get_child_requisition(GtkWidgetHandle widget, out GtkRequisition requisition);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_get_child_visible(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_get_clip(GtkWidgetHandle widget, out GtkAllocation clip);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkClipboardHandle gtk_widget_get_clipboard(GtkWidgetHandle widget, GdkAtom selection);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_widget_get_composite_name(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_get_device_enabled(GtkWidgetHandle widget, GdkDeviceHandle device);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkEventMask gtk_widget_get_device_events(GtkWidgetHandle widget, GdkDeviceHandle device);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTextDirection gtk_widget_get_direction(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkDisplayHandle gtk_widget_get_display(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_get_double_buffered(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_widget_get_events(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_get_focus_on_click(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoFontMapHandle gtk_widget_get_font_map(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern cairo_font_options_tHandle gtk_widget_get_font_options(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkFrameClockHandle gtk_widget_get_frame_clock(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAlign gtk_widget_get_halign(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_get_has_tooltip(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_get_has_window(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_get_hexpand(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_get_hexpand_set(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_get_mapped(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_widget_get_margin_bottom(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_widget_get_margin_end(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_widget_get_margin_left(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_widget_get_margin_right(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_widget_get_margin_start(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_widget_get_margin_top(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkModifierType gtk_widget_get_modifier_mask(GtkWidgetHandle widget, GdkModifierIntent intent);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkRcStyleHandle gtk_widget_get_modifier_style(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	[return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef = typeof(NoNativeFreeStringMarshaller))]
	internal static extern string gtk_widget_get_name(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_get_no_show_all(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_widget_get_opacity(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern PangoContextHandle gtk_widget_get_pango_context(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_widget_get_parent(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkWindowHandle gtk_widget_get_parent_window(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetPathHandle gtk_widget_get_path(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_get_pointer(GtkWidgetHandle widget, out int x, out int y);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_get_preferred_height(GtkWidgetHandle widget, out int minimum_height, out int natural_height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_get_preferred_height_and_baseline_for_width(GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height, out int minimum_baseline, out int natural_baseline);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_get_preferred_height_for_width(GtkWidgetHandle widget, int width, out int minimum_height, out int natural_height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_get_preferred_size(GtkWidgetHandle widget, out GtkRequisition minimum_size, out GtkRequisition natural_size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_get_preferred_width(GtkWidgetHandle widget, out int minimum_width, out int natural_width);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_get_preferred_width_for_height(GtkWidgetHandle widget, int height, out int minimum_width, out int natural_width);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_get_realized(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_get_receives_default(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSizeRequestMode gtk_widget_get_request_mode(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_get_requisition(GtkWidgetHandle widget, out GtkRequisition requisition);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkWindowHandle gtk_widget_get_root_window(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_widget_get_scale_factor(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkScreenHandle gtk_widget_get_screen(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_get_sensitive(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkSettingsHandle gtk_widget_get_settings(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_get_size_request(GtkWidgetHandle widget, out int width, out int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStateType gtk_widget_get_state(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStateFlags gtk_widget_get_state_flags(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStyleHandle gtk_widget_get_style(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStyleContextHandle gtk_widget_get_style_context(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_get_support_multidevice(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GObjectHandle gtk_widget_get_template_child(GtkWidgetHandle widget, GType widget_type, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_widget_get_tooltip_markup(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_widget_get_tooltip_text(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWindowHandle gtk_widget_get_tooltip_window(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_widget_get_toplevel(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAlign gtk_widget_get_valign(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkAlign gtk_widget_get_valign_with_baseline(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_get_vexpand(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_get_vexpand_set(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_get_visible(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkVisualHandle gtk_widget_get_visual(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkWindowHandle gtk_widget_get_window(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_grab_add(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_grab_default(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_grab_focus(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_grab_remove(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_has_default(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_has_focus(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_has_grab(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_has_rc_style(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_has_screen(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_has_visible_focus(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_hide(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_hide_on_delete(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_in_destruction(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_init_template(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_input_shape_combine_region(GtkWidgetHandle widget, cairo_region_tHandle region);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_insert_action_group(GtkWidgetHandle widget, string name, GActionGroupHandle group);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_intersect(GtkWidgetHandle widget, GdkRectangleHandle area, out GdkRectangle intersection);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_is_ancestor(GtkWidgetHandle widget, GtkWidgetHandle ancestor);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_is_composited(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_is_drawable(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_is_focus(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_is_sensitive(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_is_toplevel(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_is_visible(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_keynav_failed(GtkWidgetHandle widget, GtkDirectionType direction);

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_widget_list_accel_closures(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern IntPtr gtk_widget_list_action_prefixes(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GListHandle gtk_widget_list_mnemonic_labels(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_map(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_mnemonic_activate(GtkWidgetHandle widget, bool group_cycling);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_modify_base(GtkWidgetHandle widget, GtkStateType state, GdkColorHandle color);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_modify_bg(GtkWidgetHandle widget, GtkStateType state, GdkColorHandle color);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_modify_cursor(GtkWidgetHandle widget, GdkColorHandle primary, GdkColorHandle secondary);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_modify_fg(GtkWidgetHandle widget, GtkStateType state, GdkColorHandle color);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_modify_font(GtkWidgetHandle widget, PangoFontDescriptionHandle font_desc);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_modify_style(GtkWidgetHandle widget, GtkRcStyleHandle style);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_modify_text(GtkWidgetHandle widget, GtkStateType state, GdkColorHandle color);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_override_background_color(GtkWidgetHandle widget, GtkStateFlags state, GdkRGBAHandle color);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_override_color(GtkWidgetHandle widget, GtkStateFlags state, GdkRGBAHandle color);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_override_cursor(GtkWidgetHandle widget, GdkRGBAHandle cursor, GdkRGBAHandle secondary_cursor);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_override_font(GtkWidgetHandle widget, PangoFontDescriptionHandle font_desc);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_override_symbolic_color(GtkWidgetHandle widget, string name, GdkRGBAHandle color);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_path(GtkWidgetHandle widget, out uint path_length, out string path, out string path_reversed);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_queue_allocate(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_queue_compute_expand(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_queue_draw(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_queue_draw_area(GtkWidgetHandle widget, int x, int y, int width, int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_queue_draw_region(GtkWidgetHandle widget, cairo_region_tHandle region);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_queue_resize(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_queue_resize_no_redraw(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_realize(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern cairo_region_tHandle gtk_widget_region_intersect(GtkWidgetHandle widget, cairo_region_tHandle region);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_register_window(GtkWidgetHandle widget, GdkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_remove_accelerator(GtkWidgetHandle widget, GtkAccelGroupHandle accel_group, uint accel_key, GdkModifierType accel_mods);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_remove_mnemonic_label(GtkWidgetHandle widget, GtkWidgetHandle label);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_remove_tick_callback(GtkWidgetHandle widget, uint id);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_widget_render_icon(GtkWidgetHandle widget, string stock_id, GtkIconSize size, string detail);

	[DllImport(Libraries.Gtk3)]
	internal static extern GdkPixbufHandle gtk_widget_render_icon_pixbuf(GtkWidgetHandle widget, string stock_id, GtkIconSize size);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_reparent(GtkWidgetHandle widget, GtkWidgetHandle new_parent);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_reset_rc_styles(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_reset_style(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern int gtk_widget_send_expose(GtkWidgetHandle widget, GdkEventHandle @event);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_send_focus_change(GtkWidgetHandle widget, GdkEventHandle @event);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_accel_path(GtkWidgetHandle widget, string accel_path, GtkAccelGroupHandle accel_group);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_allocation(GtkWidgetHandle widget, GtkAllocation[] allocation);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_app_paintable(GtkWidgetHandle widget, bool app_paintable);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_can_default(GtkWidgetHandle widget, bool can_default);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_can_focus(GtkWidgetHandle widget, bool can_focus);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_child_visible(GtkWidgetHandle widget, bool is_visible);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_clip(GtkWidgetHandle widget, GtkAllocation[] clip);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_composite_name(GtkWidgetHandle widget, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_device_enabled(GtkWidgetHandle widget, GdkDeviceHandle device, bool enabled);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_device_events(GtkWidgetHandle widget, GdkDeviceHandle device, GdkEventMask events);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_direction(GtkWidgetHandle widget, GtkTextDirection dir);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_double_buffered(GtkWidgetHandle widget, bool double_buffered);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_events(GtkWidgetHandle widget, int events);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_focus_on_click(GtkWidgetHandle widget, bool focus_on_click);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_font_map(GtkWidgetHandle widget, PangoFontMapHandle font_map);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_font_options(GtkWidgetHandle widget, cairo_font_options_tHandle options);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_halign(GtkWidgetHandle widget, GtkAlign align);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_has_tooltip(GtkWidgetHandle widget, bool has_tooltip);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_has_window(GtkWidgetHandle widget, bool has_window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_hexpand(GtkWidgetHandle widget, bool expand);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_hexpand_set(GtkWidgetHandle widget, bool set);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_mapped(GtkWidgetHandle widget, bool mapped);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_margin_bottom(GtkWidgetHandle widget, int margin);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_margin_end(GtkWidgetHandle widget, int margin);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_margin_left(GtkWidgetHandle widget, int margin);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_margin_right(GtkWidgetHandle widget, int margin);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_margin_start(GtkWidgetHandle widget, int margin);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_margin_top(GtkWidgetHandle widget, int margin);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_name(GtkWidgetHandle widget, string name);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_no_show_all(GtkWidgetHandle widget, bool no_show_all);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_opacity(GtkWidgetHandle widget, double opacity);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_parent(GtkWidgetHandle widget, GtkWidgetHandle parent);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_parent_window(GtkWidgetHandle widget, GdkWindowHandle parent_window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_realized(GtkWidgetHandle widget, bool realized);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_receives_default(GtkWidgetHandle widget, bool receives_default);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_redraw_on_allocate(GtkWidgetHandle widget, bool redraw_on_allocate);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_sensitive(GtkWidgetHandle widget, bool sensitive);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_size_request(GtkWidgetHandle widget, int width, int height);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_state(GtkWidgetHandle widget, GtkStateType state);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_state_flags(GtkWidgetHandle widget, GtkStateFlags flags, bool clear);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_style(GtkWidgetHandle widget, GtkStyleHandle style);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_support_multidevice(GtkWidgetHandle widget, bool support_multidevice);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_tooltip_markup(GtkWidgetHandle widget, string markup);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_tooltip_text(GtkWidgetHandle widget, string text);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_tooltip_window(GtkWidgetHandle widget, GtkWindowHandle custom_window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_valign(GtkWidgetHandle widget, GtkAlign align);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_vexpand(GtkWidgetHandle widget, bool expand);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_vexpand_set(GtkWidgetHandle widget, bool set);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_visible(GtkWidgetHandle widget, bool visible);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_visual(GtkWidgetHandle widget, GdkVisualHandle visual);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_window(GtkWidgetHandle widget, GdkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_shape_combine_region(GtkWidgetHandle widget, cairo_region_tHandle region);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_show(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_show_all(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_show_now(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_size_allocate(GtkWidgetHandle widget, GtkAllocationHandle allocation);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_size_allocate_with_baseline(GtkWidgetHandle widget, GtkAllocationHandle allocation, int baseline);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_size_request(GtkWidgetHandle widget, out GtkRequisition requisition);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_style_attach(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_style_get(GtkWidgetHandle widget, string first_property_name, IntPtr @__arglist);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_style_get_property(GtkWidgetHandle widget, string property_name, GValueHandle value);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_style_get_valist(GtkWidgetHandle widget, string first_property_name, IntPtr var_args);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_thaw_child_notify(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_widget_translate_coordinates(GtkWidgetHandle src_widget, GtkWidgetHandle dest_widget, int src_x, int src_y, out int dest_x, out int dest_y);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_trigger_tooltip_query(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_unmap(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_unparent(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_unrealize(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_unregister_window(GtkWidgetHandle widget, GdkWindowHandle window);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_unset_state_flags(GtkWidgetHandle widget, GtkStateFlags flags);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_test_widget_send_key(GtkWidgetHandle widget, uint keyval, GdkModifierType modifiers);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_test_slider_set_perc(GtkWidgetHandle widget, double percentage);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_test_widget_click(GtkWidgetHandle widget, uint button, GdkModifierType modifiers);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_selection_add_targets(GtkWidgetHandle widget, GdkAtom selection, GtkTargetEntry[] targets, uint ntargets);

	[DllImport(Libraries.Gtk3)]
	internal static extern double gtk_test_slider_get_value(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern string gtk_test_text_get(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_propagate_event(GtkWidgetHandle widget, GdkEventHandle @event);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_test_widget_wait_for_draw(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_test_find_widget(GtkWidgetHandle widget, string label_pattern, GType widget_type);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_selection_convert(GtkWidgetHandle widget, GdkAtom selection, GdkAtom target, uint time_);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_selection_add_target(GtkWidgetHandle widget, GdkAtom selection, GdkAtom target, uint info);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStyleHandle gtk_rc_get_style(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_selection_clear_targets(GtkWidgetHandle widget, GdkAtom selection);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_test_find_sibling(GtkWidgetHandle base_widget, GType widget_type);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_selection_remove_all(GtkWidgetHandle widget);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_draw_insertion_cursor(GtkWidgetHandle widget, cairo_tHandle cr, GdkRectangleHandle location, bool is_primary, GtkTextDirection direction, bool draw_arrow);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_test_text_set(GtkWidgetHandle widget, string @string);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_device_grab_remove(GtkWidgetHandle widget, GdkDeviceHandle device);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkWidgetHandle gtk_test_find_label(GtkWidgetHandle widget, string label_pattern);

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_device_grab_add(GtkWidgetHandle widget, GdkDeviceHandle device, bool block_others);

	[DllImport(Libraries.Gtk3)]
	internal static extern bool gtk_selection_owner_set(GtkWidgetHandle widget, GdkAtom selection, uint time_);

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkTextDirection gtk_widget_get_default_direction();

	[DllImport(Libraries.Gtk3)]
	internal static extern GtkStyleHandle gtk_widget_get_default_style();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_pop_composite_child();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_push_composite_child();

	[DllImport(Libraries.Gtk3)]
	internal static extern void gtk_widget_set_default_direction(GtkTextDirection dir);

}
