namespace MentorLake.Vulkan;


public class VkVideoPictureResourceInfoKHRHandle : BaseSafeHandle
{
}


public static class VkVideoPictureResourceInfoKHRExtensions
{

	public static VkVideoPictureResourceInfoKHR Dereference(this VkVideoPictureResourceInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkVideoPictureResourceInfoKHR>(x.DangerousGetHandle());
}
internal class VkVideoPictureResourceInfoKHRExterns
{
}


public struct VkVideoPictureResourceInfoKHR
{
}
