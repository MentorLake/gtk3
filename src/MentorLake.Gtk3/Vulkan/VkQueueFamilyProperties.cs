namespace MentorLake.Vulkan;

public class VkQueueFamilyPropertiesHandle : BaseSafeHandle
{
}


public static class VkQueueFamilyPropertiesExtensions
{

	public static VkQueueFamilyProperties Dereference(this VkQueueFamilyPropertiesHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueueFamilyProperties>(x.DangerousGetHandle());
}
internal class VkQueueFamilyPropertiesExterns
{
}

public struct VkQueueFamilyProperties
{
}
