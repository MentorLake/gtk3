namespace MentorLake.Vulkan;


public class VkVideoSessionParametersUpdateInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoSessionParametersUpdateInfoKHRExtensions
{

	public static VkVideoSessionParametersUpdateInfoKHR Dereference(this VkVideoSessionParametersUpdateInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoSessionParametersUpdateInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoSessionParametersUpdateInfoKHRExterns
{
}


public struct VkVideoSessionParametersUpdateInfoKHR
{
}
