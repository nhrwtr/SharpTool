using System;

namespace SharpTool.Factory
{
    /// <summary>
    /// globally unique identifier (GUID) genetrate class.
    /// </summary>
    public class GuidFactory
    {
        /// <summary>
        /// Generates a <see cref="Guid"/> and returns it as a <see cref="Guid"/> structure.
        /// </summary>
        /// <returns><see cref="Guid"/> structure</returns>
        public static Guid Generate()
        {
            Guid guid = Guid.NewGuid();
            return guid;
        }

        /// <summary>
        /// Generates a <see cref="Guid"/>, converts it to a string, and returns it.
        /// </summary>
        /// <returns>converted string GUID</returns>
        public static string GenerateLabel()
        {
            string guid = Generate().ToString();
            return guid;
        }
    }
}
