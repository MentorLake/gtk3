namespace MentorLake.Vulkan;

public class VkDisplayPlaneInfo2KHRHandle : BaseSafeHandle
{
}


public static class VkDisplayPlaneInfo2KHRExtensions
{

	public static VkDisplayPlaneInfo2KHR Dereference(this VkDisplayPlaneInfo2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplayPlaneInfo2KHR>(x.DangerousGetHandle());
}
internal class VkDisplayPlaneInfo2KHRExterns
{
}

public struct VkDisplayPlaneInfo2KHR
{
}
