using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomBuild
{
    public static class BuildCreator
    {
        public static HashSet<Build> AllBuilds;
        public static Build CreateBuld()
        {
            return new Build();
        }
        public static void Delete(Build build)
        {
            foreach (Build builds in AllBuilds)
            {
                if (build == builds)
                    AllBuilds.Remove(build);
            }
        }
    }
}
