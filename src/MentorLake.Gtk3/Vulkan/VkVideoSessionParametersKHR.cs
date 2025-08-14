namespace MentorLake.Vulkan;


public class VkVideoSessionParametersKHRHandle : BaseSafeHandle
{
}


public static class VkVideoSessionParametersKHRExtensions
{

	public static VkVideoSessionParametersKHR Dereference(this VkVideoSessionParametersKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoSessionParametersKHR>(x.DangerousGetHandle());
}
internal class VkVideoSessionParametersKHRExterns
{
}


public struct VkVideoSessionParametersKHR
{
}
