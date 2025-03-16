namespace MentorLake.Vulkan;

public class VkQueueFamilyProperties2Handle : BaseSafeHandle
{
}


public static class VkQueueFamilyProperties2Extensions
{

	public static VkQueueFamilyProperties2 Dereference(this VkQueueFamilyProperties2Handle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueueFamilyProperties2>(x.DangerousGetHandle());
}
internal class VkQueueFamilyProperties2Externs
{
}

public struct VkQueueFamilyProperties2
{
}
