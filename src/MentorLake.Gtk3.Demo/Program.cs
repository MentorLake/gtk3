using System.Reactive.Linq;
using MentorLake.Gtk3.Cairo;
using MentorLake.Gtk3.Gio;
using MentorLake.Gtk3.GObject;
using MentorLake.Gtk3.Gtk3;

namespace MentorLake.Gtk3.Demo;

public static class Program
{
	public static void Main(string[] args)
	{
		SynchronizationContext.SetSynchronizationContext(new GLibSynchronizationContext());

		var appHandle = GtkApplicationHandle.New("my.app", GApplicationFlags.G_APPLICATION_FLAGS_NONE);

		appHandle.Signal_Activate().Subscribe(async e =>
		{
			var window = GtkWindowHandle.New(GtkWindowType.GTK_WINDOW_TOPLEVEL)
				.Add(GtkBoxHandle.New(GtkOrientation.GTK_ORIENTATION_HORIZONTAL, 0)
					.Add(GtkDrawingAreaHandle.New()
						.SetManagedData("DrawingAreaKeyVal", "TestValue")
						.With(d => d.Signal_Draw().Subscribe(arg =>
						{
							arg.Cr.CairoArc(0, 0, 10, 0, 180);
							arg.Cr.CairoStroke();
						}))
						.SetSizeRequest(200, 200))
					.Add(GtkButtonHandle.New()
						.SetLabel("TEST")
						.SetManagedData("SomeKey", "TestValue")
						.With(b =>
						{
							var motionController = GtkEventControllerMotionHandle.New(b);
							motionController.Signal_Enter().TakeUntil(b.Signal_Destroy().Take(1)).Subscribe(_ =>
							{
								Console.WriteLine(b.GetManagedData<string>("SomeKey"));
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
			await Task.Delay(5000);
			window.Destroy();
		});

		appHandle.Run(0, null);
	}
}
