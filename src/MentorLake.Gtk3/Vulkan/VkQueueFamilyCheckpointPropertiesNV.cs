namespace MentorLake.Vulkan;

public class VkQueueFamilyCheckpointPropertiesNVHandle : BaseSafeHandle
{
}


public static class VkQueueFamilyCheckpointPropertiesNVExtensions
{

	public static VkQueueFamilyCheckpointPropertiesNV Dereference(this VkQueueFamilyCheckpointPropertiesNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkQueueFamilyCheckpointPropertiesNV>(x.DangerousGetHandle());
}
internal class VkQueueFamilyCheckpointPropertiesNVExterns
{
}

public struct VkQueueFamilyCheckpointPropertiesNV
{
}
