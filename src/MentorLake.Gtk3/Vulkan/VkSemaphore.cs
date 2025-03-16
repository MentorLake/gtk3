namespace MentorLake.Vulkan;

public class VkSemaphoreHandle : BaseSafeHandle
{
}


public static class VkSemaphoreExtensions
{

	public static VkSemaphore Dereference(this VkSemaphoreHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkSemaphore>(x.DangerousGetHandle());
}
internal class VkSemaphoreExterns
{
}

public struct VkSemaphore
{
}
