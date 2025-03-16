namespace MentorLake.Vulkan;

public class VkExternalMemoryFeatureFlagsNVHandle : BaseSafeHandle
{
}


public static class VkExternalMemoryFeatureFlagsNVExtensions
{

	public static VkExternalMemoryFeatureFlagsNV Dereference(this VkExternalMemoryFeatureFlagsNVHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalMemoryFeatureFlagsNV>(x.DangerousGetHandle());
}
internal class VkExternalMemoryFeatureFlagsNVExterns
{
}

public struct VkExternalMemoryFeatureFlagsNV
{
}
