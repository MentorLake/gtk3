namespace MentorLake.Vulkan;

public class VkVideoCapabilitiesKHRHandle : BaseSafeHandle
{
}


public static class VkVideoCapabilitiesKHRExtensions
{

	public static VkVideoCapabilitiesKHR Dereference(this VkVideoCapabilitiesKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoCapabilitiesKHR>(x.DangerousGetHandle());
}
internal class VkVideoCapabilitiesKHRExterns
{
}

public struct VkVideoCapabilitiesKHR
{
}
