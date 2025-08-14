namespace MentorLake.Vulkan;


public class VkExternalFenceFeatureFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkExternalFenceFeatureFlagsKHRExtensions
{

	public static VkExternalFenceFeatureFlagsKHR Dereference(this VkExternalFenceFeatureFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkExternalFenceFeatureFlagsKHR>(x.DangerousGetHandle());
}
internal class VkExternalFenceFeatureFlagsKHRExterns
{
}


public struct VkExternalFenceFeatureFlagsKHR
{
}
