namespace MentorLake.Vulkan;


public class VkExternalMemoryFeatureFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkExternalMemoryFeatureFlagsKHRExtensions
{

	public static VkExternalMemoryFeatureFlagsKHR Dereference(this VkExternalMemoryFeatureFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalMemoryFeatureFlagsKHR>(x.DangerousGetHandle());
}
internal class VkExternalMemoryFeatureFlagsKHRExterns
{
}


public struct VkExternalMemoryFeatureFlagsKHR
{
}
