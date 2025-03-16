namespace MentorLake.Vulkan;

public class VkVideoCapabilityFlagsKHRHandle : BaseSafeHandle
{
}


public static class VkVideoCapabilityFlagsKHRExtensions
{

	public static VkVideoCapabilityFlagsKHR Dereference(this VkVideoCapabilityFlagsKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoCapabilityFlagsKHR>(x.DangerousGetHandle());
}
internal class VkVideoCapabilityFlagsKHRExterns
{
}

public struct VkVideoCapabilityFlagsKHR
{
}
