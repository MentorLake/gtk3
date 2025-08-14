namespace MentorLake.Vulkan;


public class VkCalibratedTimestampInfoKHRHandle : BaseSafeHandle
{
}


public static class VkCalibratedTimestampInfoKHRExtensions
{

	public static VkCalibratedTimestampInfoKHR Dereference(this VkCalibratedTimestampInfoKHRHandle x) => System.Runtime.InteropServices.Marshal.PtrToStructure<VkCalibratedTimestampInfoKHR>(x.DangerousGetHandle());
}
internal class VkCalibratedTimestampInfoKHRExterns
{
}


public struct VkCalibratedTimestampInfoKHR
{
}
