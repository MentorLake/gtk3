namespace MentorLake.Vulkan;

public class VkDriverIdKHRHandle : BaseSafeHandle
{
}


public static class VkDriverIdKHRExtensions
{

	public static VkDriverIdKHR Dereference(this VkDriverIdKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkDriverIdKHR>(x.DangerousGetHandle());
}
internal class VkDriverIdKHRExterns
{
}

public struct VkDriverIdKHR
{
}
