namespace MentorLake.Vulkan;


public class VkDisplayPlaneProperties2KHRHandle : BaseSafeHandle
{
}


public static class VkDisplayPlaneProperties2KHRExtensions
{

	public static VkDisplayPlaneProperties2KHR Dereference(this VkDisplayPlaneProperties2KHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplayPlaneProperties2KHR>(x.DangerousGetHandle());
}
internal class VkDisplayPlaneProperties2KHRExterns
{
}


public struct VkDisplayPlaneProperties2KHR
{
}
