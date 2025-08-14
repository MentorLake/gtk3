namespace MentorLake.Vulkan;


public class VkQueueFamilyCheckpointProperties2NVHandle : BaseSafeHandle
{
}


public static class VkQueueFamilyCheckpointProperties2NVExtensions
{

	public static VkQueueFamilyCheckpointProperties2NV Dereference(this VkQueueFamilyCheckpointProperties2NVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueueFamilyCheckpointProperties2NV>(x.DangerousGetHandle());
}
internal class VkQueueFamilyCheckpointProperties2NVExterns
{
}


public struct VkQueueFamilyCheckpointProperties2NV
{
}
