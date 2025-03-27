using System.Reactive.Linq;
using System.Runtime.InteropServices;
using MentorLake.Gdk;
using MentorLake.Gio;
using MentorLake.GLib;
using MentorLake.GObject;
using MentorLake.Gtk;

namespace MentorLake.Gtk3.Demo;

public static class Program
{
	public static List<T> ToList<T>(this GListHandle gListHandle) where T : SafeHandle, new()
	{
		var length = GList.Length(gListHandle);
		var result = new List<T>((int) length);

		for (uint i = 0; i < length; i++)
		{
			var safeHandle = new T();
			Marshal.InitHandle(safeHandle, GList.NthData(gListHandle, i));
			result.Add(safeHandle);
		}

		return result;
	}

	public static async Task Main(string[] args)
	{
		SynchronizationContext.SetSynchronizationContext(new GLibSynchronizationContext());

		var appHandle = GtkApplicationHandle.New("my.app", GApplicationFlags.G_APPLICATION_FLAGS_NONE);

		appHandle.Signal_Activate().Subscribe(async e =>
		{
			var desktopFiles = GAppInfoHandleExtensions.GetAll();
			desktopFiles
				.ToList<GDesktopAppInfoHandle>()
				.Where(a => a.ShouldShow())
				.ToList()
				.ForEach(a => Console.WriteLine($"{a.GetName()} {string.Join(", ", a.ListActions())}"));

			var window = GtkWindowHandle.New(GtkWindowType.GTK_WINDOW_TOPLEVEL)
				.SetEvents((int) GdkEventMask.GDK_ALL_EVENTS_MASK)
				.With(b => b.Signal_KeyPressEvent(GConnectFlags.G_CONNECT_DEFAULT).Select(x => x.Event.Dereference()).Subscribe(e =>
				{
					Console.WriteLine(e.@string);
					GC.Collect();
				}))
				.Add(GtkBoxHandle.New(GtkOrientation.GTK_ORIENTATION_HORIZONTAL, 0)
					.Add(GtkDrawingAreaHandle.New()
						.SetManagedData("DrawingAreaKeyVal", "TestValue")
						.With(d => d.Signal_Draw().Subscribe(arg =>
						{
							cairo.cairoGlobalFunctions.Arc(arg.Cr, 0, 0, 10, 0, 180);
							cairo.cairoGlobalFunctions.Stroke(arg.Cr);
						}))
						.SetSizeRequest(200, 200))
					.Add(GtkButtonHandle.New()
						.SetLabel("TEST")
						.SetEvents((int) GdkEventMask.GDK_ALL_EVENTS_MASK)
						.SetManagedData("SomeKey", "TestValue")
						.With(b =>
						{
							var motionController = GtkEventControllerMotionHandle.New(b);
							b.SetEvents((int)GdkEventMask.GDK_ALL_EVENTS_MASK);
							motionController.Signal_Motion().TakeUntil(b.Signal_Destroy().Take(1)).Subscribe(z =>
							{
								Console.WriteLine(b.GetManagedData<string>("SomeKey") + " " + z.X + " " + z.Y);
							});
						})
						.With(b => b.Signal_Clicked().TakeUntil(b.Signal_Destroy().Take(1)).Subscribe(_ =>
						{
							Console.WriteLine();
							Console.WriteLine(b.GetLabel());
							Console.WriteLine(b.GetLabel());
							Console.WriteLine(b.GetLabel());
							Console.WriteLine(b.GetAllocatedHeight());
							Console.WriteLine(b.GetAllocatedHeight());
						}, _ => { }, () => Console.WriteLine("UNSUB"))))
					.Add(GtkImageHandle.NewFromIconName("face-smile", GtkIconSize.GTK_ICON_SIZE_LARGE_TOOLBAR)
						.SetSizeRequest(64, 64)));

			window.ShowAll();
			appHandle.AddWindow(window);
			await Task.Delay(3000);
			GC.Collect();
			window.Destroy();
		});

		appHandle.Run(0, null);
	}
}
