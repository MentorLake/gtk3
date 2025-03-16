namespace MentorLake.Vulkan;

public class VkDisplayKHRHandle : BaseSafeHandle
{
}


public static class VkDisplayKHRExtensions
{

	public static VkDisplayKHR Dereference(this VkDisplayKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplayKHR>(x.DangerousGetHandle());
}
internal class VkDisplayKHRExterns
{
}

public struct VkDisplayKHR
{
}
