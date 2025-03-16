namespace MentorLake.Vulkan;

public class VkVideoCapabilityFlagBitsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoCapabilityFlagBitsKHRExtensions
{

	public static VkVideoCapabilityFlagBitsKHR Dereference(this VkVideoCapabilityFlagBitsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoCapabilityFlagBitsKHR>(x.DangerousGetHandle());
}
internal class VkVideoCapabilityFlagBitsKHRExterns
{
}

public struct VkVideoCapabilityFlagBitsKHR
{
}
