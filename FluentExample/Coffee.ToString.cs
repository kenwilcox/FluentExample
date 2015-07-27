using System.Linq;
using System.Reflection;

namespace FluentExample
{
    public partial class Coffee
    {
        public override string ToString()
        {
            var ret = "";
            var propInfo = GetType().GetProperties(BindingFlags.Instance | BindingFlags.Public);
            foreach (var prop in propInfo.Where(prop => !prop.Name.StartsWith("Raw")))
            {
	            if (ret.Length > 0)
		            ret += string.Format(" - {0}: {1}", prop.Name, prop.GetValue(this));
	            else
		            ret += string.Format("{0}: {1}", prop.Name, prop.GetValue(this));
            }
            return ret;
        }
    }
}
