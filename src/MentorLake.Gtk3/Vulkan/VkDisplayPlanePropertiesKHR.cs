namespace MentorLake.Vulkan;

public class VkDisplayPlanePropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkDisplayPlanePropertiesKHRExtensions
{

	public static VkDisplayPlanePropertiesKHR Dereference(this VkDisplayPlanePropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplayPlanePropertiesKHR>(x.DangerousGetHandle());
}
internal class VkDisplayPlanePropertiesKHRExterns
{
}

public struct VkDisplayPlanePropertiesKHR
{
}
