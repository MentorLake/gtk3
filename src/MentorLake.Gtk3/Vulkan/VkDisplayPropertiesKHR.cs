namespace MentorLake.Vulkan;

public class VkDisplayPropertiesKHRHandle : BaseSafeHandle
{
}


public static class VkDisplayPropertiesKHRExtensions
{

	public static VkDisplayPropertiesKHR Dereference(this VkDisplayPropertiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDisplayPropertiesKHR>(x.DangerousGetHandle());
}
internal class VkDisplayPropertiesKHRExterns
{
}

public struct VkDisplayPropertiesKHR
{
}
